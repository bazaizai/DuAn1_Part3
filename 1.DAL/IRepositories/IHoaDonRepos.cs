using _1.DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.IRepositories
{
    public interface IHoaDonRepos
    {
        bool Add(HoaDon obj);
        bool Update(HoaDon obj);
        HoaDon GetID(Guid id);
        List<HoaDon> GetAll();
    }
}
