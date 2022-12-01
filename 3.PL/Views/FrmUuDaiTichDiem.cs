using _2.BUS.IServices;
using _2.BUS.Services;
using _2.BUS.ViewModels;
using _3.PL.Utilities;
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
    public partial class FrmUuDaiTichDiem : Form
    {
        public IUuDaiTichDiemServices _iUuDaiTichDiemServices;
        public ICtTichDiemServices _ctTichDiemServices;
        public UuDaiTichDiemView _uuDaiTichDiemView;
        public List<UuDaiTichDiemView> _lstUuDaiTichDiem;
        public FrmUuDaiTichDiem()
        {
            InitializeComponent();
            _iUuDaiTichDiemServices = new UuDaiTichDiemServices();
            _uuDaiTichDiemView = new UuDaiTichDiemView();
            _lstUuDaiTichDiem = new List<UuDaiTichDiemView>();
            _ctTichDiemServices = new CtTichDiemServices();
            LoadData();
            LoadCBB();
            LoadDT();


        }

        private void LoadDT()
        {
            _ctTichDiemServices = new CtTichDiemServices();
            var x = _ctTichDiemServices.GetAll();
            if (x.Count() == 0)
            {
                label8.Text = "Chưa có công thức";
                lb1.Visible = false;
                lb2.Visible = false;
                lb3.Visible = false;
            }
            foreach (var xItem in x)
            {
                if (xItem != null && xItem.TrangThai == 0)
                {
                    label8.Text = xItem.HeSoTich.ToString();
                    lb1.Visible = true;
                    lb2.Visible = true;
                    lb3.Visible = true;
                }
                else
                {
                    label8.Text = "Chưa có công thức";
                    lb1.Visible = false;
                    lb2.Visible = false;
                    lb3.Visible = false;
                }
            }
        }

            public void LoadCBB()
        {
            cbb_loctrangthai.Items.Add("Tất cả");
            cbb_loctrangthai.Items.Add("Hoạt động");
            cbb_loctrangthai.Items.Add("Không hoạt động");
            cbb_loctrangthai.SelectedIndex = 0;
            cbb_locloaihinhkm.Items.Add("Tất cả");
            cbb_locloaihinhkm.Items.Add("%");
            cbb_locloaihinhkm.Items.Add("$");
            cbb_locloaihinhkm.SelectedIndex = 0;
            cbb_loaihinhkm.Items.Add("%");
            cbb_loaihinhkm.Items.Add("$");
            cbb_loaihinhkm.SelectedIndex = 0;
        }
        public void ClearForm()
        {
            LoadData();
            _uuDaiTichDiemView.Id = Guid.Empty;
            tb_ma.Text = "";
            tb_mucuudai.Text = "";
            cbb_loaihinhkm.SelectedIndex = 0;
            tb_sodiem.Text = "";
            rdb_hd.Checked = false;
            rdb_khd.Checked = false;

        }
        public void LoadData()
        {
            int stt = 1;
            dtg_show.ColumnCount = 7;
            dtg_show.Columns[0].Name = "Id";
            dtg_show.Columns[0].Visible = false;
            dtg_show.Columns[1].Name = "STT";
            dtg_show.Columns[2].Name = "Mã";
            dtg_show.Columns[3].Name = "Loại hình khuyến mại";
            dtg_show.Columns[4].Name = "Mức ưu đãi";
            dtg_show.Columns[5].Name = "Số điểm";
            dtg_show.Columns[6].Name = "Trạng thái";
            tb_ma.Enabled = false;
            dtg_show.Rows.Clear();
            _lstUuDaiTichDiem = _iUuDaiTichDiemServices.GetAll().Where(c=>c.LoaiHinhKm.ToLower().Contains(tb_timkiem.Text.ToLower())).OrderBy(x=>x.Ma).ToList();
            foreach (var item in _lstUuDaiTichDiem)
            {
                dtg_show.Rows.Add(item.Id, stt++, item.Ma, item.LoaiHinhKm,item.MucUuDai,item.SoDiem, item.TrangThai == 1 ? "Hoạt động" : "Không hoạt động");
            }
        }
        private void btn_them_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Bạn có muốn thêm không?", "Cảnh báo!", MessageBoxButtons.YesNo);
            if(dlr == DialogResult.Yes)
            {
                if (tb_mucuudai.Text == "")
                {
                    MessageBox.Show("Không được để trống mức ưu đãi");
                }
                else if (tb_sodiem.Text == "")
                {
                    MessageBox.Show("Không được để trống số điểm");
                }
                else if (_iUuDaiTichDiemServices.GetAll().Any(c => c.SoDiem == Convert.ToDecimal(tb_sodiem.Text)))
                {
                    MessageBox.Show("Điểm bị trùng với ưu đãi khác!");
                }
                else if (ValidateInput.CheckIntInput(tb_sodiem.Text) == false || Convert.ToDecimal(tb_sodiem.Text) == 0)
                {
                    MessageBox.Show("Vui lòng nhập đúng số điểm");
                }
                else if (Convert.ToDecimal(tb_mucuudai.Text) == 0)
                {
                    MessageBox.Show("Mức ưu đãi không được bằng 0");
                }
                else if (cbb_loaihinhkm.Text == "%" && Convert.ToDecimal(tb_mucuudai.Text) > 100)
                {
                    MessageBox.Show("Không được quá 100%");
                }
                else if (rdb_hd.Checked == false && rdb_khd.Checked == false)
                {
                    MessageBox.Show("Vui lòng chọn trạng thái");
                }
                else
                {
                    var x = new UuDaiTichDiemView()
                    {
                        Id = new Guid(),
                        LoaiHinhKm = cbb_loaihinhkm.Text,
                        MucUuDai = Convert.ToDecimal(tb_mucuudai.Text),
                        SoDiem = Convert.ToDecimal(tb_sodiem.Text),
                        TrangThai = rdb_hd.Checked ? 1 : 0
                    };
                    MessageBox.Show(_iUuDaiTichDiemServices.Add(x));
                    ClearForm();
                }
            }
            else
            {
                MessageBox.Show("Bạn đã hủy lựa chọn!");
            }
            
           
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Bạn có muốn xóa không?", "Cảnh báo!", MessageBoxButtons.YesNo);
            if (dlr == DialogResult.Yes)
            {
                if (_uuDaiTichDiemView.Id == Guid.Empty)
                {
                    MessageBox.Show("Vui lòng chọn ưu đãi cần xóa!");
                }
                else
                {
                    MessageBox.Show(_iUuDaiTichDiemServices.Delete(_uuDaiTichDiemView));
                    ClearForm();
                }
            }
            else
            {
                MessageBox.Show("Bạn đã hủy lựa chọn!");
            }
               
            
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Bạn có muốn cập nhật không?", "Cảnh báo!", MessageBoxButtons.YesNo);
            if (dlr == DialogResult.Yes)
            {
                if (_uuDaiTichDiemView.Id == Guid.Empty)
                {
                    MessageBox.Show("Vui lòng chọn ưu đã cần cập nhật!");
                }
                else
                {
                    _uuDaiTichDiemView.LoaiHinhKm = cbb_loaihinhkm.Text;
                    _uuDaiTichDiemView.MucUuDai = Convert.ToDecimal(tb_mucuudai.Text);
                    _uuDaiTichDiemView.SoDiem = Convert.ToDecimal(tb_sodiem.Text);
                    _uuDaiTichDiemView.TrangThai = rdb_hd.Checked ? 1 : 0;
                    MessageBox.Show(_iUuDaiTichDiemServices.Update(_uuDaiTichDiemView));
                    ClearForm();
                }
               
            }
            else
            {
                MessageBox.Show("Bạn đã hủy lựa chọn!");
            }
            
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void dtg_show_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow r = dtg_show.Rows[e.RowIndex];
                _uuDaiTichDiemView = _iUuDaiTichDiemServices.GetAll().FirstOrDefault(x => x.Id == Guid.Parse(r.Cells[0].Value.ToString()));
                cbb_loaihinhkm.Text = _uuDaiTichDiemView.LoaiHinhKm;
                tb_mucuudai.Text = Convert.ToString(_uuDaiTichDiemView.MucUuDai);
                tb_sodiem.Text = Convert.ToString(_uuDaiTichDiemView.SoDiem);
                rdb_hd.Checked = _uuDaiTichDiemView.TrangThai == 1;
                rdb_khd.Checked = _uuDaiTichDiemView.TrangThai == 0;
            }
        }

        private void tb_sodiem_TextChanged(object sender, EventArgs e)
        {
            //if (tb_sodiem.Text != "" && CheckValidate.InputIsOnlyNumber(tb_sodiem.Text) && tb_sodiem.Text.Length < 3)
            //{
            //    tb_mucUudai.Text = (Convert.ToDecimal(_iUuDaiTichDiemServices.GetAll().FirstOrDefault(c => c.MucUuDai = tb_mucUudai.Text).chiTietSp.GiaBan) * Convert.ToDecimal(tb_sl.Text)).ToString();
            //    tb_sodiem.Text = (Convert.ToDecimal(tb_mucUudai.Text) * 95 / 100).ToString();
            //}
        }

        private void tb_timkiem_TextChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        private void cbb_locloaihinhkm_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbb_locloaihinhkm.Text == "Tất cả")
            {
                LoadData();
            }
            else if (cbb_locloaihinhkm.Text == "%")
            {
                int stt = 1;
                dtg_show.ColumnCount = 7;
                dtg_show.Columns[0].Name = "Id";
                dtg_show.Columns[0].Visible = false;
                dtg_show.Columns[1].Name = "STT";
                dtg_show.Columns[2].Name = "Mã";
                dtg_show.Columns[3].Name = "Loại hình khuyến mại";
                dtg_show.Columns[4].Name = "Mức ưu đãi";
                dtg_show.Columns[5].Name = "Số điểm";
                dtg_show.Columns[6].Name = "Trạng thái";
                tb_ma.Enabled = false;
                dtg_show.Rows.Clear();
                _lstUuDaiTichDiem = _iUuDaiTichDiemServices.GetAll().Where(c => c.LoaiHinhKm.Contains("%")).OrderBy(c=>c.Ma).ToList();
                foreach (var item in _lstUuDaiTichDiem)
                {
                    dtg_show.Rows.Add(item.Id, stt++, item.Ma, item.LoaiHinhKm, item.MucUuDai, item.SoDiem, item.TrangThai == 1 ? "Hoạt động" : "Không hoạt động");
                }
            }
            else
            {
                int stt = 1;
                dtg_show.ColumnCount = 7;
                dtg_show.Columns[0].Name = "Id";
                dtg_show.Columns[0].Visible = false;
                dtg_show.Columns[1].Name = "STT";
                dtg_show.Columns[2].Name = "Mã";
                dtg_show.Columns[3].Name = "Loại hình khuyến mại";
                dtg_show.Columns[4].Name = "Mức ưu đãi";
                dtg_show.Columns[5].Name = "Số điểm";
                dtg_show.Columns[6].Name = "Trạng thái";
                tb_ma.Enabled = false;
                dtg_show.Rows.Clear();
                _lstUuDaiTichDiem = _iUuDaiTichDiemServices.GetAll().Where(c => c.LoaiHinhKm.Contains("$")).OrderBy(c => c.Ma).ToList();
                foreach (var item in _lstUuDaiTichDiem)
                {
                    dtg_show.Rows.Add(item.Id, stt++, item.Ma, item.LoaiHinhKm, item.MucUuDai, item.SoDiem, item.TrangThai == 1 ? "Hoạt động" : "Không hoạt động");
                }
            }

        }

        private void cbb_loctrangthai_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbb_loctrangthai.Text == "Tất cả")
            {
                LoadData();
            }
            else if (cbb_loctrangthai.Text == "Hoạt động")
            {
                int stt = 1;
                dtg_show.ColumnCount = 7;
                dtg_show.Columns[0].Name = "Id";
                dtg_show.Columns[0].Visible = false;
                dtg_show.Columns[1].Name = "STT";
                dtg_show.Columns[2].Name = "Mã";
                dtg_show.Columns[3].Name = "Loại hình khuyến mại";
                dtg_show.Columns[4].Name = "Mức ưu đãi";
                dtg_show.Columns[5].Name = "Số điểm";
                dtg_show.Columns[6].Name = "Trạng thái";
                tb_ma.Enabled = false;
                dtg_show.Rows.Clear();
                _lstUuDaiTichDiem = _iUuDaiTichDiemServices.GetAll().Where(c => c.TrangThai == 1).OrderBy(c => c.Ma).ToList();
                foreach (var item in _lstUuDaiTichDiem)
                {
                    dtg_show.Rows.Add(item.Id, stt++, item.Ma, item.LoaiHinhKm, item.MucUuDai, item.SoDiem, item.TrangThai == 1 ? "Hoạt động" : "Không hoạt động");
                }
            }
            else
            {
                int stt = 1;
                dtg_show.ColumnCount = 7;
                dtg_show.Columns[0].Name = "Id";
                dtg_show.Columns[0].Visible = false;
                dtg_show.Columns[1].Name = "STT";
                dtg_show.Columns[2].Name = "Mã";
                dtg_show.Columns[3].Name = "Loại hình khuyến mại";
                dtg_show.Columns[4].Name = "Mức ưu đãi";
                dtg_show.Columns[5].Name = "Số điểm";
                dtg_show.Columns[6].Name = "Trạng thái";
                tb_ma.Enabled = false;
                dtg_show.Rows.Clear();
                _lstUuDaiTichDiem = _iUuDaiTichDiemServices.GetAll().Where(c => c.TrangThai == 0).OrderBy(c => c.Ma).ToList();
                foreach (var item in _lstUuDaiTichDiem)
                {
                    dtg_show.Rows.Add(item.Id, stt++, item.Ma, item.LoaiHinhKm, item.MucUuDai, item.SoDiem, item.TrangThai == 1 ? "Hoạt động" : "Không hoạt động");
                }
            }
        }

        private void btn_congthuc_Click(object sender, EventArgs e)
        {
            FrmCongThuc frmCongThuc = new FrmCongThuc();
            frmCongThuc.ShowDialog();
            LoadDT();
        }

        private void tb_mucuudai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void tb_sodiem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void cbb_loaihinhkm_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbb_loaihinhkm.Text == "%")
            {
                lb_mucuudai.Text = "Ưu đãi %";
                lb_km.Text = "%";
            }
            else
            {
                lb_mucuudai.Text = "Ưu đãi $";
                lb_km.Text = "$";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random random = new Random();
            int one = random.Next(0, 255);
            int two = random.Next(0, 255);
            int three = random.Next(0, 255);
            int four = random.Next(0, 255);

            lb_ud.ForeColor = Color.FromArgb(one, two, three, four);
            //btn_them.BackColor = Color.FromArgb(one, two, three, four);
            //btn_sua.BackColor = Color.FromArgb(one, two, three, four);
            //btn_xoa.BackColor = Color.FromArgb(one, two, three, four);
            //btn_clear.BackColor = Color.FromArgb(one, two, three, four);
        }

        private void FrmUuDaiTichDiem_Load(object sender, EventArgs e)
        {
            timer1.Start();
            timer1.Enabled = true;
        }

        private void tb_mucuudai_TextChanged(object sender, EventArgs e)
        {
            if(cbb_loaihinhkm.Text == "%" && Convert.ToDecimal(tb_mucuudai.Text) > 100)
            {
                tb_mucuudai.Text = "100";
            }
        }
    }
}
