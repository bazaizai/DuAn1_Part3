using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.ViewModels
{
    public class ChiTietHDView
    {
        public Guid Id { get; set; }
        public Guid? IdHoaDon { get; set; }
        public string MaHD { get; set; }
        public Guid? IdChiTietSp { get; set; }
        public Guid? IdSp { get; set; }
        public decimal? GiaBan { get; set; }
        public string TenSP { get; set; }
        public int? SoLuong { get; set; }
        public decimal? DonGia { get; set; }
        public int? TrangThai { get; set; }

    }
}
