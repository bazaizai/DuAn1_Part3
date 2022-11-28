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
    public class KhachHangRepos:IKhachHangRepos
    {
        private FpolyDBContext context;
        private List<KhachHang> _lstKhachHang;
        public KhachHangRepos()
        {
            context = new FpolyDBContext();
            _lstKhachHang = new List<KhachHang>();
        }
        public bool Add(KhachHang obj)
        {
            try
            {
                if (obj == null) return false;
                context.KhachHangs.Add(obj);
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Delete(KhachHang obj)
        {
            try
            {
                if (obj == null) return false;
                var tempobj = context.KhachHangs.FirstOrDefault(c => c.Id == obj.Id);
                context.Remove(tempobj);
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public KhachHang GetById(Guid id)
        {
            if (id == Guid.Empty) return null;
            return context.KhachHangs.FirstOrDefault(c => c.Id == id);
        }

        public List<KhachHang> GetAll()
        {
                _lstKhachHang = context.KhachHangs.ToList();
                return _lstKhachHang;
            
        }

        public bool Update(KhachHang obj)
        {
            try
            {
                if (obj == null) return false;
                var tempobj = context.KhachHangs.FirstOrDefault(c => c.Id == obj.Id);
                tempobj.Idnv = obj.Id;
                tempobj.Ma = obj.Ma;
                tempobj.Ten = obj.Ten;
                tempobj.Sdt = obj.Sdt;
                tempobj.DiaChi = obj.DiaChi;
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
