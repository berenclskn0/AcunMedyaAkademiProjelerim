using Odev_GenericListKullanimi;

List<Araba> arabalar = new List<Araba>();

arabalar.Add(new Araba
{
    marka = "Toyota",
    model = "Corolla",
    benzinHarcamasi = 6.5,
    toplamMesafe = 5000
});

arabalar.Add(new Araba
{
    marka = "BMW",
    model = "X5",
    benzinHarcamasi = 9.0,
    toplamMesafe = 5000
});

arabalar.Add(new Araba
{
    marka = "Mercedes",
    model = "C200",
    benzinHarcamasi = 8.2,
    toplamMesafe = 5000
});

foreach(Araba araba in arabalar)
{
    Console.WriteLine($"Marka: {araba.marka}, Model: {araba.model}, 100 km'de Yaktığı Yakıt: {araba.benzinHarcamasi} litre, Toplam Yakıt Tüketimi: {araba.ToplamYakitTuketimi()} litre");
}