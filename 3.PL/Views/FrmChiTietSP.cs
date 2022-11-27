using _2.BUS.IServices;
using _2.BUS.Services;
using _2.BUS.ViewModels;
using _3.PL.Components;
using _3.PL.Properties;
using BarcodeLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace _3.PL.Views
{
    public partial class FrmChiTietSP : Form
    {
        IChiTietSpServices _IChiTietSpServices;
        IAnhServices _IanhServices;

        private int x;
        public int Count { get => x; set { x = value; x = value; } }

        public FrmChiTietSP()
        {
            InitializeComponent();
            _IChiTietSpServices = new ChiTietSpServices();
            _IanhServices = new AnhServices();
            x = 1;
            LoadData();
        }

        private void LoadAll()
        {
            InitializeComponent();
            _IChiTietSpServices = new ChiTietSpServices();
            _IanhServices = new AnhServices();
            LoadData();
        }

        private Form CurrentFormChild;
        private void LoadData()
        {
            flowLayoutPanel1.Controls.Clear();
            //List<AnhViews> ListAnh = _IanhServices.GetAll().GroupBy(x => x.IdChiTietSp).Select(sp => sp.First()).ToList();
            List<ChiTietSpViews> CTSP = _IChiTietSpServices.GetAll();

            ViewSP[] Sp = new ViewSP[_IChiTietSpServices.GetAll().Count];
            for (int i = 0; i < _IChiTietSpServices.GetAll().Count; i++)
            {
                Sp[i] = new ViewSP();
                Sp[i].MauSac = CTSP[i].TenMauSac;
                Sp[i].ChatLieu = CTSP[i].TenChatLieu;
                Sp[i].Team = CTSP[i].TenTeam;
                Sp[i].Size = CTSP[i].Size;
                Sp[i].IDSP = CTSP[i].Id;
                Sp[i].MaHang = CTSP[i].MaQr;
                Sp[i].GiaNhap = double.Parse(CTSP[i].GiaNhap.ToString()).ToString("#,###", CultureInfo.GetCultureInfo("vi-VN").NumberFormat) + "đ";
                Sp[i].GiaBan = double.Parse(CTSP[i].GiaBan.ToString()).ToString("#,###", CultureInfo.GetCultureInfo("vi-VN").NumberFormat) + "đ";
                Sp[i].TrangThai = CTSP[i].TrangThai == 0 ? "Đang Bán" : "Ngừng Bán";
                Sp[i].SoLuong = CTSP[i].SoLuongTon.ToString();
                Sp[i].APDungKM = CTSP[i].TrangThaiKhuyenMai == 0 ? "Đang áp dụng" : "Không áp dụng";
                Sp[i].TenHang = CTSP[i].TenSP + "-" + CTSP[i].TenMauSac;
                Sp[i].Anh1 = _IanhServices.GetAll().Find(x => x.IdChiTietSp == CTSP[i].Id && x.TenAnh == "Anh") != null ? Image.FromStream(new MemoryStream((byte[])_IanhServices.GetAll().Find(x => x.IdChiTietSp == CTSP[i].Id && x.TenAnh == "Anh").DuongDan)) : null;
                Sp[i].Barcode = _IanhServices.GetAll().Find(x => x.IdChiTietSp == CTSP[i].Id && x.TenAnh == "Anh") != null ? Image.FromStream(new MemoryStream((byte[])_IanhServices.GetAll().Find(x => x.IdChiTietSp == CTSP[i].Id && x.TenAnh == "Barcode").DuongDan)) : null;
                Sp[i].BaoHanh = CTSP[i].BaoHanh;
                Sp[i].GhiChu = CTSP[i].MoTa;


                Sp[i].TopLevel = false;
                Sp[i].FormBorderStyle = FormBorderStyle.None;
                Sp[i].Dock = DockStyle.Top;
                flowLayoutPanel1.Controls.Add(Sp[i]);
                Sp[i].BringToFront();
                Sp[i].Show();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            FrmThemSP sp = new FrmThemSP();
            sp.ShowDialog();
            LoadData();

        }
    }
}
