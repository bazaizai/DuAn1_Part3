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
    public class HoaDonServices : IHoaDonServices
    {
        IHoaDonRepos hoaDonRepos;
        IKhachHangRepos khachHangRepos;
        INhanVienRepos nhanVienRepos;
        ITichDiemRepos tichDiemRepos;
        IHinhThucMhRepos hinhThucMhRepos;
        IPtthanhToanRepos ptthanhToanRepos;
        IUuDaiTichDiemRepos uuDaiTichDiemRepos;
        public HoaDonServices()
        {
            hoaDonRepos = new HoaDonRepos();
            khachHangRepos = new KhachHangRepos();
            nhanVienRepos = new NhanVienRepos();
            tichDiemRepos = new TichDiemRepos();
            hinhThucMhRepos = new HinhThucMhRepos();
            ptthanhToanRepos = new PtthanhToanRepos();
            uuDaiTichDiemRepos = new UuDaiTichDiemRepos();
        }

        public string Add(HoaDonViews obj)
        {
            if (obj == null) return "Không thành công";
            HoaDon temp = new HoaDon()
            {
                Id = obj.Id,
                Ma = MaTT(),
                IdKh = obj.IdKh,
                IdNv = obj.IdNv,
                IdHt = obj.IdHt,
                IdPttt = obj.IdPttt,
                IdUdtichDiem = obj.IdUD,
                NgayTao = obj.NgayTao,
                NgayNhan = obj.NgayNhan,
                NgayThanhToan = obj.NgayThanhToan,
                NgayShip = obj.NgayShip,
                TenNguoiNhan = obj.TenNguoiNhan,
                DiaChi = obj.DiaChiNhan,
                GiamGia = obj.GiamGia,
                TienKhachDua = obj.TienKhachDua,
                TienChuyenKhoan = obj.TienChuyenKhoan,
                Cod = obj.Cod,
                HinhThucGiamGia = obj.HinhThucGiamGia,
                TienShip = obj.TienShip,
                TrangThaiGiaoHang = obj.TrangThaiGiaoHang,
                TongTien = obj.TongTien,
                SoTienGiam = obj.SoTienGiam,
                Sdt = obj.SdtNhanHang,
                MoTa = obj.MoTa,
                TrangThai = obj.TrangThai
            };
            if (hoaDonRepos.Add(temp)) return "Thành công";
            return "Không thành công";
        }

        public string Delete(HoaDonViews obj)
        {
            if (obj == null) return "Không thành công";
            HoaDon temp = new HoaDon()
            {
                Id = obj.Id,
                Ma = MaTT(),
                TrangThai = obj.TrangThai
            };
            if (hoaDonRepos.Update(temp)) return "Thành công";
            return "Không thành công";
        }

        public List<HoaDonViews> GetAll()
        {
            var lst = (from a in hoaDonRepos.GetAll()
                       //join b in (from a in khachHangRepos.GetAll()
                       //           join b in tichDiemRepos.GetAll() on a.IdtichDiem equals b.Id
                       //           select new KhachHangView()
                       //           {
                       //               Id = a.Id,
                       //               Ten = a.Ten,
                       //               Ho = a.Ho,
                       //               TenDem = a.TenDem,
                       //               Sdt = a.Sdt,
                       //               DiaChi = a.DiaChi,
                       //               IdtichDiem = a.IdtichDiem,
                       //               Email = a.Email,
                       //               Ma = a.Ma,
                       //               TrangThai = a.TrangThai,
                       //               NgaySinh = a.NgaySinh,
                       //               SoDiem = b.SoDiem
                       //           }
                       //           ).ToList() on a.IdKh equals b.Id
                       //join c in nhanVienRepos.GetAll() on a.IdNv equals c.Id
                       //join d in ptthanhToanRepos.GetAll() on a.IdPttt equals d.Id
                       //join e in hinhThucMhRepos.GetAll() on a.IdHt equals e.Id
                       //join f in uuDaiTichDiemRepos.GetAll() on a.IdUdtichDiem equals f.Id
                       select new HoaDonViews()
                       {
                           Id = a.Id,
                           DiaChiNhan = a.DiaChi,
                           GiamGia = a.GiamGia,
                           NgayTao = a.NgayTao,
                           NgayNhan = a.NgayNhan,
                           NgayShip = a.NgayShip,
                           NgayThanhToan = a.NgayThanhToan,
                           SdtNhanHang = a.Sdt,
                           MaHD = a.Ma,
                           TongTienSauKhiGiam = a.TongTien - a.SoTienGiam,
                           TenNguoiNhan = a.TenNguoiNhan,
                           TienKhachDua = a.TienKhachDua,
                           TienChuyenKhoan = a.TienChuyenKhoan,
                           TongTien = a.TongTien,
                           TrangThai = a.TrangThai,
                           MoTa = a.MoTa,
                           SoTienGiam = a.SoTienGiam,
                           TrangThaiGiaoHang = a.TrangThaiGiaoHang
                           //IdtichDiem = b.IdtichDiem,
                           //IdKh = b.Id,
                           //HoKh = b.Ho,
                           //TenDemKh = b.TenDem,
                           //TenKh = b.Ten,
                           //SoDiemKH = b.SoDiem,
                           //MaKh = b.Ma,
                           //IdNv = c.Id,
                           //HoNv = c.Ho,
                           //TenDemNv = c.TenDem,
                           //TenNv = c.Ten,
                           //MaNv = c.Ma,
                           //IdPttt = d.Id,
                           //TenPttt = d.Ten,
                           //MaPttt = d.Ma,
                           //IdHt = e.Id,
                           //TenHt = e.Ten,
                           //MaHt = e.Ma,
                           //IdUD = f.Id,
                           //MaUD = f.Ma,
                           //MucUuDai = f.MucUuDai,
                           //SoDiemUD = f.SoDiem,
                           //LoaiHinhKm = f.LoaiHinhKm
                       }
                       ).ToList();
            return lst;
        }

        public HoaDonViews GetID(Guid id) => GetAll().Find(x => x.Id == id);
        public string Update(HoaDonViews obj)
        {
            if (obj == null) return "Không thành công";
            HoaDon temp = new HoaDon()
            {
                Id = obj.Id,
                Ma = obj.MaHD,
                IdKh = obj.IdKh,
                IdNv = obj.IdNv,
                IdHt = obj.IdHt,
                IdPttt = obj.IdPttt,
                IdUdtichDiem = obj.IdUD,
                NgayTao = obj.NgayTao,
                NgayNhan = obj.NgayNhan,
                NgayThanhToan = obj.NgayThanhToan,
                NgayShip = obj.NgayShip,
                TenNguoiNhan = obj.TenNguoiNhan,
                DiaChi = obj.DiaChiNhan,
                GiamGia = obj.GiamGia,
                TienKhachDua = obj.TienKhachDua,
                TienChuyenKhoan = obj.TienChuyenKhoan,
                Cod = obj.Cod,
                HinhThucGiamGia = obj.HinhThucGiamGia,
                TienShip = obj.TienShip,
                TrangThaiGiaoHang = obj.TrangThaiGiaoHang,
                TongTien = obj.TongTien,
                SoTienGiam = obj.TongTien - obj.TongTienSauKhiGiam,
                Sdt = obj.SdtNhanHang,
                MoTa = obj.MoTa,
                TrangThai = obj.TrangThai
            };
            if (hoaDonRepos.Update(temp)) return "Thành công";
            return "Không thành công";
        }
        private string MaTT()
        {
            if (hoaDonRepos.GetAll().Count > 0)
            {
                return "HD" + Convert.ToString(hoaDonRepos.GetAll().Max(c => Convert.ToInt32(c.Ma.Substring(2, c.Ma.Length - 2)) + 1));
            }
            else return "HD1";
        }
    }
}
