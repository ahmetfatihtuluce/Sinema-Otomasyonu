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
    public partial class frmSeansEkle : Form
    {
        public frmSeansEkle()
        {
            InitializeComponent();
        }

        // Adaptör
        sinemaTableAdapters.Seans_BilgileriTableAdapter filmseansi = new sinemaTableAdapters.Seans_BilgileriTableAdapter();
        //Bağlantı
        SqlConnection baglanti = new SqlConnection("Data Source=.\\sqlexpress;Initial Catalog=Sinema_Bileti;Integrated Security=True");
        //Filme Ve Salon bilgilerini comboboxa getirme!
        private void FilmVeSalonGoster(ComboBox combo, string sql, string sql2)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand(sql,baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while(read.Read())
            {
                combo.Items.Add(read[sql2].ToString());
            }
            baglanti.Close();
        }

        string seans = "";
        private void RadioButtonSeciliyse()
        {
            if (radioButton1.Checked == true) seans = radioButton1.Text;
            else if (radioButton1.Checked == true) seans = radioButton1.Text;
            else if (radioButton2.Checked == true) seans = radioButton2.Text;
            else if (radioButton3.Checked == true) seans = radioButton3.Text;
            else if (radioButton4.Checked == true) seans = radioButton4.Text;
            else if (radioButton5.Checked == true) seans = radioButton5.Text;
            else if (radioButton6.Checked == true) seans = radioButton6.Text;
            else if (radioButton7.Checked == true) seans = radioButton7.Text;
            else if (radioButton8.Checked == true) seans = radioButton8.Text;
            else if (radioButton9.Checked == true) seans = radioButton9.Text;
            else if (radioButton10.Checked == true) seans = radioButton10.Text;
            else if (radioButton11.Checked == true) seans = radioButton11.Text;
            else if (radioButton12.Checked == true) seans = radioButton12.Text;

        }

        private void button1_Click(object sender, EventArgs e)
        {

            RadioButtonSeciliyse();
            if (seans != "")
            {
                
                try
                {
                    filmseansi.SeansEkleme(cmbFilm.Text, cmbSalon.Text, dateTimePicker1.Text, seans);
                    MessageBox.Show("Seans Eklendi");
                }
                catch (Exception)
                {

                    MessageBox.Show("Seans Ekleme Başarısız!");
                }
                
            }
            else if (seans == "")
            {
                MessageBox.Show("Seans Seçimi Yapınız!");
            }

            //Sıfırlama
            cmbFilm.Text = "";
            cmbSalon.Text = "";
            dateTimePicker1.Text = DateTime.Now.ToShortDateString();
        }

        private void frmSeansEkle_Load(object sender, EventArgs e)
        {
            FilmVeSalonGoster(cmbFilm, "select * from film_bilgileri", "filmadi");
            FilmVeSalonGoster(cmbSalon, "select * from salon_bilgileri", "salonadi");
        }

        private void frmSeansEkle_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmAnaSayfa anasayfa = new frmAnaSayfa();
            anasayfa.Show();
            this.Hide();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            foreach (Control item3 in panel1.Controls)
            {
                item3.Enabled = true;
            }


            DateTime bugun = DateTime.Parse(DateTime.Now.ToShortDateString());
            DateTime yeni = DateTime.Parse(dateTimePicker1.Text);
            if (yeni == bugun)
            {
                foreach (Control item in panel1.Controls)
                {
                    if (DateTime.Parse(DateTime.Now.ToShortDateString()) > DateTime.Parse(item.Text)) ;
                    {
                        item.Enabled = false;
                    }
                }
                Tarihi_karsilastir();
            }
            else if (yeni > bugun) { Tarihi_karsilastir(); }
            else if (yeni < bugun) { MessageBox.Show("Geriye dönük işlem yapılamaz!"); dateTimePicker1.Text = DateTime.Now.ToShortDateString(); }
        }

        private void Tarihi_karsilastir()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from seans_bilgileri where salonadi='" + cmbSalon.Text + "' and tarih='" + dateTimePicker1.Text + "'", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                foreach (Control item2 in panel1.Controls)
                    if (read["seans"].ToString() == item2.Text)
                    {
                        item2.Enabled = false;
                    }
            }
            baglanti.Close();
        }

        private void cmbSalon_SelectedIndexChanged(object sender, EventArgs e)
        {
            dateTimePicker1.Text = DateTime.Now.ToShortDateString();
        }

        private void cmbFilm_SelectedIndexChanged(object sender, EventArgs e)
        {
            dateTimePicker1.Text = DateTime.Now.ToShortDateString();
        }
    }
}
