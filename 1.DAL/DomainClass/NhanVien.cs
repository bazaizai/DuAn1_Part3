using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace _1.DAL.DomainClass
{
    [Table("NhanVien")]
    [Index(nameof(Ma), Name = "UQ__NhanVien__3214CC9E5CF6BCD3", IsUnique = true)]
    [Index(nameof(Email), Name = "UQ__NhanVien__A9D10534E6EA6CEB", IsUnique = true)]
    [Index(nameof(TaiKhoan), Name = "UQ__NhanVien__D5B8C7F006557263", IsUnique = true)]
    public partial class NhanVien
    {
        public NhanVien()
        {
            HoaDons = new HashSet<HoaDon>();
            KhachHangs = new HashSet<KhachHang>();
        }

        [Key]
        public Guid Id { get; set; }
        [Column("IdCV")]
        public Guid? IdCv { get; set; }
        [StringLength(20)]
        public string Ma { get; set; }
        [StringLength(30)]
        public string Ten { get; set; }
        [StringLength(30)]
        public string TenDem { get; set; }
        [StringLength(30)]
        public string Ho { get; set; }
        [StringLength(10)]
        public string GioiTinh { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? NgaySinh { get; set; }
        [StringLength(100)]
        public string DiaChi { get; set; }
        [StringLength(10)]
        public string Sdt { get; set; }
        [Column("CCCD")]
        [StringLength(12)]
        public string Cccd { get; set; }
        public string MatKhau { get; set; }
        [StringLength(50)]
        public string Email { get; set; }
        [StringLength(30)]
        public string TaiKhoan { get; set; }
        public int? TrangThai { get; set; }

        [ForeignKey(nameof(IdCv))]
        [InverseProperty(nameof(ChucVu.NhanViens))]
        public virtual ChucVu IdCvNavigation { get; set; }
        [InverseProperty(nameof(HoaDon.IdNvNavigation))]
        public virtual ICollection<HoaDon> HoaDons { get; set; }
        [InverseProperty(nameof(KhachHang.IdnvNavigation))]
        public virtual ICollection<KhachHang> KhachHangs { get; set; }
    }
}
