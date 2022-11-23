namespace _3.PL.Components
{
    partial class Hats
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
            this.IdSPCT = new System.Windows.Forms.Label();
            this.Add = new CustomControls.RJControls.RJButton();
            this.Gia = new System.Windows.Forms.Label();
            this.TenSP = new System.Windows.Forms.Label();
            this.Anh = new CustomControls.RJControls.RJCircularPictureBox();
            this.SoLuong = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Anh)).BeginInit();
            this.SuspendLayout();
            // 
            // IdSPCT
            // 
            this.IdSPCT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.IdSPCT.AutoSize = true;
            this.IdSPCT.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.IdSPCT.ForeColor = System.Drawing.Color.Silver;
            this.IdSPCT.Location = new System.Drawing.Point(-2, 137);
            this.IdSPCT.Name = "IdSPCT";
            this.IdSPCT.Size = new System.Drawing.Size(64, 12);
            this.IdSPCT.TabIndex = 17;
            this.IdSPCT.Text = "Số lượng: 500";
            this.IdSPCT.Visible = false;
            // 
            // Add
            // 
            this.Add.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(143)))), ((int)(((byte)(157)))));
            this.Add.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(143)))), ((int)(((byte)(157)))));
            this.Add.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.Add.BorderRadius = 15;
            this.Add.BorderSize = 0;
            this.Add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Add.FlatAppearance.BorderSize = 0;
            this.Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Add.ForeColor = System.Drawing.Color.Black;
            this.Add.Location = new System.Drawing.Point(107, 106);
            this.Add.Margin = new System.Windows.Forms.Padding(0);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(107, 29);
            this.Add.TabIndex = 12;
            this.Add.Text = "Add";
            this.Add.TextColor = System.Drawing.Color.Black;
            this.Add.UseVisualStyleBackColor = false;
            this.Add.Click += new System.EventHandler(this.Add_Click_1);
            // 
            // Gia
            // 
            this.Gia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Gia.AutoSize = true;
            this.Gia.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Gia.ForeColor = System.Drawing.Color.Red;
            this.Gia.Location = new System.Drawing.Point(116, 72);
            this.Gia.Name = "Gia";
            this.Gia.Size = new System.Drawing.Size(90, 16);
            this.Gia.TabIndex = 11;
            this.Gia.Text = "Giá: 500.000 đ";
            // 
            // TenSP
            // 
            this.TenSP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TenSP.AutoSize = true;
            this.TenSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TenSP.ForeColor = System.Drawing.Color.Black;
            this.TenSP.Location = new System.Drawing.Point(97, 3);
            this.TenSP.Name = "TenSP";
            this.TenSP.Size = new System.Drawing.Size(99, 25);
            this.TenSP.TabIndex = 10;
            this.TenSP.Text = "SanPham";
            // 
            // Anh
            // 
            this.Anh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Anh.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.Anh.BorderColor = System.Drawing.Color.RoyalBlue;
            this.Anh.BorderColor2 = System.Drawing.Color.HotPink;
            this.Anh.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.Anh.BorderSize = 2;
            this.Anh.GradientAngle = 50F;
            this.Anh.Location = new System.Drawing.Point(-1, 10);
            this.Anh.Margin = new System.Windows.Forms.Padding(0);
            this.Anh.Name = "Anh";
            this.Anh.Size = new System.Drawing.Size(109, 109);
            this.Anh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Anh.TabIndex = 9;
            this.Anh.TabStop = false;
            // 
            // SoLuong
            // 
            this.SoLuong.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SoLuong.AutoSize = true;
            this.SoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SoLuong.ForeColor = System.Drawing.Color.Black;
            this.SoLuong.Location = new System.Drawing.Point(116, 47);
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.Size = new System.Drawing.Size(60, 16);
            this.SoLuong.TabIndex = 18;
            this.SoLuong.Text = "Số lượng";
            // 
            // Hats
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(219)))), ((int)(((byte)(216)))));
            this.Controls.Add(this.SoLuong);
            this.Controls.Add(this.IdSPCT);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.Gia);
            this.Controls.Add(this.TenSP);
            this.Controls.Add(this.Anh);
            this.Name = "Hats";
            this.Size = new System.Drawing.Size(216, 142);
            ((System.ComponentModel.ISupportInitialize)(this.Anh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label IdSPCT;
        private CustomControls.RJControls.RJButton Add;
        private System.Windows.Forms.Label Gia;
        private System.Windows.Forms.Label TenSP;
        private CustomControls.RJControls.RJCircularPictureBox Anh;
        private System.Windows.Forms.Label SoLuong;
    }
}
