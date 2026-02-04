using AppSenSoutenance.View.Paramètre;
using APPSenSoutenance.Views.Account;
using APPSenSoutenance.Views.Parametre;
using Microsoft.VisualBasic.Devices;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

namespace APPSenSoutenance
{
    /// <summary>
    /// Formulaire principal MDI (Multiple Document Interface) de l'application
    /// Gère l'affichage des formulaires enfants et la navigation
    /// </summary>
    public partial class frmMDI : Form

    
    {

        /// <summary>
        /// Profil de l'utilisateur connecté (Admin, User, etc.)
        /// </summary>
        
        public string profil;

        /// <summary>
        /// Initialise une nouvelle instance du formulaire MDI
        /// </summary>
        public frmMDI()
        {
            InitializeComponent();
        }

        /// <summary>
        ///Methode permettant de fermer toutes les fenetres enfants ouvertes
        ///</summary>
        private void fermer()
        {
            Form[] charr = this.MdiChildren;

            //For each child form set the window state to Maximized 
            foreach (Form chform in charr)
            {
                chform.WindowState = FormWindowState.Maximized;
                chform.Close();
            }
        }


        /// <summary>
        /// Gère la déconnexion de l'utilisateur
        /// Ferme tous les formulaires enfants et affiche l'écran de connexion
        /// </summary>
        private void seDeconnecterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fermer();
            FrmConnexion f = new FrmConnexion();
            f.Show();
            this.Close();
        }

        /// <summary>
        /// Ouvre le formulaire de gestion des années académiques
        /// </summary>
        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Ouvre le formulaire de gestion des années académiques
        /// </summary>
        private void anneeAcadmiqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fermer();
            SetActiveButton(btnParametres);
            lblPageTitle.Text = "Paramètres";
            lblBreadcrumb.Text = "Accueil > Paramètres > Année académique";
            frmAnneeAcademique f = new frmAnneeAcademique();
            f.MdiParent = this;
            f.Show();
            f.WindowState = FormWindowState.Maximized;
        }

        /// <summary>
        /// Ouvre le formulaire de gestion des sessions
        /// </summary>
        private void sessionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fermer();
            SetActiveButton(btnParametres);
            lblPageTitle.Text = "Sessions";
            lblBreadcrumb.Text = "Accueil > Paramètres > Sessions";
            frmSession f = new frmSession();
            f.MdiParent = this;
            f.Show();
            f.WindowState = FormWindowState.Maximized;
        }

        /// <summary>
        /// Ouvre le formulaire de gestion des professeurs
        /// </summary>
        private void professeurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fermer();
            SetActiveButton(btnProfesseurs);
            lblPageTitle.Text = "Gestion des Professeurs";
            lblBreadcrumb.Text = "Accueil > Professeurs";
            frmProfesseur f = new frmProfesseur();
            f.MdiParent = this;
            f.Show();
            f.WindowState = FormWindowState.Maximized;
        }


        /// <summary>
        /// Ouvre le formulaire de gestion des soutenances
        /// </summary>
        private void soutenanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fermer();
            SetActiveButton(btnSoutenances);
            lblPageTitle.Text = "Gestion des Soutenances";
            lblBreadcrumb.Text = "Accueil > Soutenances";
            frmSoutenance f = new frmSoutenance();
            f.MdiParent = this;
            f.Show();
            f.WindowState = FormWindowState.Maximized;
        }

        /// <summary>
        /// Ouvre le formulaire de gestion des mémoires
        /// </summary>
        private void memoireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fermer();
            SetActiveButton(btnMemoires);
            lblPageTitle.Text = "Gestion des Mémoires";
            lblBreadcrumb.Text = "Accueil > Mémoires";
            frmMemoire f = new frmMemoire();
            f.MdiParent = this;
            f.Show();
            f.WindowState = FormWindowState.Maximized;
        }

        /// <summary>
        /// Ouvre le formulaire de gestion des chefs de département
        /// </summary>
        private void chefDeDepartementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fermer();
            SetActiveButton(btnParametres);
            lblPageTitle.Text = "Chefs de Département";
            lblBreadcrumb.Text = "Accueil > Paramètres > Chefs de département";
            frmChefDepartement f = new frmChefDepartement();
            f.MdiParent = this;
            f.Show();
            f.WindowState = FormWindowState.Maximized;
        }

        /// <summary>
        /// Ouvre le formulaire de gestion des départements
        /// </summary>
        private void departementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fermer();
            SetActiveButton(btnDepartements);
            lblPageTitle.Text = "Gestion des Départements";
            lblBreadcrumb.Text = "Accueil > Départements";
            frmDepartement f = new frmDepartement();
            f.MdiParent = this;
            f.Show();
            f.WindowState = FormWindowState.Maximized;
        }

        /// <summary>
        /// Événement déclenché au chargement du formulaire MDI
        /// Configure la sécurité selon le profil utilisateur et ajuste la taille de la fenêtre
        /// </summary>
        private void frmMDI_Load(object sender, EventArgs e)
        {
            // Configurer les informations utilisateur
            lblUserRole.Text = profil ?? "Utilisateur";
            
            // Initialiser les effets hover pour les boutons de menu
            InitializeMenuHoverEffects();
            
            // Ajuster la taille de la fenêtre
            Computer myComputer = new Computer();
            this.Width = myComputer.Screen.Bounds.Width;
            this.Height = myComputer.Screen.Bounds.Height;
            this.Location = new Point(0, 0);
            
            // Afficher le tableau de bord par défaut
            btnDashboard_Click(null, null);
        }

        private void InitializeMenuHoverEffects()
        {
            // Liste de tous les boutons de menu
            List<Button> menuButtons = new List<Button>
            {
                btnSoutenances, btnMemoires, btnProfesseurs, 
                btnDepartements, btnParametres, btnSecurite
            };

            // Ajouter les effets hover
            foreach (var btn in menuButtons)
            {
                btn.MouseEnter += (s, e) =>
                {
                    if (btn.BackColor == Color.Transparent)
                    {
                        btn.BackColor = Color.FromArgb(52, 73, 94);
                    }
                };
                btn.MouseLeave += (s, e) =>
                {
                    if (btn.BackColor != Color.FromArgb(52, 152, 219))
                    {
                        btn.BackColor = Color.Transparent;
                    }
                };
            }

            // Effet hover pour le bouton Dashboard
            btnDashboard.MouseEnter += (s, e) => btnDashboard.BackColor = Color.FromArgb(41, 128, 185);
            btnDashboard.MouseLeave += (s, e) => btnDashboard.BackColor = Color.FromArgb(52, 152, 219);

            // Effet hover pour le bouton Déconnexion
            btnDeconnexion.MouseEnter += (s, e) => btnDeconnexion.BackColor = Color.FromArgb(192, 57, 43);
            btnDeconnexion.MouseLeave += (s, e) => btnDeconnexion.BackColor = Color.FromArgb(231, 76, 60);
        }

        private void SetActiveButton(Button activeButton)
        {
            // Réinitialiser tous les boutons
            List<Button> allButtons = new List<Button>
            {
                btnDashboard, btnSoutenances, btnMemoires, btnProfesseurs,
                btnDepartements, btnParametres, btnSecurite
            };

            foreach (var btn in allButtons)
            {
                if (btn == activeButton)
                {
                    btn.BackColor = Color.FromArgb(52, 152, 219);
                    btn.ForeColor = Color.White;
                }
                else if (btn == btnDashboard)
                {
                    btn.BackColor = Color.Transparent;
                    btn.ForeColor = Color.FromArgb(189, 195, 199);
                }
                else
                {
                    btn.BackColor = Color.Transparent;
                    btn.ForeColor = Color.FromArgb(189, 195, 199);
                }
            }

            // Garder le Dashboard actif par défaut
            if (activeButton == btnDashboard)
            {
                btnDashboard.BackColor = Color.FromArgb(52, 152, 219);
                btnDashboard.ForeColor = Color.White;
            }
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            fermer();
            SetActiveButton(btnDashboard);
            lblPageTitle.Text = "Tableau de bord";
            lblBreadcrumb.Text = "Accueil > Tableau de bord";
            // TODO: Créer et afficher le formulaire Dashboard
            // frmDashboard f = new frmDashboard();
            // f.MdiParent = this;
            // f.Show();
            // f.WindowState = FormWindowState.Maximized;
        }

        /// <summary>
        /// Ouvre le formulaire de gestion des utilisateurs
        /// Accessible uniquement aux administrateurs en theorie mais ca ne fonctionne pas encore.
        /// </summary>
        private void utilisateurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fermer();
            SetActiveButton(btnSecurite);
            lblPageTitle.Text = "Gestion des Utilisateurs";
            lblBreadcrumb.Text = "Accueil > Sécurité > Utilisateurs";
            frmUtilisateur f = new frmUtilisateur();
            f.MdiParent = this;
            f.Show();
            f.WindowState = FormWindowState.Maximized;
        }

        private void securiteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void lblBreadcrumb_Click(object sender, EventArgs e)
        {

        }
    }
}
