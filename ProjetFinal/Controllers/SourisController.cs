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
    public class SourisController : Controller
    {
        private ProjetFinalContexte db = new ProjetFinalContexte();

        // GET: Souris
        public ActionResult Index()
        {
            return View(db.Souris.ToList());
        }

        // GET: Souris/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Souris souris = db.Souris.Find(id);
            if (souris == null)
            {
                return HttpNotFound();
            }
            return View(souris);
        }

        // GET: Souris/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Souris/Create
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Type,Prix,Nom,Description")] Souris souris)
        {
            if (ModelState.IsValid)
            {
                db.Souris.Add(souris);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(souris);
        }

        // GET: Souris/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Souris souris = db.Souris.Find(id);
            if (souris == null)
            {
                return HttpNotFound();
            }
            return View(souris);
        }

        // POST: Souris/Edit/5
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Categorie,Type,Prix,Nom,Description")] Souris souris)
        {
            if (ModelState.IsValid)
            {
                db.Entry(souris).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(souris);
        }

        // GET: Souris/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Souris souris = db.Souris.Find(id);
            if (souris == null)
            {
                return HttpNotFound();
            }
            return View(souris);
        }

        // POST: Souris/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Souris souris = db.Souris.Find(id);
            db.Souris.Remove(souris);
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
