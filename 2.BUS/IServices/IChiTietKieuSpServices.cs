using _1.DAL.DomainClass;
using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.IServices
{
    public interface IChiTietKieuSpViewService
    {
        string Add(ChiTietKieuSpViews Obj);
        string Update(ChiTietKieuSpViews Obj);
        string Delete(ChiTietKieuSpViews Obj);
        ChiTietKieuSpViews GetById(Guid Id);
        List<ChiTietKieuSpViews> GetAll();
    }
}
