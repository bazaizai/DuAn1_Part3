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
    public class KieuSpRepos : IKieuSpRepos
    {
        FpolyDBContext Context;
        public KieuSpRepos()
        {
            Context = new FpolyDBContext();
        }
        public bool Add(KieuSp Obj)
        {
            if(Obj == null)return false;
            try
            {
                Context.KieuSps.Add(Obj);
                Context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Delete(KieuSp Obj)
        {
            if (Obj == null) return false;
            try
            {
                Context.KieuSps.Remove(Obj);
                Context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<KieuSp> GetAll() => Context.KieuSps.ToList();

        public KieuSp GetById(Guid Id)=> GetAll().FirstOrDefault(x => x.Id == Id);

        public bool Update(KieuSp Obj)
        {
            if (Obj == null) return false;
            try
            {
                var temp = Context.KieuSps.FirstOrDefault(x => x.Id == Obj.Id); 
                temp.IdCha = Obj.IdCha;
                temp.Ma = Obj.Ma;
                temp.Ten = Obj.Ten;
                temp.TrangThai = Obj.TrangThai;
                Context.KieuSps.Update(Obj);
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
