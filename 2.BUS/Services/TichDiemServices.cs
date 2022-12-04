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
    public class TichDiemServices : ITichDiemServices
    {
        ITichDiemRepos _iTichDiemRepos;
        //IHoaDonRepos _iHoaDonRepos;
        public TichDiemServices()
        {
            _iTichDiemRepos = new TichDiemRepos();
            ////_iHoaDonRepos = new HoaDonRepos();
        }
        public string Add(TichDiemView obj)
        {
            try
            {
                var x = new TichDiem()
                {
                    Id = obj.Id,
                    SoDiem = obj.SoDiem,
                    TrangThai = obj.TrangThai
                };
                if (_iTichDiemRepos.Add(x)) return "Thêm tích điểm thành công";
                return "Thêm tích điểm không thành công";
            }
            catch (Exception e)
            {
                return e.Message.ToString();
            }
        }

        public string Delete(TichDiemView obj)
        {
            try
            {
                var x = new TichDiem()
                {
                    Id = obj.Id
                };
                if (_iTichDiemRepos.Delete(x)) return "Thành Công";
                return "Không Thành Công";
            }
            catch (Exception e)
            {

                return e.Message.ToString();
            }
        }

        public List<TichDiemView> GetAll()
        {
            var lst = (from a in _iTichDiemRepos.GetAll()                      
                       select new TichDiemView()
                       {
                           Id = a.Id,
                           SoDiem = a.SoDiem,
                           TrangThai = a.TrangThai
                       }).ToList();
            return lst;
        }

        public TichDiemView GetByID(Guid id)
        {
            var a = _iTichDiemRepos.GetById(id);
            var x = new TichDiemView()
            {
                Id = a.Id,
                SoDiem = a.SoDiem,
                TrangThai = a.TrangThai
            };
            return x;
        }

        //public List<TichDiemView> Search(string obj)
        //{
        //    throw new NotImplementedException();
        //}

        public string Update(TichDiemView obj)
        {
            try
            {
                var x = new TichDiem()
                {
                    Id = obj.Id,
                    SoDiem = obj.SoDiem,
                    TrangThai= obj.TrangThai
                };
                if (_iTichDiemRepos.Update(x)) return "Thành Công";
                return "Không Thành Công";
            }
            catch (Exception e)
            {
                return e.Message.ToString();
            }
        }
    }
}
