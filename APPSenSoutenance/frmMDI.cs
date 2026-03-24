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
            fermer();
            frm.MdiParent = this;
            frm.Show();
            frm.WindowState = FormWindowState.Maximized;
            SetActiveButton(navBtn);
        }

        private void fermer()
        {
            foreach (Form f in this.MdiChildren)
            {
                f.WindowState = FormWindowState.Maximized;
                f.Close();
            }
        }

        // ── Chargement ───────────────────────────────────────────────
        private void frmMDI_Load(object sender, EventArgs e)
        {
            // Masquer sécurité sauf Admin
            btnUtilisateur.Visible = false;
            if (profil == "Admin")
                btnUtilisateur.Visible = true;

            Computer myComputer = new Computer();
            this.Width  = myComputer.Screen.Bounds.Width;
            this.Height = myComputer.Screen.Bounds.Height;
            this.Location = new Point(0, 0);

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
        private void btnProfesseur_Click(object sender, EventArgs e)        => OpenForm(new frmProfesseur(), (Button)sender);
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
