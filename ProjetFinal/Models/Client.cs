using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetFinal.Models
{
    public class Client : CompteUtilisateur
    {
        public virtual Panier Panier { get; set; }

        [Display(Name = "Hystorique Commande")]
        public virtual List<Commande> Commandes { get; set; }
    }
}