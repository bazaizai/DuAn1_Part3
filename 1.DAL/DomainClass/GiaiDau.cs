using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace _1.DAL.DomainClass
{
    [Table("GiaiDau")]
    [Index(nameof(Ma), Name = "UQ__GiaiDau__3214CC9E27649C1F", IsUnique = true)]
    public partial class GiaiDau
    {
        public GiaiDau()
        {
            Teams = new HashSet<Team>();
        }

        [Key]
        public Guid Id { get; set; }
        [StringLength(20)]
        public string Ma { get; set; }
        [StringLength(30)]
        public string Ten { get; set; }
        public int? TrangThai { get; set; }

        [InverseProperty(nameof(Team.IdGdNavigation))]
        public virtual ICollection<Team> Teams { get; set; }
    }
}
