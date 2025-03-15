using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev2
{
    public class Matematik
    {
        public double topla(double sayi1, double sayi2)
        {
            double sonuc = 0;
            sonuc = sayi1 + sayi2;
            Console.WriteLine("Iki sayinin toplami: " + sonuc);
            return sonuc;
        }
        
        public int topla(int sayi1 , int sayi2 , int sayi3)
        {
            int sonuc = 0;
            sonuc = sayi1 + sayi2 + sayi3;
            Console.WriteLine("Uc sayinin toplami: " + sonuc);
            return sonuc;
        }
        
        public int carp(int sayi1, int sayi2)
        {
            int sonuc = 0;
            sonuc = sayi1 * sayi2;
            Console.WriteLine("Iki sayinin carpimi: " + sonuc);
            return sonuc;
        }
        
        public int carp(int sayi1 , int sayi2, int sayi3)
        {
            int sonuc = 0;
            sonuc = sayi1 * sayi2 * sayi3;
            Console.WriteLine("Uc sayinin carpimi: " + sonuc);
            return sonuc;
        }
    }
}
