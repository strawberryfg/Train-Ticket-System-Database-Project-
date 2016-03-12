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
    public partial class frmuser_info : Form
    {
        SqlConnection myConn;
        public frmuser_info()
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
        
        private void picmodify_MouseMove(object sender, MouseEventArgs e)
        {
            this.Cursor = Cursors.Hand;
            picmodify.Image = Properties.Resources.modify2;
        }

        private void gp1_MouseHover(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
            picmodify.Image = Properties.Resources.modify;
        }

        private void picmodify_Click(object sender, EventArgs e)
        {
            try
            {
                if (!txtpassword.Text.Equals(txtpassword2.Text))
                {
                    MessageBox.Show("密码输入不一致", "错误", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
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

                int bo;
                if (radiostu.Checked == true) bo = 1;
                else bo = 0;
                int bosex;
                if (radioman.Checked == true) bosex = 1;
                else bosex = 0;

                string upd = "update usertable set name='" + txtname.Text + "',password='" + txtpassword.Text + "',sex=" + bosex + ",cer='" + txtcer.Text + "',tel='" + txttel.Text + "',email='" +
                             txtemail.Text + "',student=" + bo + " where userid='" + txtuser.Text + "'";
                SqlCommand cmd = new SqlCommand(upd, myConn);
                MessageBox.Show("修改成功！", "恭喜您", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(System.Exception err)
            {
                MessageBox.Show("未知错误！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }           
        }

        private void frmuser_info_Load(object sender, EventArgs e)
        {
            try
            {
                string sel = "select sex,cer,tel,email,student,password from usertable where userid='" + txtuser.Text + "'";
                SqlCommand cmd = new SqlCommand(sel, myConn);
                SqlDataReader readit = cmd.ExecuteReader();
                readit.Read();
                if ((bool)readit[0] == true) radioman.Checked = true;
                txtcer.Text = (string)readit[1];
                txttel.Text = (string)readit[2];
                txtemail.Text = (string)readit[3];
                if ((bool)readit[4] == true) radiostu.Checked = true;
                txtpassword.Text = txtpassword2.Text = (string)readit[5];
            }
            catch(System.Exception err)
            {
                MessageBox.Show("未知错误！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            
        }

        private void frmuser_info_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (myConn.State == ConnectionState.Open)
            {
                myConn.Close();
            }
        }
    }
}
