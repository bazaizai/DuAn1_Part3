using _1.DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.IRepositories
{
    public interface IUuDaiTichDiemRepos
    {
        bool Add(UdtichDiem obj);
        bool Update(UdtichDiem obj);
        bool Delete(UdtichDiem obj);
        UdtichDiem GetById(Guid id);
        List<UdtichDiem> GetAll();
    }
}
