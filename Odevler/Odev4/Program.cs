using Odev4;

Calisan[] calisanlar = new Calisan[4];

calisanlar[0] = new Calisan 
{   
    isim = "Yasemin Beren", 
    soyisim = "Caliskan", 
    meslek = "Genel Müdür", 
    maas = 200000, 
    departman = "Yönetim"
};

calisanlar[1] = new Calisan 
{ 
    isim= "Erdeniz", 
    soyisim = "Bulat", 
    meslek = "Müdür", 
    maas= 120000, 
    departman = "Satış"
};

calisanlar[2] = new Calisan 
{ 
    isim = "Emir", 
    soyisim = "Yildiz", 
    meslek = "Programcı", 
    maas = 80000, 
    departman = "Teknoloji"
};

calisanlar[3] = new Calisan 
{ 
    isim = "Aras", 
    soyisim = "Hosbay", 
    meslek = "Stajyer", 
    maas = 30000, 
    departman = "Hukuk"
};

int toplamMaas = 0;

for (int i = 0; i < calisanlar.Length; i++)
{
    calisanlar[i].BilgiGoster();
    toplamMaas += calisanlar[i].maas;
}

Console.WriteLine($"Toplam Maas: {toplamMaas}");
