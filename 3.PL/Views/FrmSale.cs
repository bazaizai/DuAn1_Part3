using _2.BUS.IServices;
using _2.BUS.Services;
using _2.BUS.ViewModels;
using _3.PL.Utilities;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3.PL.Views
{
    public partial class FrmSale : Form
    {
        private ISaleServices _saleServices;
        private List<SaleView> lstSale;
        private Guid idSale;
        private SaleView _slv;
        public FrmSale()
        {
            InitializeComponent();
            _saleServices = new SaleServices();
            lstSale = new List<SaleView>();
            tb_ma.Enabled = false;
            loadcbb();
            cbb_loaiKm.SelectedIndex = 0;

            loadData();
        }
        private void loadlb()
        {
            if (cbb_loaiKm.Text == "%")
            {
                lb_mucgiam.Text = "% giảm";
            }
            if (cbb_loaiKm.Text == "Tiền mặt")
            {
                lb_mucgiam.Text = "Số tiền giảm";
            }

        }
        private void loadData()
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
            lstSale = _saleServices.GetAll();
            if (tb_timkiem.Text != "")
            {
                lstSale = lstSale.Where(c => c.Ten.ToLower().Contains(tb_timkiem.Text.ToLower())).ToList();
            }
            foreach (var item in lstSale)
            {
                dtg_show.Rows.Add(item.Id, item.Ma, item.Ten, item.NgayBatDau, item.NgayKetThuc, item.LoaiHinhKm, item.MucGiam, item.MoTa, item.TrangThai == 0 ? "Hoạt động" : "Không hoạt động");
            }

        }
        private void loadcbb()
        {
            cbb_loaiKm.Items.Add("%");
            cbb_loaiKm.Items.Add("Tiền mặt");
        }
        private void ClearForm()
        {
            tb_ten.Text = "";
            tb_timkiem.Text = "";
            tb_ma.Text = "";
            rdb_hd.Checked = false;
            rdb_khd.Checked = false;
            cbb_loaiKm.Text = "";
            dtp_end.Value = DateTime.Now;
            dtp_start.Value = DateTime.Now;
            tb_mucgiam.Text = "";
            tb_mota.Text = "";

        }
        private void bt_update_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn sửa ?", "Cảnh báo", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                if (idSale == Guid.Empty)
                {
                    MessageBox.Show("Vui lòng chọn mã sale cần sửa");
                }
                else if (_saleServices.GetAll().FirstOrDefault(c => c.Ten == tb_ten.Text && c.Id != _slv.Id) != null)
                {
                    MessageBox.Show("Tên sale được trùng");
                }
                else if (string.IsNullOrWhiteSpace(tb_ten.Text))
                {
                    MessageBox.Show("Tên không được để trống");
                }
                else if (ValidateInput.hasSpecialChar(tb_ten.Text))
                {
                    MessageBox.Show("Tên không hợp lệ");
                }
                else if (rdb_hd.Checked == false && rdb_khd.Checked == false)
                {
                    MessageBox.Show("Vui lòng chọn trạng thái");
                }
                else if (cbb_loaiKm.Text == "")
                {
                    MessageBox.Show("Vui lòng chọn hình thức giảm");
                }
                else if (dtp_end.Value < dtp_start.Value)
                {
                    MessageBox.Show("Thời gian kết thúc sale không được bé hơn thời gian bắt đầu");
                }
                else if (ValidateInput.CheckIntInput(tb_mucgiam.Text) == false || Convert.ToDecimal(tb_mucgiam.Text) < 0)
                {
                    MessageBox.Show("Nhập đúng mức giảm");
                }
                else if (cbb_loaiKm.Text == "%" && Convert.ToDecimal(tb_mucgiam.Text) > 100)
                {
                    MessageBox.Show("Không được giảm quá 100%");
                }

                else
                {
                    SaleView saleView = new SaleView()
                    {
                        Id = idSale,
                        Ma = tb_ma.Text,
                        Ten = XoaDauCach(tb_ten.Text.Trim()),
                        NgayBatDau = dtp_start.Value,
                        NgayKetThuc = dtp_end.Value,
                        LoaiHinhKm = cbb_loaiKm.Text,
                        MucGiam = Convert.ToDecimal(tb_mucgiam.Text),
                        MoTa = tb_mota.Text,
                        TrangThai = rdb_hd.Checked ? 0 : 1,
                    };
                    MessageBox.Show(_saleServices.Update(saleView));
                    ClearForm();
                    loadData();
                }
            }
            else
            {
                MessageBox.Show("Bạn đã hủy sửa");
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
        private void tb_them_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thêm ?", "Cảnh báo", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                if (_saleServices.GetAll().Any(c => c.Ten == tb_ten.Text))
                {
                    MessageBox.Show("Tên bị trùng");
                }
                else if (string.IsNullOrWhiteSpace(tb_ten.Text))
                {
                    MessageBox.Show("Tên không được bỏ trống");
                }
                else if (ValidateInput.hasSpecialChar(tb_ten.Text))
                {
                    MessageBox.Show("Tên không hợp lệ");
                }
                else if (rdb_hd.Checked == false && rdb_khd.Checked == false)
                {
                    MessageBox.Show("Vui lòng chọn trạng thái");
                }
                else if (cbb_loaiKm.Text == "")
                {
                    MessageBox.Show("Vui lòng chọn hình thức giảm");
                }
                else if (dtp_end.Value < dtp_start.Value)
                {
                    MessageBox.Show("Ngày kết thúc sale không được bé hơn ngày bắt đầu");
                }
                else if (ValidateInput.CheckIntInput(tb_mucgiam.Text) == false || Convert.ToDecimal(tb_mucgiam.Text) < 0)
                {
                    MessageBox.Show("Nhập đúng mức giảm");
                }
                else if (cbb_loaiKm.Text == "%" && Convert.ToDecimal(tb_mucgiam.Text) > 100)
                {
                    MessageBox.Show("Không được giảm quá 100%");
                }

                else
                {
                    SaleView saleView = new SaleView()
                    {
                        Id = Guid.Empty,
                        Ma = tb_ma.Text,
                        Ten = XoaDauCach(tb_ten.Text.Trim()),
                        NgayBatDau = dtp_start.Value,
                        NgayKetThuc = dtp_end.Value,
                        LoaiHinhKm = cbb_loaiKm.Text,
                        MucGiam = Convert.ToDecimal(tb_mucgiam.Text),
                        MoTa = tb_mota.Text,
                        TrangThai = rdb_hd.Checked ? 0 : 1,
                    };
                    MessageBox.Show(_saleServices.Add(saleView));
                    ClearForm();
                    loadData();
                }
            }
            else
            {
                MessageBox.Show("Bạn đã hủy thêm");
            }
        }

        private void bt_xoa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn xóa ?", "Cảnh báo", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                if (_slv == null)
                {
                    MessageBox.Show("Vui lòng chọn sale cần xóa");
                }
                else
                {
                    MessageBox.Show(_saleServices.Delete(_slv));
                    ClearForm();
                    loadData();
                }
            }
            else
            {
                MessageBox.Show("Bạn đã hủy xóa");
            }
        }

        private void FrmSale_Load(object sender, EventArgs e)
        {

        }

        private void bt_xoaform_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void dtg_show_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _slv = _saleServices.GetAll().FirstOrDefault(c => c.Id == Guid.Parse(dtg_show.CurrentRow.Cells[0].Value.ToString()));
            idSale = (Guid)(dtg_show.CurrentRow.Cells[0].Value);
            tb_ma.Text = dtg_show.CurrentRow.Cells[1].Value.ToString();
            tb_ten.Text = dtg_show.CurrentRow.Cells[2].Value.ToString();
            dtp_start.Value = Convert.ToDateTime(dtg_show.CurrentRow.Cells[3].Value);
            dtp_end.Value = Convert.ToDateTime(dtg_show.CurrentRow.Cells[4].Value);
            cbb_loaiKm.Text = dtg_show.CurrentRow.Cells[5].Value.ToString();
            tb_mucgiam.Text = dtg_show.CurrentRow.Cells[6].Value.ToString();
            tb_mota.Text = dtg_show.CurrentRow.Cells[7].Value.ToString();
            rdb_hd.Checked = dtg_show.CurrentRow.Cells[8].Value.ToString() == "Hoạt động";
            rdb_khd.Checked = dtg_show.CurrentRow.Cells[8].Value.ToString() == "Không hoạt động";
        }

        private void cbb_loaiKm_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadlb();
        }

        private void tb_mucgiam_TextChanged(object sender, EventArgs e)
        {
            if (cbb_loaiKm.Text == "%")
            {
                if (Convert.ToDecimal(tb_mucgiam.Text) > 100)
                {
                    tb_mucgiam.Text = "100";
                }
            }
        }

        private void tb_mucgiam_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}
