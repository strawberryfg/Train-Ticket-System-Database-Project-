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
    public partial class frmuser_reg : Form
    {
        public frmuser_login f1;
        public frmuser_reg()
        {
            InitializeComponent();
        }
        
        

        private void btnreg_Click(object sender, EventArgs e)
        {
            try
            {
                if (!txtpassword.Text.Equals(txtpassword2.Text))
                {
                    MessageBox.Show("密码输入不一致", "错误", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                SqlConnection myConn = new SqlConnection("Server=localhost;Integrated security=SSPI;database=master");
                try
                {
                    myConn.Open();
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "MyProgram", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                if (txtuser.Text.Equals("") || txtpassword.Text.Equals("") || txtname.Text.Equals("") || txtcer.Text.Equals("") || txttel.Text.Equals("") || txtemail.Text.Equals(""))
                {
                    MessageBox.Show("输入值不能为空！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                if (!((txtuser.Text[0] >= 'a' && txtuser.Text[0] <= 'z') || (txtuser.Text[0] >= 'A' && txtuser.Text[0] <= 'Z')))
                {
                    MessageBox.Show("用户名开头必须为大写或小写英文字母！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                string sqlcrt;
                sqlcrt = "select COUNT(*) from " + "usertable " +
                                                   "where userid='" + txtuser.Text + "'";
                SqlCommand cmd = new SqlCommand(sqlcrt, myConn);
                SqlDataReader readit = cmd.ExecuteReader();
                if (readit.Read() && (int)readit[0] != 0)
                {
                    MessageBox.Show("该用户名已被注册", "错误", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    readit.Close();
                    return;
                }
                readit.Close();
                int bo;
                if (radiostu.Checked == true) bo = 1;
                else bo = 0;
                int bosex;
                if (radioman.Checked == true) bosex = 1;
                else bosex = 0;
                sqlcrt = "insert into " + "usertable values('" +
                                                    txtuser.Text + "','" +
                                                    txtpassword.Text + "','" +
                                                    txtname.Text + "','" +
                                                    bosex + "','" +
                                                    txtcer.Text + "','" +
                                                    txttel.Text + "','" +
                                                    txtemail.Text + "','" +
                                                    bo + "')";
                cmd = new SqlCommand(sqlcrt, myConn);
                cmd.ExecuteNonQuery();

                sqlcrt = "create table " + txtuser.Text +
                                                   "(userid varchar(20) not null," +
                                                    "name varchar(20) not null," +
                                                    "sex bit not null," +
                                                    "cer varchar(20) not null," +
                                                    "student bit not null)";
                cmd = new SqlCommand(sqlcrt, myConn);
                cmd.ExecuteNonQuery();

                sqlcrt = "insert into " + txtuser.Text + " values('" +
                                                    txtuser.Text + "','" +
                                                    txtname.Text + "','" +
                                                    bosex + "','" +
                                                    txtcer.Text + "','" +
                                                    bo + "')";
                cmd = new SqlCommand(sqlcrt, myConn);
                cmd.ExecuteNonQuery();

                MessageBox.Show("注册成功！", "恭喜您", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void frmuser_reg_Load(object sender, EventArgs e)
        {

        }



        private void frmuser_reg_FormClosed(object sender, FormClosedEventArgs e)
        {
            f1.Show();
        }

        private void picsubmit_Click(object sender, EventArgs e)
        {
            btnreg_Click(sender, e);
        }

        private void picsubmit_MouseMove_1(object sender, MouseEventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void gp1_MouseHover(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }
    }
}
