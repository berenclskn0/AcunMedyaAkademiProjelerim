using Odev2.Class;

Bmw bmw = new Bmw();
bmw.hizliGit("Bmw");
bmw.havadaGit("Bmw");
bmw.denizdeGit("Bmw");

Mercedes mercedes = new Mercedes();
mercedes.denizdeGit("Mercedes");
mercedes.havadaGit("Mercedes");

Porsche porsche = new Porsche();
porsche.havadaGit("Porsche");

double toplamYakit = bmw.yakitTuketimi() + mercedes.yakitTuketimi() + porsche.yakitTuketimi();
Console.WriteLine("Toplam:" + toplamYakit + " L yakit tuketirler.");

GenelMudur genelMudur = new GenelMudur();
Mudur mudur = new Mudur();
Programci programci = new Programci();
Stajyer stajyer = new Stajyer();

double toplamMaas = genelMudur.maasinNedir() + mudur.maasinNedir() + programci.maasinNedir() + stajyer.maasinNedir();
Console.WriteLine("Toplam:" + toplamMaas + " TL maas aliyorlar.");

double toplamMaas2 = genelMudur.maasinNedir2() + mudur.maasinNedir2() + programci.maasinNedir2() + stajyer.maasinNedir2();
Console.WriteLine("Toplam:" + toplamMaas2 + " TL maas aliyorlar.");
