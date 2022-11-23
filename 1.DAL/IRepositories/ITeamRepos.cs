using _1.DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.IRepositories
{
    public interface ITeamRepos
    {
        bool Add(Team obj);
        bool Update(Team obj);
        bool Delete(Team obj);

        Team GetByI(Guid id);
        List<Team> GetAll();
    }
}
