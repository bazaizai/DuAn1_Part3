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
            this.SoLuong = new System.Windows.Forms.Label();
            this.IdSPCT = new System.Windows.Forms.Label();
            this.Gia = new System.Windows.Forms.Label();
            this.TenSP = new System.Windows.Forms.Label();
            this.Anh = new CustomControls.RJControls.RJCircularPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Anh)).BeginInit();
            this.SuspendLayout();
            // 
            // SoLuong
            // 
            this.SoLuong.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SoLuong.AutoSize = true;
            this.SoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SoLuong.ForeColor = System.Drawing.Color.Black;
            this.SoLuong.Location = new System.Drawing.Point(111, 70);
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.Size = new System.Drawing.Size(60, 16);
            this.SoLuong.TabIndex = 24;
            this.SoLuong.Text = "Số lượng";
            // 
            // IdSPCT
            // 
            this.IdSPCT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.IdSPCT.AutoSize = true;
            this.IdSPCT.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.IdSPCT.ForeColor = System.Drawing.Color.Silver;
            this.IdSPCT.Location = new System.Drawing.Point(24, 89);
            this.IdSPCT.Name = "IdSPCT";
            this.IdSPCT.Size = new System.Drawing.Size(64, 12);
            this.IdSPCT.TabIndex = 23;
            this.IdSPCT.Text = "Số lượng: 500";
            this.IdSPCT.Visible = false;
            // 
            // Gia
            // 
            this.Gia.AutoSize = true;
            this.Gia.Dock = System.Windows.Forms.DockStyle.Right;
            this.Gia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Gia.ForeColor = System.Drawing.Color.Red;
            this.Gia.Location = new System.Drawing.Point(219, 0);
            this.Gia.Name = "Gia";
            this.Gia.Size = new System.Drawing.Size(128, 22);
            this.Gia.TabIndex = 21;
            this.Gia.Text = "Giá: 500.000 đ";
            // 
            // TenSP
            // 
            this.TenSP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TenSP.AutoSize = true;
            this.TenSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TenSP.ForeColor = System.Drawing.Color.Black;
            this.TenSP.Location = new System.Drawing.Point(92, 32);
            this.TenSP.Name = "TenSP";
            this.TenSP.Size = new System.Drawing.Size(99, 25);
            this.TenSP.TabIndex = 20;
            this.TenSP.Text = "SanPham";
            // 
            // Anh
            // 
            this.Anh.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.Anh.BorderColor = System.Drawing.Color.RoyalBlue;
            this.Anh.BorderColor2 = System.Drawing.Color.HotPink;
            this.Anh.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.Anh.BorderSize = 2;
            this.Anh.Dock = System.Windows.Forms.DockStyle.Left;
            this.Anh.GradientAngle = 50F;
            this.Anh.Location = new System.Drawing.Point(0, 0);
            this.Anh.Margin = new System.Windows.Forms.Padding(0);
            this.Anh.Name = "Anh";
            this.Anh.Size = new System.Drawing.Size(89, 89);
            this.Anh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Anh.TabIndex = 19;
            this.Anh.TabStop = false;
            // 
            // SearchHats
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(219)))), ((int)(((byte)(216)))));
            this.Controls.Add(this.SoLuong);
            this.Controls.Add(this.IdSPCT);
            this.Controls.Add(this.Gia);
            this.Controls.Add(this.TenSP);
            this.Controls.Add(this.Anh);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "SearchHats";
            this.Size = new System.Drawing.Size(347, 96);
            this.Click += new System.EventHandler(this.SearchHats_Click);
            ((System.ComponentModel.ISupportInitialize)(this.Anh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SoLuong;
        private System.Windows.Forms.Label IdSPCT;
        private System.Windows.Forms.Label Gia;
        private System.Windows.Forms.Label TenSP;
        private CustomControls.RJControls.RJCircularPictureBox Anh;
    }
}
