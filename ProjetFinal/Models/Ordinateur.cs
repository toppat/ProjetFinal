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
        public int memoire { get; set; }
        [Required]
        public float processeur { get; set; }
        [Required]
        public String carteGraphique { get; set; }

        
    }
}