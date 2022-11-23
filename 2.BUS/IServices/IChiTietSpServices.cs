using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.IServices
{
    public interface IChiTietSpServices
    {
        bool Add(ChiTietSpViews Obj);
        bool Update(ChiTietSpViews Obj);
        bool Delete(ChiTietSpViews Obj);
        ChiTietSpViews GetById(Guid Id);
        List<ChiTietSpViews> GetAll();
    }
}
