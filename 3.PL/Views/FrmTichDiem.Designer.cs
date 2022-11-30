namespace _3.PL.Views
{
    partial class FrmTichDiem
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
            this.dtg_show = new System.Windows.Forms.DataGridView();
            this.rdb_hd = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.rdb_khd = new System.Windows.Forms.RadioButton();
            this.btn_update = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_show)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtg_show
            // 
            this.dtg_show.AllowUserToAddRows = false;
            this.dtg_show.AllowUserToDeleteRows = false;
            this.dtg_show.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg_show.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(224)))), ((int)(((byte)(225)))));
            this.dtg_show.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtg_show.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_show.Location = new System.Drawing.Point(23, 56);
            this.dtg_show.Name = "dtg_show";
            this.dtg_show.ReadOnly = true;
            this.dtg_show.RowHeadersVisible = false;
            this.dtg_show.RowHeadersWidth = 62;
            this.dtg_show.RowTemplate.Height = 33;
            this.dtg_show.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtg_show.Size = new System.Drawing.Size(777, 282);
            this.dtg_show.TabIndex = 0;
            this.dtg_show.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_show_CellClick);
            // 
            // rdb_hd
            // 
            this.rdb_hd.AutoSize = true;
            this.rdb_hd.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rdb_hd.Location = new System.Drawing.Point(179, 324);
            this.rdb_hd.Name = "rdb_hd";
            this.rdb_hd.Size = new System.Drawing.Size(144, 34);
            this.rdb_hd.TabIndex = 1;
            this.rdb_hd.TabStop = true;
            this.rdb_hd.Text = "Hoạt động";
            this.rdb_hd.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(46, 326);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "Trạng thái";
            // 
            // rdb_khd
            // 
            this.rdb_khd.AutoSize = true;
            this.rdb_khd.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rdb_khd.Location = new System.Drawing.Point(331, 324);
            this.rdb_khd.Name = "rdb_khd";
            this.rdb_khd.Size = new System.Drawing.Size(212, 34);
            this.rdb_khd.TabIndex = 3;
            this.rdb_khd.TabStop = true;
            this.rdb_khd.Text = "Không hoạt động";
            this.rdb_khd.UseVisualStyleBackColor = true;
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(143)))), ((int)(((byte)(157)))));
            this.btn_update.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_update.ForeColor = System.Drawing.Color.White;
            this.btn_update.Location = new System.Drawing.Point(605, 313);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(147, 56);
            this.btn_update.TabIndex = 4;
            this.btn_update.Text = "Cập nhật";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtg_show);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(-11, -44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(822, 437);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // FrmTichDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(224)))), ((int)(((byte)(225)))));
            this.ClientSize = new System.Drawing.Size(801, 379);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.rdb_khd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rdb_hd);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmTichDiem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmTichDiem";
            ((System.ComponentModel.ISupportInitialize)(this.dtg_show)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dtg_show;
        private System.Windows.Forms.RadioButton rdb_hd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdb_khd;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}