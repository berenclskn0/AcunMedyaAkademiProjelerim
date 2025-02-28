using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Odev2.Interface;

namespace Odev2.Class
{
    public class Porsche : Araba, IHava
    {
        public void havadaGit(string isim)
        {
            Console.WriteLine(isim + " havada ucar.");
        }

        public override double yakitTuketimi()
        {
            return 60.0;
        }
    }
}
