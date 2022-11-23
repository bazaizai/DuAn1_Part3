namespace _3.PL.Views
{
    partial class FrmChatLieu
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
            this.label14 = new System.Windows.Forms.Label();
            this.tb_TimKiem = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_Ten = new System.Windows.Forms.Label();
            this.tb_Ten = new System.Windows.Forms.TextBox();
            this.lb_Ma = new System.Windows.Forms.Label();
            this.tb_Ma = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtg_Show = new System.Windows.Forms.DataGridView();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Show)).BeginInit();
            this.SuspendLayout();
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(476, 28);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(84, 25);
            this.label14.TabIndex = 87;
            this.label14.Text = "Tìm kiếm";
            // 
            // tb_TimKiem
            // 
            this.tb_TimKiem.Location = new System.Drawing.Point(566, 22);
            this.tb_TimKiem.Name = "tb_TimKiem";
            this.tb_TimKiem.Size = new System.Drawing.Size(394, 31);
            this.tb_TimKiem.TabIndex = 86;
            this.tb_TimKiem.TextChanged += new System.EventHandler(this.tb_TimKiem_TextChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox3.Controls.Add(this.radioButton2);
            this.groupBox3.Controls.Add(this.radioButton1);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.lb_Ten);
            this.groupBox3.Controls.Add(this.tb_Ten);
            this.groupBox3.Controls.Add(this.lb_Ma);
            this.groupBox3.Controls.Add(this.tb_Ma);
            this.groupBox3.Location = new System.Drawing.Point(47, 396);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(572, 280);
            this.groupBox3.TabIndex = 85;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông tin ";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(396, 210);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(78, 29);
            this.radioButton2.TabIndex = 12;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "0 HD";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(174, 210);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(63, 29);
            this.radioButton1.TabIndex = 11;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "HD";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 210);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Trạng thái";
            // 
            // lb_Ten
            // 
            this.lb_Ten.AutoSize = true;
            this.lb_Ten.Location = new System.Drawing.Point(59, 142);
            this.lb_Ten.Name = "lb_Ten";
            this.lb_Ten.Size = new System.Drawing.Size(43, 25);
            this.lb_Ten.TabIndex = 8;
            this.lb_Ten.Text = "Tên ";
            // 
            // tb_Ten
            // 
            this.tb_Ten.Location = new System.Drawing.Point(174, 139);
            this.tb_Ten.Name = "tb_Ten";
            this.tb_Ten.Size = new System.Drawing.Size(301, 31);
            this.tb_Ten.TabIndex = 7;
            // 
            // lb_Ma
            // 
            this.lb_Ma.AutoSize = true;
            this.lb_Ma.Location = new System.Drawing.Point(59, 87);
            this.lb_Ma.Name = "lb_Ma";
            this.lb_Ma.Size = new System.Drawing.Size(37, 25);
            this.lb_Ma.TabIndex = 3;
            this.lb_Ma.Text = "Mã";
            // 
            // tb_Ma
            // 
            this.tb_Ma.Location = new System.Drawing.Point(174, 81);
            this.tb_Ma.Name = "tb_Ma";
            this.tb_Ma.Size = new System.Drawing.Size(301, 31);
            this.tb_Ma.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox2.Controls.Add(this.btn_Reset);
            this.groupBox2.Controls.Add(this.btn_Xoa);
            this.groupBox2.Controls.Add(this.btn_Sua);
            this.groupBox2.Controls.Add(this.btn_Them);
            this.groupBox2.Location = new System.Drawing.Point(757, 396);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(203, 280);
            this.groupBox2.TabIndex = 84;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức năng ";
            // 
            // btn_Reset
            // 
            this.btn_Reset.Location = new System.Drawing.Point(45, 225);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(112, 46);
            this.btn_Reset.TabIndex = 7;
            this.btn_Reset.Text = "Reset";
            this.btn_Reset.UseVisualStyleBackColor = true;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(45, 160);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(112, 46);
            this.btn_Xoa.TabIndex = 6;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Location = new System.Drawing.Point(45, 94);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(112, 46);
            this.btn_Sua.TabIndex = 5;
            this.btn_Sua.Text = "Sửa ";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(45, 30);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(112, 46);
            this.btn_Them.TabIndex = 4;
            this.btn_Them.Text = "Thêm ";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.dtg_Show);
            this.groupBox1.Location = new System.Drawing.Point(47, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(913, 293);
            this.groupBox1.TabIndex = 83;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách ";
            // 
            // dtg_Show
            // 
            this.dtg_Show.AllowUserToAddRows = false;
            this.dtg_Show.AllowUserToDeleteRows = false;
            this.dtg_Show.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg_Show.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_Show.Location = new System.Drawing.Point(17, 30);
            this.dtg_Show.Name = "dtg_Show";
            this.dtg_Show.ReadOnly = true;
            this.dtg_Show.RowHeadersWidth = 62;
            this.dtg_Show.RowTemplate.Height = 33;
            this.dtg_Show.Size = new System.Drawing.Size(870, 224);
            this.dtg_Show.TabIndex = 0;
            this.dtg_Show.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_Show_CellClick);
            // 
            // FrmChatLieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 698);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.tb_TimKiem);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmChatLieu";
            this.Text = "FrmChatLieu";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Show)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tb_TimKiem;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_Ten;
        private System.Windows.Forms.TextBox tb_Ten;
        private System.Windows.Forms.Label lb_Ma;
        private System.Windows.Forms.TextBox tb_Ma;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dtg_Show;
    }
}