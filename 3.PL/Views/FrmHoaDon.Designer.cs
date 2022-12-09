namespace _3.PL.Views
{
    partial class FrmHoaDon
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tb_timkiem = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtg_show = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtngaythanhToan = new System.Windows.Forms.TextBox();
            this.btn_clear = new System.Windows.Forms.Button();
            this.rdb_khd = new System.Windows.Forms.RadioButton();
            this.rdb_hd = new System.Windows.Forms.RadioButton();
            this.tb_giamgia = new System.Windows.Forms.TextBox();
            this.tb_hinhthucgiamgia = new System.Windows.Forms.TextBox();
            this.tb_tongtien = new System.Windows.Forms.TextBox();
            this.dtp_ngaytt = new System.Windows.Forms.DateTimePicker();
            this.dtp_ngaytao = new System.Windows.Forms.DateTimePicker();
            this.tb_hinhthucmh = new System.Windows.Forms.TextBox();
            this.tb_mucuudai = new System.Windows.Forms.TextBox();
            this.tb_pttt = new System.Windows.Forms.TextBox();
            this.tb_manv = new System.Windows.Forms.TextBox();
            this.tb_makh = new System.Windows.Forms.TextBox();
            this.tb_tenkh = new System.Windows.Forms.TextBox();
            this.tb_mahd = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_show)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.tb_timkiem);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dtg_show);
            this.panel1.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.panel1.Location = new System.Drawing.Point(477, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1063, 747);
            this.panel1.TabIndex = 0;
            // 
            // tb_timkiem
            // 
            this.tb_timkiem.Location = new System.Drawing.Point(175, 11);
            this.tb_timkiem.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tb_timkiem.Name = "tb_timkiem";
            this.tb_timkiem.Size = new System.Drawing.Size(638, 32);
            this.tb_timkiem.TabIndex = 2;
            this.tb_timkiem.TextChanged += new System.EventHandler(this.tb_timkiem_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tìm kiếm";
            // 
            // dtg_show
            // 
            this.dtg_show.AllowUserToAddRows = false;
            this.dtg_show.AllowUserToDeleteRows = false;
            this.dtg_show.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg_show.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dtg_show.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_show.Location = new System.Drawing.Point(2, 53);
            this.dtg_show.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dtg_show.Name = "dtg_show";
            this.dtg_show.ReadOnly = true;
            this.dtg_show.RowHeadersVisible = false;
            this.dtg_show.RowHeadersWidth = 62;
            this.dtg_show.RowTemplate.Height = 33;
            this.dtg_show.Size = new System.Drawing.Size(1004, 679);
            this.dtg_show.TabIndex = 0;
            this.dtg_show.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_show_CellClick);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.txtngaythanhToan);
            this.panel2.Controls.Add(this.btn_clear);
            this.panel2.Controls.Add(this.rdb_khd);
            this.panel2.Controls.Add(this.rdb_hd);
            this.panel2.Controls.Add(this.tb_giamgia);
            this.panel2.Controls.Add(this.tb_hinhthucgiamgia);
            this.panel2.Controls.Add(this.tb_tongtien);
            this.panel2.Controls.Add(this.dtp_ngaytt);
            this.panel2.Controls.Add(this.dtp_ngaytao);
            this.panel2.Controls.Add(this.tb_hinhthucmh);
            this.panel2.Controls.Add(this.tb_mucuudai);
            this.panel2.Controls.Add(this.tb_pttt);
            this.panel2.Controls.Add(this.tb_manv);
            this.panel2.Controls.Add(this.tb_makh);
            this.panel2.Controls.Add(this.tb_tenkh);
            this.panel2.Controls.Add(this.tb_mahd);
            this.panel2.Controls.Add(this.label18);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.label17);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(471, 751);
            this.panel2.TabIndex = 1;
            // 
            // txtngaythanhToan
            // 
            this.txtngaythanhToan.Location = new System.Drawing.Point(179, 425);
            this.txtngaythanhToan.Name = "txtngaythanhToan";
            this.txtngaythanhToan.Size = new System.Drawing.Size(281, 32);
            this.txtngaythanhToan.TabIndex = 36;
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(366, 13);
            this.btn_clear.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(89, 39);
            this.btn_clear.TabIndex = 35;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // rdb_khd
            // 
            this.rdb_khd.AutoSize = true;
            this.rdb_khd.Enabled = false;
            this.rdb_khd.Location = new System.Drawing.Point(385, 620);
            this.rdb_khd.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.rdb_khd.Name = "rdb_khd";
            this.rdb_khd.Size = new System.Drawing.Size(68, 29);
            this.rdb_khd.TabIndex = 34;
            this.rdb_khd.TabStop = true;
            this.rdb_khd.Text = "Hủy";
            this.rdb_khd.UseVisualStyleBackColor = true;
            this.rdb_khd.CheckedChanged += new System.EventHandler(this.rdb_khd_CheckedChanged);
            // 
            // rdb_hd
            // 
            this.rdb_hd.AutoSize = true;
            this.rdb_hd.Enabled = false;
            this.rdb_hd.Location = new System.Drawing.Point(179, 620);
            this.rdb_hd.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.rdb_hd.Name = "rdb_hd";
            this.rdb_hd.Size = new System.Drawing.Size(133, 29);
            this.rdb_hd.TabIndex = 33;
            this.rdb_hd.TabStop = true;
            this.rdb_hd.Text = "Thành công";
            this.rdb_hd.UseVisualStyleBackColor = true;
            this.rdb_hd.CheckedChanged += new System.EventHandler(this.rdb_hd_CheckedChanged);
            // 
            // tb_giamgia
            // 
            this.tb_giamgia.Location = new System.Drawing.Point(179, 471);
            this.tb_giamgia.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tb_giamgia.Name = "tb_giamgia";
            this.tb_giamgia.ReadOnly = true;
            this.tb_giamgia.Size = new System.Drawing.Size(281, 32);
            this.tb_giamgia.TabIndex = 31;
            // 
            // tb_hinhthucgiamgia
            // 
            this.tb_hinhthucgiamgia.Location = new System.Drawing.Point(179, 516);
            this.tb_hinhthucgiamgia.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tb_hinhthucgiamgia.Name = "tb_hinhthucgiamgia";
            this.tb_hinhthucgiamgia.ReadOnly = true;
            this.tb_hinhthucgiamgia.Size = new System.Drawing.Size(281, 32);
            this.tb_hinhthucgiamgia.TabIndex = 30;
            // 
            // tb_tongtien
            // 
            this.tb_tongtien.Location = new System.Drawing.Point(179, 561);
            this.tb_tongtien.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tb_tongtien.Name = "tb_tongtien";
            this.tb_tongtien.ReadOnly = true;
            this.tb_tongtien.Size = new System.Drawing.Size(281, 32);
            this.tb_tongtien.TabIndex = 29;
            // 
            // dtp_ngaytt
            // 
            this.dtp_ngaytt.Location = new System.Drawing.Point(179, 425);
            this.dtp_ngaytt.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dtp_ngaytt.Name = "dtp_ngaytt";
            this.dtp_ngaytt.Size = new System.Drawing.Size(281, 32);
            this.dtp_ngaytt.TabIndex = 28;
            // 
            // dtp_ngaytao
            // 
            this.dtp_ngaytao.Location = new System.Drawing.Point(179, 379);
            this.dtp_ngaytao.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dtp_ngaytao.Name = "dtp_ngaytao";
            this.dtp_ngaytao.Size = new System.Drawing.Size(281, 32);
            this.dtp_ngaytao.TabIndex = 27;
            // 
            // tb_hinhthucmh
            // 
            this.tb_hinhthucmh.Location = new System.Drawing.Point(179, 288);
            this.tb_hinhthucmh.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tb_hinhthucmh.Name = "tb_hinhthucmh";
            this.tb_hinhthucmh.ReadOnly = true;
            this.tb_hinhthucmh.Size = new System.Drawing.Size(281, 32);
            this.tb_hinhthucmh.TabIndex = 25;
            // 
            // tb_mucuudai
            // 
            this.tb_mucuudai.Location = new System.Drawing.Point(179, 333);
            this.tb_mucuudai.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tb_mucuudai.Name = "tb_mucuudai";
            this.tb_mucuudai.ReadOnly = true;
            this.tb_mucuudai.Size = new System.Drawing.Size(281, 32);
            this.tb_mucuudai.TabIndex = 24;
            // 
            // tb_pttt
            // 
            this.tb_pttt.Location = new System.Drawing.Point(179, 243);
            this.tb_pttt.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tb_pttt.Name = "tb_pttt";
            this.tb_pttt.ReadOnly = true;
            this.tb_pttt.Size = new System.Drawing.Size(281, 32);
            this.tb_pttt.TabIndex = 22;
            // 
            // tb_manv
            // 
            this.tb_manv.Location = new System.Drawing.Point(179, 107);
            this.tb_manv.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tb_manv.Name = "tb_manv";
            this.tb_manv.ReadOnly = true;
            this.tb_manv.Size = new System.Drawing.Size(281, 32);
            this.tb_manv.TabIndex = 21;
            // 
            // tb_makh
            // 
            this.tb_makh.Location = new System.Drawing.Point(179, 148);
            this.tb_makh.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tb_makh.Name = "tb_makh";
            this.tb_makh.ReadOnly = true;
            this.tb_makh.Size = new System.Drawing.Size(281, 32);
            this.tb_makh.TabIndex = 20;
            // 
            // tb_tenkh
            // 
            this.tb_tenkh.Location = new System.Drawing.Point(179, 197);
            this.tb_tenkh.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tb_tenkh.Name = "tb_tenkh";
            this.tb_tenkh.ReadOnly = true;
            this.tb_tenkh.Size = new System.Drawing.Size(281, 32);
            this.tb_tenkh.TabIndex = 18;
            // 
            // tb_mahd
            // 
            this.tb_mahd.Location = new System.Drawing.Point(179, 57);
            this.tb_mahd.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tb_mahd.Name = "tb_mahd";
            this.tb_mahd.ReadOnly = true;
            this.tb_mahd.Size = new System.Drawing.Size(281, 32);
            this.tb_mahd.TabIndex = 17;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(9, 623);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(97, 25);
            this.label18.TabIndex = 16;
            this.label18.Text = "Trạng thái";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(10, 571);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(93, 25);
            this.label13.TabIndex = 14;
            this.label13.Text = "Tổng tiền";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(9, 525);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(176, 25);
            this.label14.TabIndex = 13;
            this.label14.Text = "Hình thức giảm giá";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(11, 480);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(88, 25);
            this.label15.TabIndex = 12;
            this.label15.Text = "Giảm giá";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(9, 435);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(83, 25);
            this.label16.TabIndex = 11;
            this.label16.Text = "Ngày TT";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(11, 388);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(91, 25);
            this.label17.TabIndex = 10;
            this.label17.Text = "Ngày tạo";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 343);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 25);
            this.label8.TabIndex = 8;
            this.label8.Text = "Mức ưu đãi";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 297);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(134, 25);
            this.label9.TabIndex = 7;
            this.label9.Text = "Hình thức MH";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 252);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 25);
            this.label10.TabIndex = 6;
            this.label10.Text = "PTTT";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 207);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 25);
            this.label6.TabIndex = 4;
            this.label6.Text = "Tên KH";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 157);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Mã KH";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 116);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Mã NV";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 67);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã HĐ";
            // 
            // FrmHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(224)))), ((int)(((byte)(225)))));
            this.ClientSize = new System.Drawing.Size(1539, 751);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "FrmHoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmHoaDon";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_show)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dtg_show;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tb_timkiem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DateTimePicker dtp_ngaytao;
        private System.Windows.Forms.TextBox tb_hinhthucmh;
        private System.Windows.Forms.TextBox tb_mucuudai;
        private System.Windows.Forms.TextBox tb_pttt;
        private System.Windows.Forms.TextBox tb_manv;
        private System.Windows.Forms.TextBox tb_makh;
        private System.Windows.Forms.TextBox tb_tenkh;
        private System.Windows.Forms.TextBox tb_mahd;
        private System.Windows.Forms.RadioButton rdb_khd;
        private System.Windows.Forms.RadioButton rdb_hd;
        private System.Windows.Forms.TextBox tb_giamgia;
        private System.Windows.Forms.TextBox tb_hinhthucgiamgia;
        private System.Windows.Forms.TextBox tb_tongtien;
        private System.Windows.Forms.DateTimePicker dtp_ngaytt;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.TextBox txtngaythanhToan;
    }
}