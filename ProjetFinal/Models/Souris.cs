using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace ProjetFinal.Models
{
    public class Souris : Item
    {
        public CategorieSouris Type { get; set; }

        public enum CategorieSouris
        {
            [Description("Filaire")]
            filaire,
            [Description("Sans Fil")]
            sansFil,
            [Description("Gamer")]
            Gamer,
            [Description("Ergonomique")]
            ergonomique
        }
        public Souris()
        {
            this.TypeCatego = TypeItem.Accessoire;
        }
    }
}