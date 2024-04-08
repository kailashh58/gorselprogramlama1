using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace gorselprogramlama1
{
    public partial class kitapeklemeverigirisi : Form
    {
        private string connectionString = "Data Source=kitaplar.db;Version=3;";

        public class VeriModeli
        {
            public string KitapAdi { get; set; }
            public string YazarAdi { get; set; }
            public string Tur { get; set; }
        }

        public kitapeklemeverigirisi()
        {
            InitializeComponent();
            veritabaniolustur();
            Goruntule_Click(null, null);
        }

        private void veritabaniolustur()
        {
            if (!File.Exists("kitaplar.db"))
            {
                SQLiteConnection.CreateFile("kitaplar.db");
                string query = "CREATE TABLE IF NOT EXISTS Kitaplar (KitapAdi TEXT, YazarAdi TEXT, Tur TEXT)";
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();
                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        command.ExecuteNonQuery();
                    }
                }
            }
        }

        private void KaydetButton_Click(object sender, EventArgs e)
        {
            VeriModeli veri = new VeriModeli
            {
                KitapAdi = kitapadiTextBox.Text,
                YazarAdi = yazaradiTextBox.Text,
                Tur = turTextBox.Text
            };

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string query = "INSERT INTO Kitaplar (KitapAdi, YazarAdi, Tur) VALUES (@KitapAdi, @YazarAdi, @Tur)";
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@KitapAdi", veri.KitapAdi);
                    command.Parameters.AddWithValue("@YazarAdi", veri.YazarAdi);
                    command.Parameters.AddWithValue("@Tur", veri.Tur);
                    command.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Veri başarıyla kaydedildi.");
            Goruntule_Click(null, null); // Veriyi güncelle
        }

        private void Goruntule_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Kitap Adı");
            dt.Columns.Add("Yazar Adı");
            dt.Columns.Add("Tür");

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT KitapAdi, YazarAdi, Tur FROM Kitaplar";
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            dt.Rows.Add(reader["KitapAdi"].ToString(), reader["YazarAdi"].ToString(), reader["Tur"].ToString());
                        }
                    }
                }
            }

            dataGridView1.DataSource = dt;
        }
    }
}