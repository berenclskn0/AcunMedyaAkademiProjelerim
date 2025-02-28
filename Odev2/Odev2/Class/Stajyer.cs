using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Odev2.Abstract;
using Odev2.Interface;

namespace Odev2.Class
{
    public class Stajyer : Calisan, ICalisan
    {
        public double maasinNedir2()
        {
            return 5000.0;
        }

        public override double maasinNedir()
        {
            return 5000.0;
        }
    }
}
