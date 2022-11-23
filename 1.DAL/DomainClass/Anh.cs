using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace _1.DAL.DomainClass
{
    [Table("Anh")]
    public partial class Anh
    {
        [Key]
        public Guid Id { get; set; }
        public Guid? IdChiTietSp { get; set; }
        [StringLength(30)]
        public string TenAnh { get; set; }
        [Column(TypeName = "image")]
        public byte[] DuongDan { get; set; }
        public int? TrangThai { get; set; }

        [ForeignKey(nameof(IdChiTietSp))]
        [InverseProperty(nameof(ChiTietSp.Anhs))]
        public virtual ChiTietSp IdChiTietSpNavigation { get; set; }
        public Anh(Guid? idChiTietSp, string tenAnh, byte[] duongDan, int? trangThai)
        {
            IdChiTietSp = idChiTietSp;
            TenAnh = tenAnh;
            DuongDan = duongDan;
            TrangThai = trangThai;
        }
    }
}
