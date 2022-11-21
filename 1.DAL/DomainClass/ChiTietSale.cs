using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace _1.DAL.DomainClass
{
    [Table("ChiTietSale")]
    public partial class ChiTietSale
    {
        [Key]
        public Guid Id { get; set; }
        public Guid? IdSale { get; set; }
        [Column("IdChiTietSP")]
        public Guid? IdChiTietSp { get; set; }
        [StringLength(50)]
        public string MoTa { get; set; }
        public int? TrangThai { get; set; }

        [ForeignKey(nameof(IdChiTietSp))]
        [InverseProperty(nameof(ChiTietSp.ChiTietSales))]
        public virtual ChiTietSp IdChiTietSpNavigation { get; set; }
        [ForeignKey(nameof(IdSale))]
        [InverseProperty(nameof(Sale.ChiTietSales))]
        public virtual Sale IdSaleNavigation { get; set; }
    }
}
