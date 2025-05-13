using HastaRandevuSistemi.Models;
using System.Data.SqlClient;

namespace HastaRandevuSistemi
{
    public partial class Form1 : Form
    {
        string connectionString = "Server=192.168.1.89,1433;"
            + "Database=AcunMedya;"
            + "User Id=sa;"
            + "Password=3.Yaseber3;"
            + "TrustServerCertificate=True;";

        int bransId = 0;
        int doktorId = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BransGetir();
            SaatleriYukle();
        }

        public void BransGetir()
        {
            List<Brans> bransListesi = new List<Brans>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string sorgu = "SELECT * FROM Branslar";
                    SqlCommand command = new SqlCommand(sorgu, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    bransListesi.Add(new Brans 
                    { 
                        Id = -1, 
                        BransAdi = "Branş Seçiniz" 
                    });

                    while (reader.Read())
                    {
                        bransListesi.Add(new Brans
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            BransAdi = reader["BransAdi"].ToString()
                        });
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    connection.Close();
                }

                cmbBranslar.DataSource = bransListesi;
                cmbBranslar.DisplayMember = "BransAdi";
                cmbBranslar.ValueMember = "Id";
            }
        }

        public void DoktorGetir(int bransId)
        {
            List<Doktor> doktorListesi = new List<Doktor>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string sorgu = "SELECT * FROM Doktorlar WHERE BransID = " + bransId;
                    SqlCommand command = new SqlCommand(sorgu, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        doktorListesi.Add(new Doktor
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            DoktorAdi = reader["DoktorAdi"].ToString(),
                            DoktorSoyadi = reader["DoktorSoyadi"].ToString()
                        });
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    connection.Close();
                }

                cmbDoktorlar.DataSource = doktorListesi;
                cmbDoktorlar.DisplayMember = "TamAd";
                cmbDoktorlar.ValueMember = "Id";
            }
        }

        private void cmbBranslar_SelectedIndexChanged(object sender, EventArgs e)
        {
            Brans brans = (Brans)cmbBranslar.SelectedItem;
            bransId = brans.Id;

            if (bransId > 0)
            {
                DoktorGetir(bransId);
            }
        }

        private void SaatleriYukle()
        {
            cmbSaat.Items.Add("09:00");
            cmbSaat.Items.Add("10:00");
            cmbSaat.Items.Add("11:00");
            cmbSaat.Items.Add("13:00");
            cmbSaat.Items.Add("14:00");
            cmbSaat.Items.Add("15:00");
        }

        private void btnRandevuOlustur_Click(object sender, EventArgs e)
        {
            string hastaAdi = txtAd.Text;
            string hastaSoyadi = txtSoyad.Text;
            DateTime tarih = dtpTarih.Value.Date;
            string saat = cmbSaat.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(hastaAdi) || string.IsNullOrEmpty(hastaSoyadi) || cmbDoktorlar.SelectedItem == null || string.IsNullOrEmpty(saat))
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz.");
                return;
            }

            doktorId = ((Doktor)cmbDoktorlar.SelectedItem).Id;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string kontrol = "SELECT COUNT(*) FROM Randevular WHERE DoktorID=@doktorId AND Tarih=@tarih";
                    SqlCommand checkCommand = new SqlCommand(kontrol, connection);
                    checkCommand.Parameters.AddWithValue("@doktorId", doktorId);
                    checkCommand.Parameters.AddWithValue("@tarih", tarih.AddHours(Convert.ToDateTime(saat).Hour));

                    int count = (int)checkCommand.ExecuteScalar();
                    if (count > 0)
                    {
                        MessageBox.Show("Bu saatte zaten bir randevu var!");
                        return;
                    }

                    string ekle = "INSERT INTO Randevular (HastaAdi, HastaSoyadi, BransID, DoktorID, Tarih) " +
                                  "VALUES (@adi, @soyadi, @bransId, @doktorId, @tarih)";

                    SqlCommand insertCommand = new SqlCommand(ekle, connection);

                    insertCommand.Parameters.AddWithValue("@adi", hastaAdi);
                    insertCommand.Parameters.AddWithValue("@soyadi", hastaSoyadi);
                    insertCommand.Parameters.AddWithValue("@bransId", bransId);
                    insertCommand.Parameters.AddWithValue("@doktorId", doktorId);
                    insertCommand.Parameters.AddWithValue("@tarih", tarih.AddHours(Convert.ToDateTime(saat).Hour));

                    insertCommand.ExecuteNonQuery();
                    MessageBox.Show("Randevu başarıyla oluşturuldu!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }
    }
}
