using System.Windows.Forms;

namespace RecipeApp2
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private DataGridView dataGridView1;
        private Button btnTarifEkle;
        private Button btnTarifAra;
        private Button btnTarifDuzenle;
        private Button btnTarifSil;
        private RichTextBox txtTarifAdı;
        private RichTextBox txtMalzemeler;
        private RichTextBox txtTalimatlar;
        private RichTextBox txtTarifAra;
        private Label lblTarifAdı;
        private Label lblMalzemeler;
        private Label lblTalimatlar;
        private Label lblTarifAra;
        private Label lblYemekTarifleriBaslik;

        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnTarifEkle = new System.Windows.Forms.Button();
            this.btnTarifAra = new System.Windows.Forms.Button();
            this.btnTarifDuzenle = new System.Windows.Forms.Button();
            this.btnTarifSil = new System.Windows.Forms.Button();
            this.txtTarifAdı = new System.Windows.Forms.RichTextBox();
            this.txtMalzemeler = new System.Windows.Forms.RichTextBox();
            this.txtTalimatlar = new System.Windows.Forms.RichTextBox();
            this.txtTarifAra = new System.Windows.Forms.RichTextBox();
            this.lblTarifAdı = new System.Windows.Forms.Label();
            this.lblMalzemeler = new System.Windows.Forms.Label();
            this.lblTalimatlar = new System.Windows.Forms.Label();
            this.lblTarifAra = new System.Windows.Forms.Label();
            this.lblYemekTarifleriBaslik = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();

            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(179, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 60;
            this.dataGridView1.Size = new System.Drawing.Size(740, 300);
            this.dataGridView1.TabIndex = 12;

            this.btnTarifEkle.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.btnTarifEkle.Location = new System.Drawing.Point(939, 370);
            this.btnTarifEkle.Name = "btnTarifEkle";
            this.btnTarifEkle.Size = new System.Drawing.Size(150, 50);
            this.btnTarifEkle.TabIndex = 11;
            this.btnTarifEkle.Text = "Tarif Ekle";
            this.btnTarifEkle.Click += new System.EventHandler(this.btnTarifEkle_Click);

            this.btnTarifAra.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.btnTarifAra.Location = new System.Drawing.Point(939, 552);
            this.btnTarifAra.Name = "btnTarifAra";
            this.btnTarifAra.Size = new System.Drawing.Size(150, 50);
            this.btnTarifAra.TabIndex = 10;
            this.btnTarifAra.Text = "Tarif Ara";
            this.btnTarifAra.Click += new System.EventHandler(this.btnTarifAra_Click);

            this.btnTarifDuzenle.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.btnTarifDuzenle.Location = new System.Drawing.Point(939, 64);
            this.btnTarifDuzenle.Name = "btnTarifDuzenle";
            this.btnTarifDuzenle.Size = new System.Drawing.Size(183, 50);
            this.btnTarifDuzenle.TabIndex = 13;
            this.btnTarifDuzenle.Text = "Tarif Düzenle";
            this.btnTarifDuzenle.Click += new System.EventHandler(this.btnTarifDuzenle_Click);

            this.btnTarifSil.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.btnTarifSil.Location = new System.Drawing.Point(939, 120);
            this.btnTarifSil.Name = "btnTarifSil";
            this.btnTarifSil.Size = new System.Drawing.Size(183, 50);
            this.btnTarifSil.TabIndex = 14;
            this.btnTarifSil.Text = "Tarif Sil";
            this.btnTarifSil.Click += new System.EventHandler(this.btnTarifSil_Click);

            this.txtTarifAdı.Location = new System.Drawing.Point(179, 370);
            this.txtTarifAdı.Name = "txtTarifAdı";
            this.txtTarifAdı.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.txtTarifAdı.Size = new System.Drawing.Size(220, 100);
            this.txtTarifAdı.TabIndex = 7;
            this.txtTarifAdı.Text = "";

            this.txtMalzemeler.Location = new System.Drawing.Point(446, 370);
            this.txtMalzemeler.Name = "txtMalzemeler";
            this.txtMalzemeler.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.txtMalzemeler.Size = new System.Drawing.Size(220, 100);
            this.txtMalzemeler.TabIndex = 6;
            this.txtMalzemeler.Text = "";

            this.txtTalimatlar.Location = new System.Drawing.Point(707, 370);
            this.txtTalimatlar.Name = "txtTalimatlar";
            this.txtTalimatlar.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.txtTalimatlar.Size = new System.Drawing.Size(216, 100);
            this.txtTalimatlar.TabIndex = 8;
            this.txtTalimatlar.Text = "";

            this.txtTarifAra.Location = new System.Drawing.Point(707, 519);
            this.txtTarifAra.Name = "txtTarifAra";
            this.txtTarifAra.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.txtTarifAra.Size = new System.Drawing.Size(220, 80);
            this.txtTarifAra.TabIndex = 9;
            this.txtTarifAra.Text = "";

            this.lblTarifAdı.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblTarifAdı.Location = new System.Drawing.Point(179, 343);
            this.lblTarifAdı.Name = "lblTarifAdı";
            this.lblTarifAdı.Size = new System.Drawing.Size(220, 20);
            this.lblTarifAdı.TabIndex = 1;
            this.lblTarifAdı.Text = "Tarif Adı";

            this.lblMalzemeler.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblMalzemeler.Location = new System.Drawing.Point(446, 343);
            this.lblMalzemeler.Name = "lblMalzemeler";
            this.lblMalzemeler.Size = new System.Drawing.Size(220, 20);
            this.lblMalzemeler.TabIndex = 2;
            this.lblMalzemeler.Text = "Malzemeler";

            this.lblTalimatlar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblTalimatlar.Location = new System.Drawing.Point(707, 343);
            this.lblTalimatlar.Name = "lblTalimatlar";
            this.lblTalimatlar.Size = new System.Drawing.Size(216, 20);
            this.lblTalimatlar.TabIndex = 3;
            this.lblTalimatlar.Text = "Talimatlar";

            this.lblTarifAra.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblTarifAra.Location = new System.Drawing.Point(703, 496);
            this.lblTarifAra.Name = "lblTarifAra";
            this.lblTarifAra.Size = new System.Drawing.Size(220, 20);
            this.lblTarifAra.TabIndex = 4;
            this.lblTarifAra.Text = "Tarif Adı Ara";
            
            this.lblYemekTarifleriBaslik.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold);
            this.lblYemekTarifleriBaslik.Location = new System.Drawing.Point(172, -7);
            this.lblYemekTarifleriBaslik.Name = "lblYemekTarifleriBaslik";
            this.lblYemekTarifleriBaslik.Size = new System.Drawing.Size(910, 46);
            this.lblYemekTarifleriBaslik.TabIndex = 0;
            this.lblYemekTarifleriBaslik.Text = "Yemek Tarifleri Uygulaması";
            this.lblYemekTarifleriBaslik.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            
            this.ClientSize = new System.Drawing.Size(1134, 611);
            this.Controls.Add(this.lblYemekTarifleriBaslik);
            this.Controls.Add(this.lblTarifAra);
            this.Controls.Add(this.lblTalimatlar);
            this.Controls.Add(this.lblMalzemeler);
            this.Controls.Add(this.lblTarifAdı);
            this.Controls.Add(this.txtTarifAra);
            this.Controls.Add(this.txtTalimatlar);
            this.Controls.Add(this.txtMalzemeler);
            this.Controls.Add(this.txtTarifAdı);
            this.Controls.Add(this.btnTarifSil);
            this.Controls.Add(this.btnTarifDuzenle);
            this.Controls.Add(this.btnTarifAra);
            this.Controls.Add(this.btnTarifEkle);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Yemek Tarifleri";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
        }
    }
}
