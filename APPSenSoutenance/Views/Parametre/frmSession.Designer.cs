using APPSenSoutenance.Shared;
using System.Drawing;
using System.Windows.Forms;

namespace APPSenSoutenance.Views.Parametre
{
    partial class frmSession
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.pnlHeader = new APPSenSoutenance.Shared.GradientPanel();
            this.lblHeaderTitle = new System.Windows.Forms.Label();
            this.lblHeaderSub = new System.Windows.Forms.Label();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.lblSession = new System.Windows.Forms.Label();
            this.txtSession = new System.Windows.Forms.TextBox();
            this.lblAnnee = new System.Windows.Forms.Label();
            this.cbbAnneeAcademique = new System.Windows.Forms.ComboBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.txtRSession = new System.Windows.Forms.TextBox();
            this.txtRanneeAcademique = new System.Windows.Forms.TextBox();
            this.lblRSession = new System.Windows.Forms.Label();
            this.lblRAnnee = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgSession = new System.Windows.Forms.DataGridView();
            this.pnlHeader.SuspendLayout();
            this.pnlLeft.SuspendLayout();
            this.pnlRight.SuspendLayout();
            this.pnlSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSession)).BeginInit();
            this.SuspendLayout();

            // pnlHeader
            this.pnlHeader.Controls.Add(this.lblHeaderTitle);
            this.pnlHeader.Controls.Add(this.lblHeaderSub);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.GradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(18)))), ((int)(((byte)(16)))));
            this.pnlHeader.GradientStart = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(25)))), ((int)(((byte)(23)))));
            this.pnlHeader.Height = 72;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1100, 72);

            // lblHeaderTitle
            this.lblHeaderTitle.AutoSize = true;
            this.lblHeaderTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblHeaderTitle.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblHeaderTitle.ForeColor = DarkTheme.TextTitle;
            this.lblHeaderTitle.Location = new System.Drawing.Point(62, 10);
            this.lblHeaderTitle.Name = "lblHeaderTitle";
            this.lblHeaderTitle.Size = new System.Drawing.Size(217, 41);
            this.lblHeaderTitle.Text = "Gestion des Sessions";

            // lblHeaderSub
            this.lblHeaderSub.AutoSize = true;
            this.lblHeaderSub.BackColor = System.Drawing.Color.Transparent;
            this.lblHeaderSub.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblHeaderSub.ForeColor = DarkTheme.TextSecondary;
            this.lblHeaderSub.Location = new System.Drawing.Point(64, 38);
            this.lblHeaderSub.Name = "lblHeaderSub";
            this.lblHeaderSub.Size = new System.Drawing.Size(350, 25);
            this.lblHeaderSub.Text = "Définition des périodes de soutenance";

            // pnlLeft
            this.pnlLeft.BackColor = DarkTheme.BgCard;
            this.pnlLeft.Controls.Add(this.lblSession);
            this.pnlLeft.Controls.Add(this.txtSession);
            this.pnlLeft.Controls.Add(this.lblAnnee);
            this.pnlLeft.Controls.Add(this.cbbAnneeAcademique);
            this.pnlLeft.Controls.Add(this.btnSelect);
            this.pnlLeft.Controls.Add(this.btnAdd);
            this.pnlLeft.Controls.Add(this.btnEdit);
            this.pnlLeft.Controls.Add(this.btnRemove);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 72);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Padding = new System.Windows.Forms.Padding(20);
            this.pnlLeft.Size = new System.Drawing.Size(360, 628);

            // lblSession
            this.lblSession.AutoSize = true;
            this.lblSession.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblSession.ForeColor = DarkTheme.TextSecondary;
            this.lblSession.Location = new System.Drawing.Point(20, 20);
            this.lblSession.Name = "lblSession";
            this.lblSession.Size = new System.Drawing.Size(142, 23);
            this.lblSession.Text = "NOM SESSION";

            // txtSession
            this.txtSession.BackColor = DarkTheme.BgHover;
            this.txtSession.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSession.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSession.ForeColor = DarkTheme.TextPrimary;
            this.txtSession.Location = new System.Drawing.Point(20, 45);
            this.txtSession.Name = "txtSession";
            this.txtSession.Size = new System.Drawing.Size(320, 34);
            this.txtSession.TabIndex = 1;

            // lblAnnee
            this.lblAnnee.AutoSize = true;
            this.lblAnnee.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblAnnee.ForeColor = DarkTheme.TextSecondary;
            this.lblAnnee.Location = new System.Drawing.Point(20, 95);
            this.lblAnnee.Name = "lblAnnee";
            this.lblAnnee.Size = new System.Drawing.Size(182, 23);
            this.lblAnnee.Text = "ANNÉE ACADÉMIQUE";

            // cbbAnneeAcademique
            this.cbbAnneeAcademique.BackColor = DarkTheme.BgHover;
            this.cbbAnneeAcademique.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbbAnneeAcademique.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbbAnneeAcademique.ForeColor = DarkTheme.TextPrimary;
            this.cbbAnneeAcademique.Location = new System.Drawing.Point(20, 120);
            this.cbbAnneeAcademique.Name = "cbbAnneeAcademique";
            this.cbbAnneeAcademique.Size = new System.Drawing.Size(320, 36);
            this.cbbAnneeAcademique.TabIndex = 2;

            // btnSelect (Select source row)
            this.btnSelect.BackColor = Color.FromArgb(16, 185, 129); // Emerald
            this.btnSelect.FlatAppearance.BorderSize = 0;
            this.btnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelect.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSelect.ForeColor = Color.White;
            this.btnSelect.Location = new System.Drawing.Point(20, 180);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(320, 30);
            this.btnSelect.Text = "Sélectionner la ligne active";
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);

            // btnAdd
            this.btnAdd.BackColor = DarkTheme.Amber;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(20, 240);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(320, 40);
            this.btnAdd.Text = "Ajouter";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);

            // btnEdit
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(37)))), ((int)(((byte)(36)))));
            this.btnEdit.FlatAppearance.BorderSize = 1;
            this.btnEdit.FlatAppearance.BorderColor = DarkTheme.Amber;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnEdit.ForeColor = DarkTheme.Amber;
            this.btnEdit.Location = new System.Drawing.Point(20, 290);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(155, 40);
            this.btnEdit.Text = "Modifier";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);

            // btnRemove
            this.btnRemove.BackColor = DarkTheme.Danger;
            this.btnRemove.FlatAppearance.BorderSize = 0;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnRemove.ForeColor = System.Drawing.Color.White;
            this.btnRemove.Location = new System.Drawing.Point(185, 290);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(155, 40);
            this.btnRemove.Text = "Supprimer";
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);

            // pnlRight
            this.pnlRight.BackColor = DarkTheme.BgPrincipal;
            this.pnlRight.Controls.Add(this.dgSession);
            this.pnlRight.Controls.Add(this.pnlSearch);
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRight.Location = new System.Drawing.Point(360, 72);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Padding = new System.Windows.Forms.Padding(16);

            // pnlSearch
            this.pnlSearch.BackColor = DarkTheme.BgCard;
            this.pnlSearch.Controls.Add(this.lblRSession);
            this.pnlSearch.Controls.Add(this.txtRSession);
            this.pnlSearch.Controls.Add(this.lblRAnnee);
            this.pnlSearch.Controls.Add(this.txtRanneeAcademique);
            this.pnlSearch.Controls.Add(this.btnSearch);
            this.pnlSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSearch.Height = 80;
            this.pnlSearch.Padding = new System.Windows.Forms.Padding(10);
            this.pnlSearch.Name = "pnlSearch";

            // txtRSession
            this.txtRSession.BackColor = DarkTheme.BgHover;
            this.txtRSession.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRSession.ForeColor = DarkTheme.TextPrimary;
            this.txtRSession.Location = new System.Drawing.Point(10, 35);
            this.txtRSession.Width = 200;
            this.txtRSession.Name = "txtRSession";

            // txtRanneeAcademique
            this.txtRanneeAcademique.BackColor = DarkTheme.BgHover;
            this.txtRanneeAcademique.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRanneeAcademique.ForeColor = DarkTheme.TextPrimary;
            this.txtRanneeAcademique.Location = new System.Drawing.Point(220, 35);
            this.txtRanneeAcademique.Width = 200;
            this.txtRanneeAcademique.Name = "txtRanneeAcademique";

            // lblRSession
            this.lblRSession.Text = "Chercher Session";
            this.lblRSession.ForeColor = DarkTheme.TextSecondary;
            this.lblRSession.Location = new System.Drawing.Point(10, 15);
            this.lblRSession.AutoSize = true;

            // lblRAnnee
            this.lblRAnnee.Text = "Chercher Année";
            this.lblRAnnee.ForeColor = DarkTheme.TextSecondary;
            this.lblRAnnee.Location = new System.Drawing.Point(220, 15);
            this.lblRAnnee.AutoSize = true;

            // btnSearch
            this.btnSearch.BackColor = DarkTheme.Amber;
            this.btnSearch.ForeColor = Color.White;
            this.btnSearch.Text = "🔍 Rechercher";
            this.btnSearch.Location = new System.Drawing.Point(430, 30);
            this.btnSearch.Width = 140;
            this.btnSearch.Height = 35;
            this.btnSearch.FlatStyle = FlatStyle.Flat;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);

            // dgSession
            this.dgSession.AllowUserToAddRows = false;
            this.dgSession.AllowUserToDeleteRows = false;
            this.dgSession.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgSession.BackgroundColor = DarkTheme.BgPrincipal;
            this.dgSession.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgSession.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSession.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgSession.Location = new System.Drawing.Point(16, 96);
            this.dgSession.Name = "dgSession";
            this.dgSession.ReadOnly = true;
            this.dgSession.RowHeadersVisible = false;

            // frmSession
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = DarkTheme.BgPrincipal;
            this.ClientSize = new System.Drawing.Size(1100, 700);
            this.Controls.Add(this.pnlRight);
            this.Controls.Add(this.pnlLeft);
            this.Controls.Add(this.pnlHeader);
            this.Name = "frmSession";
            this.Text = "Sessions";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlLeft.ResumeLayout(false);
            this.pnlLeft.PerformLayout();
            this.pnlRight.ResumeLayout(false);
            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSession)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        private APPSenSoutenance.Shared.GradientPanel pnlHeader;
        private System.Windows.Forms.Label lblHeaderTitle;
        private System.Windows.Forms.Label lblHeaderSub;
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.Panel pnlSearch;
        private System.Windows.Forms.Label lblSession;
        private System.Windows.Forms.TextBox txtSession;
        private System.Windows.Forms.Label lblAnnee;
        private System.Windows.Forms.ComboBox cbbAnneeAcademique;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.DataGridView dgSession;
        private System.Windows.Forms.TextBox txtRSession;
        private System.Windows.Forms.TextBox txtRanneeAcademique;
        private System.Windows.Forms.Label lblRSession;
        private System.Windows.Forms.Label lblRAnnee;
        private System.Windows.Forms.Button btnSearch;
    }
}
