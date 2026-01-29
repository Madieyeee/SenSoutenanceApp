namespace APPSenSoutenance.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AjoutTypeUtilisateur : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Utilisateurs", "TypeUtilisateur", c => c.String(nullable: false, maxLength: 50, storeType: "nvarchar"));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Utilisateurs", "TypeUtilisateur");
        }
    }
}
