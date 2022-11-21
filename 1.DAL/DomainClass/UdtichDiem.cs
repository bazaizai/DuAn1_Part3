using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace _1.DAL.DomainClass
{
    [Table("UDTichDiem")]
    [Index(nameof(Ma), Name = "UQ__UDTichDi__3214CC9EACC61D9F", IsUnique = true)]
    public partial class UdtichDiem
    {
        public UdtichDiem()
        {
            HoaDons = new HashSet<HoaDon>();
        }

        [Key]
        public Guid Id { get; set; }
        [StringLength(20)]
        public string Ma { get; set; }
        [Column("LoaiHinhKM")]
        [StringLength(30)]
        public string LoaiHinhKm { get; set; }
        [Column(TypeName = "decimal(18, 0)")]
        public decimal? MucUuDai { get; set; }
        [Column(TypeName = "decimal(18, 0)")]
        public decimal? SoDiem { get; set; }
        public int? TrangThai { get; set; }

        [InverseProperty(nameof(HoaDon.IdUdtichDiemNavigation))]
        public virtual ICollection<HoaDon> HoaDons { get; set; }
    }
}
