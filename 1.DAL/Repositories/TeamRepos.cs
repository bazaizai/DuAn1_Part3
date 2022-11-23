using _1.DAL.Context;
using _1.DAL.DomainClass;
using _1.DAL.IRepositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Repositories
{
    public class TeamRepos : ITeamRepos
    {
        private FpolyDBContext _dbContext;
        public TeamRepos()
        {
            _dbContext = new FpolyDBContext();
        }
        public bool Add(Team obj)
        {
            try
            {
                if (obj == null) return false;
                _dbContext.Teams.Add(obj);
                _dbContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Delete(Team obj)
        {
            try
            {
                if (obj == null) return false;
                var tempobj = _dbContext.Teams.FirstOrDefault(c => c.Id == obj.Id);
                _dbContext.Remove(tempobj);
                _dbContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<Team> GetAll()
        {
            return _dbContext.Teams.ToList();
        }

        public Team GetByI(Guid id)
        {
            if (id == Guid.Empty) return null;
            return _dbContext.Teams.FirstOrDefault(c => c.Id == id);
        }

        public bool Update(Team obj)
        {
            try
            {
                if (obj == null) return false;
                var tempobj = _dbContext.Teams.FirstOrDefault(c => c.Id == obj.Id);
                tempobj.IdGd = obj.IdGd;
                tempobj.Ma = obj.Ma;
                tempobj.Ten = obj.Ten;
                tempobj.TrangThai = obj.TrangThai;
                _dbContext.Update(tempobj);
                _dbContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;

            }
        }
    }
}