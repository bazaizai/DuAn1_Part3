
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
    public partial class FrmLichSuTichDiem : Form
    {
        ILichSuTichDiemServices _iLichSuTichDiemServices;
        IHoaDonServices _iHoaDonServices;
        ITichDiemServices _iTichDiemServices;
        ICtTichDiemServices _iCongThucTichDiemServices;
        
        LichSuTichDiemView _lichSuTichDiemView;
        HoaDonViews _hoaDonViews;
        TichDiemView _tichDiemView;
        CtTinhDiemView _ctTichDiemView;
        List<LichSuTichDiemView> _lstLichSuTichDiem;
        List<HoaDonViews> _lstHoaDonViews;
        public FrmLichSuTichDiem()
        {
            InitializeComponent();
            _iLichSuTichDiemServices = new LichSuTichDiemServices();
            _iHoaDonServices = new HoaDonServices();
            _iTichDiemServices = new TichDiemServices();
            _iCongThucTichDiemServices = new CtTichDiemServices();
            _lichSuTichDiemView = new LichSuTichDiemView();
            _tichDiemView = new TichDiemView();
            _hoaDonViews = new HoaDonViews();
            _ctTichDiemView = new CtTinhDiemView();
            _lstLichSuTichDiem = new List<LichSuTichDiemView>();
            _lstHoaDonViews = new List<HoaDonViews>();
            loadLS();
            LoadData();
        }

        public void ClearForm()
        {
            LoadData();
            //tb_sodiemdung.Text = "";
            //rdb_hd.Checked = false;
            //rdb_khd.Checked = false;
        }
        public void LoadData()
        {
            int stt = 1;
            dtg_show.ColumnCount = 8;
            dtg_show.Columns[0].Name = "Id";
            dtg_show.Columns[0].Visible = false;
            dtg_show.Columns[1].Name = "STT";          
            dtg_show.Columns[2].Name = "Mã hóa đơn";          
            dtg_show.Columns[3].Name = "Mã nhân viên";          
            dtg_show.Columns[4].Name = "Tên khách hàng";          
            dtg_show.Columns[5].Name = "Số điểm dùng";          
            dtg_show.Columns[6].Name = "Ngày tích điểm";          
            dtg_show.Columns[7].Name = "Trạng thái";


            dtg_show.Rows.Clear();
            var lst = _iLichSuTichDiemServices.GetAll();
            _lstHoaDonViews = _iHoaDonServices.GetAll().Where(c => c.MaHD.ToLower().Contains(tb_timkiem.Text.ToLower())).OrderBy(x=>x.MaHD).ToList();
            //_lstLichSuTichDiem = _iLichSuTichDiemServices.GetAll().Where(x => x.Ma.ToLower().Contains(tb_timkiem.Text.ToLower()) || x.Ten.ToLower().Contains(tb_timkiem.Text.ToLower()) || x.Sdt.ToLower().Contains(tb_timkiem.Text.ToLower())).OrderBy(c => c.Ma).ToList();
            foreach (var item in lst)
            {
                dtg_show.Rows.Add(item.Id, stt++,item.MaHD, item.MaNV, item.TenKH, item.SoDiemDung, item.NgayTichDiem, item.TrangThai == 1 ? "Hoạt động" : "Không hoạt động");
            }
            //AddHeaderCheckBox();
            //HeaderCheckBox.MouseClick += new MouseEventHandler(cbb_loaiKM_MouseClick);
        }


        private void btn_clear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void dtg_show_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.RowIndex >= 0)
            //{
            //    DataGridViewRow r = dtg_show.Rows[e.RowIndex];
            //    _lichSuTichDiemView = _iLichSuTichDiemServices.GetAll().FirstOrDefault(x => x.Id == Guid.Parse(r.Cells[0].Value.ToString()));
            //    tb_sodiemdung.Text =Convert.ToString(_lichSuTichDiemView.SoDiemDung);
            //    dtp_ngaytichdiem.Value =Convert.ToDateTime(_lichSuTichDiemView.NgayTichDiem);
            //    rdb_hd.Checked = _lichSuTichDiemView.TrangThai == 1;
            //    rdb_khd.Checked = _lichSuTichDiemView.TrangThai == 0;
            //}
        }

        CheckBox HeaderCheckBox = null;
        bool IsHeaderCheckBoxClicked = false;

        //private void AddHeaderCheckBox()
        //{
        //    HeaderCheckBox = new CheckBox();
        //    HeaderCheckBox.Size = new Size(15, 15);
        //    this.dtg_show.Controls.Add(HeaderCheckBox);
        //}
        private void HeaderCheckBoxClick(CheckBox checkBox)
        {
            IsHeaderCheckBoxClicked = true;
            foreach (DataGridViewRow row in dtg_show.Rows) ((DataGridViewCheckBoxCell)row.Cells["ckb"]).Value = checkBox.Checked;
            dtg_show.RefreshEdit();
            IsHeaderCheckBoxClicked = false;
        }

        private void cbb_loaiKM_MouseClick(object sender, MouseEventArgs e)
        {
            HeaderCheckBoxClick((CheckBox)sender);
        }

        private void loadLS()
        {
            dtg_show.Rows.Clear();
            int stt = 1;
            foreach (var item in _iLichSuTichDiemServices.GetAll())
            {
                dtg_show.Rows.Add(item.Id, stt++,item.MaHD, item.MaNV, item.TenKH, item.NgayTichDiem, item.SoDiemDung, item.TrangThai);
            }

        }

        private void tb_timkiem_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
