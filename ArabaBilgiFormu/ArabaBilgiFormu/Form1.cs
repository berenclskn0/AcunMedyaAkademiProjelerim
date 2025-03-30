namespace ArabaBilgiFormu
{
    public partial class ArabaBilgiFormu : Form
    {
        public ArabaBilgiFormu()
        {
            InitializeComponent();
        }

        private void btnBilgileriGoster_Click(object sender, EventArgs e)
        {
            string marka = txtMarka.Text;
            string model = txtModel.Text;
            string renk = txtRenk.Text;
            string kapiSayisi = txtKapiSayisi.Text;
            string pencereSayisi = txtPencereSayisi.Text;
            string yakitTuketimi = txtYaktigiYakitMiktari.Text;

            string bilgileriGoster = $"Marka: {marka}, " +
                                    $"Model: {model}, " +
                                    $"Renk: {renk}, " +
                                    $"Kapı Sayısı: {kapiSayisi}, " +
                                    $"Pencere Sayısı: {pencereSayisi}, " +
                                    $"Yakıt Tüketimi: {yakitTuketimi}L";

            listBoxSonuc.Items.Add(bilgileriGoster);
        }
    }
}
