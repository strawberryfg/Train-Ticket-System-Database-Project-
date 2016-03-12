using System;
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
    public partial class frmmain : Form
    {
        string usr;
        string worker;
        string admin;
        public frmmain()
        {
            InitializeComponent();
        }
        public int workeronline = 0;
        SqlConnection myConn;
        private void 用户登录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmuser_login f = new frmuser_login();
            f.f1 = this;
            f.Show();
            //this.Hide();
        }

        private void frmmain_Load(object sender, EventArgs e)
        {
            usr = lblexpusr.Text;
            worker = lblexpworker.Text;
            admin = lblexpadmin.Text;
            lblexpusr.Text="";
            lblexpworker.Text="";
            lblexpadmin.Text="";
        }

        private void frmmain_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                if (myConn.State == ConnectionState.Open)
                {
                    myConn.Close();
                }
            }
            catch (System.Exception err)
            {
                return;
            }
            
        }

        private void 工作人员登录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmworker_login f = new frmworker_login();
            f.f1 = this;
            f.Show();
            //this.Hide();
        }

        private void 管理员登录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmadmin_login f = new frmadmin_login();
            f.f1 = this;
            f.Show();
        }

        private void 初始化ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string sqlcrt;
            SqlCommand cmd;
            try
            {
                myConn = new SqlConnection("Server=localhost;Integrated security=SSPI;database=master");
                try
                {
                    myConn.Open();
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "MyProgram", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
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
                                    "orderno varchar(15)," +
                                    "ordertime varchar(30)," +
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
                        "orderno varchar(15)," +
                        "ischanged int," +
                        "finishtime varchar(30)," +
                        "userid varchar(30))";
                cmd = new SqlCommand(sqlcrt, myConn);
                cmd.ExecuteNonQuery();
                //userorder
                sqlcrt = "create table " + "queryonline" +
                            "(traincode char(15)," +
                            "startcode char(15)," +
                            "startname char(15)," +
                            "endcode char(15)," +
                            "endname char(15)," +
                            "fromcode char(15)," +
                            "fromname char(15)," +
                            "tocode char(15)," +
                            "toname char(15)," +
                            "starttime char(15)," +
                            "arrivetime char(15)," +
                            "daydiff char(15)," +
                            "lishi char(15)," +
                            "swz_num char(15)," +
                            "tz_num char(15)," +
                            "zy_num char(15)," +
                            "ze_num char(15)," +
                            "gr_num char(15)," +
                            "rw_num char(15)," +
                            "yw_num char(15)," +
                            "rz_num char(15)," +
                            "yz_num char(15)," +
                            "wz_num char(15)," +
                            "swz_price varchar(15)," +
                            "tdz_price varchar(15)," +
                            "ydz_price varchar(15)," +
                            "edz_price varchar(15)," +
                            "gjrw_price varchar(15)," +
                            "rw_price varchar(15)," +
                            "yw_price varchar(15)," +
                            "rz_price varchar(15)," +
                            "yz_price varchar(15)," +
                            "wz_price varchar(15)," +
                            "train_no varchar(30)," +
                            "from_station_no varchar(15)," +
                            "to_station_no varchar(15)," +
                            "seat_types varchar(15))";
                cmd = new SqlCommand(sqlcrt, myConn);
                cmd.ExecuteNonQuery();
                //queryonline

                sqlcrt = "create table " + "usertable" +
                                                    "(userid varchar(20) not null," +
                                                    "password varchar(20) not null," +
                                                    "name varchar(20) not null," +
                                                    "sex bit not null," +
                                                    "cer varchar(20) not null," +
                                                    "tel varchar(20) not null," +
                                                    "email varchar(30) not null," +
                                                    "student bit not null)";
                cmd = new SqlCommand(sqlcrt, myConn);
                cmd.ExecuteNonQuery();
                //usertable
                sqlcrt = "create table " + "traintable" +
                                    "(trainid varchar(30) not null)";
                cmd = new SqlCommand(sqlcrt, myConn);
                cmd.ExecuteNonQuery();
                //traintable
                MessageBox.Show("初始化成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (System.Exception err)
            {
                return;
            }            
        }

        private void 关于ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmaboutall f = new frmaboutall();
            f.Show();
        }
        private int gets(int x)
        {
            if (x <= this.Width) return x;
            return x - this.Width;
        }
        private void tmrmovebottom_Tick(object sender, EventArgs e)
        {
            Label[] lblbot = { label1, label7, label8, label9, label10, label11, label12, label13, label14, label15, label16, label2, label3, label4 };

            for (int i = 0; i < 14; i++)
            {

                lblbot[i].Location = new Point(gets(lblbot[i].Location.X + 40), lblbot[i].Location.Y);
            }
        }
        int now = 1, len = 0;
        private void tmrnext_Tick(object sender, EventArgs e)
        {
            if (now==1)
            {
                if (len + 1 <= usr.Length) lblexpusr.Text = lblexpusr.Text + usr[len];
                len++;
                if (len > usr.Length) { now++; len = 0; }
                return;
            }
            if (now==2)
            {
                if (len + 1 <= worker.Length) lblexpworker.Text = lblexpworker.Text + worker[len];
                len++;
                if (len > worker.Length) { now++; len = 0; }
                return;
            }
            if (now==3)
            {
                if (len + 1 <= admin.Length) lblexpadmin.Text = lblexpadmin.Text + admin[len];
                len++;
                if (len > admin.Length) { now++; len = 0; }
                if (now == 4)
                {
                    lblexpusr.Text = lblexpworker.Text = lblexpadmin.Text = "";
                    now = 1;
                }
                return;
            }
        }
    }
}
