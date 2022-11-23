using _1.DAL.Context;
using _1.DAL.DomainClass;
using _1.DAL.IRepositories;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Repositories
{
    public class KichCoRepos:IKichCoRepos
    {
        public FpolyDBContext _dbContext;
        public KichCoRepos()
        {
            _dbContext = new FpolyDBContext();
        }
        public bool Add(KichCo obj)
        {
            obj.Id = Guid.NewGuid();
            if (obj == null) return false;
            try
            {
                _dbContext.KichCos.Add(obj);
                _dbContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
           
        }

        public bool Update(KichCo obj)
        {
            if (obj == null) return false;
            try
            {
                var tempobj = _dbContext.KichCos.FirstOrDefault(x => x.Id == obj.Id);
                tempobj.Ma = obj.Ma;
                tempobj.Size = obj.Size;
                tempobj.Cm = obj.Cm;
                tempobj.TrangThai = obj.TrangThai;
                _dbContext.KichCos.Update(obj);
                _dbContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
            
        }

        public bool Delete(KichCo obj)
        {
            if (obj == null) return false;
            try
            {
                var tempobj = _dbContext.KichCos.FirstOrDefault(x => x.Id == obj.Id);
                _dbContext.Remove(obj);
                _dbContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
           
        }

        public List<KichCo> GetAll ()
        {
            return _dbContext.KichCos.ToList();
        }

        public KichCo GetById(Guid id)
        {
            if (id == Guid.Empty) return null;
            return _dbContext.KichCos.FirstOrDefault(c => c.Id == id);

        }

       
    }
}
