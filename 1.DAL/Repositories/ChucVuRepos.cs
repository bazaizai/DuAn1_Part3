using _1.DAL.Context;
using _1.DAL.DomainClass;
using _1.DAL.IRepositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Repositories
{
    public class ChucVuRepos : IChucVuRepos
    {
        FpolyDBContext Context;
        public ChucVuRepos()
        {
            Context = new FpolyDBContext();
        }
        public bool Add(ChucVu obj)
        {
            if (obj == null) return false;
            try
            {
                Context.ChucVus.Add(obj);
                Context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Delete(ChucVu obj)
        {
            if (obj == null) return false;
            try
            {
                var temp = Context.ChucVus.FirstOrDefault(x => x.Id == obj.Id);
                Context.ChucVus.Remove(temp);
                Context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public ChucVu GetById(Guid id)
        {
            if (id == Guid.Empty) return null;
            return Context.ChucVus.FirstOrDefault(s => s.Id == id);
        }

        public List<ChucVu> GetAll()
        {
            return Context.ChucVus.ToList();
        }

        public bool Update(ChucVu obj)
        {
            if (obj == null) return false;
            try
            {
                var temp = Context.ChucVus.FirstOrDefault(x => x.Id == obj.Id);
                temp.Ma = obj.Ma;
                temp.Ten = obj.Ten;
                temp.TrangThai = obj.TrangThai;
                Context.ChucVus.Update(temp);
                Context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
