namespace _3.PL.Views
{
    partial class FrmChonSale
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KhuyenMai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MucKM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LHinhKm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Ma,
            this.KhuyenMai,
            this.MucKM,
            this.LHinhKm});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(1011, 627);
            this.dataGridView1.TabIndex = 0;
            // 
            // Id
            // 
            this.Id.HeaderText = "ID";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // Ma
            // 
            this.Ma.HeaderText = "Ma";
            this.Ma.MinimumWidth = 6;
            this.Ma.Name = "Ma";
            this.Ma.ReadOnly = true;
            // 
            // KhuyenMai
            // 
            this.KhuyenMai.HeaderText = "Khuyến mãi";
            this.KhuyenMai.MinimumWidth = 6;
            this.KhuyenMai.Name = "KhuyenMai";
            this.KhuyenMai.ReadOnly = true;
            // 
            // MucKM
            // 
            this.MucKM.HeaderText = "Mức KM";
            this.MucKM.MinimumWidth = 6;
            this.MucKM.Name = "MucKM";
            this.MucKM.ReadOnly = true;
            // 
            // LHinhKm
            // 
            this.LHinhKm.HeaderText = "Loại KM";
            this.LHinhKm.MinimumWidth = 6;
            this.LHinhKm.Name = "LHinhKm";
            this.LHinhKm.ReadOnly = true;
            // 
            // FrmChonSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 627);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FrmChonSale";
            this.Text = "FrmChonSale";
            this.Load += new System.EventHandler(this.FrmChonSale_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ma;
        private System.Windows.Forms.DataGridViewTextBoxColumn KhuyenMai;
        private System.Windows.Forms.DataGridViewTextBoxColumn MucKM;
        private System.Windows.Forms.DataGridViewTextBoxColumn LHinhKm;
    }
}