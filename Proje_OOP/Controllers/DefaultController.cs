using Microsoft.AspNetCore.Mvc;
using Proje_OOP.Örnekler;
using System.Security.Cryptography;

namespace Proje_OOP.Controllers
{
    public class DefaultController : Controller
    {
        //void İşlemler()
        //{
        //    Class1 c = new Class1();
        //    c.Topla();
        //}

        public void messages()
        {
            ViewBag.m1 = "Merhaba bu bir core projesi";
            ViewBag.m2 = "Merhaba proje çok iyi duruyor";
            ViewBag.m3 = "Merhaba hi hello bonjour";
        }

        int topla()
        {
            int s1 = 20;
            int s2 = 30;
            int sonuc = s1 + s2;
            return sonuc;
        }

        int Cevre()
        {
            int kısa = 10;
            int uzun = 20;
            int sonuc = 2 * (kısa + uzun);
            return sonuc;
        }

        string Cumle()
        {
            string c = "Atatürk";
            return c;
        }

        void MesajListesi(string p)
        {
            ViewBag.v = p;
        }

        void Kullanıcı(string kullaniciadi)
        {
            ViewBag.v = kullaniciadi;
        }

        int Topla(int s1, int s2)
        {
            int sonuc = s1 + s2;
            return sonuc;
        }


        int Faktoriyel(int p)
        {
            int f = 1;
            for (int i = 1; i <= p; i++)
            {
                f = f * i;
            }
            return f;
        }

        public IActionResult Index()
        {
            messages();
            MesajListesi("Parametre ismi");
            Kullanıcı("üye");
            ViewBag.tp = Topla(20, 35);
            return View();
        }

        public IActionResult Urunler()
        {
            messages();
            ViewBag.t = topla();
            ViewBag.c = Cevre();
            Kullanıcı("member");
            ViewBag.faktor = Faktoriyel(6);
            return View();
        }

        public IActionResult Musteriler()
        {
            Kullanıcı("admin");
            ViewBag.d = Cumle();
            return View();
        }

        public IActionResult Deneme()
        {
            Sehirler sehirler = new Sehirler(); //Nesne türetildi

            sehirler.SehirAd = "Ankara";
            sehirler.SehirId = 1;
            sehirler.Nufus = 1000000;
            sehirler.Ulke = "Türkiye";
            sehirler.Renk1 = "Kırmızı";
            sehirler.Renk2 = "Beyaz";

            ViewBag.v1 = sehirler.SehirId;
            ViewBag.v2 = sehirler.Ulke;
            ViewBag.v3 = sehirler.SehirAd;
            ViewBag.v4 = sehirler.Nufus;
            ViewBag.v5 = sehirler.Renk1;
            ViewBag.v6 = sehirler.Renk2;

            sehirler.SehirAd = "Bakü";
            sehirler.SehirId = 2;
            sehirler.Nufus = 1000000;
            sehirler.Ulke = "Azerbeycan";
            sehirler.Renk1 = "Kırmızı";
            sehirler.Renk2 = "Turkuaz";
            sehirler.Renk3 = "Yeşil";

            ViewBag.z1 = sehirler.SehirId;
            ViewBag.z2 = sehirler.Ulke;
            ViewBag.z3 = sehirler.SehirAd;
            ViewBag.z4 = sehirler.Nufus;
            ViewBag.z5 = sehirler.Renk1;
            ViewBag.z6 = sehirler.Renk2;
            ViewBag.z7 = sehirler.Renk3;




            return View();
        }
    }
}
