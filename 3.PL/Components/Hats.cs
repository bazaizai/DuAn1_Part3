using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using Size = System.Drawing.Size;

namespace _3.PL.Components
{
    public partial class Hats : UserControl
    {
        private double price;
        private string Ten;
        private string ChatLieuview;
        private string MauSacView;
        private string Sizeview;
        private String SoLuongView;
        private Image _Icon;
        private Guid _Idspct;
        public event EventHandler Onselect = null;


        public Hats()
        {
            InitializeComponent();
            if (SoLuongView == 0.ToString())
            {
                Add.Visible = false;
            }
        }

        public string TenSP1 { get => Ten; set { Ten = value; TenSP.Text = value; } }
        public string SoluongSP1 { get => SoLuongView; set { SoLuongView = value; SoLuong.Text = "Số lượng: " + value; } }
        public Image Icon { get => _Icon; set { _Icon = value; Anh.Image = value; } }
        public double Price { get => price; set { price = value; Gia.Text = "Giá: " + double.Parse(price.ToString()).ToString("#,###", CultureInfo.GetCultureInfo("vi-VN").NumberFormat) + "đ"; } }
        public Guid IdSPCTSP { get => _Idspct; set { _Idspct = value; IdSPCT.Text = value.ToString(); } }

        private double Money;
        public double GiaDaGiam { get => Money; set { Money = value; lblGiaSauKhiGiam.Text = "Giá: " + double.Parse(Money.ToString()).ToString("#,###", CultureInfo.GetCultureInfo("vi-VN").NumberFormat) + "đ"; } }


        private string Pt;
        public string LoaiKM { get => Pt; set { Pt = value; lblPhuongThuc.Text = value; } }


        private string MA;
        public string MaSP { get => MA; set { MA = value; lblMa.Text = value; } }


        private void Add_Click_1(object sender, EventArgs e)
        {
            Onselect?.Invoke(this, e);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random random = new Random();
            int one = random.Next(0, 255);
            int two = random.Next(0, 255);
            int three = random.Next(0, 255);
            int four = random.Next(0, 255);
            lblPhuongThuc.ForeColor = Color.FromArgb(one, two, three, four);
        }

        private void Hats_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
