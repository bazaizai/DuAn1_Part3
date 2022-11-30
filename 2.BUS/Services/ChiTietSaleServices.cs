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
    public class ChiTietSaleServices : IChiTietSaleServices
    {
        private IChiTietSaleRepos _chiTietSaleRepos;
        private ISaleRepos _saleRepos;
        private List<ChiTietSaleView> lstctSale;
        private IChiTietSpServices _chiTietSpServices;
        private ISanPhamRepos _ISanPhamRepos;
        private IMauSacRepos _IMauSacRepos;
        private ITeamRepos _ITeamRepos;
        public ChiTietSaleServices()
        {
            _chiTietSaleRepos = new ChiTietSaleRepos();
            _saleRepos = new SaleRepos();
            lstctSale = new List<ChiTietSaleView>();
            _chiTietSpServices = new ChiTietSpServices();
            _ISanPhamRepos = new SanPhamRepos();
            _IMauSacRepos = new MauSacRepos();
            _ITeamRepos = new TeamRepos();
        }
        public string Add(ChiTietSaleView chiTietSale)
        {
            if (chiTietSale == null) return "Thêm thất bại";
            ChiTietSale x = new ChiTietSale()
            {
                Id = chiTietSale.Id,
                IdSale = chiTietSale.IdSale,
                IdChiTietSp = chiTietSale.IdChiTietSp,
                MoTa = chiTietSale.MoTa,
                TrangThai = chiTietSale.TrangThai,
            };
            if (_chiTietSaleRepos.Add(x)) return "Thêm thành công";
            return "Thêm thất bại";
        }

        public string Delete(Guid id)
        {
            var x = _chiTietSaleRepos.GetAll().FirstOrDefault(c => c.Id == id);
            if (_chiTietSaleRepos.Delete(x)) return "Xóa thành công";
            return "Xóa thất bại";
        }

        public string Delete(ChiTietSaleView chiTietSale)
        {
            if (chiTietSale == null) return "Xóa thất bại";
            ChiTietSale sale = new ChiTietSale
            {
                Id = chiTietSale.Id,
                IdSale = chiTietSale.IdSale,
                IdChiTietSp = chiTietSale.IdChiTietSp,
                MoTa = chiTietSale.MoTa,
                TrangThai = chiTietSale.TrangThai,
            };
            _chiTietSaleRepos.Delete(sale);
            return "Xóa thành công";
        }

        public List<ChiTietSaleView> GetAll()
        {
            lstctSale = (from a in _chiTietSaleRepos.GetAll()
                         join b in _saleRepos.GetAll()
                         on a.IdSale equals b.Id
                         join c in (from ctsp in _chiTietSpServices.GetAll()
                                    join d in _ISanPhamRepos.GetAll() on ctsp.IdSp equals d.Id
                                    join e in _IMauSacRepos.GetAll() on ctsp.IdMauSac equals e.Id
                                    join g in _ITeamRepos.GetAll() on ctsp.IdTeam equals g.Id
                                    select new ChiTietSpViews
                                    {
                                        Id = ctsp.Id,
                                        TenSP = d.Ten,
                                        TenMauSac = e.Ten,
                                        TenTeam= g.Ten,
                                    }).ToList() on a.IdChiTietSp equals c.Id
                         select new ChiTietSaleView
                         {
                             Id = a.Id,
                             IdSale = a.IdSale,
                             MaSale = b.Ma,
                             TenSale = b.Ten,
                             MoTa = a.MoTa,
                             TrangThai = a.TrangThai,
                             IdChiTietSp= a.IdChiTietSp,
                             TenSanPham = c.TenSP,
                             Team = c.TenTeam,
                             MauSac= c.TenMauSac
                         }).ToList();
            return lstctSale;
        }

        public string Update(ChiTietSaleView chiTietSale)
        {
            var x = _chiTietSaleRepos.GetAll().FirstOrDefault(c => c.Id == chiTietSale.Id);
            x.Id = chiTietSale.Id;
            x.IdSale = chiTietSale.IdSale;
            x.IdChiTietSp = chiTietSale.IdChiTietSp;
            x.MoTa = chiTietSale.MoTa;
            x.TrangThai = chiTietSale.TrangThai;
            if (_chiTietSaleRepos.Update(x)) return "Sửa thành công";
            return "Không thành công";
        }
    }
}
