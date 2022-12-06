using _2.BUS.IServices;
using _2.BUS.Services;
using _2.BUS.ViewModels;
using _3.PL.CustomControlls;
using _3.PL.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
            //CanChinhSize();
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

            dtg_show.Columns[1].Width = 40;
            dtg_show.Columns[2].Width = 70;
            dtg_show.Columns[3].Width = 160;
            dtg_show.Columns[4].Width = 100;
            dtg_show.Columns[5].Width = 90;
            dtg_show.Columns[6].Width = 80;
            dtg_show.Columns[7].Width = 100;
            dtg_show.Columns[8].Width = 130;
   

            dtg_show.Rows.Clear();
            _lstKhachHang = _iKhachHangServices.GetAll().Where(x => x.Ma.ToLower().Contains(tb_timkiem.Text.ToLower()) || x.Ten.ToLower().Contains(tb_timkiem.Text.ToLower()) || x.Sdt.ToLower().Contains(tb_timkiem.Text.ToLower())).OrderBy(c=>c.Ma).ToList();
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
            DialogResult result = RJMessageBox.Show("Bạn có muốn thêm không?", "Cảnh báo!", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                if (_iKhachHangServices.GetAll().Any(c => c.Ma == tb_ma.Text))
                {
                    RJMessageBox.Show("Mã bị trùng");
                }
                else if (string.IsNullOrWhiteSpace(tb_ten.Text))
                {
                    RJMessageBox.Show("Không được để trống tên!");
                } 
                else if (tb_ten.Text.Length < 2)
                {
                    RJMessageBox.Show("Tên quá ngắn!");
                }
                else if (CheckValidate.hasSpecialChar(tb_ten.Text))
                {
                    RJMessageBox.Show("Tên không hợp lệ!");
                }             
                else if (tb_sdt.Text == "")
                {
                    RJMessageBox.Show("Không được để trống số điện thoại!");
                }
                else if (_iKhachHangServices.GetAll().Any(c => c.Sdt == tb_sdt.Text))
                {
                    RJMessageBox.Show("Số điện thoại bị trùng");
                }
                else if (!CheckValidate.IsValidVietNamPhoneNumber(tb_sdt.Text))
                {
                    RJMessageBox.Show("Số điện thoại không hợp lệ!");
                }
                else if (rdb_hd.Checked == false && rdb_khd.Checked == false)
                {
                    RJMessageBox.Show("Không được để trống trạng thái!");
                }
                else
                {
                    var tichdiem = new TichDiemView()
                    {
                        Id = Guid.NewGuid(),
                        SoDiem = 0,
                        TrangThai = 1
                    };
                    RJMessageBox.Show(_itichDiemServices.Add(tichdiem));
                    var y = _itichDiemServices.GetAll().FirstOrDefault(c => c.Id == _tichDiemView.Id);
                    var x = new KhachHangView()
                    {
                        Id = new Guid(),
                        IdtichDiem = tichdiem.Id,
                        Ten = XoaDauCach(VietHoaChuCaiDau(tb_ten.Text.Trim())),
                        DiaChi = tb_diachi.Text,
                        Sdt = tb_sdt.Text,
                        TrangThai = rdb_hd.Checked ? 1 : 0
                    };

                    RJMessageBox.Show(_iKhachHangServices.Add(x));
                    ClearForm();
                }
            }
            else
            {
                RJMessageBox.Show("Bạn đã hủy lựa chọn");
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            DialogResult result = RJMessageBox.Show("Bạn có muốn sửa không?", "Cảnh báo!", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                //else if (_iKhachHangServices.GetAll().Any(c => c.Ma == tb_ma.Text))
                //{
                //    RJMessageBox.Show("Mã bị trùng");
                //}
                if (_khachHangView.Id == Guid.Empty)
                {
                    RJMessageBox.Show("Vui lòng chọn khách hàng cần sửa!");
                }
                else if (tb_ten.Text == "")
                {
                    RJMessageBox.Show("Không được để trống tên!");
                }               
                else if (tb_ten.Text.Length < 2)
                {
                    RJMessageBox.Show("Tên quá ngắn!");
                }
                //else if (!CheckValidate.KiemTraHoTen(tb_ten.Text))
                //{
                //    RJMessageBox.Show("Phải viết hoa chữ cái đầu!");
                //}
                else if (CheckValidate.hasSpecialChar(tb_ten.Text))
                {
                    RJMessageBox.Show("Tên không hợp lệ!");
                }
                else if (tb_sdt.Text == "")
                {
                    RJMessageBox.Show("Không được để trống số điện thoại!");
                }
                //else if (_iKhachHangServices.GetAll().Any(c => c.Sdt == tb_sdt.Text))
                //{
                //    RJMessageBox.Show("Số điện thoại bị trùng");
                //}
                else if (!CheckValidate.IsValidVietNamPhoneNumber(tb_sdt.Text))
                {
                    RJMessageBox.Show("Số điện thoại không hợp lệ!");
                }
                else if (rdb_hd.Checked == false && rdb_khd.Checked == false)
                {
                    RJMessageBox.Show("Không được để trống trạng thái!");
                }
                else
                {
                    _khachHangView.Ten = XoaDauCach(VietHoaChuCaiDau(tb_ten.Text.Trim()));
                    _khachHangView.DiaChi = tb_diachi.Text;
                    _khachHangView.Sdt = tb_sdt.Text;
                    _khachHangView.TrangThai = rdb_hd.Checked ? 1 : 0;
                    RJMessageBox.Show(_iKhachHangServices.Update(_khachHangView));
                    ClearForm();
                }
            }
            else
            {
                RJMessageBox.Show("Bạn đã hủy lựa chọn");
            }

        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            DialogResult result = RJMessageBox.Show("Bạn có muốn xóa không?", "Cảnh báo!", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                if (_khachHangView.Id == Guid.Empty)
                {
                    RJMessageBox.Show("Vui lòng chọn khách hàng cần xóa!");
                }
                else
                {
                    RJMessageBox.Show(_iKhachHangServices.Delete(_khachHangView));
                    ClearForm();
                }
            }
            else
            {
                RJMessageBox.Show("Bạn đã hủy lựa chọn");
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
                _lstKhachHang = _iKhachHangServices.GetAll().Where(c => c.TrangThai == 1).OrderBy(c=>c.Ma).ToList();
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
                _lstKhachHang = _iKhachHangServices.GetAll().Where(c => c.TrangThai == 0).OrderBy(c=>c.Ma).ToList();
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
                _lstKhachHang = _iKhachHangServices.GetAll().Where(c => c.Sdt.StartsWith("03") || c.Sdt.StartsWith("09")).OrderBy(c=>c.Ma).ToList();
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
                _lstKhachHang = _iKhachHangServices.GetAll().Where(c => c.Sdt.StartsWith("07")).OrderBy(c=>c.Ma).ToList();
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
                _lstKhachHang = _iKhachHangServices.GetAll().Where(c => c.Sdt.StartsWith("08")).OrderBy(c=>c.Ma).ToList();
                foreach (var item in _lstKhachHang)
                {
                    dtg_show.Rows.Add(item.Id, stt++, item.Ma, item.Ten, item.Sdt, item.NhaMang, item.DiaChi,item.SoDiem, item.TrangThai == 1 ? "Hoạt động" : "Không hoạt động");
                }
            }
        }
       
        private void dtg_show_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {

        }

        private void dtg_show_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {

        }


        //private string RemoveWhiteSpace(string z)
        //{
        //    string x = "";
        //    string[] list = z.Split(' ');
        //    for (int i = 0; i < list.Length; i++)
        //    {
        //        x += " " + list[i];
                
        //    }
        //    return x;
        //}

        private string XoaDauCach(string s)
        {
 
            while (s.Trim().Contains("  "))
            {
                s = s.Replace("  ", " "); // Xóa 2 dấu cách thành 1 dấu cho đến khi hết
            }
            return s;
        }
             
        private void tb_ten_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;


        }

        private void tb_sdt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        //string titleCase = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(str.ToLower());
        public static string VietHoaChuCaiDau(string value)
        {
            value = value.ToLower();
            char[] array = value.ToCharArray();
            if (array.Length >= 1)
            {
                if (char.IsLower(array[0]))
                {
                    array[0] = char.ToUpper(array[0]);
                }
            }

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i - 1] == ' ')
                {
                    if (char.IsLower(array[i]))
                    {
                        array[i] = char.ToUpper(array[i]);
                    }
                }
            }
            return new string(array);
        }


        private void tb_ten_TextChanged(object sender, EventArgs e)
        {
            if(tb_ten.Text == " ")
            {
                tb_ten.Text = "";
            }
        }

        private void tb_sdt_TextChanged(object sender, EventArgs e)
        {
           
        }
        int x;
        private void timer1_Tick(object sender, EventArgs e)
        {

            Random random = new Random();
            int one = random.Next(0, 255);
            int two = random.Next(0, 255);
            int three = random.Next(0, 255);
            int four = random.Next(0, 255);

            lb_kh.ForeColor = Color.FromArgb(one, two, three, four);
        }

        private void FrmKhachHang_Load(object sender, EventArgs e)
        {
            timer1.Start();
            timer1.Enabled = true;
        }


        //public void CanChinhSize()
        //{
        //    FrmKhachHang frmKhachHang = new FrmKhachHang();
        //    frmKhachHang.dtg_show.Columns[1].Width = 60;
        //}
    }
}
