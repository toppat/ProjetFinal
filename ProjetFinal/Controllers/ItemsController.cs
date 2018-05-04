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
    public class ItemsController : Controller
    {
        private ProjetFinalContexte db = new ProjetFinalContexte();

        // GET: Items
        public ActionResult Index(String searchString)
        {
            ViewBag.CurrentFilter = searchString;
            var items = from i in db.Items
                select i;
             if (!String.IsNullOrEmpty(searchString))
            {
                items = items.Where(i => i.Nom.ToLower().Contains(searchString.ToLower()) || i.Description.ToLower().Contains(searchString.ToLower()));
            }
            return View(items.ToList());
        }

        //// Search
        //ViewBag.CurrentFilter = searchString;

        //    var students = from s in db.Students
        //                   select s;
        //    if (!String.IsNullOrEmpty(searchString))
        //    {
        //        students = students.Where(s => s.LastName.Contains(searchString)
        //                               || s.FirstMidName.Contains(searchString));
        //    }
        //    switch (sortOrder)
        //    {
        //        case "name_desc":
        //            students = students.OrderByDescending(s => s.LastName);
        //            break;
        //        case "Date":
        //            students = students.OrderBy(s => s.EnrollmentDate);
        //            break;
        //        case "date_desc":
        //            students = students.OrderByDescending(s => s.EnrollmentDate);
        //            break;
        //        default:  // Name ascending 
        //            students = students.OrderBy(s => s.LastName);
        //            break;
        //    }

// GET: Items/Details/5
public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Item item = db.Items.Find(id);
            if (item == null)
            {
                return HttpNotFound();
            }
            ViewBag.client = db.Clients.ToList();
            return View(item);
        }

        // GET: Items/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Items/Create
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,TypeCatego,Prix,Nom,Description")] Item item)
        {
            if (ModelState.IsValid)
            {
                db.Items.Add(item);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(item);
        }
        
        // GET: Items/Edit/5                           
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Item item = db.Items.Find(id);
            if (item == null)
            {
                return HttpNotFound();
            }
            return View(item);
        }

        // POST: Items/Edit/5
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,TypeCatego,Prix,Nom,Description")] Item item)
        {
            if (ModelState.IsValid)
            {
                db.Entry(item).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(item);
        }

        // GET: Items/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Item item = db.Items.Find(id);
            if (item == null)
            {
                return HttpNotFound();
            }
            return View(item);
        }

        // POST: Items/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Item item = db.Items.Find(id);
            db.Items.Remove(item);
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
