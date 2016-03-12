namespace trainticket
{
    partial class frmworker_login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmworker_login));
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.txtuser = new System.Windows.Forms.TextBox();
            this.lbpassword = new System.Windows.Forms.Label();
            this.lbuser = new System.Windows.Forms.Label();
            this.piclogin = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.piclogin)).BeginInit();
            this.SuspendLayout();
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(85, 59);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.PasswordChar = '●';
            this.txtpassword.Size = new System.Drawing.Size(175, 21);
            this.txtpassword.TabIndex = 10;
            this.txtpassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtpassword_KeyDown);
            // 
            // txtuser
            // 
            this.txtuser.Location = new System.Drawing.Point(85, 17);
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(175, 21);
            this.txtuser.TabIndex = 9;
            // 
            // lbpassword
            // 
            this.lbpassword.AutoSize = true;
            this.lbpassword.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbpassword.Location = new System.Drawing.Point(23, 55);
            this.lbpassword.Name = "lbpassword";
            this.lbpassword.Size = new System.Drawing.Size(42, 22);
            this.lbpassword.TabIndex = 8;
            this.lbpassword.Text = "密码";
            // 
            // lbuser
            // 
            this.lbuser.AutoSize = true;
            this.lbuser.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbuser.Location = new System.Drawing.Point(21, 15);
            this.lbuser.Name = "lbuser";
            this.lbuser.Size = new System.Drawing.Size(58, 22);
            this.lbuser.TabIndex = 7;
            this.lbuser.Text = "用户名";
            // 
            // piclogin
            // 
            this.piclogin.BackgroundImage = global::trainticket.Properties.Resources.userlogin1;
            this.piclogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.piclogin.Location = new System.Drawing.Point(168, 99);
            this.piclogin.Name = "piclogin";
            this.piclogin.Size = new System.Drawing.Size(92, 29);
            this.piclogin.TabIndex = 11;
            this.piclogin.TabStop = false;
            this.piclogin.Click += new System.EventHandler(this.piclogin_Click);
            this.piclogin.MouseMove += new System.Windows.Forms.MouseEventHandler(this.piclogin_MouseMove);
            // 
            // frmworker_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(291, 154);
            this.Controls.Add(this.piclogin);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.txtuser);
            this.Controls.Add(this.lbpassword);
            this.Controls.Add(this.lbuser);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmworker_login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "工作人员登录";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmworker_login_FormClosed);
            this.Load += new System.EventHandler(this.frmworker_login_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmworker_login_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.piclogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox piclogin;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.TextBox txtuser;
        private System.Windows.Forms.Label lbpassword;
        private System.Windows.Forms.Label lbuser;
    }
}