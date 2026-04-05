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
    }
}
