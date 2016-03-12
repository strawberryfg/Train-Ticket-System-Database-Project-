using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace trainticket
{
    public partial class frmuser_choose : Form
    {
        SqlConnection myConn;
        public frmuser_choose()
        {
            InitializeComponent();
            myConn = new SqlConnection("Server=localhost;Integrated security=SSPI;database=master");
            try
            {
                myConn.Open();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.ToString(), "MyProgram", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public string trainid;
        public string userid;
        string person;
        public string starttime;
        public string trainno;
        public string fromstation;
        public string tostation;
        string seatno;
        string seattypenow;
        public string[] price=new string[10];
        public string traindate;
        public bool isbuy;
        string[] allcontact = new string[1111111];
        string orderno = "E";
        int car, seat;
        int p;
        int cnt = 0;
        public string l00;
        public string l01;
        public string l08;
        public string l04;
        String[] seattype = { "商务座",  "一等座", "二等座", "高级软卧", "软卧", "硬卧", "软座", "硬座", "无座" };


        private void update()
        {
            try
            {
                PictureBox[] pic = { pictureBox1,pictureBox2,pictureBox3,pictureBox4,pictureBox5,pictureBox6,pictureBox7,pictureBox8,pictureBox9,pictureBox10,
                                 pictureBox11,pictureBox12,pictureBox13,pictureBox14,pictureBox15,pictureBox16,pictureBox17,pictureBox18,pictureBox19,pictureBox20,
                                 pictureBox21,pictureBox22,pictureBox23,pictureBox24,pictureBox25,pictureBox26,pictureBox27,pictureBox28,pictureBox29,pictureBox30,
                                 pictureBox31,pictureBox32,pictureBox33,pictureBox34,pictureBox35,pictureBox36,pictureBox37,pictureBox38,pictureBox39,pictureBox40,
                                 pictureBox41,pictureBox42,pictureBox43,pictureBox44,pictureBox45,pictureBox46,pictureBox47,pictureBox48,pictureBox49,pictureBox50,
                                 pictureBox51,pictureBox52,pictureBox53,pictureBox54,pictureBox55,pictureBox56,pictureBox57,pictureBox58,pictureBox59,pictureBox60,
                                 pictureBox61,pictureBox62,pictureBox63,pictureBox64,pictureBox65,pictureBox66,pictureBox67,pictureBox68,pictureBox69,pictureBox70,
                                 pictureBox71,pictureBox72,pictureBox73,pictureBox74,pictureBox75,pictureBox76,pictureBox77,pictureBox78,pictureBox79,pictureBox80,
                                 pictureBox81,pictureBox82,pictureBox83,pictureBox84,pictureBox85,pictureBox86,pictureBox87,pictureBox88,pictureBox89,pictureBox90,
                                 pictureBox91,pictureBox92,pictureBox93,pictureBox94,pictureBox95,pictureBox96,pictureBox97,pictureBox98,pictureBox99,pictureBox100,
                                 pictureBox101,pictureBox102,pictureBox103,pictureBox104,pictureBox105,pictureBox106,pictureBox107,pictureBox108,pictureBox109,pictureBox110,
                                 pictureBox111,pictureBox112,pictureBox113,pictureBox114,pictureBox115,pictureBox116,pictureBox117,pictureBox118,pictureBox119,pictureBox120,
                                 pictureBox121,pictureBox122,pictureBox123,pictureBox124,pictureBox125,pictureBox126,pictureBox127,pictureBox128,pictureBox129,pictureBox130,
                                 pictureBox131,pictureBox132,pictureBox133,pictureBox134, };
                SqlCommand cmd;
                SqlDataReader readit;
                string sqlcrt = "select seat from " + trainid + handle(traindate);
                cmd = new SqlCommand(sqlcrt, myConn);
                readit = cmd.ExecuteReader();
                while (readit.Read())
                {
                    pic[(int)readit[0]].Image = Properties.Resources.ooo;
                }
                readit.Close();

                sel = -1;
            }
            catch(System.Exception err)
            {
                MessageBox.Show("未知错误！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            
        }
        private  string handle(string s1)
        {
            return s1.Substring(0,4)+s1.Substring(5,2)+s1.Substring(8,2);
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }


        private void frmuser_choose_MouseMove(object sender, MouseEventArgs e)
        {
            this.Cursor = Cursors.Default;
            picbuy.Image = Properties.Resources.yuding;
            picchange.Image = Properties.Resources.change2;
        }
        int sel=-1;
    
        private void pic_Click(object sender,EventArgs e)
        {
            try
            {
                PictureBox[] pic = { pictureBox1,pictureBox2,pictureBox3,pictureBox4,pictureBox5,pictureBox6,pictureBox7,pictureBox8,pictureBox9,pictureBox10,
                                 pictureBox11,pictureBox12,pictureBox13,pictureBox14,pictureBox15,pictureBox16,pictureBox17,pictureBox18,pictureBox19,pictureBox20,
                                 pictureBox21,pictureBox22,pictureBox23,pictureBox24,pictureBox25,pictureBox26,pictureBox27,pictureBox28,pictureBox29,pictureBox30,
                                 pictureBox31,pictureBox32,pictureBox33,pictureBox34,pictureBox35,pictureBox36,pictureBox37,pictureBox38,pictureBox39,pictureBox40,
                                 pictureBox41,pictureBox42,pictureBox43,pictureBox44,pictureBox45,pictureBox46,pictureBox47,pictureBox48,pictureBox49,pictureBox50,
                                 pictureBox51,pictureBox52,pictureBox53,pictureBox54,pictureBox55,pictureBox56,pictureBox57,pictureBox58,pictureBox59,pictureBox60,
                                 pictureBox61,pictureBox62,pictureBox63,pictureBox64,pictureBox65,pictureBox66,pictureBox67,pictureBox68,pictureBox69,pictureBox70,
                                 pictureBox71,pictureBox72,pictureBox73,pictureBox74,pictureBox75,pictureBox76,pictureBox77,pictureBox78,pictureBox79,pictureBox80,
                                 pictureBox81,pictureBox82,pictureBox83,pictureBox84,pictureBox85,pictureBox86,pictureBox87,pictureBox88,pictureBox89,pictureBox90,
                                 pictureBox91,pictureBox92,pictureBox93,pictureBox94,pictureBox95,pictureBox96,pictureBox97,pictureBox98,pictureBox99,pictureBox100,
                                 pictureBox101,pictureBox102,pictureBox103,pictureBox104,pictureBox105,pictureBox106,pictureBox107,pictureBox108,pictureBox109,pictureBox110,
                                 pictureBox111,pictureBox112,pictureBox113,pictureBox114,pictureBox115,pictureBox116,pictureBox117,pictureBox118,pictureBox119,pictureBox120,
                                 pictureBox121,pictureBox122,pictureBox123,pictureBox124,pictureBox125,pictureBox126,pictureBox127,pictureBox128,pictureBox129,pictureBox130,
                                 pictureBox131,pictureBox132,pictureBox133,pictureBox134, };
                for (int i = 0; i < 134; i++)
                {
                    if (sender.Equals(pic[i]) && (pic[i].Image == null || i == sel))
                    {
                        if (pic[i].Image == null) pic[i].Image = Properties.Resources.ooo;
                        else pic[i].Image = null;
                        if (sel >= 0 && sel != i)
                            if (pic[sel].Image == null) pic[sel].Image = Properties.Resources.ooo;
                            else pic[sel].Image = null;
                        if (sel == i) sel = -1;
                        else sel = i;
                        if (i < 15)
                        {
                            car = 0; seat = i; seatno = (seat / 3 + 1).ToString() + Convert.ToChar('A' + seat % 3);
                        }
                        else if (i < 35)
                        {
                            car = 1; seat = i - 15; seatno = (seat / 4 + 1).ToString() + Convert.ToChar('A' + seat % 4);
                        }
                        else if (i < 60)
                        {
                            car = 2; seat = i - 35; seatno = (seat / 5 + 1).ToString() + Convert.ToChar('A' + seat % 5);
                        }
                        else if (i < 64)
                        {
                            car = 3; seat = i - 60; seatno = (seat / 2 + 1).ToString() + Convert.ToChar('A' + seat % 2);
                        }
                        else if (i < 72)
                        {
                            car = 4; seat = i - 64; seatno = (seat / 2 + 1).ToString() + Convert.ToChar('A' + seat % 2);
                        }
                        else if (i < 84)
                        {
                            car = 5; seat = i - 72; seatno = (seat / 3 + 1).ToString() + Convert.ToChar('A' + seat % 3);
                        }
                        else if (i < 109)
                        {
                            car = 6; seat = i - 84; seatno = (seat / 5 + 1).ToString() + Convert.ToChar('A' + seat % 5);
                        }
                        else
                        {
                            car = 7; seat = i - 109; seatno = (seat / 5 + 1).ToString() + Convert.ToChar('A' + seat % 5);
                        }
                        seattypenow = seattype[car];
                        p = car;
                        if (p > 0) ++p;
                    }
                }
            }
            catch(System.Exception err)
            {
                MessageBox.Show("未知错误！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            
               
        }

        private void picbuy_Click(object sender, EventArgs e)
        {
            try
            {
                PictureBox[] pic = { pictureBox1,pictureBox2,pictureBox3,pictureBox4,pictureBox5,pictureBox6,pictureBox7,pictureBox8,pictureBox9,pictureBox10,
                                 pictureBox11,pictureBox12,pictureBox13,pictureBox14,pictureBox15,pictureBox16,pictureBox17,pictureBox18,pictureBox19,pictureBox20,
                                 pictureBox21,pictureBox22,pictureBox23,pictureBox24,pictureBox25,pictureBox26,pictureBox27,pictureBox28,pictureBox29,pictureBox30,
                                 pictureBox31,pictureBox32,pictureBox33,pictureBox34,pictureBox35,pictureBox36,pictureBox37,pictureBox38,pictureBox39,pictureBox40,
                                 pictureBox41,pictureBox42,pictureBox43,pictureBox44,pictureBox45,pictureBox46,pictureBox47,pictureBox48,pictureBox49,pictureBox50,
                                 pictureBox51,pictureBox52,pictureBox53,pictureBox54,pictureBox55,pictureBox56,pictureBox57,pictureBox58,pictureBox59,pictureBox60,
                                 pictureBox61,pictureBox62,pictureBox63,pictureBox64,pictureBox65,pictureBox66,pictureBox67,pictureBox68,pictureBox69,pictureBox70,
                                 pictureBox71,pictureBox72,pictureBox73,pictureBox74,pictureBox75,pictureBox76,pictureBox77,pictureBox78,pictureBox79,pictureBox80,
                                 pictureBox81,pictureBox82,pictureBox83,pictureBox84,pictureBox85,pictureBox86,pictureBox87,pictureBox88,pictureBox89,pictureBox90,
                                 pictureBox91,pictureBox92,pictureBox93,pictureBox94,pictureBox95,pictureBox96,pictureBox97,pictureBox98,pictureBox99,pictureBox100,
                                 pictureBox101,pictureBox102,pictureBox103,pictureBox104,pictureBox105,pictureBox106,pictureBox107,pictureBox108,pictureBox109,pictureBox110,
                                 pictureBox111,pictureBox112,pictureBox113,pictureBox114,pictureBox115,pictureBox116,pictureBox117,pictureBox118,pictureBox119,pictureBox120,
                                 pictureBox121,pictureBox122,pictureBox123,pictureBox124,pictureBox125,pictureBox126,pictureBox127,pictureBox128,pictureBox129,pictureBox130,
                                 pictureBox131,pictureBox132,pictureBox133,pictureBox134, };
                if (sel == -1)
                {
                    MessageBox.Show("未选择座位", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string chkalreadyhave = "select COUNT(*) from dbo.allorder where person='" + person + "' and trainno='" + trainno + "'";
                SqlCommand cmd = new SqlCommand(chkalreadyhave, myConn);
                SqlDataReader readit = cmd.ExecuteReader();
                if (readit.Read() && (int)readit[0] != 0)
                {
                    MessageBox.Show("一个人不能再次购买同一车次的车票", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    readit.Close();
                    pic[sel].Image = null;
                    sel = -1;
                    return;
                }
                readit.Close();
                chkalreadyhave = "select COUNT(*) from dbo.orderdone where person='" + person + "' and trainno='" + trainno + "'";
                cmd = new SqlCommand(chkalreadyhave, myConn);
                readit = cmd.ExecuteReader();
                if (readit.Read() && (int)readit[0] != 0)
                {
                    MessageBox.Show("一个人不能再次购买同一车次的车票", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    readit.Close();
                    pic[sel].Image = null;
                    sel = -1;
                    return;
                }
                readit.Close();
                DateTime nowtime = DateTime.Now;

                string insertinto = "insert into allorder values('" + traindate + " " + starttime + "','" + trainno + "','" + fromstation + "','" +
                                   tostation + "','" + person + "','" + car + "','" + seatno + "','" + seattypenow + "','" + price[p] + "','" + orderno +
                                   "','" + nowtime.Year + "-" + (nowtime.Month).ToString().PadLeft(2, '0') + "-" + (nowtime.Day).ToString().PadLeft(2, '0') + " " + (nowtime.Hour).ToString().PadLeft(2, '0') + ":" + (nowtime.Minute).ToString().PadLeft(2, '0') + "','" + userid + "')";
                cmd = new SqlCommand(insertinto, myConn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("购票成功！请在30分钟内去支付界面", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);

                string sqlcrt;
                sqlcrt = "insert into " + trainid + handle(traindate) + " values('" +
                                            person + "','" +
                                            sel + "')";
                cmd = new SqlCommand(sqlcrt, myConn);
                cmd.ExecuteNonQuery();

                ListViewItem lvi = new ListViewItem();
                lvi.Text = cmbcontact.Items[cmbcontact.SelectedIndex].ToString();
                lvi.SubItems.Add(seattype[car]);
                lvi.SubItems.Add(seatno);
                lstshow.Items.Add(lvi);

                sel = -1;

            }
            catch(System.Exception err)
            {
                MessageBox.Show("未知错误！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
          
        }

        private void frmuser_choose_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (myConn.State == ConnectionState.Open)
            {
                myConn.Close();
            }
        }

        private void frmuser_choose_Load(object sender, EventArgs e)
        {
            try
            {
                if (isbuy == true)
                {
                    picbuy.Visible = true;
                    picchange.Visible = false;
                }
                else
                {
                    picbuy.Visible = false;
                    picchange.Visible = true;
                }
                string sqlcrt;
                sqlcrt = "select COUNT(*) from " + "traintable " +
                                                   "where trainid='" + trainid + handle(traindate) + "'";
                SqlCommand cmd = new SqlCommand(sqlcrt, myConn);
                SqlDataReader readit = cmd.ExecuteReader();
                if (readit.Read() && (int)readit[0] != 0)
                {
                    readit.Close();
                }
                else
                {
                    readit.Close();
                    string sql;
                    sql = "insert into " + "traintable values('" +
                                                    trainid + handle(traindate) + "')";
                    cmd = new SqlCommand(sql, myConn);
                    cmd.ExecuteNonQuery();

                    sql = "create table " + trainid + handle(traindate) +
                                          " (name varchar(20) not null," +
                                          "seat integer not null)";
                    cmd = new SqlCommand(sql, myConn);
                    cmd.ExecuteNonQuery();
                }

                update();

                for (int i = 8; i >= 2; --i)
                    if (price[i].Equals("超过范围") || price[i].Equals(""))
                    {
                        tabControl1.TabPages.Remove(tabControl1.TabPages[i - 1]);
                    }

                if (price[0].Equals("超过范围") || price[0].Equals(""))
                {
                    tabControl1.TabPages.Remove(tabControl1.TabPages[0]);
                }

                //------------------------------------

                sqlcrt = "select userid from " + userid;  //get all contacts save to string array
                cmd = new SqlCommand(sqlcrt, myConn);
                readit = cmd.ExecuteReader();

                while (readit.Read())
                {
                    allcontact[cnt++] = (string)readit[0];  //only id
                }
                readit.Close();

                string sqlload;
                for (int j = 0; j < cnt; ++j)
                {
                    sqlload = "select name from usertable where userid='" + allcontact[j] + "'";
                    cmd = new SqlCommand(sqlload, myConn);
                    readit = cmd.ExecuteReader();
                    readit.Read();
                    if (isbuy == true || readit[0].Equals(l04))
                        cmbcontact.Items.Add((string)readit[0]);
                    readit.Close();
                }

                //-----------------

                Random rnd = new Random();
                for (int j = 0; j < 9; j++)
                {
                    orderno = orderno + rnd.Next(0, 9).ToString();
                }

                cmbcontact.SelectedIndex = 0;

                ImageList imageList = new ImageList();   //设置行高20
                imageList.ImageSize = new System.Drawing.Size(1, 40);   //分别是宽和高
                lstshow.SmallImageList = imageList;
            }
            catch(System.Exception err)
            {
                return;
            }
            
            
        }

        private void cmbcontact_SelectedIndexChanged(object sender, EventArgs e)
        {
            person = cmbcontact.Items[cmbcontact.SelectedIndex].ToString(); //id
            //update();
        }

        private void picchange_Click(object sender, EventArgs e)
        {
            try
            {
                PictureBox[] pic = { pictureBox1,pictureBox2,pictureBox3,pictureBox4,pictureBox5,pictureBox6,pictureBox7,pictureBox8,pictureBox9,pictureBox10,
                                 pictureBox11,pictureBox12,pictureBox13,pictureBox14,pictureBox15,pictureBox16,pictureBox17,pictureBox18,pictureBox19,pictureBox20,
                                 pictureBox21,pictureBox22,pictureBox23,pictureBox24,pictureBox25,pictureBox26,pictureBox27,pictureBox28,pictureBox29,pictureBox30,
                                 pictureBox31,pictureBox32,pictureBox33,pictureBox34,pictureBox35,pictureBox36,pictureBox37,pictureBox38,pictureBox39,pictureBox40,
                                 pictureBox41,pictureBox42,pictureBox43,pictureBox44,pictureBox45,pictureBox46,pictureBox47,pictureBox48,pictureBox49,pictureBox50,
                                 pictureBox51,pictureBox52,pictureBox53,pictureBox54,pictureBox55,pictureBox56,pictureBox57,pictureBox58,pictureBox59,pictureBox60,
                                 pictureBox61,pictureBox62,pictureBox63,pictureBox64,pictureBox65,pictureBox66,pictureBox67,pictureBox68,pictureBox69,pictureBox70,
                                 pictureBox71,pictureBox72,pictureBox73,pictureBox74,pictureBox75,pictureBox76,pictureBox77,pictureBox78,pictureBox79,pictureBox80,
                                 pictureBox81,pictureBox82,pictureBox83,pictureBox84,pictureBox85,pictureBox86,pictureBox87,pictureBox88,pictureBox89,pictureBox90,
                                 pictureBox91,pictureBox92,pictureBox93,pictureBox94,pictureBox95,pictureBox96,pictureBox97,pictureBox98,pictureBox99,pictureBox100,
                                 pictureBox101,pictureBox102,pictureBox103,pictureBox104,pictureBox105,pictureBox106,pictureBox107,pictureBox108,pictureBox109,pictureBox110,
                                 pictureBox111,pictureBox112,pictureBox113,pictureBox114,pictureBox115,pictureBox116,pictureBox117,pictureBox118,pictureBox119,pictureBox120,
                                 pictureBox121,pictureBox122,pictureBox123,pictureBox124,pictureBox125,pictureBox126,pictureBox127,pictureBox128,pictureBox129,pictureBox130,
                                 pictureBox131,pictureBox132,pictureBox133,pictureBox134, };
                DateTime nowtime = DateTime.Now;
                double oriprice = Convert.ToDouble(l08.Substring(1, l08.Length - 2));
                double nowprice = Convert.ToDouble(price[p].Substring(1, price[p].Length - 2));
                string msg;
                if (nowprice - oriprice > 0.0) msg = "需要补差价￥" + Convert.ToString(nowprice - oriprice);
                else if (oriprice - nowprice > 0.0) msg = "即将退还给您￥" + Convert.ToString(oriprice - nowprice);
                else msg = "票价不变";
                DialogResult confirm = MessageBox.Show(msg + ",是否确定改签？", "确认", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirm == DialogResult.No)
                {
                    return;
                }
                string upd = "delete orderdone where " +
                           "trainno='" + l01 + "' and person='" + l04 + "'";


                SqlCommand cmd = new SqlCommand(upd, myConn);
                cmd.ExecuteNonQuery();

                //----------------------------------


                if (sel == -1)
                {
                    MessageBox.Show("未选择座位", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string chkalreadyhave = "select COUNT(*) from dbo.allorder where person='" + person + "' and trainno='" + trainno + "'";
                cmd = new SqlCommand(chkalreadyhave, myConn);
                SqlDataReader readit = cmd.ExecuteReader();
                if (readit.Read() && (int)readit[0] != 0)
                {
                    MessageBox.Show("一个人不能再次购买同一车次的车票", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    readit.Close();
                    pic[sel].Image = null;
                    sel = -1;
                    return;
                }
                readit.Close();
                chkalreadyhave = "select COUNT(*) from dbo.orderdone where person='" + person + "' and trainno='" + trainno + "'";
                cmd = new SqlCommand(chkalreadyhave, myConn);
                readit = cmd.ExecuteReader();
                if (readit.Read() && (int)readit[0] != 0)
                {
                    MessageBox.Show("一个人不能再次购买同一车次的车票", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    readit.Close();
                    pic[sel].Image = null;
                    sel = -1;
                    return;
                }
                readit.Close();


                string insertinto = "insert into orderdone values('" + traindate + " " + starttime + "','" + trainno + "','" + fromstation + "','" +
                                   tostation + "','" + person + "','" + car + "','" + seatno + "','" + seattypenow + "','" + price[p] + "','" + orderno + "','" + 1 +
                                   "','" + nowtime.Year + "-" + (nowtime.Month).ToString().PadLeft(2, '0') + "-" + (nowtime.Day).ToString().PadLeft(2, '0') + " " + (nowtime.Hour).ToString().PadLeft(2, '0') + ":" + (nowtime.Minute).ToString().PadLeft(2, '0') + "','" + userid + "')";
                cmd = new SqlCommand(insertinto, myConn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("改签成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);



                string sqlcrt;

                sqlcrt = "delete from " + trainid + handle(traindate) + " " + " where name='" + l04 + "'";
                cmd = new SqlCommand(sqlcrt, myConn);
                cmd.ExecuteNonQuery();

                sqlcrt = "insert into " + trainid + handle(traindate) + " values('" +
                                            person + "','" +
                                            sel + "')";
                cmd = new SqlCommand(sqlcrt, myConn);
                cmd.ExecuteNonQuery();

                sel = -1;


                this.Close();
            }
            catch(System.Exception err)
            {
                return;
            }
            
        }

        private void tabControl1_MouseMove(object sender, MouseEventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void picchange_MouseMove(object sender, MouseEventArgs e)
        {
            picchange.Image = Properties.Resources.change;
            this.Cursor = Cursors.Hand;
        }

        private void picbuy_MouseMove(object sender, MouseEventArgs e)
        {
            picbuy.Image = Properties.Resources.yuding2;
            this.Cursor = Cursors.Hand;
        }


    }
}
