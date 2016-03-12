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
using System.Collections;   

namespace trainticket
{
   

    
    public partial class frmuser_offline : Form
    {
        String[] s1 = { "VAP", "BOP", "BJP", "VNP", "BXP", "IZQ", "CUW", "CQW", "CRW", "GGQ", "SHH", "SNH", "AOH", "SXH", "TBP", "TJP", "TIP", "TXP", "CCT", "CET", "CRT", "ICW", "CNW", "CDW", "CSQ", "CWQ", "FZS", "FYS", "GIW", "GZQ", "GXQ", "HBB", "VBB", "VAB", "HFH", "HHC", "HMQ", "VUQ", "HGH", "HZH", "XHH", "JNK", "JAK", "JGK", "KMM", "KXM", "LSO", "LVJ", "LZJ", "LAJ", "NCG", "NJH", "NKH", "NNZ", "VVP", "SJP", "SYT", "SBT", "SDT", "TBV", "TDV", "TYV", "WHN", "EAY", "XAY", "CAY", "XNO", "YIJ", "ZZF", "CZH", "DFT", "DKM", "DLT", "LYF", "LDF", "UKH", "NVH", "NGH", "NUH", "QDK", "SEQ", "SZQ", "SZH", "OSQ", "FUP", "TSP", "WCN", "WHH", "WXH", "WAS", "RZH", "VRH", "XKS", "XMS", "XBS", "YBW", "HAN", "YCN", "AFH", "ZHQ", "ZIQ", "ZJH", "DIQ", "ZKP", "ZMP", "ESH", "VZH", "JXH", "EPH", "UEH", "LSG", "UIH", "MAH", "SOH", "OHH", "BJQ", "KAH", "ITH", "WGH", "IFH", "COH", "ENH", "NXG", "NFZ", "SLH", "YLK" };
        String[] staname = { "北京北", "北京东", "北京", "北京南", "北京西", "广州南", "重庆北", "重庆", "重庆南", "广州东", "上海", "上海南", "上海虹桥", "上海西", "天津北", "天津", "天津南", "天津西", "长春", "长春南", "长春西", "成都东", "成都南", "成都", "长沙", "长沙南", "福州", "福州南", "贵阳", "广州", "广州西", "哈尔滨", "哈尔滨东", "哈尔滨西", "合肥", "呼和浩特", "海口东", "海口", "杭州东", "杭州", "杭州南", "济南", "济南东", "济南西", "昆明", "昆明西", "拉萨", "兰州东", "兰州", "兰州西", "南昌", "南京", "南京南", "南宁", "石家庄北", "石家庄", "沈阳", "沈阳北", "沈阳东", "太原北", "太原东", "太原", "武汉", "西安北", "西安", "西安南", "西宁", "银川", "郑州", "常州", "大连北", "大理", "大连", "洛阳", "洛阳东", "连云港东", "宁波东", "宁波", "南通", "青岛", "三亚", "深圳", "苏州", "深圳西", "唐山北", "唐山", "武昌", "芜湖", "无锡", "武夷山", "温州", "温州南", "厦门北", "厦门", "厦门高崎", "宜宾", "宜昌东", "宜昌", "盐城", "珠海", "珠海北", "镇江", "张家界", "张家口", "张家口南", "常州北", "湖州", "嘉兴", "嘉兴南", "姜堰", "庐山", "连云港", "马鞍山", "绍兴", "苏州北", "深圳东", "苏州园区", "苏州新区", "无锡东", "无锡新区", "合肥北城", "合肥南", "南昌西", "南宁东", "绍兴北", "烟台南" };
        String[] suo1 = { "beijingbei", "beijingdong", "beijing", "beijingnan", "beijingxi", "guangzhounan", "chongqingbei", "chongqing", "chongqingnan", "guangzhoudong", "shanghai", "shanghainan", "shanghaihongqiao", "shanghaixi", "tianjinbei", "tianjin", "tianjinnan", "tianjinxi", "changchun", "changchunnan", "changchunxi", "chengdudong", "chengdunan", "chengdu", "changsha", "changshanan", "fuzhou", "fuzhounan", "guiyang", "guangzhou", "guangzhouxi", "haerbin", "haerbindong", "haerbinxi", "hefei", "huhehaote", "haikoudong", "haikou", "hangzhoudong", "hangzhou", "hangzhounan", "jinan", "jinandong", "jinanxi", "kunming", "kunmingxi", "lasa", "lanzhoudong", "lanzhou", "lanzhouxi", "nanchang", "nanjing", "nanjingnan", "nanning", "shijiazhuangbei", "shijiazhuang", "shenyang", "shenyangbei", "shenyangdong", "taiyuanbei", "taiyuandong", "taiyuan", "wuhan", "xianbei", "xian", "xiannan", "xining", "yinchuan", "zhengzhou", "changzhou", "dalianbei", "dali", "dalian", "luoyang", "luoyangdong", "lianyungangdong", "ningbodong", "ningbo", "nantong", "qingdao", "sanya", "shenzhen", "suzhou", "shenzhenxi", "tangshanbei", "tangshan", "wuchang", "wuhu", "wuxi", "wuyishan", "wenzhou", "wenzhounan", "xiamenbei", "xiamen", "xiamengaoqi", "yibin", "yichangdong", "yichang", "yancheng", "zhuhai", "zhuhaibei", "zhenjiang", "zhangjiajie", "zhangjiakou", "zhangjiakounan", "changzhoubei", "huzhou", "jiaxing", "jiaxingnan", "jiangyan", "lushan", "lianyungang", "maanshan", "shaoxing", "suzhoubei", "shenzhendong", "suzhouyuanqu", "suzhouxinqu", "wuxidong", "wuxixinqu", "hefeibeicheng", "hefeinan", "nanchangxi", "nanningdong", "shaoxingbei", "yantainan" };
        String[] suo2 = { "bjb", "bjd", "bj", "bjn", "bjx", "gzn", "cqb", "cq", "cqn", "gzd", "sh", "shn", "shhq", "shx", "tjb", "tj", "tjn", "tjx", "cc", "ccn", "ccx", "cdd", "cdn", "cd", "cs", "csn", "fz", "fzn", "gy", "gz", "gzx", "heb", "hebd", "hebx", "hf", "hhht", "hkd", "hk", "hzd", "hz", "hzn", "jn", "jnd", "jnx", "km", "kmx", "ls", "lzd", "lz", "lzx", "nc", "nj", "njn", "nn", "sjzb", "sjz", "sy", "syb", "syd", "tyb", "tyd", "ty", "wh", "xab", "xa", "xan", "xn", "yc", "zz", "cz", "dlb", "dl", "dl", "ly", "lyd", "lygd", "nbd", "nb", "nt", "qd", "sy", "sz", "sz", "szx", "tsb", "ts", "wc", "wh", "wx", "wys", "wz", "wzn", "xmb", "xm", "xmgq", "yb", "ycd", "yc", "yc", "zh", "zhb", "zj", "zjj", "zjk", "zjkn", "czb", "hz", "jx", "jxn", "jy", "ls", "lyg", "mas", "sx", "szb", "szd", "szyq", "szxq", "wxd", "wxxq", "hfbc", "hfn", "ncx", "nnd", "sxb", "ytn"};
        public frmuser_main f1;
        public frmuser_offline()
        {
            InitializeComponent();
            ImageList imageList = new ImageList();   //设置行高20
            imageList.ImageSize = new System.Drawing.Size(1, 40);   //分别是宽和高            
            lstquery.SmallImageList = imageList;  
        }
        public class ListViewHelper
        {           
            public ListViewHelper()
            {
               
            }

            public static void ListView_ColumnClick(object sender, ColumnClickEventArgs e)
            {
                ListView lv = sender as ListView;              
                if (e.Column == (lv.ListViewItemSorter as ListViewColumnSorter).SortColumn)
                {                    
                    if ((lv.ListViewItemSorter as ListViewColumnSorter).Order == System.Windows.Forms.SortOrder.Ascending)
                    {
                        (lv.ListViewItemSorter as ListViewColumnSorter).Order = System.Windows.Forms.SortOrder.Descending;
                    }
                    else
                    {
                        (lv.ListViewItemSorter as ListViewColumnSorter).Order = System.Windows.Forms.SortOrder.Ascending;
                    }
                }
                else
                {                   
                    (lv.ListViewItemSorter as ListViewColumnSorter).SortColumn = e.Column;
                    (lv.ListViewItemSorter as ListViewColumnSorter).Order = System.Windows.Forms.SortOrder.Ascending;
                }               
                ((ListView)sender).Sort();
            }
        }
       
        public class ListViewColumnSorter : IComparer
        {           
            private int ColumnToSort;           
            private System.Windows.Forms.SortOrder OrderOfSort;            
            private CaseInsensitiveComparer ObjectCompare;
          
            public ListViewColumnSorter()
            {               
                ColumnToSort = 0;
                OrderOfSort = System.Windows.Forms.SortOrder.None;
                ObjectCompare = new CaseInsensitiveComparer();
            }
            public int Compare(object x, object y)
            {
                int compareResult;
                ListViewItem listviewX, listviewY;
                listviewX = (ListViewItem)x;
                listviewY = (ListViewItem)y;
                compareResult = ObjectCompare.Compare(listviewX.SubItems[ColumnToSort].Text, listviewY.SubItems[ColumnToSort].Text);
                if (OrderOfSort == System.Windows.Forms.SortOrder.Ascending)
                {                  
                    return compareResult;
                }
                else if (OrderOfSort == System.Windows.Forms.SortOrder.Descending)
                {                   
                    return (-compareResult);
                }
                else
                {                 
                    return 0;
                }
            }
            public int SortColumn
            {
                set
                {
                    ColumnToSort = value;
                }
                get
                {
                    return ColumnToSort;
                }
            }

            public System.Windows.Forms.SortOrder Order
            {
                set
                {
                    OrderOfSort = value;
                }
                get
                {
                    return OrderOfSort;
                }
            }
        }

 

        private void txtsrc_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtsrc.TextLength == 0) { lstsrc.Visible = false; return; }
                lstsrc.Visible = true;
                lstsrc.Items.Clear();
                for (int i = 0; i < 126; i++)
                {
                    if (staname[i].Length >= txtsrc.TextLength && staname[i].Substring(0, txtsrc.TextLength).Equals(txtsrc.Text)
                       || suo1[i].Length >= txtsrc.TextLength && suo1[i].Substring(0, txtsrc.TextLength).Equals(txtsrc.Text)
                       || suo2[i].Length >= txtsrc.TextLength && suo2[i].Substring(0, txtsrc.TextLength).Equals(txtsrc.Text)
                        )
                    {
                        lstsrc.Items.Add(staname[i]);
                    }
                }
                if (lstsrc.Items.Count == 0) lstsrc.Visible = false;
            }
            catch(System.Exception err)
            {
                return;
            }            
        }

        private void lstsrc_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                txtsrc.Text = lstsrc.Items[lstsrc.SelectedIndex].ToString();
            }
            catch(System.Exception err)
            {
                return;
            }            
        }

        private void txtdst_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtdst.TextLength == 0) { lstdst.Visible = false; return; }
                lstdst.Visible = true;
                lstdst.Items.Clear();
                for (int i = 0; i < 126; i++)
                {
                    if (staname[i].Length >= txtdst.TextLength && staname[i].Substring(0, txtdst.TextLength).Equals(txtdst.Text)
                       || suo1[i].Length >= txtdst.TextLength && suo1[i].Substring(0, txtdst.TextLength).Equals(txtdst.Text)
                       || suo2[i].Length >= txtdst.TextLength && suo2[i].Substring(0, txtdst.TextLength).Equals(txtdst.Text)
                        )
                    {
                        lstdst.Items.Add(staname[i]);
                    }
                }
                if (lstdst.Items.Count == 0) lstdst.Visible = false;
            }
            catch(System.Exception err)
            {
                return;
            }                       
        }

        private void lstdst_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                txtdst.Text = lstdst.Items[lstdst.SelectedIndex].ToString();
            }
            catch(System.Exception err)
            {
                return;
            }            
        }
        
        private void btnexchange_Click(object sender, EventArgs e)
        {
            try
            {
                string tmp = txtsrc.Text;
                txtsrc.Text = txtdst.Text;
                txtdst.Text = tmp;
            }
            catch(System.Exception err)
            {
                return;
            }            
        }

        private void btnquery_MouseMove(object sender, MouseEventArgs e)
        {
            this.Cursor = System.Windows.Forms.Cursors.Hand;
        }

        private void frmoffline_MouseMove(object sender, MouseEventArgs e)
        {
            this.Cursor = System.Windows.Forms.Cursors.Default;
        }
        private string gets(string s)
        {            
            try
            {
                int len = s.Length;
                while (s[len - 1] != '\"') len--;
                return s.Substring(1, len - 2);
            }
            catch(System.Exception err)
            {
                return "";
            }            
        }
        private void btnquery_Click(object sender, EventArgs e)
        {
            try
            {
                int src = -1, dst = -1;
                for (int i = 0; i < 126; i++)
                {
                    if (txtsrc.Text.Equals(staname[i])) { src = i; break; }
                }
                for (int i = 0; i < 126; i++)
                {
                    if (txtdst.Text.Equals(staname[i])) { dst = i; break; }
                }
                lstquery.Items.Clear();
                if (src == -1 || dst == -1)
                {
                    return;
                }
                SqlConnection conn = new SqlConnection("Server=localhost;Integrated security=SSPI;database=master");
                try
                {
                    conn.Open();
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "MyProgram", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                string sql;
                if (chklikely.Checked == false) sql = "select distinct * from dbo." + s1[src] + " where fromcode='\"" + s1[src] + "\"' and tocode='\"" + s1[dst] + "\"'";
                else sql = "select distinct * from dbo." + s1[src] + " where fromname like '\"" + staname[src] + "%\"' and toname like '\"" + staname[dst] + "%\"'";
                string addtype = "";
                int flag = 0;
                if (chkC.Checked == true)
                {
                    if (flag == 0)
                    {
                        addtype = addtype + " and ((traincode like '\"C%')";
                        flag = 1;
                    }
                    else
                    {
                        addtype = addtype + " or (traincode like '\"C%')";
                    }
                }
                if (chkD.Checked == true)
                {
                    if (flag == 0)
                    {
                        addtype = addtype + " and ((traincode like '\"D%')";
                        flag = 1;
                    }
                    else
                    {
                        addtype = addtype + " or (traincode like '\"D%')";
                    }
                }
                if (chkG.Checked == true)
                {
                    if (flag == 0)
                    {
                        addtype = addtype + " and ((traincode like '\"G%')";
                        flag = 1;
                    }
                    else
                    {
                        addtype = addtype + " or (traincode like '\"G%')";
                    }
                }
                if (chkT.Checked == true)
                {
                    if (flag == 0)
                    {
                        addtype = addtype + " and ((traincode like '\"T%')";
                        flag = 1;
                    }
                    else
                    {
                        addtype = addtype + " or (traincode like '\"T%')";
                    }
                }
                if (chkK.Checked == true)
                {
                    if (flag == 0)
                    {
                        addtype = addtype + " and ((traincode like '\"K%')";
                        flag = 1;
                    }
                    else
                    {
                        addtype = addtype + " or (traincode like '\"K%')";
                    }
                }
                if (chkP.Checked == true)
                {
                    if (flag == 0)
                    {
                        addtype = addtype + " and (((traincode like '\"0%') or (traincode like '\"1%') or (traincode like '\"2%') or (traincode like '\"3%') or (traincode like '\"4%') or (traincode like '\"5%') or (traincode like '\"6%') or (traincode like '\"7%') or (traincode like '\"8%') or (traincode like '\"9%'))";
                        flag = 1;
                    }
                    else
                    {
                        addtype = addtype + " or ((traincode like '\"0%') or (traincode like '\"1%') or (traincode like '\"2%') or (traincode like '\"3%') or (traincode like '\"4%') or (traincode like '\"5%') or (traincode like '\"6%') or (traincode like '\"7%') or (traincode like '\"8%') or (traincode like '\"9%'))";
                    }
                }
                if (flag == 1) addtype = addtype + ")";
                sql = sql + addtype;
                if (chksf.Checked == true && chkgl.Checked == false) sql = sql + " and fromcode=startcode";
                if (chkgl.Checked == true && chksf.Checked == false) sql = sql + " and fromcode<>startcode";
                flag = 0;
                if (chkseatswz.Checked == true)
                {

                    if (flag == 0)
                    {
                        sql += " and ((swz_num<>'\"--\"' and swz_num<>'\"无\"' and swz_num<>'\"*\"')";
                        flag = 1;
                    }
                    else
                    {
                        sql += " or (swz_num<>'\"--\"' and swz_num<>'\"无\"' and swz_num<>'\"*\"')";
                    }
                }
                if (chkseattdz.Checked == true)
                {
                    if (flag == 0)
                    {
                        sql += " and ((tz_num<>'\"--\"' and tz_num<>'\"无\"' and tz_num<>'\"*\"')";
                        flag = 1;
                    }
                    else
                    {
                        sql += " or (tz_num<>'\"--\"' and tz_num<>'\"无\"' and tz_num<>'\"*\"')";
                    }
                }
                if (chkseatydz.Checked == true)
                {
                    if (flag == 0)
                    {
                        sql += " and ((zy_num<>'\"--\"' and zy_num<>'\"无\"' and zy_num<>'\"*\"')";
                        flag = 1;
                    }
                    else
                    {
                        sql += " or (zy_num<>'\"--\"' and zy_num<>'\"无\"' and zy_num<>'\"*\"')";
                    }
                }
                if (chkseatedz.Checked == true)
                {
                    if (flag == 0)
                    {
                        sql += " and ((ze_num<>'\"--\"' and ze_num<>'\"无\"' and ze_num<>'\"*\"')";
                        flag = 1;
                    }
                    else
                    {
                        sql += " or (ze_num<>'\"--\"' and ze_num<>'\"无\"' and ze_num<>'\"*\"')";
                    }
                }
                if (chkseatgjrw.Checked == true)
                {
                    if (flag == 0)
                    {
                        sql += " and ((gr_num<>'\"--\"' and gr_num<>'\"无\"' and gr_num<>'\"*\"')";
                        flag = 1;
                    }
                    else
                    {
                        sql += " or (gr_num<>'\"--\"' and gr_num<>'\"无\"' and gr_num<>'\"*\"')";
                    }
                }
                if (chkseatrw.Checked == true)
                {
                    if (flag == 0)
                    {
                        sql += " and ((rw_num<>'\"--\"' and rw_num<>'\"无\"' and rw_num<>'\"*\"')";
                        flag = 1;
                    }
                    else
                    {
                        sql += " or (rw_num<>'\"--\"' and rw_num<>'\"无\"' and rw_num<>'\"*\"')";
                    }
                }
                if (chkseatyw.Checked == true)
                {
                    if (flag == 0)
                    {
                        sql += " and ((yw_num<>'\"--\"' and yw_num<>'\"无\"' and yw_num<>'\"*\"')";
                        flag = 1;
                    }
                    else
                    {
                        sql += " or (yw_num<>'\"--\"' and yw_num<>'\"无\"' and yw_num<>'\"*\"')";
                    }
                }
                if (chkseatrz.Checked == true)
                {
                    if (flag == 0)
                    {
                        sql += " and ((rz_num<>'\"--\"' and rz_num<>'\"无\"' and rz_num<>'\"*\"')";
                        flag = 1;
                    }
                    else
                    {
                        sql += " or (rz_num<>'\"--\"' and rz_num<>'\"无\"' and rz_num<>'\"*\"')";
                    }
                }
                if (chkseatyz.Checked == true)
                {
                    if (flag == 0)
                    {
                        sql += " and ((yz_num<>'\"--\"' and yz_num<>'\"无\"' and yz_num<>'\"*\"')";
                        flag = 1;
                    }
                    else
                    {
                        sql += " or (yz_num<>'\"--\"' and yz_num<>'\"无\"' and yz_num<>'\"*\"')";
                    }
                }
                if (chkseatwz.Checked == true)
                {
                    if (flag == 0)
                    {
                        sql += " and ((wz_num<>'\"--\"' and wz_num<>'\"无\"' and wz_num<>'\"*\"')";
                        flag = 1;
                    }
                    else
                    {
                        sql += " or (wz_num<>'\"--\"' and wz_num<>'\"无\"' and wz_num<>'\"*\"')";
                    }
                }
                if (flag == 1) sql += ")";
                sql += " and (starttime between '\"" + txtstart1.Text + "        \"' and '\"" + txtstart2.Text + "        \"')";
                sql += " and (arrivetime between '\"" + txtend1.Text + "         \"' and '\"" + txtend2.Text + "        \"')";
                sql += " and (lishi between '\"" + txtinterval1.Text + "        \"' and '\"" + txtinterval2.Text + "        \"')";
                ListViewGroup G = new ListViewGroup();
                ListViewGroup C = new ListViewGroup();
                ListViewGroup D = new ListViewGroup();
                ListViewGroup Z = new ListViewGroup();
                ListViewGroup T = new ListViewGroup();
                ListViewGroup K = new ListViewGroup();
                ListViewGroup P = new ListViewGroup();
                if (chktype.Checked == true)
                {
                    sql += " order by traincode ";
                    if (radiodesc.Checked == true) sql += "desc"; else sql += "asc";

                    G.Header = "高铁";
                    G.HeaderAlignment = HorizontalAlignment.Left;

                    C.Header = "城际";
                    C.HeaderAlignment = HorizontalAlignment.Left;

                    D.Header = "动车";
                    D.HeaderAlignment = HorizontalAlignment.Left;

                    Z.Header = "直达";
                    Z.HeaderAlignment = HorizontalAlignment.Left;

                    T.Header = "特快";
                    T.HeaderAlignment = HorizontalAlignment.Left;

                    K.Header = "快速";
                    K.HeaderAlignment = HorizontalAlignment.Left;

                    P.Header = "普通";
                    P.HeaderAlignment = HorizontalAlignment.Left;
                    if (radiodesc.Checked == true)
                    {
                        lstquery.Groups.Add(Z);
                        lstquery.Groups.Add(T);
                        lstquery.Groups.Add(K);
                        lstquery.Groups.Add(G);
                        lstquery.Groups.Add(D);
                        lstquery.Groups.Add(C);
                        lstquery.Groups.Add(P);
                    }
                    else
                    {
                        lstquery.Groups.Add(P);
                        lstquery.Groups.Add(C);
                        lstquery.Groups.Add(D);
                        lstquery.Groups.Add(G);
                        lstquery.Groups.Add(K);
                        lstquery.Groups.Add(T);
                        lstquery.Groups.Add(Z);
                    }
                    lstquery.ShowGroups = true;

                }
                SqlCommand comm = new SqlCommand(sql, conn);
                SqlDataReader reader = comm.ExecuteReader();
                string ts;
                int cnt = 0;
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        ListViewItem lvi = new ListViewItem();
                        cnt++;
                        lvi.Text = cnt.ToString();
                        lvi.SubItems.Add(gets((string)reader[0]));
                        for (int i = 1; i <= 4; i++)
                        {
                            ts = gets((string)reader[2 * i]);
                            lvi.SubItems.Add(ts);
                        }
                        for (int i = 9; i <= 10; i++)
                        {
                            ts = gets((string)reader[i]);
                            lvi.SubItems.Add(ts);
                        }
                        for (int i = 12; i <= 22; i++)
                        {
                            ts = gets((string)reader[i]);
                            lvi.SubItems.Add(ts);
                        }
                        if (chktype.Checked == true)
                        {
                            switch ((lvi.SubItems[1].ToString())[18])
                            {
                                case 'Z':
                                    lvi.Group = Z; break;
                                case 'T':
                                    lvi.Group = T; break;
                                case 'K':
                                    lvi.Group = K; break;
                                case 'G':
                                    lvi.Group = G; break;
                                case 'D':
                                    lvi.Group = D; break;
                                case 'C':
                                    lvi.Group = C; break;
                                default:
                                    lvi.Group = P; break;
                            }
                        }
                        lstquery.Items.Add(lvi);
                    }
                }
                conn.Close();
            }
            catch(System.Exception err)
            {
                return;
            }
            
            
        }

        private void lstquery_MouseMove(object sender, MouseEventArgs e)
        {
            this.Cursor = System.Windows.Forms.Cursors.Hand;
        }

        private void lstquery_SelectedIndexChanged(object sender, EventArgs e)
        {
            int t = lstquery.SelectedIndices[0];
        }

        private void frmoffline_Load(object sender, EventArgs e)
        {
            try
            {
                this.lstquery.ListViewItemSorter = new ListViewColumnSorter();
                this.lstquery.ColumnClick += new ColumnClickEventHandler(ListViewHelper.ListView_ColumnClick);
                chkall.Checked = true;
                chksfglall.Checked = true;
            }
            catch(System.Exception err)
            {
                return;
            }
        }
        private void chkall_CheckedChanged(object sender, EventArgs e)
        {
            chkC.Checked = chkD.Checked = chkG.Checked = chkK.Checked = chkP.Checked = chkT.Checked = chkall.Checked;
        }

        private void chksfglall_CheckedChanged(object sender, EventArgs e)
        {
            chksf.Checked = chkgl.Checked = chksfglall.Checked;
        }

        private void chkseatall_CheckedChanged(object sender, EventArgs e)
        {
            chkseatswz.Checked = chkseattdz.Checked = chkseatydz.Checked = chkseatedz.Checked = chkseatgjrw.Checked = chkseatrw.Checked = chkseatyw.Checked = chkseatrz.Checked = chkseatyz.Checked = chkseatwz.Checked = chkseatall.Checked;
        }




        private void frmoffline_FormClosed(object sender, FormClosedEventArgs e)
        {
            //f1.Show();
        }
    }
}
