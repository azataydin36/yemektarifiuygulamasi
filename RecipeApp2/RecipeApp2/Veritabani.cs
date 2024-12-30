using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;

namespace RecipeApp2
{
    public class Veritabani
    {
        private string connectionString = "Data Source=tarifler.db;Version=3;";

        public Veritabani()
        {
            
            if (!File.Exists("tarifler.db"))
            {
                SQLiteConnection.CreateFile("tarifler.db");
            }

            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();

                
                string createTableQuery = @"CREATE TABLE IF NOT EXISTS Tarifler (
                                            id INTEGER PRIMARY KEY AUTOINCREMENT, 
                                            TarifAdi TEXT, 
                                            MalzemelerListesi TEXT, 
                                            HazirlikTalimatlari TEXT)";
                SQLiteCommand cmd = new SQLiteCommand(createTableQuery, conn);
                cmd.ExecuteNonQuery();
            }
        }

        
        public void TarifEkle(Tarif tarif)
        {
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();

                string query = "INSERT INTO Tarifler (TarifAdi, MalzemelerListesi, HazirlikTalimatlari) VALUES (@TarifAdi, @MalzemelerListesi, @HazirlikTalimatlari)";
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@TarifAdi", tarif.TarifAdi);
                cmd.Parameters.AddWithValue("@MalzemelerListesi", tarif.MalzemelerListesi);
                cmd.Parameters.AddWithValue("@HazirlikTalimatlari", tarif.HazirlikTalimatlari);

                cmd.ExecuteNonQuery();
            }
        }

        
        public List<Tarif> TarifleriGetir()
        {
            List<Tarif> tarifler = new List<Tarif>();

            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();

                string query = "SELECT * FROM Tarifler";
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                SQLiteDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Tarif tarif = new Tarif
                    {
                        Id = Convert.ToInt32(reader["id"]),
                        TarifAdi = reader["TarifAdi"].ToString(),
                        MalzemelerListesi = reader["MalzemelerListesi"].ToString(),
                        HazirlikTalimatlari = reader["HazirlikTalimatlari"].ToString()
                    };
                    tarifler.Add(tarif);
                }
            }

            return tarifler;
        }

        
        public List<Tarif> TarifAra(string arama)
        {
            List<Tarif> tarifler = new List<Tarif>();

            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();

                string query = "SELECT * FROM Tarifler WHERE TarifAdi LIKE @arama";
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@arama", "%" + arama + "%");
                SQLiteDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Tarif tarif = new Tarif
                    {
                        Id = Convert.ToInt32(reader["id"]),
                        TarifAdi = reader["TarifAdi"].ToString(),
                        MalzemelerListesi = reader["MalzemelerListesi"].ToString(),
                        HazirlikTalimatlari = reader["HazirlikTalimatlari"].ToString()
                    };
                    tarifler.Add(tarif);
                }
            }

            return tarifler;
        }

        public void TarifDuzenle(Tarif tarif)
        {
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();

                string query = "UPDATE Tarifler SET TarifAdi = @TarifAdi, MalzemelerListesi = @MalzemelerListesi, HazirlikTalimatlari = @HazirlikTalimatlari WHERE id = @Id";
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@TarifAdi", tarif.TarifAdi);
                cmd.Parameters.AddWithValue("@MalzemelerListesi", tarif.MalzemelerListesi);
                cmd.Parameters.AddWithValue("@HazirlikTalimatlari", tarif.HazirlikTalimatlari);
                cmd.Parameters.AddWithValue("@Id", tarif.Id);

                cmd.ExecuteNonQuery();
            }
        }

        public void TarifSil(int tarifId)
        {
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();

                string query = "DELETE FROM Tarifler WHERE id = @Id";
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@Id", tarifId);

                cmd.ExecuteNonQuery();
            }
        }
    }
}
