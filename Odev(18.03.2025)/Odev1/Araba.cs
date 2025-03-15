using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev1
{
    public class Araba
    {
        public Marka marka;
        public Model model;
        public Kapi kapi;
        public Pencere pencere;
        public Kasa kasa;
        public int fiyat;

        public Araba(Marka marka, Model model, Kapi kapi, Pencere pencere, Kasa kasa, int fiyat)
        {
            this.marka = marka;
            this.model = model;
            this.kapi = kapi;
            this.pencere = pencere;
            this.kasa = kasa;
            this.fiyat = fiyat;
        }

        public void bilgileriGoster()
        {
            Console.WriteLine("Marka: " + marka.markaAdi 
                + "\nModel: " + model.modelAdi 
                + "\nKasa: " + kasa.kasaTipi 
                + "\nKapi Sayisi: " + kapi.kapiSayisi 
                + "\nPencere Sayisi: " + pencere.pencereSayisi 
                + "\nFiyat: " + fiyat + " TL'dir");
        }
    }
}
