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
            this.label6 = new System.Windows.Forms.Label();
            this.tb_timkiem = new System.Windows.Forms.TextBox();
            this.dtg_show = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tennv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoDiemDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayTichDiem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Trangthai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ID = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_show)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(36)))));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(77, 15);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 20);
            this.label6.TabIndex = 19;
            this.label6.Text = "Tìm kiếm";
            // 
            // tb_timkiem
            // 
            this.tb_timkiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(36)))));
            this.tb_timkiem.Location = new System.Drawing.Point(181, 12);
            this.tb_timkiem.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tb_timkiem.Name = "tb_timkiem";
            this.tb_timkiem.Size = new System.Drawing.Size(623, 27);
            this.tb_timkiem.TabIndex = 19;
            this.tb_timkiem.TextChanged += new System.EventHandler(this.tb_timkiem_TextChanged);
            // 
            // dtg_show
            // 
            this.dtg_show.AllowUserToAddRows = false;
            this.dtg_show.AllowUserToDeleteRows = false;
            this.dtg_show.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg_show.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(36)))));
            this.dtg_show.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtg_show.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_show.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.STT,
            this.MaHD,
            this.tennv,
            this.Kh,
            this.SoDiemDung,
            this.NgayTichDiem,
            this.Trangthai});
            this.dtg_show.Location = new System.Drawing.Point(2, 52);
            this.dtg_show.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dtg_show.Name = "dtg_show";
            this.dtg_show.RowHeadersVisible = false;
            this.dtg_show.RowHeadersWidth = 62;
            this.dtg_show.RowTemplate.Height = 33;
            this.dtg_show.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtg_show.Size = new System.Drawing.Size(937, 409);
            this.dtg_show.TabIndex = 0;
            this.dtg_show.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_show_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.MinimumWidth = 8;
            this.STT.Name = "STT";
            // 
            // MaHD
            // 
            this.MaHD.HeaderText = "Mã hóa đơn";
            this.MaHD.MinimumWidth = 8;
            this.MaHD.Name = "MaHD";
            // 
            // tennv
            // 
            this.tennv.HeaderText = "Nhân Viên";
            this.tennv.MinimumWidth = 8;
            this.tennv.Name = "tennv";
            // 
            // Kh
            // 
            this.Kh.HeaderText = "Khách hàng";
            this.Kh.MinimumWidth = 8;
            this.Kh.Name = "Kh";
            // 
            // SoDiemDung
            // 
            this.SoDiemDung.HeaderText = "Số điểm dùng";
            this.SoDiemDung.MinimumWidth = 8;
            this.SoDiemDung.Name = "SoDiemDung";
            // 
            // NgayTichDiem
            // 
            this.NgayTichDiem.HeaderText = "Ngày tích điểm";
            this.NgayTichDiem.MinimumWidth = 8;
            this.NgayTichDiem.Name = "NgayTichDiem";
            // 
            // Trangthai
            // 
            this.Trangthai.HeaderText = "Trạng thái";
            this.Trangthai.MinimumWidth = 8;
            this.Trangthai.Name = "Trangthai";
            this.Trangthai.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtg_show);
            this.panel1.Controls.Add(this.tb_timkiem);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.panel1.Location = new System.Drawing.Point(0, 10);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(942, 471);
            this.panel1.TabIndex = 21;
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(942, 481);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "FrmLichSuTichDiem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmLichSuTichDiem";
            ((System.ComponentModel.ISupportInitialize)(this.dtg_show)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_timkiem;
        private System.Windows.Forms.DataGridView dtg_show;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ID;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn tennv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kh;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoDiemDung;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayTichDiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Trangthai;
    }
}