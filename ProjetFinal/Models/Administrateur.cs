using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetFinal.Models
{
    public class Administrateur : CompteUtilisateur
    {
        [Display(Name = "Historique")]
        public virtual List<String> Historique { get; set; }
    }
}