using APPSenSoutenance.Shared;
using APPSenSoutenance.Models;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Session = APPSenSoutenance.Models.Session;

namespace APPSenSoutenance.Views.Parametre
{
    public partial class frmSession : Form
    {
        public frmSession()
        {
            InitializeComponent();
            this.Load += new EventHandler(frmSession_Load);
        }

        BdSenSoutenanceContext db = new BdSenSoutenanceContext();
        FillerList filler = new FillerList();

        private void frmSession_Load(object sender, EventArgs e)
        {
            this.BackColor = DarkTheme.BgPrincipal;
            DarkTheme.StyleDataGridView(dgSession);
            Effacer();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cbbAnneeAcademique.SelectedValue == null) { MessageBox.Show("Sélectionnez une année académique.", "Attention"); return; }
            Session session = new Session();
            session.LibelleSession = txtSession.Text;
            session.IdAnneeAcademique = int.Parse(cbbAnneeAcademique.SelectedValue.ToString());
            db.Sessions.Add(session);
            db.SaveChanges();
            Effacer();
        }

        private void Effacer()
        {
            txtSession.Clear();
            dgSession.DataSource = db.Sessions.ToList();
            cbbAnneeAcademique.DataSource = filler.FillAnneeAcademique();
            cbbAnneeAcademique.DisplayMember = "Text";
            cbbAnneeAcademique.ValueMember = "Value";
            txtSession.Focus();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (dgSession.CurrentRow == null) return;
            int? id = int.Parse(dgSession.CurrentRow.Cells[0].Value.ToString());
            Session session = db.Sessions.Find(id);
            txtSession.Text = session.LibelleSession;
            cbbAnneeAcademique.SelectedValue = session.IdAnneeAcademique;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgSession.CurrentRow == null) return;
            int? id = int.Parse(dgSession.CurrentRow.Cells[0].Value.ToString());
            Session session = db.Sessions.Find(id);
            session.LibelleSession = txtSession.Text;
            session.IdAnneeAcademique = (int?)cbbAnneeAcademique.SelectedValue;
            db.SaveChanges();
            Effacer();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dgSession.CurrentRow == null) return;
            int? id = int.Parse(dgSession.CurrentRow.Cells[0].Value.ToString());
            Session session = db.Sessions.Find(id);
            db.Sessions.Remove(session);
            db.SaveChanges();
            Effacer();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var liste = db.Sessions.ToList();
            if (!string.IsNullOrEmpty(txtRSession.Text))
                liste = liste.Where(s => s.LibelleSession.Contains(txtRSession.Text)).ToList();
            if (!string.IsNullOrEmpty(txtRanneeAcademique.Text))
                liste = liste.Where(s => s.AnneeAcademique != null && s.AnneeAcademique.LibelleAnneeAcademique.Contains(txtRanneeAcademique.Text)).ToList();
            dgSession.DataSource = liste;
        }

        private void txtSession_TextChanged(object sender, EventArgs e) { }
    }
}
