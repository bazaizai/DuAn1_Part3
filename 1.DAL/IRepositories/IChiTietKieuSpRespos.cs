using _1.DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.IRepositories
{
    public interface IChiTietKieuSpRespos
    {
        bool Add(ChiTietKieuSp Obj);
        bool Update(ChiTietKieuSp Obj);
        bool Delete(ChiTietKieuSp Obj);
        ChiTietKieuSp GetById(Guid Id);
        List<ChiTietKieuSp> GetAll();
    }
}
