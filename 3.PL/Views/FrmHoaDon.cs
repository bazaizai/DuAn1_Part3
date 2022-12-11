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
using System.Windows.Controls.Primitives;
using System.Windows.Controls;
using System.Windows.Forms;
using _1.DAL.DomainClass;

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
        IUuDaiTichDiemServices _IUuDaiTichDiemServices;
        public Guid _IdHD;
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
            _IUuDaiTichDiemServices = new UuDaiTichDiemServices();
            LoadData();

        }

        public void Clear()
        {
            tb_mahd1.Text = "";
            tb_manv.Text = "";
            tb_makh.Text = "";
            tb_tenkh.Text = "";
            tb_pttt.Text = "";
            tb_mucuudai.Text = "";
            dtp_ngaytao.Text = "";
            dtp_ngaytt.Text = "";
            tb_giamgia.Text = "";
            tb_giamgia.Text = "";
            tb_hinhthucgiamgia.Text = "";
            tb_TongTien.Text = "";

        }
        public static string RemoveUnicode(string text)
        {
            string[] arr1 = new string[] { "á", "à", "ả", "ã", "ạ", "â", "ấ", "ầ", "ẩ", "ẫ", "ậ", "ă", "ắ", "ằ", "ẳ", "ẵ", "ặ",
    "đ",
    "é","è","ẻ","ẽ","ẹ","ê","ế","ề","ể","ễ","ệ",
    "í","ì","ỉ","ĩ","ị",
    "ó","ò","ỏ","õ","ọ","ô","ố","ồ","ổ","ỗ","ộ","ơ","ớ","ờ","ở","ỡ","ợ",
    "ú","ù","ủ","ũ","ụ","ư","ứ","ừ","ử","ữ","ự",
    "ý","ỳ","ỷ","ỹ","ỵ",};
            string[] arr2 = new string[] { "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a",
    "d",
    "e","e","e","e","e","e","e","e","e","e","e",
    "i","i","i","i","i",
    "o","o","o","o","o","o","o","o","o","o","o","o","o","o","o","o","o",
    "u","u","u","u","u","u","u","u","u","u","u",
    "y","y","y","y","y",};
            for (int i = 0; i < arr1.Length; i++)
            {
                text = text.Replace(arr1[i], arr2[i]);
                text = text.Replace(arr1[i].ToUpper(), arr2[i].ToUpper());
            }
            return text;
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
            _lstHoaDonViews = _iHoaDonServices.GetAll().Where(x => (x.TrangThai == 1 && x.TrangThaiGiaoHang == 0) || (x.TrangThai == 3 && x.TrangThaiGiaoHang == 0) || (x.TrangThai == 3 && x.TrangThaiGiaoHang == 5) || (x.TrangThai == 1 && x.TrangThaiGiaoHang == 4)).OrderByDescending(x=>x.MaHD).OrderByDescending(x=>x.MaHD.Length).ToList();
            if (tb_timkiem.Text.Trim() != "")
            {
                _lstHoaDonViews = _lstHoaDonViews.Where(x => RemoveUnicode(x.MaHD.ToLower()).Contains(RemoveUnicode(tb_timkiem.Text.ToLower()))|| RemoveUnicode(x.MaNv.ToLower()).Contains(RemoveUnicode(tb_timkiem.Text.ToLower()))).ToList();
            }
            foreach (var item in _lstHoaDonViews)
            {
                dtg_show.Rows.Add(item.Id, stt++, item.MaHD, item.MaNv, _ikhachHangServices.GetAll().Find(x => x.Id == item.IdKh) == null ? "No information" : _ikhachHangServices.GetAll().Find(x => x.Id == item.IdKh).Ma, item.NgayTao?.ToString("dd/M/yyyy", CultureInfo.InvariantCulture), item.NgayThanhToan == null?"No information": item.NgayThanhToan?.ToString("dd/M/yyyy", CultureInfo.InvariantCulture), item.TongTien==0?"No information": double.Parse(item.TongTien.ToString()).ToString("#,###", CultureInfo.GetCultureInfo("vi-VN").NumberFormat) + "đ", item.TrangThai == 1 ? "Thành công" : "Hủy");
            }
        }

        private string Cell(int x) => dtg_show.CurrentRow.Cells[x].Value.ToString();

        private void tb_timkiem_TextChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dtg_show_CellClick(object sender, DataGridViewCellEventArgs e)
        {

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

        private void dtg_show_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtg_show_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
           
            if (e.RowIndex >= 0)
            {
                _IdHD = Guid.Parse(Cell(0));
                var hoaDon = _iHoaDonServices.GetAll().Find(x => x.Id == _IdHD);
                DataGridViewRow r = dtg_show.Rows[e.RowIndex];
                _hoaDonView = _iHoaDonServices.GetAll().FirstOrDefault(x => x.Id == Guid.Parse(r.Cells[0].Value.ToString()));
                tb_mahd1.Text = _hoaDonView.MaHD;
                tb_manv.Text = _inhanVienServices.GetAll().FirstOrDefault(c => c.Id == _hoaDonView.IdNv).Ma;
                if (_hoaDonView.IdKh != null)
                {
                    tb_makh.Text = _ikhachHangServices.GetAll().FirstOrDefault(c => c.Id == _hoaDonView.IdKh).Ma;
                    tb_tenkh.Text = _ikhachHangServices.GetAll().FirstOrDefault(c => c.Id == _hoaDonView.IdKh).Ten;
                }
                else
                {
                    tb_makh.Text = "No information";
                    tb_tenkh.Text = "Khách hàng vãng lai";
                }
                tb_pttt.Text = _iptthanhToanServices.GetAll().FirstOrDefault(c => c.Id == _hoaDonView.IdPttt) == null ? "No information" : _iptthanhToanServices.GetAll().FirstOrDefault(c => c.Id == _hoaDonView.IdPttt).Ten;
                tb_mucuudai.Text = GetUuDai()== null ? "Chưa có ưu đãi" : GetUuDai().MucUuDai.ToString() + GetUuDai().LoaiHinhKm;
                dtp_ngaytao.Text = Convert.ToDateTime(_hoaDonView.NgayTao).ToString("dd/M/yyyy", CultureInfo.InvariantCulture);

                if (_hoaDonView.NgayThanhToan == null)
                {
                    dtp_ngaytt.Text = "No information";
                }
                else
                {
                    dtp_ngaytt.Text = Convert.ToDateTime(_hoaDonView.NgayThanhToan).ToString("dd/M/yyyy", CultureInfo.InvariantCulture);
                }
                if (hoaDon.TrangThai == 3)
                {
                    tb_HinhThucMuaHang.Text = "No information";
                    tb_hinhthucgiamgia.Text = "No information";
                    tb_TongTien.Text = "No information";
                }
                else if(hoaDon.TrangThai == 1)
                {
                    tb_HinhThucMuaHang.Text = _IHinhThucMhServices.GetAll().Find(x => x.Id == _hoaDonView.IdHt).Ten;
                    tb_TongTien.Text = double.Parse(_hoaDonView.TongTien.ToString()).ToString("#,###", CultureInfo.GetCultureInfo("vi-VN").NumberFormat) + "đ";
                    tb_hinhthucgiamgia.Text = _hoaDonView.HinhThucGiamGia;
                }
                tb_giamgia.Text = Convert.ToDecimal(_hoaDonView.GiamGia).ToString();
                tb_TrangThai.Text = _hoaDonView.TrangThai == 1 ? "Thành công" : "Hủy";
                tbGhiChu.Text = hoaDon.MoTa;
                
            }
        }
        private UuDaiTichDiemView GetUuDai()
        {
            var hoaDon = _iHoaDonServices.GetAll().Find(x => x.Id == _IdHD);
            if (hoaDon.IdKh != null)
            {
                var Obj = _IUuDaiTichDiemServices.GetAll().Where(x => x.TrangThai == 1).ToList();
                if (Obj.Count < 1)
                {
                    return null;
                }
                else
                {
                    int d = 0;
                    foreach (var x in Obj)
                    {
                        if (_ikhachHangServices.GetAll().Find(x=>x.Id == hoaDon.IdKh).SoDiem >= x.SoDiem && d <= x.SoDiem)
                        {
                            d = Convert.ToInt32(x.SoDiem);
                        }
                    }
                    if (d == 0)
                    {
                        return null;
                    }
                    else
                    {
                        return _IUuDaiTichDiemServices.GetAll().Find(x => x.SoDiem == d);
                    }
                }
            }
            else
                return null;
        }

        private void tb_timkiem_TextChanged_1(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
