using _1.DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.IRepositories
{
    public interface IPtthanhToanRepos
    {
        bool Add(PtthanhToan obj);
        bool Update(PtthanhToan obj);

        bool Delete(PtthanhToan obj);
        PtthanhToan GetById(Guid id);
        List<PtthanhToan> GetAll();
    }
}
