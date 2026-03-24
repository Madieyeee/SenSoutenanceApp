using APPSenSoutenance.Models;
using APPSenSoutenance.Shared;
using System;
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
            this.Load += new EventHandler(frmUtilisateur_Load);
        }

        BdSenSoutenanceContext db = new BdSenSoutenanceContext();

        private void frmUtilisateur_Load(object sender, EventArgs e)
        {
            this.BackColor = DarkTheme.BgPrincipal;
            this.ForeColor = DarkTheme.TextPrimary;
            DarkTheme.StyleDataGridView(dgUtilisateur);
            ResetForm();
        }

        private void ResetForm()
        {
            dgUtilisateur.DataSource = db.Utilisateurs.Select(a => new
            {
                a.IdUtilisateur,
                a.NomUtilisateur,
                a.EmailUtilisateur
            }).ToList();
            txtNomUtilisateur.Clear();
            txtMotDePasse.Clear();
            cbbRole.SelectedIndex = -1;
            txtNomUtilisateur.Focus();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNomUtilisateur.Text)) { MessageBox.Show("Le nom est requis.", "Attention"); return; }
            var u = new Utilisateur
            {
                NomUtilisateur = txtNomUtilisateur.Text,
                PrenomUtilisateur = "",
                TelUtilisateur = "",
                EmailUtilisateur = txtNomUtilisateur.Text + "@univ.sn",
                MotDePasse = Crypted.GetMd5Hash(MD5.Create(), txtMotDePasse.Text)
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
                if (!string.IsNullOrWhiteSpace(txtMotDePasse.Text))
                    u.MotDePasse = Crypted.GetMd5Hash(MD5.Create(), txtMotDePasse.Text);
                db.SaveChanges();
                ResetForm();
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dgUtilisateur.CurrentRow == null) return;
            if (MessageBox.Show("Supprimer cet utilisateur ?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.No) return;
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
