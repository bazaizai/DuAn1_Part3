
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
    public class SaleRepos : ISaleRepos
    {
        private FpolyDBContext _dbContext;
        public SaleRepos()
        {
            _dbContext = new FpolyDBContext();
        }
        public bool Add(Sale obj)
        {
            try
            {
                if (obj == null) return false;
                _dbContext.Sales.Add(obj);
                _dbContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Delete(Sale obj)
        {
            try
            {
                if (obj == null) return false;
                var tempobj = _dbContext.Sales.FirstOrDefault(c => c.Id == obj.Id);
                _dbContext.Remove(tempobj);
                _dbContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<Sale> GetAll()
        {
            return _dbContext.Sales.ToList();
        }

        public Sale GetByI(Guid id)
        {
            if (id == Guid.Empty) return null;
            return _dbContext.Sales.FirstOrDefault(c => c.Id == id);
        }

        public bool Update(Sale obj)
        {
            try
            {
                if (obj == null) return false;
                var tempobj = _dbContext.Sales.FirstOrDefault(c => c.Id == obj.Id);
                tempobj.Ma = obj.Ma;
                tempobj.Ten = obj.Ten;
                tempobj.NgayBatDau = obj.NgayBatDau;
                tempobj.NgayKetThuc = obj.NgayKetThuc;
                tempobj.LoaiHinhKm = obj.LoaiHinhKm;
                tempobj.MucGiam = obj.MucGiam;
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