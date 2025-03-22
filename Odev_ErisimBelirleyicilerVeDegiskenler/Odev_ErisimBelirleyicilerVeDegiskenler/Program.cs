using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KullaniciYonetimi
{
    public class User
    {
        private string isim;
        private string soyisim;
        private int yas;
        public string Email { get; set; }

        public string GetIsim()
        {
            return isim;
        }

        public void SetIsim(string isim)
        {
            this.isim = isim;
        }

        public string GetSoyisim()
        {
            return soyisim;
        }

        public void SetSoyisim(string soyisim)
        {
            this.soyisim = soyisim;
        }
        public int GetYas()
        {
            return yas;
        }

        public void SetYas(int age)
        {
            if (age > 0)
                yas = age;
            else
                Console.WriteLine("Yas negatif olamaz!");
        }
        
        public void BilgileriGoster()
        {
            Console.WriteLine($"Isim: {isim}\n" +
                $"Soyisim: {soyisim}\n" +
                $"Yas: {yas}\n" +
                $"Email: {Email}");
        }
    }
}

namespace Odev_ErisimBelirleyicilerVeDegiskenler
{
    using KullaniciYonetimi;
    public class Program
    {
        static void Main(string[] args)
        {
            User kullanici = new User();
            kullanici.SetIsim("Yasemin Beren");
            kullanici.SetSoyisim("Caliskan");
            kullanici.SetYas(21);
            kullanici.Email = "berenclskn3@gmail.com";
            kullanici.BilgileriGoster();
        }
    }
}
