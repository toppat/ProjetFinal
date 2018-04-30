using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetFinal.Models
{
    public class PanierItem
    {
        [Display(Name = "ID")]
        public int ID { get; set; }

        [Display(Name = "Quantity")]
        public int Qty { get; set; }

        [Display(Name = "Item")]
        public virtual Item Item{ get; set; }
    }
}