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
    public partial class frmadmin_login : Form
    {
        public frmmain f1;
        public frmadmin_login()
        {
            InitializeComponent();
        }

        private void piclogin_MouseMove(object sender, MouseEventArgs e)
        {
            this.Cursor = Cursors.Hand;
            piclogin.BackgroundImage = Properties.Resources.userlogin2;
        }

        private void frmadmin_login_MouseMove(object sender, MouseEventArgs e)
        {
            this.Cursor = Cursors.Default;
            piclogin.BackgroundImage = Properties.Resources.userlogin1;
        }



        private void piclogin_Click(object sender, EventArgs e)
        {
            if (txtuser.Text.Equals("admin") && txtpassword.Text.Equals("admin"))
            {
                frmadmin_main f = new frmadmin_main();
                f.f1 = this;                
                f.Show();
                
                this.Hide();
            }
            else
            {
                MessageBox.Show("用户名不存在或者密码错误", "错误", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void frmadmin_login_Load(object sender, EventArgs e)
        {
            txtuser.Focus();
        }

        private void txtpassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                piclogin_Click(sender, e);
            }
        }
    }
}
