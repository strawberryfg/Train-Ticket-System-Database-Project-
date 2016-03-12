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
    public partial class frmuser_login : Form
    {
        public frmmain f1;
        public frmuser_login()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
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
                sqlcrt = "select COUNT(*) from " + "usertable " +
                                                   "where userid='" + txtuser.Text + "' and password='" + txtpassword.Text + "'";
                SqlCommand cmd = new SqlCommand(sqlcrt, myConn);
                SqlDataReader readit = cmd.ExecuteReader();
                if (readit.Read() && (int)readit[0] != 0)
                {
                    readit.Close();
                    string sql;
                    sql = "select name,sex from usertable where userid='" + txtuser.Text + "'";
                    cmd = new SqlCommand(sql, myConn);
                    SqlDataReader readit2 = cmd.ExecuteReader();
                    if (readit2.Read())
                    {
                        frmuser_main f = new frmuser_main();
                        f.f1 = this;
                        f.lblusername.Text = (string)readit2[0];
                        f.lbluserid.Text = txtuser.Text;
                        if ((bool)(readit2[1]) == true) f.lblsex.Text = "先生"; else f.lblsex.Text = "女士";
                        readit2.Close();
                        f.Show();
                        this.Hide();
                    }

                }
                else
                {
                    readit.Close();
                    MessageBox.Show("用户名不存在或者密码错误", "错误", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                if (myConn.State == ConnectionState.Open)
                {
                    myConn.Close();
                }
            }
            catch(System.Exception err)
            {
                MessageBox.Show("未知错误！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            

        }     
        private void btnreg_Click(object sender, EventArgs e)
        {
            frmuser_reg f = new frmuser_reg();
            f.f1 = this;
            f.Show();
            this.Visible = false;
        }

      

        private void frmuser_login_Activated(object sender, EventArgs e)
        {
            txtuser.Focus();
        }

        private void txtpassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                btnlogin_Click(sender, e);
            }
        }

       

        private void frmuser_login_FormClosed(object sender, FormClosedEventArgs e)
        {
            //f1.Show();
        }

        private void picsubmit_MouseMove(object sender, MouseEventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void piclogin_MouseMove(object sender, MouseEventArgs e)
        {
            this.Cursor = Cursors.Hand;
            piclogin.BackgroundImage = Properties.Resources.userlogin2;
        }

        private void frmuser_login_MouseMove(object sender, MouseEventArgs e)
        {
            this.Cursor = Cursors.Default;
            piclogin.BackgroundImage = Properties.Resources.userlogin1;
        }

        private void picsubmit_Click(object sender, EventArgs e)
        {
            btnreg_Click(sender, e);
        }

        private void piclogin_Click(object sender, EventArgs e)
        {
            btnlogin_Click(sender, e);
        }
    }
}
