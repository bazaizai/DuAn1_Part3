using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace _1.DAL.DomainClass
{
    [Table("Team")]
    [Index(nameof(Ma), Name = "UQ__Team__3214CC9E25A2EFAF", IsUnique = true)]
    public partial class Team
    {
        public Team()
        {
            ChiTietSps = new HashSet<ChiTietSp>();
        }

        [Key]
        public Guid Id { get; set; }
        [Column("IdGD")]
        public Guid? IdGd { get; set; }
        [StringLength(20)]
        public string Ma { get; set; }
        [StringLength(30)]
        public string Ten { get; set; }
        public int? TrangThai { get; set; }

        [ForeignKey(nameof(IdGd))]
        [InverseProperty(nameof(GiaiDau.Teams))]
        public virtual GiaiDau IdGdNavigation { get; set; }
        [InverseProperty(nameof(ChiTietSp.IdTeamNavigation))]
        public virtual ICollection<ChiTietSp> ChiTietSps { get; set; }
    }
}
