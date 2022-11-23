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
    public class ChucVuServices : IChucVuServices
    {
        private IChucVuRepos _iChucVuRepos;
        public ChucVuServices()
        {
            _iChucVuRepos = new ChucVuRepos();
        }
        public string MaTS()
        {
            if (_iChucVuRepos.GetAll().Count == 0) return "CV1";
            return "CV" + (_iChucVuRepos.GetAll().Max(x => Convert.ToInt32(x.Ma.Substring(2, x.Ma.Length - 2))) + 1);

        }
        public string Add(ChucVuView obj)
        {
            if (obj == null) return "Thêm thất bại";
            ChucVu vcv = new ChucVu()
            {
                Id = obj.Id,
                Ma = MaTS(),
                Ten = obj.Ten,
                TrangThai = obj.TrangThai
            };
            if (_iChucVuRepos.Add(vcv)) return "thêm thành công";
            return "thêm thất bại";
        }

        public string Delete(ChucVuView obj)
        {
            if (obj == null) return "xóa thất bại";
            ChucVu vcv = new ChucVu()
            {
                Id = obj.Id,
                Ma = obj.Ma,
                Ten = obj.Ten,
                TrangThai = obj.TrangThai
            };
            if (_iChucVuRepos.Delete(vcv)) return "xóa thành công";
            return "xóa thất bại";
        }

        public List<ChucVuView> GetAll()
        {
            List<ChucVuView> _lstChucVu = new List<ChucVuView>();
            _lstChucVu = (
                from a in _iChucVuRepos.GetAll()
                select new ChucVuView()
                {
                    Id = a.Id,
                    Ma = a.Ma,
                    Ten = a.Ten,
                    TrangThai = a.TrangThai
                }).ToList();
            return _lstChucVu;
        }

        public string Update(ChucVuView obj)
        {
            if (obj == null) return "sửa thất bại";
            ChucVu vcv = new ChucVu()
            {
                Id = obj.Id,
                Ma = obj.Ma,
                Ten = obj.Ten,
                TrangThai = obj.TrangThai
            };
            if(_iChucVuRepos.Update(vcv)) return"sửa thành công";
            return "sửa thất bại";
        }
    }
}
