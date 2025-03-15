using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev5
{
    public class Araba
    {
        public string marka;
        public string model;
        public int depoKapasitesi;
        public int gidilenYol;
        public double benzinTuketimi;

        public double benzinHesapla()
        {
            return benzinTuketimi = (depoKapasitesi / (double)gidilenYol) * 100; 
        }

        public void bilgileriGoster()
        {
            Console.WriteLine($"Marka - Model: {marka} - {model}");
            Console.WriteLine($"Benzin Tuketimi: {benzinTuketimi}L/Km");
            Console.WriteLine("-----------------");
        }
    }
}
