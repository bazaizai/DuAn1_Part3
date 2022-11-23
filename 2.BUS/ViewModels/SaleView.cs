using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.ViewModels
{
    public class SaleView
    {
        public Guid Id { get; set; }

        public string Ma { get; set; }

        public string Ten { get; set; }

        public DateTime? NgayBatDau { get; set; }

        public DateTime? NgayKetThuc { get; set; }


        public string LoaiHinhKm { get; set; }
        public decimal? MucGiam { get; set; }

        public string MoTa { get; set; }
        public int? TrangThai { get; set; }

    }
}
