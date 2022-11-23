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
    public class SanPhamRepos:ISanPhamRepos
    {
        public FpolyDBContext _dbContext;
        public SanPhamRepos()
        {
            _dbContext = new FpolyDBContext();
        }
        public bool Add(SanPham obj)
        {
            obj.Id = Guid.NewGuid();
            if (obj == null) return false;
            try
            {
                _dbContext.SanPhams.Add(obj);
                _dbContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
           
        }

        public bool Update(SanPham obj)
        {
            if (obj == null) return false;
            try
            {
                var tempobj = _dbContext.SanPhams.FirstOrDefault(x => x.Id == obj.Id);
                tempobj.Ma = obj.Ma;
                tempobj.Ten = obj.Ten;
                tempobj.TrangThai = obj.TrangThai;
                _dbContext.SanPhams.Update(obj);
                _dbContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
        public bool Delete(SanPham obj)
        {
            if (obj == null) return false;
            try
            {
                var tempobj = _dbContext.SanPhams.FirstOrDefault(x => x.Id == obj.Id);
                _dbContext.Remove(obj);
                _dbContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
           
        }

        public List<SanPham> GetAll()
        {
            return _dbContext.SanPhams.ToList();
        }

        public SanPham GetById(Guid id)
        {
            if (id == Guid.Empty) return null;
            return _dbContext.SanPhams.FirstOrDefault(c => c.Id == id);

        }
    }
}
