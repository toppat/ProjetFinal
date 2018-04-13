using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace ProjetFinal.Models
{
    public class Souris : Item
    {
        public enum Categorie
        {
            [Description("Avec Fil")]
            avecFil,
            [Description("Sans Fil")]
            sansFil,
            [Description("De Jeu")]
            deJeu,
            [Description("Ergonomique")]
            ergonomique
        }
        public Souris()
        {
            this.categorie = TypeItem.Accessoire;
        }
    }
}