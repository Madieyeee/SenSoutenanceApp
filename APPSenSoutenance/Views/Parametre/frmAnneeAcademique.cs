using APPSenSoutenance.Models;
using APPSenSoutenance.Shared;
using System;
using System.Linq;
using System.Windows.Forms;

namespace APPSenSoutenance.Views.Parametre
{
    public partial class frmAnneeAcademique : Form
    {
        public frmAnneeAcademique()
        {
            InitializeComponent();
            this.Load += new EventHandler(frmAnneeAcademique_Load);
        }

        BdSenSoutenanceContext db = new BdSenSoutenanceContext();

        private void frmAnneeAcademique_Load(object sender, EventArgs e)
        {
            this.BackColor = DarkTheme.BgPrincipal;
            this.ForeColor = DarkTheme.TextPrimary;
            DarkTheme.StyleDataGridView(dgAnneeAcademique);
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
            if (string.IsNullOrWhiteSpace(txtLibelleAnneeAcademique.Text)) { MessageBox.Show("Le libellé est requis.", "Attention"); return; }
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
            if (dgAnneeAcademique.CurrentRow == null) return;
            int? id = int.Parse(dgAnneeAcademique.CurrentRow.Cells[0].Value.ToString());
            AnneeAcademique anneeAcademique = db.AnneeAcademiques.Find(id);
            anneeAcademique.LibelleAnneeAcademique = txtLibelleAnneeAcademique.Text;
            anneeAcademique.AnneeAcademiqueVal = int.Parse(txtAnneeAcademiqueVal.Text);
            db.SaveChanges();
            Effacer();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dgAnneeAcademique.CurrentRow == null) return;
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