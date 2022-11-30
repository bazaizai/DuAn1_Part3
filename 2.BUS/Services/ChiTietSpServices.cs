using _1.DAL.DomainClass;
using _1.DAL.IRepositories;
using _1.DAL.Repositories;
using _2.BUS.IServices;
using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;

namespace _2.BUS.Services
{
    public class ChiTietSpServices : IChiTietSpServices
    {
        IChiTietSpRespos _IChiTietSpRespos;
        IKichCoRepos _ISizeRepos;
        IMauSacRepos _IMauSacRepos;
        ISanPhamRepos _ISanPhamRepos;
        IChatLieuRepos _IChatLieuRepos;
        ITeamRepos _ITeamRepos;
        IGiaiDauRepos _IGiaiDauRepos;
        IKieuSpRepos _IKieuSpRepos;
        IChiTietKieuSpRespos _IChiTietKieuSpRespos;
        public ChiTietSpServices()
        {
            _IChiTietSpRespos = new ChiTietSpRespos();
            _ISizeRepos = new KichCoRepos();
            _IMauSacRepos = new MauSacRepos();
            _ISanPhamRepos = new SanPhamRepos();
            _IChatLieuRepos = new ChatLieuRepos();
            _ITeamRepos = new TeamRepos();
            _IGiaiDauRepos = new GiaiDauRepos();
            _IKieuSpRepos =new KieuSpRepos();
            _IChiTietKieuSpRespos = new ChiTietKieuSpRespos();
        }
        public bool Add(ChiTietSpViews Obj) => Obj != null && _IChiTietSpRespos.Add(new ChiTietSp(Obj.Id,Obj.IdSp, Obj.IdMauSac, Obj.IdSize, Obj.IdTeam, Obj.IdChatLieu,Obj.MaQr, Obj.BaoHanh, Obj.MoTa, Obj.SoLuongTon, Obj.GiaNhap, Obj.GiaBan, Obj.TrangThaiKhuyenMai, Obj.TrangThai));

        public bool Delete(ChiTietSpViews Obj)=> Obj != null && _IChiTietSpRespos.Delete(_IChiTietSpRespos.GetAll().Find(x => x.Id == Obj.Id));


        public List<ChiTietSpViews> GetAll() => (from spct in _IChiTietSpRespos.GetAll()
                                                 join s in _ISizeRepos.GetAll() on spct.IdKichCo equals s.Id
                                                 join ms in _IMauSacRepos.GetAll() on spct.IdMauSac equals ms.Id
                                                 join sp in _ISanPhamRepos.GetAll() on spct.IdSp equals sp.Id
                                                 join cl in _IChatLieuRepos.GetAll() on spct.IdChatLieu equals cl.Id
                                                 //join ksp in (from ctksp in _IChiTietKieuSpRespos.GetAll() 
                                                 //             join InKieusp in _IKieuSpRepos.GetAll() on ctksp.IdKieuSp equals InKieusp.Id 
                                                 //             select new ChiTietKieuSpViews()
                                                 //{
                                                 //    Id = ctksp.Id,
                                                 //    IdKieuSp = InKieusp.Id,
                                                 //    IdChiTietSp = ctksp.IdChiTietSp,
                                                 //    TenKieuSP = InKieusp.Ten
                                                 //}).ToList() on spct.Id equals ksp.IdSPct
                                                  join t in (from gd in _IGiaiDauRepos.GetAll()
                                                               join Team in _ITeamRepos.GetAll() on gd.Id equals Team.IdGd
                                                               select new TeamView()
                                                               {
                                                                   Id = Team.Id,
                                                                   IdGd = Team.IdGd,
                                                                   Ma = Team.Ma,
                                                                   Ten = Team.Ten,
                                                                   TenGiaiDau = gd.Ten,
                                                                   TrangThai = Team.TrangThai
                                                               }).ToList() on spct.IdTeam equals t.Id
                                                 select new ChiTietSpViews()
                                                 {
                                                     Id = spct.Id,
                                                     IdSp = spct.IdSp,
                                                     IdMauSac = spct.IdMauSac,
                                                     IdSize = spct.IdKichCo,
                                                     IdTeam = spct.IdTeam,
                                                     IdChatLieu = spct.IdChatLieu,
                                                     BaoHanh = spct.BaoHanh,
                                                     MoTa = spct.MoTa,
                                                     MaQr = spct.MaQr,
                                                     SoLuongTon = spct.SoLuongTon,
                                                     GiaNhap = spct.GiaNhap,
                                                     GiaBan = spct.GiaBan,
                                                     TrangThai = spct.TrangThai,
                                                     TrangThaiKhuyenMai = spct.TrangThaiKhuyenMai,
                                                     TenMauSac = ms.Ten,
                                                     TenSP = sp.Ten,
                                                     Size = s.Size,
                                                     TenChatLieu = cl.Ten,
                                                     TenTeam = t.Ten,
                                                     //IdKieuSP = ksp.IdKieuSp,
                                                     //TenKieuSp = ksp.TenKieuSP
                                                 }).ToList();


        public ChiTietSpViews GetById(Guid Id) => GetAll().Find(x => x.Id == Id);

        public bool Update(ChiTietSpViews Obj)
        {
            //public ChiTietSpViews(Guid? idSp, Guid? idMauSac, Guid? idSize, Guid? idTeam, Guid? idChatLieu, string baoHanh, string moTa, int? soLuongTon, decimal? giaNhap, decimal? giaBan, int? trangThai, int? trangThaiKhuyenMai)

            if (Obj == null) return false;
            var x = _IChiTietSpRespos.GetById(Obj.Id);
            x.IdSp = Obj.IdSp;
            x.IdMauSac = Obj.IdMauSac;
            x.IdKichCo = Obj.IdSize;
            x.IdTeam = Obj.IdTeam;
            x.IdChatLieu = Obj.IdChatLieu;
            x.BaoHanh = Obj.BaoHanh;
            x.MoTa = Obj.MoTa;
            x.SoLuongTon = Obj.SoLuongTon;
            x.GiaNhap = Obj.GiaNhap;
            x.GiaBan = Obj.GiaBan;
            x.TrangThai = Obj.TrangThai;
            x.TrangThaiKhuyenMai = Obj.TrangThaiKhuyenMai;
            _IChiTietSpRespos.Update(x);
            return true;
        }

    }
}
