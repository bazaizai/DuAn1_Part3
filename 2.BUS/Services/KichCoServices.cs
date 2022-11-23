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
    public class KichCoServices:IKichCoServices
    {
        private IKichCoRepos _IKichCoRepos;
        private List<KichCoViews> _lstSp;

        public KichCoServices()
        {
            _IKichCoRepos = new KichCoRepos();
            _lstSp = new List<KichCoViews>();
        }

        public string Add(KichCoViews obj)
        {
            if (obj == null) return "Thêm Không thành công";

            KichCo Sp = new KichCo()
            {
                Id = obj.Id,
                Ma = MaTT(),
                Size = obj.Size,
                Cm = obj.Cm,
                TrangThai = obj.TrangThai
            };
            if (_IKichCoRepos.Add(Sp)) return "Thêm thành công";
            return "Thêm Không thành công";
        }



        public string Delete(KichCoViews obj)
        {
            if (obj == null) return "Delete Không thành công";

            var x = _IKichCoRepos.GetAll().FirstOrDefault(p => p.Id == obj.Id);
            if (_IKichCoRepos.Delete(x)) return "Delete thành công";
            return "Delete Không thành công";
        }

        public List<KichCoViews> GetAll ()
        {
            _lstSp = (from a in _IKichCoRepos.GetAll()
                      select new KichCoViews
                      {
                          Id = a.Id,
                          Ma = a.Ma,
                          Size = a.Size,
                          Cm = a.Cm,
                          TrangThai = a.TrangThai,

                      }).ToList();
            return _lstSp;
        }

        public string Update(KichCoViews obj)
        {
            if (obj == null) return "Update Không thành công";
            var x = _IKichCoRepos.GetAll().FirstOrDefault(p => p.Id == obj.Id);
            x.Id = obj.Id;
            x.Ma = obj.Ma;
            x.Size = obj.Size;
            x.TrangThai = obj.TrangThai;
            if (_IKichCoRepos.Update(x)) return "Update thành công";
            return "Update Không thành công";
        }

        private string MaTT()
        {
            if (_IKichCoRepos.GetAll().Count > 0)
            {
                return "KC" + Convert.ToString(_IKichCoRepos.GetAll().Max(c => Convert.ToInt32(c.Ma.Substring(2, c.Ma.Length - 2)) + 1));
            }
            else return "KC1";
        }

    }
}
