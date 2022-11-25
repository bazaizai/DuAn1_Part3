using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3.PL.Views
{
    public partial class ViewSP : Form
    {
        int x;
        public ViewSP()
        {
            InitializeComponent();
            x = 0;
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
        public Image Barcode { get => bcode; set { bcode = value; barcode.Image = value; barcode1.Image = value; } }


        private Image Anh;
        public Image Anh1 { get => Anh; set { Anh = value; Anhtt1.Image = value; } }


        private string Gchu;
        public string GhiChu { get => Gchu; set { Gchu = value; lblGhiChu.Text = value; } }


        private string Bhanh;
        public string BaoHanh { get => Bhanh; set { Bhanh = value; lblBaoHanh.Text = value; } }





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

    }
}
