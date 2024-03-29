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


using System.IO;

namespace gorselprogramlama1
{
    public partial class uyeeklemeverigirisi : Form
    {
        public List<VeriModeli> uyeler; 
        public class VeriModeli
        {
            public string UyeAd { get; set; }
            public string UyeNo { get; set; }
        }



        public uyeeklemeverigirisi()
        {
            InitializeComponent();
            uyeler = new List<VeriModeli>();

            DataTable booksdata = new DataTable();
            booksdata.Columns.Add("Member Id:");
            booksdata.Columns.Add("Member Name:");
            booksdata.Columns.Add("Member Mail:");
            dataGridView1.DataSource = uyeler;


            try
            {
                string json = File.ReadAllText("Uyeler.json");
                List<VeriModeli> Uyeler = JsonConvert.DeserializeObject<List<VeriModeli>>(json);
                foreach (VeriModeli uye in Uyeler)
                {
                    uyeler.Add(uye);
                }
            }
            catch (Exception ex) { }
        }

        private void kaydet_Click(object sender, EventArgs e)
        {
            
            VeriModeli veri = new VeriModeli
            {
                UyeAd = uyeadTextBox.Text,
                UyeNo = uyenoTextBox.Text
            };
            uyeler.Add(veri);
             
            string json = JsonConvert.SerializeObject(uyeler);
            File.WriteAllText("Uyeler.json", json);

            
            if (!File.Exists("Uyeler.json"))
            {
                using (StreamWriter sw = File.CreateText("Uyeler.json"))
                {
                    sw.WriteLine("");
                }
            }

            MessageBox.Show("Veriler başarıyla kaydedildi.");
        }






        private void goruntule_Click(object sender, EventArgs e)
        {
            
            if (File.Exists("Uyeler.json"))
            {
                try
                {
                    string json = File.ReadAllText("Uyeler.json");
                    List<VeriModeli> veriler = JsonConvert.DeserializeObject<List<VeriModeli>>(json);


                    DataTable dt = new DataTable();
                    dt.Columns.Add("Member Id:");
                    dt.Columns.Add("Member Name:");
                    foreach (VeriModeli veri in veriler)
                    {
                        dt.Rows.Add(veri.UyeAd, veri.UyeNo);
                    }
                    dataGridView1.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Uyeler okunurken bir hata oluştu: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Veri dosyası bulunamadı.");
            }
        }




    }
}