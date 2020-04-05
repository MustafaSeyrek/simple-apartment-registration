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
    public partial class frmGiderler : Form
    {
        public frmGiderler()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(System.IO.File.ReadAllText(@"C:\server.txt"));
        private void verileriGoster()
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from giderler", baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["id"].ToString();
                ekle.SubItems.Add(oku["ElektrikA"].ToString());
                ekle.SubItems.Add(oku["ElektrikB"].ToString());
                ekle.SubItems.Add(oku["Su"].ToString());
                ekle.SubItems.Add(oku["MuhtelifGiderler"].ToString());               
                ekle.SubItems.Add(oku["Aciklama"].ToString());

                listView1.Items.Add(ekle);
            }
            baglanti.Close();
        }

        private void lblElektrikA_Click(object sender, EventArgs e)
        {

        }
        int id = 0;
        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            txtElektrikA.Text = listView1.SelectedItems[0].SubItems[1].Text;
            txtElektrikB.Text = listView1.SelectedItems[0].SubItems[2].Text;
            txtSu.Text = listView1.SelectedItems[0].SubItems[3].Text;
            txtMuhtelif.Text = listView1.SelectedItems[0].SubItems[4].Text;
            txtAciklamaGider.Text = listView1.SelectedItems[0].SubItems[5].Text;
           
        }
        private void temizle()
        {
            txtElektrikA.Text = "";
            txtElektrikB.Text = "";
            txtSu.Text = "";
            txtMuhtelif.Text = "";
            txtAciklamaGider.Text = "";           
        }

        private void btnVerileriGoster_Click(object sender, EventArgs e)
        {
            verileriGoster();
            temizle();

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtElektrikA.Text != "" && txtElektrikB.Text!="" && txtSu.Text!="" && txtMuhtelif.Text!="")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into giderler(ElektrikA,ElektrikB,Su,MuhtelifGiderler,Aciklama) values (@ElektrikA,@ElektrikB,@Su,@MuhtelifGiderler,@Aciklama)", baglanti);
               
                komut.Parameters.AddWithValue("@ElektrikA", double.Parse(txtElektrikA.Text));
                komut.Parameters.AddWithValue("@ElektrikB", double.Parse(txtElektrikB.Text));
                komut.Parameters.AddWithValue("@Su", double.Parse(txtSu.Text));
                komut.Parameters.AddWithValue("@MuhtelifGiderler", double.Parse(txtMuhtelif.Text));
                komut.Parameters.AddWithValue("@Aciklama", txtAciklamaGider.Text);
                komut.ExecuteNonQuery();
                baglanti.Close();
                listView1.Items.Clear();
                verileriGoster();
                temizle();
            }
            else
            {
                MessageBox.Show("Boş alan kaldı!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from giderler where id=(" + id + ")", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            verileriGoster();
            temizle();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (txtElektrikA.Text != "" && txtElektrikB.Text != "" && txtSu.Text != "" && txtMuhtelif.Text != "")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("update giderler set ElektrikA=@ElektrikA,ElektrikB=@ElektrikB,Su=@Su,MuhtelifGiderler=@MuhtelifGiderler, Aciklama=@Aciklama where id='" + id + "'", baglanti);
                komut.Parameters.AddWithValue("@ElektrikA", double.Parse(txtElektrikA.Text));
                komut.Parameters.AddWithValue("@ElektrikB", double.Parse(txtElektrikB.Text));
                komut.Parameters.AddWithValue("@Su", double.Parse(txtSu.Text));
                komut.Parameters.AddWithValue("@MuhtelifGiderler", double.Parse(txtMuhtelif.Text));
                komut.Parameters.AddWithValue("@Aciklama", txtAciklamaGider.Text);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verileriGoster();
                temizle();
            }
            else
            {
                MessageBox.Show("Boş alan kaldı!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void frmGiderler_Load(object sender, EventArgs e)
        {

        }
    }
}
