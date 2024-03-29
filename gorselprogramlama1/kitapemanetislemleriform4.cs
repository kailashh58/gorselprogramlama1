using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gorselprogramlama1
{
    public partial class kitapemanetislemleriform4 : Form
    {
        public kitapemanetislemleriform4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            emanetislemleriverigirisi form = new emanetislemleriverigirisi();
            form.Show();
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
