using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev2
{
    public class Eft : IOdemeYontemi
    {
        public string Ode(decimal tutar)
        {
            return $"EFT ile {tutar} TL odendi";
        }
    }
}
