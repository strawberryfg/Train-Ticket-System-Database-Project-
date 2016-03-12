namespace trainticket
{
    partial class frmadmin_main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmadmin_main));
            this.label1 = new System.Windows.Forms.Label();
            this.lblworker = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.picmanage = new System.Windows.Forms.PictureBox();
            this.piclogout = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picmanage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.piclogout)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(27, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "当前在线工作人员";
            // 
            // lblworker
            // 
            this.lblworker.AutoSize = true;
            this.lblworker.Font = new System.Drawing.Font("Comic Sans MS", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblworker.ForeColor = System.Drawing.Color.Red;
            this.lblworker.Location = new System.Drawing.Point(213, 18);
            this.lblworker.Name = "lblworker";
            this.lblworker.Size = new System.Drawing.Size(94, 35);
            this.lblworker.TabIndex = 1;
            this.lblworker.Text = "worker";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(27, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 28);
            this.label3.TabIndex = 1;
            this.label3.Text = "注销在线工作人员";
            // 
            // picmanage
            // 
            this.picmanage.Image = global::trainticket.Properties.Resources.manage3;
            this.picmanage.Location = new System.Drawing.Point(110, 180);
            this.picmanage.Name = "picmanage";
            this.picmanage.Size = new System.Drawing.Size(200, 200);
            this.picmanage.TabIndex = 0;
            this.picmanage.TabStop = false;
            this.picmanage.Click += new System.EventHandler(this.picmanage_Click);
            this.picmanage.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picmanage_MouseMove);
            // 
            // piclogout
            // 
            this.piclogout.Image = global::trainticket.Properties.Resources.logout2;
            this.piclogout.Location = new System.Drawing.Point(210, 56);
            this.piclogout.Name = "piclogout";
            this.piclogout.Size = new System.Drawing.Size(100, 100);
            this.piclogout.TabIndex = 0;
            this.piclogout.TabStop = false;
            this.piclogout.Click += new System.EventHandler(this.piclogout_Click);
            this.piclogout.MouseMove += new System.Windows.Forms.MouseEventHandler(this.piclogout_MouseMove);
            // 
            // frmadminmain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(409, 407);
            this.Controls.Add(this.lblworker);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picmanage);
            this.Controls.Add(this.piclogout);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmadminmain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "管理员界面";
            this.Activated += new System.EventHandler(this.frmadminmain_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmadminmain_FormClosed);
            this.Load += new System.EventHandler(this.frmadminmain_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmadminmin_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.picmanage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.piclogout)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox piclogout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblworker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox picmanage;
    }
}