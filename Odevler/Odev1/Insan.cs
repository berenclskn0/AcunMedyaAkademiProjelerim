using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev1
{
    public class Insan
    {
        public int yasHesapla(int dogumYili)
        {
            return DateTime.Now.Year - dogumYili;
        }

        public string yasBelirleme(int yas)
        {
            if (yas < 18)
                return "Küçüksünüz";

            else if (yas >= 18 && yas < 35)
                return "Gençsiniz";

            else if (yas >= 35 && yas < 55)
                return "Yetişkinsiniz";

            else if (yas >= 55 && yas < 75)
                return "Yaşlısınız";

            else if (yas >= 75 && yas < 99)
                return "Çok yaşlısınız";

            else
                return "Ya hiç doğmadınız ya da çoktan öldünüz...";
        }
    }
}
