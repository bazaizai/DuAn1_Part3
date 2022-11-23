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
    public class ChiTietHoaDonRepos : IChiTietHoaDonRepos
    {
        FpolyDBContext context;
        public ChiTietHoaDonRepos()
        {
            context = new FpolyDBContext();
        }

        public bool Add(HoaDonChiTiet obj)
        {
            try
            {   
                if(obj == null) return false;
                context.HoaDonChiTiets.Add(obj);
                context.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
        public bool Delete(HoaDonChiTiet obj)
        {
            try
            {
                if (obj == null) return false;
                var temp = context.HoaDonChiTiets.FirstOrDefault(c => c.Id == obj.Id);
                context.HoaDonChiTiets.Remove(temp);
                context.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public List<HoaDonChiTiet> GetAll()
        {
            return context.HoaDonChiTiets.ToList();
        }

        public HoaDonChiTiet GetID(Guid id)
        {
            if (id == Guid.Empty) return null;
            return context.HoaDonChiTiets.FirstOrDefault(c => c.Id == id);
        }

        public bool Update(HoaDonChiTiet obj)
        {
            try
            {
                if (obj == null) return false;
                var temp = context.HoaDonChiTiets.FirstOrDefault(c => c.Id == obj.Id);
                temp.IdChiTietSp = obj.IdChiTietSp;
                temp.IdHoaDon = obj.IdHoaDon;
                temp.SoLuong = obj.SoLuong;
                temp.DonGia = obj.DonGia;
                context.HoaDonChiTiets.Update(temp);
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
