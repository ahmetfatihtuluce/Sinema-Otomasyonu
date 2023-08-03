namespace Sinema_Otomasyonu
{
    partial class frmAnaSayfa
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAnaSayfa));
            this.btnSalonEkle = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.c = new System.Windows.Forms.Button();
            this.btnSeansEkle = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnSeansListele = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.txtsoyad = new System.Windows.Forms.TextBox();
            this.txtad = new System.Windows.Forms.TextBox();
            this.txtkltkno = new System.Windows.Forms.TextBox();
            this.cmbucret = new System.Windows.Forms.ComboBox();
            this.cmbseans = new System.Windows.Forms.ComboBox();
            this.cmbtarih = new System.Windows.Forms.ComboBox();
            this.cmbsalonadi = new System.Windows.Forms.ComboBox();
            this.cmbfilmadi = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cmbiptal = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnSatislar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSalonEkle
            // 
            this.btnSalonEkle.BackColor = System.Drawing.Color.Cyan;
            this.btnSalonEkle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSalonEkle.ForeColor = System.Drawing.Color.Black;
            this.btnSalonEkle.ImageIndex = 4;
            this.btnSalonEkle.ImageList = this.ımageList1;
            this.btnSalonEkle.Location = new System.Drawing.Point(33, 13);
            this.btnSalonEkle.Name = "btnSalonEkle";
            this.btnSalonEkle.Size = new System.Drawing.Size(75, 75);
            this.btnSalonEkle.TabIndex = 0;
            this.btnSalonEkle.Text = "SALON EKLE";
            this.btnSalonEkle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalonEkle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSalonEkle.UseVisualStyleBackColor = false;
            this.btnSalonEkle.Click += new System.EventHandler(this.btnSalonEkle_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "exit.png");
            this.ımageList1.Images.SetKeyName(1, "iamge3.jpg");
            this.ımageList1.Images.SetKeyName(2, "icon1.png");
            this.ımageList1.Images.SetKeyName(3, "img2.jpg");
            this.ımageList1.Images.SetKeyName(4, "Salon1.png");
            this.ımageList1.Images.SetKeyName(5, "Seans.png");
            this.ımageList1.Images.SetKeyName(6, "Seans2.png");
            this.ımageList1.Images.SetKeyName(7, "thumbs_b_c_0a0614ec64694cf784afdf4828dd74e2.jpg");
            this.ımageList1.Images.SetKeyName(8, "money.jpg");
            // 
            // c
            // 
            this.c.BackColor = System.Drawing.Color.Cyan;
            this.c.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.c.Cursor = System.Windows.Forms.Cursors.Default;
            this.c.ForeColor = System.Drawing.Color.Black;
            this.c.ImageIndex = 1;
            this.c.ImageList = this.ımageList1;
            this.c.Location = new System.Drawing.Point(114, 13);
            this.c.Name = "c";
            this.c.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.c.Size = new System.Drawing.Size(75, 75);
            this.c.TabIndex = 1;
            this.c.Text = "FİLM EKLE";
            this.c.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.c.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.c.UseVisualStyleBackColor = false;
            this.c.Click += new System.EventHandler(this.c_Click);
            // 
            // btnSeansEkle
            // 
            this.btnSeansEkle.BackColor = System.Drawing.Color.Cyan;
            this.btnSeansEkle.ForeColor = System.Drawing.Color.Black;
            this.btnSeansEkle.ImageIndex = 3;
            this.btnSeansEkle.ImageList = this.ımageList1;
            this.btnSeansEkle.Location = new System.Drawing.Point(195, 13);
            this.btnSeansEkle.Name = "btnSeansEkle";
            this.btnSeansEkle.Size = new System.Drawing.Size(75, 75);
            this.btnSeansEkle.TabIndex = 2;
            this.btnSeansEkle.Text = "SEANS EKLE";
            this.btnSeansEkle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSeansEkle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSeansEkle.UseVisualStyleBackColor = false;
            this.btnSeansEkle.Click += new System.EventHandler(this.btnSeansEkle_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.BackColor = System.Drawing.Color.Cyan;
            this.btnCikis.ImageKey = "exit.png";
            this.btnCikis.ImageList = this.ımageList1;
            this.btnCikis.Location = new System.Drawing.Point(445, 12);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnCikis.Size = new System.Drawing.Size(75, 75);
            this.btnCikis.TabIndex = 3;
            this.btnCikis.Text = "ÇIKIŞ";
            this.btnCikis.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCikis.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCikis.UseVisualStyleBackColor = false;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // btnSeansListele
            // 
            this.btnSeansListele.BackColor = System.Drawing.Color.Cyan;
            this.btnSeansListele.ImageIndex = 5;
            this.btnSeansListele.ImageList = this.ımageList1;
            this.btnSeansListele.Location = new System.Drawing.Point(276, 13);
            this.btnSeansListele.Name = "btnSeansListele";
            this.btnSeansListele.Size = new System.Drawing.Size(75, 75);
            this.btnSeansListele.TabIndex = 4;
            this.btnSeansListele.Text = "SEANS LİSTELE";
            this.btnSeansListele.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSeansListele.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSeansListele.UseVisualStyleBackColor = false;
            this.btnSeansListele.Click += new System.EventHandler(this.btnSeansListele_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Location = new System.Drawing.Point(33, 109);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(317, 270);
            this.panel2.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(369, 138);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(174, 188);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(33, 395);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(755, 43);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(645, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "BOŞ KOLTUKLAR";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "DOLU KOLTUKLAR";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(422, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "FİLM AFİŞİ";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Green;
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.txtsoyad);
            this.groupBox2.Controls.Add(this.txtad);
            this.groupBox2.Controls.Add(this.txtkltkno);
            this.groupBox2.Controls.Add(this.cmbucret);
            this.groupBox2.Controls.Add(this.cmbseans);
            this.groupBox2.Controls.Add(this.cmbtarih);
            this.groupBox2.Controls.Add(this.cmbsalonadi);
            this.groupBox2.Controls.Add(this.cmbfilmadi);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.groupBox2.Location = new System.Drawing.Point(549, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 263);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bilet Satış";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(73, 231);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 23);
            this.button2.TabIndex = 16;
            this.button2.Text = "Bilet Sat";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtsoyad
            // 
            this.txtsoyad.Location = new System.Drawing.Point(73, 177);
            this.txtsoyad.Name = "txtsoyad";
            this.txtsoyad.Size = new System.Drawing.Size(121, 20);
            this.txtsoyad.TabIndex = 15;
            // 
            // txtad
            // 
            this.txtad.Location = new System.Drawing.Point(73, 151);
            this.txtad.Name = "txtad";
            this.txtad.Size = new System.Drawing.Size(121, 20);
            this.txtad.TabIndex = 14;
            // 
            // txtkltkno
            // 
            this.txtkltkno.Enabled = false;
            this.txtkltkno.Location = new System.Drawing.Point(73, 125);
            this.txtkltkno.Name = "txtkltkno";
            this.txtkltkno.Size = new System.Drawing.Size(121, 20);
            this.txtkltkno.TabIndex = 13;
            // 
            // cmbucret
            // 
            this.cmbucret.FormattingEnabled = true;
            this.cmbucret.Location = new System.Drawing.Point(73, 203);
            this.cmbucret.Name = "cmbucret";
            this.cmbucret.Size = new System.Drawing.Size(121, 21);
            this.cmbucret.TabIndex = 12;
            // 
            // cmbseans
            // 
            this.cmbseans.FormattingEnabled = true;
            this.cmbseans.Location = new System.Drawing.Point(73, 98);
            this.cmbseans.Name = "cmbseans";
            this.cmbseans.Size = new System.Drawing.Size(121, 21);
            this.cmbseans.TabIndex = 11;
            this.cmbseans.SelectedIndexChanged += new System.EventHandler(this.cmbseans_SelectedIndexChanged);
            // 
            // cmbtarih
            // 
            this.cmbtarih.FormattingEnabled = true;
            this.cmbtarih.Location = new System.Drawing.Point(73, 71);
            this.cmbtarih.Name = "cmbtarih";
            this.cmbtarih.Size = new System.Drawing.Size(121, 21);
            this.cmbtarih.TabIndex = 10;
            this.cmbtarih.SelectedIndexChanged += new System.EventHandler(this.cmbtarih_SelectedIndexChanged);
            // 
            // cmbsalonadi
            // 
            this.cmbsalonadi.FormattingEnabled = true;
            this.cmbsalonadi.Location = new System.Drawing.Point(73, 44);
            this.cmbsalonadi.Name = "cmbsalonadi";
            this.cmbsalonadi.Size = new System.Drawing.Size(121, 21);
            this.cmbsalonadi.TabIndex = 9;
            this.cmbsalonadi.SelectedIndexChanged += new System.EventHandler(this.cmbsalonadi_SelectedIndexChanged);
            // 
            // cmbfilmadi
            // 
            this.cmbfilmadi.FormattingEnabled = true;
            this.cmbfilmadi.Location = new System.Drawing.Point(73, 17);
            this.cmbfilmadi.Name = "cmbfilmadi";
            this.cmbfilmadi.Size = new System.Drawing.Size(121, 21);
            this.cmbfilmadi.TabIndex = 8;
            this.cmbfilmadi.SelectedIndexChanged += new System.EventHandler(this.cmbfilmadi_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 206);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(33, 13);
            this.label11.TabIndex = 7;
            this.label11.Text = "Ücret";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 180);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 13);
            this.label10.TabIndex = 6;
            this.label10.Text = "Soyad";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 154);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(20, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "Ad";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 128);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Koltuk No";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Film Seansı";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Film Tarihi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Salon Adı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Film Adı";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.cmbiptal);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.ForeColor = System.Drawing.Color.Red;
            this.groupBox3.Location = new System.Drawing.Point(549, 305);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 83);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Bilet İptal";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(73, 54);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Bilet İptal";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmbiptal
            // 
            this.cmbiptal.FormattingEnabled = true;
            this.cmbiptal.Location = new System.Drawing.Point(73, 27);
            this.cmbiptal.Name = "cmbiptal";
            this.cmbiptal.Size = new System.Drawing.Size(121, 21);
            this.cmbiptal.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 30);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(54, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "Koltuk No";
            // 
            // btnSatislar
            // 
            this.btnSatislar.BackColor = System.Drawing.Color.Cyan;
            this.btnSatislar.ImageIndex = 8;
            this.btnSatislar.ImageList = this.ımageList1;
            this.btnSatislar.Location = new System.Drawing.Point(357, 13);
            this.btnSatislar.Name = "btnSatislar";
            this.btnSatislar.Size = new System.Drawing.Size(75, 75);
            this.btnSatislar.TabIndex = 11;
            this.btnSatislar.Text = "SATIŞLAR";
            this.btnSatislar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSatislar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSatislar.UseVisualStyleBackColor = false;
            this.btnSatislar.Click += new System.EventHandler(this.btnSatislar_Click);
            // 
            // frmAnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Sinema_Otomasyonu.Properties.Resources.thumbs_b_c_0a0614ec64694cf784afdf4828dd74e2;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSatislar);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnSeansListele);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnSeansEkle);
            this.Controls.Add(this.c);
            this.Controls.Add(this.btnSalonEkle);
            this.Name = "frmAnaSayfa";
            this.Text = "Anasayfa";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalonEkle;
        private System.Windows.Forms.Button c;
        private System.Windows.Forms.Button btnSeansEkle;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button btnSeansListele;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtsoyad;
        private System.Windows.Forms.TextBox txtad;
        private System.Windows.Forms.TextBox txtkltkno;
        private System.Windows.Forms.ComboBox cmbucret;
        private System.Windows.Forms.ComboBox cmbseans;
        private System.Windows.Forms.ComboBox cmbtarih;
        private System.Windows.Forms.ComboBox cmbsalonadi;
        private System.Windows.Forms.ComboBox cmbfilmadi;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cmbiptal;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Button btnSatislar;
    }
}

