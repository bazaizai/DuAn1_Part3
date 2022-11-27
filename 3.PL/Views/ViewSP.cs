using _2.BUS.IServices;
using _2.BUS.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using Image = System.Drawing.Image;

namespace _3.PL.Views
{
    public partial class ViewSP : Form
    {
        int x;
        IChiTietSpServices _IChiTietSpServices;
        public ViewSP()
        {
            InitializeComponent();
            x = 0;
            _IChiTietSpServices = new ChiTietSpServices();
            pnlbody.Height = panel2.Height;
            this.Height = pnlbody.Height;
        }

        private string TenSP;
        public string TenHang { get => TenSP; set { TenSP = value; lblTenHang.Text = value; lblTenSPtt.Text = value; } }

        private string MauSacSP;
        public string MauSac { get => MauSacSP; set { MauSacSP = value; lblMauSac.Text = value; } }


        private string Tem;
        public string Team { get => Tem; set { Tem = value; lblTeam.Text = value; } }

        private string CL;
        public string ChatLieu { get => CL; set { CL = value; lblChatLieu.Text = value; } }


        private string SLuong;
        public string SoLuong { get => SLuong; set { SLuong = value; lblSoLuongTon.Text = value; lblSoLuongTon1.Text = value; } }

        private string Gia;
        public string GiaBan { get => Gia; set { Gia = value; lblGiaBan.Text = value; lblGiaBan1.Text = value; } }

        private string Nhap;
        public string GiaNhap { get => Nhap; set { Nhap = value; lblGiaNhap.Text = value; lblGiaNhap1.Text = value; } }


        private string Sze;
        public string Size { get => Sze; set { Sze = value; lblSize.Text = value; } }



        private string Ma;
        public string MaHang { get => Ma; set { Ma = value; lblMaHang.Text = value; lblMaHang1.Text = value; } }


        private string ADKM;
        public string APDungKM { get => ADKM; set { ADKM = value; lblADKM.Text = value; } }


        private string TT;
        public string TrangThai { get => TT; set { TT = value; lblTrangThai.Text = value; } }


        private Image bcode;
        public System.Drawing.Image Barcode { get => bcode; set { bcode = value; barcode.Image = value; barcode1.Image = value; } }


        private Image Anh;
        public Image Anh1 { get => Anh; set { Anh = value; Anhtt1.Image = value; } }


        private string Gchu;
        public string GhiChu { get => Gchu; set { Gchu = value; lblGhiChu.Text = value; } }


        private string Bhanh;
        public string BaoHanh { get => Bhanh; set { Bhanh = value; lblBaoHanh.Text = value; } }


        private Guid Id;
        public Guid IDSP { get => Id; set { Id = value; ID.Text = value.ToString(); } }


        private string N_Hang;
        public string NhomHang { get => N_Hang; set { N_Hang = value; lblNhomHang.Text = value;lblNhomHang1.Text = value; } }





        private void panel2_Click(object sender, EventArgs e)
        {
            x++;
            if (x % 2 == 1)
            {
                tabControl1.Visible = true;
                pnlbody.Height = panel2.Height + tabControl1.Height;
                this.Height = pnlbody.Height;
                this.Width = pnlbody.Width;
            }
            else
            {
                tabControl1.Visible = false;
                pnlbody.Height = panel2.Height;
                this.Width = pnlbody.Width;
                this.Height = pnlbody.Height;
            }
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            var ctsp = _IChiTietSpServices.GetById(Guid.Parse(ID.Text));
            if (lblTrangThai.Text == "Đang Bán")
            {
                lblTrangThai.Text = "Ngừng Bán";
                ctsp.TrangThai = 1;
                _IChiTietSpServices.Update(ctsp);

            }
            else
            {
                lblTrangThai.Text = "Đang Bán";
                ctsp.TrangThai = 0;
                _IChiTietSpServices.Update(ctsp);
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            FrmSuaSanPham fixSP = new FrmSuaSanPham();
            fixSP.Anh1 = this.Anh1;
            fixSP.IDSP = this.IDSP;
            fixSP.MaSP = this.lblMaHang.Text;
            fixSP.TenSP = this.lblTenHang.Text.Substring(0, this.lblTenHang.Text.IndexOf("-"));
            fixSP.MauSac = this.lblMauSac.Text;
            fixSP.Size1 = this.lblSize.Text;
            fixSP.ChatLieu = this.lblChatLieu.Text;
            fixSP.Team = this.lblTeam.Text;
            fixSP.GiaNhap = this.lblGiaNhap.Text;
            fixSP.GiaBan = this.lblGiaBan.Text;
            fixSP.SoLuong = this.lblSoLuongTon.Text;
            fixSP.BaoHanh = this.lblBaoHanh.Text;
            fixSP.CheckTrangThai = this.lblTrangThai.Text;
            fixSP.KhuyenMai = this.lblADKM.Text;
            fixSP.Mota = this.lblGhiChu.Text;
            fixSP.ShowDialog();
        }
    }
}
