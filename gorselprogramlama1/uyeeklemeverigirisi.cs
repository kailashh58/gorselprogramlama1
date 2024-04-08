using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace gorselprogramlama1
{
    public partial class uyeeklemeverigirisi : Form
    {
        public class VeriModeli
        {
            public string UyeAd { get; set; }
            public string UyeNo { get; set; }
        }

        private string baglantidizisi = "Data Source=Uyeler.db;Version=3;";

        public uyeeklemeverigirisi()
        {
            bilesenibaslat();
            tabloyoksaolustur();
        }

        private void tabloyoksaolustur()
        {
            using (SQLiteConnection connection = new SQLiteConnection(baglantidizisi))
            {
                connection.Open();
                string sql = "CREATE TABLE IF NOT EXISTS Uyeler (UyeAd TEXT, UyeNo TEXT)";
                using (SQLiteCommand command = new SQLiteCommand(sql, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }

        private void sqliteveriekle(List<VeriModeli> veriler)
        {
            using (SQLiteConnection connection = new SQLiteConnection(baglantidizisi))
            {
                connection.Open();
                foreach (VeriModeli veri in veriler)
                {
                    string sql = "INSERT INTO Uyeler (UyeAd, UyeNo) VALUES (@UyeAd, @UyeNo)";
                    using (SQLiteCommand command = new SQLiteCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@UyeAd", veri.UyeAd);
                        command.Parameters.AddWithValue("@UyeNo", veri.UyeNo);
                        command.ExecuteNonQuery();
                    }
                }
            }
        }

        private List<VeriModeli> ReadDataFromJSON(string jsonFilePath)
        {
            string json = System.IO.File.ReadAllText(jsonFilePath);
            List<VeriModeli> veriler = JsonConvert.DeserializeObject<List<VeriModeli>>(json);
            return veriler;
        }

        private void kaydet_Click(object sender, EventArgs e)
        {
            VeriModeli veri = new VeriModeli
            {
                UyeAd = uyeadTextBox.Text,
                UyeNo = uyenoTextBox.Text
            };
            List<VeriModeli> yeniVeriler = new List<VeriModeli>();
            yeniVeriler.Add(veri);

            

            sqliteveriekle(yeniVeriler);

            MessageBox.Show("Veriler başarıyla kaydedildi.");
        }

        private void goruntule_Click(object sender, EventArgs e)
        {
            using (SQLiteConnection connection = new SQLiteConnection(baglantidizisi))
            {
                connection.Open();
                string sql = "SELECT * FROM Uyeler";
                using (SQLiteCommand command = new SQLiteCommand(sql, connection))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        DataTable dt = new DataTable();
                        dt.Load(reader);
                        dataGridView1.DataSource = dt;
                    }
                }
            }
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // uyeeklemeverigirisi
            // 
            this.ClientSize = new System.Drawing.Size(319, 258);
            this.Name = "uyeeklemeverigirisi";
            this.Load += new System.EventHandler(this.uyeeklemeverigirisi_Load);
            this.ResumeLayout(false);

        }

        private void uyeeklemeverigirisi_Load(object sender, EventArgs e)
        {

        }
    }
}