using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetFinal.Models
{
    public class OrdiBureau : Ordinateur
    {
        //public Boitier Format { get; set; }

        //Identification de variables
        public enum Boitier //• De bureau (ang. desktop) offre les moindres volumes et encombrements 
                            //• Tour il se décline en: • mini-tour ou demi-tour, moyenne-tour ou médium tour
                            //• tour ou maxi-tour, ou grande tour(plus grande volume pour l’extensions) • micro-tour 
        {
            [Display(Name = "Bureau")]
            bureau,
            [Display(Name = "Grande-Tour")]
            grandeTour,
            [Display(Name = "Demi-Tour")]
            demiTour,
            [Display(Name = "Mini-Tour")]
            miniTour,
            [Display(Name = "Micro-Tour")]
            microTour
        }

       // public CarteMere MotherBoard { get; set; }

        public enum CarteMere //ATX / Micro ATX / Mini ITX
        {
            [Description("ATX")]
            atx,
            [Description("Micro ATX")]
            microATX,
            [Description("Mini ITX")]
            miniITX
        }

        public OrdiBureau() : base() { }
    }
}