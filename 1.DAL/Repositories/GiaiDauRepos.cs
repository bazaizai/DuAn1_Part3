using _1.DAL.Context;
using _1.DAL.DomainClass;
using _1.DAL.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Repositories
{
    public class GiaiDauRepos : IGiaiDauRepos
    {
        private FpolyDBContext _dbContext;
        public GiaiDauRepos()
        {
            _dbContext = new FpolyDBContext();
        }
        public bool Add(GiaiDau obj)
        {
            try
            {
                if (obj == null) return false;
                _dbContext.GiaiDaus.Add(obj);
                _dbContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Delete(GiaiDau obj)
        {
            try
            {
                if (obj == null) return false;
                var tempobj = _dbContext.GiaiDaus.FirstOrDefault(c => c.Id == obj.Id);
                _dbContext.Remove(tempobj);
                _dbContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<GiaiDau> GetAll()
        {
            return _dbContext.GiaiDaus.ToList();
        }

        public GiaiDau GetByI(Guid id)
        {
            if (id == Guid.Empty) return null;
            return _dbContext.GiaiDaus.FirstOrDefault(c => c.Id == id);
        }

        public bool Update(GiaiDau obj)
        {

            try
            {
                if (obj == null) return false;
                var tempobj = _dbContext.GiaiDaus.FirstOrDefault(c => c.Id == obj.Id);
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