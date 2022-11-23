namespace _3.PL.Views
{
    partial class FrmDoiMK
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDoiMK));
            this.label1 = new System.Windows.Forms.Label();
            this.btn_quaylai = new CustomControls.RJControls.RJCircularPictureBox();
            this.btn_luu = new CustomControls.RJControls.RJButton();
            this.tb_mkHienTai = new System.Windows.Forms.TextBox();
            this.tb_MkMoi = new System.Windows.Forms.TextBox();
            this.tb_nhapLai = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lb_quenMK = new System.Windows.Forms.Label();
            this.cb_htMK = new System.Windows.Forms.CheckBox();
            this.lb_khopMK = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btn_quaylai)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(91, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đổi mật khẩu";
            // 
            // btn_quaylai
            // 
            this.btn_quaylai.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.btn_quaylai.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btn_quaylai.BorderColor2 = System.Drawing.Color.HotPink;
            this.btn_quaylai.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.btn_quaylai.BorderSize = 2;
            this.btn_quaylai.GradientAngle = 50F;
            this.btn_quaylai.Image = ((System.Drawing.Image)(resources.GetObject("btn_quaylai.Image")));
            this.btn_quaylai.Location = new System.Drawing.Point(26, 26);
            this.btn_quaylai.Name = "btn_quaylai";
            this.btn_quaylai.Size = new System.Drawing.Size(47, 47);
            this.btn_quaylai.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_quaylai.TabIndex = 1;
            this.btn_quaylai.TabStop = false;
            this.btn_quaylai.Click += new System.EventHandler(this.btn_quaylai_Click);
            // 
            // btn_luu
            // 
            this.btn_luu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(143)))), ((int)(((byte)(157)))));
            this.btn_luu.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(143)))), ((int)(((byte)(157)))));
            this.btn_luu.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_luu.BorderRadius = 0;
            this.btn_luu.BorderSize = 0;
            this.btn_luu.FlatAppearance.BorderSize = 0;
            this.btn_luu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_luu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_luu.ForeColor = System.Drawing.Color.Black;
            this.btn_luu.Location = new System.Drawing.Point(91, 433);
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.Size = new System.Drawing.Size(622, 60);
            this.btn_luu.TabIndex = 2;
            this.btn_luu.Text = "Lưu thay đổi";
            this.btn_luu.TextColor = System.Drawing.Color.Black;
            this.btn_luu.UseVisualStyleBackColor = false;
            this.btn_luu.Click += new System.EventHandler(this.btn_luu_Click);
            // 
            // tb_mkHienTai
            // 
            this.tb_mkHienTai.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_mkHienTai.Location = new System.Drawing.Point(297, 132);
            this.tb_mkHienTai.Name = "tb_mkHienTai";
            this.tb_mkHienTai.Size = new System.Drawing.Size(416, 31);
            this.tb_mkHienTai.TabIndex = 4;
            // 
            // tb_MkMoi
            // 
            this.tb_MkMoi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_MkMoi.Location = new System.Drawing.Point(297, 192);
            this.tb_MkMoi.Name = "tb_MkMoi";
            this.tb_MkMoi.Size = new System.Drawing.Size(416, 31);
            this.tb_MkMoi.TabIndex = 5;
            // 
            // tb_nhapLai
            // 
            this.tb_nhapLai.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_nhapLai.Location = new System.Drawing.Point(297, 259);
            this.tb_nhapLai.Name = "tb_nhapLai";
            this.tb_nhapLai.Size = new System.Drawing.Size(416, 31);
            this.tb_nhapLai.TabIndex = 6;
            this.tb_nhapLai.TextChanged += new System.EventHandler(this.tb_nhapLai_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(91, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Mật khẩu mới";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(91, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Mật khẩu hiện tại";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(91, 262);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(205, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Nhập lại mật khẩu mới";
            // 
            // lb_quenMK
            // 
            this.lb_quenMK.AutoSize = true;
            this.lb_quenMK.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_quenMK.Location = new System.Drawing.Point(316, 530);
            this.lb_quenMK.Name = "lb_quenMK";
            this.lb_quenMK.Size = new System.Drawing.Size(166, 25);
            this.lb_quenMK.TabIndex = 10;
            this.lb_quenMK.Text = "Forgot password ?";
            this.lb_quenMK.Click += new System.EventHandler(this.lb_quenMK_Click);
            // 
            // cb_htMK
            // 
            this.cb_htMK.AutoSize = true;
            this.cb_htMK.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cb_htMK.Location = new System.Drawing.Point(91, 335);
            this.cb_htMK.Name = "cb_htMK";
            this.cb_htMK.Size = new System.Drawing.Size(191, 29);
            this.cb_htMK.TabIndex = 11;
            this.cb_htMK.Text = "Hiển thị mật khẩu";
            this.cb_htMK.UseVisualStyleBackColor = true;
            this.cb_htMK.CheckedChanged += new System.EventHandler(this.cb_htMK_CheckedChanged);
            this.cb_htMK.Click += new System.EventHandler(this.cb_htMK_Click);
            // 
            // lb_khopMK
            // 
            this.lb_khopMK.AutoSize = true;
            this.lb_khopMK.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_khopMK.ForeColor = System.Drawing.Color.Navy;
            this.lb_khopMK.Location = new System.Drawing.Point(580, 315);
            this.lb_khopMK.Name = "lb_khopMK";
            this.lb_khopMK.Size = new System.Drawing.Size(0, 25);
            this.lb_khopMK.TabIndex = 14;
            // 
            // FrmDoiMK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ClientSize = new System.Drawing.Size(810, 624);
            this.Controls.Add(this.lb_khopMK);
            this.Controls.Add(this.cb_htMK);
            this.Controls.Add(this.lb_quenMK);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_nhapLai);
            this.Controls.Add(this.tb_MkMoi);
            this.Controls.Add(this.tb_mkHienTai);
            this.Controls.Add(this.btn_luu);
            this.Controls.Add(this.btn_quaylai);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmDoiMK";
            this.Text = "FrmDoiMK";
            ((System.ComponentModel.ISupportInitialize)(this.btn_quaylai)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private CustomControls.RJControls.RJCircularPictureBox btn_quaylai;
        private CustomControls.RJControls.RJButton btn_luu;
        private System.Windows.Forms.TextBox tb_mkHienTai;
        private System.Windows.Forms.TextBox tb_MkMoi;
        private System.Windows.Forms.TextBox tb_nhapLai;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lb_quenMK;
        private System.Windows.Forms.CheckBox cb_htMK;
        private System.Windows.Forms.Label lb_khopMK;
    }
}