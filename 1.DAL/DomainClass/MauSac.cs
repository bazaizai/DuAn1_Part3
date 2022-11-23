using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace _1.DAL.DomainClass
{
    [Table("MauSac")]
    [Index(nameof(Ma), Name = "UQ__MauSac__3214CC9EFCAA9610", IsUnique = true)]
    public partial class MauSac
    {
        public MauSac()
        {
            ChiTietSps = new HashSet<ChiTietSp>();
        }

        [Key]
        public Guid Id { get; set; }
        [StringLength(20)]
        public string Ma { get; set; }
        [StringLength(30)]
        public string Ten { get; set; }
        public int? TrangThai { get; set; }

        [InverseProperty(nameof(ChiTietSp.IdMauSacNavigation))]
        public virtual ICollection<ChiTietSp> ChiTietSps { get; set; }
    }
}
