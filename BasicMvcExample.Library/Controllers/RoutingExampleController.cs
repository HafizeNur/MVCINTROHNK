using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BasicMvcExample.Library.Controllers
{
    public class RoutingExampleController : Controller
    {
        // GET: RoutingExample
        public ActionResult Bolgeler()
        {
            ViewBag.bolge1 = "Akdeniz";
            ViewBag.bolge2 = "Karadeniz";
            ViewBag.bolge3 = "Ege";
            ViewBag.bolge4 = "Marmara";
            ViewBag.bolge5 = "İç Anadolu";
            ViewBag.bolge6 = "Günaydoğu Anadolu";
            ViewBag.bolge7 = "Doğu";

            return View();
        }
        [HttpPost]
        public ActionResult Bolge(string bolge)
        {
            if (bolge == "akdeniz")
            {
                ViewBag.bolge = "Akdeniz Bölge detayı";
            }
            else if (bolge == "karadeniz")
            {
                ViewBag.bolge = "Karadeniz Bölge detayı";
            }
            else if (bolge == "ege")
            {
                ViewBag.bolge = "Ege Bölge detayı";
            }
            else if (bolge == "marmara")
            {
                ViewBag.bolge = "Marmara Bölge detayı";
            }
            else if (bolge == "icanadolu")
            {
                ViewBag.bolge = "İç Anadolu Bölge detayı";
            }
            else if (bolge == "doguanadolu")
            {
                ViewBag.bolge = "Doğu Anadolu Bölge detayı";
            }
            else if (bolge == "guneydoguanadolu")
            {
                ViewBag.bolge = "Günaydoğu Anadolu Bölge detayı";
            }
            else
            {
                ViewBag.bolge = "Bölge seçmediniz!";
            }
            return View();
        }
    }
}