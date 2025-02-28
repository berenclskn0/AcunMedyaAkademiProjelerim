using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Odev2.Interface;

namespace Odev2.Class
{
    public class Bmw : Araba, IHiz, IHava, IDeniz
    {
        public void denizdeGit(string isim)
        {
            Console.WriteLine(isim + " denizde yuzer.");
        }

        public void havadaGit(string isim)
        {
            Console.WriteLine(isim + " havada ucar.");
        }

        public void hizliGit(string isim)
        {
            Console.WriteLine(isim + " cok hizli gider.");
        }

        public override double yakitTuketimi()
        {
            return 80.0;
        }
    }
}
