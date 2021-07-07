using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Linq_Kullanimi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();



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

        private void btnSehirler_Click(object sender, EventArgs e)
        {
            string[] sehirler = {"İstanbul","Ankara","Adana","Diyarbakır","Hatay","Trabzon"};

            var result = from sehir in sehirler
                         where sehir != "İstanbul"
                         orderby sehir ascending
                         select sehir;

            lstSehirler.Items.Clear();

            foreach (var sehir in result)
            {
                lstSehirler.Items.Add(sehir);
            }

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            Listele();

            MusteriGetir();

        }

        private void MusteriGetir()
        {
            List<Orders> order = new List<Orders>();
            DataTable tablo = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select SipId,SipAdSoyad FROM orders", bgl.baglanti());
            da.Fill(tablo);

            order = tablo.AsEnumerable().Select(s => new Orders
            {
                SipId = s.Field<int>("SipId"),
                SipAdSoyad = s.Field<string>("SipAdSoyad")
            }
            ).ToList();

            cmbMusteri.DisplayMember = "SipId";

            cmbMusteri.ValueMember = "SipAdSoyad";
            cmbMusteri.DataSource = order;
        }

        private void Listele()
        {
            DataTable tablo = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT SipId,SipAdSoyad,SipTelNo,SipAdres,SipTutar FROM orders", bgl.baglanti());
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            List<Orders> order = new List<Orders>(); //bu bizim oluşturdugumuz sınıf

            DataTable tablo = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT SipId,SipAdSoyad,SipTelNo,SipAdres,SipTutar FROM orders", bgl.baglanti());
            da.Fill(tablo);
            order = tablo.AsEnumerable().Select(s => new Orders
            {
                SipId = s.Field<int>("SipId"),
                SipAdSoyad = s.Field<string>("SipAdSoyad"),
                SipTelNo = s.Field<string>("SipTelNo"),
                SipAdres = s.Field<string>("SipAdres"),
                SipTutar = s.Field<decimal>("SipTutar")
            }).Where(x => x.SipAdres == "İstanbul / Kartal").Take(5).ToList();  // 5 tanesini getir dedik
                                                                                //order.Where(x => x.SipAdres == "f").Take(5).Skip(2).ToList();
                                                                                //sıralanabilir 
                                                                                //method küp mor
                                                                                //yeni nesne oluşturduk
                                                                                //s  ilk indis
                                                                                //s.field aradıgımız değer veri tabanından gelen tipi ve adı string (adı)
                                                                                //value cekiyoruz parantez içinde 
            dataGridView1.DataSource = order;
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            IList<Product> products = new List<Product>
            {
                new Product
                {
                    Id = 1,
                    Name = "Süt",
                    CategoryName = "Gıda",
                    Price = 3
                },
                new Product
                {
                    Id = 2,
                    Name = "Elma",
                    CategoryName = "Meyve",
                    Price = 4
                },
                new Product
                {
                    Id = 3,
                    Name = "Üzüm",
                    CategoryName = "Meyve",
                    Price = 7
                },
                new Product
                {
                    Id = 4,
                    Name = "Kiraz",
                    CategoryName = "Meyve",
                    Price = 9
                }
            };

            var result = from p in products
                         where p.CategoryName == "Meyve"
                         select p;

            foreach (var pro in result)
            {
                lstProduct.Items.Add(" Ürünün Idsi: " + pro.Id + " Ürün Adı: " + pro.Name + " Ürünün Kategorisi " + pro.CategoryName +" Ürün Fiyatı: " + pro.Price);
            }












        }

        private void cmbMusteri_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblSipId.Text = cmbMusteri.SelectedIndex.ToString();
            lblSipAdSoyad.Text = cmbMusteri.SelectedValue.ToString();
        }
    }
}
