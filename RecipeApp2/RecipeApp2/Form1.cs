using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RecipeApp2
{
    public partial class Form1 : Form
    {
        private Veritabani veritabani;
        private int selectedTarifId = -1;

        public Form1()
        {
            InitializeComponent();
            veritabani = new Veritabani();
            this.dataGridView1.CellClick += new DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            RefreshTarifListesi(); 
        }

        private void btnTarifEkle_Click(object sender, EventArgs e)
        {
            string tarifAdi = txtTarifAdı.Text;
            string malzemeler = txtMalzemeler.Text;
            string talimatlar = txtTalimatlar.Text;

            if (string.IsNullOrEmpty(tarifAdi) || string.IsNullOrEmpty(malzemeler) || string.IsNullOrEmpty(talimatlar))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            List<Tarif> tarifler = veritabani.TarifleriGetir();
            int yeniId = tarifler.Count == 0 ? 1 : tarifler[tarifler.Count - 1].Id + 1;

            Tarif yeniTarif = new Tarif
            {
                Id = yeniId,
                TarifAdi = tarifAdi,
                MalzemelerListesi = malzemeler,
                HazirlikTalimatlari = talimatlar
            };

            veritabani.TarifEkle(yeniTarif);
            RefreshTarifListesi();

            txtTarifAdı.Clear();
            txtMalzemeler.Clear();
            txtTalimatlar.Clear();
        }

        private void btnTarifAra_Click(object sender, EventArgs e)
        {
            string arama = txtTarifAra.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(arama))
            {
                MessageBox.Show("Lütfen aramak için bir tarif adı girin.", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            List<Tarif> bulunanTarifler = veritabani.TarifAra(arama);

            if (bulunanTarifler.Count == 0)
            {
                MessageBox.Show("Aradığınız tarif bulunamadı.", "Sonuç Yok", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = bulunanTarifler;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var selectedRow = dataGridView1.Rows[e.RowIndex];
                selectedTarifId = Convert.ToInt32(selectedRow.Cells["Id"].Value);

                if (e.ColumnIndex == 1)
                {
                    string tarifAdi = selectedRow.Cells["TarifAdi"].Value.ToString();
                    MessageBox.Show($"Tarif Adı: {tarifAdi}", "Tarif Adı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (e.ColumnIndex == 2)
                {
                    string malzemeler = selectedRow.Cells["MalzemelerListesi"].Value.ToString();
                    MessageBox.Show($"Malzemeler:\n{malzemeler}", "Malzemeler", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (e.ColumnIndex == 3)
                {
                    string talimatlar = selectedRow.Cells["HazirlikTalimatlari"].Value.ToString();
                    MessageBox.Show($"Talimatlar:\n{talimatlar}", "Talimatlar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnTarifDuzenle_Click(object sender, EventArgs e)
        {
            if (selectedTarifId == -1)
            {
                MessageBox.Show("Lütfen düzenlemek istediğiniz tarifi seçin.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string tarifAdi = txtTarifAdı.Text;
            string malzemeler = txtMalzemeler.Text;
            string talimatlar = txtTalimatlar.Text;

            if (string.IsNullOrEmpty(tarifAdi) || string.IsNullOrEmpty(malzemeler) || string.IsNullOrEmpty(talimatlar))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
           
            Tarif duzenlenenTarif = new Tarif
            {
                Id = selectedTarifId,
                TarifAdi = tarifAdi,
                MalzemelerListesi = malzemeler,
                HazirlikTalimatlari = talimatlar
            };

            veritabani.TarifDuzenle(duzenlenenTarif);
            RefreshTarifListesi();

            txtTarifAdı.Clear();
            txtMalzemeler.Clear();
            txtTalimatlar.Clear();
            selectedTarifId = -1;
        }

        private void btnTarifSil_Click(object sender, EventArgs e)
        {
            if (selectedTarifId == -1)
            {
                MessageBox.Show("Lütfen silmek istediğiniz tarifi seçin.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var result = MessageBox.Show("Seçilen tarifi silmek istediğinizden emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                veritabani.TarifSil(selectedTarifId);
                RefreshTarifListesi();
                selectedTarifId = -1;
            }
        }

        private void RefreshTarifListesi()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = veritabani.TarifleriGetir();
        }
    }
}
