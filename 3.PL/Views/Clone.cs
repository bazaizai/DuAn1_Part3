using _2.BUS.IServices;
using _2.BUS.Services;
using _2.BUS.ViewModels;
using _3.PL.Properties;
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
    public partial class Clone : Form
    {
        private IChiTietSaleServices _IchiTietSaleServices;
        private IChiTietSpServices _chiTietSpServices;
        private ISaleServices _SaleServices;
        private List<ChiTietSaleView> _lstCtsle;
        private List<SaleView> lstSale;
        private List<ChiTietSpViews> ChiTietSpViews;

        private Guid IDCtsp;
        private Guid IDsale;
        private ChiTietSpViews chiTietSpViews;

        public Clone()
        {
            InitializeComponent();
            _IchiTietSaleServices = new ChiTietSaleServices();
            _chiTietSpServices = new ChiTietSpServices();
            _SaleServices = new SaleServices();
            _lstCtsle = new List<ChiTietSaleView>();
            lstSale = new List<SaleView>();
            loadCTSP();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<SPSelected> selcted = ((List<SPSelected>)dtg_sp.DataSource).Where(c => c.Selected).ToList();
            MessageBox.Show(selcted.Count.ToString());
        }
        private void loadCTSP()
        {

            List<SPSelected> selcted = new List<SPSelected>();
            foreach (var item in _chiTietSpServices.GetAll().Where(c => c.TrangThaiKhuyenMai == 0))
            {
                //dtg_sp.Rows.Add(item.Id, item.TenSP, item.TenMauSac, item.TenTeam);
                SPSelected sPSelected = new SPSelected()
                {
                    Id = item.Id.ToString(),
                    TenSanPham = item.TenSP,
                    MauSac = item.TenMauSac,
                    Team = item.TenTeam,
                    KieuSp = "acb",

                };
                selcted.Add(sPSelected);
            }
            dtg_sp.DataSource = selcted;
        }
    }
}
