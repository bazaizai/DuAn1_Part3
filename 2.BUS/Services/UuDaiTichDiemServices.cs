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
    public class UuDaiTichDiemServices : IUuDaiTichDiemServices
    {
        IUuDaiTichDiemRepos _iUuDaiTichDiemRepos;
        public UuDaiTichDiemServices()
        {
            _iUuDaiTichDiemRepos = new UuDaiTichDiemRepos();
        }
        public string Add(UuDaiTichDiemView obj)
        {
            try
            {
                var x = new UdtichDiem()
                {
                    Id = obj.Id,
                    Ma = MaTT(),
                    LoaiHinhKm = obj.LoaiHinhKm,
                    MucUuDai = obj.MucUuDai,
                    SoDiem = obj.SoDiem,
                    TrangThai = obj.TrangThai
                };
                if (_iUuDaiTichDiemRepos.Add(x)) return "Thành Công";
                return "Không Thành Công";
            }
            catch (Exception e)
            {
                return e.Message.ToString();
            }
        }

        public string Delete(UuDaiTichDiemView obj)
        {
            try
            {
                var x = new UdtichDiem()
                {
                    Id = obj.Id
                };
                if (_iUuDaiTichDiemRepos.Delete(x)) return "Thành Công";
                return "Không Thành Công";
            }
            catch (Exception e)
            {

                return e.Message.ToString();
            }
        }

        public List<UuDaiTichDiemView> GetAll()
        {
            var lst = (from a in _iUuDaiTichDiemRepos.GetAll()
                       select new UuDaiTichDiemView()
                       {
                           Id = a.Id,
                           Ma = a.Ma,
                           LoaiHinhKm = a.LoaiHinhKm,
                           MucUuDai = a.MucUuDai,
                           SoDiem = a.SoDiem,
                           TrangThai = a.TrangThai
                       }).OrderBy(c => c.Ma).ToList();
            return lst;
        }

        public UuDaiTichDiemView GetByID(Guid id)
        {
            var a = _iUuDaiTichDiemRepos.GetById(id);
            var x = new UuDaiTichDiemView()
            {
                Id = a.Id,
                Ma = a.Ma,
                LoaiHinhKm = a.LoaiHinhKm,
                MucUuDai = a.MucUuDai,
                SoDiem = a.SoDiem,
                TrangThai = a.TrangThai
            };
            return x;
        }
        public string Update(UuDaiTichDiemView obj)
        {
            try
            {
                var x = new UdtichDiem()
                {
                    Id = obj.Id,
                    Ma = obj.Ma,
                    LoaiHinhKm = obj.LoaiHinhKm,
                    MucUuDai = obj.MucUuDai,
                    SoDiem = obj.SoDiem,
                    TrangThai = obj.TrangThai
                };
                if (_iUuDaiTichDiemRepos.Update(x)) return "Thành Công";
                return "Không Thành Công";
            }
            catch (Exception e)
            {
                return e.Message.ToString();
            }
        }
        private string MaTT()
        {
            if (_iUuDaiTichDiemRepos.GetAll().Count > 0)
            {
                return "UD" + Convert.ToString(_iUuDaiTichDiemRepos.GetAll().Max(c => Convert.ToInt32(c.Ma.Substring(2, c.Ma.Length - 2)) + 1));
            }
            else return "UD1";
        }
    }
}
