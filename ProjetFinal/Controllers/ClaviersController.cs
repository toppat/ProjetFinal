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
    public class ClaviersController : Controller
    {
        private ProjetFinalContexte db = new ProjetFinalContexte();

        // GET: Claviers
        public ActionResult Index()
        {
            return View(db.Claviers.ToList());
        }

        // GET: Claviers/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Clavier clavier = db.Claviers.Find(id);
            if (clavier == null)
            {
                return HttpNotFound();
            }
            return View(clavier);
        }

        // GET: Claviers/Create
        public ActionResult Create()
        {
            return View(new Clavier());
        }

        // POST: Claviers/Create
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Type,Prix,Nom,Description")] Clavier clavier)
        {
            if (ModelState.IsValid)
            {
                db.Claviers.Add(clavier);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(clavier);
        }

        // GET: Claviers/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Clavier clavier = db.Claviers.Find(id);
            if (clavier == null)
            {
                return HttpNotFound();
            }
            return View(clavier);
        }

        // POST: Claviers/Edit/5
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,TypeCatego,Type,Prix,Nom,Description")] Clavier clavier)
        {
            if (ModelState.IsValid)
            {
                db.Entry(clavier).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(clavier);
        }

        // GET: Claviers/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Clavier clavier = db.Claviers.Find(id);
            if (clavier == null)
            {
                return HttpNotFound();
            }
            return View(clavier);
        }

        // POST: Claviers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Clavier clavier = db.Claviers.Find(id);
            db.Claviers.Remove(clavier);
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
