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
    public class UuDaiTichDiemRepos:IUuDaiTichDiemRepos
    {
        private FpolyDBContext context;
        private List<UdtichDiem> _lstUuDaiTichDiem;

        public UuDaiTichDiemRepos()
        {
            context = new FpolyDBContext();
            _lstUuDaiTichDiem = new List<UdtichDiem>();
        }

        public bool Add(UdtichDiem obj)
        {
            try
            {
                if(obj == null) return false;
                context.UdtichDiems.Add(obj);
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Delete(UdtichDiem obj)
        {
            try
            {
                if (obj == null) return false;
                var tempobj = context.UdtichDiems.FirstOrDefault(c => c.Id == obj.Id);
                context.Remove(tempobj);
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public UdtichDiem GetById(Guid id)
        {
            if (id == Guid.Empty) return null;
            return context.UdtichDiems.FirstOrDefault(c => c.Id == id);
        }

        public List<UdtichDiem> GetAll()
        {
            _lstUuDaiTichDiem = context.UdtichDiems.ToList();
            return _lstUuDaiTichDiem;
        }

        public bool Update(UdtichDiem obj)
        {
            try
            {
                if (obj == null) return false;
                var tempobj = context.UdtichDiems.FirstOrDefault(c => c.Id == obj.Id);
                tempobj.Ma = obj.Ma;
                tempobj.LoaiHinhKm = obj.LoaiHinhKm;
                tempobj.MucUuDai = obj.MucUuDai;
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
