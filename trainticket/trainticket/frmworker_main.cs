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
    public partial class frmworker_main : Form
    {
        public frmworker_login f1;
        int flag = 0;
        public frmworker_main()
        {
            InitializeComponent();
        }

        private void pictimetable_MouseMove(object sender, MouseEventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void pictrainid_MouseMove(object sender, MouseEventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void frmworker_choose_MouseMove(object sender, MouseEventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void pictimetable_Click(object sender, EventArgs e)
        {
            frmworker_train f = new frmworker_train();
            f.f1 = f1;
            f.Show();            
        }

        private void pictrainid_Click(object sender, EventArgs e)
        {
            frmworker_seat f = new frmworker_seat();
            f.f1 = f1;
            f.Show();
        }

        private void frmworker_choose_FormClosed(object sender, FormClosedEventArgs e)
        {
            f1.Show();
            f1.f1.workeronline = 0;
        }

        private void frmworker_choose_Activated(object sender, EventArgs e)
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
    }
}
