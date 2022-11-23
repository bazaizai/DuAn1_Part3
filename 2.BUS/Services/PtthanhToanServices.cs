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
    public class PtthanhToanServices:IPtthanhToanServices
    {
        private IPtthanhToanRepos _IPtthanhToanReposy;
        private List<PtthanhToanViews> _lstSp;
        public PtthanhToanServices()
        {
            _IPtthanhToanReposy = new PtthanhToanRepos();
            _lstSp = new List<PtthanhToanViews>();
        }


        public string Add(PtthanhToanViews obj)
        {
            if (obj == null) return "Thêm Không thành công";

            PtthanhToan Sp = new PtthanhToan()
            {
                Id = obj.Id,
                Ma = MaTT(),
                Ten = obj.Ten,
                TrangThai = obj.TrangThai,
            };
            if (_IPtthanhToanReposy.Add(Sp)) return "Thêm thành công";
            return "Thêm Không thành công";
        }



        public string Delete(PtthanhToanViews obj)
        {
            if (obj == null) return "Delete Không thành công";

            var x = _IPtthanhToanReposy.GetAll().FirstOrDefault(p => p.Id == obj.Id);
            if (_IPtthanhToanReposy.Delete(x)) return "Delete thành công";
            return "Delete Không thành công";
        }

        public List<PtthanhToanViews> GetAll()
        {
            _lstSp = (from a in _IPtthanhToanReposy.GetAll()
                      select new PtthanhToanViews
                      {
                          Id = a.Id,
                          Ma = a.Ma,
                          Ten = a.Ten,
                          TrangThai = a.TrangThai
                      }).ToList();
            return _lstSp;
        }

        public string Update(PtthanhToanViews obj)
        {
            if (obj == null) return "Update Không thành công";
            var x = _IPtthanhToanReposy.GetAll().FirstOrDefault(p => p.Id == obj.Id);
            x.Id = obj.Id;
            x.Ma = obj.Ma;
            x.Ten = obj.Ten;
            x.TrangThai = obj.TrangThai;
            if (_IPtthanhToanReposy.Update(x)) return "Update thành công";
            return "Update Không thành công";
        }
        private string MaTT()
        {
            if (_IPtthanhToanReposy.GetAll().Count > 0)
            {
                return "PTTT" + Convert.ToString(_IPtthanhToanReposy.GetAll().Max(c => Convert.ToInt32(c.Ma.Substring(4, c.Ma.Length - 4)) + 1));
            }
            else return "PTTT1";
        }
    }
}
