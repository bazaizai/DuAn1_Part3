namespace _3.PL.Views
{
    partial class FrmChiTietSale
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_timkiemkm = new System.Windows.Forms.TextBox();
            this.bt_timkm = new System.Windows.Forms.Button();
            this.dtg_show = new System.Windows.Forms.DataGridView();
            this.label13 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.cbb_locSp = new System.Windows.Forms.ComboBox();
            this.tb_timkiemSp = new System.Windows.Forms.TextBox();
            this.cbb_locTrangthai = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btloadlai = new System.Windows.Forms.Button();
            this.dtg_sp = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MauSac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Team = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KieuSp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Selected = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.bt_them2 = new CustomControls.RJControls.RJButton();
            this.ck_all = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tb_trangthai = new CustomControls.RJControls.RJTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bt_them = new CustomControls.RJControls.RJButton();
            this.bt_sua = new CustomControls.RJControls.RJButton();
            this.tb_ma = new CustomControls.RJControls.RJTextBox();
            this.cbb_loaiKM = new CustomControls.RJControls.RJComboBox();
            this.tb_mota = new CustomControls.RJControls.RJTextBox();
            this.tb_mucgiam = new CustomControls.RJControls.RJTextBox();
            this.tb_ten = new CustomControls.RJControls.RJTextBox();
            this.dtp_start = new System.Windows.Forms.DateTimePicker();
            this.dtp_end = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.lb_mucgiam = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_show)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_sp)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(53, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Tìm khuyến mại";
            // 
            // tb_timkiemkm
            // 
            this.tb_timkiemkm.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_timkiemkm.Location = new System.Drawing.Point(53, 33);
            this.tb_timkiemkm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_timkiemkm.Name = "tb_timkiemkm";
            this.tb_timkiemkm.Size = new System.Drawing.Size(388, 34);
            this.tb_timkiemkm.TabIndex = 1;
            this.tb_timkiemkm.TextChanged += new System.EventHandler(this.tb_timkiemkm_TextChanged_1);
            // 
            // bt_timkm
            // 
            this.bt_timkm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(122)))), ((int)(((byte)(83)))));
            this.bt_timkm.FlatAppearance.BorderSize = 2;
            this.bt_timkm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_timkm.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bt_timkm.ForeColor = System.Drawing.Color.White;
            this.bt_timkm.Location = new System.Drawing.Point(447, 30);
            this.bt_timkm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bt_timkm.Name = "bt_timkm";
            this.bt_timkm.Size = new System.Drawing.Size(68, 39);
            this.bt_timkm.TabIndex = 3;
            this.bt_timkm.Text = "Tìm";
            this.bt_timkm.UseVisualStyleBackColor = false;
            // 
            // dtg_show
            // 
            this.dtg_show.AllowUserToAddRows = false;
            this.dtg_show.AllowUserToDeleteRows = false;
            this.dtg_show.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg_show.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(36)))));
            this.dtg_show.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtg_show.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_show.GridColor = System.Drawing.Color.Black;
            this.dtg_show.Location = new System.Drawing.Point(53, 79);
            this.dtg_show.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtg_show.Name = "dtg_show";
            this.dtg_show.ReadOnly = true;
            this.dtg_show.RowHeadersVisible = false;
            this.dtg_show.RowHeadersWidth = 62;
            this.dtg_show.RowTemplate.Height = 25;
            this.dtg_show.Size = new System.Drawing.Size(849, 269);
            this.dtg_show.TabIndex = 7;
            this.dtg_show.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_show_CellClick);
            this.dtg_show.Click += new System.EventHandler(this.dtg_show_CellClick);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label13.ForeColor = System.Drawing.Color.Transparent;
            this.label13.Location = new System.Drawing.Point(521, 359);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(32, 20);
            this.label13.TabIndex = 13;
            this.label13.Text = "Lọc";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(122)))), ((int)(((byte)(83)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(447, 387);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(68, 39);
            this.button1.TabIndex = 11;
            this.button1.Text = "Tìm";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // cbb_locSp
            // 
            this.cbb_locSp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_locSp.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbb_locSp.FormattingEnabled = true;
            this.cbb_locSp.Location = new System.Drawing.Point(521, 389);
            this.cbb_locSp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbb_locSp.Name = "cbb_locSp";
            this.cbb_locSp.Size = new System.Drawing.Size(283, 36);
            this.cbb_locSp.TabIndex = 10;
            this.cbb_locSp.SelectedIndexChanged += new System.EventHandler(this.cbb_locSp_SelectedIndexChanged);
            // 
            // tb_timkiemSp
            // 
            this.tb_timkiemSp.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_timkiemSp.Location = new System.Drawing.Point(53, 389);
            this.tb_timkiemSp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_timkiemSp.Name = "tb_timkiemSp";
            this.tb_timkiemSp.Size = new System.Drawing.Size(388, 34);
            this.tb_timkiemSp.TabIndex = 9;
            this.tb_timkiemSp.TextChanged += new System.EventHandler(this.tb_timkiemSp_TextChanged);
            // 
            // cbb_locTrangthai
            // 
            this.cbb_locTrangthai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_locTrangthai.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbb_locTrangthai.FormattingEnabled = true;
            this.cbb_locTrangthai.Location = new System.Drawing.Point(521, 30);
            this.cbb_locTrangthai.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbb_locTrangthai.Name = "cbb_locTrangthai";
            this.cbb_locTrangthai.Size = new System.Drawing.Size(283, 36);
            this.cbb_locTrangthai.TabIndex = 4;
            this.cbb_locTrangthai.SelectedIndexChanged += new System.EventHandler(this.cbb_locTrangthai_SelectedIndexChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label14.ForeColor = System.Drawing.Color.Transparent;
            this.label14.Location = new System.Drawing.Point(53, 359);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(104, 20);
            this.label14.TabIndex = 8;
            this.label14.Text = "Tìm sản phẩm";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.Color.Transparent;
            this.label11.Location = new System.Drawing.Point(521, 6);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 20);
            this.label11.TabIndex = 6;
            this.label11.Text = "Trạng thái";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(36)))));
            this.panel2.Controls.Add(this.btloadlai);
            this.panel2.Controls.Add(this.dtg_sp);
            this.panel2.Controls.Add(this.bt_them2);
            this.panel2.Controls.Add(this.ck_all);
            this.panel2.Controls.Add(this.dtg_show);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.tb_timkiemkm);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.cbb_locSp);
            this.panel2.Controls.Add(this.bt_timkm);
            this.panel2.Controls.Add(this.tb_timkiemSp);
            this.panel2.Controls.Add(this.cbb_locTrangthai);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.ForeColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(669, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1083, 1055);
            this.panel2.TabIndex = 110;
            // 
            // btloadlai
            // 
            this.btloadlai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(122)))), ((int)(((byte)(83)))));
            this.btloadlai.ForeColor = System.Drawing.Color.Transparent;
            this.btloadlai.Location = new System.Drawing.Point(816, 30);
            this.btloadlai.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btloadlai.Name = "btloadlai";
            this.btloadlai.Size = new System.Drawing.Size(86, 34);
            this.btloadlai.TabIndex = 123;
            this.btloadlai.Text = "Load lại data";
            this.btloadlai.UseVisualStyleBackColor = false;
            this.btloadlai.Click += new System.EventHandler(this.btloadlai_Click);
            // 
            // dtg_sp
            // 
            this.dtg_sp.AllowUserToAddRows = false;
            this.dtg_sp.AllowUserToDeleteRows = false;
            this.dtg_sp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg_sp.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(36)))));
            this.dtg_sp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtg_sp.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtg_sp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_sp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.TenSanPham,
            this.MauSac,
            this.Team,
            this.KieuSp,
            this.TrangThai,
            this.Selected});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtg_sp.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtg_sp.GridColor = System.Drawing.Color.Black;
            this.dtg_sp.Location = new System.Drawing.Point(53, 434);
            this.dtg_sp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtg_sp.Name = "dtg_sp";
            this.dtg_sp.RowHeadersVisible = false;
            this.dtg_sp.RowHeadersWidth = 51;
            this.dtg_sp.RowTemplate.Height = 25;
            this.dtg_sp.Size = new System.Drawing.Size(849, 351);
            this.dtg_sp.TabIndex = 122;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "Id";
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // TenSanPham
            // 
            this.TenSanPham.DataPropertyName = "TenSanPham";
            this.TenSanPham.HeaderText = "TênSP";
            this.TenSanPham.MinimumWidth = 6;
            this.TenSanPham.Name = "TenSanPham";
            this.TenSanPham.ReadOnly = true;
            // 
            // MauSac
            // 
            this.MauSac.DataPropertyName = "MauSac";
            this.MauSac.HeaderText = "Màu Sắc";
            this.MauSac.MinimumWidth = 6;
            this.MauSac.Name = "MauSac";
            this.MauSac.ReadOnly = true;
            // 
            // Team
            // 
            this.Team.DataPropertyName = "Team";
            this.Team.HeaderText = "Team";
            this.Team.MinimumWidth = 6;
            this.Team.Name = "Team";
            this.Team.ReadOnly = true;
            // 
            // KieuSp
            // 
            this.KieuSp.DataPropertyName = "KieuSP";
            this.KieuSp.HeaderText = "Kiểu SP";
            this.KieuSp.MinimumWidth = 6;
            this.KieuSp.Name = "KieuSp";
            // 
            // TrangThai
            // 
            this.TrangThai.DataPropertyName = "TrangThai";
            this.TrangThai.HeaderText = "Trạng thái";
            this.TrangThai.MinimumWidth = 6;
            this.TrangThai.Name = "TrangThai";
            // 
            // Selected
            // 
            this.Selected.DataPropertyName = "Selected";
            this.Selected.HeaderText = "Selected";
            this.Selected.MinimumWidth = 6;
            this.Selected.Name = "Selected";
            // 
            // bt_them2
            // 
            this.bt_them2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(122)))), ((int)(((byte)(83)))));
            this.bt_them2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(122)))), ((int)(((byte)(83)))));
            this.bt_them2.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bt_them2.BorderRadius = 7;
            this.bt_them2.BorderSize = 0;
            this.bt_them2.FlatAppearance.BorderSize = 0;
            this.bt_them2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_them2.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bt_them2.ForeColor = System.Drawing.Color.White;
            this.bt_them2.Location = new System.Drawing.Point(207, 793);
            this.bt_them2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bt_them2.Name = "bt_them2";
            this.bt_them2.Size = new System.Drawing.Size(537, 71);
            this.bt_them2.TabIndex = 121;
            this.bt_them2.Text = "Áp dụng thay đổi";
            this.bt_them2.TextColor = System.Drawing.Color.White;
            this.bt_them2.UseVisualStyleBackColor = false;
            this.bt_them2.Click += new System.EventHandler(this.bt_them2_Click);
            // 
            // ck_all
            // 
            this.ck_all.AutoSize = true;
            this.ck_all.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ck_all.ForeColor = System.Drawing.Color.Transparent;
            this.ck_all.Location = new System.Drawing.Point(829, 398);
            this.ck_all.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ck_all.Name = "ck_all";
            this.ck_all.Size = new System.Drawing.Size(73, 24);
            this.ck_all.TabIndex = 16;
            this.ck_all.Text = "Tất cả";
            this.ck_all.UseVisualStyleBackColor = true;
            this.ck_all.CheckedChanged += new System.EventHandler(this.ck_all_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(36)))));
            this.panel1.Controls.Add(this.tb_trangthai);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.bt_them);
            this.panel1.Controls.Add(this.bt_sua);
            this.panel1.Controls.Add(this.tb_ma);
            this.panel1.Controls.Add(this.cbb_loaiKM);
            this.panel1.Controls.Add(this.tb_mota);
            this.panel1.Controls.Add(this.tb_mucgiam);
            this.panel1.Controls.Add(this.tb_ten);
            this.panel1.Controls.Add(this.dtp_start);
            this.panel1.Controls.Add(this.dtp_end);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.lb_mucgiam);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(669, 1055);
            this.panel1.TabIndex = 111;
            // 
            // tb_trangthai
            // 
            this.tb_trangthai.BackColor = System.Drawing.Color.White;
            this.tb_trangthai.BorderColor = System.Drawing.Color.White;
            this.tb_trangthai.BorderFocusColor = System.Drawing.Color.HotPink;
            this.tb_trangthai.BorderRadius = 0;
            this.tb_trangthai.BorderSize = 1;
            this.tb_trangthai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_trangthai.ForeColor = System.Drawing.Color.Black;
            this.tb_trangthai.Location = new System.Drawing.Point(306, 665);
            this.tb_trangthai.Margin = new System.Windows.Forms.Padding(5);
            this.tb_trangthai.Multiline = false;
            this.tb_trangthai.Name = "tb_trangthai";
            this.tb_trangthai.Padding = new System.Windows.Forms.Padding(11, 9, 11, 9);
            this.tb_trangthai.PasswordChar = false;
            this.tb_trangthai.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tb_trangthai.PlaceholderText = "";
            this.tb_trangthai.Size = new System.Drawing.Size(279, 39);
            this.tb_trangthai.TabIndex = 121;
            this.tb_trangthai.Texts = "";
            this.tb_trangthai.UnderlinedStyle = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.ForeColor = System.Drawing.Color.Transparent;
            this.label12.Location = new System.Drawing.Point(49, 35);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(0, 32);
            this.label12.TabIndex = 120;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Elephant", 47.99999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(223, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(227, 103);
            this.label4.TabIndex = 119;
            this.label4.Text = "Sale";
            // 
            // bt_them
            // 
            this.bt_them.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(122)))), ((int)(((byte)(83)))));
            this.bt_them.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(122)))), ((int)(((byte)(83)))));
            this.bt_them.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bt_them.BorderRadius = 7;
            this.bt_them.BorderSize = 0;
            this.bt_them.FlatAppearance.BorderSize = 0;
            this.bt_them.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_them.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bt_them.ForeColor = System.Drawing.Color.White;
            this.bt_them.Location = new System.Drawing.Point(84, 785);
            this.bt_them.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bt_them.Name = "bt_them";
            this.bt_them.Size = new System.Drawing.Size(171, 79);
            this.bt_them.TabIndex = 118;
            this.bt_them.Text = "Thêm";
            this.bt_them.TextColor = System.Drawing.Color.White;
            this.bt_them.UseVisualStyleBackColor = false;
            this.bt_them.Click += new System.EventHandler(this.bt_them_Click);
            // 
            // bt_sua
            // 
            this.bt_sua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(122)))), ((int)(((byte)(83)))));
            this.bt_sua.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(122)))), ((int)(((byte)(83)))));
            this.bt_sua.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bt_sua.BorderRadius = 7;
            this.bt_sua.BorderSize = 0;
            this.bt_sua.FlatAppearance.BorderSize = 0;
            this.bt_sua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_sua.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bt_sua.ForeColor = System.Drawing.Color.White;
            this.bt_sua.Location = new System.Drawing.Point(413, 785);
            this.bt_sua.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bt_sua.Name = "bt_sua";
            this.bt_sua.Size = new System.Drawing.Size(171, 79);
            this.bt_sua.TabIndex = 117;
            this.bt_sua.Text = "Sửa";
            this.bt_sua.TextColor = System.Drawing.Color.White;
            this.bt_sua.UseVisualStyleBackColor = false;
            this.bt_sua.Click += new System.EventHandler(this.bt_sua_Click);
            // 
            // tb_ma
            // 
            this.tb_ma.BackColor = System.Drawing.Color.White;
            this.tb_ma.BorderColor = System.Drawing.Color.White;
            this.tb_ma.BorderFocusColor = System.Drawing.Color.HotPink;
            this.tb_ma.BorderRadius = 0;
            this.tb_ma.BorderSize = 1;
            this.tb_ma.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_ma.ForeColor = System.Drawing.Color.Black;
            this.tb_ma.Location = new System.Drawing.Point(306, 191);
            this.tb_ma.Margin = new System.Windows.Forms.Padding(5);
            this.tb_ma.Multiline = false;
            this.tb_ma.Name = "tb_ma";
            this.tb_ma.Padding = new System.Windows.Forms.Padding(11, 9, 11, 9);
            this.tb_ma.PasswordChar = false;
            this.tb_ma.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tb_ma.PlaceholderText = "";
            this.tb_ma.Size = new System.Drawing.Size(279, 39);
            this.tb_ma.TabIndex = 111;
            this.tb_ma.Texts = "";
            this.tb_ma.UnderlinedStyle = false;
            // 
            // cbb_loaiKM
            // 
            this.cbb_loaiKM.BackColor = System.Drawing.Color.White;
            this.cbb_loaiKM.BorderColor = System.Drawing.Color.White;
            this.cbb_loaiKM.BorderSize = 1;
            this.cbb_loaiKM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_loaiKM.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbb_loaiKM.ForeColor = System.Drawing.Color.Black;
            this.cbb_loaiKM.IconColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cbb_loaiKM.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cbb_loaiKM.ListTextColor = System.Drawing.Color.DimGray;
            this.cbb_loaiKM.Location = new System.Drawing.Point(306, 331);
            this.cbb_loaiKM.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbb_loaiKM.MinimumSize = new System.Drawing.Size(229, 40);
            this.cbb_loaiKM.Name = "cbb_loaiKM";
            this.cbb_loaiKM.Padding = new System.Windows.Forms.Padding(1);
            this.cbb_loaiKM.Size = new System.Drawing.Size(279, 49);
            this.cbb_loaiKM.TabIndex = 115;
            this.cbb_loaiKM.Texts = "";
            this.cbb_loaiKM.OnSelectedIndexChanged += new System.EventHandler(this.cbb_loaiKM_OnSelectedIndexChanged);
            // 
            // tb_mota
            // 
            this.tb_mota.BackColor = System.Drawing.Color.White;
            this.tb_mota.BorderColor = System.Drawing.Color.White;
            this.tb_mota.BorderFocusColor = System.Drawing.Color.HotPink;
            this.tb_mota.BorderRadius = 0;
            this.tb_mota.BorderSize = 1;
            this.tb_mota.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_mota.ForeColor = System.Drawing.Color.Black;
            this.tb_mota.Location = new System.Drawing.Point(306, 609);
            this.tb_mota.Margin = new System.Windows.Forms.Padding(5);
            this.tb_mota.Multiline = false;
            this.tb_mota.Name = "tb_mota";
            this.tb_mota.Padding = new System.Windows.Forms.Padding(11, 9, 11, 9);
            this.tb_mota.PasswordChar = false;
            this.tb_mota.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tb_mota.PlaceholderText = "";
            this.tb_mota.Size = new System.Drawing.Size(279, 39);
            this.tb_mota.TabIndex = 114;
            this.tb_mota.Texts = "";
            this.tb_mota.UnderlinedStyle = false;
            // 
            // tb_mucgiam
            // 
            this.tb_mucgiam.BackColor = System.Drawing.Color.White;
            this.tb_mucgiam.BorderColor = System.Drawing.Color.White;
            this.tb_mucgiam.BorderFocusColor = System.Drawing.Color.HotPink;
            this.tb_mucgiam.BorderRadius = 0;
            this.tb_mucgiam.BorderSize = 1;
            this.tb_mucgiam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_mucgiam.ForeColor = System.Drawing.Color.Black;
            this.tb_mucgiam.Location = new System.Drawing.Point(306, 409);
            this.tb_mucgiam.Margin = new System.Windows.Forms.Padding(5);
            this.tb_mucgiam.Multiline = false;
            this.tb_mucgiam.Name = "tb_mucgiam";
            this.tb_mucgiam.Padding = new System.Windows.Forms.Padding(11, 9, 11, 9);
            this.tb_mucgiam.PasswordChar = false;
            this.tb_mucgiam.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tb_mucgiam.PlaceholderText = "";
            this.tb_mucgiam.Size = new System.Drawing.Size(279, 39);
            this.tb_mucgiam.TabIndex = 113;
            this.tb_mucgiam.Texts = "";
            this.tb_mucgiam.UnderlinedStyle = false;
            this.tb_mucgiam._TextChanged += new System.EventHandler(this.tb_mucgiam__TextChanged);
            this.tb_mucgiam.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_mucgiam_KeyPress);
            // 
            // tb_ten
            // 
            this.tb_ten.BackColor = System.Drawing.Color.White;
            this.tb_ten.BorderColor = System.Drawing.Color.White;
            this.tb_ten.BorderFocusColor = System.Drawing.Color.HotPink;
            this.tb_ten.BorderRadius = 0;
            this.tb_ten.BorderSize = 1;
            this.tb_ten.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_ten.ForeColor = System.Drawing.Color.Black;
            this.tb_ten.Location = new System.Drawing.Point(306, 251);
            this.tb_ten.Margin = new System.Windows.Forms.Padding(5);
            this.tb_ten.Multiline = false;
            this.tb_ten.Name = "tb_ten";
            this.tb_ten.Padding = new System.Windows.Forms.Padding(11, 9, 11, 9);
            this.tb_ten.PasswordChar = false;
            this.tb_ten.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tb_ten.PlaceholderText = "";
            this.tb_ten.Size = new System.Drawing.Size(279, 39);
            this.tb_ten.TabIndex = 112;
            this.tb_ten.Texts = "";
            this.tb_ten.UnderlinedStyle = false;
            // 
            // dtp_start
            // 
            this.dtp_start.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(36)))));
            this.dtp_start.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(36)))));
            this.dtp_start.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(36)))));
            this.dtp_start.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_start.Location = new System.Drawing.Point(306, 475);
            this.dtp_start.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtp_start.Name = "dtp_start";
            this.dtp_start.Size = new System.Drawing.Size(278, 27);
            this.dtp_start.TabIndex = 109;
            this.dtp_start.Value = new System.DateTime(2022, 11, 18, 0, 0, 0, 0);
            this.dtp_start.ValueChanged += new System.EventHandler(this.dtp_start_ValueChanged);
            // 
            // dtp_end
            // 
            this.dtp_end.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(36)))));
            this.dtp_end.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(36)))));
            this.dtp_end.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(36)))));
            this.dtp_end.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_end.Location = new System.Drawing.Point(306, 545);
            this.dtp_end.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtp_end.Name = "dtp_end";
            this.dtp_end.Size = new System.Drawing.Size(278, 27);
            this.dtp_end.TabIndex = 110;
            this.dtp_end.ValueChanged += new System.EventHandler(this.dtp_end_ValueChanged);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(101, 331);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(199, 32);
            this.label7.TabIndex = 88;
            this.label7.Text = "Loại khuyến mại:";
            // 
            // lb_mucgiam
            // 
            this.lb_mucgiam.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_mucgiam.AutoSize = true;
            this.lb_mucgiam.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_mucgiam.ForeColor = System.Drawing.Color.White;
            this.lb_mucgiam.Location = new System.Drawing.Point(101, 409);
            this.lb_mucgiam.Name = "lb_mucgiam";
            this.lb_mucgiam.Size = new System.Drawing.Size(129, 32);
            this.lb_mucgiam.TabIndex = 89;
            this.lb_mucgiam.Text = "Mức giảm:";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(101, 542);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(174, 32);
            this.label6.TabIndex = 87;
            this.label6.Text = "Ngày kết thúc:";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(101, 609);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 32);
            this.label9.TabIndex = 90;
            this.label9.Text = "Mô tả:";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(101, 475);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(169, 32);
            this.label5.TabIndex = 86;
            this.label5.Text = "Ngày bắt đầu:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(101, 673);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 32);
            this.label3.TabIndex = 76;
            this.label3.Text = "Trạng thái:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(101, 259);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 32);
            this.label2.TabIndex = 75;
            this.label2.Text = "Tên khuyến mại:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(101, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 32);
            this.label1.TabIndex = 73;
            this.label1.Text = "Mã khuyến mại:";
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // FrmChiTietSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1752, 1055);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmChiTietSale";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmChiTietSale";
            this.Load += new System.EventHandler(this.FrmChiTietSale_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_show)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_sp)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_timkiemkm;
        private System.Windows.Forms.Button bt_timkm;
        private System.Windows.Forms.DataGridView dtg_show;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbb_locSp;
        private System.Windows.Forms.TextBox tb_timkiemSp;
        private System.Windows.Forms.ComboBox cbb_locTrangthai;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox ck_all;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private CustomControls.RJControls.RJButton bt_them;
        private CustomControls.RJControls.RJButton bt_sua;
        private CustomControls.RJControls.RJTextBox tb_ma;
        private CustomControls.RJControls.RJComboBox cbb_loaiKM;
        private CustomControls.RJControls.RJTextBox tb_mota;
        private CustomControls.RJControls.RJTextBox tb_mucgiam;
        private CustomControls.RJControls.RJTextBox tb_ten;
        private System.Windows.Forms.DateTimePicker dtp_start;
        private System.Windows.Forms.DateTimePicker dtp_end;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lb_mucgiam;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private CustomControls.RJControls.RJButton bt_them2;
        private System.Windows.Forms.DataGridView dtg_sp;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btloadlai;
        private CustomControls.RJControls.RJTextBox tb_trangthai;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn MauSac;
        private System.Windows.Forms.DataGridViewTextBoxColumn Team;
        private System.Windows.Forms.DataGridViewTextBoxColumn KieuSp;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrangThai;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Selected;
    }
}