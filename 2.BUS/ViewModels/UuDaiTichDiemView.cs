using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.ViewModels
{
    public class UuDaiTichDiemView
    {
        public Guid Id { get; set; }

        public string Ma { get; set; }

        public string LoaiHinhKm { get; set; }

        public decimal? MucUuDai { get; set; }
        public decimal? SoDiem { get; set; }
        public int? TrangThai { get; set; }
    }
}
