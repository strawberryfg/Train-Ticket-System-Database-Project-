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
    public partial class frmadmin_managecontact : Form
    {
        SqlConnection myConn;
        public frmadmin_managecontact()
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
        int selectedrow = -1;
        private void frmadmin_Load(object sender, EventArgs e)
        {
            try
            {
                string sqlcrt;
                sqlcrt = "select * from " + "usertable ";
                SqlCommand cmd = new SqlCommand(sqlcrt, myConn);
                SqlDataReader readit = cmd.ExecuteReader();
                if (readit.HasRows)
                {
                    while (readit.Read())
                    {
                        ListViewItem lvi = new ListViewItem();
                        lvi.Text = (string)readit[0];
                        for (int i = 1; i <= 2; i++)
                        {
                            lvi.SubItems.Add((string)readit[i]);
                        }
                        if ((bool)readit[3] == true) lvi.SubItems.Add("男"); else lvi.SubItems.Add("女");
                        for (int i = 4; i <= 6; i++)
                        {
                            lvi.SubItems.Add((string)readit[i]);
                        }
                        if ((bool)readit[7] == true) lvi.SubItems.Add("是"); else lvi.SubItems.Add("否");
                        lstshow.Items.Add(lvi);
                    }
                }
                readit.Close();
                ImageList imageList = new ImageList();   //设置行高20
                imageList.ImageSize = new System.Drawing.Size(1, 40);   //分别是宽和高
                lstshow.SmallImageList = imageList;
            }
            catch(System.Exception err)
            {
                MessageBox.Show("未知错误！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }            
        }


        private void lstshow_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (lstshow.SelectedIndices.Count != 0)
                {
                    selectedrow = lstshow.SelectedIndices[0];
                    txtuser.Text = lstshow.Items[selectedrow].SubItems[0].Text;
                    //lstshow.Items[selectedrow].Text;
                    txtpassword.Text = lstshow.Items[selectedrow].SubItems[1].Text;
                    txtname.Text = lstshow.Items[selectedrow].SubItems[2].Text;
                    if (lstshow.Items[selectedrow].SubItems[3].Text.Equals("男")) radioman.Checked = true;
                    else radiowoman.Checked = true;
                    txtcer.Text = lstshow.Items[selectedrow].SubItems[4].Text;
                    txttel.Text = lstshow.Items[selectedrow].SubItems[5].Text;
                    txtemail.Text = lstshow.Items[selectedrow].SubItems[6].Text;
                    if (lstshow.Items[selectedrow].SubItems[7].Text.Equals("是")) radiostu.Checked = true;
                    else radionotstu.Checked = true;
                }
            }
            catch(System.Exception err)
            {
                MessageBox.Show("未知错误！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
        }
        private void frmadmin_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (myConn.State == ConnectionState.Open)
            {
                myConn.Close();
            }
        }

        private void picmodify_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtuser.Text.Equals("") || txtpassword.Text.Equals("") || txtname.Text.Equals("") || txttel.Text.Equals("") || txtcer.Text.Equals("") || txtemail.Text.Equals(""))
                {
                    MessageBox.Show("输入值为空", "错误", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                if (lstshow.SelectedIndices.Count == 0)
                {
                    MessageBox.Show("没有选中项", "错误", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                int id = lstshow.SelectedIndices[0];

                string sqlcrt;
                sqlcrt = "update " + "usertable " +
                                                   "set password='" + txtpassword.Text
                                                   + "',name='" + txtname.Text + "',sex=" + ((radioman.Checked == true) ? 1 : 0)
                                                   + ",cer='" + txtcer.Text + "',tel='" + txtcer.Text
                                                   + "',email='" + txtemail.Text + "',student=" + ((radiostu.Checked == true) ? 1 : 0)
                                                   +
                                                   " where userid='" + lstshow.Items[id].SubItems[0].Text + "'";
                SqlCommand cmd = new SqlCommand(sqlcrt, myConn);
                cmd.ExecuteNonQuery();

                lstshow.Items[lstshow.SelectedIndices[0]].SubItems[0].Text = txtuser.Text;
                lstshow.Items[lstshow.SelectedIndices[0]].SubItems[1].Text = txtpassword.Text;
                lstshow.Items[lstshow.SelectedIndices[0]].SubItems[2].Text = txtname.Text;
                if (radioman.Checked == true) lstshow.Items[lstshow.SelectedIndices[0]].SubItems[3].Text = "男";
                else lstshow.Items[lstshow.SelectedIndices[0]].SubItems[3].Text = "女";
                lstshow.Items[lstshow.SelectedIndices[0]].SubItems[4].Text = txtcer.Text;
                lstshow.Items[lstshow.SelectedIndices[0]].SubItems[5].Text = txttel.Text;
                lstshow.Items[lstshow.SelectedIndices[0]].SubItems[6].Text = txtemail.Text;
                if (radiostu.Checked == true) lstshow.Items[lstshow.SelectedIndices[0]].SubItems[7].Text = "是";
                else lstshow.Items[lstshow.SelectedIndices[0]].SubItems[7].Text = "否";
            }
            catch(System.Exception err)
            {
                MessageBox.Show("未知错误！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
        }

        private void picdelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult rslt = MessageBox.Show("是否确定删除？", "确认", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rslt == DialogResult.No)
                {
                    return;
                }
                if (selectedrow != -1)
                {
                    lstshow.Items.RemoveAt(selectedrow);
                }
                string sqlcrt;
                sqlcrt = "delete " + "usertable " +
                                                  " where userid='" + txtuser.Text + "'";
                SqlCommand cmd = new SqlCommand(sqlcrt, myConn);
                cmd.ExecuteNonQuery();

                sqlcrt = "drop table \"" + txtuser.Text + "\"";
                cmd = new SqlCommand(sqlcrt, myConn);
                cmd.ExecuteNonQuery();
            }
            catch(System.Exception err)
            {
                MessageBox.Show("未知错误！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return; 
            }            
        }

        private void picdelete_MouseMove(object sender, MouseEventArgs e)
        {
            this.Cursor = Cursors.Hand;
            picdelete.Image = Properties.Resources.delete2;
        }

        private void frmadmin_MouseMove(object sender, MouseEventArgs e)
        {
            this.Cursor = Cursors.Default;
            picdelete.Image = Properties.Resources.delete;
            picmodify.Image = Properties.Resources.modify1;
        }

        private void picmodify_MouseMove(object sender, MouseEventArgs e)
        {
            this.Cursor = Cursors.Hand;
            picmodify.Image=Properties.Resources.modify21;
        }

        private void lstshow_KeyDown(object sender, KeyEventArgs e)
        {
            
            if (e.KeyCode == Keys.Delete) picdelete_Click(sender, e);
        }
    }
}
