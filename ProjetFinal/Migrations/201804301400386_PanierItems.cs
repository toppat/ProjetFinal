namespace ProjetFinal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PanierItems : DbMigration
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
                        TypeCatego = c.Int(nullable: false),
                        Prix = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Nom = c.String(nullable: false, maxLength: 50),
                        Description = c.String(maxLength: 200),
                        Type = c.Int(),
                        Dimension = c.Int(),
                        Memoire = c.Int(),
                        Processeur = c.Single(),
                        CarteGraphique = c.String(maxLength: 50),
                        Type1 = c.Int(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Id);
            
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
            
            CreateTable(
                "dbo.PanierItems",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Qty = c.Int(nullable: false),
                        Item_Id = c.Int(),
                        Panier_Id = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Items", t => t.Item_Id)
                .ForeignKey("dbo.Paniers", t => t.Panier_Id)
                .Index(t => t.Item_Id)
                .Index(t => t.Panier_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CompteUtilisateurs", "Panier_Id", "dbo.Paniers");
            DropForeignKey("dbo.PanierItems", "Panier_Id", "dbo.Paniers");
            DropForeignKey("dbo.PanierItems", "Item_Id", "dbo.Items");
            DropForeignKey("dbo.Commandes", "Client_Id", "dbo.CompteUtilisateurs");
            DropIndex("dbo.PanierItems", new[] { "Panier_Id" });
            DropIndex("dbo.PanierItems", new[] { "Item_Id" });
            DropIndex("dbo.Commandes", new[] { "Client_Id" });
            DropIndex("dbo.CompteUtilisateurs", new[] { "Panier_Id" });
            DropTable("dbo.PanierItems");
            DropTable("dbo.Paniers");
            DropTable("dbo.Commandes");
            DropTable("dbo.Items");
            DropTable("dbo.CompteUtilisateurs");
        }
    }
}
