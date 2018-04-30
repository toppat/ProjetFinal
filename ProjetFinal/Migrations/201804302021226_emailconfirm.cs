namespace ProjetFinal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class emailconfirm : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.CompteUtilisateurs", "Email", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.CompteUtilisateurs", "Email", c => c.String(maxLength: 50));
        }
    }
}
