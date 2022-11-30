namespace _3.PL.Views
{
    partial class FrmSale
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
            this.bt_xoaform = new System.Windows.Forms.Button();
            this.rdb_khd = new System.Windows.Forms.RadioButton();
            this.rdb_hd = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_timkiem = new System.Windows.Forms.TextBox();
            this.dtg_show = new System.Windows.Forms.DataGridView();
            this.bt_xoa = new System.Windows.Forms.Button();
            this.tb_them = new System.Windows.Forms.Button();
            this.bt_update = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_ten = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_ma = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lb_mucgiam = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_mota = new System.Windows.Forms.TextBox();
            this.tb_mucgiam = new System.Windows.Forms.TextBox();
            this.dtp_start = new System.Windows.Forms.DateTimePicker();
            this.dtp_end = new System.Windows.Forms.DateTimePicker();
            this.cbb_loaiKm = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_show)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_xoaform
            // 
            this.bt_xoaform.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(143)))), ((int)(((byte)(157)))));
            this.bt_xoaform.ForeColor = System.Drawing.SystemColors.Control;
            this.bt_xoaform.Location = new System.Drawing.Point(491, 194);
            this.bt_xoaform.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_xoaform.Name = "bt_xoaform";
            this.bt_xoaform.Size = new System.Drawing.Size(78, 37);
            this.bt_xoaform.TabIndex = 59;
            this.bt_xoaform.Text = "Xóa form";
            this.bt_xoaform.UseVisualStyleBackColor = false;
            this.bt_xoaform.Click += new System.EventHandler(this.bt_xoaform_Click);
            // 
            // rdb_khd
            // 
            this.rdb_khd.AutoSize = true;
            this.rdb_khd.Location = new System.Drawing.Point(275, 297);
            this.rdb_khd.Name = "rdb_khd";
            this.rdb_khd.Size = new System.Drawing.Size(118, 19);
            this.rdb_khd.TabIndex = 58;
            this.rdb_khd.TabStop = true;
            this.rdb_khd.Text = "Không hoạt động";
            this.rdb_khd.UseVisualStyleBackColor = true;
            // 
            // rdb_hd
            // 
            this.rdb_hd.AutoSize = true;
            this.rdb_hd.Location = new System.Drawing.Point(153, 297);
            this.rdb_hd.Name = "rdb_hd";
            this.rdb_hd.Size = new System.Drawing.Size(83, 19);
            this.rdb_hd.TabIndex = 57;
            this.rdb_hd.TabStop = true;
            this.rdb_hd.Text = "Hoạt Động";
            this.rdb_hd.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(75, 346);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 15);
            this.label4.TabIndex = 56;
            this.label4.Text = "tìm kiếm";
            // 
            // tb_timkiem
            // 
            this.tb_timkiem.Location = new System.Drawing.Point(151, 343);
            this.tb_timkiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_timkiem.Name = "tb_timkiem";
            this.tb_timkiem.Size = new System.Drawing.Size(399, 23);
            this.tb_timkiem.TabIndex = 55;
            this.tb_timkiem.TextChanged += new System.EventHandler(this.tb_timkiem_TextChanged);
            // 
            // dtg_show
            // 
            this.dtg_show.AllowUserToAddRows = false;
            this.dtg_show.AllowUserToDeleteRows = false;
            this.dtg_show.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg_show.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(224)))), ((int)(((byte)(225)))));
            this.dtg_show.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtg_show.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_show.Location = new System.Drawing.Point(43, 370);
            this.dtg_show.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtg_show.Name = "dtg_show";
            this.dtg_show.ReadOnly = true;
            this.dtg_show.RowHeadersVisible = false;
            this.dtg_show.RowHeadersWidth = 51;
            this.dtg_show.RowTemplate.Height = 29;
            this.dtg_show.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtg_show.Size = new System.Drawing.Size(551, 141);
            this.dtg_show.TabIndex = 54;
            this.dtg_show.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_show_CellClick);
            // 
            // bt_xoa
            // 
            this.bt_xoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(143)))), ((int)(((byte)(157)))));
            this.bt_xoa.ForeColor = System.Drawing.SystemColors.Control;
            this.bt_xoa.Location = new System.Drawing.Point(491, 150);
            this.bt_xoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_xoa.Name = "bt_xoa";
            this.bt_xoa.Size = new System.Drawing.Size(78, 37);
            this.bt_xoa.TabIndex = 53;
            this.bt_xoa.Text = "xóa";
            this.bt_xoa.UseVisualStyleBackColor = false;
            this.bt_xoa.Click += new System.EventHandler(this.bt_xoa_Click);
            // 
            // tb_them
            // 
            this.tb_them.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(143)))), ((int)(((byte)(157)))));
            this.tb_them.ForeColor = System.Drawing.SystemColors.Control;
            this.tb_them.Location = new System.Drawing.Point(491, 102);
            this.tb_them.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_them.Name = "tb_them";
            this.tb_them.Size = new System.Drawing.Size(78, 37);
            this.tb_them.TabIndex = 52;
            this.tb_them.Text = "Thêm";
            this.tb_them.UseVisualStyleBackColor = false;
            this.tb_them.Click += new System.EventHandler(this.tb_them_Click);
            // 
            // bt_update
            // 
            this.bt_update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(143)))), ((int)(((byte)(157)))));
            this.bt_update.ForeColor = System.Drawing.SystemColors.Control;
            this.bt_update.Location = new System.Drawing.Point(491, 56);
            this.bt_update.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_update.Name = "bt_update";
            this.bt_update.Size = new System.Drawing.Size(78, 37);
            this.bt_update.TabIndex = 51;
            this.bt_update.Text = "Sửa";
            this.bt_update.UseVisualStyleBackColor = false;
            this.bt_update.Click += new System.EventHandler(this.bt_update_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 299);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 15);
            this.label3.TabIndex = 50;
            this.label3.Text = "Trạng thái";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 15);
            this.label2.TabIndex = 49;
            this.label2.Text = "Tên";
            // 
            // tb_ten
            // 
            this.tb_ten.Location = new System.Drawing.Point(177, 73);
            this.tb_ten.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_ten.Name = "tb_ten";
            this.tb_ten.Size = new System.Drawing.Size(216, 23);
            this.tb_ten.TabIndex = 48;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 15);
            this.label1.TabIndex = 47;
            this.label1.Text = "Mã";
            // 
            // tb_ma
            // 
            this.tb_ma.Location = new System.Drawing.Point(177, 34);
            this.tb_ma.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_ma.Name = "tb_ma";
            this.tb_ma.Size = new System.Drawing.Size(216, 23);
            this.tb_ma.TabIndex = 46;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(79, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 15);
            this.label5.TabIndex = 60;
            this.label5.Text = "Ngày bắt đầu";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(79, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 15);
            this.label6.TabIndex = 61;
            this.label6.Text = "Ngày kết thúc";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(79, 193);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 15);
            this.label7.TabIndex = 62;
            this.label7.Text = "Loại hình KM";
            // 
            // lb_mucgiam
            // 
            this.lb_mucgiam.AutoSize = true;
            this.lb_mucgiam.Location = new System.Drawing.Point(79, 232);
            this.lb_mucgiam.Name = "lb_mucgiam";
            this.lb_mucgiam.Size = new System.Drawing.Size(61, 15);
            this.lb_mucgiam.TabIndex = 63;
            this.lb_mucgiam.Text = "Mức giảm";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(79, 263);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 15);
            this.label9.TabIndex = 64;
            this.label9.Text = "Mô tả";
            // 
            // tb_mota
            // 
            this.tb_mota.Location = new System.Drawing.Point(177, 263);
            this.tb_mota.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_mota.Name = "tb_mota";
            this.tb_mota.Size = new System.Drawing.Size(216, 23);
            this.tb_mota.TabIndex = 66;
            // 
            // tb_mucgiam
            // 
            this.tb_mucgiam.Location = new System.Drawing.Point(177, 224);
            this.tb_mucgiam.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_mucgiam.Name = "tb_mucgiam";
            this.tb_mucgiam.Size = new System.Drawing.Size(216, 23);
            this.tb_mucgiam.TabIndex = 65;
            this.tb_mucgiam.TextChanged += new System.EventHandler(this.tb_mucgiam_TextChanged);
            this.tb_mucgiam.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_mucgiam_KeyPress);
            // 
            // dtp_start
            // 
            this.dtp_start.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtp_start.Location = new System.Drawing.Point(177, 118);
            this.dtp_start.Name = "dtp_start";
            this.dtp_start.Size = new System.Drawing.Size(216, 23);
            this.dtp_start.TabIndex = 69;
            this.dtp_start.Value = new System.DateTime(2022, 11, 10, 0, 0, 0, 0);
            // 
            // dtp_end
            // 
            this.dtp_end.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtp_end.Location = new System.Drawing.Point(177, 154);
            this.dtp_end.Name = "dtp_end";
            this.dtp_end.Size = new System.Drawing.Size(216, 23);
            this.dtp_end.TabIndex = 70;
            // 
            // cbb_loaiKm
            // 
            this.cbb_loaiKm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_loaiKm.FormattingEnabled = true;
            this.cbb_loaiKm.Location = new System.Drawing.Point(177, 193);
            this.cbb_loaiKm.Name = "cbb_loaiKm";
            this.cbb_loaiKm.Size = new System.Drawing.Size(216, 23);
            this.cbb_loaiKm.TabIndex = 71;
            this.cbb_loaiKm.SelectedIndexChanged += new System.EventHandler(this.cbb_loaiKm_SelectedIndexChanged);
            // 
            // FrmSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(224)))), ((int)(((byte)(225)))));
            this.ClientSize = new System.Drawing.Size(629, 542);
            this.Controls.Add(this.cbb_loaiKm);
            this.Controls.Add(this.dtp_end);
            this.Controls.Add(this.dtp_start);
            this.Controls.Add(this.tb_mota);
            this.Controls.Add(this.tb_mucgiam);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lb_mucgiam);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.bt_xoaform);
            this.Controls.Add(this.rdb_khd);
            this.Controls.Add(this.rdb_hd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_timkiem);
            this.Controls.Add(this.dtg_show);
            this.Controls.Add(this.bt_xoa);
            this.Controls.Add(this.tb_them);
            this.Controls.Add(this.bt_update);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_ten);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_ma);
            this.Name = "FrmSale";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmSale";
            this.Load += new System.EventHandler(this.FrmSale_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_show)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_xoaform;
        private System.Windows.Forms.RadioButton rdb_khd;
        private System.Windows.Forms.RadioButton rdb_hd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_timkiem;
        private System.Windows.Forms.DataGridView dtg_show;
        private System.Windows.Forms.Button bt_xoa;
        private System.Windows.Forms.Button tb_them;
        private System.Windows.Forms.Button bt_update;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_ten;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_ma;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lb_mucgiam;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tb_mota;
        private System.Windows.Forms.TextBox tb_mucgiam;
        private System.Windows.Forms.DateTimePicker dtp_start;
        private System.Windows.Forms.DateTimePicker dtp_end;
        private System.Windows.Forms.ComboBox cbb_loaiKm;
    }
}