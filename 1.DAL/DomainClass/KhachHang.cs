using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace _1.DAL.DomainClass
{
    [Table("KhachHang")]
    [Index(nameof(Ma), Name = "UQ__KhachHan__3214CC9E035E0BB0", IsUnique = true)]
    public partial class KhachHang
    {
        public KhachHang()
        {
            HoaDons = new HashSet<HoaDon>();
        }

        [Key]
        public Guid Id { get; set; }
        [Column("IDTichDiem")]
        public Guid? IdtichDiem { get; set; }
        [StringLength(20)]
        public string Ma { get; set; }
        [StringLength(100)]
        public string Ten { get; set; }
        [StringLength(10)]
        public string Sdt { get; set; }
        [StringLength(500)]
        public string DiaChi { get; set; }
        public int? TrangThai { get; set; }

        [ForeignKey(nameof(IdtichDiem))]
        [InverseProperty(nameof(TichDiem.KhachHangs))]
        public virtual TichDiem IdtichDiemNavigation { get; set; }
        [InverseProperty(nameof(HoaDon.IdKhNavigation))]
        public virtual ICollection<HoaDon> HoaDons { get; set; }
    }
}
