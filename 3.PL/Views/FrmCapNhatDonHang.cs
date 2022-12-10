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
    public partial class FrmCapNhatDonHang : Form
    {
        public static int CapNhatClick;
        IHoaDonServices _IHoaDonServices;
        IPtthanhToanServices _IPtthanhToanServices;
        public FrmCapNhatDonHang()
        {
            InitializeComponent();
            CapNhatClick = 0;
            _IHoaDonServices = new HoaDonServices();
            _IPtthanhToanServices = new PtthanhToanServices();
            cbbPtThanhToan.Items.Add("COD");
            cbbPtThanhToan.Items.Add("Chuyển khoản");
            CbbGiamGia.SelectedIndex = 0;
        }

        private string _MucGiamGia;
        public string GiamGia { get => _MucGiamGia; set { _MucGiamGia = value; txtGiamGia.Texts = value; } }


        private decimal _PhiShip;
        public decimal PhiShip { get => _PhiShip; set { _PhiShip = value; txtPhiShip.Texts = value.ToString(); } }


        private string _HTGiamGia;
        public string HTGiamGia { get => _HTGiamGia; set { _HTGiamGia = value; CbbGiamGia.Text = value; } }


        private string _LoaiHinhGiamGia;
        public string LoaiHinhGiamGia { get => _LoaiHinhGiamGia; set { _LoaiHinhGiamGia = value; CbbGiamGia.Text = value; } }


        private string _HTGG;
        public string HTthanhToan { get => Name; set { Name = value; cbbPtThanhToan.Texts = value; } }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtGiamGia__TextChanged(object sender, EventArgs e)
        {
            if (CbbGiamGia.Text == "%" && txtGiamGia.Texts != "" && Convert.ToInt32(txtGiamGia.Texts) > 100)
            {
                txtGiamGia.Texts = "100";
            }
        }

        public void Alert(string msg, Form_Alert.enmType type)
        {
            Form_Alert frm = new Form_Alert();
            frm.showAlert(msg, type);
        }

        private string _MaHD;
        public string MaHD { get => _MaHD; set { _MaHD = value; lblMaHoaDon.Text = value; } }


        private bool HopThoai() => RJMessageBox.Show("Bạn có muốn thực hiện hành động này", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes;
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if ((txtGiamGia.Texts != "" || Convert.ToInt32(txtGiamGia.Texts) > 0) && txtMoTa.Texts.Trim() == "")
            {
                this.Alert("Vui lòng xác nhận lý do cập nhật trong phần ghi chú.", Form_Alert.enmType.Info);
            }
            else
            {
                if (HopThoai())
                {
                    CapNhatClick = 1;
                    var HoaDon = _IHoaDonServices.GetAll().Find(x => x.MaHD == lblMaHoaDon.Text);
                    HoaDon.GiamGia = txtGiamGia.Texts.Trim() == "" ? 0 : Convert.ToInt32(txtGiamGia.Texts);
                    HoaDon.HinhThucGiamGia = CbbGiamGia.Text == "%" ? "Phần trăm" : "Tiền mặt";
                    HoaDon.IdPttt = _IPtthanhToanServices.GetAll().Find(x => x.Ten == cbbPtThanhToan.Texts).Id;
                    HoaDon.MoTa += "Coment : "+ txtMoTa.Texts + ")";
                    HoaDon.TienShip = Convert.ToInt32(txtPhiShip.Texts);
                    _IHoaDonServices.Update(HoaDon);
                    _IHoaDonServices = new HoaDonServices();
                    this.Close();
                    this.Alert("Cập nhật thành công.", Form_Alert.enmType.Info);
                }
            }
        }


        private void txtGiamGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtPhiShip_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}
