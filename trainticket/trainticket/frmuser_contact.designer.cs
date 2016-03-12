namespace trainticket
{
    partial class frmuser_contact
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmuser_contact));
            this.lstshow = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_add = new System.Windows.Forms.Button();
            this.btndel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbcontact = new System.Windows.Forms.ComboBox();
            this.picremove = new System.Windows.Forms.PictureBox();
            this.picadd = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picremove)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picadd)).BeginInit();
            this.SuspendLayout();
            // 
            // lstshow
            // 
            this.lstshow.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lstshow.FullRowSelect = true;
            this.lstshow.Location = new System.Drawing.Point(35, 21);
            this.lstshow.Name = "lstshow";
            this.lstshow.Size = new System.Drawing.Size(455, 208);
            this.lstshow.TabIndex = 0;
            this.lstshow.UseCompatibleStateImageBehavior = false;
            this.lstshow.View = System.Windows.Forms.View.Details;
            this.lstshow.SelectedIndexChanged += new System.EventHandler(this.lstshow_SelectedIndexChanged);
            this.lstshow.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lstshow_KeyDown);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "用户名";
            this.columnHeader1.Width = 99;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "姓名";
            this.columnHeader2.Width = 69;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "性别";
            this.columnHeader3.Width = 43;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "身份证号";
            this.columnHeader4.Width = 159;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "是否为学生";
            this.columnHeader5.Width = 77;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(258, 320);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 36);
            this.btn_add.TabIndex = 1;
            this.btn_add.Text = "添加";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Visible = false;
            this.btn_add.Click += new System.EventHandler(this.btnadd_Click);
            this.btn_add.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btn_add_MouseMove);
            // 
            // btndel
            // 
            this.btndel.Location = new System.Drawing.Point(415, 320);
            this.btndel.Name = "btndel";
            this.btndel.Size = new System.Drawing.Size(75, 36);
            this.btndel.TabIndex = 2;
            this.btndel.Text = "删除";
            this.btndel.UseVisualStyleBackColor = true;
            this.btndel.Visible = false;
            this.btndel.Click += new System.EventHandler(this.btndel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(33, 264);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "添加联系人：";
            // 
            // cmbcontact
            // 
            this.cmbcontact.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbcontact.FormattingEnabled = true;
            this.cmbcontact.ItemHeight = 21;
            this.cmbcontact.Location = new System.Drawing.Point(145, 260);
            this.cmbcontact.Name = "cmbcontact";
            this.cmbcontact.Size = new System.Drawing.Size(100, 29);
            this.cmbcontact.TabIndex = 5;
            // 
            // picremove
            // 
            this.picremove.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picremove.BackgroundImage")));
            this.picremove.Location = new System.Drawing.Point(406, 257);
            this.picremove.Name = "picremove";
            this.picremove.Size = new System.Drawing.Size(84, 32);
            this.picremove.TabIndex = 6;
            this.picremove.TabStop = false;
            this.picremove.Click += new System.EventHandler(this.picremove_Click);
            this.picremove.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picremove_MouseMove);
            // 
            // picadd
            // 
            this.picadd.BackgroundImage = global::trainticket.Properties.Resources.newcontact;
            this.picadd.Location = new System.Drawing.Point(258, 258);
            this.picadd.Name = "picadd";
            this.picadd.Size = new System.Drawing.Size(84, 32);
            this.picadd.TabIndex = 6;
            this.picadd.TabStop = false;
            this.picadd.Click += new System.EventHandler(this.picadd_Click);
            this.picadd.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picadd_MouseMove);
            // 
            // frmuser_contact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(523, 312);
            this.Controls.Add(this.picremove);
            this.Controls.Add(this.picadd);
            this.Controls.Add(this.cmbcontact);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btndel);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.lstshow);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmuser_contact";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "常用联系人";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmuser_contact_FormClosed);
            this.Load += new System.EventHandler(this.frmlogin_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmuser_contact_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.picremove)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picadd)).EndInit();
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
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btndel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbcontact;
        private System.Windows.Forms.PictureBox picadd;
        private System.Windows.Forms.PictureBox picremove;
    }
}