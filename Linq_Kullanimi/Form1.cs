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

        private void btnSayilar_Click(object sender, EventArgs e)
        {
            int[] sayilar = { 55, 64, 21, 35, 99, 28, 65, 27, 62, 100 };

            var kucuk = //küçük adında bir değişken oluşturduk
                from s in sayilar //sayilar dizisini s adı verdik as gibi düşün 
                where s < 50 // 50 den küçükler
                orderby s ascending //sıralama yapar
                select s; //tablo adı

            // var kucukSayilar2 = sayilar.Where(x => x < 5
            // bu şekildede yazılır

            MessageBox.Show("50 den küçük sayılar");

            lstSayilar.Items.Clear();
            foreach (var k in kucuk)
            {
                lstSayilar.Items.Add(k);
            }


        }

        private void btnTekSayilar_Click(object sender, EventArgs e)
        {
            int[] teksayilar = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 90, 95, 99 };
            
            var result = //IEnumerable<int>  bunu da kullanabilirz
                from t in teksayilar
                where t % 2 == 1
                select t;

            //var tekler = liste.Where(sayi => sayi % 2 == 1);

            lstTekSayilar.Items.Clear();
            foreach (var tek in result)
            {
                lstTekSayilar.Items.Add(tek);
            }

        }
    }
}
