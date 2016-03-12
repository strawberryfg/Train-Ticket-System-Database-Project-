namespace trainticket
{
    partial class frmuser_login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmuser_login));
            this.lbuser = new System.Windows.Forms.Label();
            this.lbpassword = new System.Windows.Forms.Label();
            this.btnlogin = new System.Windows.Forms.Button();
            this.txtuser = new System.Windows.Forms.TextBox();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.btnreg = new System.Windows.Forms.Button();
            this.piclogin = new System.Windows.Forms.PictureBox();
            this.picsubmit = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.piclogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picsubmit)).BeginInit();
            this.SuspendLayout();
            // 
            // lbuser
            // 
            this.lbuser.AutoSize = true;
            this.lbuser.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbuser.Location = new System.Drawing.Point(21, 15);
            this.lbuser.Name = "lbuser";
            this.lbuser.Size = new System.Drawing.Size(58, 22);
            this.lbuser.TabIndex = 0;
            this.lbuser.Text = "用户名";
            // 
            // lbpassword
            // 
            this.lbpassword.AutoSize = true;
            this.lbpassword.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbpassword.Location = new System.Drawing.Point(23, 55);
            this.lbpassword.Name = "lbpassword";
            this.lbpassword.Size = new System.Drawing.Size(42, 22);
            this.lbpassword.TabIndex = 1;
            this.lbpassword.Text = "密码";
            // 
            // btnlogin
            // 
            this.btnlogin.Location = new System.Drawing.Point(168, 168);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(66, 43);
            this.btnlogin.TabIndex = 2;
            this.btnlogin.Text = "登录";
            this.btnlogin.UseVisualStyleBackColor = true;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // txtuser
            // 
            this.txtuser.Location = new System.Drawing.Point(85, 17);
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(175, 21);
            this.txtuser.TabIndex = 3;
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(85, 59);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.PasswordChar = '●';
            this.txtpassword.Size = new System.Drawing.Size(175, 21);
            this.txtpassword.TabIndex = 4;
            this.txtpassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtpassword_KeyDown);
            // 
            // btnreg
            // 
            this.btnreg.Location = new System.Drawing.Point(27, 169);
            this.btnreg.Name = "btnreg";
            this.btnreg.Size = new System.Drawing.Size(71, 42);
            this.btnreg.TabIndex = 5;
            this.btnreg.Text = "注册";
            this.btnreg.UseVisualStyleBackColor = true;
            this.btnreg.Click += new System.EventHandler(this.btnreg_Click);
            // 
            // piclogin
            // 
            this.piclogin.BackgroundImage = global::trainticket.Properties.Resources.userlogin1;
            this.piclogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.piclogin.Location = new System.Drawing.Point(168, 99);
            this.piclogin.Name = "piclogin";
            this.piclogin.Size = new System.Drawing.Size(92, 29);
            this.piclogin.TabIndex = 6;
            this.piclogin.TabStop = false;
            this.piclogin.Click += new System.EventHandler(this.piclogin_Click);
            this.piclogin.MouseMove += new System.Windows.Forms.MouseEventHandler(this.piclogin_MouseMove);
            // 
            // picsubmit
            // 
            this.picsubmit.BackgroundImage = global::trainticket.Properties.Resources.usersubmit;
            this.picsubmit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picsubmit.Location = new System.Drawing.Point(25, 99);
            this.picsubmit.Name = "picsubmit";
            this.picsubmit.Size = new System.Drawing.Size(92, 29);
            this.picsubmit.TabIndex = 6;
            this.picsubmit.TabStop = false;
            this.picsubmit.Click += new System.EventHandler(this.picsubmit_Click);
            this.picsubmit.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picsubmit_MouseMove);
            // 
            // frmuser_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(291, 154);
            this.Controls.Add(this.piclogin);
            this.Controls.Add(this.picsubmit);
            this.Controls.Add(this.btnreg);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.txtuser);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.lbpassword);
            this.Controls.Add(this.lbuser);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmuser_login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "用户登录";
            this.Activated += new System.EventHandler(this.frmuser_login_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmuser_login_FormClosed);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmuser_login_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.piclogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picsubmit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbuser;
        private System.Windows.Forms.Label lbpassword;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.Button btnreg;
        private System.Windows.Forms.TextBox txtuser;
        private System.Windows.Forms.PictureBox picsubmit;
        private System.Windows.Forms.PictureBox piclogin;
    }
}