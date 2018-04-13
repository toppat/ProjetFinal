using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetFinal.Models
{
    public class Ordinateur : Item
    {
        //Recherche des variables
        [Required]
        public int Memoire { get; set; }

        [Required]
        public float Processeur { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Carte Graphique")]
        public String CarteGraphique { get; set; }

        public Ordinateur()
        {
            this.Categorie = TypeItem.Ordinateur;
        }
    }
}