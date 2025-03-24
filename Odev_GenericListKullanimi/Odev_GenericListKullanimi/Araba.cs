using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev_GenericListKullanimi
{
    public class Araba
    {
        public string marka;
        public string model;
        public double benzinHarcamasi;
        public double toplamMesafe;

        public double ToplamYakitTuketimi()
        {
            return (toplamMesafe / 100) * benzinHarcamasi;
        }
    }
}
