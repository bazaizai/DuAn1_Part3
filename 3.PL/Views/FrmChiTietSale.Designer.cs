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
            this.dtp_end = new System.Windows.Forms.DateTimePicker();
            this.dtp_start = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.lb_mucgiam = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_sua = new CustomControls.RJControls.RJButton();
            this.bt_them = new CustomControls.RJControls.RJButton();
            this.cbb_trangthai = new CustomControls.RJControls.RJComboBox();
            this.cbb_loaiKM = new CustomControls.RJControls.RJComboBox();
            this.tb_mota = new CustomControls.RJControls.RJTextBox();
            this.tb_mucgiam = new CustomControls.RJControls.RJTextBox();
            this.tb_ten = new CustomControls.RJControls.RJTextBox();
            this.tb_ma = new CustomControls.RJControls.RJTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ck_all = new System.Windows.Forms.CheckBox();
            this.dtg_sp = new System.Windows.Forms.DataGridView();
            this.label13 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.dtg_show = new System.Windows.Forms.DataGridView();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cbb_locTrangthai = new System.Windows.Forms.ComboBox();
            this.bt_timkm = new System.Windows.Forms.Button();
            this.cbb_locKM = new System.Windows.Forms.ComboBox();
            this.tb_timkiemkm = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_sp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_show)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtp_end
            // 
            this.dtp_end.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtp_end.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_end.Location = new System.Drawing.Point(360, 628);
            this.dtp_end.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtp_end.Name = "dtp_end";
            this.dtp_end.Size = new System.Drawing.Size(338, 31);
            this.dtp_end.TabIndex = 94;
            // 
            // dtp_start
            // 
            this.dtp_start.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtp_start.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_start.Location = new System.Drawing.Point(360, 542);
            this.dtp_start.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtp_start.Name = "dtp_start";
            this.dtp_start.Size = new System.Drawing.Size(338, 31);
            this.dtp_start.TabIndex = 93;
            this.dtp_start.Value = new System.DateTime(2022, 11, 18, 0, 0, 0, 0);
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(127, 708);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 40);
            this.label9.TabIndex = 90;
            this.label9.Text = "Mô tả:";
            // 
            // lb_mucgiam
            // 
            this.lb_mucgiam.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_mucgiam.AutoSize = true;
            this.lb_mucgiam.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_mucgiam.Location = new System.Drawing.Point(127, 458);
            this.lb_mucgiam.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_mucgiam.Name = "lb_mucgiam";
            this.lb_mucgiam.Size = new System.Drawing.Size(157, 40);
            this.lb_mucgiam.TabIndex = 89;
            this.lb_mucgiam.Text = "Mức giảm:";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(127, 370);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(239, 40);
            this.label7.TabIndex = 88;
            this.label7.Text = "Loại khuyến mại:";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(127, 625);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(207, 40);
            this.label6.TabIndex = 87;
            this.label6.Text = "Ngày kết thúc:";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(127, 542);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(201, 40);
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
            this.label3.Location = new System.Drawing.Point(127, 788);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 40);
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
            this.label2.Location = new System.Drawing.Point(127, 272);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(230, 40);
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
            this.label1.Location = new System.Drawing.Point(127, 187);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 40);
            this.label1.TabIndex = 73;
            this.label1.Text = "Mã khuyến mại:";
            // 
            // bt_sua
            // 
            this.bt_sua.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_sua.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.bt_sua.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.bt_sua.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bt_sua.BorderRadius = 7;
            this.bt_sua.BorderSize = 0;
            this.bt_sua.FlatAppearance.BorderSize = 0;
            this.bt_sua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_sua.ForeColor = System.Drawing.Color.White;
            this.bt_sua.Location = new System.Drawing.Point(490, 887);
            this.bt_sua.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bt_sua.Name = "bt_sua";
            this.bt_sua.Size = new System.Drawing.Size(214, 57);
            this.bt_sua.TabIndex = 108;
            this.bt_sua.Text = "Sửa";
            this.bt_sua.TextColor = System.Drawing.Color.White;
            this.bt_sua.UseVisualStyleBackColor = false;
            this.bt_sua.Click += new System.EventHandler(this.bt_sua_Click);
            // 
            // bt_them
            // 
            this.bt_them.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_them.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.bt_them.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.bt_them.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bt_them.BorderRadius = 7;
            this.bt_them.BorderSize = 0;
            this.bt_them.FlatAppearance.BorderSize = 0;
            this.bt_them.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_them.ForeColor = System.Drawing.Color.White;
            this.bt_them.Location = new System.Drawing.Point(147, 887);
            this.bt_them.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bt_them.Name = "bt_them";
            this.bt_them.Size = new System.Drawing.Size(214, 57);
            this.bt_them.TabIndex = 107;
            this.bt_them.Text = "Thêm";
            this.bt_them.TextColor = System.Drawing.Color.White;
            this.bt_them.UseVisualStyleBackColor = false;
            this.bt_them.Click += new System.EventHandler(this.bt_them_Click);
            // 
            // cbb_trangthai
            // 
            this.cbb_trangthai.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbb_trangthai.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbb_trangthai.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.cbb_trangthai.BorderSize = 1;
            this.cbb_trangthai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbb_trangthai.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbb_trangthai.ForeColor = System.Drawing.Color.Black;
            this.cbb_trangthai.IconColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cbb_trangthai.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cbb_trangthai.ListTextColor = System.Drawing.Color.DimGray;
            this.cbb_trangthai.Location = new System.Drawing.Point(360, 788);
            this.cbb_trangthai.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbb_trangthai.MinimumSize = new System.Drawing.Size(286, 50);
            this.cbb_trangthai.Name = "cbb_trangthai";
            this.cbb_trangthai.Padding = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.cbb_trangthai.Size = new System.Drawing.Size(344, 50);
            this.cbb_trangthai.TabIndex = 106;
            this.cbb_trangthai.Texts = "";
            // 
            // cbb_loaiKM
            // 
            this.cbb_loaiKM.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbb_loaiKM.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbb_loaiKM.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.cbb_loaiKM.BorderSize = 1;
            this.cbb_loaiKM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbb_loaiKM.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbb_loaiKM.ForeColor = System.Drawing.Color.Black;
            this.cbb_loaiKM.IconColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cbb_loaiKM.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cbb_loaiKM.ListTextColor = System.Drawing.Color.DimGray;
            this.cbb_loaiKM.Location = new System.Drawing.Point(360, 362);
            this.cbb_loaiKM.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbb_loaiKM.MinimumSize = new System.Drawing.Size(286, 50);
            this.cbb_loaiKM.Name = "cbb_loaiKM";
            this.cbb_loaiKM.Padding = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.cbb_loaiKM.Size = new System.Drawing.Size(344, 50);
            this.cbb_loaiKM.TabIndex = 105;
            this.cbb_loaiKM.Texts = "";
            this.cbb_loaiKM.OnSelectedIndexChanged += new System.EventHandler(this.cbb_loaiKM_OnSelectedIndexChanged);
            // 
            // tb_mota
            // 
            this.tb_mota.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_mota.BackColor = System.Drawing.SystemColors.Window;
            this.tb_mota.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.tb_mota.BorderFocusColor = System.Drawing.Color.HotPink;
            this.tb_mota.BorderRadius = 0;
            this.tb_mota.BorderSize = 1;
            this.tb_mota.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_mota.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tb_mota.Location = new System.Drawing.Point(360, 708);
            this.tb_mota.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.tb_mota.Multiline = false;
            this.tb_mota.Name = "tb_mota";
            this.tb_mota.Padding = new System.Windows.Forms.Padding(14, 12, 14, 12);
            this.tb_mota.PasswordChar = false;
            this.tb_mota.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tb_mota.PlaceholderText = "";
            this.tb_mota.Size = new System.Drawing.Size(344, 49);
            this.tb_mota.TabIndex = 104;
            this.tb_mota.Texts = "";
            this.tb_mota.UnderlinedStyle = false;
            // 
            // tb_mucgiam
            // 
            this.tb_mucgiam.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_mucgiam.BackColor = System.Drawing.SystemColors.Window;
            this.tb_mucgiam.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.tb_mucgiam.BorderFocusColor = System.Drawing.Color.HotPink;
            this.tb_mucgiam.BorderRadius = 0;
            this.tb_mucgiam.BorderSize = 1;
            this.tb_mucgiam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_mucgiam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tb_mucgiam.Location = new System.Drawing.Point(360, 458);
            this.tb_mucgiam.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.tb_mucgiam.Multiline = false;
            this.tb_mucgiam.Name = "tb_mucgiam";
            this.tb_mucgiam.Padding = new System.Windows.Forms.Padding(14, 12, 14, 12);
            this.tb_mucgiam.PasswordChar = false;
            this.tb_mucgiam.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tb_mucgiam.PlaceholderText = "";
            this.tb_mucgiam.Size = new System.Drawing.Size(344, 49);
            this.tb_mucgiam.TabIndex = 103;
            this.tb_mucgiam.Texts = "";
            this.tb_mucgiam.UnderlinedStyle = false;
            // 
            // tb_ten
            // 
            this.tb_ten.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_ten.BackColor = System.Drawing.SystemColors.Window;
            this.tb_ten.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.tb_ten.BorderFocusColor = System.Drawing.Color.HotPink;
            this.tb_ten.BorderRadius = 0;
            this.tb_ten.BorderSize = 1;
            this.tb_ten.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_ten.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tb_ten.Location = new System.Drawing.Point(360, 262);
            this.tb_ten.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.tb_ten.Multiline = false;
            this.tb_ten.Name = "tb_ten";
            this.tb_ten.Padding = new System.Windows.Forms.Padding(14, 12, 14, 12);
            this.tb_ten.PasswordChar = false;
            this.tb_ten.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tb_ten.PlaceholderText = "";
            this.tb_ten.Size = new System.Drawing.Size(340, 49);
            this.tb_ten.TabIndex = 102;
            this.tb_ten.Texts = "";
            this.tb_ten.UnderlinedStyle = false;
            // 
            // tb_ma
            // 
            this.tb_ma.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_ma.BackColor = System.Drawing.SystemColors.Window;
            this.tb_ma.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.tb_ma.BorderFocusColor = System.Drawing.Color.HotPink;
            this.tb_ma.BorderRadius = 0;
            this.tb_ma.BorderSize = 1;
            this.tb_ma.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_ma.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tb_ma.Location = new System.Drawing.Point(360, 187);
            this.tb_ma.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.tb_ma.Multiline = false;
            this.tb_ma.Name = "tb_ma";
            this.tb_ma.Padding = new System.Windows.Forms.Padding(14, 12, 14, 12);
            this.tb_ma.PasswordChar = false;
            this.tb_ma.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tb_ma.PlaceholderText = "";
            this.tb_ma.Size = new System.Drawing.Size(340, 49);
            this.tb_ma.TabIndex = 101;
            this.tb_ma.Texts = "";
            this.tb_ma.UnderlinedStyle = false;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Elephant", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(303, 40);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(205, 93);
            this.label4.TabIndex = 100;
            this.label4.Text = "Sale";
            // 
            // ck_all
            // 
            this.ck_all.AutoSize = true;
            this.ck_all.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ck_all.Location = new System.Drawing.Point(726, 552);
            this.ck_all.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ck_all.Name = "ck_all";
            this.ck_all.Size = new System.Drawing.Size(90, 29);
            this.ck_all.TabIndex = 16;
            this.ck_all.Text = "Tất cả";
            this.ck_all.UseVisualStyleBackColor = true;
            // 
            // dtg_sp
            // 
            this.dtg_sp.AllowUserToAddRows = false;
            this.dtg_sp.AllowUserToDeleteRows = false;
            this.dtg_sp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg_sp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_sp.Location = new System.Drawing.Point(40, 613);
            this.dtg_sp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtg_sp.Name = "dtg_sp";
            this.dtg_sp.ReadOnly = true;
            this.dtg_sp.RowHeadersWidth = 62;
            this.dtg_sp.RowTemplate.Height = 25;
            this.dtg_sp.Size = new System.Drawing.Size(770, 380);
            this.dtg_sp.TabIndex = 15;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(487, 510);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(72, 25);
            this.label13.TabIndex = 13;
            this.label13.Text = "Loại SP";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(371, 547);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 38);
            this.button1.TabIndex = 11;
            this.button1.Text = "Tìm";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // comboBox3
            // 
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(487, 547);
            this.comboBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(228, 33);
            this.comboBox3.TabIndex = 10;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(41, 548);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(320, 31);
            this.textBox1.TabIndex = 9;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(40, 510);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(127, 25);
            this.label14.TabIndex = 8;
            this.label14.Text = "Tìm sản phẩm";
            // 
            // dtg_show
            // 
            this.dtg_show.AllowUserToAddRows = false;
            this.dtg_show.AllowUserToDeleteRows = false;
            this.dtg_show.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg_show.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_show.Location = new System.Drawing.Point(47, 168);
            this.dtg_show.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtg_show.Name = "dtg_show";
            this.dtg_show.ReadOnly = true;
            this.dtg_show.RowHeadersWidth = 62;
            this.dtg_show.RowTemplate.Height = 25;
            this.dtg_show.Size = new System.Drawing.Size(770, 305);
            this.dtg_show.TabIndex = 7;
            this.dtg_show.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_show_CellClick);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(584, 62);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(95, 25);
            this.label11.TabIndex = 6;
            this.label11.Text = "Trạng thái";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(407, 62);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 25);
            this.label10.TabIndex = 5;
            this.label10.Text = "Loại KM";
            // 
            // cbb_locTrangthai
            // 
            this.cbb_locTrangthai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_locTrangthai.FormattingEnabled = true;
            this.cbb_locTrangthai.Location = new System.Drawing.Point(584, 100);
            this.cbb_locTrangthai.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbb_locTrangthai.Name = "cbb_locTrangthai";
            this.cbb_locTrangthai.Size = new System.Drawing.Size(231, 33);
            this.cbb_locTrangthai.TabIndex = 4;
            this.cbb_locTrangthai.SelectedIndexChanged += new System.EventHandler(this.cbb_locTrangthai_SelectedIndexChanged);
            // 
            // bt_timkm
            // 
            this.bt_timkm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_timkm.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bt_timkm.Location = new System.Drawing.Point(300, 100);
            this.bt_timkm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bt_timkm.Name = "bt_timkm";
            this.bt_timkm.Size = new System.Drawing.Size(107, 38);
            this.bt_timkm.TabIndex = 3;
            this.bt_timkm.Text = "Tìm";
            this.bt_timkm.UseVisualStyleBackColor = true;
            // 
            // cbb_locKM
            // 
            this.cbb_locKM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_locKM.FormattingEnabled = true;
            this.cbb_locKM.Location = new System.Drawing.Point(416, 100);
            this.cbb_locKM.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbb_locKM.Name = "cbb_locKM";
            this.cbb_locKM.Size = new System.Drawing.Size(158, 33);
            this.cbb_locKM.TabIndex = 2;
            this.cbb_locKM.SelectedIndexChanged += new System.EventHandler(this.cbb_locKM_SelectedIndexChanged);
            // 
            // tb_timkiemkm
            // 
            this.tb_timkiemkm.Location = new System.Drawing.Point(47, 100);
            this.tb_timkiemkm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_timkiemkm.Name = "tb_timkiemkm";
            this.tb_timkiemkm.Size = new System.Drawing.Size(243, 31);
            this.tb_timkiemkm.TabIndex = 1;
            this.tb_timkiemkm.TextChanged += new System.EventHandler(this.tb_timkiemkm_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(46, 62);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(143, 25);
            this.label8.TabIndex = 0;
            this.label8.Text = "Tìm khuyến mại";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bt_sua);
            this.panel1.Controls.Add(this.tb_ma);
            this.panel1.Controls.Add(this.bt_them);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.cbb_trangthai);
            this.panel1.Controls.Add(this.lb_mucgiam);
            this.panel1.Controls.Add(this.cbb_loaiKM);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.tb_mota);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.tb_mucgiam);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.tb_ten);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.dtp_start);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dtp_end);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(836, 1050);
            this.panel1.TabIndex = 109;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ck_all);
            this.panel2.Controls.Add(this.dtg_show);
            this.panel2.Controls.Add(this.dtg_sp);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.tb_timkiemkm);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.cbb_locKM);
            this.panel2.Controls.Add(this.comboBox3);
            this.panel2.Controls.Add(this.bt_timkm);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.cbb_locTrangthai);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(836, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(888, 1050);
            this.panel2.TabIndex = 109;
            // 
            // FrmChiTietSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1724, 1050);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmChiTietSale";
            this.Text = "FrmChiTietSale";
            ((System.ComponentModel.ISupportInitialize)(this.dtg_sp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_show)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dtp_end;
        private System.Windows.Forms.DateTimePicker dtp_start;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lb_mucgiam;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dtg_show;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbb_locTrangthai;
        private System.Windows.Forms.ComboBox cbb_locKM;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dtg_sp;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.CheckBox ck_all;
        private CustomControls.RJControls.RJTextBox tb_mota;
        private CustomControls.RJControls.RJTextBox tb_mucgiam;
        private CustomControls.RJControls.RJTextBox tb_ten;
        private CustomControls.RJControls.RJTextBox tb_ma;
        private CustomControls.RJControls.RJComboBox cbb_trangthai;
        private CustomControls.RJControls.RJComboBox cbb_loaiKM;
        private System.Windows.Forms.Button bt_timkm;
        private System.Windows.Forms.TextBox tb_timkiemkm;
        private CustomControls.RJControls.RJButton bt_them;
        private CustomControls.RJControls.RJButton bt_sua;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}