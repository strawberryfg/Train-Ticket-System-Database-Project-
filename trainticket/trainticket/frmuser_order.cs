using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Net;
using System.Net.Security;
using System.Security.Authentication;
using System.Security.Cryptography.X509Certificates;
using System.Data.SqlClient;
namespace trainticket
{

    public partial class frmuser_order : Form
    {
        ListViewItem it,itdone;
        SqlConnection myConn = new SqlConnection("Server=localhost;Integrated security=SSPI;database=master");
        int slt = -1;
        int sltdone = -1;
        int flag = 0;
        public frmuser_main f1;
        public frmuser_order()
        {
            SqlDataReader readit;
            try
            {
                InitializeComponent();
                try
                {
                    myConn.Open();
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "MyProgram", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                it = lstorder.Items[0];
                itdone = lstorderdone.Items[0];
                lstorder.Items.Clear();
                lstorderdone.Items.Clear();
                ImageList imageList = new ImageList();   //设置行高20
                imageList.ImageSize = new System.Drawing.Size(1, 30);   //分别是宽和高            
                lstorder.SmallImageList = imageList;
                lstorderdone.SmallImageList = imageList;               
                flag = 1;
            }
            catch(System.Exception err)
            {                
                return;
            }
            
        }


        public class ListViewHelper
        {
            public ListViewHelper()
            {

            }

            public static void ListView_ColumnClick(object sender, ColumnClickEventArgs e)
            {
                ListView lv = sender as ListView;
                if (e.Column == (lv.ListViewItemSorter as ListViewColumnSorter).SortColumn)
                {
                    if ((lv.ListViewItemSorter as ListViewColumnSorter).Order == System.Windows.Forms.SortOrder.Ascending)
                    {
                        (lv.ListViewItemSorter as ListViewColumnSorter).Order = System.Windows.Forms.SortOrder.Descending;
                    }
                    else
                    {
                        (lv.ListViewItemSorter as ListViewColumnSorter).Order = System.Windows.Forms.SortOrder.Ascending;
                    }
                }
                else
                {
                    (lv.ListViewItemSorter as ListViewColumnSorter).SortColumn = e.Column;
                    (lv.ListViewItemSorter as ListViewColumnSorter).Order = System.Windows.Forms.SortOrder.Ascending;
                }
                ((ListView)sender).Sort();
            }
        }

        public class ListViewColumnSorter : IComparer
        {
            private int ColumnToSort;
            private System.Windows.Forms.SortOrder OrderOfSort;
            private CaseInsensitiveComparer ObjectCompare;

            public ListViewColumnSorter()
            {
                ColumnToSort = 0;
                OrderOfSort = System.Windows.Forms.SortOrder.None;
                ObjectCompare = new CaseInsensitiveComparer();
            }
            public int Compare(object x, object y)
            {
                int compareResult;
                ListViewItem listviewX, listviewY;
                listviewX = (ListViewItem)x;
                listviewY = (ListViewItem)y;
                compareResult = ObjectCompare.Compare(listviewX.SubItems[ColumnToSort].Text, listviewY.SubItems[ColumnToSort].Text);
                if (OrderOfSort == System.Windows.Forms.SortOrder.Ascending)
                {
                    return compareResult;
                }
                else if (OrderOfSort == System.Windows.Forms.SortOrder.Descending)
                {
                    return (-compareResult);
                }
                else
                {
                    return 0;
                }
            }
            public int SortColumn
            {
                set
                {
                    ColumnToSort = value;
                }
                get
                {
                    return ColumnToSort;
                }
            }

            public System.Windows.Forms.SortOrder Order
            {
                set
                {
                    OrderOfSort = value;
                }
                get
                {
                    return OrderOfSort;
                }
            }
        }
        private string handle(string s1)
        {
            return s1.Substring(0, 4) + s1.Substring(5, 2) + s1.Substring(8, 2);
        }

        private void btnpay_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (slt == -1) return;
                if (lstorder.Items[slt].BackColor==Color.FromArgb(224,224,224)) //not enabled
                {
                    MessageBox.Show("已过支付时间！", "错误提示",MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                DialogResult rslt = MessageBox.Show(Owner, "确认支付"+lstorder.Items[slt].SubItems[8].Text+"？", "确认", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (rslt == DialogResult.No) return;               
                ListViewItem lvidlt = (ListViewItem)lstorder.Items[slt];

                DateTime nowtime = DateTime.Now;
                DateTime start = Convert.ToDateTime(lvidlt.SubItems[0].Text);
                TimeSpan ts1 = new TimeSpan(nowtime.Ticks);
                TimeSpan ts2 = new TimeSpan(start.Ticks); //starttime-nowtime   ts2-ts1
                TimeSpan diff = ts1.Subtract(ts2).Duration();
                

                string dlt = "delete from dbo.allorder where trainno='" + lvidlt.SubItems[1].Text +
                    "' and person='" + lvidlt.SubItems[4].Text + "' and fromstation='" + lvidlt.SubItems[2].Text +
                     "' and tostation='" + lvidlt.SubItems[3].Text +
                     "' and carno='" + lvidlt.SubItems[5].Text + "' and seatno='" + lvidlt.SubItems[6].Text + "' and userid='" + txtuserid.Text + "'"; //it must be that person id
                SqlCommand cmd = new SqlCommand(dlt, myConn);
                cmd.ExecuteNonQuery();
                lstorder.Items.RemoveAt(slt);
                if (ts1 > ts2)
                {
                    MessageBox.Show("火车已开出站台，禁止支付", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }//no pay
                string ins="insert into dbo.orderdone values('"+
                    lvidlt.SubItems[0].Text+"','"+lvidlt.SubItems[1].Text+"','"+lvidlt.SubItems[2].Text+"','"+lvidlt.SubItems[3].Text+"','"+lvidlt.SubItems[4].Text+
                    "','"+lvidlt.SubItems[5].Text+"','"+lvidlt.SubItems[6].Text+"','"+lvidlt.SubItems[7].Text+"','"+lvidlt.SubItems[8].Text+"','"+lvidlt.SubItems[9].Text+"',0,"+
                    "'" + nowtime.Year + "-" + (nowtime.Month).ToString().PadLeft(2, '0') + "-" + (nowtime.Day).ToString().PadLeft(2, '0') + " " + (nowtime.Hour).ToString().PadLeft(2, '0') + ":" + (nowtime.Minute).ToString().PadLeft(2, '0') + "','"+txtuserid.Text+"')";
                cmd = new SqlCommand(ins, myConn);
                cmd.ExecuteNonQuery();
            }
            catch(System.Exception err)
            {
                return;
            }
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                SqlConnection myConn = new SqlConnection("Server=localhost;Integrated security=SSPI;database=master");
                try
                {
                    myConn.Open();
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "MyProgram", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                string sqlcrt;
                SqlCommand cmd;
                sqlcrt = "create table " + "allorder" +
                                    "(starttime varchar(30)," +
                                    "trainno varchar(15)," +
                                    "fromstation varchar(15)," +
                                    "tostation varchar(15)," +
                                    "person varchar(15)," +
                                    "carno varchar(15)," +
                                    "seatno varchar(15)," +
                                    "seattype varchar(15)," +
                                    "price varchar(15)," +
                                    "orderno varchar(15),"+
                                    "ordertime varchar(30),"+
                                    "userid varchar(30))";
                cmd = new SqlCommand(sqlcrt, myConn);
                cmd.ExecuteNonQuery();
                sqlcrt = "create table " + "orderdone" +
                        "(starttime varchar(30)," +
                        "trainno varchar(15)," +
                        "fromstation varchar(15)," +
                        "tostation varchar(15)," +
                        "person varchar(15)," +
                        "carno varchar(15)," +
                        "seatno varchar(15)," +
                        "seattype varchar(15)," +
                        "price varchar(15)," +
                        "orderno varchar(15),"+
                        "ischanged int,"+
                        "finishtime varchar(30),"+
                        "userid varchar(30))";                
                cmd = new SqlCommand(sqlcrt, myConn);
                cmd.ExecuteNonQuery();   
            }
            catch(System.Exception err)
            {
                return;
            }            
        }

        private void chkfromtotime_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (chkfromtotime.Checked == true)
                {
                    lblstarttime1.Enabled = lbland.Enabled = lblwithin.Enabled = datetimepicker1.Enabled = datetimepicker2.Enabled = true;
                }
                else
                {
                    lblstarttime1.Enabled = lbland.Enabled = lblwithin.Enabled = datetimepicker1.Enabled = datetimepicker2.Enabled = false;
                }
                btnquery_Click(sender, e);
            }
            catch(System.Exception err)
            {
                return;
            }
        }

        private void chkfromtostation_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (chkfromtostation.Checked == true)
                {
                    lblfrom.Enabled = lblto.Enabled = txtfrom.Enabled = txtto.Enabled = true;
                }
                else
                {
                    lblfrom.Enabled = lblto.Enabled = txtfrom.Enabled = txtto.Enabled = false;
                }
                btnquery_Click(sender, e);
            }
            catch(System.Exception err)
            {
                return;
            }            
        }

        private void lstorderdone_DrawSubItem(object sender, DrawListViewSubItemEventArgs e)
        {
            try
            {
                e.DrawBackground();
                e.DrawText();
                e.DrawFocusRectangle(e.Bounds);
            }
            catch(System.Exception err)
            {
                return;
            }
        }

        private void lstorderdone_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
        {
            try
            {
                e.DrawBackground();
                e.DrawText();
            }
            catch(System.Exception err)
            {
                return;
            }
        }

        private void btnquery_Click(object sender, EventArgs e)
        {
            try
            {
                string search = "";
                string year1 = datetimepicker1.Value.Year.ToString();
                string year2 = datetimepicker1.Value.Year.ToString();
                string month1 = datetimepicker1.Value.Month.ToString().PadLeft(2, '0');
                string month2 = datetimepicker2.Value.Month.ToString().PadLeft(2, '0');
                string day1 = datetimepicker1.Value.Day.ToString().PadLeft(2, '0');
                string day2 = datetimepicker2.Value.Day.ToString().PadLeft(2, '0');
                string cat1 = year1 + month1 + day1;
                string cat2 = year2 + month2 + day2;
                lstorderdone.Items.Clear();
                if (chkfromtotime.Checked == true && chkfromtostation.Checked == true)
                {
                    search = "select * from dbo.orderdone" + " where (starttime between '" + cat1 + "' and '" + cat2 + "') and fromstation='" + txtfrom.Text + "' and tostation='" + txtto.Text +"' and userid='"+txtuserid.Text+ "'";
                }
                else if (chkfromtotime.Checked==true && chkfromtostation.Checked==false)
                {
                    search = "select * from dbo.orderdone" + " where (starttime between '" + cat1 + "' and '" + cat2 + "')"+" and userid='"+txtuserid.Text+"'";
                }
                else if (chkfromtotime.Checked==false && chkfromtostation.Checked==true)
                {
                    search = "select * from dbo.orderdone" + " where fromstation='" + txtfrom.Text + "' and tostation='" + txtto.Text + "' and userid='" + txtuserid.Text + "'";
                }
                else
                {
                    search = "select * from dbo.orderdone"+" where userid='"+txtuserid.Text+"'";
                }
                SqlCommand cmd = new SqlCommand(search, myConn);
                SqlDataReader readit = cmd.ExecuteReader();
                if (readit.HasRows)
                {
                    while (readit.Read())
                    {
                        ListViewItem lvi = (ListViewItem)itdone.Clone();
                        for (int i = 0; i < 10; i++) lvi.SubItems[i].Text =(string)readit[i];
                        lvi.SubItems[10].Text = ((int)readit[10]).ToString();
                        lvi.SubItems[11].Text = (string)readit[11];
                        if ((int)readit[10]==1) //ischanged  已改签
                        {
                            for (int i = 0; i < 12; i++) lvi.SubItems[i].BackColor = Color.FromArgb(224, 224, 224);
                        }
                        lstorderdone.Items.Add(lvi);
                    }
                }
                readit.Close();
            }
            catch(System.Exception err)
            {
                return;
            }           
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            try
            {
                if (slt == -1) return;
                DialogResult rslt=MessageBox.Show("是否确认取消订单","确认取消",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if (rslt == DialogResult.No) return;
                ListViewItem lvidlt=(ListViewItem)lstorder.Items[slt];
                string dlt = "delete from dbo.allorder where trainno='" + lvidlt.SubItems[1].Text +
                    "' and person='" + lvidlt.SubItems[4].Text + "' and fromstation='" + lvidlt.SubItems[2].Text + 
                     "' and tostation='" + lvidlt.SubItems[3].Text +
                    "' and carno='" + lvidlt.SubItems[5].Text + "' and seatno='" + lvidlt.SubItems[6].Text + "' and userid='" + txtuserid.Text + "'";
                SqlCommand cmd = new SqlCommand(dlt,myConn);
                cmd.ExecuteNonQuery();
                lstorder.Items.RemoveAt(slt);

                dlt = "delete from " + lvidlt.SubItems[1].Text+handle(lvidlt.SubItems[0].Text.Substring(0, 10))  +" where name='" + lvidlt.SubItems[4].Text + "'";
                cmd = new SqlCommand(dlt, myConn);
                cmd.ExecuteNonQuery();
            }
            catch(System.Exception err)
            {
                return;
            }
        }

        private void lstorder_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                slt = lstorder.SelectedIndices[0];
            }
            catch(System.Exception err)
            {
                return;
            }            
        }

        private void btntui_Click(object sender, EventArgs e)
        {
            try
            {
                if (sltdone == -1) return;
                ListViewItem lvidlt = (ListViewItem)lstorderdone.Items[sltdone];
                DialogResult confirm = MessageBox.Show("是否确认退票？","确认退票", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirm==DialogResult.No)
                {
                    return;
                }
                DateTime nowtime = DateTime.Now;
                DateTime starttime = Convert.ToDateTime(lvidlt.SubItems[0].Text);
                TimeSpan ts1 = new TimeSpan(nowtime.Ticks);
                TimeSpan ts2 = new TimeSpan(starttime.Ticks); //starttime-nowtime   ts2-ts1
                TimeSpan diff = ts1.Subtract(ts2).Duration();
                if (ts1>ts2)
                {
                    MessageBox.Show("该火车已开出站台，不能退票", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (diff.TotalSeconds<=1800.0)
                {
                    MessageBox.Show("开车前半小时内不能网上退票，请到站台办理退票手续", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (diff.Days>=15)
                {
                    MessageBox.Show("在开车前15天退票，不收取手续费！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);                    
                }
                else if (diff.Days>=2)
                {
                    string price = lvidlt.SubItems[8].Text;
                    price = price.Substring(1, price.Length - 1);
                    double needprice = Convert.ToDouble(price) * 0.05;
                    DialogResult pay = MessageBox.Show("在开车前退票提前48小时以上的，按照原票价的5%核收手续费。原票价￥" + price + "，需要支付￥" + needprice.ToString() + "，是否确认支付？", "确认支付",MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (pay == DialogResult.No) return; //no pay
                }
                else if (diff.Days>=1)
                {
                    string price = lvidlt.SubItems[8].Text;
                    price = price.Substring(1, price.Length - 1);
                    double needprice = Convert.ToDouble(price) * 0.10;
                    DialogResult pay = MessageBox.Show("在开车前退票提前24小时以上48小时以内的，按照原票价的10%核收手续费。原票价￥" + price + "，需要支付￥" + needprice.ToString() + "，是否确认支付？", "确认支付", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (pay == DialogResult.No) return; //no pay
                }
                else
                {
                    string price = lvidlt.SubItems[8].Text;
                    price = price.Substring(1, price.Length - 1);
                    double needprice = Convert.ToDouble(price) * 0.20;
                    DialogResult pay = MessageBox.Show("在开车前退票提前不足24小时的，按照原票价的20%核收手续费。原票价￥" + price + "，需要支付￥" + needprice.ToString() + "，是否确认支付？", "确认支付", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (pay == DialogResult.No) return; //no pay
                }
                string dlt = "delete from dbo.orderdone where trainno='" + lvidlt.SubItems[1].Text +
                    "' and person='" + lvidlt.SubItems[4].Text + "' and fromstation='" + lvidlt.SubItems[2].Text +
                     "' and tostation='" + lvidlt.SubItems[3].Text +
                    "' and carno='" + lvidlt.SubItems[5].Text + "' and seatno='" + lvidlt.SubItems[6].Text + "' and userid='"+txtuserid.Text+"'";
                SqlCommand cmd = new SqlCommand(dlt, myConn);
                cmd.ExecuteNonQuery();
                lstorderdone.Items.RemoveAt(sltdone);

                dlt = "delete from " + lvidlt.SubItems[1].Text + handle(lvidlt.SubItems[0].Text.Substring(0, 10)) + " where name='" + lvidlt.SubItems[4].Text + "'";
                cmd = new SqlCommand(dlt, myConn);
                cmd.ExecuteNonQuery();

                btnquery_Click(sender, e);
            }
            catch(System.Exception err)
            {
                return;
            }
        }

        private void lstorderdone_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                sltdone = lstorderdone.SelectedIndices[0];
                txtfinishit.Text = lstorderdone.Items[sltdone].SubItems[11].Text;
            }
            catch (System.Exception err)
            {
                return;
            }  
            
        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            if (e.TabPage==tabPage2)
            {                
                btnquery_Click(sender, e);
            }
        }

        private void btnchange_Click(object sender, EventArgs e)
        {
            try
            {
                if (sltdone == -1) return;
                if (lstorderdone.Items[sltdone].SubItems[0].BackColor==Color.FromArgb(224,224,224))
                {
                    MessageBox.Show("不能第二次改签！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                ListViewItem lvi = lstorderdone.Items[sltdone];
                frmuser_online f = new frmuser_online();
                f.btnbuy.Enabled = false;
                f.btnchange.Enabled = true;
                f.btnquery.Enabled = true;
                f.txtsrc.Text = lvi.SubItems[2].Text;
                f.txtdst.Text = lvi.SubItems[3].Text;
                f.txtsrc.ReadOnly = true;
                f.txtdst.ReadOnly = true;
                f.label00.Text = lvi.SubItems[0].Text;
                f.label01.Text = lvi.SubItems[1].Text;
                f.label02.Text = lvi.SubItems[2].Text;
                f.label03.Text = lvi.SubItems[3].Text;
                f.label04.Text = lvi.SubItems[4].Text;
                f.label05.Text = lvi.SubItems[5].Text;
                f.label06.Text = lvi.SubItems[6].Text;
                f.label07.Text = lvi.SubItems[7].Text;
                f.label08.Text = lvi.SubItems[8].Text;
                f.label09.Text = lvi.SubItems[9].Text;
                f.txtprice.Text = f.label08.Text;
                f.txtseattype.Text = f.label07.Text;
                //f.txtprice.Visible = true;
                f.txtseatno.Visible = false;
                f.txtseattype.Visible = false;
                f.txtcarno.Visible = false;
                f.txtuserid.Text = txtuserid.Text;
                f.txtusername.Text = txtusername.Text;
                f.f2 = this;
                f.Show();
            }
            catch(System.Exception err)
            {
                return;
            }
            
            
        }

        private void frmuserorder_Activated(object sender, EventArgs e)
        {
            try
            {                
                lstorder.Items.Clear();
                if (flag == 0) return;
                string search = "select  * from dbo.allorder where userid='" + txtuserid.Text +"'";
                SqlCommand cmd = new SqlCommand(search, myConn);
                SqlDataReader readit = cmd.ExecuteReader();
                if (readit.HasRows)
                {
                    while (readit.Read())
                    {
                        ListViewItem lvi = (ListViewItem)it.Clone();
                        for (int i = 0; i < 11; i++) lvi.SubItems[i].Text = readit[i].ToString();
                        
                        lstorder.Items.Add(lvi);
                    }
                }
                readit.Close();
            }
            catch(System.Exception err)
            {
                return;
            }
            btnquery_Click(sender, e);
        }

        private void datetimepicker1_ValueChanged(object sender, EventArgs e)
        {
            btnquery_Click(sender, e);
        }

        private void datetimepicker2_ValueChanged(object sender, EventArgs e)
        {
            btnquery_Click(sender, e);
        }

        private void txtfrom_TextChanged(object sender, EventArgs e)
        {
            btnquery_Click(sender, e);
        }

        private void txtto_TextChanged(object sender, EventArgs e)
        {
            btnquery_Click(sender, e);
        }

        private void tmr_Tick(object sender, EventArgs e)
        {
            try
            {                
                DateTime nowtime, start;
                TimeSpan ts1, ts2, diff;
                for (int i = 0; i < lstorder.Items.Count;i++ )
                {
                    if (lstorder.Items[i].BackColor == Color.FromArgb(224, 224, 224)) continue; //already set gray;
                    nowtime = DateTime.Now;
                    
                    start = Convert.ToDateTime(lstorder.Items[i].SubItems[10].Text);
                    ts1 = new TimeSpan(nowtime.Ticks);
                    ts2 = new TimeSpan(start.Ticks); //nowtime-start   ts1-ts2  should be >=0 <=30
                    diff = ts2.Subtract(ts1).Duration();
                    if (diff.TotalSeconds > 1800)
                    {
        
                        ListViewItem lvidlt = (ListViewItem)lstorder.Items[i];
                        string dlt = "delete from dbo.allorder where trainno='" + lvidlt.SubItems[1].Text +
                            "' and person='" + lvidlt.SubItems[4].Text + "' and fromstation='" + lvidlt.SubItems[2].Text +
                             "' and tostation='" + lvidlt.SubItems[3].Text +
                            "' and carno='" + lvidlt.SubItems[5].Text + "' and seatno='" + lvidlt.SubItems[6].Text + "' and userid='" + txtuserid.Text + "'";
                        SqlCommand cmd = new SqlCommand(dlt, myConn);
                        cmd.ExecuteNonQuery();


                        dlt = "delete from " + lvidlt.SubItems[1].Text + handle(lvidlt.SubItems[0].Text.Substring(0, 10)) + " where name='" + lvidlt.SubItems[4].Text + "'";
                        cmd = new SqlCommand(dlt, myConn);
                        cmd.ExecuteNonQuery();
                        for (int j = 0; j < 11;j++ )  lstorder.Items[i].SubItems[j].BackColor = Color.FromArgb(224, 224, 224);
                    }
                }
                if (slt == -1) return;
                txtbuyit.Text = lstorder.Items[slt].SubItems[10].Text;
                nowtime = DateTime.Now;
                start = Convert.ToDateTime(txtbuyit.Text);
                ts1 = new TimeSpan(nowtime.Ticks);
                ts2 = new TimeSpan(start.Ticks); //nowtime-start   ts1-ts2  should be >=0 <=30
                diff = ts2.Subtract(ts1).Duration();
                if (diff.TotalSeconds>1800)
                {
                    txtdaojishi.Text = "超过支付时间";
                    return;
                }
                int daojishi=Convert.ToInt32(1800.0-diff.TotalSeconds);
                txtdaojishi.Text = "00:" + (daojishi / 60).ToString().PadLeft(2,'0') + ":" + (daojishi % 60).ToString().PadLeft(2,'0');
            }
            catch(System.Exception err)
            {
                return;
            }
        }

        private void frmuserorder_Load(object sender, EventArgs e)
        {
            this.lstorder.ListViewItemSorter = new ListViewColumnSorter();
            this.lstorder.ColumnClick += new ColumnClickEventHandler(ListViewHelper.ListView_ColumnClick);
            this.lstorderdone.ListViewItemSorter = new ListViewColumnSorter();
            this.lstorderdone.ColumnClick += new ColumnClickEventHandler(ListViewHelper.ListView_ColumnClick);
            this.Text = this.Text + " - " + txtusername.Text + "(" + txtuserid.Text + ")";
        }

        private void frmuserorder_FormClosed(object sender, FormClosedEventArgs e)
        {
            //f1.Show();
        }

        private void picpay_Click(object sender, EventArgs e)
        {
            btnpay_Click(sender, e);
        }

        private void picancel_Click(object sender, EventArgs e)
        {
            btncancel_Click(sender, e);
        }

        private void tabPage1_MouseMove(object sender, MouseEventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void tabControl1_MouseMove(object sender, MouseEventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void picpay_MouseMove(object sender, MouseEventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void picancel_MouseMove(object sender, MouseEventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void picquery_Click(object sender, EventArgs e)
        {
            btnquery_Click(sender, e);
        }

        private void picquit_Click(object sender, EventArgs e)
        {
            btntui_Click(sender, e);
        }

        private void picchange_Click(object sender, EventArgs e)
        {
            btnchange_Click(sender, e);
        }

        private void tabPage2_MouseMove(object sender, MouseEventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void picquery_MouseMove(object sender, MouseEventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void picquit_MouseMove(object sender, MouseEventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void picchange_MouseMove(object sender, MouseEventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }
    }
}
