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
    public partial class frmuser_main : Form
    {
        public frmuser_login f1;
        Font ft;
        public frmuser_main()
        {
            InitializeComponent();
            ft = lbloffline.Font;
        }

      

        private void lbllogout_Click(object sender, EventArgs e)
        {
            f1.Show();
            this.Close();
        }

        private void lblcontact_Click(object sender, EventArgs e)
        {
            frmuser_contact f = new frmuser_contact();
            f.userid = lbluserid.Text;
            f.f1 = this;            
            f.Show();
            //this.Hide(); 
        }

        private void moveinit()
        {
            lbloffline.ForeColor = lblonline.ForeColor = lblbuy.ForeColor = lblcontact.ForeColor = lblpersonal.ForeColor= lblseeorder.ForeColor = lbllogout.ForeColor = Color.Black;
            lbloffline.Font = lblonline.Font = lblbuy.Font = lblcontact.Font = lblpersonal.Font = lblseeorder.Font = lbllogout.Font = ft;
            lbloffline.BackColor = lblonline.BackColor = lblcontact.BackColor = lblbuy.BackColor=lblpersonal.BackColor = lblseeorder.BackColor = lbllogout.BackColor = Color.FromArgb(218, 241, 255);
        }
        private void lbloffline_MouseMove(object sender, MouseEventArgs e)
        {
            moveinit();
            lbloffline.BackColor = Color.DarkOrange;
            lbloffline.Font=new Font(lbloffline.Font.FontFamily,15,FontStyle.Bold);            
            this.Cursor = Cursors.Hand;
            lbloffline.ForeColor = Color.Green;
        }

        private void lblonline_MouseMove(object sender, MouseEventArgs e)
        {
            moveinit();
            lblonline.BackColor = Color.DarkOrange;
            lblonline.Font = new Font(lblonline.Font.FontFamily, 15, FontStyle.Bold);
            this.Cursor = Cursors.Hand;
            lblonline.ForeColor = Color.Green;
        }

        private void lblbuy_MouseMove(object sender, MouseEventArgs e)
        {
            moveinit();
            lblbuy.BackColor = Color.DarkOrange;
            lblbuy.Font = new Font(lblbuy.Font.FontFamily, 15, FontStyle.Bold);
            this.Cursor = Cursors.Hand;
            lblbuy.ForeColor = Color.Green;
        }

        private void lblpersonal_MouseMove(object sender, MouseEventArgs e)
        {
            moveinit();
            lblpersonal.BackColor = Color.DarkOrange;
            lblpersonal.Font = new Font(lblpersonal.Font.FontFamily, 15, FontStyle.Bold);
            this.Cursor = Cursors.Hand;
            lblpersonal.ForeColor = Color.Green;
        }

        private void lblcontact_MouseMove(object sender, MouseEventArgs e)
        {
            moveinit();
            lblcontact.BackColor = Color.DarkOrange;
            lblcontact.Font = new Font(lblcontact.Font.FontFamily, 15, FontStyle.Bold);
            this.Cursor = Cursors.Hand;
            lblcontact.ForeColor = Color.Green;
        }

        private void lblseeorder_MouseMove(object sender, MouseEventArgs e)
        {
            moveinit();
            lblseeorder.BackColor = Color.DarkOrange;
            lblseeorder.Font = new Font(lblseeorder.Font.FontFamily, 15, FontStyle.Bold);
            this.Cursor = Cursors.Hand;
            lblseeorder.ForeColor = Color.Green;
        }

        private void lbllogout_MouseMove(object sender, MouseEventArgs e)
        {
            moveinit();
            lbllogout.BackColor = Color.DarkOrange;
            lbllogout.Font = new Font(lbllogout.Font.FontFamily, 15, FontStyle.Bold);
            this.Cursor = Cursors.Hand;
            lbllogout.ForeColor = Color.Green;
        }

        private void frmuser_main_MouseMove(object sender, MouseEventArgs e)
        {
            moveinit();
            this.Cursor = Cursors.Default;
        }

        private void lblpersonal_Click(object sender, EventArgs e)
        {
            frmuser_info f = new frmuser_info();
            f.txtuser.Text = lbluserid.Text;
            f.txtname.Text = lblusername.Text;
            f.Show();
        }

        private void pictureBox2_MouseMove(object sender, MouseEventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void lbloffline_Click(object sender, EventArgs e)
        {
            frmuser_offline f = new frmuser_offline();
            f.f1 = this;
            //this.Hide();
            f.Show();

        }

        private void lblonline_Click(object sender, EventArgs e)
        {
            frmuser_online f = new frmuser_online();
            f.btnbuy.Enabled = false;
            f.btnchange.Enabled = false;
            f.f1 = this;
            //this.Hide();
            f.Show();   
        }

        private void lblbuy_Click(object sender, EventArgs e)
        {
            frmuser_online f = new frmuser_online();
            f.btnbuy.Enabled = true;
            f.btnchange.Enabled = false;
            f.btnquery.Enabled = true;
            f.txtperson.Text = this.txtperson.Text;
            f.txtcarno.Text = this.txtcarno.Text;
            f.txtseatno.Text = this.txtseatno.Text;
            f.txtseattype.Text = this.txtseattype.Text;
            f.txtseatno.Visible = true;
            f.txtseattype.Visible = true;
            f.txtcarno.Visible = true;
            f.txtperson.Visible = true;
            f.f1 = this;
            f.txtuserid.Text = lbluserid.Text;
            f.txtusername.Text = lblusername.Text;
            //this.Hide();
            f.Show();
        }

        private void lblseeorder_Click(object sender, EventArgs e)
        {
            frmuser_order f = new frmuser_order();
            f.txtuserid.Text = lbluserid.Text;
            f.txtusername.Text = lblusername.Text;
            f.f1 = this;
            //this.Hide();
            f.Show();
        }

        private void frmuser_main_Load(object sender, EventArgs e)
        {
            this.Text = this.Text + " - " + lblusername.Text+"("+lbluserid.Text+")";
        }

        private void frmuser_main_FormClosed(object sender, FormClosedEventArgs e)
        {
            f1.Show();
        }

        private void frmuser_main_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.B)
            {
                lblbuy_Click(sender, e);
            }
            if (e.KeyCode==Keys.O)
            {
                lblseeorder_Click(sender, e);
            }
            if (e.KeyCode==Keys.C)
            {
                lblcontact_Click(sender, e);
            }
            if (e.KeyCode == Keys.P)
            {
                lblpersonal_Click(sender, e);
            }
            if (e.KeyCode == Keys.L)
            {
                lbloffline_Click(sender, e);                
            }
            if (e.KeyCode == Keys.Z)
            {
                lblonline_Click(sender, e);
            }
        }
    }
}
