using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev2
{
    public class Araba
    {
        public int yasHesapla(int uretimYili)
        {
            return DateTime.Now.Year - uretimYili;
        }

        public string durum(int yas)
        {
            if (yas > 0 && yas < 10)
                return "Arabanız yeni";

            else if (yas >= 10 && yas < 20)
                return "Servise götürmeniz gerekebilir";

            else if (yas >= 20 && yas < 30)
                return "Arabanız hurdaya çıkabilir";

            else
                return "Ya hiç üretilmedi ya da trafikten men edilmiştir";
        }

        public string arabaDurum(int yas)
        {
            switch (yas)
            {
                case int n when n > 0 && n < 10:
                    return "Arabanız yeni";

                case int n when n >= 10 && n < 20:
                    return "Servise götürmeniz gerekebilir";

                case int n when n >= 20 && n < 30:
                     return "Arabanız hurdaya çıkabilir";

                default:
                    return "Ya hiç üretilmedi ya da trafikten men edilmiştir";
            }
        }
    }
}
