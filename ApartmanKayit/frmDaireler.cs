using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace ApartmanKayit
{
    public partial class frmDaireler : Form
    {
        public frmDaireler() 
        {
            InitializeComponent();
        }

      
        SqlConnection baglanti = new SqlConnection(System.IO.File.ReadAllText(@"C:\server.txt"));

        double temp = 0;

        private void temizle()
        {
            lblAdSoyad.Text = "Ad Soyad";
            lblAidatKontrol.Text = "Ödedi / Ödemedi";
        }
        private void btnA1_Click(object sender, EventArgs e)
        {
            temizle();
            btnA1.ForeColor = Color.Black;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from kisiBilgiler where DaireNo= 'A1' OR DaireNo='a1'", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                temp = double.Parse(oku["Aidat"].ToString());
                lblAdSoyad.Text = oku["Ad"].ToString() + " " + oku["Soyad"].ToString();
                if (temp == 0)
                {
                    lblAidatKontrol.Text = "Ödedi";
                }
                else
                {
                    lblAidatKontrol.Text = "Ödemedi";
                }
            }
            baglanti.Close();
        }

        private void btnA2_Click(object sender, EventArgs e)
        {
            temizle();
            btnA2.ForeColor = Color.Black;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from kisiBilgiler where DaireNo= 'A2' OR DaireNo='a2'", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                temp = double.Parse(oku["Aidat"].ToString());
                lblAdSoyad.Text = oku["Ad"].ToString() + " " + oku["Soyad"].ToString();
                if (temp == 0)
                {
                    lblAidatKontrol.Text = "Ödedi";
                }
                else
                {
                    lblAidatKontrol.Text = "Ödemedi";
                }
            }
            baglanti.Close();
        }

        private void btnA3_Click(object sender, EventArgs e)
        {
            temizle();
            btnA3.ForeColor = Color.Black;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from kisiBilgiler where DaireNo= 'A3' OR DaireNo='a3'", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                temp = double.Parse(oku["Aidat"].ToString());
                lblAdSoyad.Text = oku["Ad"].ToString() + " " + oku["Soyad"].ToString();
                if (temp == 0)
                {
                    lblAidatKontrol.Text = "Ödedi";
                }
                else
                {
                    lblAidatKontrol.Text = "Ödemedi";
                }
            }
            baglanti.Close();
        }

        private void btnA4_Click(object sender, EventArgs e)
        {
            temizle();
            btnA4.ForeColor = Color.Black;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from kisiBilgiler where DaireNo= 'A4' OR DaireNo='a4'", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                temp = double.Parse(oku["Aidat"].ToString());
                lblAdSoyad.Text = oku["Ad"].ToString() + " " + oku["Soyad"].ToString();
                if (temp == 0)
                {
                    lblAidatKontrol.Text = "Ödedi";
                }
                else
                {
                    lblAidatKontrol.Text = "Ödemedi";
                }
            }
            baglanti.Close();
        }

        private void btnA5_Click(object sender, EventArgs e)
        {
            temizle();
            btnA5.ForeColor = Color.Black;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from kisiBilgiler where DaireNo= 'A5' OR DaireNo='a5'", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                temp = double.Parse(oku["Aidat"].ToString());
                lblAdSoyad.Text = oku["Ad"].ToString() + " " + oku["Soyad"].ToString();
                if (temp == 0)
                {
                    lblAidatKontrol.Text = "Ödedi";
                }
                else
                {
                    lblAidatKontrol.Text = "Ödemedi";
                }
            }
            baglanti.Close();
        }

        private void btnA6_Click(object sender, EventArgs e)
        {
            temizle();
            btnA6.ForeColor = Color.Black;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from kisiBilgiler where DaireNo= 'A6' OR DaireNo='a6'", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            
            while (oku.Read())
            {
                temp = double.Parse(oku["Aidat"].ToString());
                lblAdSoyad.Text = oku["Ad"].ToString() + " " + oku["Soyad"].ToString();
                if (temp == 0)
                {
                    lblAidatKontrol.Text = "Ödedi";
                }
                else
                {
                    lblAidatKontrol.Text = "Ödemedi";
                }
            }
            baglanti.Close();
        }

        private void btnA7_Click(object sender, EventArgs e)
        {
            temizle();
            btnA7.ForeColor = Color.Black;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from kisiBilgiler where DaireNo= 'A7' OR DaireNo='a7'", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                temp = double.Parse(oku["Aidat"].ToString());
                lblAdSoyad.Text = oku["Ad"].ToString() + " " + oku["Soyad"].ToString();
                if (temp == 0)
                {
                    lblAidatKontrol.Text = "Ödedi";
                }
                else
                {
                    lblAidatKontrol.Text = "Ödemedi";
                }
            }
            baglanti.Close();
        }

        private void btnA8_Click(object sender, EventArgs e)
        {
            temizle();
            btnA8.ForeColor = Color.Black;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from kisiBilgiler where DaireNo= 'A8' OR DaireNo='a8'", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                temp = double.Parse(oku["Aidat"].ToString());
                lblAdSoyad.Text = oku["Ad"].ToString() + " " + oku["Soyad"].ToString();
                if (temp == 0)
                {
                    lblAidatKontrol.Text = "Ödedi";
                }
                else
                {
                    lblAidatKontrol.Text = "Ödemedi";
                }
            }
            baglanti.Close();
        }

        private void btnA9_Click(object sender, EventArgs e)
        {
            temizle();
            btnA9.ForeColor = Color.Black;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from kisiBilgiler where DaireNo= 'A9' OR DaireNo='a9'", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                temp = double.Parse(oku["Aidat"].ToString());
                lblAdSoyad.Text = oku["Ad"].ToString() + " " + oku["Soyad"].ToString();
                if (temp == 0)
                {
                    lblAidatKontrol.Text = "Ödedi";
                }
                else
                {
                    lblAidatKontrol.Text = "Ödemedi";
                }
            }
            baglanti.Close();
        }

        private void btnA10_Click(object sender, EventArgs e)
        {
            temizle();
            btnA10.ForeColor = Color.Black;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from kisiBilgiler where DaireNo= 'A10' OR DaireNo='a10'", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                temp = double.Parse(oku["Aidat"].ToString());
                lblAdSoyad.Text = oku["Ad"].ToString() + " " + oku["Soyad"].ToString();
                if (temp == 0)
                {
                    lblAidatKontrol.Text = "Ödedi";
                }
                else
                {
                    lblAidatKontrol.Text = "Ödemedi";
                }
            }
            baglanti.Close();
        }

        private void btnA11_Click(object sender, EventArgs e)
        {
            temizle();
            btnA11.ForeColor = Color.Black;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from kisiBilgiler where DaireNo= 'A11' OR DaireNo='a11'", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                temp = double.Parse(oku["Aidat"].ToString());
                lblAdSoyad.Text = oku["Ad"].ToString() + " " + oku["Soyad"].ToString();
                if (temp == 0)
                {
                    lblAidatKontrol.Text = "Ödedi";
                }
                else
                {
                    lblAidatKontrol.Text = "Ödemedi";
                }
            }
            baglanti.Close();
        }

        private void btnA12_Click(object sender, EventArgs e)
        {
            temizle();
            btnA12.ForeColor = Color.Black;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from kisiBilgiler where DaireNo= 'A12' OR DaireNo='a12'", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                temp = double.Parse(oku["Aidat"].ToString());
                lblAdSoyad.Text = oku["Ad"].ToString() + " " + oku["Soyad"].ToString();
                if (temp == 0)
                {
                    lblAidatKontrol.Text = "Ödedi";
                }
                else
                {
                    lblAidatKontrol.Text = "Ödemedi";
                }
            }
            baglanti.Close();
        }

        private void btnA13_Click(object sender, EventArgs e)
        {
            temizle();
            btnA13.ForeColor = Color.Black;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from kisiBilgiler where DaireNo= 'A13' OR DaireNo='a13'", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                temp = double.Parse(oku["Aidat"].ToString());
                lblAdSoyad.Text = oku["Ad"].ToString() + " " + oku["Soyad"].ToString();
                if (temp == 0)
                {
                    lblAidatKontrol.Text = "Ödedi";
                }
                else
                {
                    lblAidatKontrol.Text = "Ödemedi";
                }
            }
            baglanti.Close();
        }

        private void btnA14_Click(object sender, EventArgs e)
        {
            temizle();
            btnA14.ForeColor = Color.Black;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from kisiBilgiler where DaireNo= 'A14' OR DaireNo='a14'", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                temp = double.Parse(oku["Aidat"].ToString());
                lblAdSoyad.Text = oku["Ad"].ToString() + " " + oku["Soyad"].ToString();
                if (temp == 0)
                {
                    lblAidatKontrol.Text = "Ödedi";
                }
                else
                {
                    lblAidatKontrol.Text = "Ödemedi";
                }
            }
            baglanti.Close();
        }

        private void btnA15_Click(object sender, EventArgs e)
        {
            temizle();
            btnA15.ForeColor = Color.Black;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from kisiBilgiler where DaireNo= 'A15' OR DaireNo='a15'", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                temp = double.Parse(oku["Aidat"].ToString());
                lblAdSoyad.Text = oku["Ad"].ToString() + " " + oku["Soyad"].ToString();
                if (temp == 0)
                {
                    lblAidatKontrol.Text = "Ödedi";
                }
                else
                {
                    lblAidatKontrol.Text = "Ödemedi";
                }
            }
            baglanti.Close();
        }

        private void btnA16_Click(object sender, EventArgs e)
        {
            temizle();
            btnA16.ForeColor = Color.Black;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from kisiBilgiler where DaireNo= 'A16' OR DaireNo='a16'", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                temp = double.Parse(oku["Aidat"].ToString());
                lblAdSoyad.Text = oku["Ad"].ToString() + " " + oku["Soyad"].ToString();
                if (temp == 0)
                {
                    lblAidatKontrol.Text = "Ödedi";
                }
                else
                {
                    lblAidatKontrol.Text = "Ödemedi";
                }
            }
            baglanti.Close();
        }

        private void btnA17_Click(object sender, EventArgs e)
        {
            temizle();
            btnA17.ForeColor = Color.Black;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from kisiBilgiler where DaireNo= 'A17' OR DaireNo='a17'", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                temp = double.Parse(oku["Aidat"].ToString());
                lblAdSoyad.Text = oku["Ad"].ToString() + " " + oku["Soyad"].ToString();
                if (temp == 0)
                {
                    lblAidatKontrol.Text = "Ödedi";
                }
                else
                {
                    lblAidatKontrol.Text = "Ödemedi";
                }
            }
            baglanti.Close();
        }

        private void btnA18_Click(object sender, EventArgs e)
        {
            temizle();
            btnA18.ForeColor = Color.Black;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from kisiBilgiler where DaireNo= 'A18' OR DaireNo='a18'", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                temp = double.Parse(oku["Aidat"].ToString());
                lblAdSoyad.Text = oku["Ad"].ToString() + " " + oku["Soyad"].ToString();
                if (temp == 0)
                {
                    lblAidatKontrol.Text = "Ödedi";
                }
                else
                {
                    lblAidatKontrol.Text = "Ödemedi";
                }
            }
            baglanti.Close();
        }

        private void btnA19_Click(object sender, EventArgs e)
        {
            temizle();
            btnA19.ForeColor = Color.Black;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from kisiBilgiler where DaireNo= 'A19' OR DaireNo='a19'", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                temp = double.Parse(oku["Aidat"].ToString());
                lblAdSoyad.Text = oku["Ad"].ToString() + " " + oku["Soyad"].ToString();
                if (temp == 0)
                {
                    lblAidatKontrol.Text = "Ödedi";
                }
                else
                {
                    lblAidatKontrol.Text = "Ödemedi";
                }
            }
            baglanti.Close();
        }

        private void btnA20_Click(object sender, EventArgs e)
        {
            temizle();
            btnA20.ForeColor = Color.Black;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from kisiBilgiler where DaireNo= 'A20' OR DaireNo='a20'", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                temp = double.Parse(oku["Aidat"].ToString());
                lblAdSoyad.Text = oku["Ad"].ToString() + " " + oku["Soyad"].ToString();
                if (temp == 0)
                {
                    lblAidatKontrol.Text = "Ödedi";
                }
                else
                {
                    lblAidatKontrol.Text = "Ödemedi";
                }
            }
            baglanti.Close();
        }

        private void btnB1_Click(object sender, EventArgs e)
        {
            temizle();
            btnB1.ForeColor = Color.Black;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from kisiBilgiler where DaireNo= 'B1' OR DaireNo='b1'", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                temp = double.Parse(oku["Aidat"].ToString());
                lblAdSoyad.Text = oku["Ad"].ToString() + " " + oku["Soyad"].ToString();
                if (temp == 0)
                {
                    lblAidatKontrol.Text = "Ödedi";
                }
                else
                {
                    lblAidatKontrol.Text = "Ödemedi";
                }
            }
            baglanti.Close();
        }

        private void btnB2_Click(object sender, EventArgs e)
        {
            temizle();
            btnB2.ForeColor = Color.Black;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from kisiBilgiler where DaireNo= 'B2' OR DaireNo='b2'", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                temp = double.Parse(oku["Aidat"].ToString());
                lblAdSoyad.Text = oku["Ad"].ToString() + " " + oku["Soyad"].ToString();
                if (temp == 0)
                {
                    lblAidatKontrol.Text = "Ödedi";
                }
                else
                {
                    lblAidatKontrol.Text = "Ödemedi";
                }
            }
            baglanti.Close();

        }

        private void btnB3_Click(object sender, EventArgs e)
        {
            temizle();
            btnB3.ForeColor = Color.Black;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from kisiBilgiler where DaireNo= 'B3' OR DaireNo='b3'", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                temp = double.Parse(oku["Aidat"].ToString());
                lblAdSoyad.Text = oku["Ad"].ToString() + " " + oku["Soyad"].ToString();
                if (temp == 0)
                {
                    lblAidatKontrol.Text = "Ödedi";
                }
                else
                {
                    lblAidatKontrol.Text = "Ödemedi";
                }
            }
            baglanti.Close();
        }

        private void btnB4_Click(object sender, EventArgs e)
        {
            temizle();
            btnB4.ForeColor = Color.Black;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from kisiBilgiler where DaireNo= 'B4' OR DaireNo='b4'", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                temp = double.Parse(oku["Aidat"].ToString());
                lblAdSoyad.Text = oku["Ad"].ToString() + " " + oku["Soyad"].ToString();
                if (temp == 0)
                {
                    lblAidatKontrol.Text = "Ödedi";
                }
                else
                {
                    lblAidatKontrol.Text = "Ödemedi";
                }
            }
            baglanti.Close();
        }

        private void btnB5_Click(object sender, EventArgs e)
        {
            temizle();
            btnB5.ForeColor = Color.Black;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from kisiBilgiler where DaireNo= 'B5' OR DaireNo='b5'", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                temp = double.Parse(oku["Aidat"].ToString());
                lblAdSoyad.Text = oku["Ad"].ToString() + " " + oku["Soyad"].ToString();
                if (temp == 0)
                {
                    lblAidatKontrol.Text = "Ödedi";
                }
                else
                {
                    lblAidatKontrol.Text = "Ödemedi";
                }
            }
            baglanti.Close();
        }

        private void btnB6_Click(object sender, EventArgs e)
        {
            temizle();
            btnB6.ForeColor = Color.Black;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from kisiBilgiler where DaireNo= 'B6' OR DaireNo='b6'", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                temp = double.Parse(oku["Aidat"].ToString());
                lblAdSoyad.Text = oku["Ad"].ToString() + " " + oku["Soyad"].ToString();
                if (temp == 0)
                {
                    lblAidatKontrol.Text = "Ödedi";
                }
                else
                {
                    lblAidatKontrol.Text = "Ödemedi";
                }
            }
            baglanti.Close();
        }

        private void btnB7_Click(object sender, EventArgs e)
        {
            temizle();
            btnB7.ForeColor = Color.Black;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from kisiBilgiler where DaireNo= 'B7' OR DaireNo='b7'", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                temp = double.Parse(oku["Aidat"].ToString());
                lblAdSoyad.Text = oku["Ad"].ToString() + " " + oku["Soyad"].ToString();
                if (temp == 0)
                {
                    lblAidatKontrol.Text = "Ödedi";
                }
                else
                {
                    lblAidatKontrol.Text = "Ödemedi";
                }
            }
            baglanti.Close();
        }

        private void btnB8_Click(object sender, EventArgs e)
        {
            temizle();
            btnB8.ForeColor = Color.Black;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from kisiBilgiler where DaireNo= 'B8' OR DaireNo='b8'", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                temp = double.Parse(oku["Aidat"].ToString());
                lblAdSoyad.Text = oku["Ad"].ToString() + " " + oku["Soyad"].ToString();
                if (temp == 0)
                {
                    lblAidatKontrol.Text = "Ödedi";
                }
                else
                {
                    lblAidatKontrol.Text = "Ödemedi";
                }
            }
            baglanti.Close();
        }

        private void btnB9_Click(object sender, EventArgs e)
        {
            temizle();
            btnB9.ForeColor = Color.Black;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from kisiBilgiler where DaireNo= 'B9' OR DaireNo='b9'", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                temp = double.Parse(oku["Aidat"].ToString());
                lblAdSoyad.Text = oku["Ad"].ToString() + " " + oku["Soyad"].ToString();
                if (temp == 0)
                {
                    lblAidatKontrol.Text = "Ödedi";
                }
                else
                {
                    lblAidatKontrol.Text = "Ödemedi";
                }
            }
            baglanti.Close();
        }

        private void btnB10_Click(object sender, EventArgs e)
        {
            temizle();
            btnB10.ForeColor = Color.Black;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from kisiBilgiler where DaireNo= 'B10' OR DaireNo='b10'", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                temp = double.Parse(oku["Aidat"].ToString());
                lblAdSoyad.Text = oku["Ad"].ToString() + " " + oku["Soyad"].ToString();
                if (temp == 0)
                {
                    lblAidatKontrol.Text = "Ödedi";
                }
                else
                {
                    lblAidatKontrol.Text = "Ödemedi";
                }
            }
            baglanti.Close();
        }

        private void btnB11_Click(object sender, EventArgs e)
        {
            temizle();
            btnB11.ForeColor = Color.Black;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from kisiBilgiler where DaireNo= 'B11' OR DaireNo='b11'", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                temp = double.Parse(oku["Aidat"].ToString());
                lblAdSoyad.Text = oku["Ad"].ToString() + " " + oku["Soyad"].ToString();
                if (temp == 0)
                {
                    lblAidatKontrol.Text = "Ödedi";
                }
                else
                {
                    lblAidatKontrol.Text = "Ödemedi";
                }
            }
            baglanti.Close();
        }

        private void btnB12_Click(object sender, EventArgs e)
        {
            temizle();
            btnB12.ForeColor = Color.Black;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from kisiBilgiler where DaireNo= 'B12' OR DaireNo='b12'", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                temp = double.Parse(oku["Aidat"].ToString());
                lblAdSoyad.Text = oku["Ad"].ToString() + " " + oku["Soyad"].ToString();
                if (temp == 0)
                {
                    lblAidatKontrol.Text = "Ödedi";
                }
                else
                {
                    lblAidatKontrol.Text = "Ödemedi";
                }
            }
            baglanti.Close();
        }

        private void btnB13_Click(object sender, EventArgs e)
        {
            temizle();
            btnB13.ForeColor = Color.Black;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from kisiBilgiler where DaireNo= 'B13' OR DaireNo='b13'", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                temp = double.Parse(oku["Aidat"].ToString());
                lblAdSoyad.Text = oku["Ad"].ToString() + " " + oku["Soyad"].ToString();
                if (temp == 0)
                {
                    lblAidatKontrol.Text = "Ödedi";
                }
                else
                {
                    lblAidatKontrol.Text = "Ödemedi";
                }
            }
            baglanti.Close();
        }

        private void btnB14_Click(object sender, EventArgs e)
        {
            temizle();
            btnB14.ForeColor = Color.Black;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from kisiBilgiler where DaireNo= 'B14' OR DaireNo='b14'", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                temp = double.Parse(oku["Aidat"].ToString());
                lblAdSoyad.Text = oku["Ad"].ToString() + " " + oku["Soyad"].ToString();
                if (temp == 0)
                {
                    lblAidatKontrol.Text = "Ödedi";
                }
                else
                {
                    lblAidatKontrol.Text = "Ödemedi";
                }
            }
            baglanti.Close();
        }

        private void btnB15_Click(object sender, EventArgs e)
        {
            temizle();
            btnB15.ForeColor = Color.Black;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from kisiBilgiler where DaireNo= 'B15' OR DaireNo='b15'", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                temp = double.Parse(oku["Aidat"].ToString());
                lblAdSoyad.Text = oku["Ad"].ToString() + " " + oku["Soyad"].ToString();
                if (temp == 0)
                {
                    lblAidatKontrol.Text = "Ödedi";
                }
                else
                {
                    lblAidatKontrol.Text = "Ödemedi";
                }
            }
            baglanti.Close();
        }

        private void btnB16_Click(object sender, EventArgs e)
        {
            temizle();
            btnB16.ForeColor = Color.Black;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from kisiBilgiler where DaireNo= 'B16' OR DaireNo='b16'", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                temp = double.Parse(oku["Aidat"].ToString());
                lblAdSoyad.Text = oku["Ad"].ToString() + " " + oku["Soyad"].ToString();
                if (temp == 0)
                {
                    lblAidatKontrol.Text = "Ödedi";
                }
                else
                {
                    lblAidatKontrol.Text = "Ödemedi";
                }
            }
            baglanti.Close();
        }

        private void btnB17_Click(object sender, EventArgs e)
        {
            temizle();
            btnB17.ForeColor = Color.Black;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from kisiBilgiler where DaireNo= 'B17' OR DaireNo='b17'", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                temp = double.Parse(oku["Aidat"].ToString());
                lblAdSoyad.Text = oku["Ad"].ToString() + " " + oku["Soyad"].ToString();
                if (temp == 0)
                {
                    lblAidatKontrol.Text = "Ödedi";
                }
                else
                {
                    lblAidatKontrol.Text = "Ödemedi";
                }
            }
            baglanti.Close();
        }

        private void btnB18_Click(object sender, EventArgs e)
        {
            temizle();
            btnB18.ForeColor = Color.Black;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from kisiBilgiler where DaireNo= 'B18' OR DaireNo='b18'", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                temp = double.Parse(oku["Aidat"].ToString());
                lblAdSoyad.Text = oku["Ad"].ToString() + " " + oku["Soyad"].ToString();
                if (temp == 0)
                {
                    lblAidatKontrol.Text = "Ödedi";
                }
                else
                {
                    lblAidatKontrol.Text = "Ödemedi";
                }
            }
            baglanti.Close();
        }

        private void btnB19_Click(object sender, EventArgs e)
        {
            temizle();
            btnB19.ForeColor = Color.Black;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from kisiBilgiler where DaireNo= 'B19' OR DaireNo='b19'", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                temp = double.Parse(oku["Aidat"].ToString());
                lblAdSoyad.Text = oku["Ad"].ToString() + " " + oku["Soyad"].ToString();
                if (temp == 0)
                {
                    lblAidatKontrol.Text = "Ödedi";
                }
                else
                {
                    lblAidatKontrol.Text = "Ödemedi";
                }
            }
            baglanti.Close();
        }

        private void btnB20_Click(object sender, EventArgs e)
        {
            temizle();
            btnB20.ForeColor = Color.Black;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from kisiBilgiler where DaireNo= 'B20' OR DaireNo='b20'", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                temp = double.Parse(oku["Aidat"].ToString());
                lblAdSoyad.Text = oku["Ad"].ToString() + " " + oku["Soyad"].ToString();
                if (temp == 0)
                {
                    lblAidatKontrol.Text = "Ödedi";
                }
                else
                {
                    lblAidatKontrol.Text = "Ödemedi";
                }
            }
            baglanti.Close();
        }

        private void frmDaireler_Load(object sender, EventArgs e)
        {

        }
    }
}
