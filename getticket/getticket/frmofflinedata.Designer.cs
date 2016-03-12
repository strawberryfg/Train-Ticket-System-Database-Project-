namespace getticket
{
    partial class frmgetofflinedata
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnoffline = new System.Windows.Forms.Button();
            this.lbl = new System.Windows.Forms.Label();
            this.txtdate = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnoffline
            // 
            this.btnoffline.Location = new System.Drawing.Point(96, 54);
            this.btnoffline.Name = "btnoffline";
            this.btnoffline.Size = new System.Drawing.Size(99, 52);
            this.btnoffline.TabIndex = 0;
            this.btnoffline.Text = "获取离线数据库";
            this.btnoffline.UseVisualStyleBackColor = true;
            this.btnoffline.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(94, 130);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(23, 12);
            this.lbl.TabIndex = 1;
            this.lbl.Text = "0 0";
            // 
            // txtdate
            // 
            this.txtdate.Location = new System.Drawing.Point(102, 27);
            this.txtdate.Name = "txtdate";
            this.txtdate.Size = new System.Drawing.Size(87, 21);
            this.txtdate.TabIndex = 2;
            this.txtdate.Text = "2015-07-15";
            // 
            // frmgetofflinedata
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 204);
            this.Controls.Add(this.txtdate);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.btnoffline);
            this.MaximizeBox = false;
            this.Name = "frmgetofflinedata";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "获取离线数据库";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnoffline;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.TextBox txtdate;
    }
}

