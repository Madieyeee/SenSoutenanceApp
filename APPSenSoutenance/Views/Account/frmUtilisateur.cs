using APPSenSoutenance.Models;
using APPSenSoutenance.Shared;
using System;
using System.Data;
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

        private void frmUtilisateur_Load(object sender, EventArgs e)
        {
            // Thème dark premium
            this.BackColor = DarkTheme.BgPrincipal;
            this.ForeColor = DarkTheme.TextPrimary;
            DarkTheme.StyleDataGridView(dgUtilisateur);

            // Charger les données
            ResetForm();
        }

        private void ResetForm()
        {
            dgUtilisateur.DataSource = db.Utilisateurs.Select(a => new
            {
                a.IdUtilisateur,
                a.NomUtilisateur,
                a.EmailUtilisateur,
                a.MotDePasse
            }).ToList();
            
            txtNomUtilisateur.Clear();
            txtMotDePasse.Clear();
            cbbRole.SelectedIndex = -1;
            txtNomUtilisateur.Focus();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Utilisateur u = new Utilisateur
            {
                NomUtilisateur = txtNomUtilisateur.Text,
                EmailUtilisateur = txtNomUtilisateur.Text + "@univ.sn", // Email géré par défaut si non présent
                MotDePasse = txtMotDePasse.Text
            };
            
            db.Utilisateurs.Add(u);
            db.SaveChanges();
            ResetForm();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgUtilisateur.CurrentRow == null) return;
            int id = int.Parse(dgUtilisateur.CurrentRow.Cells[0].Value.ToString());
            var u = db.Utilisateurs.Find(id);
            if (u != null)
            {
                u.NomUtilisateur = txtNomUtilisateur.Text;
                u.MotDePasse = txtMotDePasse.Text;
                db.SaveChanges();
                ResetForm();
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dgUtilisateur.CurrentRow == null) return;
            int id = int.Parse(dgUtilisateur.CurrentRow.Cells[0].Value.ToString());
            var u = db.Utilisateurs.Find(id);
            if (u != null)
            {
                db.Utilisateurs.Remove(u);
                db.SaveChanges();
                ResetForm();
            }
        }
    }
}
