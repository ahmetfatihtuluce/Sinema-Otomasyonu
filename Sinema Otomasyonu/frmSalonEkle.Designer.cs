namespace Sinema_Otomasyonu
{
    partial class frmSalonEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSalonEkle));
            this.label1 = new System.Windows.Forms.Label();
            this.txt_SalonAdi = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.ımageList2 = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Salon Adı";
            // 
            // txt_SalonAdi
            // 
            this.txt_SalonAdi.Location = new System.Drawing.Point(127, 23);
            this.txt_SalonAdi.Name = "txt_SalonAdi";
            this.txt_SalonAdi.Size = new System.Drawing.Size(100, 20);
            this.txt_SalonAdi.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.ImageIndex = 0;
            this.button1.ImageList = this.ımageList2;
            this.button1.Location = new System.Drawing.Point(127, 103);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 64);
            this.button1.TabIndex = 2;
            this.button1.Text = "Ekle";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ımageList2
            // 
            this.ımageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList2.ImageStream")));
            this.ımageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList2.Images.SetKeyName(0, "Salon1.png");
            // 
            // frmSalonEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Sinema_Otomasyonu.Properties.Resources.thumbs_b_c_0a0614ec64694cf784afdf4828dd74e2;
            this.ClientSize = new System.Drawing.Size(255, 179);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_SalonAdi);
            this.Controls.Add(this.label1);
            this.Name = "frmSalonEkle";
            this.Text = "Salon Ekleme";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmSalonEkle_FormClosing);
            this.Load += new System.EventHandler(this.frmSalonEkle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_SalonAdi;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ImageList ımageList2;
    }
}