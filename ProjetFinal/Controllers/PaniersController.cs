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
    public class PaniersController : Controller
    {
        private ProjetFinalContexte db = new ProjetFinalContexte();

        // GET: Paniers
        public ActionResult Index()
        {
            return View(db.Paniers.ToList());
        }

        // GET: Paniers/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Panier panier = db.Paniers.Find(id);
            if (panier == null)
            {
                return HttpNotFound();
            }
            return View(panier);
        }

        // GET: Paniers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Paniers/Create
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Total")] Panier panier)
        {
            if (ModelState.IsValid)
            {
                db.Paniers.Add(panier);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(panier);
        }

        //Ajoute un item dans le panier
        public ActionResult AddItem(int idItem)
        {
            Item item = db.Items.Find(idItem);
            if (item == null)
            {
                return HttpNotFound();
            }
            String DropDownValue = Request.Form.Get("DropDownlistClient");
            if (String.IsNullOrEmpty(DropDownValue))
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            int IdClient = int.Parse(DropDownValue);
            Client client = db.Clients.Find(IdClient);
            if (client == null)
            {
                return HttpNotFound();
            }

            PanierItem Panieritem = client.Panier.Items.Find(PanierItem => PanierItem.Item.Id == idItem);

            if (Panieritem == null)
            {
                Panieritem = new PanierItem {
                    Item = item,
                    Qty = 1
                };
                client.Panier.Items.Add(Panieritem);
            }
            else
            {
                client.Panier.Items.Find(PanierItem => PanierItem.Item.Id == idItem).Qty++;
            }

            db.Entry(client.Panier).State = EntityState.Modified;
            db.SaveChanges();

            return RedirectToAction("Details", new { Id = idItem });
        }
        // GET: Paniers/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Panier panier = db.Paniers.Find(id);
            if (panier == null)
            {
                return HttpNotFound();
            }
            return View(panier);
        }

        // POST: Paniers/Edit/5
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Total")] Panier panier)
        {
            if (ModelState.IsValid)
            {
                db.Entry(panier).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(panier);
        }

        // GET: Paniers/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Panier panier = db.Paniers.Find(id);
            if (panier == null)
            {
                return HttpNotFound();
            }
            return View(panier);
        }

        // POST: Paniers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Panier panier = db.Paniers.Find(id);
            db.Paniers.Remove(panier);
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
