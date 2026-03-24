using APPSenSoutenance.Models;
using APPSenSoutenance.Shared;
using System;
using System.Linq;
using System.Windows.Forms;

namespace APPSenSoutenance.Views.Parametre
{
    public partial class frmChefDepartement : Form
    {
        public frmChefDepartement()
        {
            InitializeComponent();
            this.Load += new EventHandler(frmChefDepartement_Load);
        }

        BdSenSoutenanceContext db = new BdSenSoutenanceContext();

        private void frmChefDepartement_Load(object sender, EventArgs e)
        {
            this.BackColor = DarkTheme.BgPrincipal;
            DarkTheme.StyleDataGridView(dataGridView1);
            RefreshGrid();
        }

        private void RefreshGrid()
        {
            dataGridView1.DataSource = db.ChefDepartements.Select(cd => new
            {
                cd.IdUtilisateur,
                cd.NomUtilisateur,
                cd.PrenomUtilisateur,
                cd.IdDepartement
            }).ToList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Fonctionnalité en cours de développement.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Fonctionnalité en cours de développement.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null) return;
            MessageBox.Show("Fonctionnalité en cours de développement.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Legacy handlers
        private void txtNom_TextChanged(object sender, EventArgs e) { }
        private void txtPrenom_TextChanged(object sender, EventArgs e) { }
        private void txtTelephone_TextChanged(object sender, EventArgs e) { }
        private void txtMail_TextChanged(object sender, EventArgs e) { }
        private void cbbDepartement_SelectedIndexChanged(object sender, EventArgs e) { }
    }
}
