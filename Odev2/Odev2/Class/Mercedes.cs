using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Odev2.Interface;

namespace Odev2.Class
{
    public class Mercedes : Araba, IDeniz, IHava
    {
        public void denizdeGit(string isim)
        {
            Console.WriteLine(isim + " denizde yuzer.");
        }

        public void havadaGit(string isim)
        {
            Console.WriteLine(isim + " havada ucar.");
        }

        public override double yakitTuketimi()
        {
            return 70.0;
        }
    }
}
