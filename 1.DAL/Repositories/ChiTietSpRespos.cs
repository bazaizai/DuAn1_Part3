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
    public class ChiTietSpRespos : IChiTietSpRespos
    {
        FpolyDBContext Context;
        public ChiTietSpRespos()
        {
            Context = new FpolyDBContext();
        }
        public bool Add(ChiTietSp Obj)
        {
            if (Obj == null) return false;
            try
            {
                Context.ChiTietSps.Add(Obj);
                Context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Delete(ChiTietSp Obj)
        {
            if (Obj == null) return false;
            try
            {
                Context.ChiTietSps.Remove(Obj);
                Context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<ChiTietSp> GetAll() => Context.ChiTietSps.ToList();

        public ChiTietSp GetById(Guid Id) => GetAll().FirstOrDefault(x => x.Id == Id);

        public bool Update(ChiTietSp Obj)
        {
            if (Obj == null) return false;
            try
            {
                Context.ChiTietSps.Update(Obj);
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
