using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetFinal.Models
{
    public class Clavier : Item
    {
        public CategorieClavier Type { get; set; }

        public enum CategorieClavier
        {
            [Display(Name = "Avec Fil")]
            avecFil,
            [Display(Name = "Sans Fil")]
            sansFil,
            [Display(Name = "De Jeu")]
            deJeu,
            [Display(Name = "Ergonomique")]
            ergonomique
        }
        public Clavier()
        {
            this.TypeCatego = TypeItem.Accessoire;
        }
    }
}