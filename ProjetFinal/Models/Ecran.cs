using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace ProjetFinal.Models
{
    public class Ecran : Item
    {
        public DimmensionDisponible Dimension { get; set; }

        public enum DimmensionDisponible
        {
            [Description("17 pouces")]
            DixSeptPouces,
            [Description("19 pouces")]
            DixNeufPouces,
            [Description("20 pouces")]
            VingtPouces,
            [Description("21 pouces")]
            VingtUnPouces,
            [Description("24 pouces")]
            VingtQuatrePouces,
        }
        public Ecran()
        {
            this.TypeCatego = TypeItem.Accessoire;
        }
    }
}