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
    public partial class FrmHoaDon : Form
    {
        IHoaDonServices _iHoaDonServices;
        IChiTietHDServices _iChiTietHDServices;
        HoaDonViews _hoaDonView;
        ChiTietHDView _chiTietHDView;
        List<HoaDonViews> _lstHoaDonViews;
        INhanVienServices _inhanVienServices;
        IKhachHangServices _ikhachHangServices;
        IPtthanhToanServices _iptthanhToanServices;
        IHinhThucMhServices _IHinhThucMhServices;   
        public FrmHoaDon()
        {
            InitializeComponent();
            _iHoaDonServices = new HoaDonServices();
            _iChiTietHDServices = new ChiTietHDServices();
            _hoaDonView = new HoaDonViews();
            _chiTietHDView = new ChiTietHDView();
            _lstHoaDonViews = new List<HoaDonViews>();
            _inhanVienServices = new NhanVienServices();
            _ikhachHangServices = new KhachHangServices();
            _iptthanhToanServices = new PtthanhToanServices();
            _IHinhThucMhServices = new HinhThucMhServices();
            LoadData();
        }

        public void Clear()
        {
            tb_mahd.Text = "";
            tb_manv.Text = "";
            tb_makh.Text = "";
            tb_tenkh.Text = "";
            tb_pttt.Text = "";
            tb_hinhthucmh.Text = "";
            tb_mucuudai.Text = "";
            dtp_ngaytao.Text = "";
            dtp_ngaytt.Text = "";
            tb_giamgia.Text = "";
            tb_hinhthucgiamgia.Text = "";
            tb_tongtien.Text = "";
          
        }

        public void LoadData()
        {
            int stt = 1;
            dtg_show.ColumnCount = 9;
            dtg_show.Columns[0].Name = "Id";
            dtg_show.Columns[0].Visible = false;
            dtg_show.Columns[1].Name = "STT";
            dtg_show.Columns[2].Name = "Mã HĐ";
            dtg_show.Columns[3].Name = "Mã NV";
            dtg_show.Columns[4].Name = "Mã KH";
            dtg_show.Columns[5].Name = "Ngày tạo";
            dtg_show.Columns[6].Name = "Ngày thanh toán";
            dtg_show.Columns[7].Name = "Tổng tiền";
            dtg_show.Columns[8].Name = "Trạng thái";
            dtg_show.Rows.Clear();

            _lstHoaDonViews = _iHoaDonServices.GetAll().Where(x => x.TrangThai != 0 && x.TrangThaiGiaoHang != 2 && x.TrangThaiGiaoHang != 1 && x.TrangThaiGiaoHang != 3).ToList();
            _lstHoaDonViews = _iHoaDonServices.GetAll().Where(x =>( x.MaHD.ToLower().Contains(tb_timkiem.Text.ToLower()) || x.MaNv.ToLower().Contains(tb_timkiem.Text.ToLower()) || x.TenKh.ToLower().Contains(tb_timkiem.Text.ToLower())) && (x.TrangThai != 0 && x.TrangThaiGiaoHang != 2 && x.TrangThaiGiaoHang != 1 && x.TrangThaiGiaoHang != 3)).OrderBy(c => c.MaHD).ToList();

            foreach (var item in _lstHoaDonViews)
            {
                dtg_show.Rows.Add(item.Id, stt++, item.MaHD, item.MaNv, item.MaKh, item.NgayTao, item.NgayThanhToan, item.TongTien, item.TrangThai == 1 ? "Thành công" : "Hủy");
            }
        }

        private void tb_timkiem_TextChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dtg_show_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow r = dtg_show.Rows[e.RowIndex];
                _hoaDonView = _iHoaDonServices.GetAll().FirstOrDefault(x => x.Id == Guid.Parse(r.Cells[0].Value.ToString()));
                tb_mahd.Text = _hoaDonView.MaHD;
                tb_manv.Text = _inhanVienServices.GetAll().FirstOrDefault(c => c.Id == _hoaDonView.IdNv).Ma;
                if (_hoaDonView.IdKh != null)
                {
                    tb_makh.Text = _ikhachHangServices.GetAll().FirstOrDefault(c => c.Id == _hoaDonView.IdKh).Ma;
                    tb_tenkh.Text = _ikhachHangServices.GetAll().FirstOrDefault(c => c.Id == _hoaDonView.IdKh).Ten;

                }
                else
                {
                    tb_makh.Text = "Vãn lai";
                    tb_tenkh.Text = "Khách hàng vãn lai";
                }
                tb_pttt.Text = _iptthanhToanServices.GetAll().FirstOrDefault(c => c.Id == _hoaDonView.IdPttt).Ten;
                tb_hinhthucmh.Text = _IHinhThucMhServices.GetAll().FirstOrDefault(c => c.Id == _hoaDonView.IdHt).Ten;
                tb_mucuudai.Text = Convert.ToDecimal(_hoaDonView.MucUuDai).ToString();
                dtp_ngaytao.Text = Convert.ToDateTime(_hoaDonView.NgayTao).ToString();
                dtp_ngaytt.Text = Convert.ToDateTime(_hoaDonView.NgayThanhToan).ToString();
                tb_giamgia.Text = Convert.ToDecimal(_hoaDonView.GiamGia).ToString();
                tb_hinhthucgiamgia.Text = _hoaDonView.HinhThucGiamGia;
                tb_tongtien.Text = Convert.ToDecimal(_hoaDonView.TongTien).ToString();
                rdb_hd.Checked = _hoaDonView.TrangThai == 1;
                rdb_khd.Checked = _hoaDonView.TrangThai == 2;
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void rdb_hd_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void rdb_khd_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
