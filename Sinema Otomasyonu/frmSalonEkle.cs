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

namespace Sinema_Otomasyonu
{
    public partial class frmSalonEkle : Form
    {
        public frmSalonEkle()
        {
            InitializeComponent();
        }

        private void frmSalonEkle_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmAnaSayfa anasayfa= new frmAnaSayfa();
            this.Hide();
            anasayfa.ShowDialog();
            
        }
        sinemaTableAdapters.Salon_BilgileriTableAdapter salon = new sinemaTableAdapters.Salon_BilgileriTableAdapter();
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                salon.SalonEkle(txt_SalonAdi.Text);
                MessageBox.Show("Salon Eklendi");
            }
            catch (Exception)
            {

                MessageBox.Show("Aynı İsimde Bir Salon Mevcut");
            }
            txt_SalonAdi.Text = "";
        }

        private void frmSalonEkle_Load(object sender, EventArgs e)
        {

        }
    }
}
