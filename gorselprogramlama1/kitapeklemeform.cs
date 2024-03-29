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
    public partial class kitapeklemeform : Form
    {
        public kitapeklemeform()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            kitapeklemeverigirisi kitapeklemeverigirisiForm = new kitapeklemeverigirisi();

            
            kitapeklemeverigirisiForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
          this.Close(); 
        }
    }
}
