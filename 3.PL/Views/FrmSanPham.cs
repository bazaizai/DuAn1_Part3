using _1.DAL.DomainClass;
using _2.BUS.IServices;
using _2.BUS.Services;
using _2.BUS.ViewModels;
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
    public partial class FrmSanPham : Form
    {
        private ISanPhamServices _ISanPhamServices;
        private List<SanPhamViews> _LstSanPham;
        public SanPhamViews? _SanPham;
        public FrmSanPham()
        {
            InitializeComponent();
            _ISanPhamServices = new SanPhamServices();
            _LstSanPham = new List<SanPhamViews>();
            tb_Ma.Enabled = false;
            LoadData();
            cbb_loc.Text = "Tất cả";
            this.CenterToScreen();
        }
        public void LoadData()
        {
            dtg_Show.Rows.Clear();
            dtg_Show.ColumnCount = 4;
            dtg_Show.Columns[0].Name = "Id ";
            dtg_Show.Columns[0].Visible = false;
            dtg_Show.Columns[1].Name = " Mã";
            dtg_Show.Columns[2].Name = "Tên ";
            dtg_Show.Columns[3].Name = "Trang Thai";
            var lstSanPham = _ISanPhamServices.GetAll();
            //if (tb_TimKiem.Text != "")
            //{
            //    lstSanPham = lstSanPham.Where(x => x.Ma.ToLower().Contains(tb_TimKiem.Text.ToLower()) || x.Ten.ToLower().Contains(tb_TimKiem.Text.ToLower())).ToList();
            //}
            foreach (var item in lstSanPham)
            {
                dtg_Show.Rows.Add(item.Id, item.Ma, item.Ten, item.TrangThai == 0 ? "Hoạt động" : "Không hoạt động");
            }
        }

        public void resetForm()
        {
            _SanPham = null;
            radioButton1.Checked=false;
            radioButton2.Checked = false;
            foreach (TextBox item in groupBox3.Controls.OfType<TextBox>())
            {
                item.Clear();
            }
            tb_TimKiem.Text = "";
            cbb_loc.Text = "Tất cả";
            LoadData();
        }

        private void dtg_Show_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow r = dtg_Show.Rows[e.RowIndex];
                _SanPham = _ISanPhamServices.GetAll().FirstOrDefault(x => x.Id == Guid.Parse(r.Cells[0].Value.ToString() ?? "Unknown message id"));
                tb_Ma.Text = r.Cells[1].Value.ToString();
                tb_Ten.Text = r.Cells[2].Value.ToString();
                radioButton1.Checked= r.Cells[3].Value.ToString()== "Hoạt động";
                radioButton2.Checked = r.Cells[3].Value.ToString() == "Không hoạt động";
            }
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            if (tb_Ten.Text == "")
            {
                MessageBox.Show("Hãy nhập tên sản phẩm");
            }
            else if (_ISanPhamServices.GetAll().FirstOrDefault(x => x.Ten == tb_Ten.Text) != null)
            {
                MessageBox.Show("Sản phẩm đã tồn tại, vui lòng nhập sản phẩm khác");
            }
            else if (radioButton1.Checked == false && radioButton2.Checked == false)
            {
                MessageBox.Show("Hãy chọn trạng thái của sản phẩm");
            }
            else
            {
                DialogResult dg = MessageBox.Show("Bạn muốn thêm sản phẩm này", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dg == DialogResult.Yes)
                {
                    SanPhamViews a = new SanPhamViews()
                    {
                        Ma = tb_Ma.Text,
                        Ten = tb_Ten.Text,
                        TrangThai = radioButton1.Checked ? 0 : 1
                };
                    _ISanPhamServices.Add(a);
                    MessageBox.Show("Thêm thành công");
                    resetForm();
                }
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (_SanPham == null)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm cần sửa");
            }
            else
            {
                if (tb_Ten.Text == "")
                {
                    MessageBox.Show("Hãy nhập tên sản phẩm ");
                }
                else if (_ISanPhamServices.GetAll().FirstOrDefault(x => x.Ten == tb_Ten.Text && x.Id != _SanPham.Id) != null)
                {
                    MessageBox.Show("Sản phẩm đã tồn tại, vui lòng nhập sản phẩm khác");
                }
                else if (radioButton1.Checked == false && radioButton2.Checked == false)
                {
                    MessageBox.Show("Hãy chọn trạng thái sản phẩm");
                }

                else
                {
                    DialogResult dg = MessageBox.Show("Bạn muốn sửa sản phẩm này", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dg == DialogResult.Yes)
                    {
                        _SanPham.Ma = tb_Ma.Text;
                        _SanPham.Ten = tb_Ten.Text;
                        _SanPham.TrangThai = radioButton1.Checked ? 0 : 1;
                        _ISanPhamServices.Update(_SanPham);
                        MessageBox.Show("Sửa thành công");
                        resetForm();
                    }
                }
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (_SanPham == null)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm cần xóa");
            }
            else
            {
                DialogResult dg = MessageBox.Show("Bạn muốn xóa sản phẩm này", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dg == DialogResult.Yes)
                {
                    _ISanPhamServices.Delete(_SanPham);
                    MessageBox.Show("Xóa thành công");
                    resetForm();
                }
            }
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            resetForm();
        }

        private void tb_TimKiem_TextChanged(object sender, EventArgs e)
        {
            _SanPham = null;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            foreach (TextBox item in groupBox2.Controls.OfType<TextBox>())
            {
                item.Clear();
            }
            //LoadData();
            loc();
        }

        private void FrmSanPham_Load(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        public void loc()
        {
            if (cbb_loc.Text == "Hoạt động")
            {
                var timkiem = _ISanPhamServices.GetAll().Where(p => (p.Ma.ToLower().Contains(tb_TimKiem.Text.ToLower()) || p.Ten.ToLower().Contains(tb_TimKiem.Text.ToLower())) && p.TrangThai == 0).ToList();
                dtg_Show.Rows.Clear();
                foreach (var item in timkiem)
                {
                    dtg_Show.Rows.Add(item.Id, item.Ma, item.Ten, item.TrangThai == 0 ? "Hoạt động" : "Không hoạt động");
                }
            }
            else if (cbb_loc.Text == "Không hoạt động")
            {
                var timkiem = _ISanPhamServices.GetAll().Where(p => (p.Ma.ToLower().Contains(tb_TimKiem.Text.ToLower()) || p.Ten.ToLower().Contains(tb_TimKiem.Text.ToLower()))
                                                                  && p.TrangThai == 1).ToList();
                dtg_Show.Rows.Clear();
                foreach (var item in timkiem)
                {
                    dtg_Show.Rows.Add(item.Id, item.Ma, item.Ten, item.TrangThai == 0 ? "Hoạt động" : "Không hoạt động");
                }
            }
            else if (cbb_loc.Text == "Tất cả")
            {
                var timkiem = _ISanPhamServices.GetAll().Where(p => p.Ma.ToLower().Contains(tb_TimKiem.Text.ToLower()) || p.Ten.ToLower().Contains(tb_TimKiem.Text.ToLower())).ToList();
                dtg_Show.Rows.Clear();
                foreach (var item in timkiem)
                {
                    dtg_Show.Rows.Add(item.Id, item.Ma, item.Ten, item.TrangThai == 0 ? "Hoạt động" : "Không hoạt động");
                }
            }
        }

        private void cbb_loc_SelectedIndexChanged(object sender, EventArgs e)
        {
            loc();
        }
    }
}
