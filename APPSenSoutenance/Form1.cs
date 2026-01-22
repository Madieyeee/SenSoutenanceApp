using APPSenSoutenance.Models;
using APPSenSoutenance.Shared;
using System;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
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

        }

        private void btnSeConnecter_Click(object sender, EventArgs e)
        {
            try
            { 
            

            BdSenSoutenanceContext db = new BdSenSoutenanceContext();
            var leUser = db.Utilisateurs.Where(a=>a.EmailUtilisateur.ToLower()==txtIdentifiant.Text.ToLower()).FirstOrDefault();
                if (leUser != null)
                {
                    using (MD5 md5Hash = MD5.Create())
                    {
                        if (VerifyMd5Hash(md5Hash, txtPassword1.Text, hash))
                        {
                            frmMDI f = new frmMDI();
                            f.profil = db.Utilisateurs.GetType().Name;
                            f.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Identifiant ou mot de passe incorrecte");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Identifiant ou mot de passe incorrecte");
                }
            }
            catch (Exception ex)
            {
                logger.WriteDataError("FrmConnexion-btnSeConnecter_Click", ex.ToString());
            }
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
