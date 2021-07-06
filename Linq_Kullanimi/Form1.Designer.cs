
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSayilar);
            this.Controls.Add(this.lstSayilar);
            this.Controls.Add(this.btnUlkeEkle);
            this.Controls.Add(this.lstUlkeler);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstUlkeler;
        private System.Windows.Forms.Button btnUlkeEkle;
        private System.Windows.Forms.ListBox lstSayilar;
        private System.Windows.Forms.Button btnSayilar;
    }
}

