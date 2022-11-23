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
    public class HinhThucMhServices : IHinhThucMhServices
    {
        private IHinhThucMhRepos _IHinhThucMhRepos;
        private List<HinhThucMhViews> _lstSp;

        public HinhThucMhServices()
        {
            _IHinhThucMhRepos = new HinhThucMhRepos();
            _lstSp = new List<HinhThucMhViews>();
        }

        public string Add(HinhThucMhViews obj)
        {
            if (obj == null) return "Thêm Không thành công";

            HinhThucMh Sp = new HinhThucMh()
            {
                Id = obj.Id,
                Ma = MaTT(),
                Ten = obj.Ten,
                TrangThai = obj.TrangThai,
            };
            if (_IHinhThucMhRepos.Add(Sp)) return "Thêm thành công";
            return "Thêm Không thành công";
        }



        public string Delete(HinhThucMhViews obj)
        {
            if (obj == null) return "Delete Không thành công";

            var x = _IHinhThucMhRepos.GetAll().FirstOrDefault(p => p.Id == obj.Id);
            if (_IHinhThucMhRepos.Delete(x)) return "Delete thành công";
            return "Delete Không thành công";
        }

        public List<HinhThucMhViews> GetAll()
        {
            _lstSp = (from a in _IHinhThucMhRepos.GetAll()
                      select new HinhThucMhViews
                      {
                          Id = a.Id,
                          Ma = a.Ma,
                          Ten = a.Ten,
                          TrangThai = a.TrangThai
                      }).ToList();
            return _lstSp;
        }

        public string Update(HinhThucMhViews obj)
        {
            if (obj == null) return "Update Không thành công";
            var x = _IHinhThucMhRepos.GetAll().FirstOrDefault(p => p.Id == obj.Id);
            x.Id = obj.Id;
            x.Ma = obj.Ma;
            x.Ten = obj.Ten;
            x.TrangThai = obj.TrangThai;
            if (_IHinhThucMhRepos.Update(x)) return "Update thành công";
            return "Update Không thành công";
        }
        private string MaTT()
        {
            if (_IHinhThucMhRepos.GetAll().Count > 0)
            {
                return "HTMH" + Convert.ToString(_IHinhThucMhRepos.GetAll().Max(c => Convert.ToInt32(c.Ma.Substring(4, c.Ma.Length - 4)) + 1));
            }
            else return "HTMH1";
        }
    }
}
