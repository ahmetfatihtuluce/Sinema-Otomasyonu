namespace Sinema_Otomasyonu
{
    partial class frmFilmEkle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFilmEkle));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_FilmAdi = new System.Windows.Forms.TextBox();
            this.txt_yonetmen = new System.Windows.Forms.TextBox();
            this.txt_sure = new System.Windows.Forms.TextBox();
            this.txt_yil = new System.Windows.Forms.TextBox();
            this.cmbbox_tur = new System.Windows.Forms.ComboBox();
            this.btn_filmEkle = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btn_AfisSec = new System.Windows.Forms.Button();
            this.pct_afis = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.pct_afis)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Film Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Yönetmen";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Film Türü";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(85, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Süre";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(62, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Yapım Yılı";
            // 
            // txt_FilmAdi
            // 
            this.txt_FilmAdi.Location = new System.Drawing.Point(166, 50);
            this.txt_FilmAdi.Name = "txt_FilmAdi";
            this.txt_FilmAdi.Size = new System.Drawing.Size(121, 20);
            this.txt_FilmAdi.TabIndex = 5;
            // 
            // txt_yonetmen
            // 
            this.txt_yonetmen.Location = new System.Drawing.Point(166, 75);
            this.txt_yonetmen.Name = "txt_yonetmen";
            this.txt_yonetmen.Size = new System.Drawing.Size(121, 20);
            this.txt_yonetmen.TabIndex = 6;
            // 
            // txt_sure
            // 
            this.txt_sure.Location = new System.Drawing.Point(166, 126);
            this.txt_sure.Name = "txt_sure";
            this.txt_sure.Size = new System.Drawing.Size(121, 20);
            this.txt_sure.TabIndex = 7;
            // 
            // txt_yil
            // 
            this.txt_yil.Location = new System.Drawing.Point(166, 152);
            this.txt_yil.Name = "txt_yil";
            this.txt_yil.Size = new System.Drawing.Size(121, 20);
            this.txt_yil.TabIndex = 8;
            // 
            // cmbbox_tur
            // 
            this.cmbbox_tur.FormattingEnabled = true;
            this.cmbbox_tur.Location = new System.Drawing.Point(166, 100);
            this.cmbbox_tur.Name = "cmbbox_tur";
            this.cmbbox_tur.Size = new System.Drawing.Size(121, 21);
            this.cmbbox_tur.TabIndex = 9;
            // 
            // btn_filmEkle
            // 
            this.btn_filmEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_filmEkle.ImageIndex = 0;
            this.btn_filmEkle.ImageList = this.ımageList1;
            this.btn_filmEkle.Location = new System.Drawing.Point(166, 205);
            this.btn_filmEkle.Name = "btn_filmEkle";
            this.btn_filmEkle.Size = new System.Drawing.Size(121, 23);
            this.btn_filmEkle.TabIndex = 10;
            this.btn_filmEkle.Text = "Film Ekle";
            this.btn_filmEkle.UseVisualStyleBackColor = true;
            this.btn_filmEkle.Click += new System.EventHandler(this.btn_filmEkle_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "img2.jpg");
            this.ımageList1.Images.SetKeyName(1, "thumbs_b_c_0a0614ec64694cf784afdf4828dd74e2.jpg");
            // 
            // btn_AfisSec
            // 
            this.btn_AfisSec.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_AfisSec.ImageIndex = 1;
            this.btn_AfisSec.ImageList = this.ımageList1;
            this.btn_AfisSec.Location = new System.Drawing.Point(293, 205);
            this.btn_AfisSec.Name = "btn_AfisSec";
            this.btn_AfisSec.Size = new System.Drawing.Size(100, 23);
            this.btn_AfisSec.TabIndex = 11;
            this.btn_AfisSec.Text = "Afiş Seç";
            this.btn_AfisSec.UseVisualStyleBackColor = true;
            this.btn_AfisSec.Click += new System.EventHandler(this.btn_AfisSec_Click);
            // 
            // pct_afis
            // 
            this.pct_afis.BackColor = System.Drawing.Color.Transparent;
            this.pct_afis.Location = new System.Drawing.Point(293, 50);
            this.pct_afis.Name = "pct_afis";
            this.pct_afis.Size = new System.Drawing.Size(100, 122);
            this.pct_afis.TabIndex = 12;
            this.pct_afis.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(83, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Tarih";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(166, 179);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(227, 20);
            this.dateTimePicker1.TabIndex = 14;
            // 
            // frmFilmEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BackgroundImage = global::Sinema_Otomasyonu.Properties.Resources.Seans;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(405, 257);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pct_afis);
            this.Controls.Add(this.btn_AfisSec);
            this.Controls.Add(this.btn_filmEkle);
            this.Controls.Add(this.cmbbox_tur);
            this.Controls.Add(this.txt_yil);
            this.Controls.Add(this.txt_sure);
            this.Controls.Add(this.txt_yonetmen);
            this.Controls.Add(this.txt_FilmAdi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "frmFilmEkle";
            this.Text = "Film Ekle";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmFilmEkle_FormClosing);
            this.Load += new System.EventHandler(this.frmFilmEkle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pct_afis)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_FilmAdi;
        private System.Windows.Forms.TextBox txt_yonetmen;
        private System.Windows.Forms.TextBox txt_sure;
        private System.Windows.Forms.TextBox txt_yil;
        private System.Windows.Forms.ComboBox cmbbox_tur;
        private System.Windows.Forms.Button btn_filmEkle;
        private System.Windows.Forms.Button btn_AfisSec;
        private System.Windows.Forms.PictureBox pct_afis;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}