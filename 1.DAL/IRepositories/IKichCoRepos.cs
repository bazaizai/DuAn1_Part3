using _1.DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.IRepositories
{
    public interface IKichCoRepos
    {
        bool Add(KichCo obj);
        bool Update(KichCo obj);
        bool Delete(KichCo obj);
        KichCo GetById(Guid id);
        List<KichCo> GetAll();
    }
}
