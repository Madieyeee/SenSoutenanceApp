using APPSenSoutenance.Models;
using APPSenSoutenance.Shared;
using System;
using System.Linq;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace APPSenSoutenance.Views.Parametre
{
    public partial class frmProfesseur : Form
    {
        BdSenSoutenanceContext db = new BdSenSoutenanceContext();

        public frmProfesseur()
        {
            InitializeComponent();
            this.Load += new EventHandler(frmProfesseur_Load);
        }

        private void frmProfesseur_Load(object sender, EventArgs e)
        {
            this.BackColor = DarkTheme.BgPrincipal;
            DarkTheme.StyleDataGridView(dgProfesseur);
            ResetForm();
            txtRNom.TextChanged        += (s, ev) => Filtrer();
            txtRSpecialite.TextChanged += (s, ev) => Filtrer();
        }

        private void ResetForm()
        {
            txtNom.Clear(); txtPrenom.Clear(); txtTelephone.Clear();
            txtEmail.Clear(); txtMotDePasse.Clear(); txtSpecialite.Clear();
            dgProfesseur.DataSource = db.Professeurs.ToList();
            txtNom.Focus();
        }

        private void Filtrer()
        {
            var nom  = txtRNom.Text.Trim().ToLower();
            var spec = txtRSpecialite.Text.Trim().ToLower();
            dgProfesseur.DataSource = db.Professeurs
                .Where(p => (nom  == "" || p.NomUtilisateur.ToLower().Contains(nom))
                         && (spec == "" || p.SpecialiteProfesseur.ToLower().Contains(spec)))
                .ToList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNom.Text)) { MessageBox.Show("Le nom est requis.", "Attention"); return; }
            var p = new Professeur
            {
                NomUtilisateur    = txtNom.Text,
                PrenomUtilisateur = txtPrenom.Text,
                TelUtilisateur    = txtTelephone.Text,
                EmailUtilisateur  = txtEmail.Text,
                MotDePasse        = Crypted.GetMd5Hash(MD5.Create(), txtMotDePasse.Text),
                SpecialiteProfesseur = txtSpecialite.Text
            };
            db.Professeurs.Add(p);
            db.SaveChanges();
            ResetForm();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgProfesseur.CurrentRow == null) return;
            int id = int.Parse(dgProfesseur.CurrentRow.Cells[0].Value.ToString());
            var p  = db.Professeurs.Find(id);
            p.NomUtilisateur    = txtNom.Text;
            p.PrenomUtilisateur = txtPrenom.Text;
            p.TelUtilisateur    = txtTelephone.Text;
            p.EmailUtilisateur  = txtEmail.Text;
            if (!string.IsNullOrWhiteSpace(txtMotDePasse.Text))
                p.MotDePasse = Crypted.GetMd5Hash(MD5.Create(), txtMotDePasse.Text);
            p.SpecialiteProfesseur = txtSpecialite.Text;
            db.SaveChanges();
            ResetForm();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dgProfesseur.CurrentRow == null) return;
            if (MessageBox.Show("Supprimer ce professeur ?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.No) return;
            int id = int.Parse(dgProfesseur.CurrentRow.Cells[0].Value.ToString());
            var p  = db.Professeurs.Find(id);
            db.Professeurs.Remove(p);
            db.SaveChanges();
            ResetForm();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (dgProfesseur.CurrentRow == null) { MessageBox.Show("Sélectionnez une ligne.", "Attention"); return; }
            var row = dgProfesseur.CurrentRow;
            txtNom.Text        = row.Cells[1].Value?.ToString() ?? "";
            txtPrenom.Text     = row.Cells[2].Value?.ToString() ?? "";
            txtTelephone.Text  = row.Cells[3].Value?.ToString() ?? "";
            txtEmail.Text      = row.Cells[4].Value?.ToString() ?? "";
            txtMotDePasse.Clear();
            txtSpecialite.Text  = row.Cells[5].Value?.ToString() ?? "";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Filtrer();
        }
    }
}
