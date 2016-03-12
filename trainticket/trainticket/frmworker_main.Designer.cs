namespace trainticket
{
    partial class frmworker_main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmworker_main));
            this.pictrainid = new System.Windows.Forms.PictureBox();
            this.pictimetable = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictrainid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictimetable)).BeginInit();
            this.SuspendLayout();
            // 
            // pictrainid
            // 
            this.pictrainid.Image = global::trainticket.Properties.Resources.dongche;
            this.pictrainid.Location = new System.Drawing.Point(286, 37);
            this.pictrainid.Name = "pictrainid";
            this.pictrainid.Size = new System.Drawing.Size(200, 200);
            this.pictrainid.TabIndex = 0;
            this.pictrainid.TabStop = false;
            this.pictrainid.Click += new System.EventHandler(this.pictrainid_Click);
            this.pictrainid.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictrainid_MouseMove);
            // 
            // pictimetable
            // 
            this.pictimetable.Image = global::trainticket.Properties.Resources.timetable;
            this.pictimetable.Location = new System.Drawing.Point(43, 37);
            this.pictimetable.Name = "pictimetable";
            this.pictimetable.Size = new System.Drawing.Size(200, 200);
            this.pictimetable.TabIndex = 0;
            this.pictimetable.TabStop = false;
            this.pictimetable.Click += new System.EventHandler(this.pictimetable_Click);
            this.pictimetable.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictimetable_MouseMove);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(49, 254);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "修改车次正晚点";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(280, 254);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(206, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "查看车次旅客信息";
            // 
            // frmworker_choose
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(527, 324);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictrainid);
            this.Controls.Add(this.pictimetable);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmworker_choose";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "工作人员";
            this.Activated += new System.EventHandler(this.frmworker_choose_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmworker_choose_FormClosed);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmworker_choose_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.pictrainid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictimetable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictimetable;
        private System.Windows.Forms.PictureBox pictrainid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}