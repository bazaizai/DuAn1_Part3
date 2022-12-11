using _2.BUS.IServices;
using _2.BUS.Services;
using _3.PL.CustomControlls;
using CustomAlertBoxDemo;
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
    public partial class FrmSuaThongTinDonHang : Form
    {
        public static int ClickLuu;
        IHoaDonServices _IHoaDonServices;
        IKhachHangServices _IKhachHangServices;
        public FrmSuaThongTinDonHang()
        {
            InitializeComponent();
            ClickLuu = 0;
            _IHoaDonServices = new HoaDonServices();
            _IKhachHangServices = new KhachHangServices();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void Alert(string msg, Form_Alert.enmType type)
        {
            Form_Alert frm = new Form_Alert();
            frm.showAlert(msg, type);
        }

        private bool HopThoai() => RJMessageBox.Show("Bạn có muốn thực hiện hành động này", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes;
        private string _HoTen;
        public string HoTen { get => _HoTen; set { _HoTen = value; txtHoTen.Texts = value; } }


        private decimal _PhiShip;
        public decimal PhiShip { get => _PhiShip; set { _PhiShip = value; txtphiShip.Texts = value.ToString(); } }


        private string _DiaChi;
        public string DiaChi { get => _DiaChi; set { _DiaChi = value; txtDiaChi.Texts = value; } }


        private string _SDT;
        public string SDT { get => _SDT; set { _SDT = value; txtSDT.Texts = value; } }


        private string _MaHD;
        public string MaHoaDon { get => _MaHD; set { _MaHD = value; lblMaHoaDon.Text = value; } }


        private void btnLuu_Click(object sender, EventArgs e)
        {
            ClickLuu = 1;
            if (txtDiaChi.Texts.Trim() == "" || txtHoTen.Texts.Trim() == "" || txtphiShip.Texts == "" || txtSDT.Texts == "")
            {
                this.Alert("Vui lòng nhập đủ thông tin", Form_Alert.enmType.Warning);
            }else
            {
                if (HopThoai())
                {
                    var hoaDon = _IHoaDonServices.GetAll().Find(x => x.MaHD == lblMaHoaDon.Text);
                    hoaDon.DiaChiNhan = txtDiaChi.Texts;
                    hoaDon.TenNguoiNhan = txtHoTen.Texts;
                    hoaDon.SdtNhanHang = txtSDT.Texts;
                    hoaDon.IdKh = _IKhachHangServices.GetAll().Find(x => x.Sdt == txtSDT.Texts) == null ? null : _IKhachHangServices.GetAll().Find(x => x.Sdt == txtSDT.Texts).Id;
                    hoaDon.TienShip = Convert.ToDecimal(txtphiShip.Texts);
                    _IHoaDonServices.Update(hoaDon);
                    this.Close();
                    this.Alert("Cập nhật thành công.", Form_Alert.enmType.Info);
                }
            }
        }

        private void txtSDT__TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;

        }


        private void txtphiShip_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;

        }

        private void txtHoTen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}
