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
    public class PtthanhToanRepos:IPtthanhToanRepos
    {
        public FpolyDBContext _dbContext;
        public PtthanhToanRepos()
        {
            _dbContext = new FpolyDBContext();
        }
        public bool Add(PtthanhToan obj)
        {
            obj.Id = Guid.NewGuid();
            if (obj == null) return false;
            try
            {               
                _dbContext.PtthanhToans.Add(obj);
                _dbContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {

               return false;
            }
        }

        public bool Update(PtthanhToan obj)
        {

            if (obj == null) return false;
            try
            {
                var tempobj = _dbContext.PtthanhToans.FirstOrDefault(x => x.Id == obj.Id);
                tempobj.Ma = obj.Ma;
                tempobj.Ten = obj.Ten;
                tempobj.TrangThai = obj.TrangThai;
                _dbContext.PtthanhToans.Update(obj);
                _dbContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
           
        }

        public bool Delete(PtthanhToan obj)
        {
            if (obj == null) return false;
            try
            {
                var tempobj = _dbContext.PtthanhToans.FirstOrDefault(x => x.Id == obj.Id);
                _dbContext.Remove(obj);
                _dbContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
            
        }

        public List<PtthanhToan> GetAll()
        {
            return _dbContext.PtthanhToans.ToList();
        }

        public PtthanhToan GetById(Guid id)
        {
            if (id == Guid.Empty) return null;
            return _dbContext.PtthanhToans.FirstOrDefault(c => c.Id == id);

        }
    }
}
