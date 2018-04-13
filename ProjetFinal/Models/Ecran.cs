using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace ProjetFinal.Models
{
    public class Ecran : Item
    {
        //public float Dimension { get; set; }

        public enum Dimension
        {
            [Description("17 pouces")]
            dixSept,
            [Description("19 pouces")]
            dixNeuf,
            [Description("20 pouces")]
            vingt,
            [Description("21 pouces")]
            vingtUn,
            [Description("24 pouces")]
            vingtQuatre,
        }
        public Ecran()
        {
            this.categorie = TypeItem.Accessoire;
        }
    }
}