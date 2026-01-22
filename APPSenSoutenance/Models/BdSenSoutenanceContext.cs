using AppSenSoutenance.Models;
using MySql.Data.EntityFramework;
using System.Data.Entity;

namespace APPSenSoutenance.Models
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    internal class BdSenSoutenanceContext : DbContext
    {
        public BdSenSoutenanceContext() : base("connBdSenSoutenance") { }
        public DbSet<AnneeAcademique> AnneeAcademiques { get; set; }
        public DbSet<Memoire> Memoires { get; set; }
        public DbSet<Session> Sessions { get; set; }
        public DbSet<Soutenance> Soutenances { get; set; }
        public DbSet<Utilisateur> Utilisateurs { get; set; }
        public DbSet<Admin> Admin { get; set; }
        public DbSet<ChefDepartement> ChefDepartements { get; set; }
        public DbSet<Candidat> Candidats { get; set; }
        public DbSet<Professeur> Professeurs { get; set; }
        public DbSet<Td_Erreur>Td_Erreur { get; set; }
        public object AnneeAcademique { get; internal set; }

    }
}
