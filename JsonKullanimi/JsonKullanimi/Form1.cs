using System.Text.Json;
using System.IO;
using System.Collections.Generic;
using System.Windows.Forms;

namespace JsonKullanimi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnUrunleriGoster_Click(object sender, EventArgs e)
        {
            try
            {
                string json = File.ReadAllText("urunler.json");
                List<Urun> urunler = JsonSerializer.Deserialize<List<Urun>>(json);

                lstUrunler.Items.Clear();

                for (int i = 0; i < urunler.Count; i++)
                {
                    lstUrunler.Items.Add($"{urunler[i].UrunAdi} - {urunler[i].Fiyat} TL");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }
    }
}
