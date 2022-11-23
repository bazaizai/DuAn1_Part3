using _1.DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.IRepositories
{
    public interface ICtTichDiemRepos
    {
        bool Add(CttichDiem obj);
        bool Update(CttichDiem obj);
        bool Delete(CttichDiem obj);
        CttichDiem GetById(Guid id);
        List<CttichDiem> GetAll();
    }
}
