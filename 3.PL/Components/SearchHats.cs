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

        private void SearchHats_Click(object sender, EventArgs e)
        {
            Onclick?.Invoke(this, e);
        }
    }
}
