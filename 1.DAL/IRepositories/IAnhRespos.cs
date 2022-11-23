using _1.DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.IRepositories
{
    public interface IAnhRespos
    {
        bool Add(Anh Obj);
        bool Update(Anh Obj);
        bool Delete(Anh Obj);
        Anh GetById(Guid Id);
        List<Anh> GetAll();
    }
}
