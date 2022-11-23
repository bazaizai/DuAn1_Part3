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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3.PL.Views
{
    public partial class FrmKichCo : Form
    {
        private IKichCoServices _IKichCoServices;
        private List<KichCoViews> _LstKichCo;
        public KichCoViews? _KichCo ;
        public FrmKichCo()
        {
            InitializeComponent();
            _IKichCoServices = new KichCoServices();
            _LstKichCo = new List<KichCoViews>();
            tb_Ma.Enabled = false;
            LoadData();
        }

        public void LoadData()
        {
            dtg_Show.Rows.Clear();
            dtg_Show.ColumnCount = 6;
            dtg_Show.Columns[0].Name = "Id ";
            dtg_Show.Columns[0].Visible = false;
            dtg_Show.Columns[1].Name = "Mã";
            dtg_Show.Columns[2].Name = "Size ";
            dtg_Show.Columns[3].Name = "Cm";
            dtg_Show.Columns[4].Name = "Inch";
            dtg_Show.Columns[5].Name = "Trạng thái";
            var lstKichCo = _IKichCoServices.GetAll();
            if (tb_TimKiem.Text != "")
            {
                lstKichCo = lstKichCo.Where(x => x.Ma.ToLower().Contains(tb_TimKiem.Text.ToLower()) || x.Size.ToLower().Contains(tb_TimKiem.Text.ToLower())).ToList();
            }
            foreach (var item in lstKichCo)
            {
                dtg_Show.Rows.Add(item.Id, item.Ma, item.Size,item.Cm, item.TrangThai == 0 ? "Hoạt động" : "Không hoạt động");
            }
        }
        public void resetForm()
        {
            _KichCo = null;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            foreach (TextBox item in groupBox3.Controls.OfType<TextBox>())
            {
                item.Clear();
            }
            tb_TimKiem.Text = "";
            LoadData();
        }

        private void dtg_Show_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow r = dtg_Show.Rows[e.RowIndex];
                _KichCo = _IKichCoServices.GetAll().FirstOrDefault(x => x.Id == Guid.Parse(r.Cells[0].Value.ToString() ?? "Unknown message id"));
                tb_Ma.Text = r.Cells[1].Value.ToString();
                tb_Ten.Text = r.Cells[2].Value.ToString();
                tb_Cm.Text = r.Cells[3].Value.ToString();
                tb_Inch.Text = r.Cells[4].Value.ToString();
                radioButton1.Checked = r.Cells[5].Value.ToString() == "Hoạt động";
                radioButton2.Checked = r.Cells[5].Value.ToString() == "Không hoạt động";
            }
        }
        private bool validateSoLonHon0(string str)
        {
            return Regex.IsMatch(str, @"^\d*\.\d+$|^\d+$");
        }
        private void btn_Them_Click(object sender, EventArgs e)
        {
            if (tb_Ten.Text == "")
            {
                MessageBox.Show("Hãy nhập size");
            }
            else if (_IKichCoServices.GetAll().FirstOrDefault(x => x.Size == tb_Ten.Text) != null)
            {
                MessageBox.Show("Size đã tồn tại, vui lòng nhập size khác");
            }
           
            else if (!validateSoLonHon0(tb_Cm.Text)|| decimal.Parse(tb_Cm.Text)<=0)
            {
                MessageBox.Show("Số liệu 'Cm' không được để trống và phải có định dạng là số nguyên hoặc số thập phân lớn hơn 0");
            }
            else if (radioButton1.Checked == false && radioButton2.Checked == false)
            {
                MessageBox.Show("Hãy chọn trạng thái của Kích cỡ");
            }
            else
            {
                DialogResult dg = MessageBox.Show("Bạn muốn thêm Kích cỡ này", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dg == DialogResult.Yes)
                {
                    KichCoViews a = new KichCoViews()
                    {
                        Ma = tb_Ma.Text,
                        Size = tb_Ten.Text,
                        Cm=Convert.ToDecimal(tb_Cm.Text),
                        TrangThai = radioButton1.Checked ? 0 : 1
                    };
                    _IKichCoServices.Add(a);
                    MessageBox.Show("Thêm thành công");
                    resetForm();
                }
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (_KichCo == null)
            {
                MessageBox.Show("Vui lòng chọn kích cỡ cần sửa");
            }
            else
            {
                if (tb_Ten.Text == "")
                {
                    MessageBox.Show("Hãy nhập size");
                }
                else if (_IKichCoServices.GetAll().FirstOrDefault(x => x.Size == tb_Ten.Text && x.Id != _KichCo.Id) != null)
                {
                    MessageBox.Show("Size đã tồn tại, vui lòng nhập size khác");
                }
                else
                {
                    DialogResult dg = MessageBox.Show("Bạn muốn sửa kích cỡ này", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dg == DialogResult.Yes) { 
                        _KichCo.Ma = tb_Ma.Text;
                        _KichCo.Size = tb_Ten.Text;
                        _KichCo.Cm =Convert.ToDecimal( tb_Cm.Text);
                        _KichCo.TrangThai = radioButton1.Checked ? 0 : 1;
                        _IKichCoServices.Update(_KichCo);
                        MessageBox.Show("Sửa thành công");
                        resetForm();
                    }
                }
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (_KichCo == null)
            {
                MessageBox.Show("Vui lòng chọn kích cỡ cần xóa");
            }
            else
            {
                DialogResult dg = MessageBox.Show("Bạn muốn xóa kích cỡ này", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dg == DialogResult.Yes)
                {
                    _IKichCoServices.Delete(_KichCo);
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
            _KichCo = null;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            foreach (TextBox item in groupBox2.Controls.OfType<TextBox>())
            {
                item.Clear();
            }
            LoadData();
        }
    }
}
