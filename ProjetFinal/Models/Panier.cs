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

        [Display(Name = "Items")]
        public virtual List<Item> Items { get; set; }

        [Display(Name = "Total")]
        public decimal Total { get; set; }
    }
}