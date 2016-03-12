namespace trainticket
{
    partial class frmadmin_managecontact
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmadmin_managecontact));
            this.lstshow = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtuser = new System.Windows.Forms.TextBox();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtcer = new System.Windows.Forms.TextBox();
            this.txttel = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.gpstu = new System.Windows.Forms.GroupBox();
            this.radionotstu = new System.Windows.Forms.RadioButton();
            this.radiostu = new System.Windows.Forms.RadioButton();
            this.gpsex = new System.Windows.Forms.GroupBox();
            this.radiowoman = new System.Windows.Forms.RadioButton();
            this.radioman = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.picdelete = new System.Windows.Forms.PictureBox();
            this.picmodify = new System.Windows.Forms.PictureBox();
            this.gpstu.SuspendLayout();
            this.gpsex.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picdelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picmodify)).BeginInit();
            this.SuspendLayout();
            // 
            // lstshow
            // 
            this.lstshow.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader7,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader8});
            this.lstshow.FullRowSelect = true;
            this.lstshow.Location = new System.Drawing.Point(12, 83);
            this.lstshow.Name = "lstshow";
            this.lstshow.Size = new System.Drawing.Size(1079, 487);
            this.lstshow.TabIndex = 0;
            this.lstshow.UseCompatibleStateImageBehavior = false;
            this.lstshow.View = System.Windows.Forms.View.Details;
            this.lstshow.SelectedIndexChanged += new System.EventHandler(this.lstshow_SelectedIndexChanged);
            this.lstshow.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lstshow_KeyDown);
            this.lstshow.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmadmin_MouseMove);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "用户名";
            this.columnHeader1.Width = 140;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "密码";
            this.columnHeader2.Width = 160;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "姓名";
            this.columnHeader3.Width = 140;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "性别";
            this.columnHeader7.Width = 40;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "证件号码";
            this.columnHeader4.Width = 180;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "手机号码";
            this.columnHeader5.Width = 180;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "电子邮件";
            this.columnHeader6.Width = 140;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "是否为学生";
            this.columnHeader8.Width = 90;
            // 
            // txtuser
            // 
            this.txtuser.Location = new System.Drawing.Point(12, 53);
            this.txtuser.Name = "txtuser";
            this.txtuser.ReadOnly = true;
            this.txtuser.Size = new System.Drawing.Size(141, 21);
            this.txtuser.TabIndex = 2;
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(159, 53);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(154, 21);
            this.txtpassword.TabIndex = 3;
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(319, 52);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(129, 21);
            this.txtname.TabIndex = 4;
            // 
            // txtcer
            // 
            this.txtcer.Location = new System.Drawing.Point(501, 52);
            this.txtcer.Name = "txtcer";
            this.txtcer.Size = new System.Drawing.Size(169, 21);
            this.txtcer.TabIndex = 5;
            // 
            // txttel
            // 
            this.txttel.Location = new System.Drawing.Point(676, 52);
            this.txttel.Name = "txttel";
            this.txttel.Size = new System.Drawing.Size(173, 21);
            this.txttel.TabIndex = 6;
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(855, 52);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(139, 21);
            this.txtemail.TabIndex = 7;
            // 
            // gpstu
            // 
            this.gpstu.Controls.Add(this.radionotstu);
            this.gpstu.Controls.Add(this.radiostu);
            this.gpstu.Location = new System.Drawing.Point(1000, 12);
            this.gpstu.Name = "gpstu";
            this.gpstu.Size = new System.Drawing.Size(81, 66);
            this.gpstu.TabIndex = 23;
            this.gpstu.TabStop = false;
            this.gpstu.Text = "是否为学生";
            // 
            // radionotstu
            // 
            this.radionotstu.AutoSize = true;
            this.radionotstu.Checked = true;
            this.radionotstu.Location = new System.Drawing.Point(6, 42);
            this.radionotstu.Name = "radionotstu";
            this.radionotstu.Size = new System.Drawing.Size(35, 16);
            this.radionotstu.TabIndex = 19;
            this.radionotstu.TabStop = true;
            this.radionotstu.Text = "否";
            this.radionotstu.UseVisualStyleBackColor = true;
            // 
            // radiostu
            // 
            this.radiostu.AutoSize = true;
            this.radiostu.Location = new System.Drawing.Point(6, 20);
            this.radiostu.Name = "radiostu";
            this.radiostu.Size = new System.Drawing.Size(35, 16);
            this.radiostu.TabIndex = 18;
            this.radiostu.Text = "是";
            this.radiostu.UseVisualStyleBackColor = true;
            // 
            // gpsex
            // 
            this.gpsex.Controls.Add(this.radiowoman);
            this.gpsex.Controls.Add(this.radioman);
            this.gpsex.Location = new System.Drawing.Point(454, 16);
            this.gpsex.Name = "gpsex";
            this.gpsex.Size = new System.Drawing.Size(44, 62);
            this.gpsex.TabIndex = 24;
            this.gpsex.TabStop = false;
            this.gpsex.Text = "性别";
            // 
            // radiowoman
            // 
            this.radiowoman.AutoSize = true;
            this.radiowoman.Location = new System.Drawing.Point(6, 42);
            this.radiowoman.Name = "radiowoman";
            this.radiowoman.Size = new System.Drawing.Size(35, 16);
            this.radiowoman.TabIndex = 22;
            this.radiowoman.Text = "女";
            this.radiowoman.UseVisualStyleBackColor = true;
            // 
            // radioman
            // 
            this.radioman.AutoSize = true;
            this.radioman.Checked = true;
            this.radioman.Location = new System.Drawing.Point(6, 20);
            this.radioman.Name = "radioman";
            this.radioman.Size = new System.Drawing.Size(35, 16);
            this.radioman.TabIndex = 21;
            this.radioman.TabStop = true;
            this.radioman.Text = "男";
            this.radioman.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 22);
            this.label1.TabIndex = 25;
            this.label1.Text = "用户名";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(155, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 22);
            this.label2.TabIndex = 25;
            this.label2.Text = "密码";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(315, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 22);
            this.label3.TabIndex = 25;
            this.label3.Text = "姓名";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(501, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 22);
            this.label4.TabIndex = 25;
            this.label4.Text = "证件号码";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(672, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 22);
            this.label5.TabIndex = 25;
            this.label5.Text = "手机号码";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(851, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 22);
            this.label6.TabIndex = 25;
            this.label6.Text = "电子邮件";
            // 
            // picdelete
            // 
            this.picdelete.Image = global::trainticket.Properties.Resources.delete;
            this.picdelete.Location = new System.Drawing.Point(1097, 201);
            this.picdelete.Name = "picdelete";
            this.picdelete.Size = new System.Drawing.Size(100, 100);
            this.picdelete.TabIndex = 26;
            this.picdelete.TabStop = false;
            this.picdelete.Click += new System.EventHandler(this.picdelete_Click);
            this.picdelete.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picdelete_MouseMove);
            // 
            // picmodify
            // 
            this.picmodify.Image = global::trainticket.Properties.Resources.modify1;
            this.picmodify.Location = new System.Drawing.Point(1097, 83);
            this.picmodify.Name = "picmodify";
            this.picmodify.Size = new System.Drawing.Size(100, 100);
            this.picmodify.TabIndex = 26;
            this.picmodify.TabStop = false;
            this.picmodify.Click += new System.EventHandler(this.picmodify_Click);
            this.picmodify.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picmodify_MouseMove);
            // 
            // frmadmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1213, 610);
            this.Controls.Add(this.picdelete);
            this.Controls.Add(this.picmodify);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gpsex);
            this.Controls.Add(this.gpstu);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.txttel);
            this.Controls.Add(this.txtcer);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.txtuser);
            this.Controls.Add(this.lstshow);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmadmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "管理联系人";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmadmin_FormClosed);
            this.Load += new System.EventHandler(this.frmadmin_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmadmin_MouseMove);
            this.gpstu.ResumeLayout(false);
            this.gpstu.PerformLayout();
            this.gpsex.ResumeLayout(false);
            this.gpsex.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picdelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picmodify)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstshow;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.TextBox txtuser;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtcer;
        private System.Windows.Forms.TextBox txttel;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.GroupBox gpstu;
        private System.Windows.Forms.RadioButton radionotstu;
        private System.Windows.Forms.RadioButton radiostu;
        private System.Windows.Forms.GroupBox gpsex;
        private System.Windows.Forms.RadioButton radiowoman;
        private System.Windows.Forms.RadioButton radioman;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox picmodify;
        private System.Windows.Forms.PictureBox picdelete;
    }
}