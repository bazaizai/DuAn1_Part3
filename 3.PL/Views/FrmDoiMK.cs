using _2.BUS.IServices;
using _2.BUS.Services;
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
            var mk = _iNhanVienServices.GetAll().FirstOrDefault(p => p.MatKhau == tb_mkHienTai.Text);
            if (mk == null)
            {
                MessageBox.Show("Mật khẩu hiện tại không chính xác");

            }
            else if (tb_MkMoi.Text.Length < 8)
            {
                MessageBox.Show("Mật khẩu mới phải có ít nhất 8 kí tự, 1 chữ cái thường, 1 chữ cái in hoa và 1 số");
            }
            else if (tb_nhapLai.Text != tb_MkMoi.Text)
            {
                MessageBox.Show("Nhập lại mật khẩu không chính xác");
            }

            else
            {
                var mkmoi = _iNhanVienServices.GetAll().FirstOrDefault();
                mkmoi.MatKhau = tb_MkMoi.Text;
                _iNhanVienServices.Update(mkmoi);
                MessageBox.Show("Đổi mật khẩu thành công. Vui lòng đăng nhập lại");
                this.Hide();
                //Application.Exit();
                //FrmMain m = new FrmMain();
                //this.Close();

                FrmLogin login = new FrmLogin();
                login.ShowDialog();
                //this.Close();
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
    }
}
