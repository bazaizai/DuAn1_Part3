using _1.DAL.DomainClass;
using _1.DAL.IRepositories;
using _1.DAL.Repositories;
using _2.BUS.IServices;
using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.Services
{
    public class KieuSpServices : IKieuSpServices
    {
        IKieuSpRepos _IKieuSpRespos;
        public KieuSpServices()
        {
            _IKieuSpRespos = new KieuSpRepos();
        }
        public string Add(KieuSpView Obj)=> Obj != null && GetAll().All(x => x.Ten != Obj.Ten) && _IKieuSpRespos.Add(new KieuSp(Obj.Id,Obj.IdCha,Obj.Ma,Obj.Ten,Obj.TrangThai)) ? "Add success" : "Add not success";
        public string Delete(KieuSpView Obj) => Obj != null && _IKieuSpRespos.Delete(_IKieuSpRespos.GetAll().Find(x => x.Id == Obj.Id)) ? "Delete success" : "Delete not success";

        public List<KieuSpView> GetAll() => (from a in _IKieuSpRespos.GetAll()
                                            select new KieuSpView()
                                            {
                                                Id = a.Id,
                                                Ma = a.Ma,
                                                Ten = a.Ten,
                                                IdCha = a.IdCha,
                                                TrangThai = a.TrangThai,
                                            }).OrderBy(x=>x.Ma).ToList();

        public KieuSpView GetById(Guid Id) => GetAll().Find(x => x.Id == Id);


        public string Mats() => "KSP" + Convert.ToString(_IKieuSpRespos.GetAll().Count == 0 ? 1 : _IKieuSpRespos.GetAll().Max(x => Convert.ToInt32(x.Ma.Substring(3, x.Ma.Length - 3)) + 1));

        public string Update(KieuSpView Obj)
        {
            if (Obj == null) return "Update not success";
            var x = _IKieuSpRespos.GetAll().FirstOrDefault(x => x.Id == Obj.Id);
                x.IdCha = Obj.IdCha;
                x.Ma = Obj.Ma;
                x.Ten = Obj.Ten;
                x.TrangThai = Obj.TrangThai;
               if( _IKieuSpRespos.Update(x)) return "Update success";
            return "Khong thanh cong";
        }
    }
}
