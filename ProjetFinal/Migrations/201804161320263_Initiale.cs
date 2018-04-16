namespace ProjetFinal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initiale : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CompteUtilisateurs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Email = c.String(maxLength: 50),
                        Nom = c.String(nullable: false, maxLength: 50),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                        Panier_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Paniers", t => t.Panier_Id)
                .Index(t => t.Panier_Id);
            
            CreateTable(
                "dbo.Items",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Prix = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Nom = c.String(nullable: false, maxLength: 50),
                        Description = c.String(maxLength: 200),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                        Panier_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Paniers", t => t.Panier_Id)
                .Index(t => t.Panier_Id);
            
            CreateTable(
                "dbo.Commandes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        StartDate = c.DateTime(nullable: false),
                        Total = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Client_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.CompteUtilisateurs", t => t.Client_Id)
                .Index(t => t.Client_Id);
            
            CreateTable(
                "dbo.Paniers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Total = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CompteUtilisateurs", "Panier_Id", "dbo.Paniers");
            DropForeignKey("dbo.Items", "Panier_Id", "dbo.Paniers");
            DropForeignKey("dbo.Commandes", "Client_Id", "dbo.CompteUtilisateurs");
            DropIndex("dbo.Commandes", new[] { "Client_Id" });
            DropIndex("dbo.Items", new[] { "Panier_Id" });
            DropIndex("dbo.CompteUtilisateurs", new[] { "Panier_Id" });
            DropTable("dbo.Paniers");
            DropTable("dbo.Commandes");
            DropTable("dbo.Items");
            DropTable("dbo.CompteUtilisateurs");
        }
    }
}
