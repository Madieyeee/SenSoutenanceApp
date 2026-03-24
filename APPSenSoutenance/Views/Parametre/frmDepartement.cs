using APPSenSoutenance.Shared;
using System;
using System.Windows.Forms;

namespace APPSenSoutenance.Views.Parametre
{
    public partial class frmDepartement : Form
    {
        public frmDepartement()
        {
            InitializeComponent();
            this.Load += new EventHandler(frmDepartement_Load);
        }

        private void frmDepartement_Load(object sender, EventArgs e)
        {
            this.BackColor = DarkTheme.BgPrincipal;
            DarkTheme.StyleDataGridView(dataGridView1);
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
            MessageBox.Show("Fonctionnalité en cours de développement.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void txtLeDepartement_TextChanged(object sender, EventArgs e) { }
    }
}
