using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev2
{
    public class KrediKarti : IOdemeYontemi
    {
        public string Ode(decimal tutar)
        {
            return $"Kredi karti ile {tutar} TL odendi";
        }
    }
}
