using Odev5;

Araba[] arabalar = new Araba[2];

arabalar[0] = new Araba
{
    marka = "Toyota",
    model = "Chr",
    depoKapasitesi = 40,
    gidilenYol = 600
};

arabalar[0].benzinTuketimi = arabalar[0].benzinHesapla();

arabalar[1] = new Araba
{
    marka = "Honda",
    model = "Civic",
    depoKapasitesi = 50,
    gidilenYol = 700
};

arabalar[1].benzinTuketimi = arabalar[1].benzinHesapla();

double toplamBenzin = 0;

for (int i = 0; i < arabalar.Length; i++)
{
    arabalar[i].bilgileriGoster();
    toplamBenzin += arabalar[i].benzinTuketimi;
}

Console.WriteLine($"Toplam Benzin Tuketimi: {toplamBenzin}L/Km");