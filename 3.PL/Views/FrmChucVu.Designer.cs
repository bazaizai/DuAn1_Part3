namespace _3.PL.Views
{
    partial class FrmChucVu
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbt_ma = new System.Windows.Forms.TextBox();
            this.rdb_hoatdong = new System.Windows.Forms.RadioButton();
            this.btn_them = new System.Windows.Forms.Button();
            this.tbt_ten = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.rdb_khonghd = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.dtg_show = new System.Windows.Forms.DataGridView();
            this.label15 = new System.Windows.Forms.Label();
            this.tb_timkiem = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_show)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(40, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã";
            // 
            // tbt_ma
            // 
            this.tbt_ma.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbt_ma.Location = new System.Drawing.Point(142, 44);
            this.tbt_ma.Name = "tbt_ma";
            this.tbt_ma.Size = new System.Drawing.Size(229, 27);
            this.tbt_ma.TabIndex = 1;
            // 
            // rdb_hoatdong
            // 
            this.rdb_hoatdong.AutoSize = true;
            this.rdb_hoatdong.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rdb_hoatdong.ForeColor = System.Drawing.Color.White;
            this.rdb_hoatdong.Location = new System.Drawing.Point(142, 157);
            this.rdb_hoatdong.Name = "rdb_hoatdong";
            this.rdb_hoatdong.Size = new System.Drawing.Size(100, 24);
            this.rdb_hoatdong.TabIndex = 2;
            this.rdb_hoatdong.TabStop = true;
            this.rdb_hoatdong.Text = "Hoạt động";
            this.rdb_hoatdong.UseVisualStyleBackColor = true;
            // 
            // btn_them
            // 
            this.btn_them.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(122)))), ((int)(((byte)(83)))));
            this.btn_them.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_them.ForeColor = System.Drawing.Color.White;
            this.btn_them.Location = new System.Drawing.Point(415, 31);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(84, 36);
            this.btn_them.TabIndex = 3;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = false;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // tbt_ten
            // 
            this.tbt_ten.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbt_ten.Location = new System.Drawing.Point(142, 100);
            this.tbt_ten.Name = "tbt_ten";
            this.tbt_ten.Size = new System.Drawing.Size(229, 27);
            this.tbt_ten.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(40, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tên";
            // 
            // btn_sua
            // 
            this.btn_sua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(122)))), ((int)(((byte)(83)))));
            this.btn_sua.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_sua.ForeColor = System.Drawing.Color.White;
            this.btn_sua.Location = new System.Drawing.Point(415, 73);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(84, 37);
            this.btn_sua.TabIndex = 8;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = false;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.BackColor = System.Drawing.Color.Crimson;
            this.btn_xoa.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_xoa.ForeColor = System.Drawing.Color.White;
            this.btn_xoa.Location = new System.Drawing.Point(415, 116);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(84, 41);
            this.btn_xoa.TabIndex = 9;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = false;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // rdb_khonghd
            // 
            this.rdb_khonghd.AutoSize = true;
            this.rdb_khonghd.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rdb_khonghd.ForeColor = System.Drawing.Color.White;
            this.rdb_khonghd.Location = new System.Drawing.Point(253, 157);
            this.rdb_khonghd.Name = "rdb_khonghd";
            this.rdb_khonghd.Size = new System.Drawing.Size(147, 24);
            this.rdb_khonghd.TabIndex = 11;
            this.rdb_khonghd.TabStop = true;
            this.rdb_khonghd.Text = "Không hoạt động";
            this.rdb_khonghd.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(40, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Trạng thái";
            // 
            // dtg_show
            // 
            this.dtg_show.AllowUserToAddRows = false;
            this.dtg_show.AllowUserToDeleteRows = false;
            this.dtg_show.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg_show.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(36)))));
            this.dtg_show.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtg_show.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_show.Location = new System.Drawing.Point(40, 244);
            this.dtg_show.Name = "dtg_show";
            this.dtg_show.ReadOnly = true;
            this.dtg_show.RowHeadersVisible = false;
            this.dtg_show.RowTemplate.Height = 25;
            this.dtg_show.Size = new System.Drawing.Size(459, 150);
            this.dtg_show.TabIndex = 13;
            this.dtg_show.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_show_CellClick);
            this.dtg_show.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_show_CellContentClick);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(40, 205);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(71, 20);
            this.label15.TabIndex = 74;
            this.label15.Text = "Tìm kiếm";
            // 
            // tb_timkiem
            // 
            this.tb_timkiem.BackColor = System.Drawing.SystemColors.Window;
            this.tb_timkiem.Location = new System.Drawing.Point(142, 202);
            this.tb_timkiem.Margin = new System.Windows.Forms.Padding(2);
            this.tb_timkiem.Name = "tb_timkiem";
            this.tb_timkiem.Size = new System.Drawing.Size(247, 23);
            this.tb_timkiem.TabIndex = 73;
            this.tb_timkiem.TextChanged += new System.EventHandler(this.tb_timkiem_TextChanged);
            // 
            // FrmChucVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(619, 454);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.tb_timkiem);
            this.Controls.Add(this.dtg_show);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rdb_khonghd);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.tbt_ten);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.rdb_hoatdong);
            this.Controls.Add(this.tbt_ma);
            this.Controls.Add(this.label1);
            this.Name = "FrmChucVu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmChucVu";
            ((System.ComponentModel.ISupportInitialize)(this.dtg_show)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbt_ma;
        private System.Windows.Forms.RadioButton rdb_hoatdong;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.TextBox tbt_ten;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.RadioButton rdb_khonghd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dtg_show;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tb_timkiem;
    }
}