using _1.DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.IRepositories
{
    public interface IKhachHangRepos
    {
        bool Add(KhachHang obj);
        bool Update(KhachHang obj);
        bool Delete(KhachHang obj);
        KhachHang GetById(Guid id);
        List<KhachHang> GetAll();
    }
}
