using ProjetFinal.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ProjetFinal.DAL
{
    public class ProjetFinalContexte : DbContext
    {
        public DbSet<Item> Items { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Commande> Commandes { get; set; }
        public DbSet<Administrateur> Administrateurs { get; set; }
        public DbSet<Panier> Paniers { get; set; }
        public DbSet<Ordinateur> Ordinateurs { get; set; }
        public DbSet<OrdiPortable> OrdiPortables { get; set; }
        public DbSet<OrdiBureau> OrdiBureaus { get; set; }
        public DbSet<Ecran> Ecrans { get; set; }
        public DbSet<Souris> Souris { get; set; }
        public DbSet<Clavier> Claviers { get; set; }
        public DbSet<CompteUtilisateur> CompteUtilisateurs { get; set; }
    }
}