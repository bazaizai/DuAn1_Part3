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
    public partial class FrmXacNhan : Form
    {
        private INhanVienServices _iNhanVienServices;
        private IChucVuServices _iChucVuServices;
        public FrmXacNhan()
        {
            InitializeComponent();
            _iChucVuServices = new ChucVuServices();
            _iNhanVienServices = new NhanVienServices();
            this.CenterToScreen();
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            var login = _iNhanVienServices.GetAll().Where(p => p.TaiKhoan == tb_1.Texts && p.MatKhau == tb_2.Texts).FirstOrDefault();
            var idCv = _iChucVuServices.GetAll().Where(p => p.Ten == "Quản lý").Select(p => p.Id).FirstOrDefault();
            var idnv = _iNhanVienServices.GetAll().Where(p => p.TaiKhoan == tb_1.Texts).Select(p => p.IdCv).FirstOrDefault();
            //MessageBox.Show((login != null).ToString());
            //MessageBox.Show((idCv == idnv).ToString());
            if (login != null && idCv == idnv)
            {
                Properties.Settings.Default.check = true;
                Properties.Settings.Default.Save();
                this.Close();
            }
            else
            {
                Properties.Settings.Default.check = false;
                Properties.Settings.Default.Save();
                MessageBox.Show("Tài khoản không đúng. Bạn không có quyền truy cập", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void rjButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
