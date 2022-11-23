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
    public class LichSuTichDiemRepos:ILichSuTichDiemRepos
    {
        private FpolyDBContext context;
        private List<LstichDiem> _lstLichSuTichDiem;

        public LichSuTichDiemRepos()
        {
            context = new FpolyDBContext();
            _lstLichSuTichDiem = new List<LstichDiem>();
        }

        public bool Add(LstichDiem obj)
        {
            try
            {
                if (obj == null) return false;
                context.LstichDiems.Add(obj);
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Delete(LstichDiem obj)
        {
            try
            {
                if (obj == null) return false;
                var tempobj = context.LstichDiems.FirstOrDefault(c => c.Id == obj.Id);
                context.Remove(tempobj);
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public LstichDiem GetById(Guid id)
        {
            if (id == Guid.Empty) return null;
            return context.LstichDiems.FirstOrDefault(c => c.Id == id);
        }

        public List<LstichDiem> GetAll()
        {
            _lstLichSuTichDiem = context.LstichDiems.ToList();
            return _lstLichSuTichDiem;
        }

        public bool Update(LstichDiem obj)
        {
            try
            {
                if (obj == null) return false;
                var tempobj = context.LstichDiems.FirstOrDefault(c => c.Id == obj.Id);
                tempobj.SoDiemDung = obj.SoDiemDung;
                tempobj.NgayTichDiem = obj.NgayTichDiem;
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
