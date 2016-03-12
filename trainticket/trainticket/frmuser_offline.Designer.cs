namespace trainticket
{
    partial class frmuser_offline
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmuser_offline));
            this.lblsrc = new System.Windows.Forms.Label();
            this.txtsrc = new System.Windows.Forms.TextBox();
            this.lstsrc = new System.Windows.Forms.ListBox();
            this.lbldst = new System.Windows.Forms.Label();
            this.txtdst = new System.Windows.Forms.TextBox();
            this.lstdst = new System.Windows.Forms.ListBox();
            this.btnexchange = new System.Windows.Forms.Button();
            this.btnquery = new System.Windows.Forms.Button();
            this.lstquery = new System.Windows.Forms.ListView();
            this.columnHeader19 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader16 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader17 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader18 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chklikely = new System.Windows.Forms.CheckBox();
            this.chktype = new System.Windows.Forms.CheckBox();
            this.radiodesc = new System.Windows.Forms.RadioButton();
            this.radioasc = new System.Windows.Forms.RadioButton();
            this.lbltype = new System.Windows.Forms.Label();
            this.chkall = new System.Windows.Forms.CheckBox();
            this.chkG = new System.Windows.Forms.CheckBox();
            this.chkC = new System.Windows.Forms.CheckBox();
            this.chkD = new System.Windows.Forms.CheckBox();
            this.chkT = new System.Windows.Forms.CheckBox();
            this.chkK = new System.Windows.Forms.CheckBox();
            this.chkP = new System.Windows.Forms.CheckBox();
            this.lblsfgl = new System.Windows.Forms.Label();
            this.chksf = new System.Windows.Forms.CheckBox();
            this.chkgl = new System.Windows.Forms.CheckBox();
            this.chksfglall = new System.Windows.Forms.CheckBox();
            this.lblseat = new System.Windows.Forms.Label();
            this.chkseatall = new System.Windows.Forms.CheckBox();
            this.chkseatswz = new System.Windows.Forms.CheckBox();
            this.chkseattdz = new System.Windows.Forms.CheckBox();
            this.chkseatydz = new System.Windows.Forms.CheckBox();
            this.chkseatedz = new System.Windows.Forms.CheckBox();
            this.chkseatgjrw = new System.Windows.Forms.CheckBox();
            this.chkseatrw = new System.Windows.Forms.CheckBox();
            this.chkseatyw = new System.Windows.Forms.CheckBox();
            this.chkseatrz = new System.Windows.Forms.CheckBox();
            this.chkseatyz = new System.Windows.Forms.CheckBox();
            this.chkseatwz = new System.Windows.Forms.CheckBox();
            this.lblstarttime = new System.Windows.Forms.Label();
            this.txtstart1 = new System.Windows.Forms.TextBox();
            this.txtstart2 = new System.Windows.Forms.TextBox();
            this.lblto1 = new System.Windows.Forms.Label();
            this.lblendtime = new System.Windows.Forms.Label();
            this.txtend1 = new System.Windows.Forms.TextBox();
            this.lblto2 = new System.Windows.Forms.Label();
            this.txtend2 = new System.Windows.Forms.TextBox();
            this.lblinterval = new System.Windows.Forms.Label();
            this.txtinterval1 = new System.Windows.Forms.TextBox();
            this.lblto3 = new System.Windows.Forms.Label();
            this.txtinterval2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblsrc
            // 
            this.lblsrc.AutoSize = true;
            this.lblsrc.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblsrc.Location = new System.Drawing.Point(41, 9);
            this.lblsrc.Name = "lblsrc";
            this.lblsrc.Size = new System.Drawing.Size(59, 16);
            this.lblsrc.TabIndex = 0;
            this.lblsrc.Text = "出发地";
            // 
            // txtsrc
            // 
            this.txtsrc.Location = new System.Drawing.Point(106, 7);
            this.txtsrc.Name = "txtsrc";
            this.txtsrc.Size = new System.Drawing.Size(102, 21);
            this.txtsrc.TabIndex = 1;
            this.txtsrc.TextChanged += new System.EventHandler(this.txtsrc_TextChanged);
            // 
            // lstsrc
            // 
            this.lstsrc.FormattingEnabled = true;
            this.lstsrc.ItemHeight = 12;
            this.lstsrc.Location = new System.Drawing.Point(106, 28);
            this.lstsrc.Name = "lstsrc";
            this.lstsrc.Size = new System.Drawing.Size(102, 136);
            this.lstsrc.TabIndex = 2;
            this.lstsrc.Visible = false;
            this.lstsrc.SelectedIndexChanged += new System.EventHandler(this.lstsrc_SelectedIndexChanged);
            // 
            // lbldst
            // 
            this.lbldst.AutoSize = true;
            this.lbldst.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbldst.Location = new System.Drawing.Point(254, 9);
            this.lbldst.Name = "lbldst";
            this.lbldst.Size = new System.Drawing.Size(59, 16);
            this.lbldst.TabIndex = 3;
            this.lbldst.Text = "目的地";
            // 
            // txtdst
            // 
            this.txtdst.Location = new System.Drawing.Point(313, 7);
            this.txtdst.Name = "txtdst";
            this.txtdst.Size = new System.Drawing.Size(102, 21);
            this.txtdst.TabIndex = 4;
            this.txtdst.TextChanged += new System.EventHandler(this.txtdst_TextChanged);
            // 
            // lstdst
            // 
            this.lstdst.FormattingEnabled = true;
            this.lstdst.ItemHeight = 12;
            this.lstdst.Location = new System.Drawing.Point(313, 28);
            this.lstdst.Name = "lstdst";
            this.lstdst.Size = new System.Drawing.Size(102, 136);
            this.lstdst.TabIndex = 5;
            this.lstdst.Visible = false;
            this.lstdst.SelectedIndexChanged += new System.EventHandler(this.lstdst_SelectedIndexChanged);
            // 
            // btnexchange
            // 
            this.btnexchange.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnexchange.BackgroundImage")));
            this.btnexchange.Location = new System.Drawing.Point(222, 5);
            this.btnexchange.Name = "btnexchange";
            this.btnexchange.Size = new System.Drawing.Size(26, 26);
            this.btnexchange.TabIndex = 6;
            this.btnexchange.UseVisualStyleBackColor = true;
            this.btnexchange.Click += new System.EventHandler(this.btnexchange_Click);
            // 
            // btnquery
            // 
            this.btnquery.BackColor = System.Drawing.Color.Transparent;
            this.btnquery.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnquery.BackgroundImage")));
            this.btnquery.FlatAppearance.BorderSize = 0;
            this.btnquery.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnquery.ForeColor = System.Drawing.Color.Transparent;
            this.btnquery.Location = new System.Drawing.Point(421, 3);
            this.btnquery.Name = "btnquery";
            this.btnquery.Size = new System.Drawing.Size(119, 30);
            this.btnquery.TabIndex = 7;
            this.btnquery.UseVisualStyleBackColor = false;
            this.btnquery.Click += new System.EventHandler(this.btnquery_Click);
            this.btnquery.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnquery_MouseMove);
            // 
            // lstquery
            // 
            this.lstquery.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader19,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader7,
            this.columnHeader1,
            this.columnHeader6,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12,
            this.columnHeader13,
            this.columnHeader14,
            this.columnHeader15,
            this.columnHeader16,
            this.columnHeader17,
            this.columnHeader18});
            this.lstquery.FullRowSelect = true;
            this.lstquery.Location = new System.Drawing.Point(12, 169);
            this.lstquery.Name = "lstquery";
            this.lstquery.Size = new System.Drawing.Size(1306, 525);
            this.lstquery.TabIndex = 8;
            this.lstquery.UseCompatibleStateImageBehavior = false;
            this.lstquery.View = System.Windows.Forms.View.Details;
            this.lstquery.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnquery_MouseMove);
            // 
            // columnHeader19
            // 
            this.columnHeader19.Text = "编号";
            this.columnHeader19.Width = 40;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "车次";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "始发站";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "终到站";
            this.columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "出发站";
            this.columnHeader5.Width = 100;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "到达站";
            this.columnHeader7.Width = 100;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "出发时间";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "到达时间";
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "历时";
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "商务座";
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "特等座";
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "一等座";
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "二等座";
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "高级软卧";
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "软卧";
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "硬卧";
            // 
            // columnHeader16
            // 
            this.columnHeader16.Text = "软座";
            // 
            // columnHeader17
            // 
            this.columnHeader17.Text = "硬座";
            // 
            // columnHeader18
            // 
            this.columnHeader18.Text = "无座";
            // 
            // chklikely
            // 
            this.chklikely.AutoSize = true;
            this.chklikely.Location = new System.Drawing.Point(421, 39);
            this.chklikely.Name = "chklikely";
            this.chklikely.Size = new System.Drawing.Size(72, 16);
            this.chklikely.TabIndex = 9;
            this.chklikely.Text = "模糊查询";
            this.chklikely.UseVisualStyleBackColor = true;
            // 
            // chktype
            // 
            this.chktype.AutoSize = true;
            this.chktype.Location = new System.Drawing.Point(421, 61);
            this.chktype.Name = "chktype";
            this.chktype.Size = new System.Drawing.Size(96, 16);
            this.chktype.TabIndex = 10;
            this.chktype.Text = "按车类型分组";
            this.chktype.UseVisualStyleBackColor = true;
            // 
            // radiodesc
            // 
            this.radiodesc.AutoSize = true;
            this.radiodesc.Location = new System.Drawing.Point(421, 83);
            this.radiodesc.Name = "radiodesc";
            this.radiodesc.Size = new System.Drawing.Size(47, 16);
            this.radiodesc.TabIndex = 11;
            this.radiodesc.Text = "降序";
            this.radiodesc.UseVisualStyleBackColor = true;
            // 
            // radioasc
            // 
            this.radioasc.AutoSize = true;
            this.radioasc.Checked = true;
            this.radioasc.Location = new System.Drawing.Point(470, 83);
            this.radioasc.Name = "radioasc";
            this.radioasc.Size = new System.Drawing.Size(47, 16);
            this.radioasc.TabIndex = 12;
            this.radioasc.TabStop = true;
            this.radioasc.Text = "升序";
            this.radioasc.UseVisualStyleBackColor = true;
            // 
            // lbltype
            // 
            this.lbltype.AutoSize = true;
            this.lbltype.Location = new System.Drawing.Point(419, 104);
            this.lbltype.Name = "lbltype";
            this.lbltype.Size = new System.Drawing.Size(53, 12);
            this.lbltype.TabIndex = 13;
            this.lbltype.Text = "车次类型";
            // 
            // chkall
            // 
            this.chkall.AutoSize = true;
            this.chkall.Location = new System.Drawing.Point(474, 103);
            this.chkall.Name = "chkall";
            this.chkall.Size = new System.Drawing.Size(48, 16);
            this.chkall.TabIndex = 14;
            this.chkall.Text = "全部";
            this.chkall.UseVisualStyleBackColor = true;
            this.chkall.CheckedChanged += new System.EventHandler(this.chkall_CheckedChanged);
            // 
            // chkG
            // 
            this.chkG.AutoSize = true;
            this.chkG.Location = new System.Drawing.Point(522, 103);
            this.chkG.Name = "chkG";
            this.chkG.Size = new System.Drawing.Size(60, 16);
            this.chkG.TabIndex = 15;
            this.chkG.Text = "G-高铁";
            this.chkG.UseVisualStyleBackColor = true;
            // 
            // chkC
            // 
            this.chkC.AutoSize = true;
            this.chkC.Location = new System.Drawing.Point(579, 103);
            this.chkC.Name = "chkC";
            this.chkC.Size = new System.Drawing.Size(60, 16);
            this.chkC.TabIndex = 16;
            this.chkC.Text = "C-城际";
            this.chkC.UseVisualStyleBackColor = true;
            // 
            // chkD
            // 
            this.chkD.AutoSize = true;
            this.chkD.Location = new System.Drawing.Point(637, 103);
            this.chkD.Name = "chkD";
            this.chkD.Size = new System.Drawing.Size(60, 16);
            this.chkD.TabIndex = 17;
            this.chkD.Text = "D-动车";
            this.chkD.UseVisualStyleBackColor = true;
            // 
            // chkT
            // 
            this.chkT.AutoSize = true;
            this.chkT.Location = new System.Drawing.Point(694, 103);
            this.chkT.Name = "chkT";
            this.chkT.Size = new System.Drawing.Size(60, 16);
            this.chkT.TabIndex = 18;
            this.chkT.Text = "T-特快";
            this.chkT.UseVisualStyleBackColor = true;
            // 
            // chkK
            // 
            this.chkK.AutoSize = true;
            this.chkK.Location = new System.Drawing.Point(751, 103);
            this.chkK.Name = "chkK";
            this.chkK.Size = new System.Drawing.Size(60, 16);
            this.chkK.TabIndex = 19;
            this.chkK.Text = "K-快速";
            this.chkK.UseVisualStyleBackColor = true;
            // 
            // chkP
            // 
            this.chkP.AutoSize = true;
            this.chkP.Location = new System.Drawing.Point(808, 103);
            this.chkP.Name = "chkP";
            this.chkP.Size = new System.Drawing.Size(48, 16);
            this.chkP.TabIndex = 20;
            this.chkP.Text = "普快";
            this.chkP.UseVisualStyleBackColor = true;
            // 
            // lblsfgl
            // 
            this.lblsfgl.AutoSize = true;
            this.lblsfgl.Location = new System.Drawing.Point(419, 124);
            this.lblsfgl.Name = "lblsfgl";
            this.lblsfgl.Size = new System.Drawing.Size(53, 12);
            this.lblsfgl.TabIndex = 21;
            this.lblsfgl.Text = "始发过路";
            // 
            // chksf
            // 
            this.chksf.AutoSize = true;
            this.chksf.Location = new System.Drawing.Point(522, 123);
            this.chksf.Name = "chksf";
            this.chksf.Size = new System.Drawing.Size(48, 16);
            this.chksf.TabIndex = 22;
            this.chksf.Text = "始发";
            this.chksf.UseVisualStyleBackColor = true;
            // 
            // chkgl
            // 
            this.chkgl.AutoSize = true;
            this.chkgl.Location = new System.Drawing.Point(579, 123);
            this.chkgl.Name = "chkgl";
            this.chkgl.Size = new System.Drawing.Size(48, 16);
            this.chkgl.TabIndex = 23;
            this.chkgl.Text = "过路";
            this.chkgl.UseVisualStyleBackColor = true;
            // 
            // chksfglall
            // 
            this.chksfglall.AutoSize = true;
            this.chksfglall.Location = new System.Drawing.Point(474, 123);
            this.chksfglall.Name = "chksfglall";
            this.chksfglall.Size = new System.Drawing.Size(48, 16);
            this.chksfglall.TabIndex = 24;
            this.chksfglall.Text = "全部";
            this.chksfglall.UseVisualStyleBackColor = true;
            this.chksfglall.CheckedChanged += new System.EventHandler(this.chksfglall_CheckedChanged);
            // 
            // lblseat
            // 
            this.lblseat.AutoSize = true;
            this.lblseat.Location = new System.Drawing.Point(419, 144);
            this.lblseat.Name = "lblseat";
            this.lblseat.Size = new System.Drawing.Size(29, 12);
            this.lblseat.TabIndex = 25;
            this.lblseat.Text = "席别";
            // 
            // chkseatall
            // 
            this.chkseatall.AutoSize = true;
            this.chkseatall.Location = new System.Drawing.Point(474, 143);
            this.chkseatall.Name = "chkseatall";
            this.chkseatall.Size = new System.Drawing.Size(48, 16);
            this.chkseatall.TabIndex = 26;
            this.chkseatall.Text = "全部";
            this.chkseatall.UseVisualStyleBackColor = true;
            this.chkseatall.CheckedChanged += new System.EventHandler(this.chkseatall_CheckedChanged);
            // 
            // chkseatswz
            // 
            this.chkseatswz.AutoSize = true;
            this.chkseatswz.Location = new System.Drawing.Point(522, 143);
            this.chkseatswz.Name = "chkseatswz";
            this.chkseatswz.Size = new System.Drawing.Size(60, 16);
            this.chkseatswz.TabIndex = 27;
            this.chkseatswz.Text = "商务座";
            this.chkseatswz.UseVisualStyleBackColor = true;
            // 
            // chkseattdz
            // 
            this.chkseattdz.AutoSize = true;
            this.chkseattdz.Location = new System.Drawing.Point(579, 143);
            this.chkseattdz.Name = "chkseattdz";
            this.chkseattdz.Size = new System.Drawing.Size(60, 16);
            this.chkseattdz.TabIndex = 28;
            this.chkseattdz.Text = "特等座";
            this.chkseattdz.UseVisualStyleBackColor = true;
            // 
            // chkseatydz
            // 
            this.chkseatydz.AutoSize = true;
            this.chkseatydz.Location = new System.Drawing.Point(637, 144);
            this.chkseatydz.Name = "chkseatydz";
            this.chkseatydz.Size = new System.Drawing.Size(60, 16);
            this.chkseatydz.TabIndex = 29;
            this.chkseatydz.Text = "一等座";
            this.chkseatydz.UseVisualStyleBackColor = true;
            // 
            // chkseatedz
            // 
            this.chkseatedz.AutoSize = true;
            this.chkseatedz.Location = new System.Drawing.Point(694, 144);
            this.chkseatedz.Name = "chkseatedz";
            this.chkseatedz.Size = new System.Drawing.Size(60, 16);
            this.chkseatedz.TabIndex = 30;
            this.chkseatedz.Text = "二等座";
            this.chkseatedz.UseVisualStyleBackColor = true;
            // 
            // chkseatgjrw
            // 
            this.chkseatgjrw.AutoSize = true;
            this.chkseatgjrw.Location = new System.Drawing.Point(751, 144);
            this.chkseatgjrw.Name = "chkseatgjrw";
            this.chkseatgjrw.Size = new System.Drawing.Size(72, 16);
            this.chkseatgjrw.TabIndex = 31;
            this.chkseatgjrw.Text = "高级软卧";
            this.chkseatgjrw.UseVisualStyleBackColor = true;
            // 
            // chkseatrw
            // 
            this.chkseatrw.AutoSize = true;
            this.chkseatrw.Location = new System.Drawing.Point(820, 144);
            this.chkseatrw.Name = "chkseatrw";
            this.chkseatrw.Size = new System.Drawing.Size(48, 16);
            this.chkseatrw.TabIndex = 32;
            this.chkseatrw.Text = "软卧";
            this.chkseatrw.UseVisualStyleBackColor = true;
            // 
            // chkseatyw
            // 
            this.chkseatyw.AutoSize = true;
            this.chkseatyw.Location = new System.Drawing.Point(864, 144);
            this.chkseatyw.Name = "chkseatyw";
            this.chkseatyw.Size = new System.Drawing.Size(48, 16);
            this.chkseatyw.TabIndex = 33;
            this.chkseatyw.Text = "硬卧";
            this.chkseatyw.UseVisualStyleBackColor = true;
            // 
            // chkseatrz
            // 
            this.chkseatrz.AutoSize = true;
            this.chkseatrz.Location = new System.Drawing.Point(908, 144);
            this.chkseatrz.Name = "chkseatrz";
            this.chkseatrz.Size = new System.Drawing.Size(48, 16);
            this.chkseatrz.TabIndex = 34;
            this.chkseatrz.Text = "软座";
            this.chkseatrz.UseVisualStyleBackColor = true;
            // 
            // chkseatyz
            // 
            this.chkseatyz.AutoSize = true;
            this.chkseatyz.Location = new System.Drawing.Point(952, 144);
            this.chkseatyz.Name = "chkseatyz";
            this.chkseatyz.Size = new System.Drawing.Size(48, 16);
            this.chkseatyz.TabIndex = 35;
            this.chkseatyz.Text = "硬座";
            this.chkseatyz.UseVisualStyleBackColor = true;
            // 
            // chkseatwz
            // 
            this.chkseatwz.AutoSize = true;
            this.chkseatwz.Location = new System.Drawing.Point(997, 144);
            this.chkseatwz.Name = "chkseatwz";
            this.chkseatwz.Size = new System.Drawing.Size(48, 16);
            this.chkseatwz.TabIndex = 36;
            this.chkseatwz.Text = "无座";
            this.chkseatwz.UseVisualStyleBackColor = true;
            // 
            // lblstarttime
            // 
            this.lblstarttime.AutoSize = true;
            this.lblstarttime.Location = new System.Drawing.Point(1089, 10);
            this.lblstarttime.Name = "lblstarttime";
            this.lblstarttime.Size = new System.Drawing.Size(53, 12);
            this.lblstarttime.TabIndex = 37;
            this.lblstarttime.Text = "出发时间";
            // 
            // txtstart1
            // 
            this.txtstart1.Location = new System.Drawing.Point(1090, 28);
            this.txtstart1.Name = "txtstart1";
            this.txtstart1.Size = new System.Drawing.Size(77, 21);
            this.txtstart1.TabIndex = 38;
            this.txtstart1.Text = "00:00";
            // 
            // txtstart2
            // 
            this.txtstart2.Location = new System.Drawing.Point(1192, 28);
            this.txtstart2.Name = "txtstart2";
            this.txtstart2.Size = new System.Drawing.Size(77, 21);
            this.txtstart2.TabIndex = 39;
            this.txtstart2.Text = "23:59";
            // 
            // lblto1
            // 
            this.lblto1.AutoSize = true;
            this.lblto1.Location = new System.Drawing.Point(1172, 31);
            this.lblto1.Name = "lblto1";
            this.lblto1.Size = new System.Drawing.Size(17, 12);
            this.lblto1.TabIndex = 40;
            this.lblto1.Text = "至";
            // 
            // lblendtime
            // 
            this.lblendtime.AutoSize = true;
            this.lblendtime.Location = new System.Drawing.Point(1088, 52);
            this.lblendtime.Name = "lblendtime";
            this.lblendtime.Size = new System.Drawing.Size(53, 12);
            this.lblendtime.TabIndex = 41;
            this.lblendtime.Text = "到达时间";
            // 
            // txtend1
            // 
            this.txtend1.Location = new System.Drawing.Point(1090, 67);
            this.txtend1.Name = "txtend1";
            this.txtend1.Size = new System.Drawing.Size(77, 21);
            this.txtend1.TabIndex = 42;
            this.txtend1.Text = "00:00";
            // 
            // lblto2
            // 
            this.lblto2.AutoSize = true;
            this.lblto2.Location = new System.Drawing.Point(1172, 70);
            this.lblto2.Name = "lblto2";
            this.lblto2.Size = new System.Drawing.Size(17, 12);
            this.lblto2.TabIndex = 43;
            this.lblto2.Text = "至";
            // 
            // txtend2
            // 
            this.txtend2.Location = new System.Drawing.Point(1192, 67);
            this.txtend2.Name = "txtend2";
            this.txtend2.Size = new System.Drawing.Size(77, 21);
            this.txtend2.TabIndex = 44;
            this.txtend2.Text = "23:59";
            // 
            // lblinterval
            // 
            this.lblinterval.AutoSize = true;
            this.lblinterval.Location = new System.Drawing.Point(1089, 90);
            this.lblinterval.Name = "lblinterval";
            this.lblinterval.Size = new System.Drawing.Size(29, 12);
            this.lblinterval.TabIndex = 45;
            this.lblinterval.Text = "历时";
            // 
            // txtinterval1
            // 
            this.txtinterval1.Location = new System.Drawing.Point(1091, 105);
            this.txtinterval1.Name = "txtinterval1";
            this.txtinterval1.Size = new System.Drawing.Size(77, 21);
            this.txtinterval1.TabIndex = 46;
            this.txtinterval1.Text = "00:00";
            // 
            // lblto3
            // 
            this.lblto3.AutoSize = true;
            this.lblto3.Location = new System.Drawing.Point(1172, 107);
            this.lblto3.Name = "lblto3";
            this.lblto3.Size = new System.Drawing.Size(17, 12);
            this.lblto3.TabIndex = 47;
            this.lblto3.Text = "至";
            // 
            // txtinterval2
            // 
            this.txtinterval2.Location = new System.Drawing.Point(1192, 105);
            this.txtinterval2.Name = "txtinterval2";
            this.txtinterval2.Size = new System.Drawing.Size(77, 21);
            this.txtinterval2.TabIndex = 48;
            this.txtinterval2.Text = "96:00";
            // 
            // frmoffline
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1350, 730);
            this.Controls.Add(this.txtinterval2);
            this.Controls.Add(this.lblto3);
            this.Controls.Add(this.txtinterval1);
            this.Controls.Add(this.lblinterval);
            this.Controls.Add(this.txtend2);
            this.Controls.Add(this.lblto2);
            this.Controls.Add(this.txtend1);
            this.Controls.Add(this.lblendtime);
            this.Controls.Add(this.lblto1);
            this.Controls.Add(this.txtstart2);
            this.Controls.Add(this.txtstart1);
            this.Controls.Add(this.lblstarttime);
            this.Controls.Add(this.chkseatwz);
            this.Controls.Add(this.chkseatyz);
            this.Controls.Add(this.chkseatrz);
            this.Controls.Add(this.chkseatyw);
            this.Controls.Add(this.chkseatrw);
            this.Controls.Add(this.chkseatgjrw);
            this.Controls.Add(this.chkseatedz);
            this.Controls.Add(this.chkseatydz);
            this.Controls.Add(this.chkseattdz);
            this.Controls.Add(this.chkseatswz);
            this.Controls.Add(this.chkseatall);
            this.Controls.Add(this.lblseat);
            this.Controls.Add(this.chksfglall);
            this.Controls.Add(this.chkgl);
            this.Controls.Add(this.chksf);
            this.Controls.Add(this.lblsfgl);
            this.Controls.Add(this.chkP);
            this.Controls.Add(this.chkK);
            this.Controls.Add(this.chkT);
            this.Controls.Add(this.chkD);
            this.Controls.Add(this.chkC);
            this.Controls.Add(this.chkG);
            this.Controls.Add(this.chkall);
            this.Controls.Add(this.lbltype);
            this.Controls.Add(this.radioasc);
            this.Controls.Add(this.radiodesc);
            this.Controls.Add(this.chktype);
            this.Controls.Add(this.chklikely);
            this.Controls.Add(this.lstquery);
            this.Controls.Add(this.btnquery);
            this.Controls.Add(this.btnexchange);
            this.Controls.Add(this.lstdst);
            this.Controls.Add(this.txtdst);
            this.Controls.Add(this.lbldst);
            this.Controls.Add(this.lstsrc);
            this.Controls.Add(this.txtsrc);
            this.Controls.Add(this.lblsrc);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmoffline";
            this.Text = "离线查询";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmoffline_FormClosed);
            this.Load += new System.EventHandler(this.frmoffline_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmoffline_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblsrc;
        private System.Windows.Forms.TextBox txtsrc;
        private System.Windows.Forms.ListBox lstsrc;
        private System.Windows.Forms.Label lbldst;
        private System.Windows.Forms.TextBox txtdst;
        private System.Windows.Forms.ListBox lstdst;
        private System.Windows.Forms.Button btnexchange;
        private System.Windows.Forms.ListView lstquery;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.ColumnHeader columnHeader15;
        private System.Windows.Forms.ColumnHeader columnHeader16;
        private System.Windows.Forms.ColumnHeader columnHeader17;
        private System.Windows.Forms.ColumnHeader columnHeader18;
        private System.Windows.Forms.ColumnHeader columnHeader19;
        private System.Windows.Forms.CheckBox chklikely;
        private System.Windows.Forms.CheckBox chktype;
        private System.Windows.Forms.RadioButton radiodesc;
        private System.Windows.Forms.RadioButton radioasc;
        private System.Windows.Forms.Label lbltype;
        private System.Windows.Forms.CheckBox chkall;
        private System.Windows.Forms.CheckBox chkG;
        private System.Windows.Forms.CheckBox chkC;
        private System.Windows.Forms.CheckBox chkD;
        private System.Windows.Forms.CheckBox chkT;
        private System.Windows.Forms.CheckBox chkK;
        private System.Windows.Forms.CheckBox chkP;
        private System.Windows.Forms.Label lblsfgl;
        private System.Windows.Forms.CheckBox chksf;
        private System.Windows.Forms.CheckBox chkgl;
        private System.Windows.Forms.CheckBox chksfglall;
        private System.Windows.Forms.Label lblseat;
        private System.Windows.Forms.CheckBox chkseatall;
        private System.Windows.Forms.CheckBox chkseatswz;
        private System.Windows.Forms.CheckBox chkseattdz;
        private System.Windows.Forms.CheckBox chkseatydz;
        private System.Windows.Forms.CheckBox chkseatedz;
        private System.Windows.Forms.CheckBox chkseatgjrw;
        private System.Windows.Forms.CheckBox chkseatrw;
        private System.Windows.Forms.CheckBox chkseatyw;
        private System.Windows.Forms.CheckBox chkseatrz;
        private System.Windows.Forms.CheckBox chkseatyz;
        private System.Windows.Forms.CheckBox chkseatwz;
        private System.Windows.Forms.Label lblstarttime;
        private System.Windows.Forms.TextBox txtstart1;
        private System.Windows.Forms.TextBox txtstart2;
        private System.Windows.Forms.Label lblto1;
        private System.Windows.Forms.Label lblendtime;
        private System.Windows.Forms.TextBox txtend1;
        private System.Windows.Forms.Label lblto2;
        private System.Windows.Forms.TextBox txtend2;
        private System.Windows.Forms.Label lblinterval;
        private System.Windows.Forms.TextBox txtinterval1;
        private System.Windows.Forms.Label lblto3;
        private System.Windows.Forms.TextBox txtinterval2;
        public System.Windows.Forms.Button btnquery;
    }
}