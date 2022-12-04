using _2.BUS.IServices;
using _2.BUS.Services;
using _2.BUS.ViewModels;
using _3.PL.Utilities;
using CustomAlertBoxDemo;
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
    public partial class FrmQLKieuSP : Form
    {
        private IKieuSpServices _IkieuSpServices;
        private Guid _selectId;
        public FrmQLKieuSP()
        {
            InitializeComponent();
            _IkieuSpServices = new KieuSpServices();
            _selectId = new Guid();
            txtMa.Texts = _IkieuSpServices.Mats();
            LoadData();
            LoadCcb();
        }
        private void LoadCcb()
        {
            cbb_cha.Items.Clear();
            cbb_cha.Items.Add("Không");
            var list = _IkieuSpServices.GetAll();
            if (list.Count != 0)
            {
                foreach (var item in list)
                {
                    cbb_cha.Items.Add(item.Ten);
                }
            }
        }
        private KieuSpView Obj() => _IkieuSpServices.GetById(_selectId);


        private void LoadData()
        {
            int stt = 1;
            var _lst = _IkieuSpServices.GetAll();
            dtgView.Columns.Clear();
            dtgView.ColumnCount = 6;
            dtgView.Columns[0].Name = "ID";
            dtgView.Columns[0].Visible = false;
            dtgView.Columns[1].Name = "STT";
            dtgView.Columns[2].Name = "Ma";
            dtgView.Columns[3].Name = "Name";
            dtgView.Columns[4].Name = "Loại cha";
            dtgView.Columns[5].Name = "Trạng Thái";
            if (txtSearch.Texts != "")
            {
                _lst = _IkieuSpServices.GetAll().Where(x => x.Ten.ToLower().Contains(txtSearch.Texts.ToLower()) || x.Ma.ToLower().Contains(txtSearch.Texts.ToLower())).ToList();
            }
            foreach (var x in _lst)
            {
                if (_IkieuSpServices.GetAll().FirstOrDefault(c => c.Id == x.IdCha) == null)
                {
                    dtgView.Rows.Add(x.Id, stt++, x.Ma, x.Ten, "Không", x.TrangThai == 0 ? "Hoạt động" : "Không hoạt động");
                }
                else dtgView.Rows.Add(x.Id, stt++, x.Ma, x.Ten, _IkieuSpServices.GetAll().FirstOrDefault(c => c.Id == x.IdCha).Ten, x.TrangThai == 0 ? "Hoạt động" : "Không hoạt động");
            }
            rdoKhongHoatDong.Checked = true;
            txtMa.Texts = _IkieuSpServices.Mats();
            _selectId = new Guid();
            txtTen.Texts = "";
        }

        private string Cell(int x) => dtgView.CurrentRow.Cells[x].Value.ToString();

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (_IkieuSpServices.GetAll().FirstOrDefault(c => c.Ten == cbb_cha.Texts) == null)
            {
                MessageBox.Show(_IkieuSpServices.Add(new KieuSpView(_IkieuSpServices.Mats(), txtTen.Texts, null, rdoHoatDong.Checked ? 0 : 1)));
                LoadData();
                LoadCcb();
            }
            else
            {
                MessageBox.Show(_IkieuSpServices.Add(new KieuSpView(_IkieuSpServices.Mats(), txtTen.Texts, _IkieuSpServices.GetAll().FirstOrDefault(c => c.Ten == cbb_cha.Texts).Id, rdoHoatDong.Checked ? 0 : 1)));
                LoadData();
                LoadCcb();
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (Obj() != null)
            {
                var temp = _IkieuSpServices.GetAll().FirstOrDefault(c => c.Ten == cbb_cha.Texts);
                if (temp == null)
                {
                    MessageBox.Show(_IkieuSpServices.Update(new KieuSpView(_selectId, _IkieuSpServices.Mats(), txtTen.Texts, null, rdoHoatDong.Checked ? 0 : 1)));
                    LoadData();
                    LoadCcb();
                }
                else
                {

                    if (check(Obj(),temp))
                    {
                        MessageBox.Show(_IkieuSpServices.Update(new KieuSpView(_selectId, _IkieuSpServices.Mats(), txtTen.Texts, temp.Id, rdoHoatDong.Checked ? 0 : 1)));
                        LoadData();
                        LoadCcb();
                        MessageBox.Show("if");
                    }
                    else
                    {
                        MessageBox.Show("else");
                    }
                   
                }

            }
            else
            {
                MessageBox.Show("Vui lòng Cellclick");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (Obj() != null)
            {
                MessageBox.Show(_IkieuSpServices.Delete(Obj()));
                LoadData();
                LoadCcb();
            }
            else
            {
                MessageBox.Show("Vui lòng Cellclick");
            }
        }


        private void txtSearch__TextChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        private bool check(KieuSpView objchinh, KieuSpView obj)
        {
            if (obj.IdCha == null && obj.Id != objchinh.Id)
            {
                return true;
            }
            else if (obj.IdCha == objchinh.Id)
            {
                return false;
            }
            else
            {
                var temp = _IkieuSpServices.GetAll().FirstOrDefault(c => c.Id == obj.IdCha);
                MessageBox.Show(temp.Id.ToString()) ;
                if (temp.IdCha == null && temp.Id != objchinh.Id)
                {
                    return true;
                }
                else if (temp.IdCha == objchinh.Id)
                {
                    return false;
                }
                else { return check(objchinh, temp); }
            }
        }

        private void dtgView_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            _selectId = Guid.Parse(Cell(0));
        }

        private void dtgView_DoubleClick_1(object sender, EventArgs e)
        {
            tabthongtin.SelectedTab = tabInput;
            _selectId = Guid.Parse(Cell(0));
            txtMa.Texts = Cell(2);
            txtTen.Texts = Cell(3);
        }
    }
}
