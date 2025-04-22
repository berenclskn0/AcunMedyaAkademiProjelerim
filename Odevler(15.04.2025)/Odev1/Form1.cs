using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Odev1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKlasorSec_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK) //Klasor secme pencerisini acar ve kullanici kalsor secerse DialogResult.OK doner
            {
                lstSiniflar.Items.Clear(); // listbox'i temizler
                string secilenKlasor = folderBrowserDialog1.SelectedPath; //Secilen klasorun yolunu alir
                KlasorleriVeClasslariListele(secilenKlasor);
            }
        }

        private void KlasorleriVeClasslariListele(string anaKlasor) // anaklasor icindeki alt klasorleri ve her bir alt klasordeki dosyalari tarar
        {
            string[] klasorler = Directory.GetDirectories(anaKlasor);

            foreach (string klasor in klasorler)
            {
                string klasorAdi = "--> " + Path.GetFileName(klasor); // klasor adi elde edilir
                lstSiniflar.Items.Add(klasorAdi); //klasor listboxa eklenir

                string[] csDosyalari = Directory.GetFiles(klasor, "*.cs", SearchOption.TopDirectoryOnly); //klasordeki .cs dosyalari alinir
                foreach (string dosya in csDosyalari)
                {
                    List<string> classIsimleri = DosyadanClassIsimleriniAl(dosya); //dosyadaki sinif isimleri alinir
                    foreach (string classAdi in classIsimleri)
                    {
                        lstSiniflar.Items.Add("   - " + classAdi); //sinif isimleri listbox'a eklenir
                    }
                }
            }
        }
        private List<string> DosyadanClassIsimleriniAl(string dosyaYolu) // .cs dosyalarini tarar ve class kelimesi gecen sinif isimlerini bulur
        {
            List<string> classIsimleri = new List<string>();
            string[] satirlar = File.ReadAllLines(dosyaYolu); // dosyadaki tum satirlar okunur

            foreach (string satir in satirlar)
            {
                string temizSatir = satir.Trim(); // satir basindaki ve sonundaki bosluklar temizlenir
                if (temizSatir.StartsWith("public class") || temizSatir.StartsWith("class "))
                {
                    string[] bolunmus = temizSatir.Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
                    int classIndex = Array.IndexOf(bolunmus, "class");
                    if (classIndex >= 0 && classIndex < bolunmus.Length - 1)
                    {
                        classIsimleri.Add(bolunmus[classIndex + 1]);
                    }
                }
            }
            return classIsimleri;
        }
    }
}
