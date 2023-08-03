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
    public partial class frmSatisListele : Form
    {
        public frmSatisListele()
        {
            InitializeComponent();
        }
        sinemaTableAdapters.SatisBilgileriTableAdapter satisListesi = new sinemaTableAdapters.SatisBilgileriTableAdapter();
        private void frmSatisListele_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = satisListesi.TariheGoreListele2(dateTimePicker1.Text);
            ToplamUcretHesapla();

        }

        private void ToplamUcretHesapla()
        {
            int ucrettoplami = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                ucrettoplami += Convert.ToInt32(dataGridView1.Rows[i].Cells["ucret"].Value);
            }
            label1.Text = "Toplam Satış =" + ucrettoplami + " TL";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = satisListesi.SatisListesi2();
            ToplamUcretHesapla();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = satisListesi.TariheGoreListele2(dateTimePicker1.Text);
            ToplamUcretHesapla();
        }

        private void frmSatisListele_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmAnaSayfa anasayfa = new frmAnaSayfa();
            anasayfa.Show();
            this.Hide();


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
