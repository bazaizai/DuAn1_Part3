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
    public class NhanVienRepos : INhanVienRepos
    {
        FpolyDBContext Context;
        public NhanVienRepos()
        {
            Context = new FpolyDBContext();
        }

        public bool Add(NhanVien obj)
        {
            if (obj == null) return false;
            try
            {
                Context.NhanViens.Add(obj);
                Context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Delete(NhanVien obj)
        {
            if (obj == null) return false;
            try
            {
                var temp = Context.NhanViens.FirstOrDefault(x => x.Id == obj.Id);
                Context.NhanViens.Remove(temp);
                Context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public NhanVien GetById(Guid id)
        {
            if (id == Guid.Empty) return null;
            return Context.NhanViens.FirstOrDefault(s => s.Id == id);
        }

        public List<NhanVien> GetAll()
        {
            return Context.NhanViens.ToList();
        }

        public bool Update(NhanVien obj)
        {
            if (obj == null) return false;
            try
            {
                var temp = Context.NhanViens.FirstOrDefault(x => x.Id == obj.Id);
                temp.IdCv = obj.IdCv;
                temp.Ma = obj.Ma;
                temp.Ten = obj.Ten;
                temp.TenDem = obj.TenDem;
                temp.Ho = obj.Ho;
                temp.GioiTinh = obj.GioiTinh;
                temp.NgaySinh = obj.NgaySinh;
                temp.DiaChi = obj.DiaChi;
                temp.Sdt = obj.Sdt;
                temp.Cccd = obj.Cccd;
                temp.MatKhau = obj.MatKhau;
                temp.Email = obj.Email;
                temp.TaiKhoan = obj.TaiKhoan;
                temp.TrangThai = obj.TrangThai;
                Context.NhanViens.Update(temp);
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
