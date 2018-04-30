using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetFinal.Models
{
    public class PanierItem
    {
        [Display(Name = "Quantity")]
        public int Qty { get; set; }

        [Display(Name = "Item")]
        public Item Item{ get; set; }
    }
}