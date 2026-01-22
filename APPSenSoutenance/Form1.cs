using System;
using System.Linq;
using System.Windows.Forms;
using APPSenSoutenance.Models;

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

        }

        private void btnSeConnecter_Click(object sender, EventArgs e)
        {
            BdSenSoutenanceContext db = new BdSenSoutenanceContext();
            var leUser = db.Utilisateurs.Where(a=>a.EmailUtilisateur.ToLower()==txtIdentifiant.Text.ToLower()).FirstOrDefault();
            if (leUser != null) {
                    
            }
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
