namespace _3.PL.Views
{
    partial class FrmForgotPW
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmForgotPW));
            this.tb_email = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_tk = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rjCircularPictureBox1 = new CustomControls.RJControls.RJCircularPictureBox();
            this.lb_SignIn = new System.Windows.Forms.Label();
            this.btn_xacNhan = new CustomControls.RJControls.RJButton();
            ((System.ComponentModel.ISupportInitialize)(this.rjCircularPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_email
            // 
            this.tb_email.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(219)))), ((int)(((byte)(216)))));
            this.tb_email.ForeColor = System.Drawing.Color.Black;
            this.tb_email.Location = new System.Drawing.Point(146, 589);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(387, 31);
            this.tb_email.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(146, 551);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Vui lòng nhập Email";
            // 
            // tb_tk
            // 
            this.tb_tk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(219)))), ((int)(((byte)(216)))));
            this.tb_tk.ForeColor = System.Drawing.Color.Black;
            this.tb_tk.Location = new System.Drawing.Point(146, 486);
            this.tb_tk.Name = "tb_tk";
            this.tb_tk.Size = new System.Drawing.Size(387, 31);
            this.tb_tk.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(146, 449);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(216, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Vui lòng nhập tài khoản";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(219, 356);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(255, 41);
            this.label3.TabIndex = 17;
            this.label3.Text = "Forgot password";
            // 
            // rjCircularPictureBox1
            // 
            this.rjCircularPictureBox1.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.rjCircularPictureBox1.BorderColor = System.Drawing.Color.RoyalBlue;
            this.rjCircularPictureBox1.BorderColor2 = System.Drawing.Color.HotPink;
            this.rjCircularPictureBox1.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.rjCircularPictureBox1.BorderSize = 2;
            this.rjCircularPictureBox1.GradientAngle = 50F;
            this.rjCircularPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("rjCircularPictureBox1.Image")));
            this.rjCircularPictureBox1.Location = new System.Drawing.Point(219, 68);
            this.rjCircularPictureBox1.Name = "rjCircularPictureBox1";
            this.rjCircularPictureBox1.Size = new System.Drawing.Size(261, 261);
            this.rjCircularPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rjCircularPictureBox1.TabIndex = 18;
            this.rjCircularPictureBox1.TabStop = false;
            // 
            // lb_SignIn
            // 
            this.lb_SignIn.AutoSize = true;
            this.lb_SignIn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_SignIn.ForeColor = System.Drawing.Color.Black;
            this.lb_SignIn.Location = new System.Drawing.Point(450, 684);
            this.lb_SignIn.Name = "lb_SignIn";
            this.lb_SignIn.Size = new System.Drawing.Size(83, 28);
            this.lb_SignIn.TabIndex = 19;
            this.lb_SignIn.Text = "Sign In ";
            this.lb_SignIn.Click += new System.EventHandler(this.lb_SignIn_Click);
            // 
            // btn_xacNhan
            // 
            this.btn_xacNhan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(143)))), ((int)(((byte)(157)))));
            this.btn_xacNhan.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(143)))), ((int)(((byte)(157)))));
            this.btn_xacNhan.BorderColor = System.Drawing.Color.HotPink;
            this.btn_xacNhan.BorderRadius = 0;
            this.btn_xacNhan.BorderSize = 0;
            this.btn_xacNhan.FlatAppearance.BorderSize = 0;
            this.btn_xacNhan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_xacNhan.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_xacNhan.ForeColor = System.Drawing.Color.Black;
            this.btn_xacNhan.Location = new System.Drawing.Point(146, 674);
            this.btn_xacNhan.Name = "btn_xacNhan";
            this.btn_xacNhan.Size = new System.Drawing.Size(128, 38);
            this.btn_xacNhan.TabIndex = 20;
            this.btn_xacNhan.Text = "Xác nhận";
            this.btn_xacNhan.TextColor = System.Drawing.Color.Black;
            this.btn_xacNhan.UseVisualStyleBackColor = false;
            this.btn_xacNhan.Click += new System.EventHandler(this.btn_xacNhan_Click);
            // 
            // FrmForgotPW
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ClientSize = new System.Drawing.Size(709, 805);
            this.Controls.Add(this.btn_xacNhan);
            this.Controls.Add(this.lb_SignIn);
            this.Controls.Add(this.rjCircularPictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_tk);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_email);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmForgotPW";
            this.Text = "FrmQuenMatKhau";
            ((System.ComponentModel.ISupportInitialize)(this.rjCircularPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_tk;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private CustomControls.RJControls.RJCircularPictureBox rjCircularPictureBox1;
        private System.Windows.Forms.Label lb_SignIn;
        private CustomControls.RJControls.RJButton btn_xacNhan;
    }
}