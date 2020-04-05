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
    public partial class frmAnaSayfa : Form
    {
        public frmAnaSayfa()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            frmKayitIslemleri kayit = new frmKayitIslemleri();
            kayit.Show();
        }

        private void btnDaireler_Click(object sender, EventArgs e)
        {
            frmDaireler daireler = new frmDaireler();
            daireler.Show();
        }

        private void btnGiderler_Click(object sender, EventArgs e)
        {
            frmGiderler giderler = new frmGiderler();
            giderler.Show();
        }

        private void frmAnaSayfa_Load(object sender, EventArgs e)
        {

        }
    }
}
