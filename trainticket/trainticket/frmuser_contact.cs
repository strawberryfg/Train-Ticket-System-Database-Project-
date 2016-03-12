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
    public partial class frmuser_contact : Form
    {
        public string userid;
        string selid;
        SqlConnection myConn;
        public frmuser_main f1;
        public frmuser_contact()
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
        string[] allcontact = new string[1111111];
        int cnt = 0;
        private void frmlogin_Load(object sender, EventArgs e)
        {
            try
            {
                string sqlcrt;
                sqlcrt = "select userid from " + userid;  //get all contacts save to string array
                SqlCommand cmd = new SqlCommand(sqlcrt, myConn);
                SqlDataReader readit = cmd.ExecuteReader();
                readit.Read();

                while (readit.Read())
                {
                    allcontact[cnt++] = (string)readit[0];  //only id
                }
                readit.Close();

                for (int i = 0; i < cnt; i++)
                {
                    sqlcrt = "select name,sex,cer,student from usertable where userid='" + allcontact[i] + "'";
                    cmd = new SqlCommand(sqlcrt, myConn);
                    readit = cmd.ExecuteReader();
                    readit.Read();
                    ListViewItem lvi = new ListViewItem();
                    lvi.Text = allcontact[i];
                    lvi.SubItems.Add((string)readit[0]);
                    if ((bool)readit[1] == true) lvi.SubItems.Add("男"); else lvi.SubItems.Add("女");
                    lvi.SubItems.Add((string)readit[2]);
                    if ((bool)readit[3] == true) lvi.SubItems.Add("是"); else lvi.SubItems.Add("否");
                    lstshow.Items.Add(lvi);

                    readit.Close();
                }

                string sqlload = "select name from usertable";
                cmd = new SqlCommand(sqlload, myConn);
                readit = cmd.ExecuteReader();
                readit.Read();
                while (readit.Read())
                {
                    cmbcontact.Items.Add((string)readit[0]);
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

        private void btnadd_Click(object sender, EventArgs e)
        {
            try
            {
                string sqlcrt;
                sqlcrt = "select * from " + "usertable " +
                                                   "where name='" + cmbcontact.Text + "'";
                SqlCommand cmd = new SqlCommand(sqlcrt, myConn);
                SqlDataReader readit = cmd.ExecuteReader();
                if (readit.HasRows && readit.Read())
                {
                    string readit0 = (string)readit[0];
                    string readit2 = (string)readit[2];
                    bool readit3 = (bool)readit[3];
                    string readit4 = (string)readit[4];
                    bool readit7 = (bool)readit[7];
                    readit.Close();
                    string sqlcheck;
                    sqlcheck = "select * from " + userid + " where name='" + cmbcontact.Text + "'";
                    cmd = new SqlCommand(sqlcheck, myConn);
                    SqlDataReader readitnew = cmd.ExecuteReader();
                    if (readitnew.HasRows)
                    {
                        readitnew.Close();
                        MessageBox.Show("同一联系人不能重复添加", "错误", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                    readitnew.Close();
                    ListViewItem lvi = new ListViewItem();
                    lvi.Text = readit0;
                    lvi.SubItems.Add(readit2);

                    if (readit3 == true) lvi.SubItems.Add("男"); else lvi.SubItems.Add("女");

                    lvi.SubItems.Add(readit4);
                    if (readit7 == true) lvi.SubItems.Add("是"); else lvi.SubItems.Add("否");
                    lstshow.Items.Add(lvi);
                    sqlcrt = "insert into " + userid + " values('" +
                                                    readit0 + "','" +
                                                    readit2 + "','" +
                                                    (readit3 == true ? 1 : 0) + "','" +
                                                    readit4 + "','" +
                                                    ((readit7 == true) ? 1 : 0) + "')";
                    cmd = new SqlCommand(sqlcrt, myConn);
                    cmd.ExecuteNonQuery();
                }
                else
                {
                    MessageBox.Show("该用户不存在", "错误", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    readit.Close();
                    return;
                }
                readit.Close();

                MessageBox.Show("添加成功！", "恭喜您", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(System.Exception err)
            {
                MessageBox.Show("未知错误！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }


        }
      
        private void btndel_Click(object sender, EventArgs e)
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
                sqlcrt = "delete " + userid +
                                                  " where userid='" + selid + "'";
                SqlCommand cmd = new SqlCommand(sqlcrt, myConn);
                cmd.ExecuteNonQuery();
            }
            catch(System.Exception err)
            {
                MessageBox.Show("未知错误！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
           

        }

        private void lstshow_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstshow.SelectedIndices.Count != 0)
            {
                selectedrow = lstshow.SelectedIndices[0];
                selid = lstshow.Items[selectedrow].SubItems[0].Text;
            }
        }

        private void frmuser_contact_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (myConn.State == ConnectionState.Open)
            {
                myConn.Close();
            }
            //f1.Show();
        }

        private void btn_add_MouseMove(object sender, MouseEventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void picadd_MouseMove(object sender, MouseEventArgs e)
        {
            this.Cursor = Cursors.Hand;
            picadd.BackgroundImage = Properties.Resources.newcontact2;
        }

        private void frmuser_contact_MouseMove(object sender, MouseEventArgs e)
        {
            picadd.BackgroundImage = Properties.Resources.newcontact;
            picremove.BackgroundImage = Properties.Resources.removecontact;
            this.Cursor = Cursors.Default;
        }

        private void picremove_MouseMove(object sender, MouseEventArgs e)
        {
            this.Cursor = Cursors.Hand;
            picremove.BackgroundImage = Properties.Resources.removecontact2;
        }

        private void picadd_Click(object sender, EventArgs e)
        {
            btnadd_Click(sender, e);
        }

        private void picremove_Click(object sender, EventArgs e)
        {
            btndel_Click(sender, e);
        }

        private void lstshow_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Delete)
            {
                btndel_Click(sender, e);
            }
        }
    }
}
