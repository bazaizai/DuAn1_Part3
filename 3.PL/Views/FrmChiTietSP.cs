﻿using _2.BUS.IServices;
using _2.BUS.Services;
using _2.BUS.ViewModels;
using _3.PL.Components;
using _3.PL.Properties;
using BarcodeLib;
using CustomControls.RJControls;
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
using System.Windows.Documents;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace _3.PL.Views
{
    public partial class FrmChiTietSP : Form
    {
        IChiTietSpServices _IChiTietSpServices;
        IAnhServices _IanhServices;
        IKieuSpServices _IKieuSpServices;
        IChiTietKieuSpService _IChiTietKieuSpService;
        public static Dictionary<Guid, bool> CheckCB;


        private int x;
        public int Count { get => x; set { x = value; x = value; } }

        public FrmChiTietSP()
        {
            InitializeComponent();
            CheckCB = new Dictionary<Guid, bool>();
            _IChiTietSpServices = new ChiTietSpServices();
            _IanhServices = new AnhServices();
            _IKieuSpServices = new KieuSpServices();
            _IChiTietKieuSpService = new ChiTietKieuSpServices();
            x = 1;
            LoadData();
        }



        private void LoadCbb()
        {
            CbbThaoTac.Items.Clear();
            CbbThaoTac.Texts = "Thao tác";
            CbbThaoTac.Items.Add("Áp dụng KM");
            CbbThaoTac.Items.Add("Không áp dụng KM");
            CbbThaoTac.Items.Add("Ngừng bán");
            CbbThaoTac.Items.Add("Mở bán");
        }

        private void LoadAll()
        {
            InitializeComponent();
            _IChiTietSpServices = new ChiTietSpServices();
            _IanhServices = new AnhServices();
            LoadData();
        }

        private bool NoCheck()
        {
            foreach (var x in CheckCB)
            {
                if (CheckCB[x.Key] == true)
                {
                    return false;
                }
            }
            return true;
        }

        private void LoadData()
        {
            LoadCbb();
            flowLayoutPanel1.Controls.Clear();
            List<ChiTietSpViews> CTSP = _IChiTietSpServices.GetAll().OrderByDescending(X => X.MaQr).OrderByDescending(X => X.MaQr.Length).ToList();
            if (txtSearch.Texts.Trim() != "")
            {
                CTSP = _IChiTietSpServices.GetAll().Where(x => x.MaQr.ToLower().Contains(RemoveUnicode(txtSearch.Texts.ToLower())) || RemoveUnicode(x.TenSP.ToLower()).Contains(RemoveUnicode(txtSearch.Texts.ToLower()))).OrderByDescending(X => X.MaQr).OrderByDescending(X => X.MaQr.Length).ToList();
            }

            ViewSP[] Sp = new ViewSP[CTSP.Count];
            for (int i = 0; i < CTSP.Count; i++)
            {
                Sp[i] = new ViewSP();
                Sp[i].MauSac = CTSP[i].TenMauSac;
                Sp[i].ChatLieu = CTSP[i].TenChatLieu;
                Sp[i].Team = CTSP[i].TenTeam;
                Sp[i].Size = CTSP[i].Size;
                Sp[i].IDSP = CTSP[i].Id;
                Sp[i].MaHang = CTSP[i].MaQr;
                Sp[i].GiaNhap = double.Parse(CTSP[i].GiaNhap.ToString()).ToString("#,###", CultureInfo.GetCultureInfo("vi-VN").NumberFormat) + "đ";
                Sp[i].GiaBan = double.Parse(CTSP[i].GiaBan.ToString()).ToString("#,###", CultureInfo.GetCultureInfo("vi-VN").NumberFormat) + "đ";
                Sp[i].TrangThai = CTSP[i].TrangThai == 0 ? "Đang Bán" : "Ngừng Bán";
                Sp[i].SoLuong = CTSP[i].SoLuongTon.ToString();
                Sp[i].APDungKM = CTSP[i].TrangThaiKhuyenMai == 0 ? "Đang áp dụng" : "Không áp dụng";
                Sp[i].TenHang = CTSP[i].TenSP + "-" + CTSP[i].TenMauSac;
                Sp[i].Anh1 = _IanhServices.GetAll().Find(x => x.IdChiTietSp == CTSP[i].Id && x.TenAnh == "Anh") != null ? Image.FromStream(new MemoryStream((byte[])_IanhServices.GetAll().Find(x => x.IdChiTietSp == CTSP[i].Id && x.TenAnh == "Anh").DuongDan)) : null;
                Sp[i].Barcode = _IanhServices.GetAll().Find(x => x.IdChiTietSp == CTSP[i].Id && x.TenAnh == "Anh") != null ? Image.FromStream(new MemoryStream((byte[])_IanhServices.GetAll().Find(x => x.IdChiTietSp == CTSP[i].Id && x.TenAnh == "Barcode").DuongDan)) : null;
                Sp[i].BaoHanh = CTSP[i].BaoHanh;
                Sp[i].GhiChu = CTSP[i].MoTa;
                
                var ctksp = _IChiTietKieuSpService.GetAll().Find(x => x.IdChiTietSp == CTSP[i].Id);
                if (ctksp != null)
                {
                    Sp[i].NhomHang = TenKsp(ctksp.IdKieuSp.GetValueOrDefault(), ctksp.TenKieuSP).Substring(0, TenKsp(ctksp.IdKieuSp.GetValueOrDefault(), ctksp.TenKieuSP).Length - 2);
                }
                Sp[i].Onclick += (ss, ee) =>
                {
                    var Obj = (ViewSP)ss;
                    if (NoCheck())
                    {
                        CbbThaoTac.Visible = false;
                    }else
                    {
                        CbbThaoTac.Visible = true;
                    }
                };
                Sp[i].TopLevel = false;
                Sp[i].FormBorderStyle = FormBorderStyle.None;
                Sp[i].Dock = DockStyle.Top;
                flowLayoutPanel1.Controls.Add(Sp[i]);
                Sp[i].BringToFront();
                Sp[i].Show();
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
        private void btnThem_Click(object sender, EventArgs e)
        {
            FrmThemSP sp = new FrmThemSP();
            sp.ShowDialog();
            txtSearch.Texts = "";
            flowLayoutPanel1.Controls.Clear();
            List<ChiTietSpViews> CTSP = _IChiTietSpServices.GetAll().OrderByDescending(X => X.MaQr).ToList();
            if (txtSearch.Texts.Trim() != "")
            {
                CTSP = _IChiTietSpServices.GetAll().Where(x => x.MaQr.ToLower().Contains(RemoveUnicode(txtSearch.Texts.ToLower())) || RemoveUnicode(x.TenSP.ToLower()).Contains(RemoveUnicode(txtSearch.Texts.ToLower()))).OrderByDescending(X => X.MaQr).OrderByDescending(X => X.MaQr.Length).ToList();
            }
            ViewSP[] Sp = new ViewSP[CTSP.Count];
            for (int i = 0; i < CTSP.Count; i++)
            {
                Sp[i] = new ViewSP();
                Sp[i].MauSac = CTSP[i].TenMauSac;
                Sp[i].ChatLieu = CTSP[i].TenChatLieu;
                Sp[i].Team = CTSP[i].TenTeam;
                Sp[i].Size = CTSP[i].Size;
                Sp[i].IDSP = CTSP[i].Id;
                Sp[i].MaHang = CTSP[i].MaQr;
                Sp[i].GiaNhap = double.Parse(CTSP[i].GiaNhap.ToString()).ToString("#,###", CultureInfo.GetCultureInfo("vi-VN").NumberFormat) + "đ";
                Sp[i].GiaBan = double.Parse(CTSP[i].GiaBan.ToString()).ToString("#,###", CultureInfo.GetCultureInfo("vi-VN").NumberFormat) + "đ";
                Sp[i].TrangThai = CTSP[i].TrangThai == 0 ? "Đang Bán" : "Ngừng Bán";
                Sp[i].SoLuong = CTSP[i].SoLuongTon.ToString();
                Sp[i].APDungKM = CTSP[i].TrangThaiKhuyenMai == 0 ? "Đang áp dụng" : "Không áp dụng";
                Sp[i].TenHang = CTSP[i].TenSP + "-" + CTSP[i].TenMauSac;
                Sp[i].Anh1 = _IanhServices.GetAll().Find(x => x.IdChiTietSp == CTSP[i].Id && x.TenAnh == "Anh") != null ? Image.FromStream(new MemoryStream((byte[])_IanhServices.GetAll().Find(x => x.IdChiTietSp == CTSP[i].Id && x.TenAnh == "Anh").DuongDan)) : null;
                Sp[i].Barcode = _IanhServices.GetAll().Find(x => x.IdChiTietSp == CTSP[i].Id && x.TenAnh == "Anh") != null ? Image.FromStream(new MemoryStream((byte[])_IanhServices.GetAll().Find(x => x.IdChiTietSp == CTSP[i].Id && x.TenAnh == "Barcode").DuongDan)) : null;
                Sp[i].BaoHanh = CTSP[i].BaoHanh;
                Sp[i].GhiChu = CTSP[i].MoTa;
                var ctksp = _IChiTietKieuSpService.GetAll().Find(x => x.IdChiTietSp == CTSP[i].Id);
                if (ctksp != null)
                {
                    Sp[i].NhomHang = TenKsp(ctksp.IdKieuSp.GetValueOrDefault(), ctksp.TenKieuSP).Substring(0, TenKsp(ctksp.IdKieuSp.GetValueOrDefault(), ctksp.TenKieuSP).Length - 2);
                }
                if (CheckCB.ContainsKey(Sp[i].IDSP))
                {
                    if (CheckCB[Sp[i].IDSP] == true)
                    {
                        Sp[i].ChBox.Checked = true;
                    }
                    else Sp[i].ChBox.Checked = false;
                }
                Sp[i].Onclick += (ss, ee) =>
                {
                    var Obj = (ViewSP)ss;
                    if (NoCheck())
                    {
                        CbbThaoTac.Visible = false;
                    }
                    else
                    {
                        CbbThaoTac.Visible = true;
                    }
                };
                Sp[i].TopLevel = false;
                Sp[i].FormBorderStyle = FormBorderStyle.None;
                Sp[i].Dock = DockStyle.Top;
                flowLayoutPanel1.Controls.Add(Sp[i]);
                Sp[i].BringToFront();
                Sp[i].Show();
            }
            btnHienThiTatCa.Visible = false;
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void rjTextBox1__TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Texts != "")
            {
                btnHienThiTatCa.Visible = true;
                flowLayoutPanel1.Controls.Clear();
                List<ChiTietSpViews> CTSP = _IChiTietSpServices.GetAll().OrderByDescending(X => X.MaQr).OrderByDescending(X => X.MaQr.Length).ToList();
                if (txtSearch.Texts.Trim() != "")
                {
                    CTSP = _IChiTietSpServices.GetAll().Where(x => x.MaQr.ToLower().Contains(RemoveUnicode(txtSearch.Texts.ToLower())) || RemoveUnicode(x.TenSP.ToLower()).Contains(RemoveUnicode(txtSearch.Texts.ToLower()))).OrderByDescending(X => X.MaQr).OrderByDescending(X => X.MaQr.Length).ToList();
                }
                ViewSP[] Sp = new ViewSP[CTSP.Count];
                for (int i = 0; i < CTSP.Count; i++)
                {
                    Sp[i] = new ViewSP();
                    Sp[i].MauSac = CTSP[i].TenMauSac;
                    Sp[i].ChatLieu = CTSP[i].TenChatLieu;
                    Sp[i].Team = CTSP[i].TenTeam;
                    Sp[i].Size = CTSP[i].Size;
                    Sp[i].IDSP = CTSP[i].Id;
                    Sp[i].MaHang = CTSP[i].MaQr;
                    Sp[i].GiaNhap = double.Parse(CTSP[i].GiaNhap.ToString()).ToString("#,###", CultureInfo.GetCultureInfo("vi-VN").NumberFormat) + "đ";
                    Sp[i].GiaBan = double.Parse(CTSP[i].GiaBan.ToString()).ToString("#,###", CultureInfo.GetCultureInfo("vi-VN").NumberFormat) + "đ";
                    Sp[i].TrangThai = CTSP[i].TrangThai == 0 ? "Đang Bán" : "Ngừng Bán";
                    Sp[i].SoLuong = CTSP[i].SoLuongTon.ToString();
                    Sp[i].APDungKM = CTSP[i].TrangThaiKhuyenMai == 0 ? "Đang áp dụng" : "Không áp dụng";
                    Sp[i].TenHang = CTSP[i].TenSP + "-" + CTSP[i].TenMauSac;
                    Sp[i].Anh1 = _IanhServices.GetAll().Find(x => x.IdChiTietSp == CTSP[i].Id && x.TenAnh == "Anh") != null ? Image.FromStream(new MemoryStream((byte[])_IanhServices.GetAll().Find(x => x.IdChiTietSp == CTSP[i].Id && x.TenAnh == "Anh").DuongDan)) : null;
                    Sp[i].Barcode = _IanhServices.GetAll().Find(x => x.IdChiTietSp == CTSP[i].Id && x.TenAnh == "Anh") != null ? Image.FromStream(new MemoryStream((byte[])_IanhServices.GetAll().Find(x => x.IdChiTietSp == CTSP[i].Id && x.TenAnh == "Barcode").DuongDan)) : null;
                    Sp[i].BaoHanh = CTSP[i].BaoHanh;
                    Sp[i].GhiChu = CTSP[i].MoTa;
                    var ctksp = _IChiTietKieuSpService.GetAll().Find(x => x.IdChiTietSp == CTSP[i].Id);
                    if (ctksp != null)
                    {
                        Sp[i].NhomHang = TenKsp(ctksp.IdKieuSp.GetValueOrDefault(), ctksp.TenKieuSP).Substring(0, TenKsp(ctksp.IdKieuSp.GetValueOrDefault(), ctksp.TenKieuSP).Length - 2);
                    }
                    if (CheckCB.ContainsKey(Sp[i].IDSP))
                    {
                        if (CheckCB[Sp[i].IDSP] == true)
                        {
                            Sp[i].ChBox.Checked = true;
                        }
                        else Sp[i].ChBox.Checked = false;
                    }
                    Sp[i].Onclick += (ss, ee) =>
                    {
                        var Obj = (ViewSP)ss;
                        if (NoCheck())
                        {
                            CbbThaoTac.Visible = false;
                        }
                        else
                        {
                            CbbThaoTac.Visible = true;
                        }
                    };
                    Sp[i].TopLevel = false;
                    Sp[i].FormBorderStyle = FormBorderStyle.None;
                    Sp[i].Dock = DockStyle.Top;
                    flowLayoutPanel1.Controls.Add(Sp[i]);
                    Sp[i].BringToFront();
                    Sp[i].Show();
                }
            }
            else
            {
                btnHienThiTatCa.Visible = true;
            }
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            txtSearch.Texts = "";
            flowLayoutPanel1.Controls.Clear();
            List<ChiTietSpViews> CTSP = _IChiTietSpServices.GetAll().OrderByDescending(X => X.MaQr).ToList();
            if (txtSearch.Texts.Trim() != "")
            {
                CTSP = _IChiTietSpServices.GetAll().Where(x => x.MaQr.ToLower().Contains(RemoveUnicode(txtSearch.Texts.ToLower())) || RemoveUnicode(x.TenSP.ToLower()).Contains(RemoveUnicode(txtSearch.Texts.ToLower()))).OrderByDescending(X => X.MaQr).OrderByDescending(X => X.MaQr.Length).ToList();
            }
            ViewSP[] Sp = new ViewSP[CTSP.Count];
            for (int i = 0; i < CTSP.Count; i++)
            {
                Sp[i] = new ViewSP();
                Sp[i].MauSac = CTSP[i].TenMauSac;
                Sp[i].ChatLieu = CTSP[i].TenChatLieu;
                Sp[i].Team = CTSP[i].TenTeam;
                Sp[i].Size = CTSP[i].Size;
                Sp[i].IDSP = CTSP[i].Id;
                Sp[i].MaHang = CTSP[i].MaQr;
                Sp[i].GiaNhap = double.Parse(CTSP[i].GiaNhap.ToString()).ToString("#,###", CultureInfo.GetCultureInfo("vi-VN").NumberFormat) + "đ";
                Sp[i].GiaBan = double.Parse(CTSP[i].GiaBan.ToString()).ToString("#,###", CultureInfo.GetCultureInfo("vi-VN").NumberFormat) + "đ";
                Sp[i].TrangThai = CTSP[i].TrangThai == 0 ? "Đang Bán" : "Ngừng Bán";
                Sp[i].SoLuong = CTSP[i].SoLuongTon.ToString();
                Sp[i].APDungKM = CTSP[i].TrangThaiKhuyenMai == 0 ? "Đang áp dụng" : "Không áp dụng";
                Sp[i].TenHang = CTSP[i].TenSP + "-" + CTSP[i].TenMauSac;
                Sp[i].Anh1 = _IanhServices.GetAll().Find(x => x.IdChiTietSp == CTSP[i].Id && x.TenAnh == "Anh") != null ? Image.FromStream(new MemoryStream((byte[])_IanhServices.GetAll().Find(x => x.IdChiTietSp == CTSP[i].Id && x.TenAnh == "Anh").DuongDan)) : null;
                Sp[i].Barcode = _IanhServices.GetAll().Find(x => x.IdChiTietSp == CTSP[i].Id && x.TenAnh == "Anh") != null ? Image.FromStream(new MemoryStream((byte[])_IanhServices.GetAll().Find(x => x.IdChiTietSp == CTSP[i].Id && x.TenAnh == "Barcode").DuongDan)) : null;
                Sp[i].BaoHanh = CTSP[i].BaoHanh;
                Sp[i].GhiChu = CTSP[i].MoTa;
                var ctksp = _IChiTietKieuSpService.GetAll().Find(x => x.IdChiTietSp == CTSP[i].Id);
                if (ctksp != null)
                {
                    Sp[i].NhomHang = TenKsp(ctksp.IdKieuSp.GetValueOrDefault(), ctksp.TenKieuSP).Substring(0, TenKsp(ctksp.IdKieuSp.GetValueOrDefault(), ctksp.TenKieuSP).Length - 2);
                }
                if (CheckCB.ContainsKey(Sp[i].IDSP))
                {
                    if (CheckCB[Sp[i].IDSP] == true)
                    {
                        Sp[i].ChBox.Checked = true;
                    }
                    else Sp[i].ChBox.Checked = false;
                }
                Sp[i].Onclick += (ss, ee) =>
                {
                    var Obj = (ViewSP)ss;
                    if (NoCheck())
                    {
                        CbbThaoTac.Visible = false;
                    }
                    else
                    {
                        CbbThaoTac.Visible = true;
                    }
                };
                Sp[i].TopLevel = false;
                Sp[i].FormBorderStyle = FormBorderStyle.None;
                Sp[i].Dock = DockStyle.Top;
                flowLayoutPanel1.Controls.Add(Sp[i]);
                Sp[i].BringToFront();
                Sp[i].Show();
            }
            btnHienThiTatCa.Visible = false;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            btnHienThiTatCa.Visible=false;
            flowLayoutPanel1.Controls.Clear();
            List<ChiTietSpViews> CTSP = _IChiTietSpServices.GetAll().OrderByDescending(X => X.MaQr).ToList();
            if (txtSearch.Texts.Trim() != "")
            {
                CTSP = _IChiTietSpServices.GetAll().Where(x => x.MaQr.ToLower().Contains(RemoveUnicode(txtSearch.Texts.ToLower())) || RemoveUnicode(x.TenSP.ToLower()).Contains(RemoveUnicode(txtSearch.Texts.ToLower()))).OrderByDescending(X => X.MaQr).OrderByDescending(X => X.MaQr.Length).ToList();
            }
            ViewSP[] Sp = new ViewSP[CTSP.Count];
            for (int i = 0; i < CTSP.Count; i++)
            {
                Sp[i] = new ViewSP();
                Sp[i].MauSac = CTSP[i].TenMauSac;
                Sp[i].ChatLieu = CTSP[i].TenChatLieu;
                Sp[i].Team = CTSP[i].TenTeam;
                Sp[i].Size = CTSP[i].Size;
                Sp[i].IDSP = CTSP[i].Id;
                Sp[i].MaHang = CTSP[i].MaQr;
                Sp[i].GiaNhap = double.Parse(CTSP[i].GiaNhap.ToString()).ToString("#,###", CultureInfo.GetCultureInfo("vi-VN").NumberFormat) + "đ";
                Sp[i].GiaBan = double.Parse(CTSP[i].GiaBan.ToString()).ToString("#,###", CultureInfo.GetCultureInfo("vi-VN").NumberFormat) + "đ";
                Sp[i].TrangThai = CTSP[i].TrangThai == 0 ? "Đang Bán" : "Ngừng Bán";
                Sp[i].SoLuong = CTSP[i].SoLuongTon.ToString();
                Sp[i].APDungKM = CTSP[i].TrangThaiKhuyenMai == 0 ? "Đang áp dụng" : "Không áp dụng";
                Sp[i].TenHang = CTSP[i].TenSP + "-" + CTSP[i].TenMauSac;
                Sp[i].Anh1 = _IanhServices.GetAll().Find(x => x.IdChiTietSp == CTSP[i].Id && x.TenAnh == "Anh") != null ? Image.FromStream(new MemoryStream((byte[])_IanhServices.GetAll().Find(x => x.IdChiTietSp == CTSP[i].Id && x.TenAnh == "Anh").DuongDan)) : null;
                Sp[i].Barcode = _IanhServices.GetAll().Find(x => x.IdChiTietSp == CTSP[i].Id && x.TenAnh == "Anh") != null ? Image.FromStream(new MemoryStream((byte[])_IanhServices.GetAll().Find(x => x.IdChiTietSp == CTSP[i].Id && x.TenAnh == "Barcode").DuongDan)) : null;
                Sp[i].BaoHanh = CTSP[i].BaoHanh;
                Sp[i].GhiChu = CTSP[i].MoTa;
                var ctksp = _IChiTietKieuSpService.GetAll().Find(x => x.IdChiTietSp == CTSP[i].Id);
                if (ctksp != null)
                {
                    Sp[i].NhomHang = TenKsp(ctksp.IdKieuSp.GetValueOrDefault(), ctksp.TenKieuSP).Substring(0, TenKsp(ctksp.IdKieuSp.GetValueOrDefault(), ctksp.TenKieuSP).Length - 2);
                }
                if (checkBox1.Checked)
                {
                    Sp[i].ChBox.Checked = true;
                    CbbThaoTac.Visible = true;
                }else
                {
                    if (CheckCB.ContainsKey(CTSP[i].Id))
                    {
                        CheckCB[CTSP[i].Id] = false;
                    }
                    else
                    {
                        CheckCB.Add(CTSP[i].Id, false);
                       
                    }
                    CbbThaoTac.Visible = false;
                }
                Sp[i].Onclick += (ss, ee) =>
                {
                    var Obj = (ViewSP)ss;
                    if (NoCheck())
                    {
                        CbbThaoTac.Visible = false;
                    }
                    else
                    {
                        CbbThaoTac.Visible = true;
                    }
                };
                Sp[i].TopLevel = false;
                Sp[i].FormBorderStyle = FormBorderStyle.None;
                Sp[i].Dock = DockStyle.Top;
                flowLayoutPanel1.Controls.Add(Sp[i]);
                Sp[i].BringToFront();
                Sp[i].Show();
            }
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
    }
}
