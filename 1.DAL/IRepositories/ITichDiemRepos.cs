using _1.DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.IRepositories
{
    public interface ITichDiemRepos
    {
        bool Add(TichDiem obj);
        bool Update(TichDiem obj);
        bool Delete(TichDiem obj);
        TichDiem GetById(Guid id);
        List<TichDiem> GetAll();
    }
}
