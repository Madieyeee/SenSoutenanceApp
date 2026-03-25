using APPSenSoutenance.Models;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace APPSenSoutenance.Views.Parametre
{
    public partial class frmAnneeAcademique : Form
    {
        public frmAnneeAcademique()
        {
            InitializeComponent();
        }

        BdSenSoutenanceContext db = new BdSenSoutenanceContext();

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgAnneeAcademique.DataSource = db.AnneeAcademiques.ToList();
        }

        private void frmAnneeAcademique_Load(object sender, EventArgs e)
        {
            // Appliquer le style des lignes alternées au DataGridView
            dgAnneeAcademique.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(236, 240, 245);
            dgAnneeAcademique.AlternatingRowsDefaultCellStyle.ForeColor = Color.FromArgb(52, 73, 94);
            dgAnneeAcademique.DefaultCellStyle.BackColor = Color.White;
            dgAnneeAcademique.DefaultCellStyle.ForeColor = Color.FromArgb(52, 73, 94);

            // Charger les données
            Effacer();
        }

        public void Effacer()
        {
            txtLibelleAnneeAcademique.Clear();
            txtAnneeAcademiqueVal.Clear();
            dgAnneeAcademique.DataSource = db.AnneeAcademiques.ToList();
            txtLibelleAnneeAcademique.Focus();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            AnneeAcademique anneeAcademique = new AnneeAcademique
            {
                LibelleAnneeAcademique = txtLibelleAnneeAcademique.Text,
                AnneeAcademiqueVal = int.Parse(txtAnneeAcademiqueVal.Text)
            };
            db.AnneeAcademiques.Add(anneeAcademique);
            db.SaveChanges();
            Effacer();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int? id = int.Parse(dgAnneeAcademique.CurrentRow.Cells[0].Value.ToString());
            AnneeAcademique anneeAcademique = db.AnneeAcademiques.Find(id);
            anneeAcademique.LibelleAnneeAcademique = txtLibelleAnneeAcademique.Text;
            anneeAcademique.AnneeAcademiqueVal = int.Parse(txtAnneeAcademiqueVal.Text);
            db.SaveChanges();
            Effacer();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            int? id = int.Parse(dgAnneeAcademique.CurrentRow.Cells[0].Value.ToString());
            AnneeAcademique anneeAcademique = db.AnneeAcademiques.Find(id);
            db.AnneeAcademiques.Remove(anneeAcademique);
            db.SaveChanges();
            Effacer();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (dgAnneeAcademique.CurrentRow == null)
            {
                MessageBox.Show("Veuillez sélectionner une ligne.", "Attention");
                return;
            }

            txtLibelleAnneeAcademique.Text = dgAnneeAcademique.CurrentRow.Cells[1].Value.ToString();
            txtAnneeAcademiqueVal.Text = dgAnneeAcademique.CurrentRow.Cells[2].Value.ToString();
        }
    }
}