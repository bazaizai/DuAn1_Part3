namespace _3.PL.Components
{
    partial class SearchHats
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.SoLuong = new System.Windows.Forms.Label();
            this.IdSPCT = new System.Windows.Forms.Label();
            this.Gia = new System.Windows.Forms.Label();
            this.TenSP = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPT = new System.Windows.Forms.Label();
            this.lblGiaGiam = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SoLuong
            // 
            this.SoLuong.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SoLuong.AutoSize = true;
            this.SoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SoLuong.ForeColor = System.Drawing.Color.Black;
            this.SoLuong.Location = new System.Drawing.Point(123, 31);
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.Size = new System.Drawing.Size(49, 13);
            this.SoLuong.TabIndex = 24;
            this.SoLuong.Text = "Số lượng";
            // 
            // IdSPCT
            // 
            this.IdSPCT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.IdSPCT.AutoSize = true;
            this.IdSPCT.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.IdSPCT.ForeColor = System.Drawing.Color.Silver;
            this.IdSPCT.Location = new System.Drawing.Point(29, 89);
            this.IdSPCT.Name = "IdSPCT";
            this.IdSPCT.Size = new System.Drawing.Size(51, 11);
            this.IdSPCT.TabIndex = 23;
            this.IdSPCT.Text = "Số lượng: 500";
            this.IdSPCT.Visible = false;
            // 
            // Gia
            // 
            this.Gia.AutoSize = true;
            this.Gia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Gia.ForeColor = System.Drawing.Color.Red;
            this.Gia.Location = new System.Drawing.Point(208, 67);
            this.Gia.Name = "Gia";
            this.Gia.Size = new System.Drawing.Size(102, 17);
            this.Gia.TabIndex = 21;
            this.Gia.Text = "Giá: 500.000 đ";
            // 
            // TenSP
            // 
            this.TenSP.AutoSize = true;
            this.TenSP.Dock = System.Windows.Forms.DockStyle.Left;
            this.TenSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TenSP.ForeColor = System.Drawing.Color.Navy;
            this.TenSP.Location = new System.Drawing.Point(0, 0);
            this.TenSP.Name = "TenSP";
            this.TenSP.Size = new System.Drawing.Size(86, 20);
            this.TenSP.TabIndex = 20;
            this.TenSP.Text = "SanPham";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(208, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 17);
            this.label1.TabIndex = 25;
            this.label1.Text = "Giá: 500.000 đ";
            // 
            // lblPT
            // 
            this.lblPT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPT.AutoSize = true;
            this.lblPT.Font = new System.Drawing.Font("Segoe UI Black", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblPT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblPT.Location = new System.Drawing.Point(123, 49);
            this.lblPT.Name = "lblPT";
            this.lblPT.Size = new System.Drawing.Size(22, 19);
            this.lblPT.TabIndex = 26;
            this.lblPT.Text = "%";
            // 
            // lblGiaGiam
            // 
            this.lblGiaGiam.AutoSize = true;
            this.lblGiaGiam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblGiaGiam.ForeColor = System.Drawing.Color.Red;
            this.lblGiaGiam.Location = new System.Drawing.Point(208, 47);
            this.lblGiaGiam.Name = "lblGiaGiam";
            this.lblGiaGiam.Size = new System.Drawing.Size(0, 17);
            this.lblGiaGiam.TabIndex = 25;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.TenSP);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(356, 28);
            this.panel1.TabIndex = 27;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(0, 93);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(380, 125);
            this.panel2.TabIndex = 21;
            // 
            // SearchHats
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblGiaGiam);
            this.Controls.Add(this.Gia);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPT);
            this.Controls.Add(this.SoLuong);
            this.Controls.Add(this.IdSPCT);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "SearchHats";
            this.Size = new System.Drawing.Size(356, 96);
            this.Load += new System.EventHandler(this.SearchHats_Load);
            this.Click += new System.EventHandler(this.SearchHats_Click);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SoLuong;
        private System.Windows.Forms.Label IdSPCT;
        public System.Windows.Forms.Label Gia;
        private System.Windows.Forms.Label TenSP;
        private CustomControls.RJControls.RJCircularPictureBox Anh;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPT;
        private System.Windows.Forms.Label lblGiaGiam;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel2;
    }
}
