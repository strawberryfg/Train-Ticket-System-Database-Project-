using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Net;
using System.Net.Security;
using System.Security.Authentication;
using System.Security.Cryptography.X509Certificates;
using System.Data.SqlClient;
using System.IO;
namespace trainticket
{
    public partial class frmuser_trainno : Form
    {
        public string trainno;
        public string srcsta;
        public string dststa;
        public string traindate;
        public string trainnumber;
        string stationname="";
        SqlConnection myConn;
        public frmuser_trainno()
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
        internal class AcceptAllCertificatePolicy : ICertificatePolicy
        {
            public AcceptAllCertificatePolicy()
            {
            }

            public bool CheckValidationResult(ServicePoint sPoint,
               X509Certificate cert, WebRequest wRequest, int certProb)
            {
                // Always accept  
                return true;
            }
        }
        private string handle(string s1)
        {
            return s1.Substring(0, 4) + s1.Substring(5, 2) + s1.Substring(8, 2);
        }
        private string eli(string s)
        {
            if (s[0].Equals('\"')) return s.Substring(1, s.Length - 2);
            return s;
        }
        public static JToken getTicketData(string fromStation, string toStation, string startDate,string trainno)
        {
            Uri uri = new Uri("https://kyfw.12306.cn/otn/czxx/queryByTrainNo?train_no="+   trainno+"&from_station_telecode="+fromStation+"&to_station_telecode="+toStation+"&depart_date="+startDate);                
            System.Net.HttpWebRequest req = (System.Net.HttpWebRequest)HttpWebRequest.Create(uri);
            req.Method = "get";
            using (Stream s = req.GetResponse().GetResponseStream())
            {
                using (StreamReader reader = new StreamReader(s))
                {
                    string str = reader.ReadToEnd();
                    reader.Close();
                    JObject joo = (JObject)JsonConvert.DeserializeObject(str);
                    string re = joo["data"].ToString();
                    JObject da = (JObject)JsonConvert.DeserializeObject(re);
                    var data = da["data"];
                    return data;
                }
            }            
        }
        int stationnum = 0,lastlate=-1;

        private void frmuser_trainno_Load(object sender, EventArgs e)
        {
            try
            {
                if (this.Text.Equals("查看车次时刻表信息")) this.Text = this.Text + "     " + trainnumber;
                Label[] labelstation = { label1, label2, label3, label4, label5, label6, label7, label8, label9, label10, label11, label12, label13, label14, label15, label16, label17, label18, label19, label20, label21, label22, label23, label24, label25, label26, label27, label28, label29, label30, label31, label32, label33, label34, label35, label36, label37, label38, label39, label40, label41, label42, label43, label44, label45, label46, label47, label48, label49, label50, label51, label52, label53, label54, label55, label56, label57, label58, label59, label60 };
                Label[] arrivetime = { label61, label62, label63, label64, label65, label66, label67, label68, label69, label70, label71, label72, label73, label74, label75, label76, label77, label78, label79, label80, label81, label82, label83, label84, label85, label86, label87, label88, label89, label90, label91, label92, label93, label94, label95, label96, label97, label98, label99, label100, label101, label102, label103, label104, label105, label106, label107, label108, label109, label110, label111, label112, label113, label114, label115, label116, label117, label118, label119, label120 };
                Label[] starttime = { label121, label122, label123, label124, label125, label126, label127, label128, label129, label130, label131, label132, label133, label134, label135, label136, label137, label138, label139, label140, label141, label142, label143, label144, label145, label146, label147, label148, label149, label150, label151, label152, label153, label154, label155, label156, label157, label158, label159, label160, label161, label162, label163, label164, label165, label166, label167, label168, label169, label170, label171, label172, label173, label174, label175, label176, label177, label178, label179, label180 };
                Label[] late = { label181, label182, label183, label184, label185, label186, label187, label188, label189, label190, label191, label192, label193, label194, label195, label196, label197, label198, label199, label200, label201, label202, label203, label204, label205, label206, label207, label208, label209, label210, label211, label212, label213, label214, label215, label216, label217, label218, label219, label220, label221, label222, label223, label224, label225, label226, label227, label228, label229, label230, label231, label232, label233, label234, label235, label236, label237, label238, label239, label240 };
                PictureBox[] pic = { pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5, pictureBox6, pictureBox7, pictureBox8, pictureBox9, pictureBox10, pictureBox11, pictureBox12, pictureBox13, pictureBox14, pictureBox15, pictureBox16, pictureBox17, pictureBox18, pictureBox19, pictureBox20, pictureBox21, pictureBox22, pictureBox23, pictureBox24, pictureBox25, pictureBox26, pictureBox27, pictureBox28, pictureBox29, pictureBox30, pictureBox31, pictureBox32, pictureBox33, pictureBox34, pictureBox35, pictureBox36, pictureBox37, pictureBox38, pictureBox39, pictureBox40, pictureBox41, pictureBox42, pictureBox43, pictureBox44, pictureBox45, pictureBox46, pictureBox47, pictureBox48, pictureBox49, pictureBox50, pictureBox51, pictureBox52, pictureBox53, pictureBox54, pictureBox55, pictureBox56, pictureBox57, pictureBox58, pictureBox59, pictureBox60 };
                var datas = getTicketData(srcsta, dststa, traindate, trainno);
                if (datas == null) return;
                string seltrainid = "select COUNT(*) from traintable where trainid='" + trainnumber + "'";
                SqlCommand cmd = new SqlCommand(seltrainid, myConn);
                SqlDataReader readit = cmd.ExecuteReader(); //has this train id
                string latetime = "";
                stationname = "";
                if (readit.Read() && (int)readit[0] != 0)
                {
                    readit.Close(); //connection must be closed
                    string sqlzwd = "select stationname,time from zwd" + trainnumber;
                    cmd = new SqlCommand(sqlzwd, myConn);
                    readit = cmd.ExecuteReader();
                    readit.Read();
                    stationname = (string)readit[0];
                    latetime = (string)readit[1];
                    readit.Close();
                }
                else
                {
                    readit.Close();
                }
                try
                {
                    for (int i = 0; i < 1000; i++)
                    {
                        labelstation[i].Text = eli(datas[i]["station_name"].ToString());
                        arrivetime[i].Text = eli(datas[i]["arrive_time"].ToString());
                        starttime[i].Text = eli(datas[i]["start_time"].ToString());
                        if (labelstation[i].Text.Equals(stationname))
                        {
                            late[i].Visible = true;
                            late[i].Text = "晚点" + latetime + "分钟";
                            if (lastlate != -1) pic[lastlate].Image = Properties.Resources.gray;
                            pic[i].Image = Properties.Resources.red;
                            lastlate = i;
                        }
                        else
                        {
                            late[i].Visible = false;
                        }
                        stationnum++;
                        if (datas[i].Next == null) break;
                    }
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "MyProgram", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                for (int i = stationnum; i < 60; i++)
                {
                    labelstation[i].Visible = false;
                    arrivetime[i].Visible = false;
                    starttime[i].Visible = false;
                    pic[i].Visible = false;
                    late[i].Visible = false;
                }
            }
            catch(System.Exception err)
            {
                MessageBox.Show("未知错误！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            
        }

        private bool judge(int h1,int m1,int h2,int m2) //1>2 ?
        {
            if (h1 > h2 || (h1 == h2 && m1 >= m2)) return true; else return false;
        }

        private bool judgebigger(int h1,int m1,int h2,int m2)
        {
            if (h1 > h2 || (h1 == h2 && m1 > m2)) return true; else return false;
        }
        int last = -1;
        private void tmr_Tick(object sender, EventArgs e)
        {
            try
            {
                if (!stationname.Equals("")) return;
                DateTime dt = DateTime.Now;
                if (dt.Day != Convert.ToInt32(traindate.Substring(8, 2)) || dt.Month != Convert.ToInt32(traindate.Substring(5, 2)))
                {
                    //tmr.Enabled = false; return;
                }
                Label[] labelstation = { label1, label2, label3, label4, label5, label6, label7, label8, label9, label10, label11, label12, label13, label14, label15, label16, label17, label18, label19, label20, label21, label22, label23, label24, label25, label26, label27, label28, label29, label30, label31, label32, label33, label34, label35, label36, label37, label38, label39, label40, label41, label42, label43, label44, label45, label46, label47, label48, label49, label50, label51, label52, label53, label54, label55, label56, label57, label58, label59, label60 };
                Label[] arrivetime = { label61, label62, label63, label64, label65, label66, label67, label68, label69, label70, label71, label72, label73, label74, label75, label76, label77, label78, label79, label80, label81, label82, label83, label84, label85, label86, label87, label88, label89, label90, label91, label92, label93, label94, label95, label96, label97, label98, label99, label100, label101, label102, label103, label104, label105, label106, label107, label108, label109, label110, label111, label112, label113, label114, label115, label116, label117, label118, label119, label120 };
                Label[] starttime = { label121, label122, label123, label124, label125, label126, label127, label128, label129, label130, label131, label132, label133, label134, label135, label136, label137, label138, label139, label140, label141, label142, label143, label144, label145, label146, label147, label148, label149, label150, label151, label152, label153, label154, label155, label156, label157, label158, label159, label160, label161, label162, label163, label164, label165, label166, label167, label168, label169, label170, label171, label172, label173, label174, label175, label176, label177, label178, label179, label180 };
                PictureBox[] pic = { pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5, pictureBox6, pictureBox7, pictureBox8, pictureBox9, pictureBox10, pictureBox11, pictureBox12, pictureBox13, pictureBox14, pictureBox15, pictureBox16, pictureBox17, pictureBox18, pictureBox19, pictureBox20, pictureBox21, pictureBox22, pictureBox23, pictureBox24, pictureBox25, pictureBox26, pictureBox27, pictureBox28, pictureBox29, pictureBox30, pictureBox31, pictureBox32, pictureBox33, pictureBox34, pictureBox35, pictureBox36, pictureBox37, pictureBox38, pictureBox39, pictureBox40, pictureBox41, pictureBox42, pictureBox43, pictureBox44, pictureBox45, pictureBox46, pictureBox47, pictureBox48, pictureBox49, pictureBox50, pictureBox51, pictureBox52, pictureBox53, pictureBox54, pictureBox55, pictureBox56, pictureBox57, pictureBox58, pictureBox59, pictureBox60 };
                int MAXX = 0;
                if (last != -1) pic[last].Image = Properties.Resources.orange;
                for (int i = 0; i < 60; i++)
                {
                    if (labelstation[i].Visible == true) //valid
                    {
                        int hr = DateTime.Now.Hour;
                        int min = DateTime.Now.Minute;
                        int hrs, mins;
                        if (arrivetime[i].Text.Equals("----")) { hrs = 0; mins = 0; }
                        else
                        {
                            hrs = Convert.ToInt32(arrivetime[i].Text.Substring(0, 2));
                            mins = Convert.ToInt32(arrivetime[i].Text.Substring(3, 2));
                        }

                        int hre = Convert.ToInt32(starttime[i].Text.Substring(0, 2));
                        int mine = Convert.ToInt32(starttime[i].Text.Substring(3, 2));
                        if (judge(hr, min, hrs, mins) && judge(hre, mine, hr, min))
                        {
                            pic[i].Image = Properties.Resources.green;
                            last = i;
                        }
                        else
                        {
                            if (last != i) pic[i].Image = Properties.Resources.gray;
                        }
                        if (judgebigger(hr, min, hre, mine))
                        {
                            MAXX = i;
                        }
                    }
                }
                //pic[MAXX].Image = Properties.Resources.orange;
            }
            catch(System.Exception err)
            {
                MessageBox.Show("未知错误！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            
        }

        private void frmuser_trainno_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (myConn.State==ConnectionState.Open)
            {
                myConn.Close();
            }
        }
        
    }
}
