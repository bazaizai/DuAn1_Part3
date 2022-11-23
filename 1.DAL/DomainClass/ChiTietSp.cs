using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace _1.DAL.DomainClass
{
    [Table("ChiTietSP")]
    public partial class ChiTietSp
    {
        public ChiTietSp()
        {
            Anhs = new HashSet<Anh>();
            ChiTietKieuSps = new HashSet<ChiTietKieuSp>();
            ChiTietSales = new HashSet<ChiTietSale>();
            HoaDonChiTiets = new HashSet<HoaDonChiTiet>();
        }

        [Key]
        public Guid Id { get; set; }
        [Column("IdSP")]
        public Guid? IdSp { get; set; }
        public Guid? IdMauSac { get; set; }
        public Guid? IdKichCo { get; set; }
        public Guid? IdTeam { get; set; }
        public Guid? IdChatLieu { get; set; }
        [Column("MaQR")]
        [StringLength(20)]
        public string MaQr { get; set; }
        [StringLength(50)]
        public string BaoHanh { get; set; }
        [StringLength(50)]
        public string MoTa { get; set; }
        public int? SoLuongTon { get; set; }
        [Column(TypeName = "decimal(18, 0)")]
        public decimal? GiaNhap { get; set; }
        [Column(TypeName = "decimal(18, 0)")]
        public decimal? GiaBan { get; set; }
        public int? TrangThaiKhuyenMai { get; set; }
        public int? TrangThai { get; set; }

        [ForeignKey(nameof(IdChatLieu))]
        [InverseProperty(nameof(ChatLieu.ChiTietSps))]
        public virtual ChatLieu IdChatLieuNavigation { get; set; }
        [ForeignKey(nameof(IdKichCo))]
        [InverseProperty(nameof(KichCo.ChiTietSps))]
        public virtual KichCo IdKichCoNavigation { get; set; }
        [ForeignKey(nameof(IdMauSac))]
        [InverseProperty(nameof(MauSac.ChiTietSps))]
        public virtual MauSac IdMauSacNavigation { get; set; }
        [ForeignKey(nameof(IdSp))]
        [InverseProperty(nameof(SanPham.ChiTietSps))]
        public virtual SanPham IdSpNavigation { get; set; }
        [ForeignKey(nameof(IdTeam))]
        [InverseProperty(nameof(Team.ChiTietSps))]
        public virtual Team IdTeamNavigation { get; set; }
        [InverseProperty(nameof(Anh.IdChiTietSpNavigation))]
        public virtual ICollection<Anh> Anhs { get; set; }
        [InverseProperty(nameof(ChiTietKieuSp.IdChiTietSpNavigation))]
        public virtual ICollection<ChiTietKieuSp> ChiTietKieuSps { get; set; }
        [InverseProperty(nameof(ChiTietSale.IdChiTietSpNavigation))]
        public virtual ICollection<ChiTietSale> ChiTietSales { get; set; }
        [InverseProperty(nameof(HoaDonChiTiet.IdChiTietSpNavigation))]
        public virtual ICollection<HoaDonChiTiet> HoaDonChiTiets { get; set; }

        public ChiTietSp(Guid id, Guid? idSp, Guid? idMauSac, Guid? idKichCo, Guid? idTeam, Guid? idChatLieu, string maQr, string baoHanh, string moTa, int? soLuongTon, decimal? giaNhap, decimal? giaBan, int? trangThaiKhuyenMai, int? trangThai)
        {
            Id = id;
            IdSp = idSp;
            IdMauSac = idMauSac;
            IdKichCo = idKichCo;
            IdTeam = idTeam;
            IdChatLieu = idChatLieu;
            MaQr = maQr;
            BaoHanh = baoHanh;
            MoTa = moTa;
            SoLuongTon = soLuongTon;
            GiaNhap = giaNhap;
            GiaBan = giaBan;
            TrangThaiKhuyenMai = trangThaiKhuyenMai;
            TrangThai = trangThai;
        }
    }
}
