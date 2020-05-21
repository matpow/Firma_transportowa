using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Firma_transportowa.Controllers
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
        public ActionResult Indextran()
        {
            return View();
        }
        public ActionResult Pusty()
        {
            return View();
        }
        public ActionResult Onas()
        {
            return View();
        }
        public ActionResult Oferta()
        {
            return View();
        }
        public ActionResult Cennik()
        {
            return View();
        }
        public ActionResult Rezerwacja()
        {
            return View();
        }
        public ActionResult Kontakt()
        {
            return View();
        }
        
    }
}