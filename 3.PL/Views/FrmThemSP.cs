using _1.DAL.DomainClass;
using _2.BUS.IServices;
using _2.BUS.Services;
using _3.PL.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BarcodeLib;
using _2.BUS.ViewModels;
using CustomAlertBoxDemo;
using _3.PL.Properties;
using CustomControls.RJControls;
using _3.PL.Utilities;
using System.Security.Cryptography.Xml;

namespace _3.PL
{
    public partial class FrmThemSP : Form
    {
        ISanPhamServices _ISanPhamServices;
        IKichCoServices _ISizeServices;
        IChatLieuServices _IChatLieuServices;
        MauSacServices _IMauSacServices;
        TeamServices _ITeamServices;
        IChiTietSpServices _IChiTietSpServices;
        AnhServices _IAnhServices;
        BarcodeLib.Barcode _barcode;
        public FrmThemSP()
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
            txtMaSP.Texts = Mats();
            cbbKhuyenMai.SelectedIndex = 0;
            RdoDangBan.Checked = true;
            _barcode = new Barcode();
            LoadCbb();
        }
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

        private void lblclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddSP_Click(object sender, EventArgs e)
        {
            FrmSanPham frmSP = new FrmSanPham();
            frmSP.ShowDialog();
            LoadCbb();
        }

        private void rjCircularPictureBox1_Click(object sender, EventArgs e)
        {
            FrmMauSac frmMauSac = new FrmMauSac();
            frmMauSac.ShowDialog();
            LoadCbb();
        }

        private void rjCircularPictureBox5_Click(object sender, EventArgs e)
        {
            FrmTeam frmTeam = new FrmTeam();
            frmTeam.ShowDialog();
            LoadCbb();
        }

        private void rjCircularPictureBox4_Click(object sender, EventArgs e)
        {
            FrmChatLieu frmChatLieu = new FrmChatLieu();
            frmChatLieu.ShowDialog();
            LoadCbb();
        }

        private void rjCircularPictureBox3_Click(object sender, EventArgs e)
        {
            FrmKichCo FrmKichCo = new FrmKichCo();
            FrmKichCo.ShowDialog();
            LoadCbb();
        }

        private Guid IdSp() => _ISanPhamServices.GetAll().Find(x => x.Ten == cbbTenSP.Texts).Id;
        private Guid IdMs() => _IMauSacServices.GetAll().Find(x => x.Ten == cbbMauSac.Texts).Id;
        private Guid IdCL() => _IChatLieuServices.GetAll().Find(x => x.Ten == CbbChatLieu.Texts).Id;
        private Guid IdTeam() => _ITeamServices.GetAll().Find(x=>x.Ten == cbbTeam.Texts).Id;
        private Guid IdSize() => _ISizeServices.GetAll().Find(x => x.Size == cbbSize.Texts).Id;
        private List<AnhViews> GetListAnh(Guid? Id) => _IAnhServices.GetAll().Where(x => x.IdChiTietSp == Id).ToList();
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

        private bool VaLidateTXT()
        {
            foreach (Control x in this.Controls)
            {
                if (x is RJTextBox && x!= txtGhiChu)
                {
                    if(Vldate.Null(((RJTextBox)x).Texts))
                        return false;
                }
            }
            return true;
        }
        private void ClearTXT()
        {
            foreach (Control x in this.Controls)
            {
                if (x is RJTextBox)
                {
                    ((RJTextBox)x).Texts = "";
                }
            }
        }
        private void ClearCBB()
        {
            foreach (Control x in this.Controls)
            {
                if (x is RJComboBox)
                {
                    ((RJComboBox)x).Texts = "";
                }
            }
        }


        public string Mats() => "SP0000" + Convert.ToString(_IChiTietSpServices.GetAll().Count == 0 ? 1 : _IChiTietSpServices.GetAll().Max(x => Convert.ToInt32(x.MaQr.Substring(2, x.MaQr.Length - 2)) + 1));
        private void Reset()
        {
            ClearTXT();
            ClearCBB();
            txtMaSP.Texts = Mats();
            RdoDangBan.Checked = true;
            Anh.Image = null;
            cbbKhuyenMai.SelectedIndex = 0;

        }
        private bool VaLidatecbb()
        {
            foreach (Control x in this.Controls)
            {
                if (x is RJComboBox && x!= CbbNhomHang)
                {
                    if (Vldate.Null(((RJComboBox)x).Texts))
                        return false;
                }
            }
            return true;
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (Anh.Image != null && VaLidateTXT() && VaLidatecbb())
            {
                if (!CheckTrungSP(IdSp(), IdMs(), IdSize(), IdTeam(), IdCL()))
                {
                    try
                    {
                        var x = new ChiTietSpViews()
                        {
                            Id = Guid.NewGuid(),
                            IdChatLieu = IdCL(),
                            IdSp = IdSp(),
                            IdMauSac = IdMs(),
                            IdSize = IdSize(),
                            IdTeam = IdTeam(),
                            MaQr = Mats(),
                            BaoHanh = txtBaoHanh.Texts,
                            SoLuongTon = int.Parse(txtSoLuong.Texts),
                            GiaBan = decimal.Parse(txtGiaBan.Texts),
                            GiaNhap = decimal.Parse(txtGiaNhap1.Texts),
                            TrangThai = RdoDangBan.Checked ? 0 : 1,
                            TrangThaiKhuyenMai = cbbKhuyenMai.SelectedIndex == 0 ? 0 : 1
                        };
                        _IChiTietSpServices.Add(x);

                        Image barcode = _barcode.Encode(BarcodeLib.TYPE.CODE128, Mats());
                        var Anh1 = new AnhViews()
                        {
                            IdChiTietSp = x.Id,
                            TenAnh = String.Concat("Barcode"),
                            DuongDan = (byte[])(new ImageConverter().ConvertTo(barcode, typeof(Byte[]))),
                            TrangThai = 0
                        };
                        _IAnhServices.Add(Anh1);
                        var Anh2 = new AnhViews()
                        {
                            IdChiTietSp = x.Id,
                            TenAnh = String.Concat("Anh"),
                            DuongDan = (byte[])(new ImageConverter().ConvertTo(Anh.Image, typeof(Byte[]))),
                            TrangThai = 0
                        };
                        _IAnhServices.Add(Anh2);
                        this.Alert("Thêm thành công", Form_Alert.enmType.Success);

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

        public void Alert(string msg, Form_Alert.enmType type)
        {
            Form_Alert frm = new Form_Alert();
            frm.showAlert(msg, type);
        }

        private void btnLuuThemMoi_Click(object sender, EventArgs e)
        {
            if (Anh.Image != null && VaLidateTXT() && VaLidatecbb())
            {
                if (!CheckTrungSP(IdSp(), IdMs(), IdSize(), IdTeam(), IdCL()))
                {
                    try
                    {
                        var x = new ChiTietSpViews()
                        {
                            Id = Guid.NewGuid(),
                            IdChatLieu = IdCL(),
                            IdSp = IdSp(),
                            IdMauSac = IdMs(),
                            IdSize = IdSize(),
                            IdTeam = IdTeam(),
                            MaQr = Mats(),
                            BaoHanh = txtBaoHanh.Texts,
                            SoLuongTon = int.Parse(txtSoLuong.Texts),
                            GiaBan = decimal.Parse(txtGiaBan.Texts),
                            GiaNhap = decimal.Parse(txtGiaNhap1.Texts),
                            TrangThai = RdoDangBan.Checked ? 0 : 1,
                            TrangThaiKhuyenMai = cbbKhuyenMai.SelectedIndex == 0 ? 0 : 1
                        };
                        _IChiTietSpServices.Add(x);

                        Image barcode = _barcode.Encode(BarcodeLib.TYPE.CODE128, "Tes");
                        var Anh1 = new AnhViews()
                        {
                            IdChiTietSp = x.Id,
                            TenAnh = String.Concat("Barcode"),
                            DuongDan = (byte[])(new ImageConverter().ConvertTo(barcode, typeof(Byte[]))),
                            TrangThai = 0
                        };
                        _IAnhServices.Add(Anh1);
                        var Anh2 = new AnhViews()
                        {
                            IdChiTietSp = x.Id,
                            TenAnh = String.Concat("Anh"),
                            DuongDan = (byte[])(new ImageConverter().ConvertTo(Anh.Image, typeof(Byte[]))),
                            TrangThai = 0
                        };
                        _IAnhServices.Add(Anh2);
                        this.Alert("Thêm thành công", Form_Alert.enmType.Success);

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    Reset();
                }
                else
                    this.Alert("Sản phẩm này đã tồn tại", Form_Alert.enmType.Warning);
            }
            else
            {
                this.Alert("Vui lòng nhập đủ trương *", Form_Alert.enmType.Warning);
            }
        }

        private void btnLuuSaochep_Click(object sender, EventArgs e)
        {
            if (Anh.Image != null && VaLidateTXT() && VaLidatecbb())
            {
                if (!CheckTrungSP(IdSp(), IdMs(), IdSize(), IdTeam(), IdCL()))
                {
                    try
                    {
                        var x = new ChiTietSpViews()
                        {
                            Id = Guid.NewGuid(),
                            IdChatLieu = IdCL(),
                            IdSp = IdSp(),
                            IdMauSac = IdMs(),
                            IdSize = IdSize(),
                            IdTeam = IdTeam(),
                            MaQr = Mats(),
                            BaoHanh = txtBaoHanh.Texts,
                            SoLuongTon = int.Parse(txtSoLuong.Texts),
                            GiaBan = decimal.Parse(txtGiaBan.Texts),
                            GiaNhap = decimal.Parse(txtGiaNhap1.Texts),
                            TrangThai = RdoDangBan.Checked ? 0 : 1,
                            TrangThaiKhuyenMai = cbbKhuyenMai.SelectedIndex == 0 ? 0 : 1
                        };
                        _IChiTietSpServices.Add(x);

                        Image barcode = _barcode.Encode(BarcodeLib.TYPE.CODE128, "Tes");
                        var Anh1 = new AnhViews()
                        {
                            IdChiTietSp = x.Id,
                            TenAnh = String.Concat("Barcode"),
                            DuongDan = (byte[])(new ImageConverter().ConvertTo(barcode, typeof(Byte[]))),
                            TrangThai = 0
                        };
                        _IAnhServices.Add(Anh1);
                        var Anh2 = new AnhViews()
                        {
                            IdChiTietSp = x.Id,
                            TenAnh = String.Concat("Anh"),
                            DuongDan = (byte[])(new ImageConverter().ConvertTo(Anh.Image, typeof(Byte[]))),
                            TrangThai = 0
                        };
                        _IAnhServices.Add(Anh2);
                        this.Alert("Thêm thành công", Form_Alert.enmType.Success);

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    txtMaSP.Texts = Mats();
                }
                else
                    this.Alert("Sản phẩm này đã tồn tại", Form_Alert.enmType.Warning);
            }
            else
            {
                this.Alert("Vui lòng nhập đủ trương *", Form_Alert.enmType.Warning);
            }
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

        private void txtGiaNhap1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;

        }

        private void txtGiaBan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void rjCircularPictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
