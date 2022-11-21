using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace _1.DAL.DomainClass
{
    [Table("KichCo")]
    [Index(nameof(Ma), Name = "UQ__KichCo__3214CC9EC4813A2D", IsUnique = true)]
    public partial class KichCo
    {
        public KichCo()
        {
            ChiTietSps = new HashSet<ChiTietSp>();
        }

        [Key]
        public Guid Id { get; set; }
        [StringLength(20)]
        public string Ma { get; set; }
        [StringLength(30)]
        public string Size { get; set; }
        [Column("CM", TypeName = "decimal(18, 0)")]
        public decimal? Cm { get; set; }
        public int? TrangThai { get; set; }

        [InverseProperty(nameof(ChiTietSp.IdKichCoNavigation))]
        public virtual ICollection<ChiTietSp> ChiTietSps { get; set; }
    }
}
