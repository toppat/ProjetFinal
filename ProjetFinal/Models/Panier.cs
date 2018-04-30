using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetFinal.Models
{
    public class Panier
    {
        [Display(Name = "ID")]
        public int Id { get; set; }

        [Display(Name = "Liste d'items")]
        public virtual List<PanierItem> Items { get; set; }

        [Display(Name = "Le total")]
        public decimal Total { get; set; }
    }
}



//PanierItems i = List.find(Pi=>Pi.item.id==itemId)
    //if (i==null)
    //new PanierItem(......)

//@html.DropDownList("Nom", SelectList, "Selectionner un client", HtmlAttributes)
// new SelectList(ListeClients, "id", "Nom")

//1.obtenir la liste des clients                  dans Controller items
//2.Passer la liste de clients a la vue (ViewBag) dans Controller items

//3.Créer un DropDownList dans la vue avec la liste de client  dans Vue (Details)
//4.Appeler un Action"Ajouter"dans le controller de panier     dans Vue (Details)

//5.Aller chercher la valeur selectionnéedu DropDownList       dans controller Panier
//6.Aller chercher le panier du client                         dans controller Panier
//7.Ajouter le PanierItem dans la liste du panier              dans controller Panier
    //- Juste modifier la quantité si existe déja
    //- si non en créer un nouveau
//8.db.saveChange()