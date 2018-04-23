using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetFinal.Models
{
    public class Souris : Item
    {
        public CategorieSouris Type { get; set; }

        public enum CategorieSouris
        {
            [Display(Name = "Filaire")]
            filaire,
            [Display(Name = "Sans Fil")]
            sansFil,
            [Display(Name = "Gamer")]
            Gamer,
            [Display(Name = "Ergonomique")]
            ergonomique
        }
        public Souris()
        {
            this.TypeCatego = TypeItem.Accessoire;
        }
    }
}