using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

using System;
using System.IO;
using System.Windows.Forms;

namespace gorselprogramlama1
{
    public partial class uyeeklemeverigirisi : Form
    {

        public class VeriModeli
        {
            public string UyeAd { get; set; }
            public string UyeNo { get; set; }
        }



        public uyeeklemeverigirisi()
        {
            InitializeComponent();
        }

        private void kaydet_Click(object sender, EventArgs e)
        {
            // TextBox'lardan alınan verileri bir nesne içine yerleştirin
            VeriModeli veri = new VeriModeli
            {
                UyeAd = uyeadTextBox.Text,
                UyeNo = uyenoTextBox.Text
            };

             // JSON dosyasına verileri yazın
            string json = JsonConvert.SerializeObject(veri);
            File.WriteAllText("veriler.json", json);

            // Verileri kaydettikten sonra dosyanın varlığını kontrol edin ve oluşturun
            if (!File.Exists("veriler.json"))
            {
                using (StreamWriter sw = File.CreateText("veriler.json"))
                {
                    sw.WriteLine("");
                }
            }

            MessageBox.Show("Veriler başarıyla kaydedildi.");
        }






        private void goruntule_Click(object sender, EventArgs e)
        {
            // JSON dosyasından verileri okuyun
            if (File.Exists("veriler.json"))
            {
                try
                {
                    string json = File.ReadAllText("veriler.json");
                    VeriModeli veri = JsonConvert.DeserializeObject<VeriModeli>(json);

                    // Okunan verileri TextBox'lara yerleştirin
                    uyeadTextBox.Text = veri.UyeAd;
                    uyenoTextBox.Text = veri.UyeNo;
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