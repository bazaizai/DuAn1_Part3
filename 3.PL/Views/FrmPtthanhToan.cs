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
    public partial class FrmPtthanhToan : Form
    {
        private IPtthanhToanServices _IPtthanhToanServices;
        private List<PtthanhToanViews> _LstPtthanhToan;
        public PtthanhToanViews? _PtthanhToan;
        public FrmPtthanhToan()
        {
            InitializeComponent();
            _IPtthanhToanServices = new PtthanhToanServices();
            _LstPtthanhToan = new List<PtthanhToanViews>();
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
            dtg_Show.Columns[1].Name = "Mã";
            dtg_Show.Columns[2].Name = "Tên ";
            dtg_Show.Columns[3].Name = "Trang Thai";
            var lstPtthanhToan = _IPtthanhToanServices.GetAll();
            //if (tb_TimKiem.Text != "")
            //{
            //    lstPtthanhToan = lstPtthanhToan.Where(x => x.Ma.ToLower().Contains(tb_TimKiem.Text.ToLower()) || x.Ten.ToLower().Contains(tb_TimKiem.Text.ToLower())).ToList();
            //}
            foreach (var item in lstPtthanhToan)
            {
                dtg_Show.Rows.Add(item.Id, item.Ma, item.Ten, item.TrangThai == 0 ? "Hoạt động" : "Không hoạt động");
            }
        }
        public void resetForm()
        {
            _PtthanhToan = null;
            radioButton1.Checked = false;
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
                _PtthanhToan = _IPtthanhToanServices.GetAll().FirstOrDefault(x => x.Id == Guid.Parse(r.Cells[0].Value.ToString() ?? "Unknown message id"));
                tb_Ma.Text = r.Cells[1].Value.ToString();
                tb_Ten.Text = r.Cells[2].Value.ToString();
                radioButton1.Checked = r.Cells[3].Value.ToString() == "Hoạt động";
                radioButton2.Checked = r.Cells[3].Value.ToString() == "Không hoạt động";
            }
        }

        private void tb_TimKiem_TextChanged(object sender, EventArgs e)
        {
            _PtthanhToan = null;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            foreach (TextBox item in groupBox2.Controls.OfType<TextBox>())
            {
                item.Clear();
            }
            //LoadData();
            loc();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            if (tb_Ten.Text == "")
            {
                MessageBox.Show("Hãy nhập tên phương thức thanh toán");
            }
            else if (_IPtthanhToanServices.GetAll().FirstOrDefault(x => x.Ten == tb_Ten.Text) != null)
            {
                MessageBox.Show("Phương thức thanh toán đã tồn tại, vui lòng nhập phương thức thanh toán khác");
            }
            else if (radioButton1.Checked == false && radioButton2.Checked == false)
            {
                MessageBox.Show("Hãy chọn trạng thái của phương thức thanh toán");
            }
            else
            {
                DialogResult dg = MessageBox.Show("Bạn muốn thêm phương thức thanh toán này", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dg == DialogResult.Yes)
                {
                    PtthanhToanViews a = new PtthanhToanViews()
                    {
                        Ma = tb_Ma.Text,
                        Ten = tb_Ten.Text,
                        TrangThai = radioButton1.Checked ? 0 : 1
                    };
                    _IPtthanhToanServices.Add(a);
                    MessageBox.Show("Thêm thành công");
                    resetForm();
                }
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (_PtthanhToan == null)
            {
                MessageBox.Show("Vui lòng chọn phương thức thanh toán cần sửa");
            }
            else
            {
                if (tb_Ten.Text == "")
                {
                    MessageBox.Show("Hãy nhập tên phương thức thanh toán");
                }
                else if (_IPtthanhToanServices.GetAll().FirstOrDefault(x => x.Ten == tb_Ten.Text && x.Id != _PtthanhToan.Id) != null)
                {
                    MessageBox.Show("phương thức thanh toán đã tồn tại, vui lòng nhập phương thức thanh toán khác");
                }
                else if (radioButton1.Checked == false && radioButton2.Checked == false)
                {
                    MessageBox.Show("Hãy chọn trạng thái");
                }
                else
                {
                    DialogResult dg = MessageBox.Show("Bạn muốn sửa phương thức thanh toán này", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dg == DialogResult.Yes)
                    {
                        _PtthanhToan.Ma = tb_Ma.Text;
                        _PtthanhToan.Ten = tb_Ten.Text;
                        _PtthanhToan.TrangThai = radioButton1.Checked ? 0 : 1;
                        _IPtthanhToanServices.Update(_PtthanhToan);
                        MessageBox.Show("Sửa thành công");
                        resetForm();
                    }
                }
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (_PtthanhToan == null)
            {
                MessageBox.Show("Vui lòng chọn phương thức thanh toán cần xóa");
            }
            else
            {
                DialogResult dg = MessageBox.Show("Bạn muốn xóa phương thức thanh toán này", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dg == DialogResult.Yes)
                {
                    _IPtthanhToanServices.Delete(_PtthanhToan);
                    MessageBox.Show("Xóa thành công");
                    resetForm();
                }
            }
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            resetForm();
        }

        private void cbb_loc_SelectedIndexChanged(object sender, EventArgs e)
        {
            loc();
        }
        public void loc()
        {
            if (cbb_loc.Text == "Hoạt động")
            {
                var timkiem = _IPtthanhToanServices.GetAll().Where(p => (p.Ma.ToLower().Contains(tb_TimKiem.Text.ToLower()) || p.Ten.ToLower().Contains(tb_TimKiem.Text.ToLower())) && p.TrangThai == 0).ToList();
                dtg_Show.Rows.Clear();
                foreach (var item in timkiem)
                {
                    dtg_Show.Rows.Add(item.Id, item.Ma, item.Ten, item.TrangThai == 0 ? "Hoạt động" : "Không hoạt động");
                }
            }
            else if (cbb_loc.Text == "Không hoạt động")
            {
                var timkiem = _IPtthanhToanServices.GetAll().Where(p => (p.Ma.ToLower().Contains(tb_TimKiem.Text.ToLower()) || p.Ten.ToLower().Contains(tb_TimKiem.Text.ToLower()))
                                                                  && p.TrangThai == 1).ToList();
                dtg_Show.Rows.Clear();
                foreach (var item in timkiem)
                {
                    dtg_Show.Rows.Add(item.Id, item.Ma, item.Ten, item.TrangThai == 0 ? "Hoạt động" : "Không hoạt động");
                }
            }
            else if (cbb_loc.Text == "Tất cả")
            {
                var timkiem = _IPtthanhToanServices.GetAll().Where(p => p.Ma.ToLower().Contains(tb_TimKiem.Text.ToLower()) || p.Ten.ToLower().Contains(tb_TimKiem.Text.ToLower())).ToList();
                dtg_Show.Rows.Clear();
                foreach (var item in timkiem)
                {
                    dtg_Show.Rows.Add(item.Id, item.Ma, item.Ten, item.TrangThai == 0 ? "Hoạt động" : "Không hoạt động");
                }
            }
        }

    }
}
