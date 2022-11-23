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

namespace _3.PL.Views
{
    public partial class FrmLogin : Form
    {
        INhanVienServices _iNhanVienServices;
        
        public FrmLogin()
        {
            InitializeComponent();
            this.CenterToScreen();
            _iNhanVienServices = new NhanVienServices();
            tb_tk.Text = Properties.Settings.Default.tk;
            tb_mk.Text = Properties.Settings.Default.mk;
            cb_save.Checked = true;
            
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            var login = _iNhanVienServices.GetAll().Where(p => p.TaiKhoan == tb_tk.Text && p.MatKhau == tb_mk.Text).FirstOrDefault();
            if (login != null)
            {
                saveInfor();
                this.Hide();
                FrmMain frmMain = new FrmMain();
                frmMain.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại");
            }
        }
        public void saveInfor()
        {
            if (cb_save.Checked == true)
            {
                Properties.Settings.Default.tk = tb_tk.Text;
                Properties.Settings.Default.mk = tb_mk.Text;
                Properties.Settings.Default.TKdaLogin = tb_tk.Text;
                Properties.Settings.Default.MKdaLogin = tb_mk.Text;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.tk = "";
                Properties.Settings.Default.mk = "";
                Properties.Settings.Default.TKdaLogin = tb_tk.Text;
                Properties.Settings.Default.MKdaLogin = tb_mk.Text;
                Properties.Settings.Default.Save();
            }
        }

       

      

        private void lb_ForgotPassword_Click(object sender, EventArgs e)
        {
           
            FrmForgotPW frmForgotPW = new FrmForgotPW();
            this.Hide();
            frmForgotPW.ShowDialog();
            
        }

        private void tb_tk_MouseClick(object sender, MouseEventArgs e)
        {
            tb_tk.Text = "";
        }

        private void tb_mk_MouseClick(object sender, MouseEventArgs e)
        {
            tb_mk.Text = "";
        }

       
    }
}
