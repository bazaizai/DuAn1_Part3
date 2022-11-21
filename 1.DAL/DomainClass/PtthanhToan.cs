using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace _1.DAL.DomainClass
{
    [Table("PTThanhToan")]
    [Index(nameof(Ma), Name = "UQ__PTThanhT__3214CC9E5A50C68E", IsUnique = true)]
    public partial class PtthanhToan
    {
        public PtthanhToan()
        {
            HoaDons = new HashSet<HoaDon>();
        }

        [Key]
        public Guid Id { get; set; }
        [StringLength(20)]
        public string Ma { get; set; }
        [StringLength(50)]
        public string Ten { get; set; }
        public int? TrangThai { get; set; }

        [InverseProperty(nameof(HoaDon.IdPtttNavigation))]
        public virtual ICollection<HoaDon> HoaDons { get; set; }
    }
}
