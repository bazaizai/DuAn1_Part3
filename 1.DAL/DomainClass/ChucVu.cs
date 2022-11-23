using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace _1.DAL.DomainClass
{
    [Table("ChucVu")]
    [Index(nameof(Ma), Name = "UQ__ChucVu__3214CC9EC28D9F1A", IsUnique = true)]
    public partial class ChucVu
    {
        public ChucVu()
        {
            NhanViens = new HashSet<NhanVien>();
        }

        [Key]
        public Guid Id { get; set; }
        [StringLength(20)]
        public string Ma { get; set; }
        [StringLength(50)]
        public string Ten { get; set; }
        public int? TrangThai { get; set; }

        [InverseProperty(nameof(NhanVien.IdCvNavigation))]
        public virtual ICollection<NhanVien> NhanViens { get; set; }
    }
}
