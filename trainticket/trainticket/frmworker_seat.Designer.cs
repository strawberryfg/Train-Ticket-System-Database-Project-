namespace trainticket
{
    partial class frmworker_seat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmworker_seat));
            this.txttrainid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txttraindate = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lstview = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.picsearch = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picsearch)).BeginInit();
            this.SuspendLayout();
            // 
            // txttrainid
            // 
            this.txttrainid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txttrainid.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txttrainid.Location = new System.Drawing.Point(113, 23);
            this.txttrainid.Name = "txttrainid";
            this.txttrainid.Size = new System.Drawing.Size(100, 30);
            this.txttrainid.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(36, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "车次";
            // 
            // txttraindate
            // 
            this.txttraindate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txttraindate.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txttraindate.Location = new System.Drawing.Point(113, 70);
            this.txttraindate.Name = "txttraindate";
            this.txttraindate.Size = new System.Drawing.Size(100, 30);
            this.txttraindate.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(36, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "日期";
            // 
            // lstview
            // 
            this.lstview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.lstview.FullRowSelect = true;
            this.lstview.Location = new System.Drawing.Point(38, 130);
            this.lstview.Name = "lstview";
            this.lstview.Size = new System.Drawing.Size(839, 517);
            this.lstview.TabIndex = 104;
            this.lstview.UseCompatibleStateImageBehavior = false;
            this.lstview.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "姓名";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "座位类型";
            this.columnHeader2.Width = 72;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "座位号";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "性别";
            this.columnHeader4.Width = 52;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "证件号码";
            this.columnHeader5.Width = 160;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "手机号码";
            this.columnHeader6.Width = 150;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "电子邮件";
            this.columnHeader7.Width = 160;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "是否为学生";
            this.columnHeader8.Width = 84;
            // 
            // picsearch
            // 
            this.picsearch.Image = global::trainticket.Properties.Resources.find1;
            this.picsearch.Location = new System.Drawing.Point(234, 12);
            this.picsearch.Name = "picsearch";
            this.picsearch.Size = new System.Drawing.Size(100, 100);
            this.picsearch.TabIndex = 105;
            this.picsearch.TabStop = false;
            this.picsearch.Click += new System.EventHandler(this.picsearch_Click);
            this.picsearch.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picsearch_MouseMove);
            // 
            // frmworker_seat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(902, 692);
            this.Controls.Add(this.picsearch);
            this.Controls.Add(this.lstview);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txttraindate);
            this.Controls.Add(this.txttrainid);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmworker_seat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "工作人员查看车次";
            this.Activated += new System.EventHandler(this.frmworker_seat_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmworker_seat_FormClosed);
            this.Load += new System.EventHandler(this.frmworker_seat_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmworker_seat_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.picsearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txttrainid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txttraindate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView lstview;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.PictureBox picsearch;
    }
}