namespace GestionDevisTraiteurWPF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class GestionDevis : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.SousProduits", "quantite", c => c.Int(nullable: false));
            AddColumn("dbo.SousProduits", "poids", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.SousProduits", "poids");
            DropColumn("dbo.SousProduits", "quantite");
        }
    }
}
