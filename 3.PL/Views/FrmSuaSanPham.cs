using _1.DAL.DomainClass;
using _2.BUS.IServices;
using _2.BUS.Services;
using _2.BUS.ViewModels;
using _3.PL.Utilities;
using BarcodeLib;
using CustomAlertBoxDemo;
using CustomControls.RJControls;
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
    public partial class FrmSuaSanPham : Form
    {
        ISanPhamServices _ISanPhamServices;
        IKichCoServices _ISizeServices;
        IChatLieuServices _IChatLieuServices;
        IMauSacServices _IMauSacServices;
        ITeamServices _ITeamServices;
        IChiTietSpServices _IChiTietSpServices;
        AnhServices _IAnhServices;
        public FrmSuaSanPham()
        {
            InitializeComponent();
            _ISanPhamServices = new SanPhamServices();
            _ISizeServices = new KichCoServices();
            _IChatLieuServices = new ChatLieuServices();
            _IMauSacServices = new MauSacServices();
            _ITeamServices = new TeamServices();
            _IChiTietSpServices = new ChiTietSpServices();
            _IAnhServices = new AnhServices();
            cbbKhuyenMai.Items.Add("Áp dụng");
            cbbKhuyenMai.Items.Add("Không áp dụng");
            cbbKhuyenMai.SelectedIndex = 0;
            RdoDangBan.Checked = true;
            LoadCbb();
        }


        private Image image;
        public Image Anh1 { get => image; set { image = value; Anh.Image = value; } }

        private string Ma;
        public string MaSP { get => Ma; set { Ma = value; txtMaSP.Texts = value; } }


        private string Ten;
        public string TenSP { get => Ten; set { Ten = value; cbbTenSP.Texts = value; } }


        private string Ms;
        public string MauSac { get => Ms; set { Ms = value; cbbMauSac.Texts = value; } }


        private string Sze;
        public string Size1 { get => Sze; set { Sze = value; cbbSize.Texts = value; } }


        private string CLieu;
        public string ChatLieu { get => CLieu; set { CLieu = value; CbbChatLieu.Texts = value; } }



        private string Tem;
        public string Team { get => Tem; set { Tem = value; cbbTeam.Texts = value; } }


        private string GNhap;
        public string GiaNhap { get => GNhap; set { GNhap = ValidateInput.RegexDecimal(value).ToString(); txtGiaNhap.Texts = ValidateInput.RegexDecimal(value).ToString(); } }


        private string GBan;
        public string GiaBan { get => GBan; set { GBan = ValidateInput.RegexDecimal(value).ToString(); txtGiaBan.Texts = ValidateInput.RegexDecimal(value).ToString(); } }


        private string SL;
        public string SoLuong { get => SL; set { SL = value; txtSoLuong.Texts = value; } }

        private string ghichu;
        public string Mota { get => ghichu; set { ghichu = value; txtGhiChu.Texts = value; } }


        private string bHanh;
        public string BaoHanh { get => bHanh; set { bHanh = value; txtBaoHanh.Texts = value; } }


        private string Kmai;
        public string KhuyenMai { get => Kmai; set { Kmai = value; cbbKhuyenMai.Texts = value; } }


        private Guid id;
        public Guid IDSP { get => id; set { id = value; lblID.Text = value.ToString(); } }



        private string CheckTT;
        public string CheckTrangThai
        {
            get => CheckTT; set
            {
                CheckTT = value; CheckTT = value; if (value == "Đang Bán")
                {
                    RdoDangBan.Checked = true;
                }
                else
                    rdoDungBan.Checked = true;
            }
        }

        private Guid IdSp() => _ISanPhamServices.GetAll().Find(x => x.Ten == cbbTenSP.Texts).Id;
        private Guid IdMs() => _IMauSacServices.GetAll().Find(x => x.Ten == cbbMauSac.Texts).Id;
        private Guid IdCL() => _IChatLieuServices.GetAll().Find(x => x.Ten == CbbChatLieu.Texts).Id;
        private Guid IdTeam() => _ITeamServices.GetAll().Find(x => x.Ten == cbbTeam.Texts).Id;
        private Guid IdSize() => _ISizeServices.GetAll().Find(x => x.Size == cbbSize.Texts).Id;



        private void LoadCbb()
        {
            cbbTenSP.Items.Clear();
            _ISanPhamServices.GetAll().ForEach(x => cbbTenSP.Items.Add(x.Ten));
            cbbSize.Items.Clear();
            _ISizeServices.GetAll().ForEach(x => cbbSize.Items.Add(x.Size));
            CbbChatLieu.Items.Clear();
            _IChatLieuServices.GetAll().ForEach(x => CbbChatLieu.Items.Add(x.Ten));
            cbbMauSac.Items.Clear();
            _IMauSacServices.GetAll().ForEach(x => cbbMauSac.Items.Add(x.Ten));
            cbbTeam.Items.Clear();
            _ITeamServices.GetAll().ForEach(x => cbbTeam.Items.Add(x.Ten));
        }
        private void rjCircularPictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnAddSP_Click(object sender, EventArgs e)
        {
            FrmSanPham frmSP = new FrmSanPham();
            frmSP.ShowDialog();
            LoadCbb();
        }

        private void rjCircularPictureBox2_Click(object sender, EventArgs e)
        {
            FrmMauSac frmMauSac = new FrmMauSac();
            frmMauSac.ShowDialog();
            LoadCbb();
        }

        private void rjCircularPictureBox3_Click(object sender, EventArgs e)
        {
            FrmKichCo FrmKichCo = new FrmKichCo();
            FrmKichCo.ShowDialog();
            LoadCbb();
        }

        private void rjCircularPictureBox4_Click(object sender, EventArgs e)
        {
            FrmChatLieu frmChatLieu = new FrmChatLieu();
            frmChatLieu.ShowDialog();
            LoadCbb();
        }

        private void rjCircularPictureBox5_Click(object sender, EventArgs e)
        {
            FrmTeam frmTeam = new FrmTeam();
            frmTeam.ShowDialog();
            LoadCbb();
        }

        private void lblclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image file:| *.jpg;*.jpeg;*.png;*.gif;*.tif;...";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                DialogResult result = MessageBox.Show("Bạn có muốn chọn ảnh không?",
               "Thông báo", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    Anh.Image = Image.FromFile(ofd.FileName);
                }
            }
        }
        private bool VaLidateTXT()
        {
            foreach (Control x in this.Controls)
            {
                if (x is RJTextBox && x != txtGhiChu)
                {
                    if (Vldate.Null(((RJTextBox)x).Texts))
                        return false;
                }
            }
            return true;
        }
        private bool VaLidatecbb()
        {
            foreach (Control x in this.Controls)
            {
                if (x is RJComboBox && x != CbbNhomHang)
                {
                    if (Vldate.Null(((RJComboBox)x).Texts))
                        return false;
                }
            }
            return true;
        }


        public void Alert(string msg, Form_Alert.enmType type)
        {
            Form_Alert frm = new Form_Alert();
            frm.showAlert(msg, type);
        }

        private bool CheckTrungSP(Guid idsp, Guid idmausac, Guid Idsize, Guid idteam, Guid idClieu)
        {
            for (int i = 0; i < _IChiTietSpServices.GetAll().Count; i++)
            {
                if (_IChiTietSpServices.GetAll()[i].IdSp == idsp && _IChiTietSpServices.GetAll()[i].IdMauSac == idmausac && _IChiTietSpServices.GetAll()[i].IdSize == Idsize && _IChiTietSpServices.GetAll()[i].IdTeam == idteam && _IChiTietSpServices.GetAll()[i].IdChatLieu == idClieu)
                {
                    return true;
                }
            }
            return false;
        }
         
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (Anh.Image != null && VaLidateTXT() && VaLidatecbb())
            {
                if (!CheckTrungSP(IdSp(), IdMs(), IdSize(), IdTeam(), IdCL()))
                {
                    try
                    {


                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                    this.Alert("Sản phẩm này đã tồn tại", Form_Alert.enmType.Warning);
            }
            else
            {
                this.Alert("Vui lòng nhập đủ trương *", Form_Alert.enmType.Warning);
            }
            this.Close();
        }
    }
}
