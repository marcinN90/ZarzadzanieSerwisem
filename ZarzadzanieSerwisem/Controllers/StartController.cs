using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ZarzadzanieSerwisem.Models;

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

        [HttpGet]
        public ActionResult Kontakt()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Kontakt(EmailForm emailForm)
        {
            if (ModelState.IsValid)
            {
                //do zrobienia wyślij maila do admina
                return View("WyslanoEmail", emailForm);
            }
            else
            {
                return View();
            }
           
        }

    }
}