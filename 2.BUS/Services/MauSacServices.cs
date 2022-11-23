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
    public class MauSacServices : IMauSacServices
    {
        private IMauSacRepos _iMauSacRepos;
        public MauSacServices()
        {
            _iMauSacRepos = new MauSacRepos();
        }
        public string MaTS()
        {
            if (_iMauSacRepos.GetAll().Count == 0) return "MS1";
            return "MS" + (_iMauSacRepos.GetAll().Max(x => Convert.ToInt32(x.Ma.Substring(2, x.Ma.Length - 2))) + 1);

        }
        public string Add(MauSacView obj)
        {
            if (obj == null) return "thêm thất bại";
            MauSac ms = new MauSac()
            {
                Id = obj.Id,
                Ma = MaTS(),
                Ten = obj.Ten,
                TrangThai = obj.TrangThai
            };
            if (_iMauSacRepos.Add(ms)) return "thêm thành công";
            return "thêm thất bại";
        }

        public string Delete(MauSacView obj)
        {
            if (obj == null) return "xóa thất bại";
            MauSac ms = new MauSac()
            {
                Id = obj.Id,
                Ma = obj.Ma,
                Ten = obj.Ten,
                TrangThai = obj.TrangThai
            };
            if (_iMauSacRepos.Delete(ms)) return "xóa thành công";
            return "xóa thất bại";
        }

        public List<MauSacView> GetAll()
        {
            List<MauSacView> _lstMauSac = new List<MauSacView>();
            _lstMauSac = (
                from a in _iMauSacRepos.GetAll()
                select new MauSacView()
                {
                    Id = a.Id,
                    Ma = a.Ma,
                    Ten = a.Ten,
                    TrangThai = a.TrangThai
                }).ToList();
            return _lstMauSac;
        }

        public string Update(MauSacView obj)
        {
            if (obj == null) return "sửa thất bại";
            MauSac ms = new MauSac()
            {
                Id = obj.Id,
                Ma = obj.Ma,
                Ten = obj.Ten,
                TrangThai = obj.TrangThai
            };
            if (_iMauSacRepos.Update(ms)) return "sửa thành công";
            return "sửa thất bại";
        }
    }
}
