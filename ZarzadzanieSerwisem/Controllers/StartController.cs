using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ZarzadzanieSerwisem.Controllers
{
    public class StartController : Controller
    {
        //// get: start
        public ActionResult index()
        {
            return View();
           
        }

        public ActionResult oferta()
        {
            return View();
        }
        public ActionResult StatusNaprawy()
        {
            return View();
        }
        public ActionResult Kontakt()
        {
            return View();
        }

    }
}