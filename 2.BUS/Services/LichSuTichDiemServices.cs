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
    public class LichSuTichDiemServices:ILichSuTichDiemServices
    {
        ILichSuTichDiemRepos _iLichSuTichDiemRepos;
        ITichDiemRepos _iTichDiemRepos;
        ICtTichDiemRepos _iCtTichDiemRepos;
        IHoaDonRepos _iHoaDonRepos;
        public LichSuTichDiemServices()
        {
            _iLichSuTichDiemRepos = new LichSuTichDiemRepos();
            _iTichDiemRepos = new TichDiemRepos();
            _iCtTichDiemRepos = new CtTichDiemRepos();
            _iHoaDonRepos = new HoaDonRepos();
        }
        public string Add(LichSuTichDiemView obj)
        {
            try
            {
                var x = new LstichDiem()
                {
                    Id = obj.Id,
                    SoDiemDung = obj.SoDiemDung,
                    NgayTichDiem = obj.NgayTichDiem,
                    TrangThai = obj.TrangThai
                };
                if (_iLichSuTichDiemRepos.Add(x)) return "Thành Công";
                return "Không Thành Công";
            }
            catch (Exception e)
            {
                return e.Message.ToString();
            }
        }

        public string Delete(LichSuTichDiemView obj)
        {
            try
            {
                var x = new LstichDiem()
                {
                    Id = obj.Id
                };
                if (_iLichSuTichDiemRepos.Delete(x)) return "Thành Công";
                return "Không Thành Công";
            }
            catch (Exception e)
            {

                return e.Message.ToString();
            }
        }

        public List<LichSuTichDiemView> GetAll()
        {
            var lst = (from lstd in _iLichSuTichDiemRepos.GetAll()
                       join td in _iTichDiemRepos.GetAll() on lstd.IdTichDiem equals td.Id
                       join hd in _iHoaDonRepos.GetAll() on lstd.IdHoaDon equals hd.Id
                       //join c in (from cttd in _iCtTichDiemRepos.GetAll()
                       //           join hd in _iHoaDonRepos.GetAll() on cttd.Id equals hd.Id
                       //           select new HoaDonViews()
                       //           {
                       //               Id = hd.Id,
                       //               IdHoaDon = cttd.IdHoaDon,
                       //               MaHD = hd.Ma,
                       //               TrangThai = cttd.TrangThai,
                       //               HeSoTich = cttd.HeSoTich,
                       //               TongTienSauKhiGiam = hd.TongTienSauKhiGiam
                       //           }).ToList() on lstd.IdCttinhDiem equals c.Id
                       select new LichSuTichDiemView()
                       {
                           Id = lstd.Id,
                           IdHoaDon = hd.IdKh,
                           TenKH = Convert.ToString(lstd.IdHoaDon),
                           SoDiemDung = lstd.SoDiemDung,
                           NgayTichDiem = lstd.NgayTichDiem,
                           TrangThai = lstd.TrangThai
                       }).ToList();
            return lst;
        }

        public LichSuTichDiemView GetByID(Guid id)
        {
            var a = _iLichSuTichDiemRepos.GetById(id);
            var x = new LichSuTichDiemView()
            {
                Id = a.Id,
                SoDiemDung = a.SoDiemDung,
                NgayTichDiem = a.NgayTichDiem,
                TrangThai = a.TrangThai
            };
            return x;
        }

        //public List<LichSuTichDiemView> Search(string obj)
        //{
        //    var lst = (from a in _iLichSuTichDiemRepos.GetLstichDiems()
        //               select new LichSuTichDiemView()
        //               {
        //                   Id = a.Id,
        //                   HeSoTich = a.HeSoTich,
        //                   TrangThai = a.TrangThai
        //               }).ToList();
        //    return lst.Where(c => c.Ma.ToLower().Contains(obj.ToLower()) || c.Ten.ToLower().Contains(obj.ToLower())).OrderBy(c => c.Ma).ToList();
        //}

        public string Update(LichSuTichDiemView obj)
        {
            try
            {
                var x = new LstichDiem()
                {
                    Id = obj.Id,
                    SoDiemDung = obj.SoDiemDung,
                    NgayTichDiem = obj.NgayTichDiem,
                    TrangThai = obj.TrangThai
                };
                if (_iLichSuTichDiemRepos.Update(x)) return "Thành Công";
                return "Không Thành Công";
            }
            catch (Exception e)
            {
                return e.Message.ToString();
            }
        }
    }
}
