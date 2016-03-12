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
    public partial class frmadmin_main : Form
    {
        public frmadmin_login f1;
        public frmadmin_main()
        {
            InitializeComponent();
        }

        private void piclogout_MouseMove(object sender, MouseEventArgs e)
        {
            if (lblworker.Text.Equals("无")) return;
            this.Cursor = Cursors.Hand;
            piclogout.Image = Properties.Resources.logout1;
        }
        private void frmadminmin_MouseMove(object sender, MouseEventArgs e)
        {
            this.Cursor = Cursors.Default;
            piclogout.Image = Properties.Resources.logout2;
            picmanage.Image = Properties.Resources.manage3;
        }

        private void frmadminmain_FormClosed(object sender, FormClosedEventArgs e)
        {
            f1.Show();
        }

        private void piclogout_Click(object sender, EventArgs e)
        {
            if (lblworker.Text.Equals("无")) return;
            f1.f1.workeronline = 0;
            MessageBox.Show("注销工作人员成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void frmadminmain_Load(object sender, EventArgs e)
        {
            if (f1.f1.workeronline == 0) lblworker.Text = "无"; else lblworker.Text = "worker";
        }

        private void frmadminmain_Activated(object sender, EventArgs e)
        {
            if (f1.f1.workeronline == 0) lblworker.Text = "无"; else lblworker.Text = "worker";
        }

        private void picmanage_MouseMove(object sender, MouseEventArgs e)
        {
            this.Cursor = Cursors.Hand;
            picmanage.Image = Properties.Resources.manage2;
        }

        private void picmanage_Click(object sender, EventArgs e)
        {
            frmadmin_managecontact f = new frmadmin_managecontact();
            f.Show();
        }
    }
}
