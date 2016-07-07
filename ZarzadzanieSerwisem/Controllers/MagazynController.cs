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
    public class MagazynController : Controller
    {
        private SerwisContext db = new SerwisContext();

        // GET: Magazyn
        public ActionResult Index()
        {
            var serwisowane = db.Serwisowane.Include(s => s.Magazynier);
            return View(serwisowane.ToList());
        }

        // GET: Magazyn/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PrzyjeteUrzadzenie serwisowane = db.Serwisowane.Find(id);
            if (serwisowane == null)
            {
                return HttpNotFound();
            }
            return View(serwisowane);
        }

        // GET: Magazyn/Create
        public ActionResult Create()
        {
            ViewBag.MagazynierId = new SelectList(db.Magazynier, "MagazynierId", "MagazynierImie");
            return View();
        }

        // POST: Magazyn/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "SerwisowaneId,SerwisowaneTytul,SerwisowaneTresc,SerwisowaneNazwaKlienta,DataPrzyjecia,SerwisowaneWycena,MagazynierId")] PrzyjeteUrzadzenie serwisowane)
        {
            if (ModelState.IsValid)
            {
                db.Serwisowane.Add(serwisowane);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.MagazynierId = new SelectList(db.Magazynier, "MagazynierId", "MagazynierImie", serwisowane.MagazynierId);
            return View(serwisowane);
        }

        // GET: Magazyn/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PrzyjeteUrzadzenie serwisowane = db.Serwisowane.Find(id);
            if (serwisowane == null)
            {
                return HttpNotFound();
            }
            ViewBag.MagazynierId = new SelectList(db.Magazynier, "MagazynierId", "MagazynierImie", serwisowane.MagazynierId);
            return View(serwisowane);
        }

        // POST: Magazyn/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "SerwisowaneId,SerwisowaneTytul,SerwisowaneTresc,SerwisowaneNazwaKlienta,DataPrzyjecia,SerwisowaneWycena,MagazynierId")] PrzyjeteUrzadzenie serwisowane)
        {
            if (ModelState.IsValid)
            {
                db.Entry(serwisowane).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.MagazynierId = new SelectList(db.Magazynier, "MagazynierId", "MagazynierImie", serwisowane.MagazynierId);
            return View(serwisowane);
        }

        // GET: Magazyn/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PrzyjeteUrzadzenie serwisowane = db.Serwisowane.Find(id);
            if (serwisowane == null)
            {
                return HttpNotFound();
            }
            return View(serwisowane);
        }

        // POST: Magazyn/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PrzyjeteUrzadzenie serwisowane = db.Serwisowane.Find(id);
            db.Serwisowane.Remove(serwisowane);
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
