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

    public class ChiTietSaleRepos : IChiTietSaleRepos
    {
        private FpolyDBContext _dbContext;
        public ChiTietSaleRepos()
        {
            _dbContext = new FpolyDBContext();
        }

        public bool Add(ChiTietSale obj)
        {
            try
            {
                if (obj == null) return false;
                _dbContext.ChiTietSales.Add(obj);
                _dbContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Delete(ChiTietSale obj)
        {
            try
            {
                if (obj == null) return false;
                var tempobj = _dbContext.ChiTietSales.FirstOrDefault(c => c.Id == obj.Id);
                _dbContext.Remove(tempobj);
                _dbContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<ChiTietSale> GetAll()
        {
            return _dbContext.ChiTietSales.ToList();
        }

        public ChiTietSale GetByI(Guid id)
        {
            if (id == Guid.Empty) return null;
            return _dbContext.ChiTietSales.FirstOrDefault(c => c.Id == id);
        }

        public bool Update(ChiTietSale obj)
        {
            try
            {
                if (obj == null) return false;
                var tempobj = _dbContext.ChiTietSales.FirstOrDefault(c => c.Id == obj.Id);
                tempobj.IdSale = obj.IdSale;
                tempobj.IdChiTietSp = obj.IdChiTietSp;
                tempobj.MoTa = obj.MoTa;
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
