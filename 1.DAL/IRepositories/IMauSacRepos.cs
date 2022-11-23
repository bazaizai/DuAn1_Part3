using _1.DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.IRepositories
{
    public interface IMauSacRepos
    {
        bool Add(MauSac obj);
        bool Update(MauSac obj);
        bool Delete(MauSac obj);
        MauSac GetById(Guid id);
        List<MauSac> GetAll();
    }
}
