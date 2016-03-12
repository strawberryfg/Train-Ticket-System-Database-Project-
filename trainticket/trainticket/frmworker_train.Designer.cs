namespace trainticket
{
    partial class frmworker_train
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmworker_train));
            this.label1 = new System.Windows.Forms.Label();
            this.txttrainno = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lstsrc = new System.Windows.Forms.ListBox();
            this.txtsrc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtlate = new System.Windows.Forms.TextBox();
            this.picset = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picset)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(34, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "车次";
            // 
            // txttrainno
            // 
            this.txttrainno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txttrainno.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttrainno.Location = new System.Drawing.Point(94, 27);
            this.txttrainno.Name = "txttrainno";
            this.txttrainno.Size = new System.Drawing.Size(115, 34);
            this.txttrainno.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(34, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 28);
            this.label2.TabIndex = 0;
            this.label2.Text = "站台";
            // 
            // lstsrc
            // 
            this.lstsrc.FormattingEnabled = true;
            this.lstsrc.ItemHeight = 12;
            this.lstsrc.Location = new System.Drawing.Point(94, 118);
            this.lstsrc.Name = "lstsrc";
            this.lstsrc.Size = new System.Drawing.Size(115, 136);
            this.lstsrc.TabIndex = 41;
            this.lstsrc.Visible = false;
            this.lstsrc.SelectedIndexChanged += new System.EventHandler(this.lstsrc_SelectedIndexChanged);
            // 
            // txtsrc
            // 
            this.txtsrc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtsrc.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtsrc.Location = new System.Drawing.Point(94, 85);
            this.txtsrc.Name = "txtsrc";
            this.txtsrc.Size = new System.Drawing.Size(115, 33);
            this.txtsrc.TabIndex = 2;
            this.txtsrc.TextChanged += new System.EventHandler(this.txtsrc_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(34, 274);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 28);
            this.label3.TabIndex = 0;
            this.label3.Text = "晚点";
            // 
            // txtlate
            // 
            this.txtlate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtlate.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtlate.Location = new System.Drawing.Point(94, 274);
            this.txtlate.Name = "txtlate";
            this.txtlate.Size = new System.Drawing.Size(115, 33);
            this.txtlate.TabIndex = 3;
            this.txtlate.Text = "0";
            this.txtlate.TextChanged += new System.EventHandler(this.txtsrc_TextChanged);
            // 
            // picset
            // 
            this.picset.Image = ((System.Drawing.Image)(resources.GetObject("picset.Image")));
            this.picset.Location = new System.Drawing.Point(237, 207);
            this.picset.Name = "picset";
            this.picset.Size = new System.Drawing.Size(100, 100);
            this.picset.TabIndex = 42;
            this.picset.TabStop = false;
            this.picset.Click += new System.EventHandler(this.picset_Click);
            this.picset.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picset_MouseMove);
            // 
            // frmworker_train
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(379, 336);
            this.Controls.Add(this.picset);
            this.Controls.Add(this.lstsrc);
            this.Controls.Add(this.txtlate);
            this.Controls.Add(this.txtsrc);
            this.Controls.Add(this.txttrainno);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmworker_train";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "工作人员修改车次正晚点";
            this.Activated += new System.EventHandler(this.frmworker_train_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmworker_train_FormClosed);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmworker_train_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.picset)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txttrainno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstsrc;
        public System.Windows.Forms.TextBox txtsrc;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtlate;
        private System.Windows.Forms.PictureBox picset;
    }
}