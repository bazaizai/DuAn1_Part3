
using _2.BUS.IServices;
using _2.BUS.Services;
using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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
        IKhachHangServices _ikhachHangServices;


        public FrmLichSuTichDiem()
        {
            InitializeComponent();
            _iLichSuTichDiemServices = new LichSuTichDiemServices();
            _iHoaDonServices = new HoaDonServices();
            _iTichDiemServices = new TichDiemServices();
            _iCongThucTichDiemServices = new CtTichDiemServices();
            _ikhachHangServices = new KhachHangServices();
            LoadData();
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
            dtg_show.Columns[5].Name = "Số điểm thêm";
            dtg_show.Columns[6].Name = "Ngày tích điểm";
            dtg_show.Columns[7].Name = "Trạng thái";
            dtg_show.Rows.Clear();
            var lst = _iLichSuTichDiemServices.GetAll();
            if (tb_timkiem.Text != "")
            {
                lst = lst.Where(x => x.TenKH.ToLower().Contains(tb_timkiem.Text.ToLower())).ToList();
            }
            foreach (var item in lst)
            {
                var lhd = _iHoaDonServices.GetAll().Find(c => c.Id == item.IdHoaDon);
                var kh = _ikhachHangServices.GetByID(lhd.IdKh.GetValueOrDefault());
                dtg_show.Rows.Add(item.Id, stt++, lhd == null ? "Không có thông tin" : lhd.MaHD, lhd == null ? "Không có thông tin" : lhd.MaNv, kh == null ? "Không có thông tin" : kh.Ten, item.SoDiemDung, item.NgayTichDiem?.ToString("dd/M/yyyy", CultureInfo.InvariantCulture), item.TrangThai == 0 ? "Hoạt động" : "Không hoạt động");
            }
        }

        private void tb_timkiem_TextChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dtg_show_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
