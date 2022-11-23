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
using System.Windows.Controls;
using System.Windows.Forms;

namespace _3.PL.Views
{
    public partial class FrmKhachHang : Form
    {
        public IKhachHangServices _iKhachHangServices;
        public ITichDiemServices _itichDiemServices;
        public KhachHangView _khachHangView;
        public TichDiemView _tichDiemView;
        public List<KhachHangView> _lstKhachHang;
        public FrmKhachHang()
        {
            InitializeComponent();
            _iKhachHangServices = new KhachHangServices();
            _itichDiemServices = new TichDiemServices();
            _khachHangView = new KhachHangView();
            _tichDiemView = new TichDiemView();
            _lstKhachHang = new List<KhachHangView>();
            LoadData();
            LoadCbb();
        }
        private string _message;
        public FrmKhachHang(string Message) : this()
        {
            _message = Message;
            tb_sdt.Text = _message;
        }
        public void LoadData()
        {
            int stt = 1;
            dtg_show.ColumnCount = 9;
            dtg_show.Columns[0].Name = "Id";
            dtg_show.Columns[0].Visible = false;
            dtg_show.Columns[1].Name = "STT";
            dtg_show.Columns[2].Name = "Mã";
            dtg_show.Columns[3].Name = "Tên khách hàng";
            dtg_show.Columns[4].Name = "SDT";
            dtg_show.Columns[5].Name = "Nhà mạng";
            dtg_show.Columns[6].Name = "Địa chỉ";
            dtg_show.Columns[7].Name = "Số điểm";
            dtg_show.Columns[8].Name = "Trạng thái";
            tb_ma.Enabled = false;

            dtg_show.Rows.Clear();
            _lstKhachHang = _iKhachHangServices.GetAll().Where(x => x.Ma.ToLower().Contains(tb_timkiem.Text.ToLower()) || x.Ten.ToLower().Contains(tb_timkiem.Text.ToLower()) || x.Sdt.ToLower().Contains(tb_timkiem.Text.ToLower())).ToList();
            foreach (var item in _lstKhachHang)
            {
                dtg_show.Rows.Add(item.Id, stt++, item.Ma, item.Ten, item.Sdt, item.NhaMang, item.DiaChi, item.SoDiem, item.TrangThai == 1 ? "Hoạt động" : "Không hoạt động");
            }
        }

        public void ClearForm()
        {
            LoadData();
            _khachHangView.Id = Guid.Empty;
            tb_ten.Text = "";
            tb_diachi.Text = "";
            tb_sdt.Text = "";
            rdb_hd.Checked = false;
            rdb_khd.Checked = false;
        }
        private void btn_them_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thêm không?", "Cảnh báo!", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                if (_iKhachHangServices.GetAll().Any(c => c.Ma == tb_ma.Text))
                {
                    MessageBox.Show("Mã bị trùng");
                }
                else if (tb_ten.Text == "")
                {
                    MessageBox.Show("Không được để trống tên!");
                }               
                else if (tb_sdt.Text == "")
                {
                    MessageBox.Show("Không được để trống số điện thoại!");
                }
                else if (_iKhachHangServices.GetAll().Any(c => c.Sdt == tb_sdt.Text))
                {
                    MessageBox.Show("Số điện thoại bị trùng");
                }
                else if (!CheckValidate.IsValidVietNamPhoneNumber(tb_sdt.Text))
                {
                    MessageBox.Show("Số điện thoại không hợp lệ!");
                }
                //else if (_iKhachHangServices.GetAll().Any(c => c.Email == tb_email.Text))
                //{
                //    MessageBox.Show("Email bị trùng");
                //}
                else if (rdb_hd.Checked == false && rdb_khd.Checked == false)
                {
                    MessageBox.Show("Không được để trống trạng thái!");
                }
                else
                {
                    var tichdiem = new TichDiemView()
                    {
                        Id = Guid.NewGuid(),
                        SoDiem = 0,
                        TrangThai = 0
                    };
                    MessageBox.Show(_itichDiemServices.Add(tichdiem));
                    var y = _itichDiemServices.GetAll().FirstOrDefault(c => c.Id == _tichDiemView.Id);
                    var x = new KhachHangView()
                    {
                        Id = new Guid(),
                        IdtichDiem = tichdiem.Id,
                        Ten = tb_ten.Text,
                        DiaChi = tb_diachi.Text,
                        Sdt = tb_sdt.Text,
                        TrangThai = rdb_hd.Checked ? 1 : 0
                    };

                    MessageBox.Show(_iKhachHangServices.Add(x));
                    ClearForm();
                }
            }
            else
            {
                MessageBox.Show("Bạn đã hủy lựa chọn");
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn sửa không?", "Cảnh báo!", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                if (tb_ma.Text == "")
                {
                    MessageBox.Show("Không được để trống mã!");
                }
                //else if (_iKhachHangServices.GetAll().Any(c => c.Ma == tb_ma.Text))
                //{
                //    MessageBox.Show("Mã bị trùng");
                //}
                else if (tb_ten.Text == "")
                {
                    MessageBox.Show("Không được để trống tên!");
                }
                else if (tb_sdt.Text == "")
                {
                    MessageBox.Show("Không được để trống số điện thoại!");
                }
                //else if (_iKhachHangServices.GetAll().Any(c => c.Sdt == tb_sdt.Text))
                //{
                //    MessageBox.Show("Số điện thoại bị trùng");
                //}
                else if (!CheckValidate.IsValidVietNamPhoneNumber(tb_sdt.Text))
                {
                    MessageBox.Show("Số điện thoại không hợp lệ!");
                }
                //else if (_iKhachHangServices.GetAll().Any(c => c.Email == tb_email.Text))
                //{
                //    MessageBox.Show("Email bị trùng");
                //}
                else if (rdb_hd.Checked == false && rdb_khd.Checked == false)
                {
                    MessageBox.Show("Không được để trống trạng thái!");
                }
                else
                {
                    _khachHangView.Ten = tb_ten.Text;
                    _khachHangView.DiaChi = tb_diachi.Text;
                    _khachHangView.Sdt = tb_sdt.Text;
                    _khachHangView.TrangThai = rdb_hd.Checked ? 1 : 0;
                    MessageBox.Show(_iKhachHangServices.Update(_khachHangView));
                    ClearForm();
                }
            }
            else
            {
                MessageBox.Show("Bạn đã hủy lựa chọn");
            }

        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn xóa không?", "Cảnh báo!", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                if (_khachHangView.Id == Guid.Empty)
                {
                    MessageBox.Show("Vui lòng chọn khách hàng cần xóa!");
                }
                else
                {
                    MessageBox.Show(_iKhachHangServices.Delete(_khachHangView));
                    ClearForm();
                }
            }
            else
            {
                MessageBox.Show("Bạn đã hủy lựa chọn");
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
                _khachHangView = _iKhachHangServices.GetAll().FirstOrDefault(x => x.Id == Guid.Parse(r.Cells[0].Value.ToString()));
                tb_ma.Text = _khachHangView.Ma;
                tb_ten.Text = _khachHangView.Ten;
                tb_diachi.Text = _khachHangView.DiaChi;
                tb_sdt.Text = _khachHangView.Sdt;
                rdb_hd.Checked = _khachHangView.TrangThai == 1;
                rdb_khd.Checked = _khachHangView.TrangThai == 0;
            }
        }

        //public void TimKiem()
        //{
        //    var lst = _iKhachHangServices.GetAll();
        //    if (tb_timkiem.Text != "")
        //    {
        //        lst = lst.Where(x => x.Ma.ToLower().Contains(tb_timkiem.Text.ToLower()) || x.Sdt.ToLower().Contains(tb_timkiem.Text.ToLower())).ToList();
        //    }
        //}
        private void tb_timkiem_TextChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dtg_show_MouseClick(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Right)
            {
                ContextMenuStrip menu = new ContextMenuStrip();
                int xy = dtg_show.HitTest(e.X, e.Y).RowIndex;


                if (xy >= 0)
                {
                    menu.Items.Add("Sửa").Name = "Sửa";
                    menu.Items.Add("Xóa").Name = "Xóa";
                }

                menu.Show(dtg_show, new Point(e.X, e.Y));
            }
        }
        private void LoadCbb()
        {
            cbb_loctrangthai.Items.Add("Tất cả");
            cbb_loctrangthai.Items.Add("Hoạt động");
            cbb_loctrangthai.Items.Add("Không hoạt động");
            cbb_loctrangthai.SelectedIndex = 0;
            cbb_locsdt.Items.Add("Tất cả");
            cbb_locsdt.Items.Add("Viettel");
            cbb_locsdt.Items.Add("Mobifone");
            cbb_locsdt.Items.Add("Vinaphone");
            cbb_locsdt.SelectedIndex = 0;
        }

        private void cbb_lockhachhang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbb_loctrangthai.Text == "Tất cả")
            {
                LoadData();
            }
            else if (cbb_loctrangthai.Text == "Hoạt động")
            {
                int stt = 1;
                dtg_show.ColumnCount = 9;
                dtg_show.Columns[0].Name = "Id";
                dtg_show.Columns[0].Visible = false;
                dtg_show.Columns[1].Name = "STT";
                dtg_show.Columns[2].Name = "Mã";
                dtg_show.Columns[3].Name = "Tên khách hàng";
                dtg_show.Columns[4].Name = "SDT";
                dtg_show.Columns[5].Name = "Nhà mạng";
                dtg_show.Columns[6].Name = "Địa chỉ";
                dtg_show.Columns[7].Name = "Số điểm";
                dtg_show.Columns[8].Name = "Trạng thái";
                tb_ma.Enabled = false;

                dtg_show.Rows.Clear();
                _lstKhachHang = _iKhachHangServices.GetAll().Where(c => c.TrangThai == 1).ToList();
                foreach (var item in _lstKhachHang)
                {
                    dtg_show.Rows.Add(item.Id, stt++, item.Ma, item.Ten, item.Sdt, item.NhaMang, item.DiaChi, item.SoDiem, item.TrangThai == 1 ? "Hoạt động" : "Không hoạt động");
                }
            }
            else if (cbb_loctrangthai.Text == "Không hoạt động")
            {
                int stt = 1;
                dtg_show.ColumnCount = 9;
                dtg_show.Columns[0].Name = "Id";
                dtg_show.Columns[0].Visible = false;
                dtg_show.Columns[1].Name = "STT";
                dtg_show.Columns[2].Name = "Mã";
                dtg_show.Columns[3].Name = "Tên khách hàng";
                dtg_show.Columns[4].Name = "SDT";
                dtg_show.Columns[5].Name = "Nhà mạng";
                dtg_show.Columns[6].Name = "Địa chỉ";
                dtg_show.Columns[7].Name = "Số điểm";
                dtg_show.Columns[8].Name = "Trạng thái";
                tb_ma.Enabled = false;

                dtg_show.Rows.Clear(); ;
                _lstKhachHang = _iKhachHangServices.GetAll().Where(c => c.TrangThai == 0).ToList();
                foreach (var item in _lstKhachHang)
                {
                    dtg_show.Rows.Add(item.Id, stt++, item.Ma, item.Ten, item.Sdt, item.NhaMang, item.DiaChi, item.SoDiem, item.TrangThai == 1 ? "Hoạt động" : "Không hoạt động");
                }
            }
        }

        private void cbb_locsdt_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbb_locsdt.Text == "Tất cả")
            {
                LoadData();
            }
            else if (cbb_locsdt.Text == "Viettel")
            {
                int stt = 1;
                dtg_show.ColumnCount = 9;
                dtg_show.Columns[0].Name = "Id";
                dtg_show.Columns[0].Visible = false;
                dtg_show.Columns[1].Name = "STT";
                dtg_show.Columns[2].Name = "Mã";
                dtg_show.Columns[3].Name = "Tên khách hàng";
                dtg_show.Columns[4].Name = "SDT";
                dtg_show.Columns[5].Name = "Nhà mạng";
                dtg_show.Columns[6].Name = "Địa chỉ";
                dtg_show.Columns[7].Name = "Số điểm";
                dtg_show.Columns[8].Name = "Trạng thái";
                tb_ma.Enabled = false;

                dtg_show.Rows.Clear();
                _lstKhachHang = _iKhachHangServices.GetAll().Where(c => c.Sdt.StartsWith("03") || c.Sdt.StartsWith("09")).ToList();
                foreach (var item in _lstKhachHang)
                {
                    dtg_show.Rows.Add(item.Id, stt++, item.Ma, item.Ten, item.Sdt, item.NhaMang, item.DiaChi, item.SoDiem, item.TrangThai == 1 ? "Hoạt động" : "Không hoạt động");
                }
            }
            else if (cbb_locsdt.Text == "Mobifone")
            {
                int stt = 1;
                dtg_show.ColumnCount = 9;
                dtg_show.Columns[0].Name = "Id";
                dtg_show.Columns[0].Visible = false;
                dtg_show.Columns[1].Name = "STT";
                dtg_show.Columns[2].Name = "Mã";
                dtg_show.Columns[3].Name = "Tên khách hàng";
                dtg_show.Columns[4].Name = "SDT";
                dtg_show.Columns[5].Name = "Nhà mạng";
                dtg_show.Columns[6].Name = "Địa chỉ";
                dtg_show.Columns[7].Name = "Số điểm";
                dtg_show.Columns[8].Name = "Trạng thái";
                tb_ma.Enabled = false;

                dtg_show.Rows.Clear();
                _lstKhachHang = _iKhachHangServices.GetAll().Where(c => c.Sdt.StartsWith("07")).ToList();
                foreach (var item in _lstKhachHang)
                {
                    dtg_show.Rows.Add(item.Id, stt++, item.Ma, item.Ten, item.Sdt, item.NhaMang, item.DiaChi, item.SoDiem, item.TrangThai == 1 ? "Hoạt động" : "Không hoạt động");
                }
            }
            else if (cbb_locsdt.Text == "Vinaphone")
            {
                int stt = 1;
                dtg_show.ColumnCount = 9;
                dtg_show.Columns[0].Name = "Id";
                dtg_show.Columns[0].Visible = false;
                dtg_show.Columns[1].Name = "STT";
                dtg_show.Columns[2].Name = "Mã";
                dtg_show.Columns[3].Name = "Tên khách hàng";
                dtg_show.Columns[4].Name = "SDT";
                dtg_show.Columns[5].Name = "Nhà mạng";
                dtg_show.Columns[6].Name = "Địa chỉ";
                dtg_show.Columns[7].Name = "Số điểm";
                dtg_show.Columns[8].Name = "Trạng thái";
                tb_ma.Enabled = false;

                dtg_show.Rows.Clear();
                _lstKhachHang = _iKhachHangServices.GetAll().Where(c => c.Sdt.StartsWith("08")).ToList();
                foreach (var item in _lstKhachHang)
                {
                    dtg_show.Rows.Add(item.Id, stt++, item.Ma, item.Ten, item.Sdt, item.NhaMang, item.DiaChi,item.SoDiem, item.TrangThai == 1 ? "Hoạt động" : "Không hoạt động");
                }
            }
        }

        private static readonly string[] VietnameseSigns = new string[]
        {
            "aAeEoOuUiIdDyY",

        "áàạảãâấầậẩẫăắằặẳẵ",

        "ÁÀẠẢÃÂẤẦẬẨẪĂẮẰẶẲẴ",

        "éèẹẻẽêếềệểễ",

        "ÉÈẸẺẼÊẾỀỆỂỄ",

        "óòọỏõôốồộổỗơớờợởỡ",

        "ÓÒỌỎÕÔỐỒỘỔỖƠỚỜỢỞỠ",

        "úùụủũưứừựửữ",

        "ÚÙỤỦŨƯỨỪỰỬỮ",

        "íìịỉĩ",

        "ÍÌỊỈĨ",

        "đ",

        "Đ",

        "ýỳỵỷỹ",

        "ÝỲỴỶỸ"
        };




        public static string RemoveDauTV(string str)
        {
            //Tiến hành thay thế , lọc bỏ dấu cho chuỗi

            for (int i = 1; i < VietnameseSigns.Length; i++)

            {

                for (int j = 0; j < VietnameseSigns[i].Length; j++)

                    str = str.Replace(VietnameseSigns[i][j], VietnameseSigns[0][i - 1]);

            }

            return str;
        }

    }
}
