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
                var leUser = db.Utilisateurs.Where(a => a.EmailUtilisateur.ToLower() == txtIdentifiant.Text.ToLower()).FirstOrDefault();
                if (leUser != null)
                {
                    using (MD5 md5Hash = MD5.Create())
                    {
                        if (VerifyMd5Hash(md5Hash, txtMotDePasse.Text, leUser.MotDePasse))
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
            logger.WriteLogSystem("Deconnexion", "btnQuitter_Click");
            Application.Exit();
        }

        static bool VerifyMd5Hash(MD5 md5Hash, string input, string hash)
        {
            string hashOfInput = GetMd5Hash(md5Hash, input);
            StringComparer comparer = StringComparer.OrdinalIgnoreCase;
            return comparer.Compare(hashOfInput, hash) == 0;
        }

        static string GetMd5Hash(MD5 md5Hash, string input)
        {
            byte[] data = md5Hash.ComputeHash(System.Text.Encoding.UTF8.GetBytes(input));
            System.Text.StringBuilder sBuilder = new System.Text.StringBuilder();
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }
            return sBuilder.ToString();
        }
    }
}
