using _2.BUS.IServices;
using _2.BUS.Services;
using _2.BUS.ViewModels;
using _3.PL.Properties;
using _3.PL.Utilities;
using CustomAlertBoxDemo;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.Animation;

namespace _3.PL.Views
{
    public partial class frmQLChiTietSp : Form
    {
        IAnhServices _IAnhServices;
        int x;
        IChiTietSpServices _IChiTietSpServices;
        ISanPhamServices _ISanPhamServices;
        IMauSacServices _IMauSacServices;
        ITeamServices _ITeamServices;
        IChatLieuServices _IChatLieuServices;
        IKichCoServices _ISizeServices;
        Guid _SelectID;
        public frmQLChiTietSp()
        {
            InitializeComponent();
            _ISanPhamServices = new SanPhamServices();
            _IChiTietSpServices = new ChiTietSpServices();
            _IMauSacServices = new MauSacServices();
            _ITeamServices = new TeamServices();
            _IChatLieuServices = new ChatLieuServices();
            _ISizeServices = new KichCoServices();
            _IAnhServices = new AnhServices();
            _SelectID = new Guid();
            cbbTrangThai1.Items.Add("Đang bán");
            cbbTrangThai1.Items.Add("Dừng bán");
            LoadCbb();
            LoadData();
            resest();
            x = 0;
        }

        private void LoadCbb()
        {
            cbbSP1.Items.Clear();
            foreach (var item in _ISanPhamServices.GetAll())
            {
                cbbSP1.Items.Add(item.Ten);
            }
            cbbsize1.Items.Clear();
            foreach (var item in _ISizeServices.GetAll())
            {
                cbbsize1.Items.Add(item.Size);
            }
            cbbChatLieu1.Items.Clear();
            foreach (var item in _IChatLieuServices.GetAll())
            {
                cbbChatLieu1.Items.Add(item.Ten);
            }
            cbbms1.Items.Clear();
            foreach (var item in _IMauSacServices.GetAll())
            {
                cbbms1.Items.Add(item.Ten);
            }
            cbbTeam1.Items.Clear();
            foreach (var item in _ITeamServices.GetAll())
            {
                cbbTeam1.Items.Add(item.Ten);
            }
            //cbbTrangThai1.Items.Clear();


        }
        private void FakeData()
        {
            for (int i = 1; i < 5; i++)
            {
                _IChatLieuServices.Add(new ChatLieuViews()
                {
                    Ma = "CL" + i.ToString(),
                    Ten = "Chất liệu " + i.ToString()
                });
                _ISizeServices.Add(new KichCoViews()
                {
                    Ma = "KC" + i.ToString(),
                    Size = "L" + i.ToString()
                });
                _IMauSacServices.Add(new MauSacView()
                {
                    Ma = "Ms" + i.ToString(),
                    Ten = "Màu sắc " + i.ToString()
                });
                _ITeamServices.Add(new TeamView()
                {
                    Ma = "Team" + i.ToString(),
                    Ten = "Team " + i.ToString()
                });
                _ISanPhamServices.Add(new SanPhamViews()
                {
                    Ma = "SP" + i.ToString(),
                    Ten = "Sản Phẩm " + i.ToString()
                });

            }
        }
        private void LoadData()
        {
            int stt = 1;
            var _lst = _IChiTietSpServices.GetAll();
            dtgView.Columns.Clear();
            dtgView.ColumnCount = 11;
            dtgView.Columns[0].Name = "ID";
            dtgView.Columns[0].Visible = false;
            dtgView.Columns[1].Name = "STT";
            dtgView.Columns[2].Name = "Sản phẩm";
            dtgView.Columns[3].Name = "Chất liệu";
            dtgView.Columns[4].Name = "Team";
            dtgView.Columns[5].Name = "Màu sắc";
            dtgView.Columns[6].Name = "Size";
            dtgView.Columns[7].Name = "Giá bán";
            dtgView.Columns[8].Name = "Giá nhập";
            dtgView.Columns[9].Name = "Số lượng tồn";
            dtgView.Columns[10].Name = "Trạng Thái";
            foreach (var x in _lst)
            {
                dtgView.Rows.Add(x.Id, stt++, x.TenSP, x.TenChatLieu, x.TenTeam, x.TenMauSac, x.Size, x.GiaBan, x.GiaNhap, x.SoLuongTon, x.TrangThai == 0 ? "Đang bán" : "Dừng Bán", x.IdMauSac, x.IdChatLieu, x.IdSize, x.IdTeam, x.IdSp);
            }
        }
        private Guid IdSp() => _ISanPhamServices.GetAll().Find(x => x.Ten == cbbSP1.Texts).Id;
        private Guid IdMs() => _IMauSacServices.GetAll().Find(x => x.Ten == cbbms1.Texts).Id;
        private Guid IdCL() => _IChatLieuServices.GetAll().Find(x => x.Ten == cbbChatLieu1.Texts).Id;
        private Guid IdTeam() => _ITeamServices.GetIdByName(cbbTeam1.Texts);
        private Guid IdSize() => _ISizeServices.GetAll().Find(x => x.Size == cbbsize1.Texts).Id;
        private List<AnhViews> GetListAnh(Guid? Id) => _IAnhServices.GetAll().Where(x => x.IdChiTietSp == Id).ToList();

        private string Cell(int x) => dtgView.CurrentRow.Cells[x].Value.ToString();


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

        private void resest()
        {
            txtBaoHanh1.Texts = "";
            txtGiaBan1.Texts = "";
            txtGiaNhap1.Texts = "";
            txtSLton.Texts = "";
            txtMoTa1.Texts = "";
            cbbChatLieu1.SelectedIndex = -1;
            cbbms1.SelectedIndex = -1;
            cbbsize1.SelectedIndex = -1;
            cbbSP1.SelectedIndex = -1;
            cbbTeam1.SelectedIndex = -1;
            cbbTrangThai1.SelectedIndex = -1;
            rdoApDung1.Checked = false;
            rdoKhongApDung1.Checked = false;
            _SelectID = new Guid();
        }

        private ChiTietSpViews Obj() => _IChiTietSpServices.GetById(_SelectID);

        public void Alert(string msg, Form_Alert.enmType type)
        {
            Form_Alert frm = new Form_Alert();
            frm.showAlert(msg, type);
        }
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (!Vldate.Null(cbbChatLieu1.Texts) && !Vldate.Null(cbbms1.Texts) && !Vldate.Null(cbbsize1.Texts) && !Vldate.Null(cbbSP1.Texts) && !Vldate.Null(cbbTeam1.Texts) && !Vldate.Null(cbbTrangThai1.Texts) && Vldate.KnullTXTGrb(grbtt, txtMoTa1) && anhtt.Image != null && Anhtt1.Image != null && (rdoApDung1.Checked || rdoKhongApDung1.Checked))
            {
                if (!CheckTrungSP(IdSp(), IdMs(), IdSize(), IdTeam(), IdCL()) || (Obj().IdChatLieu == IdCL() && Obj().IdMauSac == IdMs() && Obj().IdTeam == IdTeam() && Obj().IdSp == IdSp() && Obj().IdSize == IdSize()))
                {
                    try
                    {
                        if (Obj() != null)
                        {
                            //_IChiTietSpServices.Update(new ChiTietSpViews(_SelectID, IdSp(), IdMs(), IdSize(), IdTeam(), IdCL(), txtBaoHanh1.Texts, txtMoTa1.Texts, int.Parse(txtSLton.Texts), decimal.Parse(txtGiaNhap1.Texts), int.Parse(txtGiaBan1.Texts), cbbTrangThai1.Texts == "Đang bán" ? 0 : 1, rdoApDung1.Checked ? 0 : 1));
                            var Anh = new AnhViews()
                            {
                                Id = GetListAnh(_SelectID)[0].Id,
                                TenAnh = String.Concat("1"),
                                DuongDan = (byte[])new ImageConverter().ConvertTo(anhtt.Image, typeof(Byte[])),
                                TrangThai = 0
                            };
                            _IAnhServices.Update(Anh);
                            var Anh1 = new AnhViews()
                            {
                                Id = GetListAnh(_SelectID)[1].Id,
                                TenAnh = String.Concat("1"),
                                DuongDan = (byte[])new ImageConverter().ConvertTo(Anhtt1.Image, typeof(Byte[])),
                                TrangThai = 0
                            };
                            _IAnhServices.Update(Anh1);

                            this.Alert("Update succsess", Form_Alert.enmType.Success);
                            LoadData();
                            this.anhtt.Image = Resources.AddImg;
                            this.Anhtt1.Image = Resources.AddImg;
                            resest();
                        }
                        else
                        {

                            this.Alert("Vui lòng chọn sản phẩm", Form_Alert.enmType.Warning);
                        }

                    }
                    catch (Exception ex)
                    {

                        this.Alert(ex.Message, Form_Alert.enmType.Error);
                    }
                }
                else
                {

                    this.Alert("Sản phẩm này đã tồn tại", Form_Alert.enmType.Warning);
                }
            }
            else
                this.Alert("Vui lòng nhập đủ trường *", Form_Alert.enmType.Warning);
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            if (!Vldate.Null(cbbChatLieu1.Texts) && !Vldate.Null(cbbms1.Texts) && !Vldate.Null(cbbsize1.Texts) && !Vldate.Null(cbbSP1.Texts) && !Vldate.Null(cbbTeam1.Texts) && !Vldate.Null(cbbTrangThai1.Texts) && Vldate.KnullTXTGrb(grbtt, txtMoTa1) && anhtt.Image != null && Anhtt1.Image != null && (rdoApDung1.Checked || rdoKhongApDung1.Checked))
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
                            BaoHanh = txtBaoHanh1.Texts,
                            SoLuongTon = int.Parse(txtSLton.Texts),
                            GiaBan = decimal.Parse(txtGiaBan1.Texts),
                            GiaNhap = decimal.Parse(txtGiaNhap1.Texts),
                            TrangThai = cbbTrangThai1.Texts == "Đang bán" ? 0 : 1,
                            TrangThaiKhuyenMai = rdoApDung1.Checked ? 0 : 1
                        };
                        _IChiTietSpServices.Add(x);

                        var Anh = new AnhViews()
                        {
                            IdChiTietSp = x.Id,
                            TenAnh = String.Concat("1"),
                            DuongDan = (byte[])(new ImageConverter().ConvertTo(anhtt.Image, typeof(Byte[]))),
                            TrangThai = 0
                        };
                        _IAnhServices.Add(Anh);
                        var Anh1 = new AnhViews()
                        {
                            IdChiTietSp = x.Id,
                            TenAnh = String.Concat("1"),
                            DuongDan = (byte[])(new ImageConverter().ConvertTo(Anhtt1.Image, typeof(Byte[]))),
                            TrangThai = 0
                        };
                        _IAnhServices.Add(Anh1);
                        this.Alert("Thêm thành công", Form_Alert.enmType.Success);
                        LoadData();
                        this.anhtt.Image = Resources.AddImg;
                        this.Anhtt1.Image = Resources.AddImg;
                        resest();
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
                this.Alert("Vui lòng nhập đủ trường *", Form_Alert.enmType.Warning);
        }


        private void dtgView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _SelectID = Guid.Parse(Cell(0));
            anhthongtin.Image = anhtt.Image = Image.FromStream(new MemoryStream((byte[])GetListAnh(_SelectID)[0].DuongDan));
            Anhtt1.Image = Image.FromStream(new MemoryStream((byte[])GetListAnh(_SelectID)[1].DuongDan));
            anhtt.Image = Image.FromStream(new MemoryStream((byte[])GetListAnh(_SelectID)[0].DuongDan));
            anhtt.SizeMode = PictureBoxSizeMode.StretchImage;
            Anhtt1.Image = Image.FromStream(new MemoryStream((byte[])GetListAnh(_SelectID)[1].DuongDan));
            Anhtt1.SizeMode = PictureBoxSizeMode.StretchImage;

            lbltensp1.Text = Cell(2);
            lblGiaSP.Text = "Giá: " + double.Parse(Cell(7)).ToString("#,###", CultureInfo.GetCultureInfo("vi-VN").NumberFormat) + " đ";
            lblChatLieuSP.Text = "Chất liệu: " + Cell(3);
            lblsizesp.Text = "Size: " + Cell(6);
            lblSoLuongSP.Text = "Số lượng: " + Cell(9);
            lblmauSacSP.Text = "Màu: " + Cell(5);
            lblTeamSP.Text = "Team: " + Cell(4);
        }

        private void dtgView_DoubleClick(object sender, EventArgs e)
        {
            _SelectID = Guid.Parse(Cell(0));
            TabAll.SelectedTab = TabThongTin;
            cbbSP1.Texts = Cell(2);
            cbbChatLieu1.Texts = Cell(3);
            cbbTeam1.Texts = Cell(4);
            cbbms1.Texts = Cell(5);
            cbbsize1.Texts = Cell(6);
            txtGiaBan1.Texts = Cell(7);
            txtGiaNhap1.Texts = Cell(8);
            txtSLton.Texts = Cell(9);
            cbbTrangThai1.Texts = Cell(10);
            txtBaoHanh1.Texts = _IChiTietSpServices.GetById(_SelectID).BaoHanh;
            txtMoTa1.Text = _IChiTietSpServices.GetById(_SelectID).MoTa;
            if (_IChiTietSpServices.GetById(_SelectID).TrangThaiKhuyenMai == 0) rdoApDung1.Checked = true;
            if (_IChiTietSpServices.GetById(_SelectID).TrangThaiKhuyenMai == 1) rdoKhongApDung.Checked = true;
            cbbTrangThai1.Texts = _IChiTietSpServices.GetById(_SelectID).TrangThai == 0 ? "Đang bán" : "Dừng bán";
        }

        private void anhtt_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image file:| *.jpg;*.jpeg;*.png;*.gif;*.tif;...";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                DialogResult result = MessageBox.Show("Bạn có muốn chọn ảnh không?",
               "Thông báo", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    anhtt.Image = Image.FromFile(ofd.FileName);
                }
            }
        }

        private void Anhtt1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image file:| *.jpg;*.jpeg;*.png;*.gif;*.tif;...";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                DialogResult result = MessageBox.Show("Bạn có muốn chọn ảnh không?",
               "Thông báo", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    Anhtt1.Image = Image.FromFile(ofd.FileName);
                }
            }

        }

        private void btnAddSP_Click(object sender, EventArgs e)
        {
            FrmSanPham frmSP = new FrmSanPham();
            frmSP.ShowDialog();
            LoadCbb();
        }

        private void btnAddMauSac_Click(object sender, EventArgs e)
        {
            FrmMauSac frmMauSac = new FrmMauSac();
            frmMauSac.ShowDialog();
            LoadCbb();
        }

        private void btnAddTeam_Click(object sender, EventArgs e)
        {
            FrmTeam frmTeam = new FrmTeam();
            frmTeam.ShowDialog();
            LoadCbb();
        }

        private void btnAddChatLieu_Click(object sender, EventArgs e)
        {
            FrmChatLieu frmChatLieu = new FrmChatLieu();
            frmChatLieu.ShowDialog();
            LoadCbb();
        }

        private void btnaddSize_Click(object sender, EventArgs e)
        {
            FrmKichCo FrmKichCo = new FrmKichCo();
            FrmKichCo.ShowDialog();
            LoadCbb();
        }
    }
}
