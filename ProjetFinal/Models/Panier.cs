using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetFinal.Models
{
    public class Panier
    {
        [Display(Name = "ID")]
        public int Id { get; set; }

        [Display(Name = "Liste d'items")]
        public virtual List<Item> Items { get; set; }

        [Display(Name = "Le total")]
        public decimal Total { get; set; }
    }
}