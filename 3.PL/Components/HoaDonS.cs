using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3.PL.Components
{
    public partial class HoaDonS : UserControl
    {
        public event EventHandler Onselect = null;
        public HoaDonS()
        {
            InitializeComponent();
        }
        private string maHD;
        public string MaHD { get => maHD; set { maHD = value; lblMaHD.Text = value; } }


        private string _ID;
        public string ID { get => _ID; set { _ID = value; lblID.Text = value; } }


        private string _TenKhachHang;
        public string TenKH { get => _TenKhachHang; set { _TenKhachHang = value; lblTenKH.Text = value; } }


        private string _Sdt;
        public string SDT { get => _Sdt; set { _Sdt = value; lblSDT.Text = value; } }


        private string _DiaChi;
        public string DiaChi { get => _DiaChi; set { _DiaChi = value; lblDiaChi.Text = value; } }


        private string _trangThai;
        public string TrangThai { get => _trangThai; set { _trangThai = value; lblTrangThai.Text = value; } }


        private string _MaNV;
        public string MaNV { get => _MaNV; set { _MaNV = value; lblMaNV.Text = value; } }


        private string _ttGiaoHang;
        public string TrangThaiGiaohang { get => _ttGiaoHang; set { _ttGiaoHang = value; lblTTGiaoHang.Text = value; } }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            Onselect?.Invoke(this, e);
        }
    }
}
