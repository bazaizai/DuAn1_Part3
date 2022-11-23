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
    public class SanPhamServices:ISanPhamServices
    {
        private ISanPhamRepos _iSanPhamRepository;
        private List<SanPhamViews> _lstSp;

        public SanPhamServices()
        {         
                _iSanPhamRepository = new SanPhamRepos();
                _lstSp = new List<SanPhamViews>();
        }

        public string Add(SanPhamViews obj)
        {
            if (obj == null) return "Thêm Không thành công";

            SanPham Sp = new SanPham()
            {
                Id = obj.Id,
                Ma = MaTT(),
                Ten = obj.Ten, 
                TrangThai=obj.TrangThai
            };
            if (_iSanPhamRepository.Add(Sp)) return "Thêm thành công";
            return "Thêm Không thành công";
        }

     

        public string Delete(SanPhamViews obj)
        {
            if (obj == null) return "Delete Không thành công";

            var x = _iSanPhamRepository.GetAll().FirstOrDefault(p => p.Id == obj.Id);
            if (_iSanPhamRepository.Delete(x)) return "Delete thành công";
            return "Delete Không thành công";
        }     

        public List<SanPhamViews> GetAll()
        {
            _lstSp = (from a in _iSanPhamRepository.GetAll()
                      select new SanPhamViews
                      {
                          Id = a.Id,
                          Ma = a.Ma,
                          Ten = a.Ten,
                          TrangThai=a.TrangThai
                      }).ToList();
            return _lstSp;
        }

        public string Update(SanPhamViews obj)
        {
            if (obj == null) return "Update Không thành công";
            var x = _iSanPhamRepository.GetAll().FirstOrDefault(p => p.Id == obj.Id);
            x.Id = obj.Id;
            x.Ma = obj.Ma;
            x.Ten = obj.Ten;
            x.TrangThai=obj.TrangThai;
            if (_iSanPhamRepository.Update(x)) return "Update thành công";
            return "Update Không thành công";
        }

        private string MaTT()
        {
            if (_iSanPhamRepository.GetAll().Count > 0)
            {
                return "SP" + Convert.ToString(_iSanPhamRepository.GetAll().Max(c => Convert.ToInt32(c.Ma.Substring(2, c.Ma.Length - 2)) + 1));
            }
            else return "SP1";
        }
    }
}
