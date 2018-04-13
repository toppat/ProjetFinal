using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetFinal.Models
{
    public class Item
    {
        TypeItem categorie { get; set; }

        [Display(Name = "ID")]
        public int Id { get; set; }

        [Required]
        [Range(0, double.PositiveInfinity)]
        [Display(Name = "Le prix")]
        public decimal Prix { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Nom de l'item")]
        public String Nom { get; set; }

        [StringLength(200)]
        [Display(Name = "La description")]
        public String Description { get; set; }
    }

    public enum TypeItem
    {
        Ordinateur,
        Accessoire
    }
}