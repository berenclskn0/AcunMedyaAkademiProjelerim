using Odev2;

Araba araba = new Araba();

int yas = araba.yasHesapla(2024);
string sonuc = araba.durum(yas);
Console.WriteLine($"Arabanız {yas} yaşında --> {sonuc}");

int yas2 = araba.yasHesapla(2015);
string sonuc2 = araba.arabaDurum(yas2);
Console.WriteLine($"Arabanız {yas2} yaşında --> {sonuc2}");