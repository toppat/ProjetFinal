using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetFinal.Models
{
    public class Ecran : Item
    {
        public DimmensionDisponible Dimension { get; set; }

        public enum DimmensionDisponible
        {
            [Display(Name = "17 pouces")]
            DixSeptPouces,
            [Display(Name = "19 pouces")]
            DixNeufPouces,
            [Display(Name = "20 pouces")]
            VingtPouces,
            [Display(Name = "21 pouces")]
            VingtUnPouces,
            [Display(Name = "24 pouces")]
            VingtQuatrePouces,
        }
        public Ecran()
        {
            this.TypeCatego = TypeItem.Accessoire;
        }
    }
}