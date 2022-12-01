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
    public partial class FrmCongThuc : Form
    {
        ICtTichDiemServices _iCtTichDiemServices;
        public FrmCongThuc()
        {
            InitializeComponent();
            _iCtTichDiemServices = new CtTichDiemServices();
            LoadData();
        }

        
        private void LoadData()
        {
            var x = _iCtTichDiemServices.GetAll();
            foreach (var xItem in x)
            {
                if (xItem != null)
                {
                    tb_quydoi.PlaceholderText = xItem.HeSoTich.ToString();
                    tb_quydoi.Text = xItem.HeSoTich.ToString();
                    radioButton1.Checked = xItem.TrangThai == 0;
                    radioButton2.Checked = xItem.TrangThai == 1;
                }

            }
           
        }
        private void btn_luw_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn lưu không?", "Cảnh báo!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                //if(tb_quydoi.Text == "")
                //{
                //    MessageBox.Show("Không được để trống");
                //}
                if (tb_quydoi.Text.Length > 9)
                {
                    MessageBox.Show("Không được nhập số tiền lớn như này");
                }
                //else if (Convert.ToInt32(tb_quydoi.Text) == 0)
                //{
                //    MessageBox.Show("Không được nhập số tiền bằng 0");
                //}
                else if (radioButton1.Checked == false && radioButton2.Checked == false)
                {
                    MessageBox.Show("Không được để trống trạng thái");
                }
                else
                {
                    var x = _iCtTichDiemServices.GetAll();
                    if (x.Count() == 0)
                    {
                        if (tb_quydoi.Text == "")
                        {
                            MessageBox.Show("Rỗng");
                        }
                        else
                        {
                            CtTinhDiemView ctTinhDiemView = new CtTinhDiemView()
                            {
                                Id = Guid.NewGuid(),
                                HeSoTich = Convert.ToInt32(tb_quydoi.Text),
                                TrangThai = radioButton1.Checked ? 0 : radioButton2.Checked ? 1 : 0
                            };
                            MessageBox.Show(_iCtTichDiemServices.Add(ctTinhDiemView));
                        }
                        
                    }
                    else
                    {
                        foreach (var item in x)
                        {
                            CtTinhDiemView ctTinhDiemView = new CtTinhDiemView()
                            {

                                Id = item.Id,                                                        
                                TrangThai = radioButton1.Checked ? 0 : radioButton2.Checked ? 1 : 0
                            };
                            if (tb_quydoi.Text == "")
                            {
                                ctTinhDiemView.HeSoTich = item.HeSoTich;
                            }
                            else
                            {
                                ctTinhDiemView.HeSoTich = Convert.ToInt32(tb_quydoi.Text);
                            }
                            MessageBox.Show(_iCtTichDiemServices.Update(ctTinhDiemView));
                        }

                    }
                    LoadData();
                }
                
            }
            else
            {
                MessageBox.Show("Bạn đã hủy lựa chọn!");
            }
            
        }

        private void tb_quydoi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
     
    }
}
