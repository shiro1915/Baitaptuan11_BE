namespace GUI_QLBV
{
    partial class HoaDon
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gbnhaphd = new System.Windows.Forms.GroupBox();
            this.gbdshd = new System.Windows.Forms.GroupBox();
            this.txttimkiemhd = new System.Windows.Forms.TextBox();
            this.btntimkiem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(509, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hóa Đơn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 1;
            // 
            // gbnhaphd
            // 
            this.gbnhaphd.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gbnhaphd.Location = new System.Drawing.Point(48, 111);
            this.gbnhaphd.Name = "gbnhaphd";
            this.gbnhaphd.Size = new System.Drawing.Size(1048, 237);
            this.gbnhaphd.TabIndex = 2;
            this.gbnhaphd.TabStop = false;
            this.gbnhaphd.Text = "Nhập Thông Tin Hóa Đơn ";
            // 
            // gbdshd
            // 
            this.gbdshd.Location = new System.Drawing.Point(48, 354);
            this.gbdshd.Name = "gbdshd";
            this.gbdshd.Size = new System.Drawing.Size(1048, 155);
            this.gbdshd.TabIndex = 3;
            this.gbdshd.TabStop = false;
            this.gbdshd.Text = "Danh Sách Hóa Đơn";
            // 
            // txttimkiemhd
            // 
            this.txttimkiemhd.Location = new System.Drawing.Point(260, 60);
            this.txttimkiemhd.Name = "txttimkiemhd";
            this.txttimkiemhd.Size = new System.Drawing.Size(505, 26);
            this.txttimkiemhd.TabIndex = 4;
            // 
            // btntimkiem
            // 
            this.btntimkiem.Location = new System.Drawing.Point(802, 54);
            this.btntimkiem.Name = "btntimkiem";
            this.btntimkiem.Size = new System.Drawing.Size(102, 32);
            this.btntimkiem.TabIndex = 5;
            this.btntimkiem.Text = "Tìm Kiếm";
            this.btntimkiem.UseVisualStyleBackColor = true;
            // 
            // HoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1125, 533);
            this.Controls.Add(this.btntimkiem);
            this.Controls.Add(this.txttimkiemhd);
            this.Controls.Add(this.gbdshd);
            this.Controls.Add(this.gbnhaphd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "HoaDon";
            this.Text = "HoaDon";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbdshd;
        private System.Windows.Forms.TextBox txttimkiemhd;
        private System.Windows.Forms.Button btntimkiem;
        protected System.Windows.Forms.GroupBox gbnhaphd;
    }
}