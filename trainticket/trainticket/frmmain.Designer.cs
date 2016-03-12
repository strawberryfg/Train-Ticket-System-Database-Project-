namespace trainticket
{
    partial class frmmain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmmain));
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.登录ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.用户登录ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.工作人员登录ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.管理员登录ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.初始化ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.初始化ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblexpusr = new System.Windows.Forms.Label();
            this.lblexpworker = new System.Windows.Forms.Label();
            this.lblexpadmin = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tmrmovebottom = new System.Windows.Forms.Timer(this.components);
            this.tmrnext = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("黑体", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(403, 470);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "6";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.登录ToolStripMenuItem,
            this.初始化ToolStripMenuItem,
            this.帮助ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(960, 25);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 登录ToolStripMenuItem
            // 
            this.登录ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.用户登录ToolStripMenuItem,
            this.工作人员登录ToolStripMenuItem,
            this.管理员登录ToolStripMenuItem});
            this.登录ToolStripMenuItem.Name = "登录ToolStripMenuItem";
            this.登录ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.登录ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.登录ToolStripMenuItem.Text = "登录";
            // 
            // 用户登录ToolStripMenuItem
            // 
            this.用户登录ToolStripMenuItem.Name = "用户登录ToolStripMenuItem";
            this.用户登录ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.U)));
            this.用户登录ToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.用户登录ToolStripMenuItem.Text = "用户登录";
            this.用户登录ToolStripMenuItem.Click += new System.EventHandler(this.用户登录ToolStripMenuItem_Click);
            // 
            // 工作人员登录ToolStripMenuItem
            // 
            this.工作人员登录ToolStripMenuItem.Name = "工作人员登录ToolStripMenuItem";
            this.工作人员登录ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
            this.工作人员登录ToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.工作人员登录ToolStripMenuItem.Text = "工作人员登录";
            this.工作人员登录ToolStripMenuItem.Click += new System.EventHandler(this.工作人员登录ToolStripMenuItem_Click);
            // 
            // 管理员登录ToolStripMenuItem
            // 
            this.管理员登录ToolStripMenuItem.Name = "管理员登录ToolStripMenuItem";
            this.管理员登录ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.管理员登录ToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.管理员登录ToolStripMenuItem.Text = "管理员登录";
            this.管理员登录ToolStripMenuItem.Click += new System.EventHandler(this.管理员登录ToolStripMenuItem_Click);
            // 
            // 初始化ToolStripMenuItem
            // 
            this.初始化ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.初始化ToolStripMenuItem1});
            this.初始化ToolStripMenuItem.Name = "初始化ToolStripMenuItem";
            this.初始化ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.初始化ToolStripMenuItem.Size = new System.Drawing.Size(56, 21);
            this.初始化ToolStripMenuItem.Text = "初始化";
            // 
            // 初始化ToolStripMenuItem1
            // 
            this.初始化ToolStripMenuItem1.Name = "初始化ToolStripMenuItem1";
            this.初始化ToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.初始化ToolStripMenuItem1.Text = "初始化";
            this.初始化ToolStripMenuItem1.Click += new System.EventHandler(this.初始化ToolStripMenuItem1_Click);
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.关于ToolStripMenuItem});
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.帮助ToolStripMenuItem.Text = "帮助";
            // 
            // 关于ToolStripMenuItem
            // 
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            this.关于ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.关于ToolStripMenuItem.Text = "关于";
            this.关于ToolStripMenuItem.Click += new System.EventHandler(this.关于ToolStripMenuItem_Click);
            // 
            // lblexpusr
            // 
            this.lblexpusr.AutoSize = true;
            this.lblexpusr.BackColor = System.Drawing.Color.Transparent;
            this.lblexpusr.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblexpusr.ForeColor = System.Drawing.Color.Gray;
            this.lblexpusr.Location = new System.Drawing.Point(12, 71);
            this.lblexpusr.Name = "lblexpusr";
            this.lblexpusr.Size = new System.Drawing.Size(239, 104);
            this.lblexpusr.TabIndex = 5;
            this.lblexpusr.Text = "● 用户登录\r\n   购票、查看个人信息、\r\n   管理联系人、查看订单、\r\n   查看火车正晚点时刻表";
            // 
            // lblexpworker
            // 
            this.lblexpworker.AutoSize = true;
            this.lblexpworker.BackColor = System.Drawing.Color.Transparent;
            this.lblexpworker.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblexpworker.ForeColor = System.Drawing.Color.Gray;
            this.lblexpworker.Location = new System.Drawing.Point(12, 189);
            this.lblexpworker.Name = "lblexpworker";
            this.lblexpworker.Size = new System.Drawing.Size(220, 78);
            this.lblexpworker.TabIndex = 5;
            this.lblexpworker.Text = "● 工作人员登录\r\n   修改火车正晚点信息、\r\n   查看车次旅客信息\r\n";
            // 
            // lblexpadmin
            // 
            this.lblexpadmin.AutoSize = true;
            this.lblexpadmin.BackColor = System.Drawing.Color.Transparent;
            this.lblexpadmin.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblexpadmin.ForeColor = System.Drawing.Color.Gray;
            this.lblexpadmin.Location = new System.Drawing.Point(12, 289);
            this.lblexpadmin.Name = "lblexpadmin";
            this.lblexpadmin.Size = new System.Drawing.Size(201, 104);
            this.lblexpadmin.TabIndex = 5;
            this.lblexpadmin.Text = "● 管理员登录\r\n   注销工作人员账号、\r\n   管理联系人信息\r\n\r\n";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::trainticket.Properties.Resources.train;
            this.pictureBox1.Location = new System.Drawing.Point(274, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(651, 433);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("黑体", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label7.Location = new System.Drawing.Point(423, 470);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 29);
            this.label7.TabIndex = 2;
            this.label7.Text = "6";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("黑体", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.ForeColor = System.Drawing.Color.Teal;
            this.label8.Location = new System.Drawing.Point(443, 470);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 29);
            this.label8.TabIndex = 2;
            this.label8.Text = "6";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("黑体", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label9.Location = new System.Drawing.Point(463, 470);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 29);
            this.label9.TabIndex = 2;
            this.label9.Text = "6";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("黑体", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.ForeColor = System.Drawing.Color.Navy;
            this.label10.Location = new System.Drawing.Point(483, 470);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 29);
            this.label10.TabIndex = 2;
            this.label10.Text = "6";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("黑体", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label11.Location = new System.Drawing.Point(503, 470);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 29);
            this.label11.TabIndex = 2;
            this.label11.Text = "火";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("黑体", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(536, 470);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 29);
            this.label12.TabIndex = 2;
            this.label12.Text = "车";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("黑体", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label13.ForeColor = System.Drawing.Color.Green;
            this.label13.Location = new System.Drawing.Point(570, 470);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(44, 29);
            this.label13.TabIndex = 2;
            this.label13.Text = "票";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("黑体", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label14.Location = new System.Drawing.Point(603, 470);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(44, 29);
            this.label14.TabIndex = 2;
            this.label14.Text = "系";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("黑体", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label15.Location = new System.Drawing.Point(637, 470);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(44, 29);
            this.label15.TabIndex = 2;
            this.label15.Text = "统";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("黑体", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label16.ForeColor = System.Drawing.Color.Magenta;
            this.label16.Location = new System.Drawing.Point(671, 470);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(44, 29);
            this.label16.TabIndex = 2;
            this.label16.Text = "欢";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("黑体", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(705, 470);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "迎";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("黑体", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.DarkRed;
            this.label3.Location = new System.Drawing.Point(739, 470);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "您";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("黑体", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(773, 470);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 29);
            this.label4.TabIndex = 2;
            this.label4.Text = "！";
            // 
            // tmrmovebottom
            // 
            this.tmrmovebottom.Enabled = true;
            this.tmrmovebottom.Interval = 300;
            this.tmrmovebottom.Tick += new System.EventHandler(this.tmrmovebottom_Tick);
            // 
            // tmrnext
            // 
            this.tmrnext.Enabled = true;
            this.tmrnext.Interval = 300;
            this.tmrnext.Tick += new System.EventHandler(this.tmrnext_Tick);
            // 
            // frmmain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(960, 522);
            this.Controls.Add(this.lblexpadmin);
            this.Controls.Add(this.lblexpworker);
            this.Controls.Add(this.lblexpusr);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "frmmain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "66666火车票系统";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmmain_FormClosed);
            this.Load += new System.EventHandler(this.frmmain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 登录ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 用户登录ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 工作人员登录ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 管理员登录ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 初始化ToolStripMenuItem;
        private System.Windows.Forms.Label lblexpusr;
        private System.Windows.Forms.Label lblexpworker;
        private System.Windows.Forms.Label lblexpadmin;
        private System.Windows.Forms.ToolStripMenuItem 初始化ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer tmrmovebottom;
        private System.Windows.Forms.Timer tmrnext;
    }
}