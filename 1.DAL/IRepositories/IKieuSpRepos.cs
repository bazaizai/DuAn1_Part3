using _1.DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.IRepositories
{
    public interface IKieuSpRepos
    {
        bool Add(KieuSp Obj);
        bool Update(KieuSp Obj);
        bool Delete(KieuSp Obj);
        KieuSp GetById(Guid Id);
        List<KieuSp> GetAll();
    }
}
