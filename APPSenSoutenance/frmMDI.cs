using APPSenSoutenance.Views.Parametre;
using APPSenSoutenance.Shared;
using APPSenSoutenance.Views.Account;
using Microsoft.VisualBasic.Devices;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace APPSenSoutenance
{
    public partial class frmMDI : Form
    {
        public string profil;
        private Button _activeNavBtn = null;

        public frmMDI()
        {
            InitializeComponent();
        }

        // ── Navigation helper ─────────────────────────────────────────
        private void SetActiveButton(Button btn)
        {
            if (_activeNavBtn != null)
                _activeNavBtn.BackColor = Color.Transparent;
            _activeNavBtn = btn;
            if (_activeNavBtn != null)
                _activeNavBtn.BackColor = Color.FromArgb(40, 217, 119, 6);
        }

        private void OpenForm(Form frm, Button navBtn)
        {
            try
            {
                // Nettoyer le conteneur principal
                pnlMdiContainer.Controls.Clear();
                
                // Configurer le formulaire pour l'insertion
                frm.TopLevel = false;
                frm.FormBorderStyle = FormBorderStyle.None;
                frm.Dock = DockStyle.Fill;
                
                // Ajouter et afficher
                pnlMdiContainer.Controls.Add(frm);
                frm.Show();
                
                SetActiveButton(navBtn);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de l'ouverture du formulaire : " + ex.Message);
            }
        }

        private void fermer()
        {
            pnlMdiContainer.Controls.Clear();
        }

        // ── Chargement ───────────────────────────────────────────────
        private void frmMDI_Load(object sender, EventArgs e)
        {
            // Maximiser la fenêtre principal
            this.WindowState = FormWindowState.Maximized;

            // Masquer sécurité sauf Admin ou Utilisateur identifié
            btnUtilisateur.Visible = false;
            // Pour le moment on autorise l'affichage si profil est Utilisateur ou Admin
            if (profil == "Admin" || profil == "Utilisateur" || profil.Contains("Proxy"))
                btnUtilisateur.Visible = true;

            // Mise à jour heure
            timerClock.Start();
            UpdateClock();
        }

        private void UpdateClock()
        {
            lblClock.Text = DateTime.Now.ToString("HH:mm");
            lblDate.Text  = DateTime.Now.ToString("dddd d MMMM", new System.Globalization.CultureInfo("fr-FR"));
        }

        private void timerClock_Tick(object sender, EventArgs e) => UpdateClock();

        // ── Navigation ───────────────────────────────────────────────
        private void btnAnneeAcademique_Click(object sender, EventArgs e)   => OpenForm(new frmAnneeAcademique(), (Button)sender);
        private void btnSession_Click(object sender, EventArgs e)           => OpenForm(new frmSession(), (Button)sender);
        private void btnProfesseur_Click(object sender, EventArgs e)
        {
            try { OpenForm(new frmProfesseur(), (Button)sender); }
            catch (Exception ex) { MessageBox.Show("Erreur critique: " + ex.Message + "\n" + ex.StackTrace); }
        }
        private void btnSoutenance_Click(object sender, EventArgs e)        => OpenForm(new frmSoutenance(), (Button)sender);
        private void btnMemoire_Click(object sender, EventArgs e)           => OpenForm(new frmMemoire(), (Button)sender);
        private void btnChefDepartement_Click(object sender, EventArgs e)   => OpenForm(new frmChefDepartement(), (Button)sender);
        private void btnDepartement_Click(object sender, EventArgs e)       => OpenForm(new frmDepartement(), (Button)sender);
        private void btnUtilisateur_Click(object sender, EventArgs e)       => OpenForm(new frmUtilisateur(), (Button)sender);

        private void btnDeconnexion_Click(object sender, EventArgs e)
        {
            fermer();
            new FrmConnexion().Show();
            this.Close();
        }

        private void btnQuitter_Click(object sender, EventArgs e) => Application.Exit();
    }
}
