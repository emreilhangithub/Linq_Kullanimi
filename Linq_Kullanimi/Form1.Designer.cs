
namespace Linq_Kullanimi
{
    partial class Form1
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
            this.lstUlkeler = new System.Windows.Forms.ListBox();
            this.btnUlkeEkle = new System.Windows.Forms.Button();
            this.lstSayilar = new System.Windows.Forms.ListBox();
            this.btnSayilar = new System.Windows.Forms.Button();
            this.btnTekSayilar = new System.Windows.Forms.Button();
            this.lstTekSayilar = new System.Windows.Forms.ListBox();
            this.lstSehirler = new System.Windows.Forms.ListBox();
            this.btnSehirler = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnListele = new System.Windows.Forms.Button();
            this.lstProduct = new System.Windows.Forms.ListBox();
            this.btnProduct = new System.Windows.Forms.Button();
            this.cmbMusteri = new System.Windows.Forms.ComboBox();
            this.lblSipId = new System.Windows.Forms.Label();
            this.lblSipAdSoyad = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lstUlkeler
            // 
            this.lstUlkeler.FormattingEnabled = true;
            this.lstUlkeler.Location = new System.Drawing.Point(36, 12);
            this.lstUlkeler.Name = "lstUlkeler";
            this.lstUlkeler.Size = new System.Drawing.Size(120, 95);
            this.lstUlkeler.TabIndex = 0;
            // 
            // btnUlkeEkle
            // 
            this.btnUlkeEkle.Location = new System.Drawing.Point(81, 113);
            this.btnUlkeEkle.Name = "btnUlkeEkle";
            this.btnUlkeEkle.Size = new System.Drawing.Size(75, 23);
            this.btnUlkeEkle.TabIndex = 1;
            this.btnUlkeEkle.Text = "Ülke Ekle";
            this.btnUlkeEkle.UseVisualStyleBackColor = true;
            this.btnUlkeEkle.Click += new System.EventHandler(this.btnUlkeEkle_Click);
            // 
            // lstSayilar
            // 
            this.lstSayilar.FormattingEnabled = true;
            this.lstSayilar.Location = new System.Drawing.Point(36, 142);
            this.lstSayilar.Name = "lstSayilar";
            this.lstSayilar.Size = new System.Drawing.Size(120, 95);
            this.lstSayilar.TabIndex = 2;
            // 
            // btnSayilar
            // 
            this.btnSayilar.Location = new System.Drawing.Point(81, 243);
            this.btnSayilar.Name = "btnSayilar";
            this.btnSayilar.Size = new System.Drawing.Size(75, 23);
            this.btnSayilar.TabIndex = 3;
            this.btnSayilar.Text = "Sayılar";
            this.btnSayilar.UseVisualStyleBackColor = true;
            this.btnSayilar.Click += new System.EventHandler(this.btnSayilar_Click);
            // 
            // btnTekSayilar
            // 
            this.btnTekSayilar.Location = new System.Drawing.Point(81, 395);
            this.btnTekSayilar.Name = "btnTekSayilar";
            this.btnTekSayilar.Size = new System.Drawing.Size(75, 23);
            this.btnTekSayilar.TabIndex = 5;
            this.btnTekSayilar.Text = "Tek Sayılar";
            this.btnTekSayilar.UseVisualStyleBackColor = true;
            // 
            // lstTekSayilar
            // 
            this.lstTekSayilar.FormattingEnabled = true;
            this.lstTekSayilar.Location = new System.Drawing.Point(36, 294);
            this.lstTekSayilar.Name = "lstTekSayilar";
            this.lstTekSayilar.Size = new System.Drawing.Size(120, 95);
            this.lstTekSayilar.TabIndex = 4;
            // 
            // lstSehirler
            // 
            this.lstSehirler.FormattingEnabled = true;
            this.lstSehirler.Location = new System.Drawing.Point(187, 12);
            this.lstSehirler.Name = "lstSehirler";
            this.lstSehirler.Size = new System.Drawing.Size(120, 95);
            this.lstSehirler.TabIndex = 6;
            // 
            // btnSehirler
            // 
            this.btnSehirler.Location = new System.Drawing.Point(232, 113);
            this.btnSehirler.Name = "btnSehirler";
            this.btnSehirler.Size = new System.Drawing.Size(75, 23);
            this.btnSehirler.TabIndex = 7;
            this.btnSehirler.Text = "Sehirler";
            this.btnSehirler.UseVisualStyleBackColor = true;
            this.btnSehirler.Click += new System.EventHandler(this.btnSehirler_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(187, 142);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(375, 117);
            this.dataGridView1.TabIndex = 8;
            // 
            // btnListele
            // 
            this.btnListele.Location = new System.Drawing.Point(187, 265);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(75, 23);
            this.btnListele.TabIndex = 9;
            this.btnListele.Text = "Listele";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // lstProduct
            // 
            this.lstProduct.FormattingEnabled = true;
            this.lstProduct.HorizontalScrollbar = true;
            this.lstProduct.Location = new System.Drawing.Point(187, 294);
            this.lstProduct.Name = "lstProduct";
            this.lstProduct.Size = new System.Drawing.Size(195, 95);
            this.lstProduct.TabIndex = 10;
            // 
            // btnProduct
            // 
            this.btnProduct.Location = new System.Drawing.Point(187, 395);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Size = new System.Drawing.Size(75, 23);
            this.btnProduct.TabIndex = 11;
            this.btnProduct.Text = "Product";
            this.btnProduct.UseVisualStyleBackColor = true;
            this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click);
            // 
            // cmbMusteri
            // 
            this.cmbMusteri.FormattingEnabled = true;
            this.cmbMusteri.Location = new System.Drawing.Point(334, 12);
            this.cmbMusteri.Name = "cmbMusteri";
            this.cmbMusteri.Size = new System.Drawing.Size(121, 21);
            this.cmbMusteri.TabIndex = 12;
            this.cmbMusteri.SelectedIndexChanged += new System.EventHandler(this.cmbMusteri_SelectedIndexChanged);
            // 
            // lblSipId
            // 
            this.lblSipId.AutoSize = true;
            this.lblSipId.Location = new System.Drawing.Point(331, 36);
            this.lblSipId.Name = "lblSipId";
            this.lblSipId.Size = new System.Drawing.Size(16, 13);
            this.lblSipId.TabIndex = 13;
            this.lblSipId.Text = "Id";
            // 
            // lblSipAdSoyad
            // 
            this.lblSipAdSoyad.AutoSize = true;
            this.lblSipAdSoyad.Location = new System.Drawing.Point(331, 59);
            this.lblSipAdSoyad.Name = "lblSipAdSoyad";
            this.lblSipAdSoyad.Size = new System.Drawing.Size(53, 13);
            this.lblSipAdSoyad.TabIndex = 14;
            this.lblSipAdSoyad.Text = "Ad Soyad";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblSipAdSoyad);
            this.Controls.Add(this.lblSipId);
            this.Controls.Add(this.cmbMusteri);
            this.Controls.Add(this.btnProduct);
            this.Controls.Add(this.lstProduct);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnSehirler);
            this.Controls.Add(this.lstSehirler);
            this.Controls.Add(this.btnTekSayilar);
            this.Controls.Add(this.lstTekSayilar);
            this.Controls.Add(this.btnSayilar);
            this.Controls.Add(this.lstSayilar);
            this.Controls.Add(this.btnUlkeEkle);
            this.Controls.Add(this.lstUlkeler);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstUlkeler;
        private System.Windows.Forms.Button btnUlkeEkle;
        private System.Windows.Forms.ListBox lstSayilar;
        private System.Windows.Forms.Button btnSayilar;
        private System.Windows.Forms.Button btnTekSayilar;
        private System.Windows.Forms.ListBox lstTekSayilar;
        private System.Windows.Forms.ListBox lstSehirler;
        private System.Windows.Forms.Button btnSehirler;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.ListBox lstProduct;
        private System.Windows.Forms.Button btnProduct;
        private System.Windows.Forms.ComboBox cmbMusteri;
        private System.Windows.Forms.Label lblSipId;
        private System.Windows.Forms.Label lblSipAdSoyad;
    }
}

