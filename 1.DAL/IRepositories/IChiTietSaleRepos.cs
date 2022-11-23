using _1.DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.IRepositories
{
    public interface IChiTietSaleRepos
    {
        bool Add(ChiTietSale obj);
        bool Update(ChiTietSale obj);
        bool Delete(ChiTietSale obj);

        ChiTietSale GetByI(Guid id);
        List<ChiTietSale> GetAll();
    }
}
