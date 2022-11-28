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
    public class KhachHangServices : IKhachHangServices
    {
        IKhachHangRepos _iKhachHangRepos;
        ITichDiemRepos _iTichDiemRepos;
        INhanVienRepos _iNhanVienRepos;

        public KhachHangServices()
        {
            _iKhachHangRepos = new KhachHangRepos();
            _iTichDiemRepos = new TichDiemRepos();
            _iNhanVienRepos = new NhanVienRepos();    
        }
        public string Add(KhachHangView obj)
        {
            try
            {
                var x = new KhachHang()
                {
                    Id = obj.Id,
                    IdtichDiem = obj.IdtichDiem,
                    //Idnv = obj.Idnv,
                    Ma = MaTT(),
                    Ten = obj.Ten,
                    Sdt = obj.Sdt,
                    DiaChi = obj.DiaChi,
                    TrangThai = obj.TrangThai
                };
                if (_iKhachHangRepos.Add(x)) return "Thêm khách hàng thành công";
                return "Thêm khách hàng không Thành công";
            }
            catch (Exception e)
            {
                return e.Message.ToString();
            }
        }

        public string Delete(KhachHangView obj)
        {
            try
            {
                var x = new KhachHang()
                {
                    Id = obj.Id,
                    IdtichDiem = obj.IdtichDiem,
                    
                };
                if (_iKhachHangRepos.Delete(x)) return "Xóa thành công";
                return "Xóa không thành Công";
            }
            catch (Exception e)
            {
                return e.Message.ToString();
            }
        }

        public List<KhachHangView> GetAll()
        {
            var lst = (from a in _iKhachHangRepos.GetAll()
                       join b in _iTichDiemRepos.GetAll() on a.IdtichDiem equals b.Id
                       //join c in _iNhanVienRepos.GetAll() on a.Idnv equals c.Id
                       select new KhachHangView()
                       {
                           Id = a.Id,
                           IdtichDiem = b.Id,
                           //Idnv = c.Id,
                           Ma = a.Ma,
                           Ten = a.Ten,
                           Sdt = a.Sdt,
                           NhaMang = a.Sdt.StartsWith("03") || a.Sdt.StartsWith("09") ? "Viettel" : a.Sdt.StartsWith("07") ? "Mobifone" : a.Sdt.StartsWith("08") ? "Vinaphone" : "Nhà mạng vô danh",
                           DiaChi = a.DiaChi,
                           SoDiem = b.SoDiem,
                           TrangThai = a.TrangThai,
                       }).ToList();
            return lst;
        }

        public KhachHangView GetByID(Guid id)
        {
            var a = _iKhachHangRepos.GetById(id);
            var x = new KhachHangView()
            {
                Id = a.Id,
                IdtichDiem = a.IdtichDiem,
                //Idnv = a.Idnv,
                Ma = a.Ma,
                Ten = a.Ten,
                Sdt = a.Sdt,
                DiaChi = a.DiaChi,
                TrangThai = a.TrangThai
            };
            return x;
        }
   
        public List<KhachHangView> Search(string obj)
        {
            var lst = (from a in _iKhachHangRepos.GetAll()
                       select new KhachHangView()
                       {
                           Id = a.Id,
                           IdtichDiem = a.IdtichDiem,
                           //Idnv=a.Idnv,
                           Ma = a.Ma,
                           Ten = a.Ten,
                           Sdt = a.Sdt,
                           DiaChi = a.DiaChi,
                           TrangThai = a.TrangThai
                       }).OrderBy(c => c.Ma).ToList();
            return lst.Where(c => c.Ma.ToLower().Contains(obj.ToLower()) || c.Ten.ToLower().Contains(obj.ToLower())).OrderBy(c => c.Ma).ToList();
        }

        public string Update(KhachHangView obj)
        {
            try
            {
                var x = new KhachHang()
                {
                    Id = obj.Id,
                    //Idnv = obj.Idnv,
                    IdtichDiem = obj.IdtichDiem,
                    Ma = obj.Ma,
                    Ten = obj.Ten,
                    Sdt = obj.Sdt,
                    DiaChi = obj.DiaChi,
                    TrangThai = obj.TrangThai
                };
                if (_iKhachHangRepos.Update(x)) return "Sửa thành công";
                return "Sửa không Thành Công";
            }
            catch (Exception e)
            {
                return e.Message.ToString();
            }
        }
        private string MaTT()
        {
            if (_iKhachHangRepos.GetAll().Count > 0)
            {
                return "KH" + Convert.ToString(_iKhachHangRepos.GetAll().Max(c => Convert.ToInt32(c.Ma.Substring(2, c.Ma.Length - 2)) + 1));
            }
            else return "KH1";
        }
    }
}
