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
        //Identification de variables
        public enum Boitier //• De bureau (ang. desktop) offre les moindres volumes et encombrements 
                            //• Tour il se décline en: • mini-tour ou demi-tour, moyenne-tour ou médium tour
                            //• tour ou maxi-tour, ou grande tour(plus grande volume pour l’extensions) • micro-tour 
        {
            [Description("Bureau")]
            bureau,
            [Description("Grande-Tour")]
            grandeTour,
            [Description("Demi-Tour")]
            demiTour,
            [Description("Mini-Tour")]
            miniTour,
            [Description("Micro-Tour")]
            microTour
        }

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