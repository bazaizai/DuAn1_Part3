using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace _1.DAL.DomainClass
{
    [Table("TichDiem")]
    public partial class TichDiem
    {
        public TichDiem()
        {
            KhachHangs = new HashSet<KhachHang>();
            LstichDiems = new HashSet<LstichDiem>();
        }

        [Key]
        public Guid Id { get; set; }
        public int? SoDiem { get; set; }
        public int? TrangThai { get; set; }

        [InverseProperty(nameof(KhachHang.IdtichDiemNavigation))]
        public virtual ICollection<KhachHang> KhachHangs { get; set; }
        [InverseProperty(nameof(LstichDiem.IdTichDiemNavigation))]
        public virtual ICollection<LstichDiem> LstichDiems { get; set; }
    }
}
