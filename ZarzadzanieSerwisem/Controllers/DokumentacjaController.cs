using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ZarzadzanieSerwisem.DAL;
using System.Data.Entity;
using System.Net;
using ZarzadzanieSerwisem.Models;
using System.IO;

namespace ZarzadzanieSerwisem.Controllers
{
    public class DokumentacjaController : Controller
    {
        private SerwisContext db = new SerwisContext();
        // GET: Dokumentacja
        public ActionResult Index()
        {
            var Dokumenty = db.Kategoria;
            return View(Dokumenty.ToList());
        }

        public ActionResult Kategoria(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var zapytanie = db.Dokument.Where(b => b.KategoriaId == id).ToList();
            if (zapytanie == null)
            {
                return HttpNotFound();
            }
            return View(zapytanie);
        }

        public FileResult Download(string id)
        {
            return File(Server.MapPath("~/src/pdf/" + id + ".pdf"), System.Net.Mime.MediaTypeNames.Application.Pdf, id);

        }
    }
}