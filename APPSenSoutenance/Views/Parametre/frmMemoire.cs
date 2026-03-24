using APPSenSoutenance.Models;
using APPSenSoutenance.Shared;
using System;
using System.Linq;
using System.Windows.Forms;

namespace APPSenSoutenance.Views.Parametre
{
    public partial class frmMemoire : Form
    {
        public frmMemoire()
        {
            InitializeComponent();
            this.Load += new EventHandler(frmMemoire_Load);
        }

        BdSenSoutenanceContext db = new BdSenSoutenanceContext();

        private void frmMemoire_Load(object sender, EventArgs e)
        {
            this.BackColor = DarkTheme.BgPrincipal;
            DarkTheme.StyleDataGridView(dataGridView1);
            RefreshGrid();
        }

        private void RefreshGrid()
        {
            dataGridView1.DataSource = db.Memoires.Select(m => new
            {
                m.IdMemoire,
                m.SujetMemoire,
                m.IdAnneeAcademique,
                m.IdSession
            }).ToList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSujet.Text)) { MessageBox.Show("Le sujet est requis.", "Attention"); return; }
            MessageBox.Show("Fonctionnalité en cours de développement.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null) return;
            MessageBox.Show("Fonctionnalité en cours de développement.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null) return;
            int id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            var m = db.Memoires.Find(id);
            if (m != null)
            {
                db.Memoires.Remove(m);
                db.SaveChanges();
                RefreshGrid();
            }
        }

        private void btnParcourir_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "PDF files (*.pdf)|*.pdf|All files (*.*)|*.*";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    txtDocumentDuMemoire.Text = ofd.FileName;
                }
            }
        }

        // Legacy handlers
        private void txtSujet_TextChanged(object sender, EventArgs e) { }
        private void cbbAnneeAcademique_SelectedIndexChanged(object sender, EventArgs e) { }
        private void cbbSession_SelectedIndexChanged(object sender, EventArgs e) { }
        private void txtDocumentDuMemoire_TextChanged(object sender, EventArgs e) { }
    }
}
