using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using System;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace gorselprogramlama1
{
    public partial class emanetislemleriverigirisi : Form
    {


        public class VeriModeli
        {
            public string KitapTeslim { get; set; }
            public string UyelikNo { get; set; }
            
        }






        public emanetislemleriverigirisi()
        {
            InitializeComponent();
        }

        private void Kaydet_Click(object sender, EventArgs e)
        {
            // TextBox'lardan alınan verileri bir nesne içine yerleştirin
            VeriModeli veri = new VeriModeli
            {
                KitapTeslim = kitapteslimTextBox.Text,
                UyelikNo = uyeliknoTextBox.Text,
                // Diğer verileri de aynı şekilde ekleyin
            };

            // JSON dosyasına verileri yazın
            string json = JsonConvert.SerializeObject(veri);
            File.WriteAllText("emanetislemleri.json", json);

            MessageBox.Show("Veriler başarıyla kaydedildi.");
        }

        private void goruntule_Click(object sender, EventArgs e)
        {
            // JSON dosyasından verileri okuyun
            if (File.Exists("emanetislemleri.json"))
            {
                try
                {
                    string json = File.ReadAllText("emanetislemleri.json");
                    VeriModeli veri = JsonConvert.DeserializeObject<VeriModeli>(json);

                    // Okunan verileri TextBox'lara yerleştirin
                    kitapteslimTextBox.Text = veri.KitapTeslim;
                    uyeliknoTextBox.Text = veri.UyelikNo;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Veriler okunurken bir hata oluştu: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Veri dosyası bulunamadı.");
            }
        }
    }
}
