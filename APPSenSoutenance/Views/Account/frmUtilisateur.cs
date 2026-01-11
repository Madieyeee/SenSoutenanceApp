using AppSenSoutenance.Models;
using APPSenSoutenance.Models;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace APPSenSoutenance.Views.Account
{
    public partial class frmUtilisateur : Form
    {
        public frmUtilisateur()
        {
            InitializeComponent();
        }

        BdSenSoutenanceContext db = new BdSenSoutenanceContext();


        private void btnCAjouter_Click(object sender, EventArgs e)
        {
            Candidat candidat = new Candidat();
            candidat.NomUtilisateur = txtNom.Text;
            candidat.PrenomUtilisateur = txtPrenom.Text;
            candidat.EmailUtilisateur = txtEmail.Text;
            using (MD5 md5Hash = MD5.Create())
            {
                candidat.MotDePasse = Shared.Crypted.GetMd5Hash(md5Hash, "passer123");
            }
            candidat.MatriculeCandidat = txtMatricule.Text;
            db.Candidats.Add(candidat);
            db.SaveChanges();
            ResetForm();
        }

        private void ResetForm()
        {
            dgUtilisateur.DataSource = db.Utilisateurs.Select(
                a => new
                {
                    a.IdUtilisateur,
                    a.NomUtilisateur,
                    a.PrenomUtilisateur,
                    a.EmailUtilisateur,
                    a.TelUtilisateur
                }).ToList();
        }

        private void btnCModifier_Click(object sender, EventArgs e)
        {

        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            Candidat candidat = new Candidat();
            candidat.NomUtilisateur = txtNom.Text;
            candidat.PrenomUtilisateur = txtPrenom.Text;
            candidat.EmailUtilisateur = txtEmail.Text;
            candidat.TelUtilisateur = txtTel.Text;
            using (MD5 md5Hash = MD5.Create())
            {
                candidat.MotDePasse = Shared.Crypted.GetMd5Hash(md5Hash, "passer123");
            }
            candidat.MatriculeCandidat = txtMatricule.Text;
            db.Candidats.Add(candidat);
            db.SaveChanges();
            ResetForm();
        }

        private void frmUtilisateur_Load(object sender, EventArgs e)
        {
            // Appliquer le style des lignes alternées au DataGridView
            dgUtilisateur.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(236, 240, 245);
            dgUtilisateur.AlternatingRowsDefaultCellStyle.ForeColor = Color.FromArgb(52, 73, 94);
            dgUtilisateur.DefaultCellStyle.BackColor = Color.White;
            dgUtilisateur.DefaultCellStyle.ForeColor = Color.FromArgb(52, 73, 94);

            // Charger les données
            ResetForm();
        }
    }
}
