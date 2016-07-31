using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ZarzadzanieSerwisem.DAL;
using ZarzadzanieSerwisem.Models;

namespace ZarzadzanieSerwisem.Controllers
{
    public class UrzadzNaprController : Controller
    {
        private SerwisContext db = new SerwisContext();

        // GET: UrzadzNapr
        public ActionResult Index()
        {
            var urzadzNapr = db.UrzadzNapr.Include(u => u.PrzyjeteUrzadzenie).Include(u => u.Serwisant).Include(u => u.StatusNaprawy);
            return View(urzadzNapr.ToList());
        }

        // GET: UrzadzNapr/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UrzadzNapr urzadzNapr = db.UrzadzNapr.Find(id);
            if (urzadzNapr == null)
            {
                return HttpNotFound();
            }
            return View(urzadzNapr);
        }

        // GET: UrzadzNapr/Create
        public ActionResult Create()
        {
            ViewBag.PrzyjeteUrzadzenieId = new SelectList(db.PrzyjeteUrzadzenie, "PrzyjeteUrzadzenieId", "PrzyjeteUrzadzenieTytul");
            ViewBag.SerwisantId = new SelectList(db.Serwisant, "SerwisantId", "SerwisantImie");
            ViewBag.StatusNaprawyId = new SelectList(db.StatusNaprawy, "StatusNaprawyId", "StatusNaprawyNazwa");
            return View();
        }

        // POST: UrzadzNapr/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "UrzadzNaprId,PrzyjeteUrzadzenieId,UrzadzNaprDataWpisu,StatusNaprawyId,SerwisantId,Usterka1Id,Usterka2Id,UrzadzNaprPozycja1,UrzadzNaprPozycja2,UrzadzNaprPozycja3,UrzadzNaprPozycja4,UrzadzNaprBrakujacaCzesc1,UrzadzNaprBrakujacaCzesc2")] UrzadzNapr urzadzNapr)
        {
            if (ModelState.IsValid)
            {
                db.UrzadzNapr.Add(urzadzNapr);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.PrzyjeteUrzadzenieId = new SelectList(db.PrzyjeteUrzadzenie, "PrzyjeteUrzadzenieId", "PrzyjeteUrzadzenieTytul", urzadzNapr.PrzyjeteUrzadzenieId);
            ViewBag.SerwisantId = new SelectList(db.Serwisant, "SerwisantId", "SerwisantImie", urzadzNapr.SerwisantId);
            ViewBag.StatusNaprawyId = new SelectList(db.StatusNaprawy, "StatusNaprawyId", "StatusNaprawyNazwa", urzadzNapr.StatusNaprawyId);
            return View(urzadzNapr);
        }

        // GET: UrzadzNapr/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UrzadzNapr urzadzNapr = db.UrzadzNapr.Find(id);
            if (urzadzNapr == null)
            {
                return HttpNotFound();
            }
            ViewBag.PrzyjeteUrzadzenieId = new SelectList(db.PrzyjeteUrzadzenie, "PrzyjeteUrzadzenieId", "PrzyjeteUrzadzenieTytul", urzadzNapr.PrzyjeteUrzadzenieId);
            ViewBag.SerwisantId = new SelectList(db.Serwisant, "SerwisantId", "SerwisantImie", urzadzNapr.SerwisantId);
            ViewBag.StatusNaprawyId = new SelectList(db.StatusNaprawy, "StatusNaprawyId", "StatusNaprawyNazwa", urzadzNapr.StatusNaprawyId);
            return View(urzadzNapr);
        }

        // POST: UrzadzNapr/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "UrzadzNaprId,PrzyjeteUrzadzenieId,UrzadzNaprDataWpisu,StatusNaprawyId,SerwisantId,Usterka1Id,Usterka2Id,UrzadzNaprPozycja1,UrzadzNaprPozycja2,UrzadzNaprPozycja3,UrzadzNaprPozycja4,UrzadzNaprBrakujacaCzesc1,UrzadzNaprBrakujacaCzesc2")] UrzadzNapr urzadzNapr)
        {
            if (ModelState.IsValid)
            {
                db.Entry(urzadzNapr).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.PrzyjeteUrzadzenieId = new SelectList(db.PrzyjeteUrzadzenie, "PrzyjeteUrzadzenieId", "PrzyjeteUrzadzenieTytul", urzadzNapr.PrzyjeteUrzadzenieId);
            ViewBag.SerwisantId = new SelectList(db.Serwisant, "SerwisantId", "SerwisantImie", urzadzNapr.SerwisantId);
            ViewBag.StatusNaprawyId = new SelectList(db.StatusNaprawy, "StatusNaprawyId", "StatusNaprawyNazwa", urzadzNapr.StatusNaprawyId);
            return View(urzadzNapr);
        }

        // GET: UrzadzNapr/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UrzadzNapr urzadzNapr = db.UrzadzNapr.Find(id);
            if (urzadzNapr == null)
            {
                return HttpNotFound();
            }
            return View(urzadzNapr);
        }

        // POST: UrzadzNapr/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            UrzadzNapr urzadzNapr = db.UrzadzNapr.Find(id);
            db.UrzadzNapr.Remove(urzadzNapr);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
