using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ilkproje.Models;

namespace ilkproje.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult test()
        {
            ViewBag.Message = "Your test page.";
            ViewBag.yazarA = "orhan pamuk";
            ViewBag.yazarBi = "Mimarlık bölümünü bırakan Pamuk, İstanbul Üniversitesi'nde Gazetecilik okudu. 23 yaşından sonra yazar olmaya karar verdi ve tüm uğraşlarını bir kenara koydu, eve kapanıp kendini yazmaya verdi. İlk romanı “Cevdet Bey ve Oğulları” 1982 tarihinde yayımlandı.";
            ViewBag.tarih = DateTime.Now;
            yazar yazar = new yazar()
            {
                ID = 1,
                yazarAdi = "orhan",
                yazarSoyad = "pamuk",
                Biyografi = "Mimarlık bölümünü bırakan Pamuk, İstanbul Üniversitesi'nde Gazetecilik okudu. 23 yaşından sonra yazar olmaya karar verdi ve tüm uğraşlarını bir kenara koydu, eve kapanıp kendini yazmaya verdi. İlk romanı “Cevdet Bey ve Oğulları” 1982 tarihinde yayımlandı.",
                dogumTarihi = DateTime.Parse("7 Haziran 1952")
            };
            return View(yazar);
        }
       
    }
}