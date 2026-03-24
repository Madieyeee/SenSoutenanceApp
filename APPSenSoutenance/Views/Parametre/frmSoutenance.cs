using APPSenSoutenance.Models;
using APPSenSoutenance.Shared;
using System;
using System.Linq;
using System.Windows.Forms;

namespace APPSenSoutenance.Views.Parametre
{
    public partial class frmSoutenance : Form
    {
        public frmSoutenance()
        {
            InitializeComponent();
            this.Load += new EventHandler(frmSoutenance_Load);
        }

        BdSenSoutenanceContext db = new BdSenSoutenanceContext();

        private void frmSoutenance_Load(object sender, EventArgs e)
        {
            this.BackColor = DarkTheme.BgPrincipal;
            DarkTheme.StyleDataGridView(dataGridView1);

            // Remplir les ComboBox
            cbbMemoire.DataSource = db.Memoires.Select(m => new { m.IdMemoire, m.SujetMemoire }).ToList();
            cbbMemoire.DisplayMember = "SujetMemoire";
            cbbMemoire.ValueMember = "IdMemoire";

            RefreshGrid();
        }

        private void RefreshGrid()
        {
            dataGridView1.DataSource = db.Soutenances.ToList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // TODO: Logique d'ajout - à compléter selon le modèle
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            // TODO: Logique de modification
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null) return;
            // TODO: Logique de suppression
        }

        // Legacy event handlers
        private void cbbDateSoutenance_SelectedIndexChanged(object sender, EventArgs e) { }
        private void txtLieuSoutenance_TextChanged(object sender, EventArgs e) { }
        private void txtResultatSoutenance_TextChanged(object sender, EventArgs e) { }
        private void txtMentionSoutenance_TextChanged(object sender, EventArgs e) { }
        private void txtObservation_TextChanged(object sender, EventArgs e) { }
        private void cbbMemoire_SelectedIndexChanged(object sender, EventArgs e) { }
    }
}
