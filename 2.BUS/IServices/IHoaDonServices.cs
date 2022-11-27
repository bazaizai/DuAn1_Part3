using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.IServices
{
    public interface IHoaDonServices
    {
        string Add(HoaDonViews obj);
        string Update(HoaDonViews obj);
        string Delete(HoaDonViews obj);
        HoaDonViews GetID(Guid id);
        List<HoaDonViews> GetAll();
        List<HoaDonViews> LoadJoin();
    }
}
