using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetFinal.Models
{
    public class OrdiBureau : Ordinateur
    {
        //Identification de variables
        public enum Boitier
        {
            Petit, Moyen, Gros
        }
        public enum CarteMere
        {
            microATX, miniATX, Moyen, Gros
        }
    }
}