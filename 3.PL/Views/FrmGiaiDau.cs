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
    public partial class FrmGiaiDau : Form
    {
        private IGiaiDauServices _giaiDauServices;
        private List<GiaiDauView> lstGiaiDau;
        private Guid _idgd;
        private GiaiDauView _gdv;
        public FrmGiaiDau()
        {
            InitializeComponent();
            _giaiDauServices = new GiaiDauServices();
            lstGiaiDau = new List<GiaiDauView>();
            loadData();
            tb_ma.Enabled = false ;

        }

        private void loadData()
        {

            dtg_show.Rows.Clear();
            dtg_show.ColumnCount = 4;
            dtg_show.Columns[0].Name = "ID";
            dtg_show.Columns[0].Visible = false;
            dtg_show.Columns[1].Name = "Mã";
            dtg_show.Columns[2].Name = "Tên";
            dtg_show.Columns[3].Name = "Trạng thái";
            lstGiaiDau = _giaiDauServices.GetAll();
            if (tb_timkiem.Text != "")
            {
                lstGiaiDau = lstGiaiDau.Where(c => c.Ten.Contains(tb_timkiem.Text)).ToList();
            }
            foreach (var item in lstGiaiDau)
            {
                dtg_show.Rows.Add(item.Id, item.Ma, item.Ten, item.TrangThai == 0 ? "Hoạt động" : "Không hoạt động");
            }
          
        }
        private void ClearForm()
        {
            tb_ten.Text = "";
            tb_timkiem.Text = "";
            tb_ma.Text = "";
            rdb_hd.Checked = false;
            rdb_khd.Checked = false;

        }
        private void tb_them_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thêm ?", "Cảnh báo", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
               if(_giaiDauServices.GetAll().Any(c=>c.Ten==tb_ten.Text))
                {
                    MessageBox.Show("Giải đấu bị trùng");
                }                 
                else
                {
                    GiaiDauView giaiDauView = new GiaiDauView()
                    {
                        Id = Guid.Empty,
                        Ma = tb_ma.Text,
                        Ten = tb_ten.Text,
                        TrangThai = rdb_hd.Checked ? 0 : 1,
                    };
                    MessageBox.Show(_giaiDauServices.Add(giaiDauView));
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
                if (_gdv == null)
                {
                    MessageBox.Show("Vui lòng chọn giải đấu cần xóa");
                }
                else
                {
                    MessageBox.Show(_giaiDauServices.Delete(_gdv));
                    ClearForm();
                    loadData();
                }
            }
            else
            {
                MessageBox.Show("Bạn đã hủy xóa");
            }

        }

        private void bt_update_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn sửa ?", "Cảnh báo", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                if (_idgd == Guid.Empty)
                {
                    MessageBox.Show("Vui lòng chọn giải đấu cần sửa");
                }
                if (_giaiDauServices.GetAll().FirstOrDefault(c => c.Ten == tb_ten.Text && c.Id!= _idgd )!=null  )
                {
                    MessageBox.Show("Giải đấu bị trùng");
                }
                else
                {
                    GiaiDauView giaiDauView = new GiaiDauView()
                    {
                        Id = _idgd,
                        Ma= tb_ma.Text,
                        Ten = tb_ten.Text,
                        TrangThai = rdb_hd.Checked ? 0 : 1,
                    };
                    MessageBox.Show(_giaiDauServices.Update(giaiDauView));
                    ClearForm();
                    loadData();
                }
            }
            else
            {
                MessageBox.Show("Bạn đã hủy sửa");
            }
        }

        private void dtg_show_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _gdv = _giaiDauServices.GetAll().FirstOrDefault(c => c.Id == Guid.Parse(dtg_show.CurrentRow.Cells[0].Value.ToString()));
            _idgd = (Guid)(dtg_show.CurrentRow.Cells[0].Value);
            tb_ma.Text = dtg_show.CurrentRow.Cells[1].Value.ToString();
            tb_ten.Text = dtg_show.CurrentRow.Cells[2].Value.ToString();
            rdb_hd.Checked = dtg_show.CurrentRow.Cells[3].Value.ToString() == "Hoạt động";
            rdb_khd.Checked = dtg_show.CurrentRow.Cells[3].Value.ToString() == "Không hoạt động";

        }

        private void bt_xoaform_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void tb_timkiem_TextChanged(object sender, EventArgs e)
        {
            loadData();
        }
    }
}
