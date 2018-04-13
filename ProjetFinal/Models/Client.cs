using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetFinal.Models
{
    public class Client : CompteUtilisateur
    {
        [Display(Name = "Votre panier")]
        public virtual Panier Panier { get; set; }

        [Display(Name = "Historique des Commande")]
        public virtual List<Commande> Commandes { get; set; }
    }
}