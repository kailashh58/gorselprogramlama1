using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace gorselprogramlama1
{

    public partial class kitapeklemeverigirisi : Form
    {

        public List<VeriModeli> books;
        public class VeriModeli
        {
            public string KitapAdi { get; set; }
            public string YazarAdi { get; set; }
            public string Tur { get; set; }
           
        }

        public kitapeklemeverigirisi()
        {
            this.books = new List<VeriModeli>();
            InitializeComponent();
            DataTable booksdata = new DataTable();
            booksdata.Columns.Add("Member Id:");
            booksdata.Columns.Add("Member Name:");
            booksdata.Columns.Add("Member Mail:");
            dataGridView1.DataSource = books;


            try
            {
                string json = File.ReadAllText("veriler.json");
                List < VeriModeli > booksAll = JsonConvert.DeserializeObject<List<VeriModeli>>(json);
                foreach (VeriModeli book in booksAll)
                {
                    books.Add(book);
                }
            }
            catch (Exception ex) { }
        }

        
        private void kaydetButton_Click(object sender, EventArgs e)
        {
            

            VeriModeli veri = new VeriModeli
            {
                KitapAdi = kitapadiTextBox.Text,
                YazarAdi = yazaradiTextBox.Text,
                Tur = turTextBox.Text,
              
            };
            
            books.Add(veri);
            string json = JsonConvert.SerializeObject(books);
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
                    List<VeriModeli> veriler = JsonConvert.DeserializeObject<List<VeriModeli>>(json);

                    DataTable dt = new DataTable();
                    dt.Columns.Add("Member Id:");
                    dt.Columns.Add("Member Name:");
                    dt.Columns.Add("Member Mail:");
                    foreach (VeriModeli veri in veriler)
                    {
                        dt.Rows.Add(veri.KitapAdi,veri.YazarAdi,veri.Tur);
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

        private void kaydetbutton_Click_1(object sender, EventArgs e)
        {

        }

        private void Goruntule_Click(object sender, EventArgs e)
        {

        }
    }
}