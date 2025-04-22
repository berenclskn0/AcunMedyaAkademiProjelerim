using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Odev2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }       
        private void btnBaslat_Click(object sender, EventArgs e)
        {
            if (cmbOdemeYontemi.SelectedItem == null || string.IsNullOrWhiteSpace(txtTutar.Text))
            {
                lblSonuc.Text = "Lütfen tüm alanları doldurunuz.";
                return;
            }

            string secilenSinifAdi = cmbOdemeYontemi.SelectedItem.ToString();
            decimal tutar;

            if (!decimal.TryParse(txtTutar.Text, out tutar))
            {
                lblSonuc.Text = "Geçerli bir tutar giriniz.";
                return;
            }

            Type secilenTip = Type.GetType(secilenSinifAdi);
            if (secilenTip == null)
            {
                lblSonuc.Text = "Sınıf bulunamadı.";
                return;
            }

            IOdemeYontemi odemeYontemi = (IOdemeYontemi)Activator.CreateInstance(secilenTip);
            string sonuc = odemeYontemi.Ode(tutar);
            lblSonuc.Text = sonuc;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (Type t in typeof(IOdemeYontemi).Assembly.GetTypes()) // IOdemeYontemi arayuzunun tip bilgini al ve assembly icindeki  tum siniflari, arayuzleri, yapilari vs getir
            {
                if (typeof(IOdemeYontemi).IsAssignableFrom(t) && t.IsClass) // "t isimli sinif IOdemeYontemi arayuzunu uyguluyor mu?"
                {
                    cmbOdemeYontemi.Items.Add(t); // kontrol saglaniyorsa o sinifin tipini combobox'a ekle
                }
            }
        }
    }
}
