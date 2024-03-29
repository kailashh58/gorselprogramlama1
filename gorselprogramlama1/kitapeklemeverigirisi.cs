using System;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace gorselprogramlama1
{
    public partial class kitapeklemeverigirisi : Form
    {
       
        public class VeriModeli
        {
            public string KitapAdi { get; set; }
            public string YazarAdi { get; set; }
            public string Tur { get; set; }
           
        }

        public kitapeklemeverigirisi()
        {
            InitializeComponent();
        }

        
        private void kaydetButton_Click(object sender, EventArgs e)
        {
           
            VeriModeli veri = new VeriModeli
            {
                KitapAdi = kitapadiTextBox.Text,
                YazarAdi = yazaradiTextBox.Text,
                Tur = turTextBox.Text,
              
            };

            
            string json = JsonConvert.SerializeObject(veri);
            File.WriteAllText("veriler.json", json);

            
            if (!File.Exists("veriler.json"))
            {
                using (StreamWriter sw = File.CreateText("veriler.json"))
                {
                    sw.WriteLine("");
                }
            }

            MessageBox.Show("Veriler başarıyla kaydedildi.");
        }

       
        private void goruntuleButton_Click(object sender, EventArgs e)
        {
           
            if (File.Exists("veriler.json"))
            {
                try
                {
                    string json = File.ReadAllText("veriler.json");
                    VeriModeli veri = JsonConvert.DeserializeObject<VeriModeli>(json);

                    
                    kitapadiTextBox.Text = veri.KitapAdi;
                    yazaradiTextBox.Text = veri.YazarAdi;
                    turTextBox.Text = veri.Tur;
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