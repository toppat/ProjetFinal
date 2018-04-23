using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ProjetFinal.DAL;
using ProjetFinal.Models;

namespace ProjetFinal.Controllers
{
    public class EcransController : Controller
    {
        private ProjetFinalContexte db = new ProjetFinalContexte();

        // GET: Ecrans
        public ActionResult Index()
        {
            return View(db.Ecrans.ToList());
        }

        // GET: Ecrans/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ecran ecran = db.Ecrans.Find(id);
            if (ecran == null)
            {
                return HttpNotFound();
            }
            return View(ecran);
        }

        // GET: Ecrans/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Ecrans/Create
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Dimension,Prix,Nom,Description")] Ecran ecran)
        {
            if (ModelState.IsValid)
            {
                db.Ecrans.Add(ecran);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(ecran);
        }

        // GET: Ecrans/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ecran ecran = db.Ecrans.Find(id);
            if (ecran == null)
            {
                return HttpNotFound();
            }
            return View(ecran);
        }

        // POST: Ecrans/Edit/5
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,TypeCatego,Dimension,Prix,Nom,Description")] Ecran ecran)
        {
            if (ModelState.IsValid)
            {
                db.Entry(ecran).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(ecran);
        }

        // GET: Ecrans/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ecran ecran = db.Ecrans.Find(id);
            if (ecran == null)
            {
                return HttpNotFound();
            }
            return View(ecran);
        }

        // POST: Ecrans/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Ecran ecran = db.Ecrans.Find(id);
            db.Ecrans.Remove(ecran);
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
