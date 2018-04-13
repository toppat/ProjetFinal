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
    public class OrdiPortablesController : Controller
    {
        private ProjetFinalContexte db = new ProjetFinalContexte();

        // GET: OrdiPortables
        public ActionResult Index()
        {
            return View(db.OrdiPortables.ToList());
        }

        // GET: OrdiPortables/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OrdiPortable ordiPortable = db.OrdiPortables.Find(id);
            if (ordiPortable == null)
            {
                return HttpNotFound();
            }
            return View(ordiPortable);
        }

        // GET: OrdiPortables/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: OrdiPortables/Create
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,TypeCatego,Prix,Nom,Description,Memoire,Processeur,CarteGraphique")] OrdiPortable ordiPortable)
        {
            if (ModelState.IsValid)
            {
                db.OrdiPortables.Add(ordiPortable);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(ordiPortable);
        }

        // GET: OrdiPortables/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OrdiPortable ordiPortable = db.OrdiPortables.Find(id);
            if (ordiPortable == null)
            {
                return HttpNotFound();
            }
            return View(ordiPortable);
        }

        // POST: OrdiPortables/Edit/5
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,TypeCatego,Prix,Nom,Description,Memoire,Processeur,CarteGraphique")] OrdiPortable ordiPortable)
        {
            if (ModelState.IsValid)
            {
                db.Entry(ordiPortable).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(ordiPortable);
        }

        // GET: OrdiPortables/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OrdiPortable ordiPortable = db.OrdiPortables.Find(id);
            if (ordiPortable == null)
            {
                return HttpNotFound();
            }
            return View(ordiPortable);
        }

        // POST: OrdiPortables/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            OrdiPortable ordiPortable = db.OrdiPortables.Find(id);
            db.OrdiPortables.Remove(ordiPortable);
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
