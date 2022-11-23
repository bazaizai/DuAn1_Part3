using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.ViewModels
{
    public class HoaDonViews
    {
        public Guid Id { get; set; }
        public Guid? IdKh { get; set; }
        public Guid? IdtichDiem { get; set; }
        public string MaKh { get; set; }
        public int? SoDiemKH { get; set; }
        public string TenKh { get; set; }
        public Guid? IdNv { get; set; }
        public string MaNv { get; set; }
        public string TenNv { get; set; }
        public string TenDemNv { get; set; }
        public string HoNv { get; set; }
        public Guid? IdPttt { get; set; }
        public string MaPttt { get; set; }
        public string TenPttt { get; set; }
        public Guid? IdHt { get; set; }
        public string MaHt { get; set; }
        public string TenHt { get; set; }
        public Guid? IdUD { get; set; }
        public string MaUD { get; set; }
        public string LoaiHinhKm { get; set; }
        public decimal? MucUuDai { get; set; }
        public decimal? SoDiemUD { get; set; }
        public string MaHD { get; set; }
        public DateTime? NgayTao { get; set; }
        public DateTime? NgayThanhToan { get; set; }
        public DateTime? NgayShip { get; set; }
        public DateTime? NgayNhan { get; set; }
        public string TenNguoiNhan { get; set; }
        public string DiaChiNhan { get; set; }
        public string SdtNhanHang { get; set; }
        public decimal? GiamGia { get; set; }
        public string HinhThucGiamGia { get; set; }
        public string MoTa { get; set; }
        public decimal? TongTien { get; set; }
        public decimal? SoTienGiam { get; set; }
        public decimal? TongTienSauKhiGiam { get; set; }
        public decimal? TienKhachDua { get; set; }
        public decimal? TienChuyenKhoan { get; set; }
        public decimal? TienShip { get; set; }
        public decimal? Cod { get; set; }
        public int? TrangThaiGiaoHang { get; set; }
        public int? TrangThai { get; set; }
    }
}
