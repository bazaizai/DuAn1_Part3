using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.ViewModels
{
    public class KhachHangView
    {
        public Guid Id { get; set; }
        public Guid? Idnv { get; set; }
        public Guid? IdtichDiem { get; set; }
        public int? SoDiem { get; set; }
        public string Ma { get; set; }
        public string Ten { get; set; }
        public string Sdt { get; set; }
        public string NhaMang { get; set; }
        public string DiaChi { get; set; }
        public int? TrangThai { get; set; }
    }
}
