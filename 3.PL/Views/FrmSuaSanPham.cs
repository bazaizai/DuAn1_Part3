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

        private int Count;
        public int N { get => Count; set { Count = value; N = value; } }

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
        private FrmChiTietSP Mainform = null;
        public FrmSuaSanPham(Form Call)
        {
            Mainform = Call as FrmChiTietSP;
            InitializeComponent();
        }

        private Image image;
        public Image Anh1 { get => image; set { image = value; Anh.Image = value; } }

        public Image GetImage
        {
            get { return Anh.Image; }
        }

        private string Ma;
        public string MaSP { get => Ma; set { Ma = value; txtMaSP.Texts = value; } }


        public string GetMa
        {
            get { return txtMaSP.Texts; }
        }


        private string Ten;
        public string TenSP
        {
            get => Ten;
            set
            {
                Ten = value;
                cbbTenSP.Texts = value;
            }
        }


        public string GetTenSP
        {
            get { return cbbTenSP.Texts; }
        }


        private string Ms;
        public string MauSac { get => Ms; set { Ms = value; cbbMauSac.Texts = value; } }


        public string GetMauSac
        {
            get { return cbbMauSac.Texts; }
        }



        private string Sze;
        public string Size1 { get => Sze; set { Sze = value; cbbSize.Texts = value; } }


        public string GetSize
        {
            get { return cbbSize.Texts; }
        }


        private string CLieu;
        public string ChatLieu { get => CLieu; set { CLieu = value; CbbChatLieu.Texts = value; } }


        public string GetChatLieu
        {
            get { return CbbChatLieu.Texts; }
        }


        private string Tem;
        public string Team { get => Tem; set { Tem = value; cbbTeam.Texts = value; } }


        public string Getteam
        {
            get { return cbbTeam.Texts; }
        }


        private string GNhap;
        public string GiaNhap { get => GNhap; set { GNhap = ValidateInput.RegexDecimal(value).ToString(); txtGiaNhap.Texts = ValidateInput.RegexDecimal(value).ToString(); } }


        public string GetGiaNhap
        {
            get { return txtGiaNhap.Texts; }
        }


        private string GBan;
        public string GiaBan { get => GBan; set { GBan = ValidateInput.RegexDecimal(value).ToString(); txtGiaBan.Texts = ValidateInput.RegexDecimal(value).ToString(); } }


        public string GetGiaBan
        {
            get { return txtGiaBan.Texts; }
        }


        private string SL;
        public string SoLuong { get => SL; set { SL = value; txtSoLuong.Texts = value; } }


        public string GetSoLuong
        {
            get { return txtSoLuong.Texts; }
        }


        private string ghichu;
        public string Mota { get => ghichu; set { ghichu = value; txtGhiChu.Texts = value; } }


        public string GetGhiChu
        {
            get { return txtGhiChu.Texts; }
        }


        private string bHanh;
        public string BaoHanh { get => bHanh; set { bHanh = value; txtBaoHanh.Texts = value; } }


        public string GetBaoHanh
        {
            get { return txtBaoHanh.Texts; }
        }


        private string Kmai;
        public string KhuyenMai { get => Kmai; set { Kmai = value; cbbKhuyenMai.Texts = value; } }


        public string GetKhuyenMai
        {
            get { return cbbKhuyenMai.Texts; }
        }


        private string NHang;
        public string NhomHang { get => NHang; set { NHang = value; CbbNhomHang.Texts = value; } }


        public string GetNhomHang
        {
            get { return CbbNhomHang.Texts; }
        }



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


        public string GetTrangThai
        {
            get { return RdoDangBan.Checked ? "Đang Bán" :"Ngừng bán"; }
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
            Count = 2;
            if (Anh.Image != null && VaLidateTXT() && VaLidatecbb())
            {
                var Obj = _IChiTietSpServices.GetById(Guid.Parse(lblID.Text));
                if (!CheckTrungSP(IdSp(), IdMs(), IdSize(), IdTeam(), IdCL()) || (Obj.IdChatLieu == IdCL() && Obj.IdMauSac == IdMs() && Obj.IdTeam == IdTeam() && Obj.IdSp == IdSp() && Obj.IdSize == IdSize()))
                {
                    try
                    {
                        var sp = _IChiTietSpServices.GetById(Guid.Parse(lblID.Text));
                        sp.IdSp = IdSp();
                        sp.IdMauSac = IdMs();
                        sp.IdSize = IdSize();
                        sp.IdTeam = IdTeam();
                        sp.IdChatLieu = IdCL();
                        sp.BaoHanh = txtBaoHanh.Texts;
                        sp.MoTa = txtGhiChu.Texts;
                        sp.SoLuongTon = int.Parse(txtSoLuong.Texts);
                        sp.GiaNhap = decimal.Parse(txtGiaNhap.Texts);
                        sp.GiaBan = decimal.Parse(txtGiaBan.Texts);
                        sp.TrangThaiKhuyenMai = cbbKhuyenMai.Texts == "Áp dụng" ? 0 : 1;
                        sp.TrangThai = RdoDangBan.Checked ? 0 : 1;
                        _IChiTietSpServices.Update(sp);
                        var anh = _IAnhServices.GetAll().Find(x => x.IdChiTietSp == sp.Id && x.TenAnh == "Anh");
                        anh.DuongDan = (byte[])new ImageConverter().ConvertTo(Anh.Image, typeof(Byte[]));
                        _IAnhServices.Update(anh);
                        this.Alert("Cập nhật thành công", Form_Alert.enmType.Success);
                        this.Close();
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

        }
    }
}
