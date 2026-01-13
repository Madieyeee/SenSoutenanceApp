using APPSenSoutenance.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace APPSenSoutenance
{
    public partial class FrmConnexion : Form
    {
        public FrmConnexion()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                // On force l'initialisation de la base de données au démarrage.
                // Cette simple requête va déclencher la création et la migration de la BDD.
                using (var db = new BdSenSoutenanceContext())
                {
                    var userCount = db.Utilisateurs.Count();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Une erreur est survenue lors de la création ou de la migration de la base de données.\n\nErreur : {ex.ToString()}", "Erreur d'initialisation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        private void btnSeConnecter_Click(object sender, EventArgs e)
        {
            frmMDI f = new frmMDI();
            f.profil = "Admin";
            f.Show();
            this.Hide();
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
