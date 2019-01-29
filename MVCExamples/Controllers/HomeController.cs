using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCExamples.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Hakkimizda()
        {
            return View();
        }
        public ActionResult Iletisim()
        {
            return View();
        }


        public PartialViewResult UrunGetir()
        {
            List<string> urunListesi = new List<string>();
            urunListesi.Add("kalem");
            urunListesi.Add("silgi  ");
            urunListesi.Add("defter");
            return PartialView("~/Views/Home/_partialUrunGetir.cshtml", urunListesi);

        }
    }
}
