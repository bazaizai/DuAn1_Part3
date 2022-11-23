using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.ViewModels
{
    public class ChiTietKieuSpViews
    {
        public ChiTietKieuSpViews()
        {

        }
        public Guid Id { get; set; }
        public Guid? IdKieuSp { get; set; }
        public Guid? IdChiTietSp { get; set; }
        public int? TrangThai { get; set; }
        //KieuSP

        public string TenKieuSP { get; set; }
        //SP
        public Guid IdSPct { get; set; }
        public Guid? IdSp { get; set; }
        public Guid? IdMauSac { get; set; }
        public Guid? IdSize { get; set; }
        public Guid? IdGiaiDau { get; set; }
        public Guid? IdTeam { get; set; }
        public Guid? IdChatLieu { get; set; }
        public string BaoHanh { get; set; }
        public int? SoLuongTon { get; set; }
        public decimal? GiaNhap { get; set; }
        public decimal? GiaBan { get; set; }
        public int? TrangThaiKhuyenMai { get; set; }

        public ChiTietKieuSpViews(Guid id, Guid? idKieuSp, Guid? idCha, Guid? idChiTietSp, int? trangThai)
        {
            Id = id;
            IdKieuSp = idKieuSp;
            IdChiTietSp = idChiTietSp;
            TrangThai = trangThai;
        }

        public ChiTietKieuSpViews(Guid? idKieuSp, Guid? idCha, Guid? idChiTietSp, int? trangThai)
        {
            IdKieuSp = idKieuSp;
            IdChiTietSp = idChiTietSp;
            TrangThai = trangThai;
        }
    }
}
