using _1.DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.IRepositories
{
    public interface IChiTietHoaDonRepos
    {
        bool Add(HoaDonChiTiet obj);
        bool Update(HoaDonChiTiet obj);
        HoaDonChiTiet GetID(Guid id);
        List<HoaDonChiTiet> GetAll();
        bool Delete(HoaDonChiTiet obj);
    }
}
