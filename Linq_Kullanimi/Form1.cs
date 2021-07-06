using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Linq_Kullanimi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //List kullanımı
        private void btnUlkeEkle_Click(object sender, EventArgs e)
        {
            List<string> ulkeler = new List<string>();
            ulkeler.Add("Türkiye"); // Türkiye ülkesini ekle
            ekranaYaz(ulkeler);
            ulkeler.Add("Azerbaycan"); // Azerbaycan ülkesini ekle
            ekranaYaz(ulkeler);
            ulkeler.Add("Fransa"); // Fransa ülkesini ekle
            ekranaYaz(ulkeler);
            ulkeler.Add("Almanya"); // Almanya ülkesini ekle
            ekranaYaz(ulkeler);
            ulkeler.Add("Hollanda"); // Hollanda ülkesini ekle
            ekranaYaz(ulkeler);
            ulkeler.Add("İspanya"); // İspanya ülkesini ekle
            ekranaYaz(ulkeler);
            ulkeler.Add("Şili"); // Şili ülkesini ekle
            ekranaYaz(ulkeler);
            ulkeler.Remove("Almanya"); // Almanya ülkesini sil
            ekranaYaz(ulkeler);
            ulkeler.RemoveAt(4); // 4. indisteki ülkeyi sil
            ekranaYaz(ulkeler);
            ulkeler.Reverse(); // Tüm listeyi ters çevir
            ekranaYaz(ulkeler);

        }

        private void ekranaYaz(List<string> ulkeler)
        {
            lstUlkeler.Items.Clear(); //her cagırıldıgında yeni öge eklenmesini ekledik
            foreach (var ulke in ulkeler)
            {
                lstUlkeler.Items.Add(ulke);
            }
        }

   
    }
}
