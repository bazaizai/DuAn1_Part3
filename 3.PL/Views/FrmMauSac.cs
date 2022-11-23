using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _1.DAL.DomainClass;
using _2.BUS.IServices;
using _2.BUS.Services;
using _2.BUS.ViewModels;

namespace _3.PL.Views
{
    public partial class FrmMauSac : Form
    {
        private IMauSacServices _iMauSac;
        private MauSacView _msv;
        public FrmMauSac()
        {
            InitializeComponent();
            _iMauSac = new MauSacServices();
            LoadData();
            rdb_hoatdong.Checked = true;
            tbt_ma.Enabled = false;
        }
        public void LoadData()
        {
            dtg_show.Rows.Clear();
            dtg_show.ColumnCount = 4;
            dtg_show.Columns[0].Name = "ID";
            dtg_show.Columns[1].Name = "Mã";
            dtg_show.Columns[2].Name = "Tên";
            dtg_show.Columns[3].Name = "Trạng thái";
            dtg_show.Columns[0].Visible = false;
            var lstMauSac = _iMauSac.GetAll();
            if (tb_timkiem.Text != "")
            {
                lstMauSac = lstMauSac.Where(x => x.Ma.ToLower().Contains(tb_timkiem.Text.ToLower()) || x.Ten.ToLower().Contains(tb_timkiem.Text.ToLower())).ToList();
            }
            foreach (var item in lstMauSac)
            {
                dtg_show.Rows.Add(item.Id, item.Ma, item.Ten, item.TrangThai == 0 ? "Hoạt động" : "Không hoạt động");
            }
        }

        public MauSacView GetData()
        {
            MauSacView cvv = new MauSacView()
            {
                Id = new Guid(),
                Ma = tbt_ma.Text,
                Ten = tbt_ten.Text,
                TrangThai = rdb_hoatdong.Checked ? 0 : 1,
            };
            return cvv;
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn thêm không", "thông báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (_iMauSac.GetAll().Any(c => c.Ten == tbt_ten.Text))
                {
                    MessageBox.Show("Đã có màu sắc");
                }
                else
                {
                    _iMauSac.Add(GetData());
                    MessageBox.Show("thêm thành công");
                    LoadData();
                }
            }
            else
            {
                MessageBox.Show("Bạn đã hủy thêm");
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            MauSacView cvv = new MauSacView()
            {
                Id = Guid.Parse(dtg_show.CurrentRow.Cells[0].Value.ToString()),
                Ma = tbt_ma.Text,
                Ten = tbt_ten.Text,
                TrangThai = rdb_hoatdong.Checked ? 0 : 1,
            };
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn sửa không", "thông báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (_msv == null)
                {
                    MessageBox.Show("chọn màu sắc");
                }
                else if (_iMauSac.GetAll().FirstOrDefault(c => c.Ten == tbt_ten.Text && c.Id != _msv.Id) != null)
                {
                    MessageBox.Show("Màu sắc bị trùng");
                }
                else
                {
                    _iMauSac.Update(cvv);
                    MessageBox.Show("sửa thành công");
                    LoadData();
                }
            }
            else
            {
                MessageBox.Show("Bạn đã hủy thêm");
            }
        }

        private void btn_clear_Click(object sender, DataGridViewCellEventArgs e)
        {
            _msv = _iMauSac.GetAll().FirstOrDefault(c => c.Id == Guid.Parse(dtg_show.CurrentRow.Cells[0].Value.ToString()));
            tbt_ma.Text = dtg_show.CurrentRow.Cells[1].Value.ToString();
            tbt_ten.Text = dtg_show.CurrentRow.Cells[2].Value.ToString();
            rdb_khonghd.Checked = _msv.TrangThai == 1;
            rdb_hoatdong.Checked = _msv.TrangThai == 0;
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn xóa không", "thông báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (_msv == null)
                {
                    MessageBox.Show("chọn màu sắc");
                }
                else
                {
                    _iMauSac.Delete(_msv);
                    MessageBox.Show("xóa thành công");
                    LoadData();
                }
            }
            else
            {
                MessageBox.Show("Bạn đã hủy xóa");
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            tbt_ma.Text = "";
            tbt_ten.Text = "";
            rdb_hoatdong.Checked = false;
            rdb_khonghd.Checked = false;
        }

        private void tb_timkiem_TextChanged(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
