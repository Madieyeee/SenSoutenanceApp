using APPSenSoutenance.Models;
using APPSenSoutenance.Shared;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
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
            InitializeCustomStyles();
        }

        private void InitializeCustomStyles()
        {
            // Ajouter des bordures personnalisées aux TextBox
            txtIdentifiant.Paint += DrawTextBoxBorder;
            txtMotDePasse.Paint += DrawTextBoxBorder;

            // Ajouter des effets hover aux boutons
            btnSeConnecter.MouseEnter += (s, e) => btnSeConnecter.BackColor = Color.FromArgb(41, 128, 185);
            btnSeConnecter.MouseLeave += (s, e) => btnSeConnecter.BackColor = Color.FromArgb(52, 152, 219);

            btnQuitter.MouseEnter += (s, e) => btnQuitter.BackColor = Color.FromArgb(149, 165, 166);
            btnQuitter.MouseLeave += (s, e) => btnQuitter.BackColor = Color.FromArgb(189, 195, 199);

            // Ajouter une ombre portée au panel de connexion
            panelConnexion.Paint += DrawPanelShadow;

            // Arrondir les coins du panel de connexion
            panelConnexion.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panelConnexion.Width, panelConnexion.Height, 15, 15));
        }

        private void DrawTextBoxBorder(object sender, PaintEventArgs e)
        {
            TextBox txt = sender as TextBox;
            if (txt != null)
            {
                using (Pen pen = new Pen(Color.FromArgb(189, 195, 199), 2))
                {
                    e.Graphics.DrawRectangle(pen, 0, 0, txt.Width - 1, txt.Height - 1);
                }
            }
        }

        private void DrawPanelShadow(object sender, PaintEventArgs e)
        {
            Panel panel = sender as Panel;
            if (panel != null)
            {
                // Dessiner une ombre portée subtile
                using (GraphicsPath path = new GraphicsPath())
                {
                    path.AddRectangle(new Rectangle(5, 5, panel.Width - 5, panel.Height - 5));
                    using (PathGradientBrush brush = new PathGradientBrush(path))
                    {
                        brush.CenterColor = Color.Transparent;
                        brush.SurroundColors = new Color[] { Color.FromArgb(30, 0, 0, 0) };
                    }
                }
            }
        }

        [System.Runtime.InteropServices.DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

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
                            f.profil = leUser.GetType().Name;
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
                MessageBox.Show("Erreur: " + ex.Message + "\n\n" + ex.ToString(), "Erreur de connexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void panelRight_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
