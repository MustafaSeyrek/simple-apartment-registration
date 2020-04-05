using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ApartmanKayit
{
    public partial class frmKayitIslemleri : Form
    {
        public frmKayitIslemleri()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(System.IO.File.ReadAllText(@"C:\server.txt"));
        //verileri göster butonu
        private void verileriGoster()
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from kisiBilgiler", baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["id"].ToString();
                ekle.SubItems.Add(oku["Ad"].ToString());
                ekle.SubItems.Add(oku["Soyad"].ToString());
                ekle.SubItems.Add(oku["DaireNo"].ToString());
                ekle.SubItems.Add(oku["Telefon"].ToString());
                ekle.SubItems.Add(oku["Aidat"].ToString());
                ekle.SubItems.Add(oku["Aciklama"].ToString());

                listView1.Items.Add(ekle);
            }
            baglanti.Close();
        }
        
        
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            verileriGoster();
            temizle();
        }

        private void frmKayitIslemleri_Load(object sender, EventArgs e)
        {

        }

       
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtAidat.Text != "")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into kisiBilgiler(Ad,Soyad,DaireNo,Telefon,Aidat,Aciklama) values (@Ad,@Soyad,@DaireNo,@Telefon,@Aidat,@Aciklama)", baglanti);
                komut.Parameters.AddWithValue("@Ad", txtAd.Text);
                komut.Parameters.AddWithValue("@Soyad", txtSoyad.Text);
                komut.Parameters.AddWithValue("@DaireNo", txtDaireNo.Text);
                komut.Parameters.AddWithValue("@Telefon", txtTelefon.Text);
                komut.Parameters.AddWithValue("@Aidat", double.Parse(txtAidat.Text));
                komut.Parameters.AddWithValue("@Aciklama", txtAciklama.Text);
                komut.ExecuteNonQuery();
                baglanti.Close();
                listView1.Items.Clear();
                verileriGoster();
                temizle();
            }
            else
            {
                MessageBox.Show("Aidat boş kaldı!", "Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        int id = 0;
        private void btnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from kisiBilgiler where id=("+id+")", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            verileriGoster();
            temizle();
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            txtAd.Text = listView1.SelectedItems[0].SubItems[1].Text;
            txtSoyad.Text = listView1.SelectedItems[0].SubItems[2].Text;
            txtDaireNo.Text = listView1.SelectedItems[0].SubItems[3].Text;
            txtTelefon.Text = listView1.SelectedItems[0].SubItems[4].Text;
            txtAidat.Text = listView1.SelectedItems[0].SubItems[5].Text;
            txtAciklama.Text = listView1.SelectedItems[0].SubItems[6].Text;
        }

        private void temizle()
        {
            txtAd.Text = "";
            txtSoyad.Text = "";
            txtDaireNo.Text = "";
            txtTelefon.Text = "";
            txtAidat.Text = "";
            txtAciklama.Text = "";
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (txtAidat.Text != "")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("update kisiBilgiler set Ad=@Ad,Soyad=@Soyad,DaireNo=@DaireNo,Telefon=@Telefon, Aidat=@Aidat, Aciklama=@Aciklama where id='" + id + "'", baglanti);
                komut.Parameters.AddWithValue("@Ad", txtAd.Text);
                komut.Parameters.AddWithValue("@Soyad", txtSoyad.Text);
                komut.Parameters.AddWithValue("@DaireNo", txtDaireNo.Text);
                komut.Parameters.AddWithValue("@Telefon", txtTelefon.Text);
                komut.Parameters.AddWithValue("@Aidat", double.Parse(txtAidat.Text));
                komut.Parameters.AddWithValue("@Aciklama", txtAciklama.Text);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verileriGoster();
                temizle();
            }
            else
            {
                MessageBox.Show("Aidat boş kaldı!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from kisiBilgiler where Ad like '%"+txtAdAra.Text+"%'", baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["id"].ToString();
                ekle.SubItems.Add(oku["Ad"].ToString());
                ekle.SubItems.Add(oku["Soyad"].ToString());
                ekle.SubItems.Add(oku["DaireNo"].ToString());
                ekle.SubItems.Add(oku["Telefon"].ToString());
                ekle.SubItems.Add(oku["Aidat"].ToString());
                ekle.SubItems.Add(oku["Aciklama"].ToString());

                listView1.Items.Add(ekle);
            }
            baglanti.Close();
            txtAdAra.Text = "";
            
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
