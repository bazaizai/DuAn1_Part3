namespace _3.PL.Views
{
    partial class FrmNhanVien
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
            this.dtgv_show = new System.Windows.Forms.DataGridView();
            this.cbb_chucvu = new System.Windows.Forms.ComboBox();
            this.cbb_gioitinh = new System.Windows.Forms.ComboBox();
            this.dtp_ngaysinh = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.tb_sdt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_diachi = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_ho = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_tendem = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_matkhau = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_ten = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_ma = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.rdb_khonghd = new System.Windows.Forms.RadioButton();
            this.rdb_hoatdong = new System.Windows.Forms.RadioButton();
            this.tb_cccd = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tb_taikhoan = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.tb_timkiem = new System.Windows.Forms.TextBox();
            this.cbb_loc = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_show)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgv_show
            // 
            this.dtgv_show.AllowUserToAddRows = false;
            this.dtgv_show.AllowUserToDeleteRows = false;
            this.dtgv_show.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgv_show.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(232)))), ((int)(((byte)(229)))));
            this.dtgv_show.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgv_show.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_show.Location = new System.Drawing.Point(26, 315);
            this.dtgv_show.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgv_show.Name = "dtgv_show";
            this.dtgv_show.ReadOnly = true;
            this.dtgv_show.RowHeadersWidth = 51;
            this.dtgv_show.RowTemplate.Height = 29;
            this.dtgv_show.Size = new System.Drawing.Size(743, 232);
            this.dtgv_show.TabIndex = 1;
            this.dtgv_show.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_show_CellClick);
            // 
            // cbb_chucvu
            // 
            this.cbb_chucvu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_chucvu.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cbb_chucvu.FormattingEnabled = true;
            this.cbb_chucvu.Location = new System.Drawing.Point(100, 59);
            this.cbb_chucvu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbb_chucvu.Name = "cbb_chucvu";
            this.cbb_chucvu.Size = new System.Drawing.Size(159, 28);
            this.cbb_chucvu.TabIndex = 56;
            // 
            // cbb_gioitinh
            // 
            this.cbb_gioitinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_gioitinh.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cbb_gioitinh.FormattingEnabled = true;
            this.cbb_gioitinh.Location = new System.Drawing.Point(100, 192);
            this.cbb_gioitinh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbb_gioitinh.Name = "cbb_gioitinh";
            this.cbb_gioitinh.Size = new System.Drawing.Size(159, 28);
            this.cbb_gioitinh.TabIndex = 55;
            // 
            // dtp_ngaysinh
            // 
            this.dtp_ngaysinh.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dtp_ngaysinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_ngaysinh.Location = new System.Drawing.Point(100, 229);
            this.dtp_ngaysinh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtp_ngaysinh.Name = "dtp_ngaysinh";
            this.dtp_ngaysinh.Size = new System.Drawing.Size(159, 27);
            this.dtp_ngaysinh.TabIndex = 54;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(30, 62);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 20);
            this.label12.TabIndex = 52;
            this.label12.Text = "Chức vụ";
            // 
            // tb_sdt
            // 
            this.tb_sdt.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tb_sdt.Location = new System.Drawing.Point(393, 59);
            this.tb_sdt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_sdt.Name = "tb_sdt";
            this.tb_sdt.Size = new System.Drawing.Size(206, 27);
            this.tb_sdt.TabIndex = 50;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(338, 62);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 20);
            this.label9.TabIndex = 49;
            this.label9.Text = "SĐT";
            // 
            // tb_diachi
            // 
            this.tb_diachi.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tb_diachi.Location = new System.Drawing.Point(393, 25);
            this.tb_diachi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_diachi.Name = "tb_diachi";
            this.tb_diachi.Size = new System.Drawing.Size(206, 27);
            this.tb_diachi.TabIndex = 48;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(318, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 20);
            this.label8.TabIndex = 47;
            this.label8.Text = "Địa chỉ";
            // 
            // tb_ho
            // 
            this.tb_ho.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tb_ho.Location = new System.Drawing.Point(100, 159);
            this.tb_ho.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_ho.Name = "tb_ho";
            this.tb_ho.Size = new System.Drawing.Size(159, 27);
            this.tb_ho.TabIndex = 46;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(65, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 20);
            this.label5.TabIndex = 45;
            this.label5.Text = "Họ";
            // 
            // tb_tendem
            // 
            this.tb_tendem.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tb_tendem.Location = new System.Drawing.Point(100, 128);
            this.tb_tendem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_tendem.Name = "tb_tendem";
            this.tb_tendem.Size = new System.Drawing.Size(159, 27);
            this.tb_tendem.TabIndex = 44;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(27, 131);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 20);
            this.label7.TabIndex = 43;
            this.label7.Text = "Tên đệm";
            // 
            // tb_matkhau
            // 
            this.tb_matkhau.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tb_matkhau.Location = new System.Drawing.Point(393, 128);
            this.tb_matkhau.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_matkhau.Name = "tb_matkhau";
            this.tb_matkhau.Size = new System.Drawing.Size(206, 27);
            this.tb_matkhau.TabIndex = 42;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(300, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 20);
            this.label6.TabIndex = 41;
            this.label6.Text = "Mật khẩu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(16, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 40;
            this.label3.Text = "Ngày sinh";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(27, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 20);
            this.label4.TabIndex = 39;
            this.label4.Text = "Giới tính";
            // 
            // tb_ten
            // 
            this.tb_ten.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tb_ten.Location = new System.Drawing.Point(100, 97);
            this.tb_ten.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_ten.Name = "tb_ten";
            this.tb_ten.Size = new System.Drawing.Size(159, 27);
            this.tb_ten.TabIndex = 38;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(61, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 20);
            this.label2.TabIndex = 37;
            this.label2.Text = "Tên";
            // 
            // tb_ma
            // 
            this.tb_ma.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tb_ma.Location = new System.Drawing.Point(100, 25);
            this.tb_ma.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_ma.Name = "tb_ma";
            this.tb_ma.Size = new System.Drawing.Size(159, 27);
            this.tb_ma.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(63, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 20);
            this.label1.TabIndex = 35;
            this.label1.Text = "Mã";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(296, 234);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 20);
            this.label10.TabIndex = 60;
            this.label10.Text = "Trạng thái";
            // 
            // rdb_khonghd
            // 
            this.rdb_khonghd.AutoSize = true;
            this.rdb_khonghd.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rdb_khonghd.ForeColor = System.Drawing.Color.Black;
            this.rdb_khonghd.Location = new System.Drawing.Point(510, 234);
            this.rdb_khonghd.Name = "rdb_khonghd";
            this.rdb_khonghd.Size = new System.Drawing.Size(147, 24);
            this.rdb_khonghd.TabIndex = 59;
            this.rdb_khonghd.TabStop = true;
            this.rdb_khonghd.Text = "Không hoạt động";
            this.rdb_khonghd.UseVisualStyleBackColor = true;
            // 
            // rdb_hoatdong
            // 
            this.rdb_hoatdong.AutoSize = true;
            this.rdb_hoatdong.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rdb_hoatdong.ForeColor = System.Drawing.Color.Black;
            this.rdb_hoatdong.Location = new System.Drawing.Point(393, 234);
            this.rdb_hoatdong.Name = "rdb_hoatdong";
            this.rdb_hoatdong.Size = new System.Drawing.Size(100, 24);
            this.rdb_hoatdong.TabIndex = 58;
            this.rdb_hoatdong.TabStop = true;
            this.rdb_hoatdong.Text = "Hoạt động";
            this.rdb_hoatdong.UseVisualStyleBackColor = true;
            // 
            // tb_cccd
            // 
            this.tb_cccd.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tb_cccd.Location = new System.Drawing.Point(393, 97);
            this.tb_cccd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_cccd.Name = "tb_cccd";
            this.tb_cccd.Size = new System.Drawing.Size(206, 27);
            this.tb_cccd.TabIndex = 62;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(327, 100);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 20);
            this.label11.TabIndex = 61;
            this.label11.Text = "CCCD";
            // 
            // tb_email
            // 
            this.tb_email.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tb_email.Location = new System.Drawing.Point(393, 159);
            this.tb_email.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(206, 27);
            this.tb_email.TabIndex = 64;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(328, 162);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(46, 20);
            this.label13.TabIndex = 63;
            this.label13.Text = "Email";
            // 
            // tb_taikhoan
            // 
            this.tb_taikhoan.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tb_taikhoan.Location = new System.Drawing.Point(393, 193);
            this.tb_taikhoan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_taikhoan.Name = "tb_taikhoan";
            this.tb_taikhoan.Size = new System.Drawing.Size(206, 27);
            this.tb_taikhoan.TabIndex = 66;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(299, 195);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(75, 20);
            this.label14.TabIndex = 65;
            this.label14.Text = "Tài khoản";
            // 
            // btn_them
            // 
            this.btn_them.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(143)))), ((int)(((byte)(157)))));
            this.btn_them.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_them.ForeColor = System.Drawing.Color.White;
            this.btn_them.Location = new System.Drawing.Point(671, 25);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(98, 37);
            this.btn_them.TabIndex = 67;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = false;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(143)))), ((int)(((byte)(157)))));
            this.btn_sua.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_sua.ForeColor = System.Drawing.Color.White;
            this.btn_sua.Location = new System.Drawing.Point(671, 71);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(98, 37);
            this.btn_sua.TabIndex = 68;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = false;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(143)))), ((int)(((byte)(157)))));
            this.btn_xoa.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_xoa.ForeColor = System.Drawing.Color.White;
            this.btn_xoa.Location = new System.Drawing.Point(671, 123);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(98, 37);
            this.btn_xoa.TabIndex = 69;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = false;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(143)))), ((int)(((byte)(157)))));
            this.btn_clear.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_clear.ForeColor = System.Drawing.Color.White;
            this.btn_clear.Location = new System.Drawing.Point(671, 175);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(98, 37);
            this.btn_clear.TabIndex = 70;
            this.btn_clear.Text = "Xóa form";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(23, 286);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(71, 20);
            this.label15.TabIndex = 72;
            this.label15.Text = "Tìm kiếm";
            // 
            // tb_timkiem
            // 
            this.tb_timkiem.BackColor = System.Drawing.SystemColors.Window;
            this.tb_timkiem.Location = new System.Drawing.Point(100, 278);
            this.tb_timkiem.Margin = new System.Windows.Forms.Padding(2);
            this.tb_timkiem.Multiline = true;
            this.tb_timkiem.Name = "tb_timkiem";
            this.tb_timkiem.Size = new System.Drawing.Size(274, 28);
            this.tb_timkiem.TabIndex = 71;
            this.tb_timkiem.TextChanged += new System.EventHandler(this.tb_timkiem_TextChanged);
            // 
            // cbb_loc
            // 
            this.cbb_loc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_loc.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cbb_loc.FormattingEnabled = true;
            this.cbb_loc.Location = new System.Drawing.Point(431, 278);
            this.cbb_loc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbb_loc.Name = "cbb_loc";
            this.cbb_loc.Size = new System.Drawing.Size(106, 28);
            this.cbb_loc.TabIndex = 73;
            this.cbb_loc.SelectedIndexChanged += new System.EventHandler(this.cbb_loc_SelectedIndexChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(393, 281);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(32, 20);
            this.label16.TabIndex = 74;
            this.label16.Text = "Lọc";
            // 
            // FrmNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(232)))), ((int)(((byte)(229)))));
            this.ClientSize = new System.Drawing.Size(892, 588);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.cbb_loc);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.tb_timkiem);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.tb_taikhoan);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.tb_email);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.tb_cccd);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.rdb_khonghd);
            this.Controls.Add(this.rdb_hoatdong);
            this.Controls.Add(this.cbb_chucvu);
            this.Controls.Add(this.cbb_gioitinh);
            this.Controls.Add(this.dtp_ngaysinh);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.tb_sdt);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tb_diachi);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tb_ho);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_tendem);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tb_matkhau);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_ten);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_ma);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgv_show);
            this.Name = "FrmNhanVien";
            this.Text = "FrmNhanVien";
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_show)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgv_show;
        private System.Windows.Forms.ComboBox cbb_chucvu;
        private System.Windows.Forms.ComboBox cbb_gioitinh;
        private System.Windows.Forms.DateTimePicker dtp_ngaysinh;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tb_sdt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tb_diachi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_ho;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_tendem;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_matkhau;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_ten;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_ma;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RadioButton rdb_khonghd;
        private System.Windows.Forms.RadioButton rdb_hoatdong;
        private System.Windows.Forms.TextBox tb_cccd;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tb_taikhoan;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tb_timkiem;
        private System.Windows.Forms.ComboBox cbb_loc;
        private System.Windows.Forms.Label label16;
    }
}