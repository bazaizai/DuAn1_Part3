using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.ViewModels
{
    public class LichSuTichDiemView
    {
        public Guid Id { get; set; }
        public Guid? IdHoaDon { get; set; }
        public Guid? IdTichDiem { get; set; }
        public Guid? IdCttichDiem { get; set; }
        public decimal? SoDiemDung { get; set; }
        public DateTime? NgayTichDiem { get; set; }
        public int? TrangThai { get; set; }
        public string TenKH { get; set; }
        public string MaNV { get; set; }
        public string MaHD { get; set; }
    }
}
