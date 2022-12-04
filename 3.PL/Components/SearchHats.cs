using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3.PL.Components
{
    public partial class SearchHats : UserControl
    {
        public event EventHandler Onclick = null;
        private String SoLuongView;
        private Image _Icon;
        private Guid _Idspct;
        private double price;
        private string Ten;
        public SearchHats()
        {
            InitializeComponent();
        }
        public string TenSP1 { get => Ten; set { Ten = value; TenSP.Text = value; } }
        public string SoluongSP1 { get => SoLuongView; set { SoLuongView = value; SoLuong.Text = "Số lượng: " + value; } }
        public Image Icon { get => _Icon; set { _Icon = value; Anh.Image = value; } }
        public double Price { get => price; set { price = value; Gia.Text = "Giá: " + double.Parse(price.ToString()).ToString("#,###", CultureInfo.GetCultureInfo("vi-VN").NumberFormat) + "đ"; } }
        public Guid IdSPCTSP { get => _Idspct; set { _Idspct = value; IdSPCT.Text = value.ToString(); } }


        private double _GIaGiam;
        public double GiaGiam { get => _GIaGiam; set { _GIaGiam = value; lblGiaGiam.Text = "Giá: " + double.Parse(_GIaGiam.ToString()).ToString("#,###", CultureInfo.GetCultureInfo("vi-VN").NumberFormat) + "đ"; ; } }


        private string _MucGiam;
        public string MucGiam { get => _MucGiam; set { _MucGiam = value; lblPT.Text = value; } }



        private void SearchHats_Click(object sender, EventArgs e)
        {
            Onclick?.Invoke(this, e);
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            Random random = new Random();
            int one = random.Next(0, 255);
            int two = random.Next(0, 255);
            int three = random.Next(0, 255);
            int four = random.Next(0, 255);
            lblPT.ForeColor = Color.FromArgb(one, two, three, four);
        }

        private void SearchHats_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }


    }
}
