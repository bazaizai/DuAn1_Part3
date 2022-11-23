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
    public partial class FrmChatLieu : Form
    {
        private IChatLieuServices _IChatLieuServices;
        private List<ChatLieuViews> _LstChatLieu;
        public ChatLieuViews? _ChatLieu;

        public FrmChatLieu()
        {
            InitializeComponent();
            _IChatLieuServices = new ChatLieuServices();
            _LstChatLieu = new List<ChatLieuViews>();
            tb_Ma.Enabled = false;
            LoadData();
        }
        public void LoadData()
        {
            dtg_Show.Rows.Clear();
            dtg_Show.ColumnCount = 4;
            dtg_Show.Columns[0].Name = "Id ";
            dtg_Show.Columns[0].Visible = false;
            dtg_Show.Columns[1].Name = "Mã";
            dtg_Show.Columns[2].Name = "Tên ";
            dtg_Show.Columns[3].Name = "Trạng Thái";
            var lstChatLieu = _IChatLieuServices.GetAll();
            if (tb_TimKiem.Text != "")
            {
                lstChatLieu = lstChatLieu.Where(x => x.Ma.ToLower().Contains(tb_TimKiem.Text.ToLower()) || x.Ten.ToLower().Contains(tb_TimKiem.Text.ToLower())).ToList();
            }
            foreach (var item in lstChatLieu)
            {
                dtg_Show.Rows.Add(item.Id, item.Ma, item.Ten, item.TrangThai == 0 ? "Hoạt động" : "Không hoạt động");
            }
        }
        public void resetForm()
        {
            _ChatLieu = null;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            foreach (TextBox item in groupBox3.Controls.OfType<TextBox>())
            {
                item.Clear();
            }
            tb_TimKiem.Text = "";
            LoadData();
        }
        private void tb_TimKiem_TextChanged(object sender, EventArgs e)
        {
            _ChatLieu = null;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            foreach (TextBox item in groupBox2.Controls.OfType<TextBox>())
            {
                item.Clear();
            }
            LoadData();
        }


        private void dtg_Show_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow r = dtg_Show.Rows[e.RowIndex];
                _ChatLieu = _IChatLieuServices.GetAll().FirstOrDefault(x => x.Id == Guid.Parse(r.Cells[0].Value.ToString() ?? "Unknown message id"));
                tb_Ma.Text = r.Cells[1].Value.ToString();
                tb_Ten.Text = r.Cells[2].Value.ToString();
                radioButton1.Checked = r.Cells[3].Value.ToString() == "Hoạt động";
                radioButton2.Checked = r.Cells[3].Value.ToString() == "Không hoạt động";
            }
        }
        private void btn_Them_Click(object sender, EventArgs e)
        {
            if (tb_Ten.Text == "")
            {
                MessageBox.Show("Hãy nhập tên chất liệu");
            }
            else if (_IChatLieuServices.GetAll().FirstOrDefault(x => x.Ten == tb_Ten.Text) != null)
            {
                MessageBox.Show("Chất liệu đã tồn tại, vui lòng nhập chất liệu khác");
            }
            else if (radioButton1.Checked == false && radioButton2.Checked == false)
            {
                MessageBox.Show("Hãy chọn trạng thái của chất liệu");
            }
            else
            {
                DialogResult dg = MessageBox.Show("Bạn muốn thêm chất liệu này", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dg == DialogResult.Yes)
                {
                    ChatLieuViews a = new ChatLieuViews()
                    {
                        Ma = tb_Ma.Text,
                        Ten = tb_Ten.Text,
                        TrangThai = radioButton1.Checked ? 0 : 1
                    };
                    _IChatLieuServices.Add(a);
                    MessageBox.Show("Thêm thành công");
                    resetForm();
                }
            }
        }
       
        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (_ChatLieu == null)
            {
                MessageBox.Show("Vui lòng chọn chất liệu cần sửa");
            }
            else
            {
                if (tb_Ten.Text == "")
                {
                    MessageBox.Show("Hãy nhập tên chất liệu");
                }
                else if (_IChatLieuServices.GetAll().FirstOrDefault(x => x.Ten == tb_Ten.Text && x.Id != _ChatLieu.Id) != null)
                {
                    MessageBox.Show("Chất liệu đã tồn tại, vui lòng nhập chất liệu khác");
                }
                else if (radioButton1.Checked == false && radioButton2.Checked == false)
                {
                    MessageBox.Show("Hãy chọn trạng thái chất liệu");
                }
              
                else
                {
                    DialogResult dg = MessageBox.Show("Bạn muốn sửa chất liệu này", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dg == DialogResult.Yes)
                    {
                        _ChatLieu.Ma = tb_Ma.Text;
                        _ChatLieu.Ten = tb_Ten.Text;
                        _ChatLieu.TrangThai = radioButton1.Checked ? 0 : 1;
                        _IChatLieuServices.Update(_ChatLieu);
                        MessageBox.Show("Sửa thành công");
                        resetForm();
                    }
                }
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (_ChatLieu == null)
            {
                MessageBox.Show("Vui lòng chọn chất liệu cần xóa");
            }
            else
            {
                DialogResult dg = MessageBox.Show("Bạn muốn xóa chất liệu này", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dg == DialogResult.Yes)
                {
                    _IChatLieuServices.Delete(_ChatLieu);
                    MessageBox.Show("Xóa thành công");
                    resetForm();
                }
            }
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            resetForm();
        }
    }
}
