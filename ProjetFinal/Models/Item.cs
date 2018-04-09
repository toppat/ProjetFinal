using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetFinal.Models
{
    public class Item
    {
        [Display(Name = "ID")]
        public int Id { get; set; }

        [Required]
        [Range(0, double.PositiveInfinity)]
        [Display(Name = "Prix")]
        public decimal Prix { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Nom")]
        public String Nom { get; set; }

        [StringLength(200)]
        [Display(Name = "Description")]
        public String Description { get; set; }
    }

    public enum TypeItem
    {
        Ordinateur,
        Accessoire
    }
}