namespace _3.PL.Views
{
    partial class FrmQLKieuSP
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDelete = new FontAwesome.Sharp.IconButton();
            this.btnUpdate = new FontAwesome.Sharp.IconButton();
            this.btnAdd = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabthongtin = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dtgView = new System.Windows.Forms.DataGridView();
            this.txtSearch = new CustomControls.RJControls.RJTextBox();
            this.tabInput = new System.Windows.Forms.TabPage();
            this.cbb_cha = new CustomControls.RJControls.RJComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rdoKhongHoatDong = new CustomControls.RJControls.RJRadioButton();
            this.rdoHoatDong = new CustomControls.RJControls.RJRadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMa = new CustomControls.RJControls.RJTextBox();
            this.txtTen = new CustomControls.RJControls.RJTextBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabthongtin.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgView)).BeginInit();
            this.tabInput.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(11)))), ((int)(((byte)(18)))));
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(615, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 501);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(11)))), ((int)(((byte)(18)))));
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.Color.Gainsboro;
            this.groupBox1.Location = new System.Drawing.Point(0, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 473);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chức năng";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDelete.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnDelete.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.btnDelete.IconColor = System.Drawing.Color.Gainsboro;
            this.btnDelete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDelete.Location = new System.Drawing.Point(3, 122);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(244, 51);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Olive;
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUpdate.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnUpdate.IconChar = FontAwesome.Sharp.IconChar.Circle;
            this.btnUpdate.IconColor = System.Drawing.Color.Gainsboro;
            this.btnUpdate.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUpdate.Location = new System.Drawing.Point(3, 71);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(244, 51);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAdd.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAdd.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.btnAdd.IconColor = System.Drawing.Color.Gainsboro;
            this.btnAdd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAdd.Location = new System.Drawing.Point(3, 20);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(244, 51);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add";
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tabthongtin);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(615, 501);
            this.panel2.TabIndex = 1;
            // 
            // tabthongtin
            // 
            this.tabthongtin.Controls.Add(this.tabPage1);
            this.tabthongtin.Controls.Add(this.tabInput);
            this.tabthongtin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabthongtin.Location = new System.Drawing.Point(0, 0);
            this.tabthongtin.Name = "tabthongtin";
            this.tabthongtin.SelectedIndex = 0;
            this.tabthongtin.Size = new System.Drawing.Size(615, 501);
            this.tabthongtin.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(62)))));
            this.tabPage1.Controls.Add(this.dtgView);
            this.tabPage1.Controls.Add(this.txtSearch);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(607, 468);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "List View";
            // 
            // dtgView
            // 
            this.dtgView.AllowUserToAddRows = false;
            this.dtgView.AllowUserToDeleteRows = false;
            this.dtgView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Yellow;
            this.dtgView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(62)))));
            this.dtgView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dtgView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgView.ColumnHeadersHeight = 50;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgView.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtgView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgView.EnableHeadersVisualStyles = false;
            this.dtgView.Location = new System.Drawing.Point(3, 38);
            this.dtgView.Name = "dtgView";
            this.dtgView.ReadOnly = true;
            this.dtgView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgView.RowHeadersWidth = 51;
            this.dtgView.RowTemplate.Height = 50;
            this.dtgView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgView.Size = new System.Drawing.Size(601, 427);
            this.dtgView.TabIndex = 5;
            this.dtgView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgView_CellClick_1);
            this.dtgView.DoubleClick += new System.EventHandler(this.dtgView_DoubleClick_1);
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(62)))));
            this.txtSearch.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtSearch.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtSearch.BorderRadius = 0;
            this.txtSearch.BorderSize = 2;
            this.txtSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSearch.Location = new System.Drawing.Point(3, 3);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtSearch.Multiline = false;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtSearch.PasswordChar = false;
            this.txtSearch.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtSearch.PlaceholderText = "Search";
            this.txtSearch.Size = new System.Drawing.Size(601, 35);
            this.txtSearch.TabIndex = 4;
            this.txtSearch.Texts = "";
            this.txtSearch.UnderlinedStyle = true;
            // 
            // tabInput
            // 
            this.tabInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(14)))), ((int)(((byte)(26)))));
            this.tabInput.Controls.Add(this.cbb_cha);
            this.tabInput.Controls.Add(this.label4);
            this.tabInput.Controls.Add(this.rdoKhongHoatDong);
            this.tabInput.Controls.Add(this.rdoHoatDong);
            this.tabInput.Controls.Add(this.label3);
            this.tabInput.Controls.Add(this.label2);
            this.tabInput.Controls.Add(this.label1);
            this.tabInput.Controls.Add(this.txtMa);
            this.tabInput.Controls.Add(this.txtTen);
            this.tabInput.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tabInput.Location = new System.Drawing.Point(4, 29);
            this.tabInput.Name = "tabInput";
            this.tabInput.Padding = new System.Windows.Forms.Padding(3);
            this.tabInput.Size = new System.Drawing.Size(607, 468);
            this.tabInput.TabIndex = 1;
            this.tabInput.Text = "Thông Tin";
            // 
            // cbb_cha
            // 
            this.cbb_cha.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbb_cha.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cbb_cha.BorderSize = 1;
            this.cbb_cha.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbb_cha.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbb_cha.ForeColor = System.Drawing.Color.DimGray;
            this.cbb_cha.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.cbb_cha.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cbb_cha.ListTextColor = System.Drawing.Color.DimGray;
            this.cbb_cha.Location = new System.Drawing.Point(183, 272);
            this.cbb_cha.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbb_cha.MinimumSize = new System.Drawing.Size(229, 40);
            this.cbb_cha.Name = "cbb_cha";
            this.cbb_cha.Padding = new System.Windows.Forms.Padding(1);
            this.cbb_cha.Size = new System.Drawing.Size(363, 40);
            this.cbb_cha.TabIndex = 8;
            this.cbb_cha.Texts = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Gainsboro;
            this.label4.Location = new System.Drawing.Point(80, 272);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 29);
            this.label4.TabIndex = 7;
            this.label4.Text = "Kiểu cha";
            // 
            // rdoKhongHoatDong
            // 
            this.rdoKhongHoatDong.AutoSize = true;
            this.rdoKhongHoatDong.CheckedColor = System.Drawing.Color.MediumSlateBlue;
            this.rdoKhongHoatDong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdoKhongHoatDong.ForeColor = System.Drawing.Color.LightGray;
            this.rdoKhongHoatDong.Location = new System.Drawing.Point(382, 368);
            this.rdoKhongHoatDong.MinimumSize = new System.Drawing.Size(0, 21);
            this.rdoKhongHoatDong.Name = "rdoKhongHoatDong";
            this.rdoKhongHoatDong.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.rdoKhongHoatDong.Size = new System.Drawing.Size(165, 24);
            this.rdoKhongHoatDong.TabIndex = 5;
            this.rdoKhongHoatDong.TabStop = true;
            this.rdoKhongHoatDong.Text = "Không hoạt động";
            this.rdoKhongHoatDong.UnCheckedColor = System.Drawing.Color.Gray;
            this.rdoKhongHoatDong.UseVisualStyleBackColor = true;
            // 
            // rdoHoatDong
            // 
            this.rdoHoatDong.AutoSize = true;
            this.rdoHoatDong.CheckedColor = System.Drawing.Color.MediumSlateBlue;
            this.rdoHoatDong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdoHoatDong.ForeColor = System.Drawing.Color.LightGray;
            this.rdoHoatDong.Location = new System.Drawing.Point(239, 368);
            this.rdoHoatDong.MinimumSize = new System.Drawing.Size(0, 21);
            this.rdoHoatDong.Name = "rdoHoatDong";
            this.rdoHoatDong.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.rdoHoatDong.Size = new System.Drawing.Size(117, 24);
            this.rdoHoatDong.TabIndex = 4;
            this.rdoHoatDong.TabStop = true;
            this.rdoHoatDong.Text = "Hoạt động";
            this.rdoHoatDong.UnCheckedColor = System.Drawing.Color.Gray;
            this.rdoHoatDong.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(80, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(81, 363);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Trạng Thái";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(80, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã";
            // 
            // txtMa
            // 
            this.txtMa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(14)))), ((int)(((byte)(26)))));
            this.txtMa.BorderColor = System.Drawing.Color.Red;
            this.txtMa.BorderFocusColor = System.Drawing.Color.DarkGoldenrod;
            this.txtMa.BorderRadius = 0;
            this.txtMa.BorderSize = 2;
            this.txtMa.Enabled = false;
            this.txtMa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMa.ForeColor = System.Drawing.Color.White;
            this.txtMa.Location = new System.Drawing.Point(183, 123);
            this.txtMa.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtMa.Multiline = false;
            this.txtMa.Name = "txtMa";
            this.txtMa.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtMa.PasswordChar = false;
            this.txtMa.PlaceholderColor = System.Drawing.Color.Red;
            this.txtMa.PlaceholderText = "";
            this.txtMa.Size = new System.Drawing.Size(363, 35);
            this.txtMa.TabIndex = 0;
            this.txtMa.Texts = "";
            this.txtMa.UnderlinedStyle = true;
            // 
            // txtTen
            // 
            this.txtTen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(14)))), ((int)(((byte)(26)))));
            this.txtTen.BorderColor = System.Drawing.Color.Red;
            this.txtTen.BorderFocusColor = System.Drawing.Color.DarkGoldenrod;
            this.txtTen.BorderRadius = 0;
            this.txtTen.BorderSize = 2;
            this.txtTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTen.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtTen.Location = new System.Drawing.Point(183, 196);
            this.txtTen.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtTen.Multiline = false;
            this.txtTen.Name = "txtTen";
            this.txtTen.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtTen.PasswordChar = false;
            this.txtTen.PlaceholderColor = System.Drawing.Color.Red;
            this.txtTen.PlaceholderText = "";
            this.txtTen.Size = new System.Drawing.Size(363, 35);
            this.txtTen.TabIndex = 0;
            this.txtTen.Texts = "";
            this.txtTen.UnderlinedStyle = true;
            // 
            // FrmQLKieuSP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 501);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FrmQLKieuSP";
            this.Text = "FrmQLKieuSP";
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tabthongtin.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgView)).EndInit();
            this.tabInput.ResumeLayout(false);
            this.tabInput.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TabControl tabthongtin;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabInput;
        private System.Windows.Forms.GroupBox groupBox1;
        private FontAwesome.Sharp.IconButton btnDelete;
        private FontAwesome.Sharp.IconButton btnUpdate;
        private FontAwesome.Sharp.IconButton btnAdd;
        private CustomControls.RJControls.RJRadioButton rdoKhongHoatDong;
        private CustomControls.RJControls.RJRadioButton rdoHoatDong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private CustomControls.RJControls.RJTextBox txtMa;
        private CustomControls.RJControls.RJTextBox txtTen;
        private CustomControls.RJControls.RJComboBox cbb_cha;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dtgView;
        private CustomControls.RJControls.RJTextBox txtSearch;
    }
}