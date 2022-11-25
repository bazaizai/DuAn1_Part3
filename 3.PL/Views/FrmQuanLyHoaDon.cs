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
    public partial class FrmQuanLyHoaDon : Form
    {
        public FrmQuanLyHoaDon()
        {
            InitializeComponent();
        }
        private void LoadData()
        {
            dataGridView1.ColumnCount = 10;
        }
    }
}
