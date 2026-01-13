using APPSenSoutenance.Shared;
using APPSenSoutenance.Models;
using MySql.Data.EntityFramework;
using System.Data.Entity;

namespace APPSenSoutenance.Models
{
    [DbConfigurationType(typeof(MySqlConfiguration))]
    internal class BdSenSoutenanceContext : DbContext
    {
        public BdSenSoutenanceContext() : base("connBdSenSoutenance") 
        {
            // Cette ligne demande à EF de créer la BDD et d'appliquer toutes les migrations au démarrage.
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<BdSenSoutenanceContext, Migrations.Configuration>());
        }
        public DbSet<AnneeAcademique> AnneeAcademiques { get; set; }
        public DbSet<Memoire> Memoires { get; set; }
        public DbSet<Session> Sessions { get; set; }
        public DbSet<Soutenance> Soutenances { get; set; }
        public DbSet<Utilisateur> Utilisateurs { get; set; }
        public DbSet<Admin> Admin { get; set; }
        public DbSet<ChefDepartement> ChefDepartements { get; set; }
        public DbSet<Candidat> Candidats { get; set; }
        public DbSet<Professeur> Professeurs { get; set; }
        public object AnneeAcademique { get; internal set; }

    }
}
