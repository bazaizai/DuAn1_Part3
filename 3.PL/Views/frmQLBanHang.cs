using _1.DAL.DomainClass;
using _2.BUS.IServices;
using _2.BUS.Services;
using _2.BUS.ViewModels;
using _3.PL.Components;
using _3.PL.Utilities;
using CustomAlertBoxDemo;
using CustomControls.RJControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net.WebSockets;
using System.Windows.Documents;
using System.Windows.Forms;

namespace _3.PL.Views
{
    public partial class frmQLBanHang : Form
    {
        IAnhServices _IanhServices;
        IChiTietHDServices _IChiTietHDServices;
        IChiTietSpServices _IChiTietSpServices;
        ISanPhamServices _ISanPhamServices;
        IMauSacServices _IMauSacServices;
        ITeamServices _ITeamServices;
        IChatLieuServices _IChatLieuServices;
        IKichCoServices _ISizeServices;
        IHoaDonServices _HoaDonServices;
        IKhachHangServices _IKhachHangServices;
        IPtthanhToanServices _IPtthanhToanServices;
        IHinhThucMhServices _IHinhThucMhServices;
        TabPage tabPage;
        public string GetSdt { get; set; }
        public frmQLBanHang()
        {

            InitializeComponent();
            _IPtthanhToanServices = new PtthanhToanServices();
            _IChiTietSpServices = new ChiTietSpServices();
            _ISanPhamServices = new SanPhamServices();
            _IMauSacServices = new MauSacServices();
            _ITeamServices = new TeamServices();
            _IChatLieuServices = new ChatLieuServices();
            _ISizeServices = new KichCoServices();
            _IanhServices = new AnhServices();
            _HoaDonServices = new HoaDonServices();
            _IKhachHangServices = new KhachHangServices();
            _IHinhThucMhServices = new HinhThucMhServices();
            _IChiTietHDServices = new ChiTietHDServices();
            CbbGiamGia.SelectedIndex = 0;
            pnlKhachHang.Visible = false;
            //System.Windows.Documents.ListItem.Controls.Clear();
            ListItem.Controls.Clear();
            AnSearch();
            // FakeData();
            LoadItem();
            LoadCbb();
            LoadData();
            LoadGia();
            if (TabHoaDon.SelectedTab != null)
            {
                txtMaHD.Texts = TabHoaDon.SelectedTab.Name;
                dtgNgayTao.Value = Convert.ToDateTime(_HoaDonServices.GetAll().Find(x => x.MaHD == TabHoaDon.SelectedTab.Name).NgayTao);
            }
        }

        private void AnSearch()
        {
            if (txtSearch.Texts.Trim() == "")
            {
                pnlBodysearch.Height = txtsearchKH.Height;
            }
        }
        private void LoadData()
        {
            int stthd = 1;
            var lst = _HoaDonServices.GetAll().Where(c => c.TrangThai == 0).OrderBy(c => c.MaHD);
            foreach (var y in lst)
            {
                TabPage tabPage = new TabPage();
                tabPage.Text = y.MaHD;
                tabPage.Name = y.MaHD;
                TabHoaDon.TabPages.Add(tabPage);
                int stt = 1;
                if (TabHoaDon.TabCount == 1)
                {
                    dgview.Visible = true;
                    dgview.Parent = tabPage;
                    dgview.Dock = DockStyle.Fill;
                    Guid id = y.Id;
                    var list = _IChiTietHDServices.GetAll().Where(c => c.IdHoaDon == id);
                    decimal tongtien = 0;
                    foreach (var x in list)
                    {
                        dgview.Rows.Add(x.IdChiTietSp, stt++, x.TenSP, "+", x.SoLuong, "-",
                    double.Parse(x.DonGia.ToString()).ToString("#,###", CultureInfo.GetCultureInfo("vi-VN").NumberFormat) + "đ",
                    double.Parse((x.SoLuong * x.DonGia).ToString()).ToString("#,###", CultureInfo.GetCultureInfo("vi-VN").NumberFormat) + "đ", "X");
                        tongtien += Convert.ToDecimal(Convert.ToDecimal(x.SoLuong) * x.DonGia);
                    }
                    txtTongTien.Texts = double.Parse(tongtien.ToString()).ToString("#,###", CultureInfo.GetCultureInfo("vi-VN").NumberFormat) + "đ";
                }
            }
        }

        public void Alert(string msg, Form_Alert.enmType type)
        {
            Form_Alert frm = new Form_Alert();
            frm.showAlert(msg, type);
        }
        private void LoadCbb()
        {
            cbbHinhThucMuaHang.Items.Clear();
            foreach (var item in _IHinhThucMhServices.GetAll())
            {
                cbbHinhThucMuaHang.Items.Add(item.Ten);
            }
            cbbPtThanhToan.Items.Clear();
            foreach (var item in _IPtthanhToanServices.GetAll())
            {
                cbbPtThanhToan.Items.Add(item.Ten);
            }
        }

        private void btnAddTab_Click(object sender, EventArgs e)
        {
            tabPage = new TabPage(MaTT());
            txtMaHD.Texts = tabPage.Name = MaTT();
            TabHoaDon.TabPages.Add(tabPage);
            dgview.Parent = tabPage;
            LoadView(TabHoaDon.SelectedTab.Name);
            dgview.Visible = true;
            dgview.Dock = DockStyle.Fill;
            var x = new HoaDonViews()
            {
                Id = Guid.NewGuid(),
                //IdKh = _IKhachHangServices.GetAll().Find(x => int.Parse(x.Sdt) == int.Parse(txtsearchKH.Texts)).Id,
                //IdPttt = _IPtthanhToanServices.GetAll().Find(x => x.Ten == cbbPtThanhToan.Texts).Id,
                //IdHt = _IHinhThucMhServices.GetAll().Find(x => x.Ten == cbbHinhThucMuaHang.Texts).Id,
                MaHD = MaTT(),
                //IdUD = Guid.Empty,
                NgayTao = DateTime.Now,
                TrangThai = 0,
            };
            _HoaDonServices.Add(x);
            TabHoaDon.SelectedTab = tabPage;
            this.Alert("Tạo mới thành công hóa đơn " + TabHoaDon.SelectedTab.Name, Form_Alert.enmType.Success);

        }

        private void LoadItem()
        {
            ListItem.Controls.Clear();
            List<Hats> Hats = new List<Hats>();
            Hats[] Hat = new Hats[_IanhServices.GetAll().GroupBy(x => x.IdChiTietSp).Select(sp => sp.First()).ToList().Count];
            List<AnhViews> ListAnh = _IanhServices.GetAll().GroupBy(x => x.IdChiTietSp).Select(sp => sp.First()).Where(x => x.TrangThaiSP == 0).ToList();
            for (int i = 0; i < ListAnh.Count; i++)
            {
                if (ListAnh[i].SoLuongTon > 0)
                {
                    Hat[i] = new Hats();
                    Hat[i].TenSP1 = _ISanPhamServices.GetAll().Find(sp => sp.Id == ListAnh[i].IdSp).Ten;
                    Hat[i].Icon = Image.FromStream(new MemoryStream((byte[])ListAnh[i].DuongDan));
                    Hat[i].Price = Convert.ToDouble(ListAnh[i].GiaBan);
                    Hat[i].SoluongSP1 = ListAnh[i].SoLuongTon.ToString();
                    Hat[i].IdSPCTSP = ListAnh[i].IdChiTietSp.GetValueOrDefault();

                    ListItem.Controls.Add(Hat[i]);
                    Hat[i].Onselect += (ss, ee) =>
                    {
                        var wdg = (Hats)ss;
                        if (TabHoaDon.SelectedTab != null)
                        {
                            if (_IChiTietHDServices.GetAll().Where(x => x.MaHD == TabHoaDon.SelectedTab.Name).ToList().All(x => x.IdChiTietSp != wdg.
                                IdSPCTSP))
                            {
                                var x = new ChiTietHDView();
                                x.IdChiTietSp = wdg.IdSPCTSP;
                                x.DonGia = decimal.Parse(wdg.Price.ToString());
                                x.TenSP = wdg.TenSP1;
                                x.IdHoaDon = _HoaDonServices.GetAll().FirstOrDefault(x => x.MaHD == TabHoaDon.SelectedTab.Name).Id;
                                x.SoLuong = 1;
                                _IChiTietHDServices.Add(x);
                            }
                            else
                            {
                                var hdct = _IChiTietHDServices.GetAll().FirstOrDefault(x => x.IdChiTietSp == wdg.IdSPCTSP && x.IdHoaDon == _HoaDonServices.GetAll().FirstOrDefault(c => c.MaHD == TabHoaDon.SelectedTab.Name).Id);
                                var spct = _IChiTietSpServices.GetAll().Find(x => x.Id == hdct.IdChiTietSp);
                                if (hdct.SoLuong < spct.SoLuongTon)
                                {
                                    hdct.SoLuong += 1;
                                    _IChiTietHDServices.Update(hdct);
                                }
                                else
                                {
                                    this.Alert("Hiện tại không còn mặt hàng này", Form_Alert.enmType.Warning);
                                }
                            }
                            LoadView(TabHoaDon.SelectedTab.Name);
                            LoadGia();
                            LoadTienThua();
                        }
                        else
                        {

                            this.Alert("Vui lòng tạo hóa đơn", Form_Alert.enmType.Warning);
                        }
                    };
                }
                else
                {
                    var spct = _IChiTietSpServices.GetById(ListAnh[i].IdChiTietSp.GetValueOrDefault());
                    spct.TrangThai = 1;
                    _IChiTietSpServices.Update(spct);
                }

            }
        }

        private void LoadView(string HD)
        {
            int stt = 1;
            dgview.Rows.Clear();
            foreach (var x in _IChiTietHDServices.GetAll().Where(x => x.MaHD == HD).ToList())
            {
                dgview.Rows.Add(x.IdChiTietSp, stt++, x.TenSP, "+", x.SoLuong, "-",
                    double.Parse(x.DonGia.ToString()).ToString("#,###", CultureInfo.GetCultureInfo("vi-VN").NumberFormat) + "đ",
                    double.Parse((x.SoLuong * x.DonGia).ToString()).ToString("#,###", CultureInfo.GetCultureInfo("vi-VN").NumberFormat) + "đ", "X");
            }
        }
        private string MaTT()
        {
            if (_HoaDonServices.GetAll().Count > 0)
            {
                return "HD" + Convert.ToString(_HoaDonServices.GetAll().Max(c => Convert.ToInt32(c.MaHD.Substring(2, c.MaHD.Length - 2)) + 1));
            }
            else return "HD1";
        }
        private KhachHangView GetKH(string sdt) => sdt.Trim() == string.Empty ? null : _IKhachHangServices.GetAll().FirstOrDefault(x => x.Sdt == sdt);

        private void txtsearchKH__TextChanged(object sender, EventArgs e)
        {
            GetSdt = txtsearchKH.Texts;
            if (txtsearchKH.Texts == "")
            {
                pnlKhachHang.Visible = false;
            }
            else if (GetKH(txtsearchKH.Texts) != null)
            {
                pnlKhachHang.Visible = true;
                lblTen.Text = "KH: " + GetKH(txtsearchKH.Texts).Ten;
                lblSoDT.Text ="SĐt: " +  GetKH(txtsearchKH.Texts).Sdt;
                lblDiaChi.Text = "Địa chỉ: " + GetKH(txtsearchKH.Texts).DiaChi;
                lblMucTichLuy.Text = "Điểm tích lũy: " + GetKH(txtsearchKH.Texts).SoDiem;
            }
            else if (GetKH(txtsearchKH.Texts) == null)
            {
                pnlKhachHang.Visible = false;
            }

        }

        private ChiTietHDView GetHDct(Guid ID) => _IChiTietHDServices.GetAll().Find(x => x.IdChiTietSp == ID && x.MaHD == TabHoaDon.SelectedTab.Name);

        private string Cell(int x) => dgview.CurrentRow.Cells[x].Value.ToString();
        private void dgview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex < 0) return;
            if (dgview.Columns[e.ColumnIndex].Name == "TangSP")
            {
                var hdct = GetHDct(Guid.Parse(Cell(0)));
                if (hdct.SoLuong < _IChiTietSpServices.GetById(Guid.Parse(Cell(0))).SoLuongTon)
                {
                    hdct.SoLuong += 1;
                    _IChiTietHDServices.Update(hdct);
                }
                else
                {

                    this.Alert("Hết hàng", Form_Alert.enmType.Warning);
                }
            }
            if (dgview.Columns[e.ColumnIndex].Name == "GiamSP")
            {
                var hdct = GetHDct(Guid.Parse(Cell(0)));
                if (hdct.SoLuong > 1)
                {
                    hdct.SoLuong -= 1;
                    _IChiTietHDServices.Update(hdct);
                }
            }
            if (dgview.Columns[e.ColumnIndex].Name == "XoaSP")
            {
                var hdct = GetHDct(Guid.Parse(Cell(0)));
                _IChiTietHDServices.Delete(hdct);
            }
            LoadView(TabHoaDon.SelectedTab.Name);
            LoadGia();
            LoadTienThua();

        }
        private void txtSearchSP__TextChanged(object sender, EventArgs e)
        {

        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            txtsearchKH.PlaceholderText = "";
        }

        private void rjCircularPictureBox3_Click(object sender, EventArgs e)
        {
            FrmKhachHang frmkh = new FrmKhachHang(txtsearchKH.Texts);
            frmkh.ShowDialog();
            if (txtsearchKH.Texts == "")
            {

            }
            else if (GetKH(txtsearchKH.Texts) != null)
            {

            }
            else if (GetKH(txtsearchKH.Texts) == null)
            {

            }
        }

        private void TabHoaDon_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtTienThua.Texts = "";
            txthtThanhToan.Texts = ""; 
            LoadGia();
            LoadTienThua();
        }
        private void LoadGia()
        {
            if (TabHoaDon.SelectedTab != null)
            {
                dgview.Rows.Clear();
                dgview.Parent = TabHoaDon.TabPages[TabHoaDon.SelectedIndex];
                Guid id = _HoaDonServices.GetAll().FirstOrDefault(c => c.MaHD == TabHoaDon.SelectedTab.Name).Id;
                var list = _IChiTietHDServices.GetAll().Where(c => c.IdHoaDon == id);
                int stt = 1;
                decimal tongtien = 0;
                foreach (var x in list)
                {
                    dgview.Rows.Add(x.IdChiTietSp, stt++, x.TenSP, "+", x.SoLuong, "-",
                       double.Parse(x.DonGia.ToString()).ToString("#,###", CultureInfo.GetCultureInfo("vi-VN").NumberFormat) + "đ",
                       double.Parse((x.SoLuong * x.DonGia).ToString()).ToString("#,###", CultureInfo.GetCultureInfo("vi-VN").NumberFormat) + "đ", "X");
                    tongtien += Convert.ToDecimal(Convert.ToDecimal(x.SoLuong) * x.DonGia);
                }
                txtTongTien.Texts = double.Parse(tongtien.ToString()).ToString("#,###", CultureInfo.GetCultureInfo("vi-VN").NumberFormat) + "đ";
                txtMaHD.Texts = TabHoaDon.SelectedTab.Name;
                if (CbbGiamGia.SelectedIndex == 0)
                {
                    if (txtGiamGia.Texts.Trim() != "")
                    {
                        if (Convert.ToDecimal(txtGiamGia.Texts) >= 100)
                        {
                            txtGiamGia.Texts = 100.ToString();
                            txtTongTienPTra.Texts = 0.ToString();
                        }
                        else
                        {
                            txtTongTienPTra.Texts = double.Parse((tongtien *(100 - decimal.Parse(txtGiamGia.Texts)) / 100).ToString()).ToString("#,###", CultureInfo.GetCultureInfo("vi-VN").NumberFormat) + "đ";
                        }
                    }else
                    {
                        txtTongTienPTra.Texts = txtTongTien.Texts;
                    }
                }else
                {
                    if (txtGiamGia.Texts.Trim() != "")
                    {
                        if (Convert.ToDecimal(txtGiamGia.Texts) >= tongtien)
                        {
                            txtTongTienPTra.Texts = 0.ToString();
                        }
                        else
                        {
                            txtTongTienPTra.Texts = double.Parse((tongtien - Convert.ToDecimal(txtGiamGia.Texts)).ToString()).ToString("#,###", CultureInfo.GetCultureInfo("vi-VN").NumberFormat) + "đ";
                        }
                    }
                    else
                    {
                        txtTongTienPTra.Texts = txtTongTien.Texts;
                    }
                }
                if (_IChiTietHDServices.GetAll().Where(x=>x.MaHD == TabHoaDon.SelectedTab.Name).ToList().Count > 0 && txthtThanhToan.Texts.Trim() != "" && txtTongTienPTra.Texts != "")
                {
                    if (Convert.ToDecimal(txthtThanhToan.Texts) == ValidateInput.RegexDecimal(txtTongTienPTra.Texts))
                    {
                        txtTienThua.Texts = 0 + "đ";
                    }
                    else
                    {
                        if ((Convert.ToDecimal(txthtThanhToan.Texts) - ValidateInput.RegexDecimal(txtTongTienPTra.Texts)) > 0)
                        {
                            txtTienThua.Texts = double.Parse((Convert.ToDecimal(txthtThanhToan.Texts) - ValidateInput.RegexDecimal(txtTongTienPTra.Texts)).ToString()).ToString("#,###", CultureInfo.GetCultureInfo("vi-VN").NumberFormat) + "đ";
                        }else
                        {
                            txtTienThua.Texts = "";
                        }

                    }
                }
                if (txthtThanhToan.Texts == "")
                {
                    txtTienThua.Texts = 0.ToString();
                }
            }

            if (TabHoaDon.SelectedTab == null || !_IChiTietHDServices.GetAll().Where(x => x.MaHD == TabHoaDon.SelectedTab.Name).ToList().Any())
            {
                txtTongTien.Texts = "";
                txtTongTienPTra.Texts = "";
            }

        }

        private void Clearform()
        {
            txthtThanhToan.Texts = "";
            txtGiamGia.Texts = 0.ToString();
            cbbHinhThucMuaHang.SelectedIndex = -1;
            cbbPtThanhToan.SelectedIndex = -1;
            txtMaHD.Texts = "";
            txtTienThua.Texts = "";
            txtChuyenKhoan.Texts = "";
            txtTienThua.Texts = "";
            txthtThanhToan.Texts = "";
            cbbPtThanhToan.SelectedIndex = 0;
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
        private void LoadALL()
        {
            _IPtthanhToanServices = new PtthanhToanServices();
            _IChiTietSpServices = new ChiTietSpServices();
            _ISanPhamServices = new SanPhamServices();
            _IMauSacServices = new MauSacServices();
            _ITeamServices = new TeamServices();
            _IChatLieuServices = new ChatLieuServices();
            _ISizeServices = new KichCoServices();
            _IanhServices = new AnhServices();
            _HoaDonServices = new HoaDonServices();
            _IKhachHangServices = new KhachHangServices();
            _IHinhThucMhServices = new HinhThucMhServices();
            _IChiTietHDServices = new ChiTietHDServices();
            LoadItem();
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void txtTienKhachDua__TextChanged(object sender, EventArgs e)
        {
            LoadTienThua();
        }

        private void LoadTienThua()
        {
            if (TabHoaDon.SelectedTab != null)
            {
                if (txthtThanhToan.Texts.Trim() != "" && ValidateInput.CheckDecimalInput(txthtThanhToan.Texts.Trim()) && decimal.Parse(txthtThanhToan.Texts.Trim()) > _IChiTietHDServices.GetAll().Where(x => x.MaHD == TabHoaDon.SelectedTab.Name).Sum(x => x.SoLuong * x.DonGia))
                {
                    decimal TienThua = decimal.Parse(txthtThanhToan.Texts.Trim()) - decimal.Parse(_IChiTietHDServices.GetAll().Where(x => x.MaHD == TabHoaDon.SelectedTab.Name).Sum(x => x.SoLuong * x.DonGia).ToString());
                    if (TienThua < 0)
                    {
                        txtTienThua.Texts = "";
                    }else
                    {
                        txtTienThua.Texts = double.Parse(TienThua.ToString()).ToString("#,###", CultureInfo.GetCultureInfo("vi-VN").NumberFormat) + "đ";
                    }
                }
                else
                {
                    txtTienThua.Texts = "";
                }
            }
        }

        private void rjButton1_Click_1(object sender, EventArgs e)
        {
            if (TabHoaDon.SelectedTab != null)
            {
                if (txthtThanhToan.Texts.Trim() == "" || !ValidateInput.CheckDecimalInput(txthtThanhToan.Texts.Trim()))
                {
                    this.Alert("Trường tiền khách đưa chưa nhập", Form_Alert.enmType.Warning);
                }
                else
                {
                    if (_IChiTietHDServices.GetAll().Where(x => x.MaHD == TabHoaDon.SelectedTab.Name).Any())
                    {
                        if (decimal.Parse(txthtThanhToan.Texts.Trim()) >= ValidateInput.RegexDecimal(txtTongTienPTra.Texts))
                        {
                            var hoadon = _HoaDonServices.GetAll().FirstOrDefault(c => c.MaHD == TabHoaDon.SelectedTab.Name);
                            if (hoadon != null)
                            {
                                hoadon.NgayThanhToan = DateTime.Now;
                                hoadon.TrangThai = 1;
                                hoadon.IdPttt = _IPtthanhToanServices.GetAll().FirstOrDefault(c => c.Ten == cbbPtThanhToan.Texts).Id;
                                if (cbbPtThanhToan.Texts == "Tiền mặt")
                                {
                                    hoadon.TienKhachDua =Convert.ToDecimal(txthtThanhToan.Texts);
                                }
                                else if(cbbPtThanhToan.Texts == "Cả tiền mặt và chuyển khoản")
                                {
                                    hoadon.TienKhachDua = Convert.ToDecimal(txthtThanhToan.Texts);
                                    hoadon.TienChuyenKhoan = Convert.ToDecimal(txtChuyenKhoan.Texts);
                                }
                                else hoadon.TienChuyenKhoan = Convert.ToDecimal(txthtThanhToan.Texts);
                                hoadon.MaHD = TabHoaDon.SelectedTab.Name;
                                hoadon.TongTien = Convert.ToInt32(_IChiTietHDServices.GetAll().Where(x => x.MaHD == TabHoaDon.SelectedTab.Name).Sum(x => x.SoLuong * x.DonGia));
                                hoadon.TongTienSauKhiGiam = ValidateInput.RegexDecimal(txtTongTienPTra.Texts);
                                hoadon.TongTien = ValidateInput.RegexDecimal(txtTongTien.Texts);
                                if (txtsearchKH.Texts != "")
                                {
                                    var temp = _IKhachHangServices.GetAll().FirstOrDefault(c => c.Sdt == txtsearchKH.Texts);
                                    if (temp != null)
                                    {
                                        hoadon.IdKh = temp.Id;
                                    }
                                    else
                                    {
                                        hoadon.IdKh = null;
                                    }
                                }
                                else
                                {
                                    hoadon.IdKh = null;
                                }
                                string s = _HoaDonServices.Update(hoadon);
                                if (s == "Thành công")
                                {
                                    TabHoaDon.TabPages.Remove(TabHoaDon.TabPages[TabHoaDon.SelectedIndex]);
                                    this.Alert(_HoaDonServices.Update(hoadon), Form_Alert.enmType.Success);
                                    var HDCt = _IChiTietHDServices.GetAll().Where(x => x.IdHoaDon == hoadon.Id);
                                    foreach (var item in HDCt)
                                    {
                                        var ctsp = _IChiTietSpServices.GetAll().FirstOrDefault(x => x.Id == item.IdChiTietSp);
                                        ctsp.SoLuongTon -= item.SoLuong;
                                        _IChiTietSpServices.Update(ctsp);
                                    }
                                    LoadALL();
                                    Clearform();
                                }
                                else
                                {
                                    this.Alert(s, Form_Alert.enmType.Success);
                                }
                            }
                        }
                        else
                        {
                            this.Alert("Số tiền không đủ để thanh toán HD", Form_Alert.enmType.Warning);
                        }
                    }
                    else

                    this.Alert("Chưa có sản phẩm nào trong hóa đơn", Form_Alert.enmType.Warning);
                }
            }
            else
            {
                this.Alert("Hóa đơn không tồn tại", Form_Alert.enmType.Info);
            }
        }
        private void cbbPtThanhToan_OnSelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cbbPtThanhToan.Texts == "Cả tiền mặt và chuyển khoản")
            {
                lblHTThanhToan.Text = "Tiền mặt";
                lblHTThanhToan.Visible = true;
                txthtThanhToan.Visible = true;
                txtTienThua.Visible = true;
                lblTienThua.Visible = true;
                txtChuyenKhoan.Visible = true;
                lblChuyenTien.Visible = true;
            }
            else
            {
                lblHTThanhToan.Text = cbbPtThanhToan.Texts;
                lblHTThanhToan.Visible = true;
                txthtThanhToan.Visible = true;
                txtTienThua.Visible = true;
                lblTienThua.Visible = true;
                txtChuyenKhoan.Visible = false;
                lblChuyenTien.Visible = false;
            }
            if (CbbGiamGia.SelectedIndex == 0)
            {
                //txtTienThua.Texts = 
            }
        }

        private void txtGiamGia__TextChanged(object sender, EventArgs e)
        {
            LoadGia();
        }

        private void CbbGiamGia_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CbbGiamGia.SelectedIndex == 0)
            {
                if (txtTongTienPTra.Texts == 0.ToString())
                {
                    txtGiamGia.Texts = 100.ToString();
                }else if(txtTongTienPTra.Texts.Trim() != "" && txtTongTienPTra.Texts.Trim() != "")
                {
                    txtGiamGia.Texts = ((ValidateInput.RegexDecimal(txtTongTien.Texts) - ValidateInput.RegexDecimal(txtTongTienPTra.Texts)) / (ValidateInput.RegexDecimal(txtTongTien.Texts)) * 100).ToString();
                }
            }
            else
            {
                if (txtTongTienPTra.Texts == 0.ToString() && txtTongTien.Texts != "")
                {
                    txtGiamGia.Texts = ValidateInput.RegexDecimal(txtTongTien.Texts).ToString();
                }
                else if (txtTongTienPTra.Texts.Trim() != "" && txtTongTienPTra.Texts.Trim() != "")
                {
                    txtGiamGia.Texts = (ValidateInput.RegexDecimal(txtTongTien.Texts) - ValidateInput.RegexDecimal(txtTongTienPTra.Texts)).ToString() ;
                }
            }
        }

        private void txthtThanhToan__TextChanged(object sender, EventArgs e)
        {
            LoadGia();
        }

        private ChiTietSpViews GetCtsp(Guid id) => _IChiTietSpServices.GetById(id);
        private void LoadItemSearch(string name)
        {
            flpSP.Controls.Clear();
            SearchHats[] Hat = new SearchHats[_IanhServices.GetAll().GroupBy(x => x.IdChiTietSp).Select(sp => sp.First()).ToList().Count];
            List<AnhViews> ListAnh = _IanhServices.GetAll().GroupBy(x => x.IdChiTietSp).Select(sp => sp.First()).Where(x => x.TrangThaiSP == 0 && RemoveUnicode(GetCtsp(x.IdChiTietSp.GetValueOrDefault()).TenSP.ToLower()).Contains(RemoveUnicode(name.ToLower()))).ToList();
            if (ListAnh.Any())
            {
                for (int i = 0; i < ListAnh.Count; i++)
                {
                    if (ListAnh[i].SoLuongTon > 0)
                    {
                        Hat[i] = new SearchHats();
                        Hat[i].TenSP1 = _ISanPhamServices.GetAll().Find(sp => sp.Id == ListAnh[i].IdSp).Ten;
                        Hat[i].Icon = Image.FromStream(new MemoryStream((byte[])ListAnh[i].DuongDan));
                        Hat[i].Price = Convert.ToDouble(ListAnh[i].GiaBan);
                        Hat[i].SoluongSP1 = ListAnh[i].SoLuongTon.ToString();
                        Hat[i].IdSPCTSP = ListAnh[i].IdChiTietSp.GetValueOrDefault();

                        flpSP.Controls.Add(Hat[i]);
                        Hat[i].Onclick += (ss, ee) =>
                        {
                            var wdg = (SearchHats)ss;
                            if (TabHoaDon.SelectedTab != null)
                            {
                                if (_IChiTietHDServices.GetAll().Where(x => x.MaHD == TabHoaDon.SelectedTab.Name).ToList().All(x => x.IdChiTietSp != wdg.
                                    IdSPCTSP))
                                {
                                    var x = new ChiTietHDView();
                                    x.IdChiTietSp = wdg.IdSPCTSP;
                                    x.DonGia = decimal.Parse(wdg.Price.ToString());
                                    x.TenSP = wdg.TenSP1;
                                    x.IdHoaDon = _HoaDonServices.GetAll().FirstOrDefault(x => x.MaHD == TabHoaDon.SelectedTab.Name).Id;
                                    x.SoLuong = 1;
                                    _IChiTietHDServices.Add(x);
                                }
                                else
                                {
                                    var hdct = _IChiTietHDServices.GetAll().FirstOrDefault(x => x.IdChiTietSp == wdg.IdSPCTSP && x.IdHoaDon == _HoaDonServices.GetAll().FirstOrDefault(c => c.MaHD == TabHoaDon.SelectedTab.Name).Id);
                                    var spct = _IChiTietSpServices.GetAll().Find(x => x.Id == hdct.IdChiTietSp);
                                    if (hdct.SoLuong < spct.SoLuongTon)
                                    {
                                        hdct.SoLuong += 1;
                                        _IChiTietHDServices.Update(hdct);
                                    }
                                    else
                                    {
                                        this.Alert("Hiện tại không còn mặt hàng này", Form_Alert.enmType.Warning);
                                    }
                                }
                                LoadView(TabHoaDon.SelectedTab.Name);
                                LoadGia();
                                LoadTienThua();
                            }
                            else
                            {
                                this.Alert("Vui lòng tạo hóa đơn", Form_Alert.enmType.Warning);
                            }
                            txtSearch.Texts = "";
                        };
                    }
                    else
                    {
                        var spct = _IChiTietSpServices.GetById(ListAnh[i].IdChiTietSp.GetValueOrDefault());
                        spct.TrangThai = 1;
                        _IChiTietSpServices.Update(spct);
                    }

                }
                pnlBodysearch.Height = btnThemSP.Height + txtSearch.Height + flpSP.Height;
                pnlKhongTimThay.Visible = false;
                btnThemSP.Visible = true;
                flpSP.Visible = true;
                AnSearch();

            }
            else
            {
                pnlBodysearch.Height = pnlKhongTimThay.Height + btnThemSP.Height + txtSearch.Height;
                btnThemSP.Visible = true;
                flpSP.Visible = false;
                pnlKhongTimThay.Visible = true;
            }
                AnSearch();
        }

        private void txtSearch__TextChanged(object sender, EventArgs e)
        {
            LoadItemSearch(txtSearch.Texts);
        }
        public static string RemoveUnicode(string text)
        {
            string[] arr1 = new string[] { "á", "à", "ả", "ã", "ạ", "â", "ấ", "ầ", "ẩ", "ẫ", "ậ", "ă", "ắ", "ằ", "ẳ", "ẵ", "ặ",
    "đ",
    "é","è","ẻ","ẽ","ẹ","ê","ế","ề","ể","ễ","ệ",
    "í","ì","ỉ","ĩ","ị",
    "ó","ò","ỏ","õ","ọ","ô","ố","ồ","ổ","ỗ","ộ","ơ","ớ","ờ","ở","ỡ","ợ",
    "ú","ù","ủ","ũ","ụ","ư","ứ","ừ","ử","ữ","ự",
    "ý","ỳ","ỷ","ỹ","ỵ",};
            string[] arr2 = new string[] { "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a",
    "d",
    "e","e","e","e","e","e","e","e","e","e","e",
    "i","i","i","i","i",
    "o","o","o","o","o","o","o","o","o","o","o","o","o","o","o","o","o",
    "u","u","u","u","u","u","u","u","u","u","u",
    "y","y","y","y","y",};
            for (int i = 0; i < arr1.Length; i++)
            {
                text = text.Replace(arr1[i], arr2[i]);
                text = text.Replace(arr1[i].ToUpper(), arr2[i].ToUpper());
            }
            return text;
        }

        private void btnCloseKH_Click(object sender, EventArgs e)
        {
            txtsearchKH.PlaceholderText = "";
            txtsearchKH.Texts = "";
        }
    }
}
