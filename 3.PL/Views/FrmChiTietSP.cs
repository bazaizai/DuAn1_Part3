using _2.BUS.IServices;
using _2.BUS.Services;
using _2.BUS.ViewModels;
using _3.PL.Components;
using _3.PL.CustomControlls;
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
        IMauSacServices _IMauSacServices;
        IChatLieuServices _IChatLieuServices;
        IKichCoServices _IKichCoServices;
        CheckBox box;
        public static List<ChiTietSpViews> _ListAll;
        private Dictionary<string, bool> _LstMauSac;
        private Dictionary<string, bool> _LstChatLieu;
        private Dictionary<string, bool> _LstNhomHang;
        private Dictionary<string, bool> _LstSize;


        public static Dictionary<Guid, bool> CheckCB;

        private int ShowSL;
        private int ShowTT;
        private int ShowCL;
        private int ShowMS;
        private int x;
        public int Count { get => x; set { x = value; x = value; } }

        public FrmChiTietSP()
        {
            InitializeComponent();
            CheckCB = new Dictionary<Guid, bool>();
            _LstMauSac = new Dictionary<string, bool>();
            _LstChatLieu = new Dictionary<string, bool>();
            _LstSize = new Dictionary<string, bool>();
            _IChiTietSpServices = new ChiTietSpServices();
            _IanhServices = new AnhServices();
            _IKieuSpServices = new KieuSpServices();
            _IChiTietKieuSpService = new ChiTietKieuSpServices();
            _IMauSacServices = new MauSacServices();
            _IChatLieuServices = new ChatLieuServices();
            _IKichCoServices = new KichCoServices();
            _ListAll = new List<ChiTietSpViews>();
            _ListAll = _IChiTietSpServices.GetAll().OrderByDescending(x => x.MaQr).OrderByDescending(x=>x.MaQr.Length).OrderByDescending(x => x.MaQr).OrderByDescending(x=>x.MaQr.Length).ToList();
            LoadMauSac();
            LoadChatLieu();
            LoadSize();
            rdoTatCa.Checked = true;
            x = 1;
            ShowCL = 0;
            ShowSL = 0;
            ShowTT = 0;
            ShowMS = 0;
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

        private bool HopThoai(int count) => RJMessageBox.Show("Bạn có muốn thực hiện hành động này với " + count.ToString() + " sản phẩm đã chọn không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes;
        private void CbbThaoTac_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            if (HopThoai(CheckCB.Where(x => x.Value == true).ToList().Count))
            {
                foreach (var x in CheckCB.Where(x => x.Value == true))
                {
                    var sp = _IChiTietSpServices.GetById(x.Key);
                    if (CbbThaoTac.Texts == "Áp dụng KM")
                    {
                        sp.TrangThaiKhuyenMai = 0;
                    }
                    if (CbbThaoTac.Texts == "Không áp dụng KM")
                    {
                        sp.TrangThaiKhuyenMai = 1;
                    }
                    if (CbbThaoTac.Texts == "Ngừng bán")
                    {
                        sp.TrangThai = 1;
                    }
                    if (CbbThaoTac.Texts == "Mở bán")
                    {
                        sp.TrangThai = 0;
                    }
                    _IChiTietSpServices.Update(sp);
                }
                CheckCB = new Dictionary<Guid, bool>();
                checkBox1.Checked = false;
                CbbThaoTac.Visible = false;
                _IChiTietSpServices = new ChiTietSpServices();
                LoadData();
            }
            else
            {
                LoadCbb();
            }



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
            GetListSP();
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
            CheckCB = new Dictionary<Guid, bool>();
            _LstMauSac = new Dictionary<string, bool>();
            _LstChatLieu = new Dictionary<string, bool>();
            _LstSize = new Dictionary<string, bool>();
            _IChiTietSpServices = new ChiTietSpServices();
            _IanhServices = new AnhServices();
            _IKieuSpServices = new KieuSpServices();
            _IChiTietKieuSpService = new ChiTietKieuSpServices();
            _IMauSacServices = new MauSacServices();
            _IChatLieuServices = new ChatLieuServices();
            _IKichCoServices = new KichCoServices();
            _ListAll = new List<ChiTietSpViews>();
            _ListAll = _IChiTietSpServices.GetAll().OrderByDescending(x => x.MaQr).OrderByDescending(x => x.MaQr.Length).OrderByDescending(x => x.MaQr).OrderByDescending(x => x.MaQr.Length).ToList();
            LoadMauSac();
            LoadChatLieu();
            LoadSize();
            rdoTatCa.Checked = true;
            x = 1;
            ShowCL = 0;
            ShowSL = 0;
            ShowTT = 0;
            ShowMS = 0;
            LoadData();
            GetListSP();
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void rjTextBox1__TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Texts != "")
            {
                GetListSP();
            }
            else
            {
                btnHienThiTatCa.Visible = true;
            }
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            txtSearch.Texts = "";
            GetListSP();
            btnHienThiTatCa.Visible = false;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            btnHienThiTatCa.Visible = false;
            GetListSP();
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

        private void rjButton1_Click_2(object sender, EventArgs e)
        {
            ShowSL++;
            if (ShowSL % 2 == 1)
            {
                pnlbodySoLuongTon.Visible = false;
                BtnShowSL.Text = "Show";
            }
            else
            {
                pnlbodySoLuongTon.Visible = true;
                BtnShowSL.Text = "Hide";
            }
        }

        private void rjButton2_Click(object sender, EventArgs e)
        {
            ShowTT++;
            if (ShowTT % 2 == 1)
            {
                pnlBodyTrangThai.Visible = false;
                BtnShowTT.Text = "Show";
            }
            else
            {
                pnlBodyTrangThai.Visible = true;
                BtnShowTT.Text = "Hide";
            }
        }

        private void chkTatCa_CheckedChanged(object sender, EventArgs e)
        {
            chkDangBan.Checked = false;
            chkNgungBan.Checked = false;
        }

        private void chkDangBan_CheckedChanged(object sender, EventArgs e)
        {
            chkNgungBan.Checked = false;
            GetListSP();
        }

        private void chkNgungBan_CheckedChanged(object sender, EventArgs e)
        {
            chkDangBan.Checked = false;
            GetListSP();
        }
        private void LoadMauSac()
        {
            PnlMauSac.Controls.Clear();
            _LstMauSac.Clear();
            for (int i = 0; i < _IMauSacServices.GetAll().Where(x => x.TrangThai == 0).ToList().Count; i++)
            {
                box = new CheckBox();
                box.Text = _IMauSacServices.GetAll().Where(x => x.TrangThai == 0).ToList()[i].Ten;
                _LstMauSac.Add(box.Text, true);
                box.Dock = DockStyle.Top;
                box.Padding = new Padding(0, 5, 0, 0);
                box.AutoSize = true;
                box.Checked = true;
                PnlMauSac.Controls.Add(box);
                box.CheckedChanged += new EventHandler(CheckBoxClickMS);
            }
        }

        private void CheckBoxClickMS(object sender, EventArgs e)
        {
            CheckBox item = (CheckBox)sender;
            if (item.Checked)
            {
                _LstMauSac[item.Text] = true;
            }
            else
            {
                _LstMauSac[item.Text] = false;
            }
            GetListSP();
        }

        private void CheckBoxClickCL(object sender, EventArgs e)
        {
            CheckBox item = (CheckBox)sender;
            if (item.Checked)
            {
                _LstChatLieu[item.Text] = true;
            }
            else
            {
                _LstChatLieu[item.Text] = false;
            }
            GetListSP();
        }
        private void CheckBoxClickSize(object sender, EventArgs e)
        {
            CheckBox item = (CheckBox)sender;
            if (item.Checked)
            {
                _LstSize[item.Text] = true;
            }
            else
            {
                _LstSize[item.Text] = false;
            }
            GetListSP();
        }

        private void LoadChatLieu()
        {
            pnlChatLieu.Controls.Clear();
            _LstChatLieu.Clear();
            for (int i = 0; i < _IChatLieuServices.GetAll().Where(x => x.TrangThai == 0).ToList().Count; i++)
            {
                box = new CheckBox();
                box.Text = _IChatLieuServices.GetAll().Where(x => x.TrangThai == 0).ToList()[i].Ten;
                _LstChatLieu.Add(box.Text, true);
                box.Dock = DockStyle.Top;
                box.Padding = new Padding(0, 5, 0, 0);
                box.AutoSize = true;
                box.Checked = true;
                pnlChatLieu.Controls.Add(box);
                box.CheckedChanged += new EventHandler(CheckBoxClickCL);
            }
        }

        private void LoadSize()
        {
            pnlSize.Controls.Clear();
            _LstSize.Clear();
            for (int i = 0; i < _IKichCoServices.GetAll().Where(x => x.TrangThai == 0).ToList().Count; i++)
            {
                box = new CheckBox();
                box.Text = _IKichCoServices.GetAll().Where(x => x.TrangThai == 0).ToList()[i].Size;
                _LstSize.Add(box.Text, true);
                box.Dock = DockStyle.Top;
                box.Padding = new Padding(0, 5, 0, 0);
                box.AutoSize = true;
                box.Checked = true;
                pnlSize.Controls.Add(box);
                box.CheckedChanged += new EventHandler(CheckBoxClickSize);
            }
        }

        private void rjButton1_Click_1(object sender, EventArgs e)
        {
            ShowMS++;
            if (ShowMS % 2 == 1)
            {
                pnlBodyMS.Visible = false;
                BtnShowMS.Text = "Show";
            }
            else
            {
                pnlBodyMS.Visible = true;
                BtnShowMS.Text = "Hide";
            }
        }

        private void rjButton2_Click_1(object sender, EventArgs e)
        {
            ShowCL++;
            if (ShowCL % 2 == 1)
            {
                pnlbdchatLieu.Visible = false;
                btnShowChatLieu.Text = "Show";
            }
            else
            {
                pnlbdchatLieu.Visible = true;
                btnShowChatLieu.Text = "Hide";
            }

        }

        private void rdoTatCa_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoTatCa.Checked)
            {
                GetListSP();
            }
        }

        private void rdoConHang_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoConHang.Checked)
            {
                GetListSP();
            }
        }

        private void GetListSP()
        {
            _IChiTietSpServices = new ChiTietSpServices();
            _IanhServices = new AnhServices();
            _IKieuSpServices = new KieuSpServices();
            _IChiTietKieuSpService = new ChiTietKieuSpServices();
            _IMauSacServices = new MauSacServices();
            _IChatLieuServices = new ChatLieuServices();
            _IKichCoServices = new KichCoServices();
            _ListAll = new List<ChiTietSpViews>();
            _ListAll = _IChiTietSpServices.GetAll().OrderByDescending(x => x.MaQr).OrderByDescending(x => x.MaQr.Length).OrderByDescending(x => x.MaQr).OrderByDescending(x => x.MaQr.Length).ToList();
            if (rdoTatCa.Checked)
            {
                if (!chkDangBan.Checked && !chkNgungBan.Checked)
                {
                    if (!chkApDung.Checked && !chkKhongApDung.Checked)
                    {
                        _ListAll = _IChiTietSpServices.GetAll().OrderByDescending(x => x.MaQr).OrderByDescending(x=>x.MaQr.Length).Where(ms => _LstMauSac.Where(x => x.Value == true).Any(Lms => Lms.Key == ms.TenMauSac)).ToList();
                        _ListAll = _ListAll.Where(x => _LstChatLieu.Where(x => x.Value == true).Any(lcl => lcl.Key == x.TenChatLieu)).ToList();
                        _ListAll = _ListAll.Where(x => _LstSize.Where(x => x.Value == true).Any(lcl => lcl.Key == x.Size)).ToList();
                    }
                    else if (chkApDung.Checked)
                    {
                        _ListAll = _IChiTietSpServices.GetAll().OrderByDescending(x => x.MaQr).OrderByDescending(x=>x.MaQr.Length).Where(x => x.TrangThaiKhuyenMai == 0).ToList();
                        _ListAll = _ListAll.Where(ms => _LstMauSac.Where(x => x.Value == true).Any(Lms => Lms.Key == ms.TenMauSac)).ToList();
                        _ListAll = _ListAll.Where(x => _LstChatLieu.Where(x => x.Value == true).Any(lcl => lcl.Key == x.TenChatLieu)).ToList();
                        _ListAll = _ListAll.Where(x => _LstSize.Where(x => x.Value == true).Any(lcl => lcl.Key == x.Size)).ToList();
                    }
                    else
                    {
                        _ListAll = _IChiTietSpServices.GetAll().OrderByDescending(x => x.MaQr).OrderByDescending(x=>x.MaQr.Length).Where(x => x.TrangThaiKhuyenMai == 1).ToList();
                        _ListAll = _ListAll.Where(ms => _LstMauSac.Where(x => x.Value == true).Any(Lms => Lms.Key == ms.TenMauSac)).ToList();
                        _ListAll = _ListAll.Where(x => _LstChatLieu.Where(x => x.Value == true).Any(lcl => lcl.Key == x.TenChatLieu)).ToList();
                        _ListAll = _ListAll.Where(x => _LstSize.Where(x => x.Value == true).Any(lcl => lcl.Key == x.Size)).ToList();
                    }
                }
                else if (chkDangBan.Checked)
                {
                    _ListAll = _IChiTietSpServices.GetAll().OrderByDescending(x => x.MaQr).OrderByDescending(x=>x.MaQr.Length).Where(x => x.TrangThai == 0).ToList();
                    if (!chkApDung.Checked && !chkKhongApDung.Checked)
                    {
                        _ListAll = _ListAll.Where(ms => _LstMauSac.Where(x => x.Value == true).Any(Lms => Lms.Key == ms.TenMauSac)).ToList();
                        _ListAll = _ListAll.Where(x => _LstChatLieu.Where(x => x.Value == true).Any(lcl => lcl.Key == x.TenChatLieu)).ToList();
                        _ListAll = _ListAll.Where(x => _LstSize.Where(x => x.Value == true).Any(lcl => lcl.Key == x.Size)).ToList();
                    }
                    else if (chkApDung.Checked)
                    {
                        _ListAll = _ListAll.Where(x => x.TrangThaiKhuyenMai == 0).ToList();
                        _ListAll = _ListAll.Where(ms => _LstMauSac.Where(x => x.Value == true).Any(Lms => Lms.Key == ms.TenMauSac)).ToList();
                        _ListAll = _ListAll.Where(x => _LstChatLieu.Where(x => x.Value == true).Any(lcl => lcl.Key == x.TenChatLieu)).ToList();
                        _ListAll = _ListAll.Where(x => _LstSize.Where(x => x.Value == true).Any(lcl => lcl.Key == x.Size)).ToList();
                    }
                    else
                    {
                        _ListAll = _ListAll.Where(x => x.TrangThaiKhuyenMai == 1).ToList();
                        _ListAll = _ListAll.Where(ms => _LstMauSac.Where(x => x.Value == true).Any(Lms => Lms.Key == ms.TenMauSac)).ToList();
                        _ListAll = _ListAll.Where(x => _LstChatLieu.Where(x => x.Value == true).Any(lcl => lcl.Key == x.TenChatLieu)).ToList();
                        _ListAll = _ListAll.Where(x => _LstSize.Where(x => x.Value == true).Any(lcl => lcl.Key == x.Size)).ToList();
                    }
                }
                else
                {
                    _ListAll = _IChiTietSpServices.GetAll().OrderByDescending(x => x.MaQr).OrderByDescending(x=>x.MaQr.Length).Where(x => x.TrangThai == 1).ToList();
                    if (!chkApDung.Checked && !chkKhongApDung.Checked)
                    {
                        _ListAll = _ListAll.Where(ms => _LstMauSac.Where(x => x.Value == true).Any(Lms => Lms.Key == ms.TenMauSac)).ToList();
                        _ListAll = _ListAll.Where(x => _LstChatLieu.Where(x => x.Value == true).Any(lcl => lcl.Key == x.TenChatLieu)).ToList();
                        _ListAll = _ListAll.Where(x => _LstSize.Where(x => x.Value == true).Any(lcl => lcl.Key == x.Size)).ToList();
                    }
                    else if (chkApDung.Checked)
                    {
                        _ListAll = _ListAll.Where(x => x.TrangThaiKhuyenMai == 0).ToList();
                        _ListAll = _ListAll.Where(ms => _LstMauSac.Where(x => x.Value == true).Any(Lms => Lms.Key == ms.TenMauSac)).ToList();
                        _ListAll = _ListAll.Where(x => _LstChatLieu.Where(x => x.Value == true).Any(lcl => lcl.Key == x.TenChatLieu)).ToList();
                        _ListAll = _ListAll.Where(x => _LstSize.Where(x => x.Value == true).Any(lcl => lcl.Key == x.Size)).ToList();
                    }
                    else
                    {
                        _ListAll = _ListAll.Where(x => x.TrangThaiKhuyenMai == 1).ToList();
                        _ListAll = _ListAll.Where(ms => _LstMauSac.Where(x => x.Value == true).Any(Lms => Lms.Key == ms.TenMauSac)).ToList();
                        _ListAll = _ListAll.Where(x => _LstChatLieu.Where(x => x.Value == true).Any(lcl => lcl.Key == x.TenChatLieu)).ToList();
                        _ListAll = _ListAll.Where(x => _LstSize.Where(x => x.Value == true).Any(lcl => lcl.Key == x.Size)).ToList();
                    }
                }

            }
            else if (rdoConHang.Checked)
            {
                _ListAll = _IChiTietSpServices.GetAll().OrderByDescending(x => x.MaQr).OrderByDescending(x=>x.MaQr.Length).Where(x => x.SoLuongTon > 0).ToList();
                if (!chkDangBan.Checked && !chkNgungBan.Checked)
                {
                    if (!chkApDung.Checked && !chkKhongApDung.Checked)
                    {
                        _ListAll = _ListAll.Where(ms => _LstMauSac.Where(x => x.Value == true).Any(Lms => Lms.Key == ms.TenMauSac)).ToList();
                        _ListAll = _ListAll.Where(x => _LstChatLieu.Where(x => x.Value == true).Any(lcl => lcl.Key == x.TenChatLieu)).ToList();
                        _ListAll = _ListAll.Where(x => _LstSize.Where(x => x.Value == true).Any(lcl => lcl.Key == x.Size)).ToList();
                    }
                    else if (chkApDung.Checked)
                    {
                        _ListAll = _ListAll.Where(x => x.TrangThaiKhuyenMai == 0).ToList();
                        _ListAll = _IChiTietSpServices.GetAll().OrderByDescending(x => x.MaQr).OrderByDescending(x=>x.MaQr.Length).Where(ms => _LstMauSac.Where(x => x.Value == true).Any(Lms => Lms.Key == ms.TenMauSac)).ToList();
                        _ListAll = _ListAll.Where(x => _LstChatLieu.Where(x => x.Value == true).Any(lcl => lcl.Key == x.TenChatLieu)).ToList();
                        _ListAll = _ListAll.Where(x => _LstSize.Where(x => x.Value == true).Any(lcl => lcl.Key == x.Size)).ToList();
                    }
                    else
                    {
                        _ListAll = _ListAll.Where(x => x.TrangThaiKhuyenMai == 1).ToList();
                        _ListAll = _IChiTietSpServices.GetAll().OrderByDescending(x => x.MaQr).OrderByDescending(x=>x.MaQr.Length).Where(ms => _LstMauSac.Where(x => x.Value == true).Any(Lms => Lms.Key == ms.TenMauSac)).ToList();
                        _ListAll = _ListAll.Where(x => _LstChatLieu.Where(x => x.Value == true).Any(lcl => lcl.Key == x.TenChatLieu)).ToList();
                        _ListAll = _ListAll.Where(x => _LstSize.Where(x => x.Value == true).Any(lcl => lcl.Key == x.Size)).ToList();
                    }
                }else if (chkDangBan.Checked)
                {
                    _ListAll = _ListAll.Where(x => x.TrangThai == 0).ToList();
                    if (!chkApDung.Checked && !chkKhongApDung.Checked)
                    {
                        _ListAll = _ListAll.Where(ms => _LstMauSac.Where(x => x.Value == true).Any(Lms => Lms.Key == ms.TenMauSac)).ToList();
                        _ListAll = _ListAll.Where(x => _LstChatLieu.Where(x => x.Value == true).Any(lcl => lcl.Key == x.TenChatLieu)).ToList();
                        _ListAll = _ListAll.Where(x => _LstSize.Where(x => x.Value == true).Any(lcl => lcl.Key == x.Size)).ToList();
                    }
                    else if (chkApDung.Checked)
                    {
                        _ListAll = _ListAll.Where(x => x.TrangThaiKhuyenMai == 0).ToList();
                        _ListAll = _IChiTietSpServices.GetAll().OrderByDescending(x => x.MaQr).OrderByDescending(x=>x.MaQr.Length).Where(ms => _LstMauSac.Where(x => x.Value == true).Any(Lms => Lms.Key == ms.TenMauSac)).ToList();
                        _ListAll = _ListAll.Where(x => _LstChatLieu.Where(x => x.Value == true).Any(lcl => lcl.Key == x.TenChatLieu)).ToList();
                        _ListAll = _ListAll.Where(x => _LstSize.Where(x => x.Value == true).Any(lcl => lcl.Key == x.Size)).ToList();
                    }
                    else
                    {
                        _ListAll = _ListAll.Where(x => x.TrangThaiKhuyenMai == 1).ToList();
                        _ListAll = _IChiTietSpServices.GetAll().OrderByDescending(x => x.MaQr).OrderByDescending(x=>x.MaQr.Length).Where(ms => _LstMauSac.Where(x => x.Value == true).Any(Lms => Lms.Key == ms.TenMauSac)).ToList();
                        _ListAll = _ListAll.Where(x => _LstChatLieu.Where(x => x.Value == true).Any(lcl => lcl.Key == x.TenChatLieu)).ToList();
                        _ListAll = _ListAll.Where(x => _LstSize.Where(x => x.Value == true).Any(lcl => lcl.Key == x.Size)).ToList();
                    }
                }else
                {
                    _ListAll = _ListAll.Where(x => x.TrangThai == 1).ToList();
                    if (!chkApDung.Checked && !chkKhongApDung.Checked)
                    {
                        _ListAll = _ListAll.Where(ms => _LstMauSac.Where(x => x.Value == true).Any(Lms => Lms.Key == ms.TenMauSac)).ToList();
                        _ListAll = _ListAll.Where(x => _LstChatLieu.Where(x => x.Value == true).Any(lcl => lcl.Key == x.TenChatLieu)).ToList();
                        _ListAll = _ListAll.Where(x => _LstSize.Where(x => x.Value == true).Any(lcl => lcl.Key == x.Size)).ToList();
                    }
                    else if (chkApDung.Checked)
                    {
                        _ListAll = _ListAll.Where(x => x.TrangThaiKhuyenMai == 0).ToList();
                        _ListAll = _IChiTietSpServices.GetAll().OrderByDescending(x => x.MaQr).OrderByDescending(x=>x.MaQr.Length).Where(ms => _LstMauSac.Where(x => x.Value == true).Any(Lms => Lms.Key == ms.TenMauSac)).ToList();
                        _ListAll = _ListAll.Where(x => _LstChatLieu.Where(x => x.Value == true).Any(lcl => lcl.Key == x.TenChatLieu)).ToList();
                        _ListAll = _ListAll.Where(x => _LstSize.Where(x => x.Value == true).Any(lcl => lcl.Key == x.Size)).ToList();
                    }
                    else
                    {
                        _ListAll = _ListAll.Where(x => x.TrangThaiKhuyenMai == 1).ToList();
                        _ListAll = _IChiTietSpServices.GetAll().OrderByDescending(x => x.MaQr).OrderByDescending(x=>x.MaQr.Length).Where(ms => _LstMauSac.Where(x => x.Value == true).Any(Lms => Lms.Key == ms.TenMauSac)).ToList();
                        _ListAll = _ListAll.Where(x => _LstChatLieu.Where(x => x.Value == true).Any(lcl => lcl.Key == x.TenChatLieu)).ToList();
                        _ListAll = _ListAll.Where(x => _LstSize.Where(x => x.Value == true).Any(lcl => lcl.Key == x.Size)).ToList();
                    }
                }
            }
            else
            {
                _ListAll = _IChiTietSpServices.GetAll().OrderByDescending(x => x.MaQr).OrderByDescending(x=>x.MaQr.Length).Where(x => x.SoLuongTon == 0).ToList();
                if (!chkDangBan.Checked && !chkNgungBan.Checked)
                {
                    if (!chkApDung.Checked && !chkKhongApDung.Checked)
                    {
                        _ListAll = _ListAll.Where(ms => _LstMauSac.Where(x => x.Value == true).Any(Lms => Lms.Key == ms.TenMauSac)).ToList();
                        _ListAll = _ListAll.Where(x => _LstChatLieu.Where(x => x.Value == true).Any(lcl => lcl.Key == x.TenChatLieu)).ToList();
                        _ListAll = _ListAll.Where(x => _LstSize.Where(x => x.Value == true).Any(lcl => lcl.Key == x.Size)).ToList();
                    }
                    else if (chkApDung.Checked)
                    {
                        _ListAll = _ListAll.Where(x => x.TrangThaiKhuyenMai == 0).ToList();
                        _ListAll = _IChiTietSpServices.GetAll().OrderByDescending(x => x.MaQr).OrderByDescending(x=>x.MaQr.Length).Where(ms => _LstMauSac.Where(x => x.Value == true).Any(Lms => Lms.Key == ms.TenMauSac)).ToList();
                        _ListAll = _ListAll.Where(x => _LstChatLieu.Where(x => x.Value == true).Any(lcl => lcl.Key == x.TenChatLieu)).ToList();
                        _ListAll = _ListAll.Where(x => _LstSize.Where(x => x.Value == true).Any(lcl => lcl.Key == x.Size)).ToList();
                    }
                    else
                    {
                        _ListAll = _ListAll.Where(x => x.TrangThaiKhuyenMai == 1).ToList();
                        _ListAll = _IChiTietSpServices.GetAll().OrderByDescending(x => x.MaQr).OrderByDescending(x=>x.MaQr.Length).Where(ms => _LstMauSac.Where(x => x.Value == true).Any(Lms => Lms.Key == ms.TenMauSac)).ToList();
                        _ListAll = _ListAll.Where(x => _LstChatLieu.Where(x => x.Value == true).Any(lcl => lcl.Key == x.TenChatLieu)).ToList();
                        _ListAll = _ListAll.Where(x => _LstSize.Where(x => x.Value == true).Any(lcl => lcl.Key == x.Size)).ToList();
                    }
                }
                else if (chkDangBan.Checked)
                {
                    _ListAll = _ListAll.Where(x => x.TrangThai == 0).ToList();
                    if (!chkApDung.Checked && !chkKhongApDung.Checked)
                    {
                        _ListAll = _ListAll.Where(ms => _LstMauSac.Where(x => x.Value == true).Any(Lms => Lms.Key == ms.TenMauSac)).ToList();
                        _ListAll = _ListAll.Where(x => _LstChatLieu.Where(x => x.Value == true).Any(lcl => lcl.Key == x.TenChatLieu)).ToList();
                        _ListAll = _ListAll.Where(x => _LstSize.Where(x => x.Value == true).Any(lcl => lcl.Key == x.Size)).ToList();
                    }
                    else if (chkApDung.Checked)
                    {
                        _ListAll = _ListAll.Where(x => x.TrangThaiKhuyenMai == 0).ToList();
                        _ListAll = _IChiTietSpServices.GetAll().OrderByDescending(x => x.MaQr).OrderByDescending(x=>x.MaQr.Length).Where(ms => _LstMauSac.Where(x => x.Value == true).Any(Lms => Lms.Key == ms.TenMauSac)).ToList();
                        _ListAll = _ListAll.Where(x => _LstChatLieu.Where(x => x.Value == true).Any(lcl => lcl.Key == x.TenChatLieu)).ToList();
                        _ListAll = _ListAll.Where(x => _LstSize.Where(x => x.Value == true).Any(lcl => lcl.Key == x.Size)).ToList();
                    }
                    else
                    {
                        _ListAll = _ListAll.Where(x => x.TrangThaiKhuyenMai == 1).ToList();
                        _ListAll = _IChiTietSpServices.GetAll().OrderByDescending(x => x.MaQr).OrderByDescending(x=>x.MaQr.Length).Where(ms => _LstMauSac.Where(x => x.Value == true).Any(Lms => Lms.Key == ms.TenMauSac)).ToList();
                        _ListAll = _ListAll.Where(x => _LstChatLieu.Where(x => x.Value == true).Any(lcl => lcl.Key == x.TenChatLieu)).ToList();
                        _ListAll = _ListAll.Where(x => _LstSize.Where(x => x.Value == true).Any(lcl => lcl.Key == x.Size)).ToList();
                    }
                }
                else
                {
                    _ListAll = _ListAll.Where(x => x.TrangThai == 1).ToList();
                    if (!chkApDung.Checked && !chkKhongApDung.Checked)
                    {
                        _ListAll = _ListAll.Where(ms => _LstMauSac.Where(x => x.Value == true).Any(Lms => Lms.Key == ms.TenMauSac)).ToList();
                        _ListAll = _ListAll.Where(x => _LstChatLieu.Where(x => x.Value == true).Any(lcl => lcl.Key == x.TenChatLieu)).ToList();
                        _ListAll = _ListAll.Where(x => _LstSize.Where(x => x.Value == true).Any(lcl => lcl.Key == x.Size)).ToList();
                    }
                    else if (chkApDung.Checked)
                    {
                        _ListAll = _ListAll.Where(x => x.TrangThaiKhuyenMai == 0).ToList();
                        _ListAll = _IChiTietSpServices.GetAll().OrderByDescending(x => x.MaQr).OrderByDescending(x=>x.MaQr.Length).Where(ms => _LstMauSac.Where(x => x.Value == true).Any(Lms => Lms.Key == ms.TenMauSac)).ToList();
                        _ListAll = _ListAll.Where(x => _LstChatLieu.Where(x => x.Value == true).Any(lcl => lcl.Key == x.TenChatLieu)).ToList();
                        _ListAll = _ListAll.Where(x => _LstSize.Where(x => x.Value == true).Any(lcl => lcl.Key == x.Size)).ToList();
                    }
                    else
                    {
                        _ListAll = _ListAll.Where(x => x.TrangThaiKhuyenMai == 1).ToList();
                        _ListAll = _IChiTietSpServices.GetAll().OrderByDescending(x => x.MaQr).OrderByDescending(x=>x.MaQr.Length).Where(ms => _LstMauSac.Where(x => x.Value == true).Any(Lms => Lms.Key == ms.TenMauSac)).ToList();
                        _ListAll = _ListAll.Where(x => _LstChatLieu.Where(x => x.Value == true).Any(lcl => lcl.Key == x.TenChatLieu)).ToList();
                        _ListAll = _ListAll.Where(x => _LstSize.Where(x => x.Value == true).Any(lcl => lcl.Key == x.Size)).ToList();
                    }
                }
            }

            flowLayoutPanel1.Controls.Clear();
            if (txtSearch.Texts.Trim() != "")
            {
                _ListAll = _ListAll.Where(x => x.MaQr.ToLower().Contains(RemoveUnicode(txtSearch.Texts.ToLower())) || RemoveUnicode(x.TenSP.ToLower()).Contains(RemoveUnicode(txtSearch.Texts.ToLower()))).OrderByDescending(X => X.MaQr).OrderByDescending(X => X.MaQr.Length).ToList();
            }
            ViewSP[] Sp = new ViewSP[_ListAll.Count];
            for (int i = 0; i < _ListAll.Count; i++)
            {
                Sp[i] = new ViewSP();
                Sp[i].MauSac = _ListAll[i].TenMauSac;
                Sp[i].ChatLieu = _ListAll[i].TenChatLieu;
                Sp[i].Team = _ListAll[i].TenTeam;
                Sp[i].Size = _ListAll[i].Size;
                Sp[i].IDSP = _ListAll[i].Id;
                Sp[i].MaHang = _ListAll[i].MaQr;
                Sp[i].GiaNhap = double.Parse(_ListAll[i].GiaNhap.ToString()).ToString("#,###", CultureInfo.GetCultureInfo("vi-VN").NumberFormat) + "đ";
                Sp[i].GiaBan = double.Parse(_ListAll[i].GiaBan.ToString()).ToString("#,###", CultureInfo.GetCultureInfo("vi-VN").NumberFormat) + "đ";
                Sp[i].TrangThai = _ListAll[i].TrangThai == 0 ? "Đang Bán" : "Ngừng Bán";
                Sp[i].SoLuong = _ListAll[i].SoLuongTon.ToString();
                Sp[i].APDungKM = _ListAll[i].TrangThaiKhuyenMai == 0 ? "Đang áp dụng" : "Không áp dụng";
                Sp[i].TenHang = _ListAll[i].TenSP + "-" + _ListAll[i].Size;
                Sp[i].TenHang1 = _ListAll[i].TenSP + "-" + _ListAll[i].Size;
                if (Sp[i].TenHang.Length > 28)
                {
                    Sp[i].TenHang = Sp[i].TenHang.Substring(0, 28);
                }
                Sp[i].Anh1 = _IanhServices.GetAll().Find(x => x.IdChiTietSp == _ListAll[i].Id && x.TenAnh == "Anh") != null ? Image.FromStream(new MemoryStream((byte[])_IanhServices.GetAll().Find(x => x.IdChiTietSp == _ListAll[i].Id && x.TenAnh == "Anh").DuongDan)) : null;
                Sp[i].Barcode = _IanhServices.GetAll().Find(x => x.IdChiTietSp == _ListAll[i].Id && x.TenAnh == "Anh") != null ? Image.FromStream(new MemoryStream((byte[])_IanhServices.GetAll().Find(x => x.IdChiTietSp == _ListAll[i].Id && x.TenAnh == "Barcode").DuongDan)) : null;
                Sp[i].BaoHanh = _ListAll[i].BaoHanh;
                Sp[i].GhiChu = _ListAll[i].MoTa;
                var ctksp = _IChiTietKieuSpService.GetAll().Find(x => x.IdChiTietSp == _ListAll[i].Id);
                if (ctksp != null)
                {
                    Sp[i].NhomHang = TenKsp(ctksp.IdKieuSp.GetValueOrDefault(), ctksp.TenKieuSP).Substring(0, TenKsp(ctksp.IdKieuSp.GetValueOrDefault(), ctksp.TenKieuSP).Length - 2);
                }
                if (checkBox1.Checked)
                {
                    Sp[i].ChBox.Checked = true;
                    CbbThaoTac.Visible = true;
                    CbbThaoTac.Texts = "Thao tác";
                }
                else
                {
                    if (CheckCB.ContainsKey(_ListAll[i].Id))
                    {
                        CheckCB[_ListAll[i].Id] = false;
                    }
                    else
                    {
                        CheckCB.Add(_ListAll[i].Id, false);

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
                        CbbThaoTac.Texts = "Thao tác";
                    }
                };
                if (CheckCB.ContainsKey(Sp[i].IDSP))
                {
                    if (CheckCB[Sp[i].IDSP] == true)
                    {
                        Sp[i].ChBox.Checked = true;
                    }
                    else Sp[i].ChBox.Checked = false;
                }
                Sp[i].TopLevel = false;
                Sp[i].FormBorderStyle = FormBorderStyle.None;
                Sp[i].Dock = DockStyle.Top;
                flowLayoutPanel1.Controls.Add(Sp[i]);
                Sp[i].BringToFront();
                Sp[i].Show();
            }
            btnHienThiTatCa.Visible = false;
        }

        private void rdoHetHang_CheckedChanged(object sender, EventArgs e)
        {
            GetListSP();
        }

        private void chkApDung_CheckedChanged(object sender, EventArgs e)
        {
            GetListSP();
            chkKhongApDung.Checked = false;
        }

        private void chkKhongApDung_CheckedChanged(object sender, EventArgs e)
        {
            GetListSP();
            chkApDung.Checked = false;
        }
    }
}
