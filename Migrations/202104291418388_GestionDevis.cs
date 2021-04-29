namespace GestionDevisTraiteurWPF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class GestionDevis : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clients",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        nom = c.String(unicode: false),
                        prenom = c.String(unicode: false),
                        adresse = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Devis",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        nom = c.String(unicode: false),
                        prixHtSansMarge = c.Double(nullable: false),
                        prixHtAvecMarge = c.Double(nullable: false),
                        coefficientMarge = c.Double(nullable: false),
                        nombrePersonne = c.Int(nullable: false),
                        nombreCuisinier = c.Int(nullable: false),
                        nombreServeur = c.Int(nullable: false),
                        tempsTravail = c.DateTime(nullable: false, precision: 0),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.ProduitDevis",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        quantite = c.Int(nullable: false),
                        prixUnitaire = c.Double(nullable: false),
                        prixTotalHt = c.Double(nullable: false),
                        Devis_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Devis", t => t.Devis_id)
                .Index(t => t.Devis_id);
            
            CreateTable(
                "dbo.Familles",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        nom = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Produits",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        nom = c.String(unicode: false),
                        unite = c.String(unicode: false),
                        prix = c.Double(nullable: false),
                        Famille_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Familles", t => t.Famille_id)
                .Index(t => t.Famille_id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Produits", "Famille_id", "dbo.Familles");
            DropForeignKey("dbo.ProduitDevis", "Devis_id", "dbo.Devis");
            DropIndex("dbo.Produits", new[] { "Famille_id" });
            DropIndex("dbo.ProduitDevis", new[] { "Devis_id" });
            DropTable("dbo.Produits");
            DropTable("dbo.Familles");
            DropTable("dbo.ProduitDevis");
            DropTable("dbo.Devis");
            DropTable("dbo.Clients");
        }
    }
}
