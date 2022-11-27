using _2.BUS.IServices;
using _2.BUS.Services;
using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3.PL.Views
{
    public partial class FrmTichDiem : Form
    {
        public ITichDiemServices _iTichDiemServices;
        public TichDiemView _tichDiemView;
        public FrmTichDiem()
        {
            InitializeComponent();
            _iTichDiemServices = new TichDiemServices();
            _tichDiemView = new TichDiemView();
            LoadData();


        }
        public void ClearForm()
        {
            LoadData();
            //tb_sodiem.Text = "";
            //rdb_hd.Checked = false;
            //rdb_khd.Checked = false;
        }
        public void LoadData()
        {
            int stt = 1;
            dtg_show.ColumnCount = 4;
            dtg_show.Columns[0].Name = "Id";
            dtg_show.Columns[0].Visible = false;
            dtg_show.Columns[1].Name = "STT";
            dtg_show.Columns[2].Name = "Tổng số điểm";
            dtg_show.Columns[3].Name = "Trạng thái";


            dtg_show.Rows.Clear();
            var lst = _iTichDiemServices.GetAll();
            foreach (var item in lst)
            {
                dtg_show.Rows.Add(item.Id, stt++, item.SoDiem, item.TrangThai == 1 ? "Hoạt động" : "Không hoạt động");
            }
        }
        private void btn_them_Click(object sender, EventArgs e)
        {
            //var x = new TichDiemView()
            //{
            //    Id = new Guid(),
            //    SoDiem = Convert.ToInt32(tb_sodiem.Text),
            //    TrangThai = rdb_hd.Checked ? 1 : 0
            //};
            //MessageBox.Show(_iTichDiemServices.Add(x));
            //ClearForm();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(_iTichDiemServices.Delete(_tichDiemView));
            //ClearForm();
        }


        private void btn_clear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void dtg_show_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow r = dtg_show.Rows[e.RowIndex];
                _tichDiemView = _iTichDiemServices.GetAll().FirstOrDefault(x => x.Id == Guid.Parse(r.Cells[0].Value.ToString()));
                rdb_hd.Checked = _tichDiemView.TrangThai == 1;
                rdb_khd.Checked = _tichDiemView.TrangThai == 0;
            }
        }

        private void tb_ct_TextChanged(object sender, EventArgs e)
        {
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            _tichDiemView.TrangThai = rdb_hd.Checked ? 1 : 0;
            MessageBox.Show(_iTichDiemServices.Update(_tichDiemView));
            ClearForm();
        }
    }
}
