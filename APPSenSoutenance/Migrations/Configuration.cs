namespace APPSenSoutenance.Migrations
{
    using System.Data.Entity.Migrations;
    using System.Security.Cryptography;
    using System.Text;
    using APPSenSoutenance.Models;
    using AppSenSoutenance.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<APPSenSoutenance.Models.BdSenSoutenanceContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = false;
        }

        protected override void Seed(APPSenSoutenance.Models.BdSenSoutenanceContext context)
        {
            context.Admin.AddOrUpdate(
                u => u.EmailUtilisateur,
                new Admin
                {
                    IdUtilisateur = 1,
                    NomUtilisateur = "Admin",
                    PrenomUtilisateur = "Système",
                    TelUtilisateur = "771234567",
                    EmailUtilisateur = "admin@sensoutenance.sn",
                    MotDePasse = GetMd5Hash("admin123")
                }
            );

            context.Candidats.AddOrUpdate(
                u => u.EmailUtilisateur,
                new Candidat
                {
                    IdUtilisateur = 2,
                    NomUtilisateur = "Diop",
                    PrenomUtilisateur = "Moussa",
                    TelUtilisateur = "779876543",
                    EmailUtilisateur = "candidat@sensoutenance.sn",
                    MotDePasse = GetMd5Hash("candidat123"),
                    MatriculeCandidat = "2021-001"
                }
            );

            context.SaveChanges();
        }

        private static string GetMd5Hash(string input)
        {
            using (MD5 md5Hash = MD5.Create())
            {
                byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));
                StringBuilder sBuilder = new StringBuilder();
                for (int i = 0; i < data.Length; i++)
                {
                    sBuilder.Append(data[i].ToString("x2"));
                }
                return sBuilder.ToString();
            }
        }
    }
}
