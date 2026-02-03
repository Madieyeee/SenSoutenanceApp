using AppSenSoutenance.View.Paramètre;
using APPSenSoutenance.Views.Account;
using APPSenSoutenance.Views.Parametre;
using Microsoft.VisualBasic.Devices;
using System;
using System.Drawing;
using System.Windows.Forms;

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
            securiteToolStripMenuItem.Visible = false;
            if (profil == "Admin")
            {
                securiteToolStripMenuItem.Visible = true;
            }
            Computer myComputer = new Computer();
            this.Width = myComputer.Screen.Bounds.Width;
            this.Height = myComputer.Screen.Bounds.Height;
            this.Location = new Point(0, 0);
        }

        /// <summary>
        /// Ouvre le formulaire de gestion des utilisateurs
        /// Accessible uniquement aux administrateurs
        /// </summary>
        private void utilisateurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fermer();
            frmUtilisateur f = new frmUtilisateur();
            f.MdiParent = this;
            f.Show();
            f.WindowState = FormWindowState.Maximized;

        }

        private void securiteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
