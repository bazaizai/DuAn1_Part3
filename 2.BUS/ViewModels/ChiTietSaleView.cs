using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics.Contracts;

namespace _2.BUS.ViewModels
{
    public class ChiTietSaleView
    {
        public Guid Id { get; set; }
        public Guid? IdSale { get; set; }

        public Guid? IdChiTietSp { get; set; }

        public string MoTa { get; set; }
        public int? TrangThai { get; set; }
        public string MaSale { get; set; }
        public string TenSanPham { get; set; }
        public Guid? IdSp { get; set; }
        public string TenSale { get; set; }
        public string MauSac { get; set; }
        public string Team { get; set; }


    }
}
