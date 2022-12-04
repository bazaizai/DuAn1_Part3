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
    public partial class FrmThongTinSP : Form
    {
        public FrmThongTinSP()
        {
            InitializeComponent();
        }


        private string _TenSP;
        public string TenSP { get => _TenSP; set { _TenSP = value; lblTenSP.Text = value; } }


        private string _ChatLieu;
        public string ChatLieu { get => _ChatLieu; set { _ChatLieu = value; lblChatLieu.Text = value; } }


        private string _MauSac;
        public string MauSac { get => _MauSac; set { _MauSac = value; lblMauSac.Text = value; } }


        private string _team;
        public string Team { get => _team; set { _team = value; lblTeam.Text = value; } }


        private string _NhomHang;
        public string NhomHang { get => _NhomHang; set { _NhomHang = value; lblNhomHang.Text = value; } }


        private string _size;
        public string SizeSp { get => _size; set { _size = value; lblSize.Text = value; } }



        private Image _AnhSP;
        public Image AnhSP1 { get => _AnhSP; set { _AnhSP = value; AnhSP.Image = value; } }


        private Image _Anhqr;
        public Image AnhMQr { get => _Anhqr; set { _Anhqr = value; AnhMaQR.Image = value; } }





        private void label13_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
