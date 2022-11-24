namespace _3.PL.Views
{
    partial class FrmGiaiDau
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
            ((System.ComponentModel.ISupportInitialize)(this.dtg_show)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_xoaform
            // 
            this.bt_xoaform.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(143)))), ((int)(((byte)(157)))));
            this.bt_xoaform.ForeColor = System.Drawing.Color.White;
            this.bt_xoaform.Location = new System.Drawing.Point(626, 178);
            this.bt_xoaform.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_xoaform.Name = "bt_xoaform";
            this.bt_xoaform.Size = new System.Drawing.Size(82, 36);
            this.bt_xoaform.TabIndex = 42;
            this.bt_xoaform.Text = "Xóa form";
            this.bt_xoaform.UseVisualStyleBackColor = false;
            this.bt_xoaform.Click += new System.EventHandler(this.bt_xoaform_Click);
            // 
            // rdb_khd
            // 
            this.rdb_khd.AutoSize = true;
            this.rdb_khd.Location = new System.Drawing.Point(280, 153);
            this.rdb_khd.Name = "rdb_khd";
            this.rdb_khd.Size = new System.Drawing.Size(118, 19);
            this.rdb_khd.TabIndex = 41;
            this.rdb_khd.TabStop = true;
            this.rdb_khd.Text = "Không hoạt động";
            this.rdb_khd.UseVisualStyleBackColor = true;
            // 
            // rdb_hd
            // 
            this.rdb_hd.AutoSize = true;
            this.rdb_hd.Location = new System.Drawing.Point(158, 153);
            this.rdb_hd.Name = "rdb_hd";
            this.rdb_hd.Size = new System.Drawing.Size(83, 19);
            this.rdb_hd.TabIndex = 40;
            this.rdb_hd.TabStop = true;
            this.rdb_hd.Text = "Hoạt Động";
            this.rdb_hd.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(86, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 15);
            this.label4.TabIndex = 39;
            this.label4.Text = "tìm kiếm";
            // 
            // tb_timkiem
            // 
            this.tb_timkiem.Location = new System.Drawing.Point(158, 193);
            this.tb_timkiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_timkiem.Name = "tb_timkiem";
            this.tb_timkiem.Size = new System.Drawing.Size(381, 23);
            this.tb_timkiem.TabIndex = 38;
            this.tb_timkiem.TextChanged += new System.EventHandler(this.tb_timkiem_TextChanged);
            // 
            // dtg_show
            // 
            this.dtg_show.AllowUserToAddRows = false;
            this.dtg_show.AllowUserToDeleteRows = false;
            this.dtg_show.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg_show.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_show.Location = new System.Drawing.Point(55, 231);
            this.dtg_show.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtg_show.Name = "dtg_show";
            this.dtg_show.ReadOnly = true;
            this.dtg_show.RowHeadersWidth = 51;
            this.dtg_show.RowTemplate.Height = 29;
            this.dtg_show.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtg_show.Size = new System.Drawing.Size(684, 141);
            this.dtg_show.TabIndex = 37;
            this.dtg_show.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_show_CellClick);
            // 
            // bt_xoa
            // 
            this.bt_xoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(143)))), ((int)(((byte)(157)))));
            this.bt_xoa.ForeColor = System.Drawing.Color.White;
            this.bt_xoa.Location = new System.Drawing.Point(626, 134);
            this.bt_xoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_xoa.Name = "bt_xoa";
            this.bt_xoa.Size = new System.Drawing.Size(82, 36);
            this.bt_xoa.TabIndex = 36;
            this.bt_xoa.Text = "xóa";
            this.bt_xoa.UseVisualStyleBackColor = false;
            this.bt_xoa.Click += new System.EventHandler(this.bt_xoa_Click);
            // 
            // tb_them
            // 
            this.tb_them.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(143)))), ((int)(((byte)(157)))));
            this.tb_them.ForeColor = System.Drawing.Color.White;
            this.tb_them.Location = new System.Drawing.Point(626, 86);
            this.tb_them.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_them.Name = "tb_them";
            this.tb_them.Size = new System.Drawing.Size(82, 36);
            this.tb_them.TabIndex = 35;
            this.tb_them.Text = "Thêm";
            this.tb_them.UseVisualStyleBackColor = false;
            this.tb_them.Click += new System.EventHandler(this.tb_them_Click);
            // 
            // bt_update
            // 
            this.bt_update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(143)))), ((int)(((byte)(157)))));
            this.bt_update.ForeColor = System.Drawing.Color.White;
            this.bt_update.Location = new System.Drawing.Point(626, 40);
            this.bt_update.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_update.Name = "bt_update";
            this.bt_update.Size = new System.Drawing.Size(82, 36);
            this.bt_update.TabIndex = 34;
            this.bt_update.Text = "Sửa";
            this.bt_update.UseVisualStyleBackColor = false;
            this.bt_update.Click += new System.EventHandler(this.bt_update_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(87, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 15);
            this.label3.TabIndex = 33;
            this.label3.Text = "Trạng thái";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(92, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 15);
            this.label2.TabIndex = 32;
            this.label2.Text = "Tên";
            // 
            // tb_ten
            // 
            this.tb_ten.Location = new System.Drawing.Point(164, 102);
            this.tb_ten.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_ten.Name = "tb_ten";
            this.tb_ten.Size = new System.Drawing.Size(375, 23);
            this.tb_ten.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 15);
            this.label1.TabIndex = 30;
            this.label1.Text = "Mã";
            // 
            // tb_ma
            // 
            this.tb_ma.Location = new System.Drawing.Point(164, 60);
            this.tb_ma.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_ma.Name = "tb_ma";
            this.tb_ma.Size = new System.Drawing.Size(375, 23);
            this.tb_ma.TabIndex = 29;
            // 
            // FrmGiaiDau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(224)))), ((int)(((byte)(225)))));
            this.ClientSize = new System.Drawing.Size(796, 399);
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
            this.Name = "FrmGiaiDau";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmGiaiDau";
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
    }
}