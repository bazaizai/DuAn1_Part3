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
    public class AnhServices : IAnhServices
    {
        IAnhRespos _IAnhRespo;
        IChiTietSpRespos _IChiTietSPRepos;
        public AnhServices()
        {
            _IAnhRespo = new AnhRespos();
            _IChiTietSPRepos = new ChiTietSpRespos();
        }

        public string Add(AnhViews Obj) => Obj != null && _IAnhRespo.Add(new Anh(Obj.IdChiTietSp, Obj.TenAnh, Obj.DuongDan, Obj.TrangThai)) ? "Add succsess" : "Add not succsess";

        public string Delete(AnhViews Obj) => Obj != null && _IAnhRespo.Delete(_IAnhRespo.GetAll().Find(x => x.Id == Obj.Id)) ? "Delete success" : "Delete not succsess";

        public List<AnhViews> GetAll() =>( from a in _IAnhRespo.GetAll() join sp in _IChiTietSPRepos.GetAll() on a.IdChiTietSp equals sp.Id
                                         select new AnhViews()
                                         {
                                             Id = a.Id,
                                             IdChiTietSp = a.IdChiTietSp,
                                             TenAnh = a.TenAnh,
                                             DuongDan = a.DuongDan,
                                             TrangThai = a.TrangThai,
                                             BaoHanh = sp.BaoHanh,
                                             GiaBan = sp.GiaBan,
                                             TrangThaiSP = sp.TrangThai,
                                             IdChatLieu = sp.IdChatLieu,
                                             IdKichCo = sp.IdKichCo,
                                             IdMauSac=sp.IdMauSac,
                                             IdSp = sp.IdSp,
                                             IdTeam = sp.IdTeam,
                                             SoLuongTon = sp.SoLuongTon ,
                                             MoTa = sp.MoTa,
                                             TrangThaiKhuyenMai= sp.TrangThaiKhuyenMai,

                                         }).ToList();

        public AnhViews GetByID(Guid ID) => GetAll().Find(x => x.Id == ID);

        public string Update(AnhViews Obj)
        {
            if (Obj == null) return "Updat not success";
            var x = _IAnhRespo.GetById(Obj.Id);
            x.TenAnh = Obj.TenAnh;
            x.DuongDan = Obj.DuongDan;
            x.TrangThai = Obj.TrangThai;
            _IAnhRespo.Update(x);
            return "Update success";
        }
    }
}
