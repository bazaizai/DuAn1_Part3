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
            this.btn_clear = new System.Windows.Forms.Button();
            this.rdb_khd = new System.Windows.Forms.RadioButton();
            this.rdb_hd = new System.Windows.Forms.RadioButton();
            this.tb_tienkhachdua = new System.Windows.Forms.TextBox();
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
            this.label12 = new System.Windows.Forms.Label();
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
            this.panel1.Location = new System.Drawing.Point(596, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1327, 934);
            this.panel1.TabIndex = 0;
            // 
            // tb_timkiem
            // 
            this.tb_timkiem.Location = new System.Drawing.Point(218, 13);
            this.tb_timkiem.Name = "tb_timkiem";
            this.tb_timkiem.Size = new System.Drawing.Size(797, 37);
            this.tb_timkiem.TabIndex = 2;
            this.tb_timkiem.TextChanged += new System.EventHandler(this.tb_timkiem_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tìm kiếm";
            // 
            // dtg_show
            // 
            this.dtg_show.AllowUserToAddRows = false;
            this.dtg_show.AllowUserToDeleteRows = false;
            this.dtg_show.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dtg_show.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_show.Location = new System.Drawing.Point(3, 67);
            this.dtg_show.Name = "dtg_show";
            this.dtg_show.ReadOnly = true;
            this.dtg_show.RowHeadersVisible = false;
            this.dtg_show.RowHeadersWidth = 62;
            this.dtg_show.RowTemplate.Height = 33;
            this.dtg_show.Size = new System.Drawing.Size(1312, 849);
            this.dtg_show.TabIndex = 0;
            this.dtg_show.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_show_CellClick);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btn_clear);
            this.panel2.Controls.Add(this.rdb_khd);
            this.panel2.Controls.Add(this.rdb_hd);
            this.panel2.Controls.Add(this.tb_tienkhachdua);
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
            this.panel2.Controls.Add(this.label12);
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
            this.panel2.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.panel2.Location = new System.Drawing.Point(2, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(588, 934);
            this.panel2.TabIndex = 1;
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(457, 16);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(112, 34);
            this.btn_clear.TabIndex = 35;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // rdb_khd
            // 
            this.rdb_khd.AutoSize = true;
            this.rdb_khd.Location = new System.Drawing.Point(482, 829);
            this.rdb_khd.Name = "rdb_khd";
            this.rdb_khd.Size = new System.Drawing.Size(78, 34);
            this.rdb_khd.TabIndex = 34;
            this.rdb_khd.TabStop = true;
            this.rdb_khd.Text = "Hủy";
            this.rdb_khd.UseVisualStyleBackColor = true;
            // 
            // rdb_hd
            // 
            this.rdb_hd.AutoSize = true;
            this.rdb_hd.Location = new System.Drawing.Point(224, 829);
            this.rdb_hd.Name = "rdb_hd";
            this.rdb_hd.Size = new System.Drawing.Size(155, 34);
            this.rdb_hd.TabIndex = 33;
            this.rdb_hd.TabStop = true;
            this.rdb_hd.Text = "Thành công";
            this.rdb_hd.UseVisualStyleBackColor = true;
            // 
            // tb_tienkhachdua
            // 
            this.tb_tienkhachdua.Location = new System.Drawing.Point(224, 763);
            this.tb_tienkhachdua.Name = "tb_tienkhachdua";
            this.tb_tienkhachdua.Size = new System.Drawing.Size(350, 37);
            this.tb_tienkhachdua.TabIndex = 32;
            // 
            // tb_giamgia
            // 
            this.tb_giamgia.Location = new System.Drawing.Point(224, 588);
            this.tb_giamgia.Name = "tb_giamgia";
            this.tb_giamgia.Size = new System.Drawing.Size(350, 37);
            this.tb_giamgia.TabIndex = 31;
            // 
            // tb_hinhthucgiamgia
            // 
            this.tb_hinhthucgiamgia.Location = new System.Drawing.Point(224, 645);
            this.tb_hinhthucgiamgia.Name = "tb_hinhthucgiamgia";
            this.tb_hinhthucgiamgia.Size = new System.Drawing.Size(350, 37);
            this.tb_hinhthucgiamgia.TabIndex = 30;
            // 
            // tb_tongtien
            // 
            this.tb_tongtien.Location = new System.Drawing.Point(224, 702);
            this.tb_tongtien.Name = "tb_tongtien";
            this.tb_tongtien.Size = new System.Drawing.Size(350, 37);
            this.tb_tongtien.TabIndex = 29;
            // 
            // dtp_ngaytt
            // 
            this.dtp_ngaytt.Location = new System.Drawing.Point(224, 531);
            this.dtp_ngaytt.Name = "dtp_ngaytt";
            this.dtp_ngaytt.Size = new System.Drawing.Size(350, 37);
            this.dtp_ngaytt.TabIndex = 28;
            // 
            // dtp_ngaytao
            // 
            this.dtp_ngaytao.Location = new System.Drawing.Point(224, 474);
            this.dtp_ngaytao.Name = "dtp_ngaytao";
            this.dtp_ngaytao.Size = new System.Drawing.Size(350, 37);
            this.dtp_ngaytao.TabIndex = 27;
            // 
            // tb_hinhthucmh
            // 
            this.tb_hinhthucmh.Location = new System.Drawing.Point(224, 360);
            this.tb_hinhthucmh.Name = "tb_hinhthucmh";
            this.tb_hinhthucmh.Size = new System.Drawing.Size(350, 37);
            this.tb_hinhthucmh.TabIndex = 25;
            // 
            // tb_mucuudai
            // 
            this.tb_mucuudai.Location = new System.Drawing.Point(224, 417);
            this.tb_mucuudai.Name = "tb_mucuudai";
            this.tb_mucuudai.Size = new System.Drawing.Size(350, 37);
            this.tb_mucuudai.TabIndex = 24;
            // 
            // tb_pttt
            // 
            this.tb_pttt.Location = new System.Drawing.Point(224, 303);
            this.tb_pttt.Name = "tb_pttt";
            this.tb_pttt.Size = new System.Drawing.Size(350, 37);
            this.tb_pttt.TabIndex = 22;
            // 
            // tb_manv
            // 
            this.tb_manv.Location = new System.Drawing.Point(224, 128);
            this.tb_manv.Name = "tb_manv";
            this.tb_manv.Size = new System.Drawing.Size(350, 37);
            this.tb_manv.TabIndex = 21;
            // 
            // tb_makh
            // 
            this.tb_makh.Location = new System.Drawing.Point(224, 185);
            this.tb_makh.Name = "tb_makh";
            this.tb_makh.Size = new System.Drawing.Size(350, 37);
            this.tb_makh.TabIndex = 20;
            // 
            // tb_tenkh
            // 
            this.tb_tenkh.Location = new System.Drawing.Point(224, 246);
            this.tb_tenkh.Name = "tb_tenkh";
            this.tb_tenkh.Size = new System.Drawing.Size(350, 37);
            this.tb_tenkh.TabIndex = 18;
            // 
            // tb_mahd
            // 
            this.tb_mahd.Location = new System.Drawing.Point(224, 71);
            this.tb_mahd.Name = "tb_mahd";
            this.tb_mahd.Size = new System.Drawing.Size(350, 37);
            this.tb_mahd.TabIndex = 17;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(11, 831);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(112, 30);
            this.label18.TabIndex = 16;
            this.label18.Text = "Trạng thái";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(11, 767);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(165, 30);
            this.label12.TabIndex = 15;
            this.label12.Text = "Tiền khách đưa";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(11, 709);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(109, 30);
            this.label13.TabIndex = 14;
            this.label13.Text = "Tổng tiền";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(11, 647);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(203, 30);
            this.label14.TabIndex = 13;
            this.label14.Text = "Hình thức giảm giá";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(11, 589);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(100, 30);
            this.label15.TabIndex = 12;
            this.label15.Text = "Giảm giá";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(11, 531);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(95, 30);
            this.label16.TabIndex = 11;
            this.label16.Text = "Ngày TT";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(11, 473);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(103, 30);
            this.label17.TabIndex = 10;
            this.label17.Text = "Ngày tạo";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 415);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 30);
            this.label8.TabIndex = 8;
            this.label8.Text = "Mức ưu đãi";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 357);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(154, 30);
            this.label9.TabIndex = 7;
            this.label9.Text = "Hình thức MH";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(11, 299);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 30);
            this.label10.TabIndex = 6;
            this.label10.Text = "PTTT";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 241);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 30);
            this.label6.TabIndex = 4;
            this.label6.Text = "Tên KH";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 30);
            this.label4.TabIndex = 2;
            this.label4.Text = "Mã KH";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 30);
            this.label3.TabIndex = 1;
            this.label3.Text = "Mã NV";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 30);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã HĐ";
            // 
            // FrmHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(224)))), ((int)(((byte)(225)))));
            this.ClientSize = new System.Drawing.Size(1924, 939);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
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
        private System.Windows.Forms.Label label12;
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
        private System.Windows.Forms.TextBox tb_tienkhachdua;
        private System.Windows.Forms.TextBox tb_giamgia;
        private System.Windows.Forms.TextBox tb_hinhthucgiamgia;
        private System.Windows.Forms.TextBox tb_tongtien;
        private System.Windows.Forms.DateTimePicker dtp_ngaytt;
        private System.Windows.Forms.Button btn_clear;
    }
}