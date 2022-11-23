using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.IServices
{
    public interface IChiTietHDServices
    {
        string Add(ChiTietHDView obj);
        string Update(ChiTietHDView obj);
        string Delete(ChiTietHDView obj);
        ChiTietHDView GetID(Guid id);
        List<ChiTietHDView> GetAll();
    }
}
