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
    public class HoaDonRepos:IHoaDonRepos
    {

        FpolyDBContext context;

        public HoaDonRepos()
        {
            context = new FpolyDBContext();
        }

        public bool Add(HoaDon obj)
        {
            try
            {
                if (obj == null) return false;
                context.HoaDons.Add(obj);
                context.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public List<HoaDon> GetAll()
        {
            return context.HoaDons.ToList();
        }

        public HoaDon GetID(Guid id)
        {
            if (id == Guid.Empty) return null;
            return context.HoaDons.FirstOrDefault(c => c.Id == id);
        }

        public bool Update(HoaDon obj)
        {
            try
            {
                if (obj == null) return false;
                var temp = context.HoaDons.FirstOrDefault(c => c.Id == obj.Id);
                temp.Id = obj.Id;
                temp.IdPttt = obj.IdPttt;
                temp.IdHt = obj.IdHt;
                temp.IdKh = obj.IdKh;
                temp.IdNv = obj.IdNv;
                temp.IdUdtichDiem = obj.IdUdtichDiem;
                temp.Ma = obj.Ma;
                temp.NgayThanhToan = obj.NgayThanhToan;
                temp.NgayShip = obj.NgayShip;
                temp.TenNguoiNhan = obj.TenNguoiNhan;
                temp.DiaChi = obj.DiaChi;
                temp.Sdt = obj.Sdt;
                temp.GiamGia = obj.GiamGia;
                temp.Cod = obj.Cod;
                temp.HinhThucGiamGia = obj.HinhThucGiamGia;
                temp.TienShip = obj.TienShip;
                temp.TrangThaiGiaoHang = obj.TrangThaiGiaoHang;
                temp.SoTienGiam = obj.SoTienGiam;
                temp.TienKhachDua = obj.TienKhachDua;
                temp.TrangThai = obj.TrangThai;
                temp.MoTa = obj.MoTa;
                temp.NgayNhan = obj.NgayNhan;
                context.HoaDons.Update(temp);
                context.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}
