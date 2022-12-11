namespace _3.PL.Views
{
    partial class FrmCapNhatDonHang
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
            this.label5 = new System.Windows.Forms.Label();
            this.btnclose = new CustomControls.RJControls.RJButton();
            this.btnLuu = new CustomControls.RJControls.RJButton();
            this.txtGiamGia = new CustomControls.RJControls.RJTextBox();
            this.lblMaHoaDon = new System.Windows.Forms.Label();
            this.txtPhiShip = new CustomControls.RJControls.RJTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.cbbPtThanhToan = new CustomControls.RJControls.RJComboBox();
            this.CbbGiamGia = new System.Windows.Forms.ComboBox();
            this.txtMoTa = new CustomControls.RJControls.RJTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(325, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cập nhật thông tin đơn hàng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(669, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 23);
            this.label5.TabIndex = 91;
            this.label5.Text = "X";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // btnclose
            // 
            this.btnclose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(123)))), ((int)(((byte)(125)))));
            this.btnclose.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(123)))), ((int)(((byte)(125)))));
            this.btnclose.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnclose.BorderRadius = 15;
            this.btnclose.BorderSize = 0;
            this.btnclose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnclose.FlatAppearance.BorderSize = 0;
            this.btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclose.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnclose.ForeColor = System.Drawing.Color.White;
            this.btnclose.Location = new System.Drawing.Point(564, 492);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(134, 44);
            this.btnclose.TabIndex = 120;
            this.btnclose.Text = "Bỏ Qua";
            this.btnclose.TextColor = System.Drawing.Color.White;
            this.btnclose.UseVisualStyleBackColor = false;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(122)))), ((int)(((byte)(83)))));
            this.btnLuu.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(122)))), ((int)(((byte)(83)))));
            this.btnLuu.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnLuu.BorderRadius = 15;
            this.btnLuu.BorderSize = 0;
            this.btnLuu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLuu.FlatAppearance.BorderSize = 0;
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.Location = new System.Drawing.Point(424, 492);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(134, 44);
            this.btnLuu.TabIndex = 121;
            this.btnLuu.Text = "Cập nhật";
            this.btnLuu.TextColor = System.Drawing.Color.White;
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // txtGiamGia
            // 
            this.txtGiamGia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(36)))));
            this.txtGiamGia.BorderColor = System.Drawing.Color.White;
            this.txtGiamGia.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtGiamGia.BorderRadius = 0;
            this.txtGiamGia.BorderSize = 1;
            this.txtGiamGia.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtGiamGia.ForeColor = System.Drawing.Color.White;
            this.txtGiamGia.Location = new System.Drawing.Point(261, 118);
            this.txtGiamGia.Margin = new System.Windows.Forms.Padding(4);
            this.txtGiamGia.Multiline = false;
            this.txtGiamGia.Name = "txtGiamGia";
            this.txtGiamGia.Padding = new System.Windows.Forms.Padding(11, 7, 11, 7);
            this.txtGiamGia.PasswordChar = false;
            this.txtGiamGia.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtGiamGia.PlaceholderText = "";
            this.txtGiamGia.Size = new System.Drawing.Size(351, 38);
            this.txtGiamGia.TabIndex = 115;
            this.txtGiamGia.Texts = "";
            this.txtGiamGia.UnderlinedStyle = true;
            this.txtGiamGia._TextChanged += new System.EventHandler(this.txtGiamGia__TextChanged);
            this.txtGiamGia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGiamGia_KeyPress);
            // 
            // lblMaHoaDon
            // 
            this.lblMaHoaDon.AutoSize = true;
            this.lblMaHoaDon.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMaHoaDon.ForeColor = System.Drawing.Color.White;
            this.lblMaHoaDon.Location = new System.Drawing.Point(0, 77);
            this.lblMaHoaDon.Name = "lblMaHoaDon";
            this.lblMaHoaDon.Size = new System.Drawing.Size(61, 23);
            this.lblMaHoaDon.TabIndex = 107;
            this.lblMaHoaDon.Text = "MaHD";
            this.lblMaHoaDon.Visible = false;
            // 
            // txtPhiShip
            // 
            this.txtPhiShip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(36)))));
            this.txtPhiShip.BorderColor = System.Drawing.Color.White;
            this.txtPhiShip.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtPhiShip.BorderRadius = 0;
            this.txtPhiShip.BorderSize = 1;
            this.txtPhiShip.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtPhiShip.ForeColor = System.Drawing.Color.White;
            this.txtPhiShip.Location = new System.Drawing.Point(261, 195);
            this.txtPhiShip.Margin = new System.Windows.Forms.Padding(4);
            this.txtPhiShip.Multiline = false;
            this.txtPhiShip.Name = "txtPhiShip";
            this.txtPhiShip.Padding = new System.Windows.Forms.Padding(11, 7, 11, 7);
            this.txtPhiShip.PasswordChar = false;
            this.txtPhiShip.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtPhiShip.PlaceholderText = "";
            this.txtPhiShip.Size = new System.Drawing.Size(351, 38);
            this.txtPhiShip.TabIndex = 114;
            this.txtPhiShip.Texts = "";
            this.txtPhiShip.UnderlinedStyle = true;
            this.txtPhiShip.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPhiShip_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(76, 287);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(181, 23);
            this.label4.TabIndex = 110;
            this.label4.Text = "Hình thức thanh toán";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(212, 288);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 20);
            this.label3.TabIndex = 118;
            this.label3.Text = "*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(76, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 23);
            this.label2.TabIndex = 111;
            this.label2.Text = "Phí ship";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(83)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(702, 74);
            this.panel1.TabIndex = 106;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(76, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 23);
            this.label6.TabIndex = 109;
            this.label6.Text = "Giảm giá";
            // 
            // cbbPtThanhToan
            // 
            this.cbbPtThanhToan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(36)))));
            this.cbbPtThanhToan.BorderColor = System.Drawing.Color.Black;
            this.cbbPtThanhToan.BorderSize = 1;
            this.cbbPtThanhToan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbbPtThanhToan.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbbPtThanhToan.ForeColor = System.Drawing.Color.White;
            this.cbbPtThanhToan.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.cbbPtThanhToan.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cbbPtThanhToan.ListTextColor = System.Drawing.Color.DimGray;
            this.cbbPtThanhToan.Location = new System.Drawing.Point(261, 280);
            this.cbbPtThanhToan.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbbPtThanhToan.Name = "cbbPtThanhToan";
            this.cbbPtThanhToan.Padding = new System.Windows.Forms.Padding(1);
            this.cbbPtThanhToan.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cbbPtThanhToan.Size = new System.Drawing.Size(351, 30);
            this.cbbPtThanhToan.TabIndex = 122;
            this.cbbPtThanhToan.Texts = "";
            // 
            // CbbGiamGia
            // 
            this.CbbGiamGia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(36)))));
            this.CbbGiamGia.ForeColor = System.Drawing.Color.White;
            this.CbbGiamGia.FormattingEnabled = true;
            this.CbbGiamGia.Items.AddRange(new object[] {
            "%",
            "VNĐ"});
            this.CbbGiamGia.Location = new System.Drawing.Point(537, 124);
            this.CbbGiamGia.Name = "CbbGiamGia";
            this.CbbGiamGia.Size = new System.Drawing.Size(75, 28);
            this.CbbGiamGia.TabIndex = 123;
            // 
            // txtMoTa
            // 
            this.txtMoTa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(36)))));
            this.txtMoTa.BorderColor = System.Drawing.Color.White;
            this.txtMoTa.BorderFocusColor = System.Drawing.Color.White;
            this.txtMoTa.BorderRadius = 15;
            this.txtMoTa.BorderSize = 2;
            this.txtMoTa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMoTa.ForeColor = System.Drawing.Color.White;
            this.txtMoTa.Location = new System.Drawing.Point(76, 352);
            this.txtMoTa.Margin = new System.Windows.Forms.Padding(4);
            this.txtMoTa.Multiline = true;
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtMoTa.PasswordChar = false;
            this.txtMoTa.PlaceholderColor = System.Drawing.Color.White;
            this.txtMoTa.PlaceholderText = "Ghi Chú";
            this.txtMoTa.Size = new System.Drawing.Size(536, 112);
            this.txtMoTa.TabIndex = 124;
            this.txtMoTa.Texts = "";
            this.txtMoTa.UnderlinedStyle = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(562, 206);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 23);
            this.label7.TabIndex = 125;
            this.label7.Text = "VNĐ";
            // 
            // FrmCapNhatDonHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(702, 556);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtMoTa);
            this.Controls.Add(this.CbbGiamGia);
            this.Controls.Add(this.cbbPtThanhToan);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.txtGiamGia);
            this.Controls.Add(this.lblMaHoaDon);
            this.Controls.Add(this.txtPhiShip);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCapNhatDonHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCapNhatDonHang";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private CustomControls.RJControls.RJButton btnclose;
        private CustomControls.RJControls.RJButton btnLuu;
        private CustomControls.RJControls.RJTextBox txtGiamGia;
        private System.Windows.Forms.Label lblMaHoaDon;
        private CustomControls.RJControls.RJTextBox txtPhiShip;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private CustomControls.RJControls.RJComboBox cbbPtThanhToan;
        private System.Windows.Forms.ComboBox CbbGiamGia;
        private CustomControls.RJControls.RJTextBox txtMoTa;
        private System.Windows.Forms.Label label7;
    }
}