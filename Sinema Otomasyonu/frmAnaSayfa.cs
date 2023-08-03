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
    public partial class frmAnaSayfa : Form
    {
        public frmAnaSayfa()
        {
            InitializeComponent();
        }

        // bağlantı yolu
        SqlConnection baglanti = new SqlConnection("Data Source=.\\sqlexpress;Initial Catalog=Sinema_Bileti;Integrated Security=True");

        //koltuk doldurma
        int sayac = 0;
        private void filmAfisiGoster()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from film_bilgileri where filmadi='"+cmbfilmadi.SelectedItem+"'",baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                pictureBox1.ImageLocation = read["resim"].ToString();
            }
            baglanti.Close();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Boskoltuk();
            SalonVeFilmGetir(cmbfilmadi,"select * from  film_bilgileri","filmadi");
            SalonVeFilmGetir(cmbsalonadi, "select * from  salon_bilgileri", "salonadi");
        }

        private void SalonVeFilmGetir(ComboBox combo, string sql1, string sql2)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand(sql1, baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                combo.Items.Add(read[sql2].ToString());
            }
            baglanti.Close();
        }
        private void Boskoltuk()
        {
            sayac = 1;
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    Button btn = new Button();
                    btn.Size = new Size(30, 30);
                    btn.BackColor = Color.White;
                    btn.Location = new Point(j * 30 + 20, i * 30 + 20);
                    btn.Name = sayac.ToString();
                    btn.Text = sayac.ToString();
                    if (j == 4)
                    {
                        continue;
                    }
                    sayac++;
                    this.panel2.Controls.Add(btn);
                    btn.Click += Btn_Click;
                }
            }
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.BackColor == Color.White)
            {
                txtkltkno.Text = b.Text;
            }

        }

        private void btnSalonEkle_Click(object sender, EventArgs e)
        {
            frmSalonEkle ekle = new frmSalonEkle();
            ekle.Show();
            this.Hide();
        }

        private void c_Click(object sender, EventArgs e)
        {
            frmFilmEkle ekle = new frmFilmEkle();
            ekle.Show();
            this.Hide();
        }

        private void btnSeansEkle_Click(object sender, EventArgs e)
        {
            frmSeansEkle ekle = new frmSeansEkle();
            ekle.Show();
            this.Hide();
        }

        private void btnSeansListele_Click(object sender, EventArgs e)
        {
            frmSeansListele goster = new frmSeansListele();
            goster.Show();
            this.Hide();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSatislar_Click(object sender, EventArgs e)
        {
            frmSatisListele ekle = new frmSatisListele();
            ekle.Show();
            this.Hide();
        }

        private void cmbfilmadi_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            cmbseans.Items.Clear();
            cmbtarih.Items.Clear();
            cmbsalonadi.Text = "";
            cmbtarih.Text = "";
            cmbsalonadi.Text = "";
            cmbseans.Text = "";
            foreach (Control item in panel2.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
            filmAfisiGoster();
            YenidenRenklendir();
            
        }

        private void YenidenRenklendir()
        {
            foreach (Control item in panel2.Controls)
            {
                if (item is Button)
                {
                    item.BackColor = Color.White;
                }
            }
        }

        private void DoluKoltuklar()
        {
            //MessageBox.Show("1");
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from SatisBilgileri where Filmadi= '"+cmbfilmadi.SelectedItem+"' and Salonadi='"+cmbsalonadi.SelectedItem+"' and Tarih='"+cmbtarih.SelectedItem+"' and Saat='"+cmbseans.SelectedItem+"' ",baglanti);
            SqlCommand komut2 = new SqlCommand("select * from satisbilgileri where filmadi='"+cmbfilmadi.SelectedItem+"' and salonadi='"+cmbsalonadi.SelectedItem+"' and tarih='"+cmbtarih.SelectedItem+"' and saat='"+cmbseans.SelectedItem+"'",baglanti);
            SqlDataReader read = komut.ExecuteReader();
           
            //MessageBox.Show("2");
            while (read.Read())
            {
                
                foreach (Control item in panel2.Controls)
                {

                    
                    if (read["koltukno"].ToString() == item.Text)
                    {
                       
                            item.BackColor = Color.Red;
                        
                        
                    }
                }
            }
            baglanti.Close();
        }

        private void comboDoluKoltuklar()
        {   

            cmbiptal.Items.Clear();
            cmbiptal.Text = "";

            foreach (Control item in panel2.Controls)
            {
                if (item is Button && item.BackColor == Color.Red)
                {
                    
                    cmbiptal.Items.Add(item.Text);
                }
            }
        }

        sinemaTableAdapters.SatisBilgileriTableAdapter satis = new sinemaTableAdapters.SatisBilgileriTableAdapter();

        private void button2_Click(object sender, EventArgs e)
        {

            if (txtkltkno.Text != "")
            {
                try
                {
                    satis.SatisYap(txtkltkno.Text, cmbsalonadi.Text, cmbfilmadi.Text, cmbtarih.Text, cmbseans.Text, txtad.Text, txtsoyad.Text, cmbucret.Text, DateTime.Today.ToString("dd.MM.yyyy"));
                    MessageBox.Show("Satış Başarılı");
                    foreach (Control item in groupBox2.Controls)
                    {
                        if (item is TextBox)
                        {
                            item.Text = "";
                        }
                    }
                    YenidenRenklendir();
                    DoluKoltuklar();
                    comboDoluKoltuklar();
                }
                catch (Exception)
                {

                    MessageBox.Show("HATA!");
                }
            }
            else
            {
                MessageBox.Show("Koltuk Seçmediniz.");
            }
        }

        private void filmTarihiGetir()
        {

            cmbtarih.Text = "";
            cmbseans.Text = "";
            cmbtarih.Items.Clear();
            cmbseans.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from seans_bilgileri where filmadi='"+cmbfilmadi.Text+"' and salonadi= '"+cmbsalonadi.Text+"'",baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                if (DateTime.Parse(read["tarih"].ToString())>=DateTime.Parse(DateTime.Now.ToShortDateString()))
                {

                    if (!cmbtarih.Items.Contains(read["tarih"].ToString()))
                    {
                        cmbtarih.Items.Add(read["tarih"].ToString());
                    }
                    

                }
            }
            baglanti.Close();
        }

        private void cmbsalonadi_SelectedIndexChanged(object sender, EventArgs e)
        {
            filmTarihiGetir();
        }

        private void SeansGetir()
        {

            cmbseans.Text = "";
            cmbseans.Items.Clear();

            cmbseans.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from seans_bilgileri where filmadi='" + cmbfilmadi.Text + "' and salonadi= '" + cmbsalonadi.Text + "' and tarih= '"+cmbtarih.SelectedItem+"'", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                if (DateTime.Parse(read["tarih"].ToString()) == DateTime.Parse(DateTime.Now.ToShortDateString()))
                {
                    if (DateTime.Parse(read["seans"].ToString()) > DateTime.Now)
                    {
                        cmbseans.Items.Add(read["seans"].ToString());
                    }
         
                }
                else if (DateTime.Parse(read["tarih"].ToString()) > DateTime.Parse(DateTime.Now.ToShortDateString()))
                {

                 
                        cmbseans.Items.Add(read["seans"].ToString());
                        
                  

                }
            }
            baglanti.Close();

        }

        private void cmbseans_SelectedIndexChanged(object sender, EventArgs e)
        {

            
            YenidenRenklendir();           
            DoluKoltuklar();           
            comboDoluKoltuklar();  
            
        }

        private void cmbtarih_SelectedIndexChanged(object sender, EventArgs e)
        {
            SeansGetir();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                if (cmbiptal.Text != "")
                {
                    satis.Satisiptal(cmbfilmadi.Text, cmbsalonadi.Text, cmbtarih.Text, cmbseans.Text, cmbiptal.Text);
                    MessageBox.Show("Başarılı!");
                    YenidenRenklendir();
                    DoluKoltuklar();
                    comboDoluKoltuklar();


                }
                else
                {
                    MessageBox.Show("Koltuk Seçimi Yapılmadı!");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Hata!");
            }

            
        }
    }
}
