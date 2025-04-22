using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev2
{
    public class Havale : IOdemeYontemi
    {
        public string Ode(decimal tutar)
        {
            return $"Havale ile {tutar} TL odendi";
        }
    }
}
