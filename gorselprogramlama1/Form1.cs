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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            kitapeklemeform form2 = new kitapeklemeform();
            form2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            uyeeklemeform form3 = new uyeeklemeform();
            form3.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            kitapemanetislemleriform4 form4 = new kitapemanetislemleriform4();
            form4.Show();
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
