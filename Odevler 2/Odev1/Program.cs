using Odev1;

Insan insan = new Insan();
int yas = insan.yasHesapla(2003);
string sonuc = insan.yasBelirleme(yas);
Console.WriteLine($"Yaşınız: {yas} --> {sonuc}");