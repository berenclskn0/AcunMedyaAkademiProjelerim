using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaRandevuSistemi2.Models
{
    public class Doktor
    {
        public int Id { get; set; }
        public string DoktorAdi { get; set; }
        public string DoktorSoyadi { get; set; }
        public string TamAd => $"{DoktorAdi} {DoktorSoyadi}";
        public int BransId { get; set; }
    }
}
