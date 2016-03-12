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
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Net;
using System.Net.Security;
using System.Security.Authentication;
using System.Security.Cryptography.X509Certificates;
using System.Data.SqlClient;
namespace getticket
{    
    public partial class frmgetofflinedata : Form
    {
        String[] s1 = { "VAP", "BOP", "BJP", "VNP", "BXP", "IZQ", "CUW", "CQW", "CRW", "GGQ", "SHH", "SNH", "AOH", "SXH", "TBP", "TJP", "TIP", "TXP", "CCT", "CET", "CRT", "ICW", "CNW", "CDW", "CSQ", "CWQ", "FZS", "FYS", "GIW", "GZQ", "GXQ", "HBB", "VBB", "VAB", "HFH", "HHC", "HMQ", "VUQ", "HGH", "HZH", "XHH", "JNK", "JAK", "JGK", "KMM", "KXM", "LSO", "LVJ", "LZJ", "LAJ", "NCG", "NJH", "NKH", "NNZ", "VVP", "SJP", "SYT", "SBT", "SDT", "TBV", "TDV", "TYV", "WHN", "EAY", "XAY", "CAY", "XNO", "YIJ", "ZZF", "CZH", "DFT", "DKM", "DLT", "LYF", "LDF", "UKH", "NVH", "NGH", "NUH", "QDK", "SEQ", "SZQ", "SZH", "OSQ", "FUP", "TSP", "WCN", "WHH", "WXH", "WAS", "RZH", "VRH", "XKS", "XMS", "XBS", "YBW", "HAN", "YCN", "AFH", "ZHQ", "ZIQ", "ZJH", "DIQ", "ZKP", "ZMP", "ESH", "VZH", "JXH", "EPH", "UEH", "LSG", "UIH", "MAH", "SOH", "OHH", "BJQ", "KAH", "ITH", "WGH", "IFH", "COH", "ENH", "NXG", "NFZ", "SLH", "YLK" };
        public frmgetofflinedata()
        {
            
            
            InitializeComponent();
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


        public static JToken getTicketData(string fromStation, string toStation, string startDate)
        {
            //获取查询的车票信息
            string url = "https://kyfw.12306.cn/otn/lcxxcx/query?purpose_codes=ADULT&queryDate=" + startDate + "&from_station=" + fromStation + "&to_station=" + toStation;
            System.Net.HttpWebRequest request = (System.Net.HttpWebRequest)System.Net.HttpWebRequest.Create(url);
            ServicePointManager.CertificatePolicy = new AcceptAllCertificatePolicy();  
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();//请求连接，并返回数据
            System.IO.StreamReader myreader = new System.IO.StreamReader(response.GetResponseStream(), Encoding.UTF8);
            string responseText = myreader.ReadToEnd();
            myreader.Close();
            JObject joo = (JObject)JsonConvert.DeserializeObject(responseText);
            string re = joo["data"].ToString();
            JObject da = (JObject)JsonConvert.DeserializeObject(re);
            var data = da["datas"];
            return data;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection myConn = new SqlConnection("Server=localhost;Integrated security=SSPI;database=master");
            try
            {
                myConn.Open();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.ToString(), "MyProgram", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }                
            for (int src=0;src<126;src++)
            {
                
                string str;
                string sqlcrt;
                SqlCommand cmd;                
                sqlcrt = "create table " +s1[src]+
                                    "(traincode char(15)," +
                                    "startcode char(15)," +
                                    "startname char(15)," +
                                    "endcode char(15)," +
                                    "endname char(15)," +
                                    "fromcode char(15)," +
                                    "fromname char(15)," +
                                    "tocode char(15)," +
                                    "toname char(15)," +
                                    "starttime char(15)," +
                                    "arrivetime char(15)," +
                                    "daydiff char(15)," +
                                    "lishi char(15)," +
                                    "swz_num char(15)," +
                                    "tz_num char(15)," +
                                    "zy_num char(15)," +
                                    "ze_num char(15)," +
                                    "gr_num char(15)," +
                                    "rw_num char(15)," +
                                    "yw_num char(15)," +
                                    "rz_num char(15)," +
                                    "yz_num char(15)," +
                                    "wz_num char(15))";             
                cmd = new SqlCommand(sqlcrt, myConn);
                cmd.ExecuteNonQuery();                
                JToken[] TrainInfoArr;                

                for (int dst=0;dst<126;dst++)
                {
                    lbl.Text = src.ToString()+" "+dst.ToString();
                    if (src == dst) continue;
                    var datas = getTicketData(s1[src], s1[dst], txtdate.Text);
                    if (datas == null) continue;
                    TrainInfoArr = datas.ToArray();
                    int arrLength = TrainInfoArr.Length;                
                    try
                    {                                           
                        for (int i = 0; i < 1000; i++)
                        {
                            sqlcrt = "insert into "+s1[src]+" values('" + datas[i]["station_train_code"].ToString() + "' , " +
                                                             "'" + datas[i]["start_station_telecode"].ToString() + "'," +
                                                             "'" + datas[i]["start_station_name"].ToString() + "'," +
                                                             "'" + datas[i]["end_station_telecode"].ToString() + "'," +
                                                             "'" + datas[i]["end_station_name"].ToString() + "'," +
                                                             "'" + datas[i]["from_station_telecode"].ToString() + "'," +
                                                             "'" + datas[i]["from_station_name"].ToString() + "'," +
                                                             "'" + datas[i]["to_station_telecode"].ToString() + "'," +
                                                             "'" + datas[i]["to_station_name"].ToString() + "'," +
                                                             "'" + datas[i]["start_time"].ToString() + "'," +
                                                             "'" + datas[i]["arrive_time"].ToString() + "'," +
                                                             "'" + datas[i]["day_difference"].ToString() + "'," +
                                                             "'" + datas[i]["lishi"].ToString() + "'," +
                                                             "'" + datas[i]["swz_num"].ToString() + "'," +
                                                             "'" + datas[i]["tz_num"].ToString() + "'," +
                                                             "'" + datas[i]["zy_num"].ToString() + "'," +
                                                             "'" + datas[i]["ze_num"].ToString() + "'," +
                                                             "'" + datas[i]["gr_num"].ToString() + "'," +
                                                             "'" + datas[i]["rw_num"].ToString() + "'," +
                                                             "'" + datas[i]["yw_num"].ToString() + "'," +
                                                             "'" + datas[i]["rz_num"].ToString() + "'," +
                                                             "'" + datas[i]["yz_num"].ToString() + "'," +
                                                             "'" + datas[i]["wz_num"].ToString() + "')";
                            cmd = new SqlCommand(sqlcrt, myConn);
                            cmd.ExecuteNonQuery();                            
                            if (datas[i].Next == null) break;
                        }
                    }
                    catch (System.Exception ex)
                    {
                        MessageBox.Show(ex.ToString(), "MyProgram", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }                                                              
                }
                //MessageBox.Show(src.ToString());                
            }
            
            if (myConn.State == ConnectionState.Open)
            {
                myConn.Close();
            }
        }
    }
}
