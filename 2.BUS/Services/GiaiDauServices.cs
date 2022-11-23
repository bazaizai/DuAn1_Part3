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
    public class GiaiDauServices : IGiaiDauServices
    {
        private IGiaiDauRepos _giaiDauRepos;
        private List<GiaiDauView> lstGiaidau;
        public GiaiDauServices()
        {
            _giaiDauRepos = new GiaiDauRepos();
            lstGiaidau = new List<GiaiDauView>();
        }
        public string Add(GiaiDauView giaiDau)
        {
            if (giaiDau == null) return "Thêm thất bại";
            GiaiDau x = new GiaiDau()
            {
                Id = giaiDau.Id,
                Ma = MaTS(),
                Ten = giaiDau.Ten,
                TrangThai = giaiDau.TrangThai,
            };
            if (_giaiDauRepos.Add(x)) return "Thêm thành công";
            return "Thêm thất bại";
        }

        public string Delete(Guid id)
        {
            var x = _giaiDauRepos.GetAll().FirstOrDefault(c => c.Id == id);
            if (_giaiDauRepos.Delete(x)) return "Xóa thành công";
            return "Xóa thất bại";
        }
     
        public string Delete(GiaiDauView giaiDau)
        {
            if (giaiDau == null) return "Xóa thất bại";
            GiaiDau giaiDau1 = new GiaiDau()
            {
                Id = giaiDau.Id,
                Ma = giaiDau.Ma,
                Ten = giaiDau.Ten,
                TrangThai = giaiDau.TrangThai,
            };
            _giaiDauRepos.Delete(giaiDau1);
            return "Xóa thành công";
        }

        public List<GiaiDauView> GetAll()
        {
            lstGiaidau = (from a in _giaiDauRepos.GetAll()
                          select new GiaiDauView{
                              Id = a.Id,
                              Ma = a.Ma,
                              Ten = a.Ten,
                              TrangThai = a.TrangThai,
                          }).OrderBy(c => c.Ma).ToList();
            return lstGiaidau;
        }

        public Guid GetIdByName(string name)
        {
            return GetAll().FirstOrDefault(x => x.Ten == name).Id;
        }

        public string MaTS()
        {
            if (_giaiDauRepos.GetAll().Count == 0) return "GD1";
            return "GD" + (_giaiDauRepos.GetAll().Max(x => Convert.ToInt32(x.Ma.Substring(2, x.Ma.Length - 2)) )+1);
            
        }
        public string Update(GiaiDauView giaiDau)
        {
            var x = _giaiDauRepos.GetAll().FirstOrDefault(c => c.Id == giaiDau.Id);
            x.Id = giaiDau.Id;
            x.Ma = giaiDau.Ma;
            x.Ten = giaiDau.Ten;
            x.TrangThai = giaiDau.TrangThai;
            if (_giaiDauRepos.Update(x)) return "Sửa thành công";
            return "Không thành công";
        }
    }
}
