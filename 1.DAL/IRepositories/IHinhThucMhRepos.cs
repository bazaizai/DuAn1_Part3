using _1.DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.IRepositories
{
    public interface IHinhThucMhRepos
    {
        bool Add(HinhThucMh obj);
        bool Update(HinhThucMh obj);

        bool Delete(HinhThucMh obj);
        HinhThucMh GetById(Guid id);
        List<HinhThucMh> GetAll();
    }
}
