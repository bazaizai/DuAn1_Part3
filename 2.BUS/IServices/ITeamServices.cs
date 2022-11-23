using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.IServices
{
    public interface ITeamServices
    {
        string Add(TeamView team);
        string Update(TeamView team);
        string Delete(TeamView team);
        Guid GetIdByName(string name);
        List<TeamView> GetAll();
    }
}
