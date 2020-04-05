using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApartmanKayit
{
    public partial class form1 : Form
    {
        public form1()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if(TxtKullaniciAdi.Text == "admin" && TxtSifre.Text == "galata324")
            {
                frmAnaSayfa anaSayfa = new frmAnaSayfa();
                anaSayfa.Show();
                this.Hide();
            }
            else
            {                
                MessageBox.Show("Yasin Aga kullanıcı adın veya şifren yanlış!", "Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                TxtKullaniciAdi.Text = "";
                TxtSifre.Text = "";
            }
        }
    }
}
