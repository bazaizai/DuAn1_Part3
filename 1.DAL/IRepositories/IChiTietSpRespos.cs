using _1.DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.IRepositories
{
    public interface IChiTietSpRespos
    {
        bool Add(ChiTietSp Obj);
        bool Update(ChiTietSp Obj);
        bool Delete(ChiTietSp Obj);
        ChiTietSp GetById(Guid Id);
        List<ChiTietSp> GetAll();
    }
}
