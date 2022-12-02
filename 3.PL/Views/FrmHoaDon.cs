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
        public FrmHoaDon()
        {
            InitializeComponent();
            _iHoaDonServices = new HoaDonServices();
            _iChiTietHDServices = new ChiTietHDServices();
            _hoaDonView = new HoaDonViews();
            _chiTietHDView = new ChiTietHDView();
            _lstHoaDonViews = new List<HoaDonViews>();
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
            tb_tienkhachdua.Text = "";
            rdb_hd.Checked = false;
            rdb_khd.Checked = false;
        }

        public void LoadData()
        {
            int stt = 1;
            dtg_show.ColumnCount = 17;
            dtg_show.Columns[0].Name = "Id";
            dtg_show.Columns[0].Visible = false;
            dtg_show.Columns[1].Name = "STT";
            dtg_show.Columns[2].Name = "Mã HĐ";
            dtg_show.Columns[3].Name = "Mã NV";
            dtg_show.Columns[4].Name = "Mã KH";
            dtg_show.Columns[5].Name = "Tên KH";
            dtg_show.Columns[6].Name = "Phương thức thanh toán";
            dtg_show.Columns[7].Name = "Hình thức mua hàng";
            dtg_show.Columns[8].Name = "Mức ưu đãi";
            dtg_show.Columns[9].Name = "Ngày tạo";
            dtg_show.Columns[10].Name = "Ngày thanh toán";
            dtg_show.Columns[11].Name = "Giảm giá";
            dtg_show.Columns[12].Name = "Hình thức giảm giá";
            dtg_show.Columns[13].Name = "Tổng tiền";
            dtg_show.Columns[14].Name = "Tiền khách đưa";
            dtg_show.Columns[15].Name = "Trạng thái";
            dtg_show.Rows.Clear();

            tb_mahd.Enabled = false;
            tb_manv.Enabled = false;
            tb_makh.Enabled = false;
            tb_tenkh.Enabled = false;
            tb_pttt.Enabled = false;
            tb_hinhthucmh.Enabled = false;
            tb_mucuudai.Enabled = false;
            dtp_ngaytao.Enabled = false;
            dtp_ngaytt.Enabled = false;
            tb_giamgia.Enabled = false;
            tb_hinhthucgiamgia.Enabled = false;
            tb_tongtien.Enabled = false;
            tb_tienkhachdua.Enabled = false;
            rdb_hd.Enabled = false;
            rdb_khd.Enabled = false;

            _lstHoaDonViews = _iHoaDonServices.GetAll().Where(x => x.TrangThai != 0 && x.TrangThaiGiaoHang != 2 && x.TrangThai != 1).ToList();
            _lstHoaDonViews = _iHoaDonServices.GetAll().Where(x =>( x.MaHD.ToLower().Contains(tb_timkiem.Text.ToLower()) || x.MaNv.ToLower().Contains(tb_timkiem.Text.ToLower()) || x.TenKh.ToLower().Contains(tb_timkiem.Text.ToLower())) && (x.TrangThai != 0 && x.TrangThaiGiaoHang != 2 && x.TrangThai != 1)).OrderBy(c => c.MaHD).ToList();

            foreach (var item in _lstHoaDonViews)
            {
                dtg_show.Rows.Add(item.Id, stt++, item.MaHD, item.MaNv, item.MaKh, item.TenKh, item.TenPttt, item.TenHt, item.MucUuDai, item.NgayTao, item.NgayThanhToan, item.GiamGia, item.HinhThucGiamGia, item.TongTien , item.TienKhachDua, item.TrangThai == 0 ? "Hoạt động" : "Không hoạt động");
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
                tb_manv.Text = _hoaDonView.MaNv;
                tb_makh.Text = _hoaDonView.MaKh;
                tb_tenkh.Text = _hoaDonView.TenKh;
                tb_pttt.Text = _hoaDonView.TenPttt;
                tb_hinhthucmh.Text = _hoaDonView.TenHt;
                tb_mucuudai.Text = Convert.ToDecimal(_hoaDonView.MucUuDai).ToString();
                dtp_ngaytao.Text = Convert.ToDateTime(_hoaDonView.NgayTao).ToString();
                dtp_ngaytt.Text = Convert.ToDateTime(_hoaDonView.NgayThanhToan).ToString();
                tb_giamgia.Text = Convert.ToDecimal(_hoaDonView.GiamGia).ToString();
                tb_hinhthucgiamgia.Text = _hoaDonView.HinhThucGiamGia;
                tb_tongtien.Text = Convert.ToDecimal(_hoaDonView.TongTien).ToString();
                tb_tienkhachdua.Text = Convert.ToDecimal(_hoaDonView.TienKhachDua).ToString();
                rdb_hd.Checked = _hoaDonView.TrangThai == 0;
                rdb_khd.Checked = _hoaDonView.TrangThai == 1;
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}
