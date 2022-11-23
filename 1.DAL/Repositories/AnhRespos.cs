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
    public class AnhRespos : IAnhRespos
    {
        FpolyDBContext Context;
        public AnhRespos()
        {
            Context = new FpolyDBContext();
        }
        public bool Add(Anh Obj)
        {
            if (Obj == null) return false;
                Context.Anhs.Add(Obj);
                Context.SaveChanges();
                return true;
        }

        public bool Delete(Anh Obj)
        {
            if (Obj == null) return false;
            try
            {
                Context.Anhs.Remove(Obj);
                Context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<Anh> GetAll() => Context.Anhs.ToList();

        public Anh GetById(Guid Id)=> Id == Guid.Empty ? null : Context.Anhs.FirstOrDefault(x => x.Id == Id);

        public bool Update(Anh Obj)
        {
            if (Obj == null) return false;
            try
            {
                Context.Anhs.Update(Obj);
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
