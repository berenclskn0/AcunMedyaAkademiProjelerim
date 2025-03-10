using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev4
{
    public class Calisan
    {
        public string isim;
        public string soyisim;
        public string meslek;
        public string departman;
        public int maas;

        public void BilgiGoster()
        {
            Console.WriteLine($"Isim: {isim}");
            Console.WriteLine($"Soyisim: {soyisim}");
            Console.WriteLine($"Meslek: {meslek}");
            Console.WriteLine($"Maaş: {maas} TL");
            Console.WriteLine($"Departman: {departman}");
            Console.WriteLine("-----------------------");
        }
    }
}