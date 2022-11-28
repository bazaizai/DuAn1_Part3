namespace _3.PL.Views
{
    partial class FrmLichSuTichDiem
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
            this.btn_clear = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_sua = new System.Windows.Forms.Button();
            this.tb_timkiem = new System.Windows.Forms.TextBox();
            this.dtg_show = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.dtp_ngaytichdiem = new System.Windows.Forms.DateTimePicker();
            this.rdb_khd = new System.Windows.Forms.RadioButton();
            this.rdb_hd = new System.Windows.Forms.RadioButton();
            this.tb_sodiemdung = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ID = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_show)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(143)))), ((int)(((byte)(157)))));
            this.btn_clear.ForeColor = System.Drawing.Color.White;
            this.btn_clear.Location = new System.Drawing.Point(711, 157);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(175, 48);
            this.btn_clear.TabIndex = 3;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 195);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 30);
            this.label6.TabIndex = 19;
            this.label6.Text = "Tìm kiếm";
            // 
            // btn_sua
            // 
            this.btn_sua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(143)))), ((int)(((byte)(157)))));
            this.btn_sua.ForeColor = System.Drawing.Color.White;
            this.btn_sua.Location = new System.Drawing.Point(711, 83);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(175, 48);
            this.btn_sua.TabIndex = 1;
            this.btn_sua.Text = "Điều chỉnh";
            this.btn_sua.UseVisualStyleBackColor = false;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // tb_timkiem
            // 
            this.tb_timkiem.Location = new System.Drawing.Point(227, 196);
            this.tb_timkiem.Name = "tb_timkiem";
            this.tb_timkiem.Size = new System.Drawing.Size(409, 37);
            this.tb_timkiem.TabIndex = 19;
            // 
            // dtg_show
            // 
            this.dtg_show.AllowUserToAddRows = false;
            this.dtg_show.AllowUserToDeleteRows = false;
            this.dtg_show.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg_show.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(224)))), ((int)(((byte)(225)))));
            this.dtg_show.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_show.Location = new System.Drawing.Point(3, 3);
            this.dtg_show.Name = "dtg_show";
            this.dtg_show.RowHeadersVisible = false;
            this.dtg_show.RowHeadersWidth = 62;
            this.dtg_show.RowTemplate.Height = 33;
            this.dtg_show.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtg_show.Size = new System.Drawing.Size(943, 319);
            this.dtg_show.TabIndex = 0;
            this.dtg_show.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_show_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 30);
            this.label2.TabIndex = 20;
            this.label2.Text = "Ngày tích điểm";
            // 
            // dtp_ngaytichdiem
            // 
            this.dtp_ngaytichdiem.Location = new System.Drawing.Point(227, 94);
            this.dtp_ngaytichdiem.Name = "dtp_ngaytichdiem";
            this.dtp_ngaytichdiem.Size = new System.Drawing.Size(409, 37);
            this.dtp_ngaytichdiem.TabIndex = 19;
            // 
            // rdb_khd
            // 
            this.rdb_khd.AutoSize = true;
            this.rdb_khd.Location = new System.Drawing.Point(402, 147);
            this.rdb_khd.Name = "rdb_khd";
            this.rdb_khd.Size = new System.Drawing.Size(212, 34);
            this.rdb_khd.TabIndex = 18;
            this.rdb_khd.TabStop = true;
            this.rdb_khd.Text = "Không hoạt động";
            this.rdb_khd.UseVisualStyleBackColor = true;
            // 
            // rdb_hd
            // 
            this.rdb_hd.AutoSize = true;
            this.rdb_hd.Location = new System.Drawing.Point(227, 147);
            this.rdb_hd.Name = "rdb_hd";
            this.rdb_hd.Size = new System.Drawing.Size(144, 34);
            this.rdb_hd.TabIndex = 17;
            this.rdb_hd.TabStop = true;
            this.rdb_hd.Text = "Hoạt động";
            this.rdb_hd.UseVisualStyleBackColor = true;
            // 
            // tb_sodiemdung
            // 
            this.tb_sodiemdung.Location = new System.Drawing.Point(227, 48);
            this.tb_sodiemdung.Name = "tb_sodiemdung";
            this.tb_sodiemdung.Size = new System.Drawing.Size(409, 37);
            this.tb_sodiemdung.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(39, 147);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 30);
            this.label7.TabIndex = 8;
            this.label7.Text = "Trạng thái";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số điểm đã dùng";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtg_show);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 291);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(949, 334);
            this.panel1.TabIndex = 21;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btn_sua);
            this.panel3.Controls.Add(this.btn_clear);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.tb_sodiemdung);
            this.panel3.Controls.Add(this.tb_timkiem);
            this.panel3.Controls.Add(this.rdb_khd);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.rdb_hd);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.dtp_ngaytichdiem);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(949, 285);
            this.panel3.TabIndex = 23;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 8;
            this.ID.Name = "ID";
            this.ID.Width = 150;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.HeaderText = "ID";
            this.dataGridViewCheckBoxColumn1.MinimumWidth = 8;
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.Width = 150;
            // 
            // FrmLichSuTichDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(224)))), ((int)(((byte)(225)))));
            this.ClientSize = new System.Drawing.Size(949, 625);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Name = "FrmLichSuTichDiem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmLichSuTichDiem";
            ((System.ComponentModel.ISupportInitialize)(this.dtg_show)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_timkiem;
        private System.Windows.Forms.DataGridView dtg_show;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.RadioButton rdb_khd;
        private System.Windows.Forms.RadioButton rdb_hd;
        private System.Windows.Forms.TextBox tb_sodiemdung;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtp_ngaytichdiem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ID;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
    }
}