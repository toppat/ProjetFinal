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
    public class OrdiBureauxController : Controller
    {
        private ProjetFinalContexte db = new ProjetFinalContexte();

        // GET: OrdiBureaux
        public ActionResult Index()
        {
            return View(db.OrdiBureaux.ToList());
        }

        // GET: OrdiBureaux/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OrdiBureau ordiBureau = db.OrdiBureaux.Find(id);
            if (ordiBureau == null)
            {
                return HttpNotFound();
            }
            return View(ordiBureau);
        }

        // GET: OrdiBureaux/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: OrdiBureaux/Create
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,TypeCatego,Prix,Nom,Description,Memoire,Processeur,CarteGraphique")] OrdiBureau ordiBureau)
        {
            if (ModelState.IsValid)
            {
                db.OrdiBureaux.Add(ordiBureau);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(ordiBureau);
        }

        // GET: OrdiBureaux/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OrdiBureau ordiBureau = db.OrdiBureaux.Find(id);
            if (ordiBureau == null)
            {
                return HttpNotFound();
            }
            return View(ordiBureau);
        }

        // POST: OrdiBureaux/Edit/5
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,TypeCatego,Prix,Nom,Description,Memoire,Processeur,CarteGraphique")] OrdiBureau ordiBureau)
        {
            if (ModelState.IsValid)
            {
                db.Entry(ordiBureau).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(ordiBureau);
        }

        // GET: OrdiBureaux/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OrdiBureau ordiBureau = db.OrdiBureaux.Find(id);
            if (ordiBureau == null)
            {
                return HttpNotFound();
            }
            return View(ordiBureau);
        }

        // POST: OrdiBureaux/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            OrdiBureau ordiBureau = db.OrdiBureaux.Find(id);
            db.OrdiBureaux.Remove(ordiBureau);
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
