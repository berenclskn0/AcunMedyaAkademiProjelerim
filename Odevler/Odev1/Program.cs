using Odev1;

Marka marka = new Marka("BMW");
Model model = new Model("X5");
Kapi kapi = new Kapi(4);
Pencere pencere = new Pencere(4);
Kasa kasa = new Kasa("Suv");
int fiyat = 2000000;

Araba araba = new Araba(marka, model, kapi, pencere, kasa, fiyat);
araba.bilgileriGoster();