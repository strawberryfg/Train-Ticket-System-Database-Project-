using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace trainticket
{
    public partial class frmworker_login : Form
    {
        public frmmain f1;
        public frmworker_login()
        {
            InitializeComponent();
        }

        private void piclogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtuser.Text.Equals("worker") && txtpassword.Text.Equals("worker"))
                {
                    f1.workeronline = 1;
                    /*frmworker_train f = new frmworker_train();
                    f.f1 = this;
                    f.Show();*/
                    frmworker_main f = new frmworker_main();
                    f.f1 = this;
                    f.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("用户名不存在或者密码错误", "错误", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch(System.Exception err)
            {
                MessageBox.Show("未知错误！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
           
        }

        private void frmworker_login_FormClosed(object sender, FormClosedEventArgs e)
        {
            //f1.Show();
            
        }

        private void piclogin_MouseMove(object sender, MouseEventArgs e)
        {
            this.Cursor = Cursors.Hand;
            piclogin.BackgroundImage = Properties.Resources.userlogin2;
        }

        private void frmworker_login_MouseMove(object sender, MouseEventArgs e)
        {
            this.Cursor = Cursors.Default;
            piclogin.BackgroundImage = Properties.Resources.userlogin1;
        }

        private void txtpassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                piclogin_Click(sender, e);
            }
        }

        private void frmworker_login_Load(object sender, EventArgs e)
        {
            txtuser.Focus();
        }
    }
}
