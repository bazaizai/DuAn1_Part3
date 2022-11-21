using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace _1.DAL.DomainClass
{
    [Table("LSTichDiem")]
    public partial class LstichDiem
    {
        [Key]
        public Guid Id { get; set; }
        public Guid? IdHoaDon { get; set; }
        public Guid? IdTichDiem { get; set; }
        [Column("IdCTTichDiem")]
        public Guid? IdCttichDiem { get; set; }
        [Column(TypeName = "decimal(18, 0)")]
        public decimal? SoDiemDung { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? NgayTichDiem { get; set; }
        public int? TrangThai { get; set; }

        [ForeignKey(nameof(IdCttichDiem))]
        [InverseProperty(nameof(CttichDiem.LstichDiems))]
        public virtual CttichDiem IdCttichDiemNavigation { get; set; }
        [ForeignKey(nameof(IdHoaDon))]
        [InverseProperty(nameof(HoaDon.LstichDiems))]
        public virtual HoaDon IdHoaDonNavigation { get; set; }
        [ForeignKey(nameof(IdTichDiem))]
        [InverseProperty(nameof(TichDiem.LstichDiems))]
        public virtual TichDiem IdTichDiemNavigation { get; set; }
    }
}
