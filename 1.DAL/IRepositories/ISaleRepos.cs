using _1.DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.IRepositories
{
    public interface ISaleRepos
    {
        bool Add(Sale obj);
        bool Update(Sale obj);
        bool Delete(Sale obj);

        Sale GetByI(Guid id);
        List<Sale> GetAll();
    }
}
