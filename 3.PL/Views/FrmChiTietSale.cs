using _1.DAL.DomainClass;
using _2.BUS.IServices;
using _2.BUS.Services;
using _2.BUS.ViewModels;
using _3.PL.Utilities;
using Microsoft.EntityFrameworkCore.Storage;
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
    public partial class FrmChiTietSale : Form
    {
        private IChiTietSaleServices _IchiTietSaleServices;
        private IChiTietSpServices _chiTietSpServices;
        private ISaleServices _SaleServices;
        private List<ChiTietSaleView> _lstCtsle;
        private List<SaleView> lstSale;
        private List<ChiTietSpViews> ChiTietSpViews;
        private Guid IDCtsle;
        private Guid IDsale;
        private ChiTietSpViews chiTietSpViews;

        public FrmChiTietSale()
        {
            InitializeComponent();
            _IchiTietSaleServices = new ChiTietSaleServices();
            _chiTietSpServices = new ChiTietSpServices();
            _SaleServices = new SaleServices();
            _lstCtsle = new List<ChiTietSaleView>();
            lstSale = new List<SaleView>();
            tb_ma.Enabled = false;
            cbb_loaiKM.Items.Add("%");
            cbb_loaiKM.Items.Add("Tiền mặt");
            cbb_trangthai.Items.Add("Đang áp dụng");
            cbb_trangthai.Items.Add("Ngừng áp dụng");
            dtp_end.Value = DateTime.Now;
            dtp_start.Value = DateTime.Now;
            cbb_locKM.Items.Add("Tất cả");
            cbb_locKM.Items.Add("%");
            cbb_locKM.Items.Add("Tiền mặt");
            cbb_locTrangthai.Items.Add("Tất cả");
            cbb_locTrangthai.Items.Add("Đang áp dụng");
            cbb_locTrangthai.Items.Add("Ngừng áp dụng");

            loadKM();
            loadCTSP();

            cbb_locKM.SelectedIndex = 0;
            cbb_locTrangthai.SelectedIndex = 0;
            cbb_loaiKM.SelectedIndex = 0;
            dtp_start.CustomFormat = " HH:mm:ss  dd/MM/yyyy";
            dtp_end.CustomFormat = " HH:mm:ss  dd/MM/yyyy";
        }

        private void loadlb()
        {

            if (cbb_loaiKM.Texts == "%")
            {
                lb_mucgiam.Text = "% giảm";
            }
            if (cbb_loaiKM.Texts == "Tiền mặt")
            {
                lb_mucgiam.Text = "Số tiền giảm";
            }
        }


        private void loadKM()
        {
            dtg_show.Rows.Clear();
            dtg_show.ColumnCount = 9;
            dtg_show.Columns[0].Name = "ID";
            dtg_show.Columns[0].Visible = false;
            dtg_show.Columns[1].Name = "Mã";
            dtg_show.Columns[2].Name = "Tên";
            dtg_show.Columns[3].Name = "Ngày bắt đầu";
            dtg_show.Columns[4].Name = "Ngày kết thúc";
            dtg_show.Columns[5].Name = "Loại hình KM";
            dtg_show.Columns[6].Name = "Mức giảm";
            dtg_show.Columns[7].Name = "Mô tả";
            dtg_show.Columns[8].Name = "Trạng thái";
            lstSale = _SaleServices.GetAll();
            if (tb_timkiemkm.Text != "")
            {
                lstSale = lstSale.Where(c => c.Ten.ToLower().Contains(tb_timkiemkm.Text.ToLower())).ToList();
            }
            foreach (var item in lstSale)
            {
                dtg_show.Rows.Add(item.Id, item.Ma, item.Ten, item.NgayBatDau, item.NgayKetThuc, item.LoaiHinhKm,
                    item.MucGiam, item.MoTa, item.TrangThai == 0 ? "Đang áp dụng" : "Ngừng áp dụng");
            }
        }
        private void loadCTSP()
        {
            dtg_sp.Rows.Clear();

            foreach (var item in _chiTietSpServices.GetAll())
            {
                dtg_sp.Rows.Add(null, item.Id, item.TenSP, item.TenMauSac, item.TenTeam, item.GiaBan);
            }
            AddHeaderCheckBox();
            HeaderCheckBox.MouseClick += new MouseEventHandler(cbb_loaiKM_MouseClick);


        }

        private void cbb_loaiKM_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            loadlb();
        }
        private int? addTrangThai()
        {
            int? a;
            if (cbb_trangthai.Texts == "Đang áp dụng")
            {
                a = 0;
                return a;
            }
            else
            {
                a = 1;
                return a;
            }


        }
        private string XoaDauCach(string s)
        {

            while (s.Trim().Contains("  "))
            {
                s = s.Replace("  ", " "); // Xóa 2 dấu cách thành 1 dấu cho đến khi hết
            }
            return s;
        }
        private void bt_them_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thêm ?", "Cảnh báo", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                if (_SaleServices.GetAll().Any(c => c.Ten == tb_ten.Texts))
                {
                    MessageBox.Show("Tên bị trùng");
                }
                else if (tb_ten.Texts == "")
                {
                    MessageBox.Show("Không được bỏ trống tên");
                }
                else if (ValidateInput.hasSpecialChar(tb_ten.Text))
                {
                    MessageBox.Show("Tên không hợp lệ");
                }
                else if (cbb_loaiKM.Texts == "")
                {
                    MessageBox.Show("Vui lòng chọn hình thức giảm");
                }

                else if (ValidateInput.CheckIntInput(tb_mucgiam.Texts) == false || Convert.ToDecimal(tb_mucgiam.Texts) < 0)
                {
                    MessageBox.Show("Nhập đúng mức giảm");
                }
                else if (cbb_loaiKM.Text == "%" || Convert.ToDecimal(tb_mucgiam.Texts) > 100)
                {
                    MessageBox.Show("Không được giảm quá 100%");
                }
                else if (DateTime.Now.Day < dtp_start.Value.Day)
                {
                    MessageBox.Show("Ngày bắt đầu không được bé hơn ngày hiện tại");
                }
                else if (dtp_end.Value < dtp_start.Value)
                {
                    MessageBox.Show("Ngày kết thúc sale không được bé hơn ngày bắt đầu");
                }

                else if (cbb_trangthai.Texts == "")
                {
                    MessageBox.Show("Vui lòng chọn trạng thái");
                }
                else
                {
                    SaleView saleView = new SaleView()
                    {
                        Id = Guid.Empty,
                        Ma = tb_ma.Texts,
                        Ten = XoaDauCach(tb_ten.Text.Trim()),
                        NgayBatDau = dtp_start.Value,
                        NgayKetThuc = dtp_end.Value,
                        LoaiHinhKm = cbb_loaiKM.Texts,
                        MucGiam = Convert.ToDecimal(tb_mucgiam.Texts),
                        MoTa = tb_mota.Texts,
                        TrangThai = addTrangThai(),
                    };
                    MessageBox.Show(_SaleServices.Add(saleView));
                    ClearForm();
                    loadKM();
                }
            }
            else
            {
                MessageBox.Show("Bạn đã hủy thêm");
            }
        }
        private void ClearForm()
        {
            tb_ten.Text = "";
            tb_timkiemkm.Text = "";
            tb_ma.Text = "";
            cbb_trangthai.Texts = "";
            cbb_loaiKM.Texts = "";
            dtp_end.Value = DateTime.Now;
            dtp_start.Value = DateTime.Now;
            tb_mucgiam.Texts = "";
            tb_mota.Texts = "";
        }


        private void tb_timkiemkm_TextChanged(object sender, EventArgs e)
        {
            loadKM();
        }

        private void bt_sua_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn sửa ?", "Cảnh báo", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                if (IDsale == Guid.Empty)
                {
                    MessageBox.Show("Vui lòng chọn mã sale cần sửa");
                }
                else if (_SaleServices.GetAll().FirstOrDefault(c => c.Ten == tb_ten.Texts && c.Id != IDsale) != null)
                {
                    MessageBox.Show("Tên sale được trùng");
                }
                else if (ValidateInput.hasSpecialChar(tb_ten.Text))
                {
                    MessageBox.Show("Tên không hợp lệ");
                }
                else if (tb_ten.Texts == "")
                {
                    MessageBox.Show("Không được bỏ trống tên");
                }
                else if (cbb_loaiKM.Texts == "")
                {
                    MessageBox.Show("Vui lòng chọn hình thức giảm");
                }

                else if (ValidateInput.CheckIntInput(tb_mucgiam.Texts) == false || Convert.ToDecimal(tb_mucgiam.Texts) < 0)
                {
                    MessageBox.Show("Nhập đúng mức giảm");
                }
                else if (cbb_loaiKM.Text == "%" || Convert.ToDecimal(tb_mucgiam.Texts) > 100)
                {
                    MessageBox.Show("Không được giảm quá 100%");
                }
                else if (DateTime.Now < dtp_start.Value)
                {
                    MessageBox.Show("Ngày bắt đầu không được bé hơn ngày hiện tại");
                }
                else if (dtp_end.Value < dtp_start.Value)
                {
                    MessageBox.Show("Ngày kết thúc sale không được bé hơn ngày bắt đầu");
                }

                else if (cbb_trangthai.Texts == "")
                {
                    MessageBox.Show("Vui lòng chọn trạng thái");
                }
                else
                {
                    SaleView saleView = new SaleView()
                    {
                        Id = IDsale,
                        Ma = tb_ma.Texts,
                        Ten = XoaDauCach(tb_ten.Text.Trim()),
                        NgayBatDau = dtp_start.Value,
                        NgayKetThuc = dtp_end.Value,
                        LoaiHinhKm = cbb_loaiKM.Texts,
                        MucGiam = Convert.ToDecimal(tb_mucgiam.Texts),
                        MoTa = tb_mota.Texts,
                        TrangThai = addTrangThai(),
                    };
                    MessageBox.Show(_SaleServices.Update(saleView));
                    ClearForm();
                    loadKM();
                }
            }
            else
            {
                MessageBox.Show("Bạn đã hủy sửa");
            }
        }

        private void cbb_locKM_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbb_locKM.Text == "Tất cả")
            {
                loadKM();
            }
            else if (cbb_locKM.Text == "%")
            {
                dtg_show.Rows.Clear();
                dtg_show.ColumnCount = 9;
                dtg_show.Columns[0].Name = "ID";
                dtg_show.Columns[0].Visible = false;
                dtg_show.Columns[1].Name = "Mã";
                dtg_show.Columns[2].Name = "Tên";
                dtg_show.Columns[3].Name = "Ngày bắt đầu";
                dtg_show.Columns[4].Name = "Ngày kết thúc";
                dtg_show.Columns[5].Name = "Loại hình KM";
                dtg_show.Columns[6].Name = "Mức giảm";
                dtg_show.Columns[7].Name = "Mô tả";
                dtg_show.Columns[8].Name = "Trạng thái";
                lstSale = _SaleServices.GetAll().Where(c => c.LoaiHinhKm.Contains("%")).ToList();
                foreach (var item in lstSale)
                {
                    dtg_show.Rows.Add(item.Id, item.Ma, item.Ten, item.NgayBatDau, item.NgayKetThuc, item.LoaiHinhKm,
                        item.MucGiam, item.MoTa, item.TrangThai == 0 ? "Đang áp dụng" : "Ngừng áp dụng");
                }
            }
            else
            {
                dtg_show.Rows.Clear();
                dtg_show.ColumnCount = 9;
                dtg_show.Columns[0].Name = "ID";
                dtg_show.Columns[0].Visible = false;
                dtg_show.Columns[1].Name = "Mã";
                dtg_show.Columns[2].Name = "Tên";
                dtg_show.Columns[3].Name = "Ngày bắt đầu";
                dtg_show.Columns[4].Name = "Ngày kết thúc";
                dtg_show.Columns[5].Name = "Loại hình KM";
                dtg_show.Columns[6].Name = "Mức giảm";
                dtg_show.Columns[7].Name = "Mô tả";
                dtg_show.Columns[8].Name = "Trạng thái";
                lstSale = _SaleServices.GetAll().Where(c => c.LoaiHinhKm.Contains("Tiền mặt")).ToList();
                foreach (var item in lstSale)
                {
                    dtg_show.Rows.Add(item.Id, item.Ma, item.Ten, item.NgayBatDau, item.NgayKetThuc, item.LoaiHinhKm,
                        item.MucGiam, item.MoTa, item.TrangThai == 0 ? "Đang áp dụng" : "Ngừng áp dụng");
                }
            }
        }

        private void cbb_locTrangthai_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cbb_locTrangthai.Text == "Tất cả")
            {
                loadKM();
            }
            else if (cbb_locTrangthai.Text == "Đang áp dụng")
            {
                dtg_show.Rows.Clear();
                dtg_show.ColumnCount = 9;
                dtg_show.Columns[0].Name = "ID";
                dtg_show.Columns[0].Visible = false;
                dtg_show.Columns[1].Name = "Mã";
                dtg_show.Columns[2].Name = "Tên";
                dtg_show.Columns[3].Name = "Ngày bắt đầu";
                dtg_show.Columns[4].Name = "Ngày kết thúc";
                dtg_show.Columns[5].Name = "Loại hình KM";
                dtg_show.Columns[6].Name = "Mức giảm";
                dtg_show.Columns[7].Name = "Mô tả";
                dtg_show.Columns[8].Name = "Trạng thái";
                lstSale = _SaleServices.GetAll().Where(c => c.TrangThai == 0).ToList();
                foreach (var item in lstSale)
                {
                    dtg_show.Rows.Add(item.Id, item.Ma, item.Ten, item.NgayBatDau, item.NgayKetThuc, item.LoaiHinhKm,
                        item.MucGiam, item.MoTa, item.TrangThai == 0 ? "Đang áp dụng" : "Ngừng áp dụng");
                }
            }
            else
            {

                dtg_show.Rows.Clear();
                dtg_show.ColumnCount = 9;
                dtg_show.Columns[0].Name = "ID";
                dtg_show.Columns[0].Visible = false;
                dtg_show.Columns[1].Name = "Mã";
                dtg_show.Columns[2].Name = "Tên";
                dtg_show.Columns[3].Name = "Ngày bắt đầu";
                dtg_show.Columns[4].Name = "Ngày kết thúc";
                dtg_show.Columns[5].Name = "Loại hình KM";
                dtg_show.Columns[6].Name = "Mức giảm";
                dtg_show.Columns[7].Name = "Mô tả";
                dtg_show.Columns[8].Name = "Trạng thái";
                lstSale = _SaleServices.GetAll().Where(c => c.TrangThai == 1).ToList();
                foreach (var item in lstSale)
                {
                    dtg_show.Rows.Add(item.Id, item.Ma, item.Ten, item.NgayBatDau, item.NgayKetThuc, item.LoaiHinhKm,
                        item.MucGiam, item.MoTa, item.TrangThai == 0 ? "Đang áp dụng" : "Ngừng áp dụng");
                }
            }
        }

        private void cbb_trangthai_OnSelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dtg_show_CellClick(object sender, EventArgs e)
        {
            IDsale = (Guid)(dtg_show.CurrentRow.Cells[0].Value);
            tb_ma.Texts = dtg_show.CurrentRow.Cells[1].Value.ToString();
            tb_ten.Texts = dtg_show.CurrentRow.Cells[2].Value.ToString();
            dtp_start.Value = Convert.ToDateTime(dtg_show.CurrentRow.Cells[3].Value);
            dtp_end.Value = Convert.ToDateTime(dtg_show.CurrentRow.Cells[4].Value);
            cbb_loaiKM.Texts = dtg_show.CurrentRow.Cells[5].Value.ToString();
            tb_mucgiam.Texts = dtg_show.CurrentRow.Cells[6].Value.ToString();
            tb_mota.Texts = dtg_show.CurrentRow.Cells[7].Value.ToString();
            cbb_trangthai.Texts = dtg_show.CurrentRow.Cells[8].Value.ToString();
        }

        private void tb_timkiemkm_TextChanged_1(object sender, EventArgs e)
        {
            loadKM();
        }
        CheckBox HeaderCheckBox = null;
        bool IsHeaderCheckBoxClicked = false;

        private void AddHeaderCheckBox()
        {
            HeaderCheckBox = new CheckBox();
            HeaderCheckBox.Size = new Size(15, 15);
            this.dtg_sp.Controls.Add(HeaderCheckBox);
        }
        private void HeaderCheckBoxClick(CheckBox checkBox)
        {
            IsHeaderCheckBoxClicked = true;
            foreach (DataGridViewRow row in dtg_sp.Rows) ((DataGridViewCheckBoxCell)row.Cells["ckb"]).Value = checkBox.Checked;
            dtg_sp.RefreshEdit();
            IsHeaderCheckBoxClicked = false;
        }

        private void cbb_loaiKM_MouseClick(object sender, MouseEventArgs e)
        {
            HeaderCheckBoxClick((CheckBox)sender);
        }

        private void tb_mucgiam_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;

        }

        private void tb_mucgiam__TextChanged(object sender, EventArgs e)
        {
            if (cbb_loaiKM.Texts == "%" && tb_mucgiam.Texts != "")
            {
                if (Convert.ToDecimal(tb_mucgiam.Texts) > 100)
                {
                    tb_mucgiam.Texts = "100";
                }
            }
        }
    }
}
