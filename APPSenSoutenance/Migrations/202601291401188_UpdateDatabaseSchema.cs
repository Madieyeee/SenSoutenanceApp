namespace APPSenSoutenance.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateDatabaseSchema : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Td_Erreur",
                c => new
                    {
                        IdTdErreur = c.Int(nullable: false, identity: true),
                        TitreErreur = c.String(maxLength: 200, storeType: "nvarchar"),
                        DescriptionErreur = c.String(maxLength: 2000, storeType: "nvarchar"),
                        DateErreur = c.DateTime(nullable: false, precision: 0),
                    })
                .PrimaryKey(t => t.IdTdErreur);
            
            AlterColumn("dbo.Utilisateurs", "MatriculeCandidat", c => c.String(maxLength: 22, storeType: "nvarchar"));
            AlterColumn("dbo.AnneeAcademiques", "LibelleAnneeAcademique", c => c.String(nullable: false, maxLength: 11, storeType: "nvarchar"));
            AlterColumn("dbo.Departements", "LibelleDepartement", c => c.String(nullable: false, maxLength: 81, storeType: "nvarchar"));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Departements", "LibelleDepartement", c => c.String(nullable: false, maxLength: 80, storeType: "nvarchar"));
            AlterColumn("dbo.AnneeAcademiques", "LibelleAnneeAcademique", c => c.String(nullable: false, maxLength: 10, storeType: "nvarchar"));
            AlterColumn("dbo.Utilisateurs", "MatriculeCandidat", c => c.String(maxLength: 20, storeType: "nvarchar"));
            DropTable("dbo.Td_Erreur");
        }
    }
}
