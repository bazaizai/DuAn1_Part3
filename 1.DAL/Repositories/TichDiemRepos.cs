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
    public class TichDiemRepos : ITichDiemRepos
    {
        private FpolyDBContext context;
        private List<TichDiem> _lstTichDiem;

        public TichDiemRepos()
        {
            context = new FpolyDBContext();
            _lstTichDiem = new List<TichDiem>();
        }
        public bool Add(TichDiem obj)
        {
            try
            {
                if (obj == null) return false;
                context.TichDiems.Add(obj);
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
            
        }

        public bool Delete(TichDiem obj)
        {
            try
            {
                if (obj == null) return false;
                var tempobj = context.TichDiems.FirstOrDefault(c => c.Id == obj.Id);
                context.Remove(tempobj);
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
            
        }

        public TichDiem GetById(Guid id)
        {
            if (id == Guid.Empty) return null;
            return context.TichDiems.FirstOrDefault(c => c.Id == id);
        }

        public List<TichDiem> GetAll()
        {
            _lstTichDiem = context.TichDiems.ToList();
            return _lstTichDiem;
        }

        public bool Update(TichDiem obj)
        {
            try
            {
                if (obj == null) return false;
                var tempobj = context.TichDiems.FirstOrDefault(c => c.Id == obj.Id);
                tempobj.SoDiem = obj.SoDiem;
                tempobj.TrangThai = obj.TrangThai;
                context.Update(tempobj);
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
            
        }
    }
}
