using _1.DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.IRepositories
{
    public interface IGiaiDauRepos
    {
        bool Add(GiaiDau obj);
        bool Update(GiaiDau obj);
        bool Delete(GiaiDau obj);

        GiaiDau GetByI(Guid id);
        List<GiaiDau> GetAll();
    }
}
