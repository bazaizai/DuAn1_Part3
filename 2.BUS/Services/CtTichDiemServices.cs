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
    public class CtTichDiemServices : ICtTichDiemServices
    {
        private ICtTichDiemRepos _iCtTinhDiemRepos;
        public CtTichDiemServices()
        {
            _iCtTinhDiemRepos = new CtTichDiemRepos();
        }
        public string Add(CtTinhDiemView obj)
        {
            if (obj == null) return "Thêm thất bại";
            CttichDiem vcv = new CttichDiem()
            {
                Id = obj.Id,
                HeSoTich = obj.HeSoTich,
                TrangThai = obj.TrangThai
            };
            if (_iCtTinhDiemRepos.Add(vcv)) return "Thêm thành công";
            return "Thêm thất bại";
        }

        public string Delete(CtTinhDiemView obj)
        {
            if (obj == null) return "Xóa thất bại";
            CttichDiem vcv = new CttichDiem()
            {
                Id = obj.Id,
                HeSoTich = obj.HeSoTich,
                TrangThai = obj.TrangThai
            };
            if (_iCtTinhDiemRepos.Delete(vcv)) return "Xóa thành công";
            return "Xóa thất bại";
        }

        public List<CtTinhDiemView> GetAll()
        {
            List<CtTinhDiemView> _lstCtTinhDiem = new List<CtTinhDiemView>();
            _lstCtTinhDiem = (
                from a in _iCtTinhDiemRepos.GetAll()
                select new CtTinhDiemView()
                {
                    Id = a.Id,
                    HeSoTich = a.HeSoTich,
                    TrangThai = a.TrangThai
                }).ToList();
            return _lstCtTinhDiem;
        }

        public string Update(CtTinhDiemView obj)
        {
            if (obj == null) return "Cập nhật thất bại";
            CttichDiem vcv = new CttichDiem()
            {
                Id = obj.Id,
                HeSoTich = obj.HeSoTich,
                TrangThai = obj.TrangThai
            };
            if (_iCtTinhDiemRepos.Update(vcv)) return "Cập nhật thành công";
            return "Cập nhật thất bại";
        }
    }
}
