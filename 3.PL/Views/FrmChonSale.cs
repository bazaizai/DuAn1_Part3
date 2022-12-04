using _2.BUS.IServices;
using _2.BUS.Services;
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
    public partial class FrmChonSale : Form
    {
        IChiTietSaleServices _IChiTietSaleServices;
        ISaleServices _ISaleServices;
        public Guid IDCTSP { get; set; }
        public FrmChonSale()
        {
            InitializeComponent();
            _IChiTietSaleServices = new ChiTietSaleServices();
            _ISaleServices = new SaleServices();
        }

        private void LoadData()
        {
            var ctsale = _IChiTietSaleServices.GetAll().Where(x => x.IdChiTietSp == IDCTSP && x.TrangThai == 0).ToList();
            foreach (var x in ctsale)
            {
                var Sale = _ISaleServices.GetAll().Find(y => y.Id == x.IdSale);
                dataGridView1.Rows.Add(Sale.Id, Sale.Ma, Sale.Ten, Sale.MucGiam,Sale.LoaiHinhKm) ;
            }
        }

        private void FrmChonSale_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Properties.Settings.Default.IDSale = Guid.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            this.Close();
        }
    }
}
