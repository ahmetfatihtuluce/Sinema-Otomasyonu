using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sinema_Otomasyonu
{
    public partial class frmFilmEkle : Form
    {
        public frmFilmEkle()
        {
            InitializeComponent();
        }
        sinemaTableAdapters.Film_BilgileriTableAdapter film= new sinemaTableAdapters.Film_BilgileriTableAdapter();
        private void btn_filmEkle_Click(object sender, EventArgs e)
        {
            try
            {
               film.FilmEkleme(txt_FilmAdi.Text, txt_yonetmen.Text, cmbbox_tur.Text, txt_sure.Text, dateTimePicker1.Text, txt_yil.Text, pct_afis.ImageLocation);
                MessageBox.Show("Film Başarı İle eklendi.");
            }
            catch (Exception)
            {

                MessageBox.Show("Bu Film Daha Önce Eklendi!");
            }
            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
                cmbbox_tur.Text = "";
            }
        }

        private void btn_AfisSec_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pct_afis.ImageLocation = openFileDialog1.FileName;
        }

        private void frmFilmEkle_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmAnaSayfa anaSayfa = new frmAnaSayfa();
            anaSayfa.Show();
            this.Hide();
        }

        private void frmFilmEkle_Load(object sender, EventArgs e)
        {

        }
    }
}
