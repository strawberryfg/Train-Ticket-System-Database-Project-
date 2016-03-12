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
    public partial class frmworker_seat : Form
    {
        public frmworker_login f1;
        int flag = 0;
        SqlConnection myConn;
        public frmworker_seat()
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
        String[] seattype = { "商务座", "一等座", "二等座", "高级软卧", "软卧", "硬卧", "软座", "硬座", "无座" };

        private void frmworker_seat_Load(object sender, EventArgs e)
        {
            txttraindate.Text = DateTime.Now.Year+DateTime.Now.Month.ToString().PadLeft(2,'0')+DateTime.Now.Day.ToString().PadLeft(2,'0');
            ImageList imageList = new ImageList();   //设置行高20
            imageList.ImageSize = new System.Drawing.Size(1, 40);   //分别是宽和高
            lstview.SmallImageList = imageList;
        }

        private void picsearch_MouseMove(object sender, MouseEventArgs e)
        {
            this.Cursor = Cursors.Hand;
            picsearch.Image = Properties.Resources.find2;
        }

        private void frmworker_seat_MouseMove(object sender, MouseEventArgs e)
        {
            this.Cursor = Cursors.Default;
            picsearch.Image = Properties.Resources.find1;
        }

        private void picsearch_Click(object sender, EventArgs e)
        {
            try
            {
                string sqlcrt;
                sqlcrt = "select COUNT(*) from traintable where trainid='" + txttrainid.Text + txttraindate.Text + "'";
                SqlCommand cmd = new SqlCommand(sqlcrt, myConn);
                SqlDataReader readit = cmd.ExecuteReader();
                if (readit.Read() && (int)readit[0] == 0)
                {
                    readit.Close();
                    MessageBox.Show("您好，此车次无乘客信息！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                readit.Close();
                sqlcrt = "select * from " + txttrainid.Text + txttraindate.Text;
                cmd = new SqlCommand(sqlcrt, myConn);
                readit = cmd.ExecuteReader();
                while (readit.Read())
                {
                    ListViewItem lvi = new ListViewItem();
                    lvi.Text = (string)readit[0];
                    int i = (int)readit[1];
                    int car, seat;
                    string seatno;
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

                    lvi.SubItems.Add(seattype[car]);
                    lvi.SubItems.Add(seatno);
                    lvi.SubItems.Add(seatno);
                    lvi.SubItems.Add(seatno);
                    lvi.SubItems.Add(seatno);
                    lvi.SubItems.Add(seatno);
                    lvi.SubItems.Add(seatno);
                    lstview.Items.Add(lvi);
                }
                readit.Close();

                int n = lstview.Items.Count;
                for (int j = 0; j < n; ++j)
                {
                    sqlcrt = "select * from usertable where name='" + lstview.Items[j].SubItems[0].Text + "'";
                    cmd = new SqlCommand(sqlcrt, myConn);
                    readit = cmd.ExecuteReader();
                    if (readit.HasRows)
                    {
                        readit.Read();

                        ListViewItem lvi = new ListViewItem();

                        if ((bool)readit[3] == true) lstview.Items[j].SubItems[3].Text = "男";
                        else lstview.Items[j].SubItems[3].Text = "女";
                        for (int i = 4; i <= 6; i++)
                        {
                            lstview.Items[j].SubItems[i].Text = (string)readit[i];
                        }
                        if ((bool)readit[7] == true) lstview.Items[j].SubItems[7].Text = "是";
                        else lstview.Items[j].SubItems[7].Text = "否";

                    }
                    readit.Close();
                }
            }
            catch(System.Exception err)
            {
                return;
            }
            
        }

        private void frmworker_seat_Activated(object sender, EventArgs e)
        {
            if (flag == 1) return;
            if (f1.f1.workeronline == 0)
            {
                flag = 1;
                MessageBox.Show("您好！您已被管理人员下线，即将退出系统！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                return;

            }
        }

        private void frmworker_seat_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (myConn.State==ConnectionState.Open)
            {
                myConn.Close();
            }
        }
    }
}
