using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

using System.IO;
using Newtonsoft.Json;

namespace gorselprogramlama1
{
    public partial class emanetislemleriverigirisi : Form
    {

        List<VeriModeli> emanetler;
        public class VeriModeli
        {
            public string KitapTeslim { get; set; }
            public string UyelikNo { get; set; }
            
        }






        public emanetislemleriverigirisi()
        {
            emanetler = new List<VeriModeli>();
            InitializeComponent();
            DataTable booksdata = new DataTable();
            booksdata.Columns.Add("Member Id:");
            booksdata.Columns.Add("Member Name:");
            booksdata.Columns.Add("Member Mail:");
            dataGridView1.DataSource = emanetler;

        }

        private void Kaydet_Click(object sender, EventArgs e)
        {
           
            VeriModeli veri = new VeriModeli
            {
                KitapTeslim = kitapteslimTextBox.Text,
                UyelikNo = uyeliknoTextBox.Text,
                
            };
            emanetler.Add(veri);

            string json = JsonConvert.SerializeObject(emanetler);
            File.WriteAllText("emanetislemleri.json", json);

            MessageBox.Show("Veriler başarıyla kaydedildi.");
        }

        private void goruntule_Click(object sender, EventArgs e)
        {
            
            if (File.Exists("emanetislemleri.json"))
            {
                try
                {
                    string jsondata = File.ReadAllText("emanetislemleri.json");
                    List<VeriModeli> veriler = JsonConvert.DeserializeObject<List<VeriModeli>>(jsondata);

                    DataTable dt = new DataTable();
                    dt.Columns.Add("Member Id:");
                    dt.Columns.Add("Member Name:");
                    foreach (VeriModeli veri in veriler)
                    {
                        dt.Rows.Add(veri.KitapTeslim, veri.UyelikNo);
                    }
                    dataGridView1.DataSource = dt;
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

        private void kitapteslimTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
