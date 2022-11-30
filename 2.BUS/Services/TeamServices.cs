using _1.DAL.DomainClass;
using _1.DAL.IRepositories;
using _1.DAL.Repositories;
using _2.BUS.IServices;
using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.Services
{
    public class TeamServices : ITeamServices
    {
        private ITeamRepos _teamRepos;
        private List<TeamView> _lstteamViews;
        private IGiaiDauRepos giaiDauRepos;
        private IChiTietSpRespos _chiTietSpRespos;
        public TeamServices()
        {
            _teamRepos = new TeamRepos();
            _lstteamViews = new List<TeamView>();
            giaiDauRepos = new GiaiDauRepos();
            _chiTietSpRespos = new ChiTietSpRespos();
        }
        public string Add(TeamView team)
        {
            if (team == null) return "Thêm thất bại";
            Team x = new Team()
            {
                Id = team.Id,
                IdGd = team.IdGd,
                Ma = MaTS(),
                Ten = team.Ten,
                TrangThai = team.TrangThai,
            };
            if (_teamRepos.Add(x)) return "Thêm thành công";
            return "Thêm thất bại";
        }
        public string MaTS()
        {
            if (_teamRepos.GetAll().Count == 0) return "Team1";
            return "Team" + (_teamRepos.GetAll().Max(x => Convert.ToInt32(x.Ma.Substring(4, x.Ma.Length - 4))) + 1);

        }
        public string Delete(Guid id)
        {
            var x = _teamRepos.GetAll().FirstOrDefault(c => c.Id == id);
            if (_teamRepos.Delete(x)) return "Xóa thành công";
            return "Xóa thất bại";
        }

        public List<TeamView> GetAll()
        {
            _lstteamViews = (from a in _teamRepos.GetAll()
                             join b in giaiDauRepos.GetAll()
                             on a.IdGd equals b.Id
                             select new TeamView
                             {
                                 Id = a.Id,
                                 IdGd = a.IdGd,
                                 Ma = a.Ma,
                                 Ten = a.Ten,
                                 TrangThai = a.TrangThai,
                                 TenGiaiDau = b.Ten,
                             }).OrderBy(c=>c.Ma).ToList();
            return _lstteamViews;
        }

        public string Update(TeamView team)
        {
            var x = _teamRepos.GetAll().FirstOrDefault(c => c.Id == team.Id);
            x.Id = team.Id;
            x.IdGd = team.IdGd;
            x.Ma = team.Ma;
            x.Ten = team.Ten;
            x.TrangThai = team.TrangThai;
            if (_teamRepos.Update(x)) return "Sửa thành công";
            return "Không thành công";
        }

        public Guid GetIdByName(string name)
        {
            return GetAll().FirstOrDefault(x=>x.Ten == name).Id;
        }

        public string Delete(TeamView team)
        {
            if (team == null) return "Xóa thất bại";
            var a = _chiTietSpRespos.GetAll().Find(c=>c.IdTeam== team.Id);
            if(a==null)
            {
                Team team1 = new Team()
                {
                    Id = team.Id,
                    IdGd = team.IdGd,
                    Ma = team.Ma,
                    Ten = team.Ten,
                    TrangThai = team.TrangThai,
                };
                if (_teamRepos.Delete(team1))
                {
                    return "Thành công";
                }
                else return "Thất bại";
                    
            }    
            return "Team đã được liên kết với một bảng khác";


        }
    }
}
