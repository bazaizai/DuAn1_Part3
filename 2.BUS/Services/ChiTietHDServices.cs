using _1.DAL.DomainClass;
using _1.DAL.IRepositories;
using _1.DAL.Repositories;
using _2.BUS.IServices;
using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.Services
{
    public class ChiTietHDServices : IChiTietHDServices
    {
        ISanPhamRepos sanPhamRepos;
        IChiTietHoaDonRepos chiTietHoaDonRepos;
        IChiTietSpRespos chiTietSpRespos;
        IHoaDonRepos hoaDonRepos;

        public ChiTietHDServices()
        {
            sanPhamRepos = new SanPhamRepos();
            chiTietSpRespos = new ChiTietSpRespos();
            hoaDonRepos = new HoaDonRepos();
            chiTietHoaDonRepos = new ChiTietHoaDonRepos();
        }

        public string Add(ChiTietHDView obj)
        {
            if (obj == null) return "Không thành công";
            HoaDonChiTiet temp = new HoaDonChiTiet()
            {
                Id = obj.Id,
                IdHoaDon = obj.IdHoaDon,
                IdChiTietSp = obj.IdChiTietSp,
                DonGia = obj.DonGia,
                SoLuong = obj.SoLuong,
                TrangThai = obj.TrangThai,
            };
            if (chiTietHoaDonRepos.Add(temp)) return "Thành công";
            return "Không thành công";
        }

        public string Delete(ChiTietHDView obj)
        {
            //if (obj == null) return "Không thành công";
            //HoaDonChiTiet temp = new HoaDonChiTiet()
            //{
            //    Id = obj.Id,
            //    TrangThai = obj.TrangThai,
            //};
            //if (chiTietHoaDonRepos.Delete(temp)) return "Thành công";
            //return "Không thành công";
            if (obj == null) return "Không thành công";
            HoaDonChiTiet temp = new HoaDonChiTiet()
            {
                Id = obj.Id
            };
            if (chiTietHoaDonRepos.Delete(temp)) return "Thành công";
            return "Không thành công";
        }

        public List<ChiTietHDView> GetAll()
        {
            var lst = (from a in chiTietHoaDonRepos.GetAll()
                       join b in hoaDonRepos.GetAll() on a.IdHoaDon equals b.Id
                       join c in (from a in chiTietSpRespos.GetAll()
                                  join b in sanPhamRepos.GetAll() on a.IdSp equals b.Id
                                  select new ChiTietSpViews()
                                  {
                                      Id = a.Id,
                                      IdSp = b.Id,
                                      IdChatLieu = a.IdChatLieu,
                                      IdMauSac = a.IdMauSac,
                                      IdSize = a.IdKichCo,
                                      IdTeam = a.IdTeam,
                                      BaoHanh = a.BaoHanh,
                                      GiaBan = a.GiaBan,
                                      GiaNhap = a.GiaNhap,
                                      MoTa = a.MoTa,
                                      SoLuongTon = a.SoLuongTon,
                                      TenSP = b.Ten,
                                      TrangThai = a.TrangThai,
                                      TrangThaiKhuyenMai = a.TrangThaiKhuyenMai
                                  }
                                  ).ToList() on a.IdChiTietSp equals c.Id
                       select new ChiTietHDView()
                       {
                           Id = a.Id,
                           IdChiTietSp = c.Id,
                           IdHoaDon = b.Id,
                           IdSp = c.IdSp,
                           MaHD = b.Ma,
                           DonGia = a.DonGia,
                           GiaBan = c.GiaBan,
                           SoLuong = a.SoLuong,
                           TenSP = c.TenSP,
                           TrangThai = c.TrangThai,
                       }
                       ).ToList();
            return lst;
        }

        public ChiTietHDView GetID(Guid id)
        {
            throw new NotImplementedException();
        }
        public string Update(ChiTietHDView obj)
        {
            if (obj == null) return "Không thành công";
            HoaDonChiTiet temp = new HoaDonChiTiet()
            {
                Id = obj.Id,
                IdHoaDon = obj.IdHoaDon,
                IdChiTietSp = obj.IdChiTietSp,
                DonGia = obj.DonGia,
                SoLuong = obj.SoLuong,
                TrangThai = obj.TrangThai,
            };
            if (chiTietHoaDonRepos.Update(temp)) return "Thành công";
            return "Không thành công";
        }
    }
}
