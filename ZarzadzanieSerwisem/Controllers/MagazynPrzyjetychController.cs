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
    public class MagazynPrzyjetychController : Controller
    {
        private SerwisContext db = new SerwisContext();

        // GET: MagazynPrzyjetych
        public ActionResult Index()
        {
            var przyjeteUrzadzenie = db.PrzyjeteUrzadzenie.Include(p => p.Magazynier).Include(p => p.Serwisant).Include(p => p.StatusMagazynowy).Include(p => p.StatusNaprawy);
            return View(przyjeteUrzadzenie.ToList());
        }

        // GET: MagazynPrzyjetych/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PrzyjeteUrzadzenie przyjeteUrzadzenie = db.PrzyjeteUrzadzenie.Find(id);
            if (przyjeteUrzadzenie == null)
            {
                return HttpNotFound();
            }
            return View(przyjeteUrzadzenie);
        }

        // GET: MagazynPrzyjetych/Create
        public ActionResult Create()
        {
            ViewBag.MagazynierId = new SelectList(db.Magazynier, "MagazynierId", "MagazynierPelnaNazwa");
            ViewBag.SerwisantId = new SelectList(db.Serwisant, "SerwisantId", "SerwisantPelnaNazwa");
            ViewBag.StatusMagazynowyId = new SelectList(db.StatusMagazynowy, "StatusMagazynowyId", "StatusMagazynowyNazwa");
            ViewBag.StatusNaprawyId = new SelectList(db.StatusNaprawy, "StatusNaprawyId", "StatusNaprawyNazwa");
            return View();
        }

        // POST: MagazynPrzyjetych/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "PrzyjeteUrzadzenieId,PrzyjeteUrzadzenieTytul,PrzyjeteUrzadzenieInformacje,PrzyjeteUrzadzenieNazwaKlienta,PrzyjeteUrzadzenieTelKontaktowy,PrzyjeteUrzadzenieEmail,PrzyjeteUrzadzenieDataPrzyjecia,MagazynierId,StatusMagazynowyId,StatusNaprawyId,PrzyjeteUrzadzenieWycena,SerwisantId")] PrzyjeteUrzadzenie przyjeteUrzadzenie)
        {
            if (ModelState.IsValid)
            {
                db.PrzyjeteUrzadzenie.Add(przyjeteUrzadzenie);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.MagazynierId = new SelectList(db.Magazynier, "MagazynierId", "MagazynierPelnaNazwa", przyjeteUrzadzenie.MagazynierId);
            ViewBag.SerwisantId = new SelectList(db.Serwisant, "SerwisantId", "SerwisantPelnaNazwa", przyjeteUrzadzenie.SerwisantId);
            ViewBag.StatusMagazynowyId = new SelectList(db.StatusMagazynowy, "StatusMagazynowyId", "StatusMagazynowyNazwa", przyjeteUrzadzenie.StatusMagazynowyId);
            ViewBag.StatusNaprawyId = new SelectList(db.StatusNaprawy, "StatusNaprawyId", "StatusNaprawyNazwa", przyjeteUrzadzenie.StatusNaprawyId);
            return View(przyjeteUrzadzenie);
        }

        // GET: MagazynPrzyjetych/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PrzyjeteUrzadzenie przyjeteUrzadzenie = db.PrzyjeteUrzadzenie.Find(id);
            if (przyjeteUrzadzenie == null)
            {
                return HttpNotFound();
            }
            ViewBag.MagazynierId = new SelectList(db.Magazynier, "MagazynierId", "MagazynierImie", przyjeteUrzadzenie.MagazynierId);
            ViewBag.SerwisantId = new SelectList(db.Serwisant, "SerwisantId", "SerwisantImie", przyjeteUrzadzenie.SerwisantId);
            ViewBag.StatusMagazynowyId = new SelectList(db.StatusMagazynowy, "StatusMagazynowyId", "StatusMagazynowyNazwa", przyjeteUrzadzenie.StatusMagazynowyId);
            ViewBag.StatusNaprawyId = new SelectList(db.StatusNaprawy, "StatusNaprawyId", "StatusNaprawyNazwa", przyjeteUrzadzenie.StatusNaprawyId);
            return View(przyjeteUrzadzenie);
        }

        // POST: MagazynPrzyjetych/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "PrzyjeteUrzadzenieId,PrzyjeteUrzadzenieTytul,PrzyjeteUrzadzenieInformacje,PrzyjeteUrzadzenieNazwaKlienta,PrzyjeteUrzadzenieTelKontaktowy,PrzyjeteUrzadzenieEmail,PrzyjeteUrzadzenieDataPrzyjecia,MagazynierId,StatusMagazynowyId,StatusNaprawyId,PrzyjeteUrzadzenieWycena,SerwisantId")] PrzyjeteUrzadzenie przyjeteUrzadzenie)
        {
            if (ModelState.IsValid)
            {
                db.Entry(przyjeteUrzadzenie).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.MagazynierId = new SelectList(db.Magazynier, "MagazynierId", "MagazynierImie", przyjeteUrzadzenie.MagazynierId);
            ViewBag.SerwisantId = new SelectList(db.Serwisant, "SerwisantId", "SerwisantImie", przyjeteUrzadzenie.SerwisantId);
            ViewBag.StatusMagazynowyId = new SelectList(db.StatusMagazynowy, "StatusMagazynowyId", "StatusMagazynowyNazwa", przyjeteUrzadzenie.StatusMagazynowyId);
            ViewBag.StatusNaprawyId = new SelectList(db.StatusNaprawy, "StatusNaprawyId", "StatusNaprawyNazwa", przyjeteUrzadzenie.StatusNaprawyId);
            return View(przyjeteUrzadzenie);
        }

        // GET: MagazynPrzyjetych/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PrzyjeteUrzadzenie przyjeteUrzadzenie = db.PrzyjeteUrzadzenie.Find(id);
            if (przyjeteUrzadzenie == null)
            {
                return HttpNotFound();
            }
            return View(przyjeteUrzadzenie);
        }

        // POST: MagazynPrzyjetych/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PrzyjeteUrzadzenie przyjeteUrzadzenie = db.PrzyjeteUrzadzenie.Find(id);
            db.PrzyjeteUrzadzenie.Remove(przyjeteUrzadzenie);
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
