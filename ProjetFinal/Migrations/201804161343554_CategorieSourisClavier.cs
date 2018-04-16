namespace ProjetFinal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CategorieSourisClavier : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Items", "TypeCatego", c => c.Int(nullable: false));
            AddColumn("dbo.Items", "Type", c => c.Int());
            AddColumn("dbo.Items", "Dimension", c => c.Int());
            AddColumn("dbo.Items", "Memoire", c => c.Int());
            AddColumn("dbo.Items", "Processeur", c => c.Single());
            AddColumn("dbo.Items", "CarteGraphique", c => c.String(maxLength: 50));
            AddColumn("dbo.Items", "Type1", c => c.Int());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Items", "Type1");
            DropColumn("dbo.Items", "CarteGraphique");
            DropColumn("dbo.Items", "Processeur");
            DropColumn("dbo.Items", "Memoire");
            DropColumn("dbo.Items", "Dimension");
            DropColumn("dbo.Items", "Type");
            DropColumn("dbo.Items", "TypeCatego");
        }
    }
}
