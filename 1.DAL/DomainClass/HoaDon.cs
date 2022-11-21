using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace _1.DAL.DomainClass
{
    [Table("HoaDon")]
    [Index(nameof(Ma), Name = "UQ__HoaDon__3214CC9EECE902C2", IsUnique = true)]
    public partial class HoaDon
    {
        public HoaDon()
        {
            HoaDonChiTiets = new HashSet<HoaDonChiTiet>();
            LstichDiems = new HashSet<LstichDiem>();
        }

        [Key]
        public Guid Id { get; set; }
        [Column("IdKH")]
        public Guid? IdKh { get; set; }
        [Column("IdNVT")]
        public Guid? IdNvt { get; set; }
        [Column("IdNVTT")]
        public Guid? IdNvtt { get; set; }
        [Column("IdPTTT")]
        public Guid? IdPttt { get; set; }
        [Column("IdHT")]
        public Guid? IdHt { get; set; }
        [Column("IdUDTichDiem")]
        public Guid? IdUdtichDiem { get; set; }
        [StringLength(20)]
        public string Ma { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? NgayTao { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? NgayThanhToan { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? NgayShip { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? NgayNhan { get; set; }
        [StringLength(50)]
        public string TenNguoiNhan { get; set; }
        [StringLength(100)]
        public string DiaChi { get; set; }
        [StringLength(10)]
        public string Sdt { get; set; }
        [Column(TypeName = "decimal(18, 0)")]
        public decimal? GiamGia { get; set; }
        [StringLength(30)]
        public string HinhThucGiamGia { get; set; }
        [Column(TypeName = "decimal(18, 0)")]
        public decimal? TongTien { get; set; }
        [Column(TypeName = "decimal(18, 0)")]
        public decimal? SoTienGiam { get; set; }
        [Column(TypeName = "decimal(18, 0)")]
        public decimal? TienKhachDua { get; set; }
        [Column(TypeName = "decimal(18, 0)")]
        public decimal? TienChuyenKhoan { get; set; }
        [Column(TypeName = "decimal(18, 0)")]
        public decimal? TienShip { get; set; }
        [StringLength(50)]
        public string MoTa { get; set; }
        public int? TrangThai { get; set; }
        public int? TrangThaiGiaoHang { get; set; }

        [ForeignKey(nameof(IdHt))]
        [InverseProperty(nameof(HinhThucMh.HoaDons))]
        public virtual HinhThucMh IdHtNavigation { get; set; }
        [ForeignKey(nameof(IdKh))]
        [InverseProperty(nameof(KhachHang.HoaDons))]
        public virtual KhachHang IdKhNavigation { get; set; }
        [ForeignKey(nameof(IdNvt))]
        [InverseProperty(nameof(NhanVien.HoaDonIdNvtNavigations))]
        public virtual NhanVien IdNvtNavigation { get; set; }
        [ForeignKey(nameof(IdNvtt))]
        [InverseProperty(nameof(NhanVien.HoaDonIdNvttNavigations))]
        public virtual NhanVien IdNvttNavigation { get; set; }
        [ForeignKey(nameof(IdPttt))]
        [InverseProperty(nameof(PtthanhToan.HoaDons))]
        public virtual PtthanhToan IdPtttNavigation { get; set; }
        [ForeignKey(nameof(IdUdtichDiem))]
        [InverseProperty(nameof(UdtichDiem.HoaDons))]
        public virtual UdtichDiem IdUdtichDiemNavigation { get; set; }
        [InverseProperty(nameof(HoaDonChiTiet.IdHoaDonNavigation))]
        public virtual ICollection<HoaDonChiTiet> HoaDonChiTiets { get; set; }
        [InverseProperty(nameof(LstichDiem.IdHoaDonNavigation))]
        public virtual ICollection<LstichDiem> LstichDiems { get; set; }
    }
}
