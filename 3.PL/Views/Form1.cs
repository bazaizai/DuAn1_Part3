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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button1.Click += new EventHandler(button1_Click);
            button1_Click(null, null);

            //HelloWorldTest();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HelloWorldTest();
        }
        private void HelloWorldTest()
        {
            MessageBox.Show("Hello World!");
        }

    }
}
