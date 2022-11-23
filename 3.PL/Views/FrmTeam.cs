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
    public partial class FrmTeam : Form
    {
        private ITeamServices _TeamServices;
        private IGiaiDauServices _giaiDauServices;
        private List<TeamView> lstTeam;
        private Guid _idteam;
        private TeamView _team;
        
        public FrmTeam()
        {
            InitializeComponent();
            _TeamServices = new TeamServices();
            _giaiDauServices = new GiaiDauServices();
            lstTeam = new List<TeamView>();
            tb_ma.Enabled = false;
            loadData();
            loadcbb();

        }
        private void loadData()
        {

            dtg_show.Rows.Clear();
            dtg_show.ColumnCount = 5;
            dtg_show.Columns[0].Name = "ID";
            dtg_show.Columns[0].Visible = false;
            dtg_show.Columns[1].Name = "Mã";
            dtg_show.Columns[2].Name = "Tên";
            dtg_show.Columns[3].Name = "Giải đấu";
            dtg_show.Columns[4].Name = "Trạng thái";
            lstTeam = _TeamServices.GetAll();
            if (tb_timkiem.Text != "")
            {
                lstTeam = lstTeam.Where(c => c.Ten.Contains(tb_timkiem.Text)).ToList();
            }
            foreach (var item in lstTeam)
            {
                dtg_show.Rows.Add(item.Id, item.Ma, item.Ten,item.TenGiaiDau, item.TrangThai == 0 ? "Hoạt động" : "Không hoạt động");
            }

        }
        private void loadcbb()
        {
            foreach (var item in _giaiDauServices.GetAll())
            {
                cbb_giaidau.Items.Add(item.Ten);
            }
        }
        private void ClearForm()
        {
            tb_ten.Text = "";
            tb_timkiem.Text = "";
            tb_ma.Text = "";
            rdb_hd.Checked = false;
            rdb_khd.Checked = false;
            cbb_giaidau.Text = "";

        }
        private void FrmTeam_Load(object sender, EventArgs e)
        {

        }

        private void bt_update_Click(object sender, EventArgs e)
        {
            var ac = _giaiDauServices.GetAll().FirstOrDefault(p => p.Ten == cbb_giaidau.Text);
            DialogResult result = MessageBox.Show("Bạn có muốn sửa ?", "Cảnh báo", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                if (_idteam == Guid.Empty)
                {
                    MessageBox.Show("Vui lòng chọn team cần sửa");
                }
                else if(_TeamServices.GetAll().FirstOrDefault(c => c.Ten == tb_ten.Text && c.Id !=  _idteam) != null)
                {

                }
                else if (rdb_hd.Checked == false && rdb_khd.Checked == false)
                {
                    MessageBox.Show("Vui lòng chọn trạng thái");
                }

                else
                {
                    TeamView TeamView = new TeamView()
                    {
                        Id = _idteam,
                        IdGd=ac.Id,
                        Ma = tb_ma.Text,
                        Ten = tb_ten.Text,
                        TrangThai = rdb_hd.Checked ? 0 : 1,
                    };
                    MessageBox.Show(_TeamServices.Update(TeamView));
                    ClearForm();
                    loadData();
                }
            }
            else
            {
                MessageBox.Show("Bạn đã hủy sửa");
            }
        }

        private void tb_them_Click(object sender, EventArgs e)
        {
            var ac = _giaiDauServices.GetAll().FirstOrDefault(p => p.Ten == cbb_giaidau.Text);
            DialogResult result = MessageBox.Show("Bạn có muốn thêm ?", "Cảnh báo", MessageBoxButtons.YesNo);
          if (result == DialogResult.Yes)
            {
                
                if (ac == null)
                {
                    MessageBox.Show("Bạn chưa chọn giải đấu");
                }
                else if (_TeamServices.GetAll().Any(c => c.Ten == tb_ten.Text))
                {
                    MessageBox.Show("Tên bị trùng");
                }
                else if (rdb_hd.Checked == false && rdb_khd.Checked == false)
                {
                    MessageBox.Show("Vui lòng chọn trạng thái");
                }
                else
                {
                    TeamView teamView = new TeamView()
                    {
                        Id = Guid.Empty,
                        IdGd = ac.Id,
                        Ma = tb_ma.Text,
                        Ten = tb_ten.Text,
                        TrangThai = rdb_hd.Checked ? 0 : 1,
                    };
                    MessageBox.Show(_TeamServices.Add(teamView));
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
                if (_team==null)
                {
                    MessageBox.Show("Vui lòng chọn team cần xóa");
                }
                else
                {
                    MessageBox.Show(_TeamServices.Delete(_team));
                    ClearForm();
                    loadData();
                }
            }
            else
            {
                MessageBox.Show("Bạn đã hủy xóa");
            }
        }

        private void bt_xoaform_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void tb_timkiem_TextChanged(object sender, EventArgs e)
        {
            loadData();
        }

        private void dtg_show_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _team =  _TeamServices.GetAll().FirstOrDefault(c => c.Id == Guid.Parse(dtg_show.CurrentRow.Cells[0].Value.ToString()));
            _idteam = (Guid)(dtg_show.CurrentRow.Cells[0].Value);
            tb_ma.Text = dtg_show.CurrentRow.Cells[1].Value.ToString();
            tb_ten.Text = dtg_show.CurrentRow.Cells[2].Value.ToString();
            cbb_giaidau.Text = dtg_show.CurrentRow.Cells[3].Value.ToString();
            rdb_hd.Checked = dtg_show.CurrentRow.Cells[4].Value.ToString() == "Hoạt động";
            rdb_khd.Checked = dtg_show.CurrentRow.Cells[4].Value.ToString() == "Không hoạt động";
        }
    }
}
