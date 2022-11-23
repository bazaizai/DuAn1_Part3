using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.IServices
{
    public interface INhanVienServices
    {
        string Add(NhanVienView obj);
        string Update(NhanVienView obj);
        string Delete(NhanVienView obj);
        List<NhanVienView> GetAll();
    }
}
