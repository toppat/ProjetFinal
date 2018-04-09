using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace ProjetFinal.Models
{
    public class OrdiPortable : Ordinateur
    {
        //Identification de variables
        public enum Dimension
        {
            [Description("13 pouces")]
            treize,
            [Description("14 pouces")]
            quatorze,
            [Description("15 pouces")]
            quinze,
            [Description("15.4 pouces")]
            quinzeQuatre,
            [Description("15.6 pouces")]
            quinzeSix,
            [Description("17 pouces")]
            dixSept
        }
    }
}