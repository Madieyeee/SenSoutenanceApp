namespace APPSenSoutenance.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SyncModel : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Utilisateurs", "TypeUtilisateur");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Utilisateurs", "TypeUtilisateur", c => c.String(maxLength: 50, storeType: "nvarchar"));
        }
    }
}
