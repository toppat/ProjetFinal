using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace ProjetFinal.Models
{
    public class OrdiPortable : Ordinateur
    {
        //public Dimension DimensionEcran { get; set; }

        //Identification de variables
        public enum Dimension
        {
            [Display(Name = "13 pouces")]
            treize,
            [Display(Name = "14 pouces")]
            quatorze,
            [Display(Name = "15 pouces")]
            quinze,
            [Display(Name = "15.4 pouces")]
            quinzeQuatre,
            [Display(Name = "15.6 pouces")]
            quinzeSix,
            [Display(Name = "17 pouces")]
            dixSept
        }

        public OrdiPortable() : base() { }
    }
}