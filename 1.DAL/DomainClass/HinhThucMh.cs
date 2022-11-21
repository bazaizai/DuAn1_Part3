using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace _1.DAL.DomainClass
{
    [Table("HinhThucMH")]
    [Index(nameof(Ma), Name = "UQ__HinhThuc__3214CC9E9689EB7B", IsUnique = true)]
    public partial class HinhThucMh
    {
        public HinhThucMh()
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

        [InverseProperty(nameof(HoaDon.IdHtNavigation))]
        public virtual ICollection<HoaDon> HoaDons { get; set; }
    }
}
