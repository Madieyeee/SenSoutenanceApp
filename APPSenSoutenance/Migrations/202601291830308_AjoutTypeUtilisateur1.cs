namespace APPSenSoutenance.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AjoutTypeUtilisateur1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Utilisateurs", "TypeUtilisateur", c => c.String(maxLength: 50, storeType: "nvarchar"));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Utilisateurs", "TypeUtilisateur", c => c.String(nullable: false, maxLength: 50, storeType: "nvarchar"));
        }
    }
}
