using System.Security.Cryptography.X509Certificates;

namespace OgrenciBilgiDogrulama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDogrula_Click(object sender, EventArgs e)
        {
            string ad = txtAd.Text;
            string soyad = txtSoyad.Text;
            string bolum = txtBolum.Text;

            Ogrenci ogrenci = new Ogrenci();
            ogrenci.ad = ad;
            ogrenci.soyad = soyad;
            ogrenci.bolum = bolum;

            if (!ZorunlulukKontrolu.dogrula(ogrenci))
            {
                MessageBox.Show("Lutfen Tum Alanlari Doldurunuz!", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                lblSonuc.Text = $"Ad: {ogrenci.ad}, Soyad: {ogrenci.soyad}, Bölüm: {ogrenci.bolum}";
            }
        }
    }
}
