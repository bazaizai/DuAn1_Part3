using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace _1.DAL.DomainClass
{
    [Table("ChatLieu")]
    [Index(nameof(Ma), Name = "UQ__ChatLieu__3214CC9EF6F76785", IsUnique = true)]
    public partial class ChatLieu
    {
        public ChatLieu()
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

        [InverseProperty(nameof(ChiTietSp.IdChatLieuNavigation))]
        public virtual ICollection<ChiTietSp> ChiTietSps { get; set; }
    }
}
