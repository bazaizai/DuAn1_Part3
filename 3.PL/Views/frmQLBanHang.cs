using _1.DAL.DomainClass;
using _2.BUS.IServices;
using _2.BUS.Services;
using _2.BUS.ViewModels;
using _3.PL.Components;
using _3.PL.CustomControlls;
using _3.PL.Utilities;
using CustomAlertBoxDemo;
using CustomControls.RJControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net.WebSockets;
using System.Text.RegularExpressions;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;

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
        INhanVienServices _iNhanVienServices;
        IUuDaiTichDiemServices _IUuDaiTichDiemServices;
        ICtTichDiemServices _ICtTichDiemServices;
        ILichSuTichDiemServices _ILichSuTichDiemServices;
        ITichDiemServices _ITichDiemServices;
        IChiTietSaleServices _IChiTietSaleServices;
        IKieuSpServices _IKieuSpServices;
        IChiTietKieuSpService _IChiTietKieuSpService;
        ISaleServices _ISaleServices;
        IKichCoServices _IKichCoServices;
        TabPage tabPage;
        int doifrom = 0;
        public string GetSdt { get; set; }
        public frmQLBanHang()
        {
            InitializeComponent();
            _IChiTietSaleServices = new ChiTietSaleServices();
            _ISaleServices = new SaleServices();
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
            _iNhanVienServices = new NhanVienServices();
            _IUuDaiTichDiemServices = new UuDaiTichDiemServices();
            _ICtTichDiemServices = new CtTichDiemServices();
            _ILichSuTichDiemServices = new LichSuTichDiemServices();
            _ITichDiemServices = new TichDiemServices();
            _IKichCoServices = new KichCoServices();
            _IKieuSpServices = new KieuSpServices();
            _IChiTietKieuSpService = new ChiTietKieuSpServices();
            pnlfill.Height = this.Height - pnlbutton.Height;
            rdoTaiQuay.Checked = true;
            CbbGiamGia.SelectedIndex = 0;
            pnlKhachHang.Visible = false;
            TabHoaDon.Dock = DockStyle.Fill;
            //System.Windows.Documents.ListItem.Controls.Clear();
            ListItem.Controls.Clear();
            AnSearch();
            // FakeData();
            LoadItem();
            LoadData();
            LoadGia();
            if (TabHoaDon.SelectedTab != null)
            {
                txtMaHD1.Text = TabHoaDon.SelectedTab.Name;
                dtgNgayTao.Value = Convert.ToDateTime(_HoaDonServices.GetAll().Find(x => x.MaHD == TabHoaDon.SelectedTab.Name).NgayTao);
            }
            foreach (DataGridViewColumn column in dgview.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
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
            var lst = _HoaDonServices.GetAll().Where(c => c.TrangThai == 0 && c.TrangThaiGiaoHang == 0).OrderBy(c => c.MaHD);
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
                        dgview.Rows.Add(x.IdChiTietSp, stt++, x.TenSP + "-" + _ISizeServices.GetAll().Find(y => y.Id == _IChiTietSpServices.GetById(x.IdChiTietSp.GetValueOrDefault()).IdSize).Size, "+", x.SoLuong, "-",
                    double.Parse(x.DonGia.ToString()).ToString("#,###", CultureInfo.GetCultureInfo("vi-VN").NumberFormat) + "đ",
                    double.Parse((x.SoLuong * x.DonGia).ToString()).ToString("#,###", CultureInfo.GetCultureInfo("vi-VN").NumberFormat) + "đ", "X");
                        tongtien += Convert.ToDecimal(Convert.ToDecimal(x.SoLuong) * x.DonGia);
                    }
                    txtTongTien2.Text = double.Parse(tongtien.ToString()).ToString("#,###", CultureInfo.GetCultureInfo("vi-VN").NumberFormat) + "đ";
                    txtMaNhanVien.Texts = y.MaNv;
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
            cbbPtThanhToan.Items.Clear();
            foreach (var item in _IPtthanhToanServices.GetAll())
            {
                cbbPtThanhToan.Items.Add(item.Ten);
            }
        }

        private void btnAddTab_Click(object sender, EventArgs e)
        {
            tabPage = new TabPage(MaTT());
            txtMaHD1.Text = tabPage.Name = MaTT();
            TabHoaDon.TabPages.Add(tabPage);
            dgview.Parent = tabPage;
            LoadView(TabHoaDon.SelectedTab.Name);
            dgview.Visible = true;
            dgview.Dock = DockStyle.Fill;
            var x = new HoaDonViews()
            {
                MoTa = "(" + DateTime.Now.ToString() + "-" + (_iNhanVienServices.GetAll().Where(p => p.TaiKhoan == Properties.Settings.Default.TKdaLogin).Select(p => p.Ma).FirstOrDefault()) + "-" + "Tạo hóa đơn" + ")",
                Id = Guid.NewGuid(),
                MaHD = MaTT(),
                IdNv = _iNhanVienServices.GetAll().Where(p => p.TaiKhoan == Properties.Settings.Default.TKdaLogin).Select(p => p.Id).FirstOrDefault(),
                NgayTao = DateTime.Now,
                TrangThai = 0,
            };
            _HoaDonServices.Add(x);
            TabHoaDon.SelectedTab = tabPage;
            txtMaNhanVien.Texts = _HoaDonServices.GetAll().Find(x => x.MaHD == TabHoaDon.SelectedTab.Name).MaNv;
            this.Alert("Tạo mới thành công hóa đơn " + TabHoaDon.SelectedTab.Name, Form_Alert.enmType.Success);

        }
        private void LoadAll()
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
            CbbGiamGia.SelectedIndex = 0;
            pnlKhachHang.Visible = false;
        }


        private void LoadItem()
        {
            LoadALL();
            ListItem.Controls.Clear();
            List<Hats> Hats = new List<Hats>();
            List<AnhViews> ListAnh = _IanhServices.GetAll().Where(x => x.TrangThaiSP == 0 && x.TenAnh == "Anh").OrderBy(x => x.MaQr).ToList();
            Hats[] Hat = new Hats[ListAnh.Count];
            for (int i = 0; i < ListAnh.Count; i++)
            {
                if (ListAnh[i].SoLuongTon > 0)
                {
                    Hat[i] = new Hats();
                    Hat[i].TenSP1 = _ISanPhamServices.GetAll().Find(sp => sp.Id == ListAnh[i].IdSp).Ten + "-" + _IKichCoServices.GetAll().Find(x => x.Id == ListAnh[i].IdKichCo).Size;
                    Hat[i].Icon = Image.FromStream(new MemoryStream((byte[])ListAnh[i].DuongDan));
                    Hat[i].Price = Convert.ToDouble(ListAnh[i].GiaBan);
                    Hat[i].SoluongSP1 = ListAnh[i].SoLuongTon.ToString();
                    Hat[i].IdSPCTSP = ListAnh[i].IdChiTietSp.GetValueOrDefault();
                    Hat[i].MaSP = ListAnh[i].MaQr;
                    Hat[i].label1.Visible = false;
                    Hat[i].LoaiKM = "";
                    var CtSale = _IChiTietSaleServices.GetAll().Find(y => y.IdChiTietSp == ListAnh[i].IdChiTietSp && y.TrangThai == 0);
                    if (CtSale != null)
                    {
                        Hat[i].label1.Visible = true;
                        var Sale = _ISaleServices.GetAll().Find(z => z.Id == CtSale.IdSale);
                        if (Sale.LoaiHinhKm == "%")
                        {
                            Hat[i].GiaDaGiam = Convert.ToDouble(ListAnh[i].GiaBan * (100 - Sale.MucGiam) / 100);
                        }
                        else
                        {
                            Hat[i].GiaDaGiam = Convert.ToDouble(ListAnh[i].GiaBan - Sale.MucGiam);
                        }
                        Hat[i].label1.Text = "Giá: " + double.Parse(Convert.ToDouble(ListAnh[i].GiaBan).ToString()).ToString("#,###", CultureInfo.GetCultureInfo("vi-VN").NumberFormat) + "đ";
                        Hat[i].LoaiKM = "Sale: " + Sale.MucGiam + Sale.LoaiHinhKm;
                    }

                    ListItem.Controls.Add(Hat[i]);
                    Hat[i].OnclickAnh += (ss, ee) =>
                    {
                        var isp = (Hats)ss;
                        var ObjSP = _IChiTietSpServices.GetById(isp.IdSPCTSP);
                        FrmThongTinSP sp = new FrmThongTinSP();
                        sp.TenSP = isp.TenSP1;
                        sp.Team = _ITeamServices.GetAll().Find(x => x.Id == ObjSP.IdTeam).Ten;
                        sp.ChatLieu = _IChatLieuServices.GetAll().Find(x => x.Id == ObjSP.IdChatLieu).Ten;
                        sp.MauSac = _IMauSacServices.GetAll().Find(x => x.Id == ObjSP.IdMauSac).Ten;
                        sp.SizeSp = _ISizeServices.GetAll().Find(x => x.Id == ObjSP.IdSize).Size;
                        var ctksp = _IChiTietKieuSpService.GetAll().Find(x => x.IdChiTietSp == ObjSP.Id);
                        if (ctksp != null)
                        {
                            sp.NhomHang = TenKsp(ctksp.IdKieuSp.GetValueOrDefault(), ctksp.TenKieuSP).Substring(0, TenKsp(ctksp.IdKieuSp.GetValueOrDefault(), ctksp.TenKieuSP).Length - 2);
                        }
                        var QR = _IanhServices.GetAll().Find(x => x.IdChiTietSp == ObjSP.Id && x.TenAnh == "Barcode");
                        sp.AnhMQr = Image.FromStream(new MemoryStream((byte[])QR.DuongDan));
                        var Anh = _IanhServices.GetAll().Find(x => x.IdChiTietSp == ObjSP.Id && x.TenAnh == "Anh");
                        sp.AnhSP1 = Image.FromStream(new MemoryStream((byte[])Anh.DuongDan));
                        sp.ShowDialog();
                    };
                    Hat[i].Onselect += (ss, ee) =>
                    {
                        var wdg = (Hats)ss;
                        if (TabHoaDon.SelectedTab != null)
                        {
                            var spct = _IChiTietSpServices.GetById(wdg.IdSPCTSP);
                            if (_IChiTietHDServices.GetAll().Where(x => x.MaHD == TabHoaDon.SelectedTab.Name).ToList().All(x => x.IdChiTietSp != wdg.
                                IdSPCTSP))
                            {
                                var x = new ChiTietHDView();
                                x.IdChiTietSp = wdg.IdSPCTSP;
                                if (CtSale != null)
                                {
                                    var Sale = _ISaleServices.GetAll().Find(z => z.Id == CtSale.IdSale);
                                    if (Sale.LoaiHinhKm == "%")
                                    {
                                        x.DonGia = decimal.Parse((wdg.Price * Convert.ToDouble((100 - Sale.MucGiam) / 100)).ToString()); ;
                                    }
                                    else
                                    {
                                        x.DonGia = decimal.Parse((wdg.Price - Convert.ToDouble(Sale.MucGiam)).ToString()); ;
                                    }
                                }
                                else
                                {
                                    x.DonGia = decimal.Parse(wdg.Price.ToString());
                                }
                                x.TenSP = wdg.TenSP1;
                                x.IdHoaDon = _HoaDonServices.GetAll().FirstOrDefault(x => x.MaHD == TabHoaDon.SelectedTab.Name).Id;
                                x.SoLuong = 1;
                                _IChiTietHDServices.Add(x);
                                spct.SoLuongTon = spct.SoLuongTon - 1;
                                _IChiTietSpServices.Update(spct);
                            }
                            else
                            {
                                var hdct = _IChiTietHDServices.GetAll().FirstOrDefault(x => x.IdChiTietSp == wdg.IdSPCTSP && x.IdHoaDon == _HoaDonServices.GetAll().FirstOrDefault(c => c.MaHD == TabHoaDon.SelectedTab.Name).Id);
                                if (spct.SoLuongTon > 0)
                                {
                                    hdct.SoLuong += 1;
                                    _IChiTietHDServices.Update(hdct);
                                    spct.SoLuongTon -= 1;
                                    _IChiTietSpServices.Update(spct);
                                }
                                else
                                {
                                    this.Alert("Hiện tại không còn mặt hàng này", Form_Alert.enmType.Warning);
                                }
                            }
                            LoadView(TabHoaDon.SelectedTab.Name);
                            LoadGia();
                            LoadItem();
                            LoadTienThua();
                        }
                        else
                        {
                            tabPage = new TabPage(MaTT());
                            txtMaHD1.Text = tabPage.Name = MaTT();
                            TabHoaDon.TabPages.Add(tabPage);
                            dgview.Parent = tabPage;
                            LoadView(TabHoaDon.SelectedTab.Name);
                            dgview.Visible = true;
                            dgview.Dock = DockStyle.Fill;
                            var x = new HoaDonViews()
                            {
                                MoTa = "(" + DateTime.Now.ToString() + "-" + (_iNhanVienServices.GetAll().Where(p => p.TaiKhoan == Properties.Settings.Default.TKdaLogin).Select(p => p.Ma).FirstOrDefault()) + "-" + "Tạo hóa đơn" + ")",
                                Id = Guid.NewGuid(),
                                MaHD = MaTT(),
                                NgayTao = DateTime.Now,
                                TrangThai = 0,
                                IdNv = _iNhanVienServices.GetAll().Where(p => p.TaiKhoan == Properties.Settings.Default.TKdaLogin).Select(p => p.Id).FirstOrDefault(),
                            };
                            _HoaDonServices.Add(x);
                            TabHoaDon.SelectedTab = tabPage;
                            this.Alert("Tạo mới thành công hóa đơn " + TabHoaDon.SelectedTab.Name, Form_Alert.enmType.Success);
                            var spct = _IChiTietSpServices.GetById(wdg.IdSPCTSP);
                            if (_IChiTietHDServices.GetAll().Where(x => x.MaHD == TabHoaDon.SelectedTab.Name).ToList().All(x => x.IdChiTietSp != wdg.
                                IdSPCTSP))
                            {
                                var cthd = new ChiTietHDView();
                                cthd.IdChiTietSp = wdg.IdSPCTSP;
                                cthd.DonGia = decimal.Parse(wdg.Price.ToString());
                                if (CtSale != null)
                                {
                                    var Sale = _ISaleServices.GetAll().Find(z => z.Id == CtSale.IdSale);
                                    if (Sale.LoaiHinhKm == "%")
                                    {
                                        cthd.DonGia = decimal.Parse((wdg.Price * Convert.ToDouble((100 - Sale.MucGiam) / 100)).ToString()); ;
                                    }
                                    else
                                    {
                                        cthd.DonGia = decimal.Parse((wdg.Price - Convert.ToDouble(Sale.MucGiam)).ToString()); ;
                                    }
                                }
                                else
                                {
                                    cthd.DonGia = decimal.Parse(wdg.Price.ToString());
                                }
                                cthd.TenSP = wdg.TenSP1;
                                cthd.IdHoaDon = _HoaDonServices.GetAll().FirstOrDefault(cthd => cthd.MaHD == TabHoaDon.SelectedTab.Name).Id;
                                cthd.SoLuong = 1;
                                _IChiTietHDServices.Add(cthd);
                                spct.SoLuongTon = spct.SoLuongTon - 1;
                                _IChiTietSpServices.Update(spct);
                            }
                            else
                            {
                                var hdct = _IChiTietHDServices.GetAll().FirstOrDefault(x => x.IdChiTietSp == wdg.IdSPCTSP && x.IdHoaDon == _HoaDonServices.GetAll().FirstOrDefault(c => c.MaHD == TabHoaDon.SelectedTab.Name).Id);
                                if (spct.SoLuongTon > 0)
                                {
                                    hdct.SoLuong += 1;
                                    _IChiTietHDServices.Update(hdct);
                                    spct.SoLuongTon -= 1;
                                    _IChiTietSpServices.Update(spct);
                                }
                                else
                                {
                                    this.Alert("Hiện tại không còn mặt hàng này", Form_Alert.enmType.Warning);
                                }
                            }
                            LoadView(TabHoaDon.SelectedTab.Name);
                            LoadGia();
                            LoadItem();
                            LoadTienThua();
                        }
                    };

                }
                else
                {
                    Hat[i] = new Hats();
                    Hat[i].TenSP1 = _ISanPhamServices.GetAll().Find(sp => sp.Id == ListAnh[i].IdSp).Ten + "-" + _IKichCoServices.GetAll().Find(x => x.Id == ListAnh[i].IdKichCo).Size;
                    Hat[i].Icon = Image.FromStream(new MemoryStream((byte[])ListAnh[i].DuongDan));
                    Hat[i].Price = Convert.ToDouble(ListAnh[i].GiaBan);
                    Hat[i].SoluongSP1 = ListAnh[i].SoLuongTon.ToString();
                    Hat[i].IdSPCTSP = ListAnh[i].IdChiTietSp.GetValueOrDefault();
                    Hat[i].MaSP = ListAnh[i].MaQr;
                    Hat[i].label1.Visible = false;
                    Hat[i].LoaiKM = "";
                    var CtSale = _IChiTietSaleServices.GetAll().Find(y => y.IdChiTietSp == ListAnh[i].IdChiTietSp && y.TrangThai == 0);
                    if (CtSale != null)
                    {
                        Hat[i].label1.Visible = true;
                        var Sale = _ISaleServices.GetAll().Find(z => z.Id == CtSale.IdSale);
                        if (Sale.LoaiHinhKm == "%")
                        {
                            Hat[i].GiaDaGiam = Convert.ToDouble(ListAnh[i].GiaBan * (100 - Sale.MucGiam) / 100);
                        }
                        else
                        {
                            Hat[i].GiaDaGiam = Convert.ToDouble(ListAnh[i].GiaBan - Sale.MucGiam);
                        }
                        Hat[i].label1.Text = "Giá: " + double.Parse(Convert.ToDouble(ListAnh[i].GiaBan).ToString()).ToString("#,###", CultureInfo.GetCultureInfo("vi-VN").NumberFormat) + "đ";
                        Hat[i].LoaiKM = "Sale: " + Sale.MucGiam + Sale.LoaiHinhKm;
                    }
                    ListItem.Controls.Add(Hat[i]);
                    Hat[i].OnclickAnh += (ss, ee) =>
                    {
                        var isp = (Hats)ss;
                        var ObjSP = _IChiTietSpServices.GetById(isp.IdSPCTSP);
                        FrmThongTinSP sp = new FrmThongTinSP();
                        sp.TenSP = isp.TenSP1;
                        sp.Team = _ITeamServices.GetAll().Find(x => x.Id == ObjSP.IdTeam).Ten;
                        sp.ChatLieu = _IChatLieuServices.GetAll().Find(x => x.Id == ObjSP.IdChatLieu).Ten;
                        sp.SizeSp = _ISizeServices.GetAll().Find(x => x.Id == ObjSP.IdSize).Size;
                        sp.MauSac = _IMauSacServices.GetAll().Find(x => x.Id == ObjSP.IdMauSac).Ten;
                        var ctksp = _IChiTietKieuSpService.GetAll().Find(x => x.IdChiTietSp == ObjSP.Id);
                        if (ctksp != null)
                        {
                            sp.NhomHang = TenKsp(ctksp.IdKieuSp.GetValueOrDefault(), ctksp.TenKieuSP).Substring(0, TenKsp(ctksp.IdKieuSp.GetValueOrDefault(), ctksp.TenKieuSP).Length - 2);
                        }
                        var QR = _IanhServices.GetAll().Find(x => x.IdChiTietSp == ObjSP.Id && x.TenAnh == "Barcode");
                        sp.AnhMQr = Image.FromStream(new MemoryStream((byte[])QR.DuongDan));
                        var Anh = _IanhServices.GetAll().Find(x => x.IdChiTietSp == ObjSP.Id && x.TenAnh == "Anh");
                        sp.AnhSP1 = Image.FromStream(new MemoryStream((byte[])Anh.DuongDan));
                        sp.ShowDialog();
                    };
                    Hat[i].Onselect += (ss, ee) =>
                    {
                        if (TabHoaDon.SelectedTab != null)

                        {
                            this.Alert("Hiện tại không còn mặt hàng này", Form_Alert.enmType.Warning);
                        }
                        else
                        {

                            this.Alert("Hiện tại không còn mặt hàng này", Form_Alert.enmType.Warning);
                        }
                    };
                }

            }
        }
        private string TenKsp(Guid Id, string sp)
        {
            if (Id == null)
            {
                return sp;
            }
            else
            {
                var temp = _IKieuSpServices.GetAll().FirstOrDefault(c => c.Id == Id);
                sp = temp.Ten + ">>" + sp;
                if (temp.IdCha == null)
                {
                    return sp;
                }
                else { return TenKsp(Guid.Parse(temp.IdCha.ToString()), sp); }
            }
        }

        private void LoadView(string HD)
        {
            int stt = 1;
            dgview.Rows.Clear();
            foreach (var x in _IChiTietHDServices.GetAll().Where(x => x.MaHD == HD).ToList())
            {
                dgview.Rows.Add(x.IdChiTietSp, stt++, x.TenSP + "-" + _ISizeServices.GetAll().Find(y => y.Id == _IChiTietSpServices.GetById(x.IdChiTietSp.GetValueOrDefault()).IdSize).Size, "+", x.SoLuong, "-",
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
                if (txtGiamGia.Texts == "")
                {
                    txtGiamGia.Texts = 0.ToString();
                }
                pnlKhachHang.Visible = true;
                lblTen.Text = "KH: " + GetKH(txtsearchKH.Texts).Ten;
                lblSoDT.Text = "SĐt: " + GetKH(txtsearchKH.Texts).Sdt;
                lblDiaChi.Text = "Địa chỉ: " + GetKH(txtsearchKH.Texts).DiaChi;
                lblMucTichLuy.Text = "Điểm tích lũy: " + GetKH(txtsearchKH.Texts).SoDiem;
                lblUuDaiTichLuy.Text = GetUuDai() == null ? "Hiện không có ưu đãi nào" : "Mức ưu đãi Là: " + GetUuDai().MucUuDai + GetUuDai().LoaiHinhKm;
                txtMucUuDai1.Text = GetUuDai() == null ? "0" : GetUuDai().MucUuDai + GetUuDai().LoaiHinhKm;
            }
            else if (GetKH(txtsearchKH.Texts) == null)
            {
                pnlKhachHang.Visible = false;
            }
            LoadGia();
            LoadTienThua();
        }

        private UuDaiTichDiemView GetUuDai()
        {
            if (pnlKhachHang.Visible == true)
            {
                var Obj = _IUuDaiTichDiemServices.GetAll().Where(x => x.TrangThai == 1).ToList();
                if (Obj.Count < 1)
                {
                    return null;
                }
                else
                {
                    int d = 0;
                    foreach (var x in Obj)
                    {
                        if (GetKH(txtsearchKH.Texts).SoDiem >= x.SoDiem && d <= x.SoDiem)
                        {
                            d = Convert.ToInt32(x.SoDiem);
                        }
                    }
                    if (d == 0)
                    {
                        return null;
                    }
                    else
                    {
                        return _IUuDaiTichDiemServices.GetAll().Find(x => x.SoDiem == d);
                    }
                }
            }
            else
                return null;
        }


        private ChiTietHDView GetHDct(Guid ID) => _IChiTietHDServices.GetAll().Find(x => x.IdChiTietSp == ID && x.MaHD == TabHoaDon.SelectedTab.Name);
        private ChiTietHDView GetHDct(Guid ID, string MaHD) => _IChiTietHDServices.GetAll().Find(x => x.IdChiTietSp == ID && x.MaHD == MaHD);

        private string Cell(int x) => dgview.CurrentRow.Cells[x].Value.ToString();
        private void dgview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            var ctsp = _IChiTietSpServices.GetById(Guid.Parse(Cell(0)));
            if (dgview.Columns[e.ColumnIndex].Name == "TangSP")
            {
                var hdct = GetHDct(Guid.Parse(Cell(0)));
                if (_IChiTietSpServices.GetById(Guid.Parse(Cell(0))).SoLuongTon > 0)
                {
                    hdct.SoLuong += 1;
                    _IChiTietHDServices.Update(hdct);
                    ctsp.SoLuongTon -= 1;
                    _IChiTietSpServices.Update(ctsp);
                }
                else
                {

                    this.Alert("Hết hàng", Form_Alert.enmType.Warning);
                }
                LoadGia();
                LoadItem();
                LoadView(TabHoaDon.SelectedTab.Name);
            }
            if (dgview.Columns[e.ColumnIndex].Name == "GiamSP")
            {
                var hdct = GetHDct(Guid.Parse(Cell(0)));
                if (hdct.SoLuong > 1)
                {
                    hdct.SoLuong -= 1;
                    _IChiTietHDServices.Update(hdct);
                    ctsp.SoLuongTon += 1;
                    ctsp.TrangThai = 0;
                    _IChiTietSpServices.Update(ctsp);
                }
                LoadGia();
                LoadItem();
                LoadView(TabHoaDon.SelectedTab.Name);
            }
            if (dgview.Columns[e.ColumnIndex].Name == "XoaSP")
            {
                var hdct = GetHDct(Guid.Parse(Cell(0)));
                ctsp.SoLuongTon += hdct.SoLuong;
                _IChiTietSpServices.Update(ctsp);
                _IChiTietHDServices.Delete(hdct);
                LoadItem();
                LoadView(TabHoaDon.SelectedTab.Name);
                LoadGia();
            }
            LoadALL();
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
                pnlKhachHang.Visible = true;
                lblTen.Text = "KH: " + GetKH(txtsearchKH.Texts).Ten;
                lblSoDT.Text = "SĐt: " + GetKH(txtsearchKH.Texts).Sdt;
                lblDiaChi.Text = "Địa chỉ: " + GetKH(txtsearchKH.Texts).DiaChi;
                lblMucTichLuy.Text = "Điểm tích lũy: " + GetKH(txtsearchKH.Texts).SoDiem;
                lblUuDaiTichLuy.Text = GetUuDai() == null ? "Hiện không có ưu đãi nào" : "Mức ưu đãi Là: " + GetUuDai().MucUuDai + GetUuDai().LoaiHinhKm;
                txtMucUuDai1.Text = GetUuDai() == null ? "0" : GetUuDai().MucUuDai + GetUuDai().LoaiHinhKm;
            }
            else if (GetKH(txtsearchKH.Texts) == null)
            {

            }
        }

        private void TabHoaDon_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtTienThua1.Text = "";
            txthtThanhToan.Texts = "";
            txtsearchKH.Texts = "";
            if (TabHoaDon.SelectedTab != null)
            {
                txtMaNhanVien.Texts = _HoaDonServices.GetAll().Find(x => x.MaHD == TabHoaDon.SelectedTab.Name).MaNv;
            }
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
                    dgview.Rows.Add(x.IdChiTietSp, stt++, x.TenSP + "-" + _ISizeServices.GetAll().Find(y => y.Id == _IChiTietSpServices.GetById(x.IdChiTietSp.GetValueOrDefault()).IdSize).Size, "+", x.SoLuong, "-",
                       double.Parse(x.DonGia.ToString()).ToString("#,###", CultureInfo.GetCultureInfo("vi-VN").NumberFormat) + "đ",
                       double.Parse((x.SoLuong * x.DonGia).ToString()).ToString("#,###", CultureInfo.GetCultureInfo("vi-VN").NumberFormat) + "đ", "X");
                    tongtien += Convert.ToDecimal(Convert.ToDecimal(x.SoLuong) * x.DonGia);
                }
                txtTongTien2.Text = double.Parse(tongtien.ToString()).ToString("#,###", CultureInfo.GetCultureInfo("vi-VN").NumberFormat) + "đ";
                txtMaHD1.Text = TabHoaDon.SelectedTab.Name;
                if (GetKH(txtsearchKH.Texts) == null)
                {
                    if (CbbGiamGia.SelectedIndex == 0)
                    {
                        if (txtGiamGia.Texts.Trim() != "")
                        {
                            if (Convert.ToDecimal(txtGiamGia.Texts) >= 100)
                            {
                                txtGiamGia.Texts = 100.ToString();
                                txtTongTienPTra1.Text = 0.ToString();
                            }
                            else
                            {
                                txtTongTienPTra1.Text = double.Parse((tongtien * (100 - decimal.Parse(txtGiamGia.Texts)) / 100).ToString()).ToString("#,###", CultureInfo.GetCultureInfo("vi-VN").NumberFormat) + "đ";
                            }
                        }
                        else
                        {
                            txtTongTienPTra1.Text = txtTongTien2.Text;
                        }
                    }
                    else
                    {
                        if (txtGiamGia.Texts.Trim() != "")
                        {
                            if (Convert.ToDecimal(txtGiamGia.Texts) >= tongtien)
                            {
                                txtTongTienPTra1.Text = 0.ToString();
                            }
                            else
                            {
                                txtTongTienPTra1.Text = double.Parse((tongtien - Convert.ToDecimal(txtGiamGia.Texts)).ToString()).ToString("#,###", CultureInfo.GetCultureInfo("vi-VN").NumberFormat) + "đ";
                            }
                        }
                        else
                        {
                            txtTongTienPTra1.Text = txtTongTien2.Text;
                        }
                    }
                    if (cbbPtThanhToan.Texts == "Cả tiền mặt và chuyển khoản")
                    {
                        if (_IChiTietHDServices.GetAll().Where(x => x.MaHD == TabHoaDon.SelectedTab.Name).ToList().Count > 0 && txthtThanhToan.Texts.Trim() != "" && txtTongTienPTra1.Text != "")
                        {
                            if (txtChuyenKhoan.Texts.Trim() != "" && txthtThanhToan.Texts.Trim() != "")
                            {
                                if ((Convert.ToDecimal(txthtThanhToan.Texts) + decimal.Parse(txtChuyenKhoan.Texts)) == ValidateInput.RegexDecimal(txtTongTienPTra1.Text))
                                {
                                    txtTienThua1.Text = 0 + "đ";
                                }
                                else
                                {
                                    if ((Convert.ToDecimal(txthtThanhToan.Texts) + decimal.Parse(txtChuyenKhoan.Texts) - ValidateInput.RegexDecimal(txtTongTienPTra1.Text)) > 0)
                                    {
                                        txtTienThua1.Text = double.Parse((Convert.ToDecimal(txthtThanhToan.Texts) + decimal.Parse(txtChuyenKhoan.Texts) - ValidateInput.RegexDecimal(txtTongTienPTra1.Text)).ToString()).ToString("#,###", CultureInfo.GetCultureInfo("vi-VN").NumberFormat) + "đ";
                                    }
                                    else
                                    {
                                        txtTienThua1.Text = "";
                                    }

                                }
                            }
                        }
                        if (txthtThanhToan.Texts == "")
                        {
                            txtTienThua1.Text = "";
                        }
                    }
                    else
                    {
                        if (_IChiTietHDServices.GetAll().Where(x => x.MaHD == TabHoaDon.SelectedTab.Name).ToList().Count > 0 && txthtThanhToan.Texts.Trim() != "" && txtTongTienPTra1.Text != "")
                        {
                            if (Convert.ToDecimal(txthtThanhToan.Texts) == ValidateInput.RegexDecimal(txtTongTienPTra1.Text))
                            {
                                txtTienThua1.Text = 0 + "đ";
                            }
                            else
                            {
                                if ((Convert.ToDecimal(txthtThanhToan.Texts) - ValidateInput.RegexDecimal(txtTongTienPTra1.Text)) > 0)
                                {
                                    txtTienThua1.Text = double.Parse((Convert.ToDecimal(txthtThanhToan.Texts) - ValidateInput.RegexDecimal(txtTongTienPTra1.Text)).ToString()).ToString("#,###", CultureInfo.GetCultureInfo("vi-VN").NumberFormat) + "đ";
                                }
                                else
                                {
                                    txtTienThua1.Text = "";
                                }

                            }
                        }
                        if (txthtThanhToan.Texts == "")
                        {
                            txtTienThua1.Text = "";
                        }
                    }
                }
                else
                {
                    if (GetUuDai() == null)
                    {
                        if (CbbGiamGia.SelectedIndex == 0)
                        {
                            if (txtGiamGia.Texts.Trim() != "")
                            {
                                if (Convert.ToDecimal(txtGiamGia.Texts) >= 100)
                                {
                                    txtGiamGia.Texts = 100.ToString();
                                    txtTongTienPTra1.Text = 0.ToString();
                                }
                                else
                                {
                                    txtTongTienPTra1.Text = double.Parse((tongtien * (100 - decimal.Parse(txtGiamGia.Texts)) / 100).ToString()).ToString("#,###", CultureInfo.GetCultureInfo("vi-VN").NumberFormat) + "đ";
                                }
                            }
                            else
                            {
                                txtTongTienPTra1.Text = txtTongTien2.Text;
                            }
                        }
                        else
                        {
                            if (txtGiamGia.Texts.Trim() != "")
                            {
                                if (Convert.ToDecimal(txtGiamGia.Texts) >= tongtien)
                                {
                                    txtTongTienPTra1.Text = 0.ToString();
                                }
                                else
                                {
                                    txtTongTienPTra1.Text = double.Parse((tongtien - Convert.ToDecimal(txtGiamGia.Texts)).ToString()).ToString("#,###", CultureInfo.GetCultureInfo("vi-VN").NumberFormat) + "đ";
                                }
                            }
                            else
                            {
                                txtTongTienPTra1.Text = txtTongTien2.Text;
                            }
                        }
                        if (cbbPtThanhToan.Texts == "Cả tiền mặt và chuyển khoản")
                        {
                            if (_IChiTietHDServices.GetAll().Where(x => x.MaHD == TabHoaDon.SelectedTab.Name).ToList().Count > 0 && txthtThanhToan.Texts.Trim() != "" && txtTongTienPTra1.Text != "")
                            {
                                if (txtChuyenKhoan.Texts.Trim() != "" && txthtThanhToan.Texts.Trim() != "")
                                {
                                    if ((Convert.ToDecimal(txthtThanhToan.Texts) + decimal.Parse(txtChuyenKhoan.Texts)) == ValidateInput.RegexDecimal(txtTongTienPTra1.Text))
                                    {
                                        txtTienThua1.Text = 0 + "đ";
                                    }
                                    else
                                    {
                                        if ((Convert.ToDecimal(txthtThanhToan.Texts) + decimal.Parse(txtChuyenKhoan.Texts) - ValidateInput.RegexDecimal(txtTongTienPTra1.Text)) > 0)
                                        {
                                            txtTienThua1.Text = double.Parse((Convert.ToDecimal(txthtThanhToan.Texts) + decimal.Parse(txtChuyenKhoan.Texts) - ValidateInput.RegexDecimal(txtTongTienPTra1.Text)).ToString()).ToString("#,###", CultureInfo.GetCultureInfo("vi-VN").NumberFormat) + "đ";
                                        }
                                        else
                                        {
                                            txtTienThua1.Text = "";
                                        }

                                    }
                                }
                            }
                            if (txthtThanhToan.Texts == "")
                            {
                                txtTienThua1.Text = "";
                            }
                        }
                        else
                        {
                            if (_IChiTietHDServices.GetAll().Where(x => x.MaHD == TabHoaDon.SelectedTab.Name).ToList().Count > 0 && txthtThanhToan.Texts.Trim() != "" && txtTongTienPTra1.Text != "")
                            {
                                if (Convert.ToDecimal(txthtThanhToan.Texts) == ValidateInput.RegexDecimal(txtTongTienPTra1.Text))
                                {
                                    txtTienThua1.Text = 0 + "đ";
                                }
                                else
                                {
                                    if ((Convert.ToDecimal(txthtThanhToan.Texts) - ValidateInput.RegexDecimal(txtTongTienPTra1.Text)) > 0)
                                    {
                                        txtTienThua1.Text = double.Parse((Convert.ToDecimal(txthtThanhToan.Texts) - ValidateInput.RegexDecimal(txtTongTienPTra1.Text)).ToString()).ToString("#,###", CultureInfo.GetCultureInfo("vi-VN").NumberFormat) + "đ";
                                    }
                                    else
                                    {
                                        txtTienThua1.Text = "";
                                    }

                                }
                            }
                            if (txthtThanhToan.Texts == "")
                            {
                                txtTienThua1.Text = "";
                            }
                        }
                    }
                    else
                    {
                        if (GetUuDai().LoaiHinhKm == "%")
                        {
                            if (CbbGiamGia.SelectedIndex == 0)
                            {
                                if (txtGiamGia.Texts.Trim() != "")
                                {
                                    if (Convert.ToDecimal(txtGiamGia.Texts) >= 100)
                                    {
                                        txtGiamGia.Texts = 100.ToString();
                                        txtTongTienPTra1.Text = 0.ToString();
                                    }
                                    else
                                    {
                                        txtTongTienPTra1.Text = double.Parse(((tongtien * (100 - decimal.Parse(txtGiamGia.Texts)) / 100) * (100 - GetUuDai().MucUuDai) / 100).ToString()).ToString("#,###", CultureInfo.GetCultureInfo("vi-VN").NumberFormat) + "đ";
                                    }
                                }
                                else
                                {
                                    txtTongTienPTra1.Text = double.Parse(((tongtien) * (100 - GetUuDai().MucUuDai) / 100).ToString()).ToString("#,###", CultureInfo.GetCultureInfo("vi-VN").NumberFormat) + "đ";
                                }
                            }
                            else
                            {
                                if (txtGiamGia.Texts.Trim() != "")
                                {
                                    if (Convert.ToDecimal(txtGiamGia.Texts) >= tongtien)
                                    {
                                        txtTongTienPTra1.Text = 0.ToString();
                                    }
                                    else
                                    {
                                        txtTongTienPTra1.Text = double.Parse(((tongtien - Convert.ToDecimal(txtGiamGia.Texts)) * (100 - GetUuDai().MucUuDai) / 100).ToString()).ToString("#,###", CultureInfo.GetCultureInfo("vi-VN").NumberFormat) + "đ";
                                    }
                                }
                                else
                                {
                                    txtTongTienPTra1.Text = double.Parse(((tongtien) * (100 - GetUuDai().MucUuDai) / 100).ToString()).ToString("#,###", CultureInfo.GetCultureInfo("vi-VN").NumberFormat) + "đ";
                                }
                            }
                            if (cbbPtThanhToan.Texts == "Cả tiền mặt và chuyển khoản")
                            {
                                if (_IChiTietHDServices.GetAll().Where(x => x.MaHD == TabHoaDon.SelectedTab.Name).ToList().Count > 0 && txthtThanhToan.Texts.Trim() != "" && txtTongTienPTra1.Text != "")
                                {
                                    if (txtChuyenKhoan.Texts.Trim() != "" && txthtThanhToan.Texts.Trim() != "")
                                    {
                                        if ((Convert.ToDecimal(txthtThanhToan.Texts) + decimal.Parse(txtChuyenKhoan.Texts)) == ValidateInput.RegexDecimal(txtTongTienPTra1.Text))
                                        {
                                            txtTienThua1.Text = 0 + "đ";
                                        }
                                        else
                                        {
                                            if ((Convert.ToDecimal(txthtThanhToan.Texts) + decimal.Parse(txtChuyenKhoan.Texts) - ValidateInput.RegexDecimal(txtTongTienPTra1.Text)) > 0)
                                            {
                                                txtTienThua1.Text = double.Parse((Convert.ToDecimal(txthtThanhToan.Texts) + decimal.Parse(txtChuyenKhoan.Texts) - ValidateInput.RegexDecimal(txtTongTienPTra1.Text)).ToString()).ToString("#,###", CultureInfo.GetCultureInfo("vi-VN").NumberFormat) + "đ";
                                            }
                                            else
                                            {
                                                txtTienThua1.Text = "";
                                            }

                                        }
                                    }
                                }
                                if (txthtThanhToan.Texts == "")
                                {
                                    txtTienThua1.Text = "";
                                }
                            }
                            else
                            {
                                if (_IChiTietHDServices.GetAll().Where(x => x.MaHD == TabHoaDon.SelectedTab.Name).ToList().Count > 0 && txthtThanhToan.Texts.Trim() != "" && txtTongTienPTra1.Text != "")
                                {
                                    if (Convert.ToDecimal(txthtThanhToan.Texts) == ValidateInput.RegexDecimal(txtTongTienPTra1.Text))
                                    {
                                        txtTienThua1.Text = 0 + "đ";
                                    }
                                    else
                                    {
                                        if ((Convert.ToDecimal(txthtThanhToan.Texts) - ValidateInput.RegexDecimal(txtTongTienPTra1.Text)) > 0)
                                        {
                                            txtTienThua1.Text = double.Parse((Convert.ToDecimal(txthtThanhToan.Texts) - ValidateInput.RegexDecimal(txtTongTienPTra1.Text)).ToString()).ToString("#,###", CultureInfo.GetCultureInfo("vi-VN").NumberFormat) + "đ";
                                        }
                                        else
                                        {
                                            txtTienThua1.Text = "";
                                        }

                                    }
                                }
                                if (txthtThanhToan.Texts == "")
                                {
                                    txtTienThua1.Text = "";
                                }
                            }
                        }
                        else
                        {
                            if (CbbGiamGia.SelectedIndex == 0)
                            {
                                if (txtGiamGia.Texts.Trim() != "")
                                {
                                    if (Convert.ToDecimal(txtGiamGia.Texts) >= 100)
                                    {
                                        txtGiamGia.Texts = 100.ToString();
                                        txtTongTienPTra1.Text = 0.ToString();
                                    }
                                    else
                                    {
                                        txtTongTienPTra1.Text = double.Parse((tongtien * (100 - decimal.Parse(txtGiamGia.Texts)) / 100 - GetUuDai().MucUuDai).ToString()).ToString("#,###", CultureInfo.GetCultureInfo("vi-VN").NumberFormat) + "đ";
                                    }
                                }
                                else
                                {
                                    txtTongTienPTra1.Text = double.Parse((tongtien - GetUuDai().MucUuDai).ToString()).ToString("#,###", CultureInfo.GetCultureInfo("vi-VN").NumberFormat) + "đ";
                                }
                            }
                            else
                            {
                                if (txtGiamGia.Texts.Trim() != "")
                                {
                                    if (Convert.ToDecimal(txtGiamGia.Texts) >= tongtien)
                                    {
                                        txtTongTienPTra1.Text = 0.ToString();
                                    }
                                    else
                                    {
                                        txtTongTienPTra1.Text = double.Parse(((tongtien - Convert.ToDecimal(txtGiamGia.Texts)) - GetUuDai().MucUuDai).ToString()).ToString("#,###", CultureInfo.GetCultureInfo("vi-VN").NumberFormat) + "đ";
                                    }
                                }
                                else
                                {
                                    txtTongTienPTra1.Text = double.Parse(((tongtien) - GetUuDai().MucUuDai).ToString()).ToString("#,###", CultureInfo.GetCultureInfo("vi-VN").NumberFormat) + "đ";
                                }
                            }
                            if (cbbPtThanhToan.Texts == "Cả tiền mặt và chuyển khoản")
                            {
                                if (_IChiTietHDServices.GetAll().Where(x => x.MaHD == TabHoaDon.SelectedTab.Name).ToList().Count > 0 && txthtThanhToan.Texts.Trim() != "" && txtTongTienPTra1.Text != "")
                                {
                                    if (txtChuyenKhoan.Texts.Trim() != "" && txthtThanhToan.Texts.Trim() != "")
                                    {
                                        if ((Convert.ToDecimal(txthtThanhToan.Texts) + decimal.Parse(txtChuyenKhoan.Texts)) == ValidateInput.RegexDecimal(txtTongTienPTra1.Text))
                                        {
                                            txtTienThua1.Text = 0 + "đ";
                                        }
                                        else
                                        {
                                            if ((Convert.ToDecimal(txthtThanhToan.Texts) + decimal.Parse(txtChuyenKhoan.Texts) - ValidateInput.RegexDecimal(txtTongTienPTra1.Text)) > 0)
                                            {
                                                txtTienThua1.Text = double.Parse((Convert.ToDecimal(txthtThanhToan.Texts) + decimal.Parse(txtChuyenKhoan.Texts) - ValidateInput.RegexDecimal(txtTongTienPTra1.Text)).ToString()).ToString("#,###", CultureInfo.GetCultureInfo("vi-VN").NumberFormat) + "đ";
                                            }
                                            else
                                            {
                                                txtTienThua1.Text = "";
                                            }

                                        }
                                    }
                                }
                                if (txthtThanhToan.Texts == "")
                                {
                                    txtTienThua1.Text = "";
                                }
                            }
                            else
                            {
                                if (_IChiTietHDServices.GetAll().Where(x => x.MaHD == TabHoaDon.SelectedTab.Name).ToList().Count > 0 && txthtThanhToan.Texts.Trim() != "" && txtTongTienPTra1.Text != "")
                                {
                                    if (Convert.ToDecimal(txthtThanhToan.Texts) == ValidateInput.RegexDecimal(txtTongTienPTra1.Text))
                                    {
                                        txtTienThua1.Text = 0 + "đ";
                                    }
                                    else
                                    {
                                        if ((Convert.ToDecimal(txthtThanhToan.Texts) - ValidateInput.RegexDecimal(txtTongTienPTra1.Text)) > 0)
                                        {
                                            txtTienThua1.Text = double.Parse((Convert.ToDecimal(txthtThanhToan.Texts) - ValidateInput.RegexDecimal(txtTongTienPTra1.Text)).ToString()).ToString("#,###", CultureInfo.GetCultureInfo("vi-VN").NumberFormat) + "đ";
                                        }
                                        else
                                        {
                                            txtTienThua1.Text = "";
                                        }

                                    }
                                }
                                if (txthtThanhToan.Texts == "")
                                {
                                    txtTienThua1.Text = "";
                                }
                            }
                        }
                    }
                }
            }
            if (TabHoaDon.SelectedTab == null || !_IChiTietHDServices.GetAll().Where(x => x.MaHD == TabHoaDon.SelectedTab.Name).ToList().Any())
            {
                txtTongTien2.Text = "";
                txtTongTienPTra1.Text = "";
            }
        }

        private void Clearform()
        {
            txthtThanhToan.Texts = "";
            txtGiamGia.Texts = 0.ToString();
            cbbPtThanhToan.SelectedIndex = -1;
            txtMaHD1.Text = "";
            txtTienThua1.Text = "";
            txtChuyenKhoan.Texts = "";
            txtTienThua1.Text = "";
            txtChuyenKhoan.Texts = "";
            txthtThanhToan.Texts = "";
            txtTenNguoiGH.Texts = "";
            txtSdtGH.Texts = "";
            txtDiaChiGH.Texts = "";
            txtPhiGiaoHang.Texts = "";
            cbbPtThanhToan.SelectedIndex = 0;
            txtMucUuDai1.Text = "";
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
                if (cbbPtThanhToan.Texts == "Cả tiền mặt và chuyển khoản")
                {
                    if (txthtThanhToan.Texts.Trim() != "" && txtChuyenKhoan.Texts.Trim() != "" && ValidateInput.CheckDecimalInput(txthtThanhToan.Texts.Trim()) && decimal.Parse(txthtThanhToan.Texts.Trim()) > _IChiTietHDServices.GetAll().Where(x => x.MaHD == TabHoaDon.SelectedTab.Name).Sum(x => x.SoLuong * x.DonGia))
                    {
                        decimal TienThua = decimal.Parse(txthtThanhToan.Texts.Trim()) + decimal.Parse(txtChuyenKhoan.Texts) - decimal.Parse(_IChiTietHDServices.GetAll().Where(x => x.MaHD == TabHoaDon.SelectedTab.Name).Sum(x => x.SoLuong * x.DonGia).ToString());
                        if (TienThua < 0)
                        {
                            txtTienThua1.Text = "";
                        }
                        else
                        {
                            txtTienThua1.Text = double.Parse(TienThua.ToString()).ToString("#,###", CultureInfo.GetCultureInfo("vi-VN").NumberFormat) + "đ";
                        }
                    }
                    else
                    {
                        txtTienThua1.Text = "";
                    }
                }
                else
                {
                    if (txthtThanhToan.Texts.Trim() != "" && ValidateInput.CheckDecimalInput(txthtThanhToan.Texts.Trim()) && decimal.Parse(txthtThanhToan.Texts.Trim()) > _IChiTietHDServices.GetAll().Where(x => x.MaHD == TabHoaDon.SelectedTab.Name).Sum(x => x.SoLuong * x.DonGia))
                    {
                        decimal TienThua = decimal.Parse(txthtThanhToan.Texts.Trim()) - decimal.Parse(_IChiTietHDServices.GetAll().Where(x => x.MaHD == TabHoaDon.SelectedTab.Name).Sum(x => x.SoLuong * x.DonGia).ToString());
                        if (TienThua < 0)
                        {
                            txtTienThua1.Text = "";
                        }
                        else
                        {
                            txtTienThua1.Text = double.Parse(TienThua.ToString()).ToString("#,###", CultureInfo.GetCultureInfo("vi-VN").NumberFormat) + "đ";
                        }
                    }
                    else
                    {
                        txtTienThua1.Text = "";
                    }
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
                        var hoadon = _HoaDonServices.GetAll().FirstOrDefault(c => c.MaHD == TabHoaDon.SelectedTab.Name);
                        if (rdoTaiQuay.Checked)
                        {
                            if (cbbPtThanhToan.SelectedIndex >= 0)
                            {
                                if (cbbPtThanhToan.Texts != "Cả tiền mặt và chuyển khoản")
                                {
                                    if (decimal.Parse(txthtThanhToan.Texts.Trim()) >= ValidateInput.RegexDecimal(txtTongTienPTra1.Text))
                                    {
                                        if (hoadon != null)
                                        {
                                            hoadon.NgayThanhToan = DateTime.Now;
                                            hoadon.TrangThai = 1;
                                            hoadon.IdHt = _IHinhThucMhServices.GetAll().Find(x => x.Ten == "Tại quầy").Id;
                                            hoadon.IdPttt = _IPtthanhToanServices.GetAll().FirstOrDefault(c => c.Ten == cbbPtThanhToan.Texts).Id;
                                            if (cbbPtThanhToan.Texts == "Tiền mặt")
                                            {
                                                hoadon.TienKhachDua = Convert.ToDecimal(txthtThanhToan.Texts);
                                            }
                                            else if (cbbPtThanhToan.Texts == "Cả tiền mặt và chuyển khoản")
                                            {
                                                hoadon.TienKhachDua = Convert.ToDecimal(txthtThanhToan.Texts);
                                                hoadon.TienChuyenKhoan = Convert.ToDecimal(txtChuyenKhoan.Texts);
                                            }
                                            else hoadon.TienChuyenKhoan = Convert.ToDecimal(txthtThanhToan.Texts);
                                            hoadon.MaHD = TabHoaDon.SelectedTab.Name;
                                            hoadon.GiamGia = txtGiamGia.Texts.Trim() == "" ? 0 : decimal.Parse(txtGiamGia.Texts);

                                            //hoadon.TongTien = Convert.ToInt32(_IChiTietHDServices.GetAll().Where(x => x.MaHD == TabHoaDon.SelectedTab.Name).Sum(x => x.SoLuong * x.DonGia));
                                            hoadon.TongTienSauKhiGiam = ValidateInput.RegexDecimal(txtTongTienPTra1.Text);
                                            hoadon.TongTien = ValidateInput.RegexDecimal(txtTongTien2.Text);
                                            hoadon.HinhThucGiamGia = CbbGiamGia.SelectedIndex == 0 ? "Phần trăm" : "Tiền mặt";
                                            hoadon.MoTa += "->(" + DateTime.Now.ToString() + "-" + hoadon.MaNv + "Thanh Toán" + "-" + txtMoTa.Texts + ")";
                                            if (txtsearchKH.Texts != "")
                                            {
                                                var temp = _IKhachHangServices.GetAll().FirstOrDefault(c => c.Sdt == txtsearchKH.Texts);
                                                if (temp != null)
                                                {
                                                    hoadon.IdKh = temp.Id;
                                                    UpdateTichDiem();
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
                                {
                                    if (decimal.Parse(txthtThanhToan.Texts.Trim()) + decimal.Parse(txtChuyenKhoan.Texts) >= ValidateInput.RegexDecimal(txtTongTienPTra1.Text))
                                    {
                                        if (hoadon != null)
                                        {
                                            hoadon.NgayThanhToan = DateTime.Now;
                                            hoadon.TrangThai = 1;
                                            hoadon.IdHt = _IHinhThucMhServices.GetAll().Find(x => x.Ten == "Tại quầy").Id;
                                            hoadon.IdPttt = _IPtthanhToanServices.GetAll().FirstOrDefault(c => c.Ten == cbbPtThanhToan.Texts).Id;
                                            if (cbbPtThanhToan.Texts == "Tiền mặt")
                                            {
                                                hoadon.TienKhachDua = Convert.ToDecimal(txthtThanhToan.Texts);
                                            }
                                            else if (cbbPtThanhToan.Texts == "Cả tiền mặt và chuyển khoản")
                                            {
                                                hoadon.TienKhachDua = Convert.ToDecimal(txthtThanhToan.Texts);
                                                hoadon.TienChuyenKhoan = Convert.ToDecimal(txtChuyenKhoan.Texts);
                                            }
                                            else hoadon.TienChuyenKhoan = Convert.ToDecimal(txthtThanhToan.Texts);
                                            hoadon.MaHD = TabHoaDon.SelectedTab.Name;
                                            hoadon.GiamGia = txtGiamGia.Texts.Trim() == "" ? 0 : decimal.Parse(txtGiamGia.Texts);
                                            //hoadon.TongTien = Convert.ToInt32(_IChiTietHDServices.GetAll().Where(x => x.MaHD == TabHoaDon.SelectedTab.Name).Sum(x => x.SoLuong * x.DonGia));
                                            hoadon.TongTienSauKhiGiam = ValidateInput.RegexDecimal(txtTongTienPTra1.Text);
                                            hoadon.TongTien = ValidateInput.RegexDecimal(txtTongTien2.Text);
                                            hoadon.HinhThucGiamGia = CbbGiamGia.SelectedIndex == 0 ? "Phần trăm" : "Tiền mặt";
                                            hoadon.MoTa += "->(" + DateTime.Now.ToString() + "-" + hoadon.MaNv + "Thanh Toán" + "-" + txtMoTa.Texts + ")";
                                            if (txtsearchKH.Texts != "")
                                            {
                                                var temp = _IKhachHangServices.GetAll().FirstOrDefault(c => c.Sdt == txtsearchKH.Texts);
                                                if (temp != null)
                                                {
                                                    hoadon.IdKh = temp.Id;
                                                    UpdateTichDiem();
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

                            }
                            else
                            {

                                this.Alert("Vui lòng chọn hình thức thanh toán", Form_Alert.enmType.Warning);
                            }
                        }
                        else
                        {
                            if (CheckValiDateGiaoHang())
                            {
                                if (!ValidateInput.IsValidVietNamPhoneNumber(txtSdtGH.Texts))
                                {
                                    RJMessageBox.Show("Số điện thoại không đúng định dạng");
                                }
                                else
                                {
                                    if (CheckGH())
                                    {
                                        if (Convert.ToDecimal(txthtThanhToan.Texts) >= ValidateInput.RegexDecimal(txtTongTienPTra1.Text))
                                        {
                                            if (cbbPtThanhToan.SelectedIndex >= 0)
                                            {
                                                if (cbbPtThanhToan.Texts == "COD")
                                                {
                                                    hoadon.TrangThai = 0;
                                                    hoadon.TrangThaiGiaoHang = 1;
                                                    hoadon.Cod = decimal.Parse(txthtThanhToan.Texts);
                                                }
                                                else
                                                {
                                                    hoadon.TrangThai = 1;
                                                    hoadon.TrangThaiGiaoHang = 1;
                                                    hoadon.NgayThanhToan = DateTime.Now;
                                                    hoadon.TienChuyenKhoan = decimal.Parse(txthtThanhToan.Texts);
                                                }
                                                hoadon.IdPttt = _IPtthanhToanServices.GetAll().Find(x => x.Ten == cbbPtThanhToan.Texts).Id;
                                                hoadon.IdHt = _IHinhThucMhServices.GetAll().Find(x => x.Ten == rdoQuaInbox.Text).Id;
                                                hoadon.MaHD = TabHoaDon.SelectedTab.Name;
                                                hoadon.GiamGia = txtGiamGia.Texts == "" ? 0 : decimal.Parse(txtGiamGia.Texts);
                                                hoadon.TongTienSauKhiGiam = ValidateInput.RegexDecimal(txtTongTienPTra1.Text);
                                                hoadon.TongTien = ValidateInput.RegexDecimal(txtTongTien2.Text);
                                                hoadon.HinhThucGiamGia = CbbGiamGia.SelectedIndex == 0 ? "Phần trăm" : "Tiền mặt";
                                                hoadon.TienShip = decimal.Parse(txtPhiGiaoHang.Texts);
                                                hoadon.TenNguoiNhan = txtTenNguoiGH.Texts;
                                                hoadon.SdtNhanHang = txtSdtGH.Texts;
                                                hoadon.DiaChiNhan = txtDiaChiGH.Texts;
                                                hoadon.MoTa += "->(" + DateTime.Now.ToString() + "-" + hoadon.MaNv + "-" + "Tạo đơn giao hàng" + txtMoTa.Texts + ")";

                                                if (txtsearchKH.Texts != "")
                                                {
                                                    var temp = _IKhachHangServices.GetAll().FirstOrDefault(c => c.Sdt == txtsearchKH.Texts);
                                                    if (temp != null)
                                                    {
                                                        hoadon.IdKh = temp.Id;
                                                        UpdateTichDiem();
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

                                            this.Alert("Số tiền không đủ!", Form_Alert.enmType.Warning);
                                        }
                                    }
                                }
                            }
                            else
                            {
                                RJMessageBox.Show("Vui lòng nhập đủ thông tin phần giao hàng");
                            }
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

        private bool CheckValiDateGiaoHang()
        {
            if (txtTenNguoiGH.Texts.Trim() == "" || txtSdtGH.Texts.Trim() == "" || txtDiaChiGH.Texts.Trim() == "" || txtPhiGiaoHang.Texts.Trim() == "")
            {
                return false;
            }
            return true;
        }

        private bool CheckGH()
        {
            foreach (var x in TabGiaoHang.Controls.OfType<RJTextBox>())
            {
                if (x.Texts.Trim() == "") return false;
            }
            return true;
        }
        private void cbbPtThanhToan_OnSelectedIndexChanged_1(object sender, EventArgs e)
        {
            txtTienThua1.Visible = true;
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
            txtChuyenKhoan.Texts = 0.ToString();
        }

        private void txtGiamGia__TextChanged(object sender, EventArgs e)
        {
            LoadGia();
        }

        private void CbbGiamGia_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CbbGiamGia.SelectedIndex == 0)
            {
                if (txtTongTienPTra1.Text == 0.ToString())
                {
                    txtGiamGia.Texts = 100.ToString();
                }
                else if (txtTongTien2.Text.Trim() != "" && txtTongTienPTra1.Text.Trim() != "")
                {
                    txtGiamGia.Texts = ((ValidateInput.RegexDecimal(txtTongTien2.Text) - ValidateInput.RegexDecimal(txtTongTienPTra1.Text)) / (ValidateInput.RegexDecimal(txtTongTien2.Text)) * 100).ToString();
                }
            }
            else
            {
                if (txtTongTienPTra1.Text == 0.ToString() && txtTongTien2.Text != "")
                {
                    txtGiamGia.Texts = ValidateInput.RegexDecimal(txtTongTien2.Text).ToString();
                }
                else if (txtTongTien2.Text.Trim() != "" && txtTongTienPTra1.Text.Trim() != "")
                {
                    txtGiamGia.Texts = (ValidateInput.RegexDecimal(txtTongTien2.Text) - ValidateInput.RegexDecimal(txtTongTienPTra1.Text)).ToString();
                }
            }
        }

        private void UpdateTichDiem()
        {
            var List = _ICtTichDiemServices.GetAll().Where(x => x.TrangThai == 0).ToList();
            var TichDiem = _ITichDiemServices.GetAll().Find(x => x.Id == GetKH(txtsearchKH.Texts).IdtichDiem);
            if (List.Count > 0)
            {
                foreach (var item in List)
                {
                    TichDiem.SoDiem = TichDiem.SoDiem + Convert.ToInt32(ValidateInput.RegexDecimal(txtTongTienPTra1.Text)) / (Convert.ToInt32(item.HeSoTich));
                }
            }
            _ITichDiemServices.Update(TichDiem);
            _ITichDiemServices = new TichDiemServices();
            var ls = new LichSuTichDiemView()
            {
                IdHoaDon = _HoaDonServices.GetAll().Find(x => x.MaHD == TabHoaDon.SelectedTab.Name).Id,
                IdTichDiem = TichDiem.Id,
                NgayTichDiem = DateTime.Now,
                SoDiemDung = _ICtTichDiemServices.GetAll().Count > 0 ? Convert.ToInt32(ValidateInput.RegexDecimal(txtTongTienPTra1.Text)) / (Convert.ToInt32(_ICtTichDiemServices.GetAll().ToList()[0].HeSoTich)) : 0,
                IdCttichDiem = _ICtTichDiemServices.GetAll().Count > 0 ? _ICtTichDiemServices.GetAll().ToList()[0].Id : null
            };
            _ILichSuTichDiemServices.Add(ls);
            _ILichSuTichDiemServices = new LichSuTichDiemServices();
            _IKhachHangServices = new KhachHangServices();
            lblMucTichLuy.Text = "Điểm tích lũy: " + GetKH(txtsearchKH.Texts).SoDiem;
            lblUuDaiTichLuy.Text = GetUuDai() == null ? "Hiện không có ưu đãi nào" : "Mức ưu đãi Là: " + GetUuDai().MucUuDai + GetUuDai().LoaiHinhKm;
        }

        private void txthtThanhToan__TextChanged(object sender, EventArgs e)
        {
            if (txtChuyenKhoan.Texts != "")
            {
                LoadGia();
            }

            if (txthtThanhToan.Texts.Length > 27)
            {
                txthtThanhToan.Texts = 0.ToString();
            }
        }

        private ChiTietSpViews GetCtsp(Guid id) => _IChiTietSpServices.GetById(id);
        private void LoadItemSearch(string name)
        {
            LoadAll();
            flpSP.Controls.Clear();
            SearchHats[] Hat = new SearchHats[_IanhServices.GetAll().GroupBy(x => x.IdChiTietSp).Select(sp => sp.First()).ToList().Count];
            List<AnhViews> ListAnh = _IanhServices.GetAll().Where(x => x.TrangThaiSP == 0 && x.TenAnh == "Anh" && RemoveUnicode(GetCtsp(x.IdChiTietSp.GetValueOrDefault()).TenSP.ToLower()).Contains(RemoveUnicode(name.ToLower()))).ToList();
            if (ListAnh.Any())
            {
                for (int i = 0; i < ListAnh.Count; i++)
                {
                    if (ListAnh[i].SoLuongTon > 0)
                    {
                        Hat[i] = new SearchHats();
                        Hat[i].TenSP1 = _ISanPhamServices.GetAll().Find(sp => sp.Id == ListAnh[i].IdSp).Ten + "-" + _IKichCoServices.GetAll().Find(x => x.Id == ListAnh[i].IdKichCo).Size;
                        Hat[i].Icon = Image.FromStream(new MemoryStream((byte[])ListAnh[i].DuongDan));
                        Hat[i].Price = Convert.ToDouble(ListAnh[i].GiaBan);
                        Hat[i].SoluongSP1 = ListAnh[i].SoLuongTon.ToString();
                        Hat[i].IdSPCTSP = ListAnh[i].IdChiTietSp.GetValueOrDefault();
                        Hat[i].label1.Visible = false;
                        Hat[i].MucGiam = "";
                        var CtSale = _IChiTietSaleServices.GetAll().Find(y => y.IdChiTietSp == ListAnh[i].IdChiTietSp && y.TrangThai == 0);
                        if (CtSale != null)
                        {
                            Hat[i].Gia.Visible = false;
                            Hat[i].label1.Visible = true;
                            var Sale = _ISaleServices.GetAll().Find(z => z.Id == CtSale.IdSale);
                            if (Sale.LoaiHinhKm == "%")
                            {
                                Hat[i].GiaGiam = Convert.ToDouble(ListAnh[i].GiaBan * (100 - Sale.MucGiam) / 100);
                            }
                            else
                            {
                                Hat[i].GiaGiam = Convert.ToDouble(ListAnh[i].GiaBan - Sale.MucGiam);
                            }
                            Hat[i].label1.Text = "Giá: " + double.Parse(Convert.ToDouble(ListAnh[i].GiaBan).ToString()).ToString("#,###", CultureInfo.GetCultureInfo("vi-VN").NumberFormat) + "đ";
                            Hat[i].MucGiam = "Sale: " + Sale.MucGiam + Sale.LoaiHinhKm;
                        }
                        flpSP.Controls.Add(Hat[i]);
                        Hat[i].Onclick += (ss, ee) =>
                        {
                            var wdg = (SearchHats)ss;
                            var ctsp = _IChiTietSpServices.GetById(wdg.IdSPCTSP);
                            if (TabHoaDon.SelectedTab != null)
                            {
                                if (_IChiTietHDServices.GetAll().Where(x => x.MaHD == TabHoaDon.SelectedTab.Name).ToList().All(x => x.IdChiTietSp != wdg.
                                    IdSPCTSP))
                                {
                                    var x = new ChiTietHDView();
                                    x.IdChiTietSp = wdg.IdSPCTSP;
                                    x.DonGia = decimal.Parse(wdg.Price.ToString());
                                    if (CtSale != null)
                                    {
                                        var Sale = _ISaleServices.GetAll().Find(z => z.Id == CtSale.IdSale);
                                        if (Sale.LoaiHinhKm == "%")
                                        {
                                            x.DonGia = decimal.Parse((wdg.Price * Convert.ToDouble((100 - Sale.MucGiam) / 100)).ToString()); ;
                                        }
                                        else
                                        {
                                            x.DonGia = decimal.Parse((wdg.Price - Convert.ToDouble(Sale.MucGiam)).ToString()); ;
                                        }
                                    }
                                    else
                                    {
                                        x.DonGia = decimal.Parse(wdg.Price.ToString());
                                    }
                                    x.TenSP = wdg.TenSP1;
                                    x.IdHoaDon = _HoaDonServices.GetAll().FirstOrDefault(x => x.MaHD == TabHoaDon.SelectedTab.Name).Id;
                                    x.SoLuong = 1;
                                    ctsp.SoLuongTon -= 1;
                                    _IChiTietHDServices.Add(x);
                                    _IChiTietSpServices.Update(ctsp);
                                }
                                else
                                {
                                    var hdct = _IChiTietHDServices.GetAll().FirstOrDefault(x => x.IdChiTietSp == wdg.IdSPCTSP && x.IdHoaDon == _HoaDonServices.GetAll().FirstOrDefault(c => c.MaHD == TabHoaDon.SelectedTab.Name).Id);
                                    var spct = _IChiTietSpServices.GetAll().Find(x => x.Id == hdct.IdChiTietSp);
                                    if (spct.SoLuongTon > 0)
                                    {
                                        hdct.SoLuong += 1;
                                        _IChiTietHDServices.Update(hdct);
                                        ctsp.SoLuongTon -= 1;
                                        _IChiTietSpServices.Update(ctsp);
                                    }
                                    else
                                    {
                                        this.Alert("Hiện tại không còn mặt hàng này", Form_Alert.enmType.Warning);
                                    }
                                }
                                LoadView(TabHoaDon.SelectedTab.Name);
                                LoadItemSearch(txtSearch.Texts);
                                LoadItem();
                                LoadGia();
                                LoadTienThua();
                            }
                            else
                            {
                                tabPage = new TabPage(MaTT());
                                txtMaHD1.Text = tabPage.Name = MaTT();
                                TabHoaDon.TabPages.Add(tabPage);
                                dgview.Parent = tabPage;
                                LoadView(TabHoaDon.SelectedTab.Name);
                                dgview.Visible = true;
                                dgview.Dock = DockStyle.Fill;
                                var x = new HoaDonViews()
                                {
                                    MoTa = "(" + DateTime.Now.ToString() + "-" + (_iNhanVienServices.GetAll().Where(p => p.TaiKhoan == Properties.Settings.Default.TKdaLogin).Select(p => p.Ma).FirstOrDefault()) + "-" + "Tạo hóa đơn" + ")",
                                    Id = Guid.NewGuid(),
                                    MaHD = MaTT(),
                                    NgayTao = DateTime.Now,
                                    TrangThai = 0,
                                    IdNv = _iNhanVienServices.GetAll().Where(p => p.TaiKhoan == Properties.Settings.Default.TKdaLogin).Select(p => p.Id).FirstOrDefault(),
                                };
                                _HoaDonServices.Add(x);
                                TabHoaDon.SelectedTab = tabPage;
                                this.Alert("Tạo mới thành công hóa đơn " + TabHoaDon.SelectedTab.Name, Form_Alert.enmType.Success);
                                var spct = _IChiTietSpServices.GetById(wdg.IdSPCTSP);
                                if (_IChiTietHDServices.GetAll().Where(x => x.MaHD == TabHoaDon.SelectedTab.Name).ToList().All(x => x.IdChiTietSp != wdg.
                                    IdSPCTSP))
                                {
                                    var cthd = new ChiTietHDView();
                                    cthd.IdChiTietSp = wdg.IdSPCTSP;
                                    cthd.DonGia = decimal.Parse(wdg.Price.ToString());
                                    if (CtSale != null)
                                    {
                                        var Sale = _ISaleServices.GetAll().Find(z => z.Id == CtSale.IdSale);
                                        if (Sale.LoaiHinhKm == "%")
                                        {
                                            cthd.DonGia = decimal.Parse((wdg.Price * Convert.ToDouble((100 - Sale.MucGiam) / 100)).ToString()); ;
                                        }
                                        else
                                        {
                                            cthd.DonGia = decimal.Parse((wdg.Price - Convert.ToDouble(Sale.MucGiam)).ToString()); ;
                                        }
                                    }
                                    else
                                    {
                                        cthd.DonGia = decimal.Parse(wdg.Price.ToString());
                                    }
                                    cthd.TenSP = wdg.TenSP1;
                                    cthd.IdHoaDon = _HoaDonServices.GetAll().FirstOrDefault(cthd => cthd.MaHD == TabHoaDon.SelectedTab.Name).Id;
                                    cthd.SoLuong = 1;
                                    _IChiTietHDServices.Add(cthd);
                                    spct.SoLuongTon = spct.SoLuongTon - 1;
                                    _IChiTietSpServices.Update(spct);
                                }
                                else
                                {
                                    var hdct = _IChiTietHDServices.GetAll().FirstOrDefault(x => x.IdChiTietSp == wdg.IdSPCTSP && x.IdHoaDon == _HoaDonServices.GetAll().FirstOrDefault(c => c.MaHD == TabHoaDon.SelectedTab.Name).Id);
                                    if (spct.SoLuongTon > 0)
                                    {
                                        hdct.SoLuong += 1;
                                        _IChiTietHDServices.Update(hdct);
                                        spct.SoLuongTon -= 1;
                                        _IChiTietSpServices.Update(spct);
                                    }
                                    else
                                    {
                                        this.Alert("Hiện tại không còn mặt hàng này", Form_Alert.enmType.Warning);
                                    }
                                }
                                dgview.CurrentCell = null;
                                LoadView(TabHoaDon.SelectedTab.Name);
                                LoadGia();
                                LoadItem();
                                LoadTienThua();
                            }
                            txtSearch.Texts = "";
                        };
                    }
                    else
                    {
                        Hat[i] = new SearchHats();
                        Hat[i].TenSP1 = _ISanPhamServices.GetAll().Find(sp => sp.Id == ListAnh[i].IdSp).Ten + "-" + _IKichCoServices.GetAll().Find(x => x.Id == ListAnh[i].IdKichCo).Size;
                        Hat[i].Icon = Image.FromStream(new MemoryStream((byte[])ListAnh[i].DuongDan));
                        Hat[i].Price = Convert.ToDouble(ListAnh[i].GiaBan);
                        Hat[i].SoluongSP1 = ListAnh[i].SoLuongTon.ToString();
                        Hat[i].IdSPCTSP = ListAnh[i].IdChiTietSp.GetValueOrDefault();
                        Hat[i].label1.Visible = false;
                        Hat[i].MucGiam = "";
                        var CtSale = _IChiTietSaleServices.GetAll().Find(y => y.IdChiTietSp == ListAnh[i].IdChiTietSp && y.TrangThai == 0);
                        if (CtSale != null)
                        {
                            Hat[i].Gia.Visible = false;
                            Hat[i].label1.Visible = true;
                            var Sale = _ISaleServices.GetAll().Find(z => z.Id == CtSale.IdSale);
                            if (Sale.LoaiHinhKm == "%")
                            {
                                Hat[i].GiaGiam = Convert.ToDouble(ListAnh[i].GiaBan * (100 - Sale.MucGiam) / 100);
                            }
                            else
                            {
                                Hat[i].GiaGiam = Convert.ToDouble(ListAnh[i].GiaBan - Sale.MucGiam);
                            }
                            Hat[i].label1.Text = "Giá: " + double.Parse(Convert.ToDouble(ListAnh[i].GiaBan).ToString()).ToString("#,###", CultureInfo.GetCultureInfo("vi-VN").NumberFormat) + "đ";
                            Hat[i].MucGiam = "Sale: " + Sale.MucGiam + Sale.LoaiHinhKm;
                        }
                        flpSP.Controls.Add(Hat[i]);
                        Hat[i].Onclick += (ss, ee) =>
                        {
                            if (TabHoaDon.SelectedTab != null)

                            {
                                this.Alert("Hiện tại không còn mặt hàng này", Form_Alert.enmType.Warning);
                            }
                            else
                            {

                                this.Alert("Hiện tại không còn mặt hàng này", Form_Alert.enmType.Warning);
                            }
                        };
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtChuyenKhoan__TextChanged(object sender, EventArgs e)
        {
            if (txthtThanhToan.Texts != "")
            {
                LoadGia();
            }

        }

        private void rdoQuaInbox_CheckedChanged(object sender, EventArgs e)
        {
            cbbPtThanhToan.Texts = "";
            if (rdoQuaInbox.Checked)
            {
                tabControl1.SelectedTab = TabGiaoHang;
                btnThanhToan.Text = "Đặt Hàng";
                cbbPtThanhToan.Items.Clear();
                cbbPtThanhToan.Items.Add("COD");
                cbbPtThanhToan.Items.Add("Chuyển khoản");
                lblHTThanhToan.Visible = false;
                lblTienThua.Visible = false;
                txtTienThua1.Visible = false;
                txtTienThua.Visible = false;
                txthtThanhToan.Visible = false;
                txtChuyenKhoan.Visible = false;
                lblChuyenTien.Visible = false;
                cbbPtThanhToan.SelectedIndex = 0;
            }

        }

        private void HideClear(string MaHoaDon)
        {
            if (TabHoaDon.SelectedTab == null)
            {
                btnClear.Visible = false;
            }
            else
            {
                if (_IChiTietHDServices.GetAll().Where(x => x.MaHD == TabHoaDon.SelectedTab.Name).ToList().Count > 0)
                {
                    btnClear.Visible = true;
                }
                else
                {
                    btnClear.Visible = false;
                }
            }
        }

        private void rdoTaiQuay_CheckedChanged(object sender, EventArgs e)
        {
            cbbPtThanhToan.Texts = "";
            if (rdoTaiQuay.Checked)
            {
                tabControl1.SelectedTab = tabPage3;
                btnThanhToan.Text = "Thanh toán";
                cbbPtThanhToan.Items.Clear();
                cbbPtThanhToan.Items.Add("Tiền mặt");
                cbbPtThanhToan.Items.Add("Chuyển khoản");
                cbbPtThanhToan.Items.Add("Cả tiền mặt và chuyển khoản");
                lblHTThanhToan.Visible = false;
                lblTienThua.Visible = false;
                txtTienThua1.Visible = false;
                txtTienThua.Visible = false;
                txthtThanhToan.Visible = false;
                txtChuyenKhoan.Visible = false;
                lblChuyenTien.Visible = false;
                cbbPtThanhToan.SelectedIndex = 0;

            }
        }


        private bool HopThoai1() => RJMessageBox.Show("Bạn có muốn thực hiện hành động này không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes;
        private void rjButton2_Click(object sender, EventArgs e)
        {
            if (HopThoai1())
            {
                if (TabHoaDon.SelectedTab != null)
                {
                    var lstcthd = _IChiTietHDServices.GetAll().Where(x => x.MaHD == TabHoaDon.SelectedTab.Name).ToList();
                    if (lstcthd.Any())
                    {
                        foreach (var item in lstcthd)
                        {
                            var ctsp = _IChiTietSpServices.GetById(item.IdChiTietSp.GetValueOrDefault());
                            ctsp.SoLuongTon += item.SoLuong;
                            _IChiTietSpServices.Update(ctsp);
                            _IChiTietHDServices.Delete(item);
                        }
                    }
                    LoadALL();
                    LoadItem();
                    LoadView(TabHoaDon.SelectedTab.Name);
                    LoadGia();
                    LoadTienThua();
                }
            }

        }

        private void btnThemSP_Click(object sender, EventArgs e)
        {
            FrmThemSP sp = new FrmThemSP();
            sp.ShowDialog();
        }

        private void rjButton1_Click_2(object sender, EventArgs e)
        {
            if (doifrom == 1)
            {
                LoadItem();
                btngiaohang.Text = "Giao hàng";
                pnlTimeLine.Visible = false;
                pnlfill.Controls.Clear();
                pnlfill.Controls.Add(TabHoaDon);
                TabHoaDon.Dock = DockStyle.Fill;
                btnClear.Visible = true;
                btnAddTab.Visible = true;
                pnlBodysearch.Visible = true;
                dgvGiaoHang.Visible = false;
                panel1.Controls.Clear();
                panel1.Controls.Add(tabControl2);
                tabControl2.Dock = DockStyle.Top;
                panel1.Controls.Add(tabControl1);
                tabControl1.Dock = DockStyle.Top;
                tabControl3.Visible = false;
                doifrom = 0;
            }
            else
            {
                LoadHoaDon();
                pnlTimeLine.Visible = true;
                pnlTimeLine.Dock = DockStyle.Left;
                btngiaohang.Text = "Bán hàng";
                pnlfill.Controls.Clear();
                pnlfill.Controls.Add(dgvGiaoHang);
                dgvGiaoHang.Dock = DockStyle.Fill;
                dgvGiaoHang.Visible = true;
                btnClear.Visible = false;
                btnAddTab.Visible = false;
                pnlBodysearch.Visible = false;
                doifrom = 1;
                panel1.Controls.Clear();
                panel1.Controls.Add(tabControl3);
                tabControl3.Dock = DockStyle.Fill;
                tabControl3.Visible = true;
            }
        }
        //0: Không
        //1: Chờ xử lý
        //2: Đang giao
        //3: Thất bại
        //4: Thành công

        private void LoadHoaDon()
        {
            LoadALL();
            ListItem.Controls.Clear();
            List<HoaDonS> Hats = new List<HoaDonS>();
            var ListAnh = _HoaDonServices.GetAll().Where(x => (x.TrangThaiGiaoHang < 4 && x.TrangThaiGiaoHang > 0) || (x.TrangThaiGiaoHang == 4 && x.TrangThai == 0)).OrderByDescending(x => x.MaHD).ToList();
            HoaDonS[] Hat = new HoaDonS[ListAnh.Count];
            for (int i = 0; i < ListAnh.Count; i++)
            {
                Hat[i] = new HoaDonS();
                Hat[i].MaHD = ListAnh[i].MaHD;
                Hat[i].ID = ListAnh[i].Id.ToString();
                Hat[i].TenKH = ListAnh[i].TenNguoiNhan;
                Hat[i].SDT = ListAnh[i].SdtNhanHang;
                Hat[i].DiaChi = ListAnh[i].DiaChiNhan;
                Hat[i].TrangThaiGiaohang = ListAnh[i].TrangThaiGiaoHang == 1 ? "Chờ xử lý" : ListAnh[i].TrangThaiGiaoHang == 2 ? "Đang giao" : ListAnh[i].TrangThaiGiaoHang == 3 ? "Thất bại" : "Thành công";
                Hat[i].TrangThai = ListAnh[i].TrangThai == 0 ? "Chưa thanh toán" : "Đã thanh toán";
                Hat[i].MaNV = ListAnh[i].MaNv;
                ListItem.Controls.Add(Hat[i]);
                Hat[i].Onselect += (ss, ee) =>
                {
                    var wdg = (HoaDonS)ss;
                    dgvGiaoHang.Rows.Clear();
                    int stt = 1; ;
                    foreach (var x in _IChiTietHDServices.GetAll().Where(x => x.MaHD == wdg.MaHD))
                    {
                        dgvGiaoHang.Rows.Add(x.IdChiTietSp, stt++, x.TenSP + "-" + _ISizeServices.GetAll().Find(y => y.Id == _IChiTietSpServices.GetById(x.IdChiTietSp.GetValueOrDefault()).IdSize).Size, "+", x.SoLuong, "-",
                    double.Parse(x.DonGia.ToString()).ToString("#,###", CultureInfo.GetCultureInfo("vi-VN").NumberFormat) + "đ",
                    double.Parse((x.SoLuong * x.DonGia).ToString()).ToString("#,###", CultureInfo.GetCultureInfo("vi-VN").NumberFormat) + "đ");
                    }

                    txtmahdgh.Texts = wdg.MaHD;
                    txtmanvgh.Texts = wdg.MaNV;
                    var HoaDon = _HoaDonServices.GetAll().Find(x => x.MaHD == wdg.MaHD);
                    TimeLineTrangThaiGiaoHang(HoaDon);
                    txtngaytaogh.Texts = HoaDon.NgayTao.ToString();
                    txttongtiengh.Texts = double.Parse(HoaDon.TongTien.ToString()).ToString("#,###", CultureInfo.GetCultureInfo("vi-VN").NumberFormat) + "đ";
                    txtpttt.Texts = _IPtthanhToanServices.GetAll().Find(x => x.Id == HoaDon.IdPttt).Ten;
                    txtnguoidat.Texts = HoaDon.IdKh == null ? "Khách vãng lai" : _IKhachHangServices.GetByID(HoaDon.IdKh.GetValueOrDefault()).Ten;
                    txtnguoinhan.Texts = HoaDon.TenNguoiNhan;
                    txtdiachi.Texts = HoaDon.DiaChiNhan;
                    txttienship.Texts = double.Parse(HoaDon.TienShip.ToString()).ToString("#,###", CultureInfo.GetCultureInfo("vi-VN").NumberFormat) + "đ";
                    txtsdt.Texts = HoaDon.SdtNhanHang.ToString();

                    if (HoaDon.TrangThaiGiaoHang > 1)
                    {
                        txtngayship.Texts = HoaDon.NgayShip.ToString();
                    }
                    else
                    {
                        txtngayship.Texts = "Đang xử lý";
                    }
                    txttrangthaitt.Texts = HoaDon.TrangThai == 0 ? "Chưa thanh toán" : "Đã thanh toán";
                };

            }
        }

        private void TimeLineTrangThaiGiaoHang(HoaDonViews Hd)
        {
            if (Hd.TrangThaiGiaoHang == 1)
            {
                btnChoXuLy.BackColor = Color.Red;
                btnChoLayHang.BackColor = Color.FromArgb(49, 66, 83);
                btndangGiao.BackColor = Color.FromArgb(49, 66, 83);
            }
        }
        private void rjButton1_Click_3(object sender, EventArgs e)
        {
            if (txtmahdgh.Text.Trim() == "")
            {
                this.Alert("Vui vui lòng chọn hóa đơn", Form_Alert.enmType.Warning);
            }
            else if (txtGhiChu.Texts.Trim() == "")
            {
                MessageBox.Show("Vui lòng xác nhận lý do hủy trong phần ghi chú.");
            }
            else
            {
                var HoaDon = _HoaDonServices.GetAll().Find(x => x.MaHD == txtmahdgh.Text);
                if (HoaDon.IdPttt == Guid.Parse("19502d67-ff7f-4dbc-849a-3751cacc1ebb"))
                {

                }
                else
                {

                }

            }
        }
        private void rjButton2_Click_1(object sender, EventArgs e)
        {
            if (txtmahdgh.Text.Trim() == "")
            {
                this.Alert("Vui vui lòng chọn hóa đơn", Form_Alert.enmType.Warning);
            }
            else
            if (txtGhiChu.Texts.Trim() == "")
            {
                MessageBox.Show("Vui lòng xác nhận lý do hủy trong phần ghi chú.");
            }
            else
            {
                var HoaDon = _HoaDonServices.GetAll().Find(x => x.MaHD == txtmahdgh.Text);
                HoaDon.TrangThai = 3;
                HoaDon.TrangThaiGiaoHang = 5;
                _HoaDonServices.Update(HoaDon);

                foreach (var x in _IChiTietHDServices.GetAll().Where(x => x.MaHD == HoaDon.MaHD).ToList())
                {
                    x.TrangThai = 1;
                    var ctsp = _IChiTietSpServices.GetById(x.IdChiTietSp.GetValueOrDefault());
                    ctsp.SoLuongTon += x.SoLuong;
                    _IChiTietSpServices.Update(ctsp);
                    _IChiTietHDServices.Update(x);
                    dgvGiaoHang.Rows.Clear();
                    LoadHoaDon();
                    tpthongtinhd.Controls.OfType<TextBox>().ToList().ForEach(txt => txt.Clear());
                    tpthongtinhd.Controls.OfType<RadioButton>().ToList().ForEach(txt => txt.Checked = false);
                    tpthongtinhd.Controls.OfType<RJTextBox>().ToList().ForEach(txt => txt.Texts = "");
                }
            }
        }

        private bool HopThoai() => MessageBox.Show("Bạn có muốn thực hiện hành động này", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes;

        private void rjButton4_Click(object sender, EventArgs e)
        {
            if (TabHoaDon.SelectedTab == null)
            {
                this.Alert("Hiện tại chưa có hóa đơn nào.", Form_Alert.enmType.Warning);
            }
            else
            if (txtMoTa.Texts.Trim() == "")
            {
                this.Alert("Vui lòng xác nhận lý do hủy trong phần ghi chú.", Form_Alert.enmType.Warning);
            }
            else
            {
                if (HopThoai())
                {
                    var HoaDon = _HoaDonServices.GetAll().Find(x => x.MaHD == TabHoaDon.SelectedTab.Name);
                    HoaDon.TrangThai = 3;
                    HoaDon.MoTa += "->(" + DateTime.Now.ToString() + "-" + HoaDon.MaNv + "Huy" + "-" + "Lý do" + txtMoTa.Texts + ")";
                    TabHoaDon.TabPages.Remove(TabHoaDon.SelectedTab);
                    _HoaDonServices.Update(HoaDon);
                    foreach (var x in _IChiTietHDServices.GetAll().Where(x => x.MaHD == HoaDon.MaHD).ToList())
                    {
                        var ctsp = _IChiTietSpServices.GetById(x.IdChiTietSp.GetValueOrDefault());
                        ctsp.SoLuongTon += x.SoLuong;
                        x.TrangThai = 1;
                        _IChiTietSpServices.Update(ctsp);
                        _IChiTietHDServices.Update(x);
                        TabHoaDon.Controls.Clear();
                        LoadData();
                        Clearform();
                        LoadItem();
                        LoadGia();
                        LoadTienThua();
                    }
                    this.Alert("Hóa đơn đã bị hủy.", Form_Alert.enmType.Info);
                }
            }
        }

        private void txthtThanhToan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtChuyenKhoan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtGiamGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtSdtGH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtPhiGiaoHang_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void dgview_DoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            var ctsp = _IChiTietSpServices.GetById(Guid.Parse(Cell(0)));
            if (dgview.Columns[e.ColumnIndex].Name == "TangSP")
            {

            }
        }

        private void dgview_DoubleClick(object sender, EventArgs e)
        {
            //var ObjSP = _IChiTietSpServices.GetById(Guid.Parse(Cell(0)));
            //if (dgview.Columns[2].Name == "NameSP")
            //{
            //    FrmThongTinSP sp = new FrmThongTinSP();
            //    sp.TenSP = ObjSP.TenSP;
            //    sp.Team = _ITeamServices.GetAll().Find(x => x.Id == ObjSP.IdTeam).Ten;
            //    sp.ChatLieu = _IChatLieuServices.GetAll().Find(x => x.Id == ObjSP.IdChatLieu).Ten;
            //    sp.MauSac = _IMauSacServices.GetAll().Find(x => x.Id == ObjSP.IdMauSac).Ten;
            //    sp.SizeSp = _ISizeServices.GetAll().Find(x => x.Id == ObjSP.IdSize).Size;
            //    var ctksp = _IChiTietKieuSpService.GetAll().Find(x => x.IdChiTietSp == ObjSP.Id);
            //    if (ctksp != null)
            //    {
            //        sp.NhomHang = TenKsp(ctksp.IdKieuSp.GetValueOrDefault(), ctksp.TenKieuSP).Substring(0, TenKsp(ctksp.IdKieuSp.GetValueOrDefault(), ctksp.TenKieuSP).Length - 2);
            //    }
            //    var QR = _IanhServices.GetAll().Find(x => x.IdChiTietSp == ObjSP.Id && x.TenAnh == "Barcode");
            //    sp.AnhMQr = Image.FromStream(new MemoryStream((byte[])QR.DuongDan));
            //    var Anh = _IanhServices.GetAll().Find(x => x.IdChiTietSp == ObjSP.Id && x.TenAnh == "Anh");
            //    sp.AnhSP1 = Image.FromStream(new MemoryStream((byte[])Anh.DuongDan));
            //    sp.ShowDialog();
            //}
        }

        private void dgview_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            var ctsp = _IChiTietSpServices.GetById(Guid.Parse(Cell(0)));
            var hdct = GetHDct(Guid.Parse(Cell(0)));
            if (ctsp == null) return;
            if (dgview.Columns[e.ColumnIndex].Name == "SoLuong1")
            {
                if (dgview.CurrentRow.Cells[4].Value != null)
                {

                    if (Regex.IsMatch(dgview.CurrentRow.Cells[4].Value.ToString(), @"^\d*(\.\d+)?$"))
                    {

                        if (Convert.ToInt32(dgview.CurrentRow.Cells[4].Value) > 0)
                        {
                            var inr = ctsp.SoLuongTon - (Convert.ToInt32(dgview.CurrentRow.Cells[4].Value) - hdct.SoLuong);
                            if (inr >= 0)
                            {
                                ctsp.SoLuongTon -= Convert.ToInt32(dgview.CurrentRow.Cells[4].Value) - hdct.SoLuong;
                                _IChiTietSpServices.Update(ctsp);
                                hdct.SoLuong = Convert.ToInt32(dgview.CurrentRow.Cells[4].Value);
                                _IChiTietHDServices.Update(hdct);

                            }
                            else
                            {

                                this.Alert("Số lượng không đủ", Form_Alert.enmType.Warning);
                            }
                        }
                        else
                        {

                            ctsp.SoLuongTon += hdct.SoLuong;
                            _IChiTietSpServices.Update(ctsp);
                            _IChiTietHDServices.Delete(hdct);
                        }
                    }
                    LoadGia();
                    LoadItem();
                    LoadView(TabHoaDon.SelectedTab.Name);

                }
                else
                {
                    dgview.CurrentRow.Cells[4].Value = hdct.SoLuong;
                }
            }

        }

        private void dgview_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void dgview_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var ObjSP = _IChiTietSpServices.GetById(Guid.Parse(Cell(0)));
            if (dgview.Columns[e.ColumnIndex].Name == "NameSP")
            {
                FrmThongTinSP sp = new FrmThongTinSP();
                sp.TenSP = ObjSP.TenSP;
                sp.Team = _ITeamServices.GetAll().Find(x => x.Id == ObjSP.IdTeam).Ten;
                sp.ChatLieu = _IChatLieuServices.GetAll().Find(x => x.Id == ObjSP.IdChatLieu).Ten;
                sp.MauSac = _IMauSacServices.GetAll().Find(x => x.Id == ObjSP.IdMauSac).Ten;
                sp.SizeSp = _ISizeServices.GetAll().Find(x => x.Id == ObjSP.IdSize).Size;
                var ctksp = _IChiTietKieuSpService.GetAll().Find(x => x.IdChiTietSp == ObjSP.Id);
                if (ctksp != null)
                {
                    sp.NhomHang = TenKsp(ctksp.IdKieuSp.GetValueOrDefault(), ctksp.TenKieuSP).Substring(0, TenKsp(ctksp.IdKieuSp.GetValueOrDefault(), ctksp.TenKieuSP).Length - 2);
                }
                var QR = _IanhServices.GetAll().Find(x => x.IdChiTietSp == ObjSP.Id && x.TenAnh == "Barcode");
                sp.AnhMQr = Image.FromStream(new MemoryStream((byte[])QR.DuongDan));
                var Anh = _IanhServices.GetAll().Find(x => x.IdChiTietSp == ObjSP.Id && x.TenAnh == "Anh");
                sp.AnhSP1 = Image.FromStream(new MemoryStream((byte[])Anh.DuongDan));
                sp.ShowDialog();
            }
        }


    }
}

