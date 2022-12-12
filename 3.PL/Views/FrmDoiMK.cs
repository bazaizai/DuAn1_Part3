using _2.BUS.IServices;
using _2.BUS.Services;
using _3.PL.CustomControlls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3.PL.Views
{
    public partial class FrmDoiMK : Form
    {
        INhanVienServices _iNhanVienServices;
        public FrmDoiMK()
        {
            InitializeComponent();
            _iNhanVienServices = new NhanVienServices();
            this.CenterToScreen();
            tb_mkHienTai.UseSystemPasswordChar = true;
            tb_MkMoi.UseSystemPasswordChar = true;
            tb_nhapLai.UseSystemPasswordChar = true;
            btn_quaylai.Visible
                = false;
        }
        public static bool IsValidPasswordtrungBinh(string Pass)
        {
            return Regex.IsMatch(Pass, @"^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$|^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9]).{8,}$");
        }
        private void btn_quaylai_Click(object sender, EventArgs e)
        {

        }

        private void lb_quenMK_Click(object sender, EventArgs e)
        {
            FrmForgotPW frmForgotPW = new FrmForgotPW();
            this.Hide();
            frmForgotPW.ShowDialog();
            
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            var mk = _iNhanVienServices.GetAll().FirstOrDefault(p => p.MatKhau == tb_mkHienTai.Text&& p.TaiKhoan == Properties.Settings.Default.TKdaLogin);
            if (tb_mkHienTai.Text == "")
            {
                RJMessageBox.Show("Mật khẩu hiện tại chưa nhập");
            }
           
           else if (mk == null)
            {
                RJMessageBox.Show("Mật khẩu hiện tại không chính xác");
            }
            else if ( tb_MkMoi.Text == _iNhanVienServices.GetAll().FirstOrDefault(p => p.TaiKhoan == Properties.Settings.Default.TKdaLogin).MatKhau)
            {
                RJMessageBox.Show("Mật khẩu mới không được trùng với mật khẩu hiện tại");
            }
            else if (tb_MkMoi.Text.Length < 8)
            {
                RJMessageBox.Show("Mật khẩu mới phải có ít nhất 8 kí tự, 1 chữ cái thường, 1 chữ cái in hoa và 1 số");
            }
            else if (tb_nhapLai.Text != tb_MkMoi.Text)
            {
                RJMessageBox.Show("Nhập lại mật khẩu không chính xác");
            }

            else
            {
                var mkmoi = _iNhanVienServices.GetAll().FirstOrDefault(x=>x.TaiKhoan==Properties.Settings.Default.TKdaLogin);
                mkmoi.MatKhau = tb_MkMoi.Text;
                DialogResult dg = RJMessageBox.Show("Bạn có muốn đổi mật khẩu?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dg == DialogResult.Yes)
                {
                    _iNhanVienServices.Update(mkmoi);
                    RJMessageBox.Show("Đổi mật khẩu thành công.");                
                    tb_mkHienTai.Text = "";
                    tb_MkMoi.Text="";
                    tb_nhapLai.Text = "";
                }

                
                //asjdhks99udsiAa
            }
        }

        private void cb_htMK_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_htMK.Checked == true)
            {
                tb_mkHienTai.UseSystemPasswordChar = false;
                tb_MkMoi.UseSystemPasswordChar = false;
                tb_nhapLai.UseSystemPasswordChar = false;
            }
            else
            {
                tb_mkHienTai.UseSystemPasswordChar = true;
                tb_MkMoi.UseSystemPasswordChar = true;
                tb_nhapLai.UseSystemPasswordChar = true;
            }
        }

        private void tb_nhapLai_TextChanged(object sender, EventArgs e)
        {
            if (tb_nhapLai.Text == tb_MkMoi.Text)
            {
                lb_khopMK.Text = "Mật khẩu khớp";
            }
            else lb_khopMK.Text = "";
        }

        private void cb_htMK_Click(object sender, EventArgs e)
        {
            
            
        }

        private void lb_khopMK_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void tb_MkMoi_TextChanged(object sender, EventArgs e)
        {
            if (tb_nhapLai.Text == tb_MkMoi.Text)
            {
                lb_khopMK.Text = "Mật khẩu khớp";
            }
            else lb_khopMK.Text = "";
        }
    }
}
