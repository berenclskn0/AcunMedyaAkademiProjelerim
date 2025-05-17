using System.Data;
using System.Windows.Forms;
using HastaRandevuSistemi2.Models;
using Microsoft.Data.SqlClient;

namespace HastaRandevuSistemi2
{
    public partial class Form1 : Form
    {
        string connectionString = "Server=YOUR_SERVER;Database=YOUR_DB;User Id=YOUR_USER;Password=YOUR_PASSWORD;";

        int bransId = 0;
        int doktorId = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BranslariDoldur();
            RandevulariGetir();
        }

        public void BranslariDoldur()
        {
            List<Brans> bransListesi = null;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string sorgu = "SELECT * FROM Branslar";
                    SqlCommand command = new SqlCommand(sorgu, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    bransListesi = new List<Brans>();

                    bransListesi.Add(new Brans
                    {
                        Id = 0,
                        BransAdi = "Brans Seciniz"
                    });

                    while (reader.Read())
                    {
                        bransListesi.Add(new Brans
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            BransAdi = (string)reader["BransAdi"]
                        });
                    }

                    cmbBranslar.DataSource = bransListesi;
                    cmbBranslar.DisplayMember = "BransAdi";
                    cmbBranslar.ValueMember = "Id";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        private void DoktorlariDoldur(int bransId)
        {
            List<Doktor> doktorlar = new List<Doktor>();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Doktorlar WHERE BransID = @bransId";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@bransId", bransId);

                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                doktorlar.Add(new Doktor
                {
                    Id = -1,
                    DoktorAdi = "Doktor Seçiniz"
                });

                while (reader.Read())
                {
                    doktorlar.Add(new Doktor
                    {
                        Id = Convert.ToInt32(reader["Id"]),
                        DoktorAdi = (string)reader["DoktorAdi"],
                        DoktorSoyadi = (string)reader["DoktorSoyadi"],
                    });
                }
            }

            cmbDoktorlar.DataSource = doktorlar;
            cmbDoktorlar.DisplayMember = "TamAd";
            cmbDoktorlar.ValueMember = "Id";
        }

        private void cmbBranslar_SelectedIndexChanged(object sender, EventArgs e)
        {
            Brans brans = (Brans)cmbBranslar.SelectedItem;
            bransId = brans.Id;

            if (bransId > 0)
            {
                DoktorlariDoldur(bransId);
            }
        }

        private void cmbDoktorlar_SelectedIndexChanged(object sender, EventArgs e)
        {
            Doktor doktor = (Doktor)cmbDoktorlar.SelectedItem;

            if (doktor.Id > 0)
            {
                doktorId = doktor.Id;
            }
        }
        private void btnRandevuOlustur_Click(object sender, EventArgs e)
        {
            DateTime tarih = dtpTarih.Value.Date;
            string saat = cmbSaat.SelectedItem.ToString();

            if (txtHastaAdi.Text == "" || txtHastaSoyadi.Text == "" || mtbTc.Text.Length != 11 || !long.TryParse(mtbTc.Text, out _))
            {
                MessageBox.Show("Lütfen hasta bilgilerini doğru giriniz!");
            }
            else if (cmbBranslar.SelectedIndex <= 0 || cmbDoktorlar.SelectedIndex <= 0 || cmbSaat.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen branş, doktor ve saat seçiniz!");
            }
            else
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();

                        string sorgu = "INSERT INTO Randevular (HastaAdi, HastaSoyadi, HastaTc, BransId, DoktorId, Tarih, Saat) " +
                        "VALUES (@HastaAdi, @HastaSoyadi, @HastaTc, @BransId, @DoktorId, @Tarih, @Saat)";

                        SqlCommand command = new SqlCommand(sorgu, connection);
                        command.Parameters.AddWithValue("@HastaAdi", txtHastaAdi.Text);
                        command.Parameters.AddWithValue("@HastaSoyadi", txtHastaSoyadi.Text);
                        command.Parameters.AddWithValue("@HastaTc", mtbTc.Text);
                        command.Parameters.AddWithValue("@BransId", bransId);
                        command.Parameters.AddWithValue("@DoktorId", doktorId);
                        command.Parameters.AddWithValue("@Tarih", tarih);
                        command.Parameters.AddWithValue("@Saat", saat);
                        int kayitSayisi = command.ExecuteNonQuery();

                        if(kayitSayisi > 0)
                        {
                            MessageBox.Show("Kayit Eklendi!");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Hata Olustu: " + ex.Message.ToString());
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }   
        }
        private void RandevulariGetir()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter(@"
                    SELECT R.HastaAdi, R.HastaSoyadi, R.HastaTC,
                           B.BransAdi, D.DoktorAdi + ' ' + D.DoktorSoyadi AS Doktor,
                           R.Tarih, R.Saat
                    FROM Randevular R
                    INNER JOIN Branslar B ON B.Id = R.BransID
                    INNER JOIN Doktorlar D ON D.Id = R.DoktorID", conn);

                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }
    }
}
