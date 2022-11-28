using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace _2.BUS.ViewModels
{
    public class ChiTietSpViews
    {
        public ChiTietSpViews()
        {

        }
        public Guid Id { get; set; }
        public Guid? IdSp { get; set; }
        public Guid? IdMauSac { get; set; }
        public Guid? IdSize { get; set; }
        public Guid? IdTeam { get; set; }
        public Guid? IdChatLieu { get; set; }
        public string MaQr { get; set; }
        public string BaoHanh { get; set; } 
        public string MoTa { get; set; }
        public int? SoLuongTon { get; set; }
        public decimal? GiaNhap { get; set; }
        public decimal? GiaBan { get; set; }
        public int? TrangThai { get; set; }
        public int? TrangThaiKhuyenMai { get; set; }

        //Bảng màu sắc
        public string TenMauSac { get; set; }
        //Bang Sp
        public string TenSP { get; set; }
        //Bang Size
        public string Size { get; set; }
        //Bang ChatLieu
        public string TenChatLieu { get; set; }
        //Bang Team
        public string TenTeam { get; set; }


        public ChiTietSpViews(Guid id, Guid? idSp, Guid? idMauSac, Guid? idSize, Guid? idTeam, Guid? idChatLieu, string maQr, string baoHanh, string moTa, int? soLuongTon, decimal? giaNhap, decimal? giaBan, int? trangThai, int? trangThaiKhuyenMai)
        {
            Id = id;
            IdSp = idSp;
            IdMauSac = idMauSac;
            IdSize = idSize;
            IdTeam = idTeam;
            IdChatLieu = idChatLieu;
            MaQr = maQr;
            BaoHanh = baoHanh;
            MoTa = moTa;
            SoLuongTon = soLuongTon;
            GiaNhap = giaNhap;
            GiaBan = giaBan;
            TrangThai = trangThai;
            TrangThaiKhuyenMai = trangThaiKhuyenMai;
        }
    }
}
