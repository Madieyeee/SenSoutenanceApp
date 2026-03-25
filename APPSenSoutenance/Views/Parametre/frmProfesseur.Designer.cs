using APPSenSoutenance.Shared;
using System.Drawing;
using System.Windows.Forms;

namespace APPSenSoutenance.Views.Parametre
{
    partial class frmProfesseur
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
            this.lblNom = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.lblTel = new System.Windows.Forms.Label();
            this.txtTelephone = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblMdp = new System.Windows.Forms.Label();
            this.txtMotDePasse = new System.Windows.Forms.TextBox();
            this.lblSpec = new System.Windows.Forms.Label();
            this.txtSpecialite = new System.Windows.Forms.TextBox();
            
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            
            this.pnlRight = new System.Windows.Forms.Panel();
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.lblRNom = new System.Windows.Forms.Label();
            this.txtRNom = new System.Windows.Forms.TextBox();
            this.lblRSpec = new System.Windows.Forms.Label();
            this.txtRSpecialite = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgProfesseur = new System.Windows.Forms.DataGridView();
            
            this.pnlHeader.SuspendLayout();
            this.pnlLeft.SuspendLayout();
            this.pnlRight.SuspendLayout();
            this.pnlSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgProfesseur)).BeginInit();
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
            this.lblHeaderTitle.Size = new System.Drawing.Size(320, 28);
            this.lblHeaderTitle.Text = "Gestion des Professeurs";

            // lblHeaderSub
            this.lblHeaderSub.AutoSize = true;
            this.lblHeaderSub.BackColor = System.Drawing.Color.Transparent;
            this.lblHeaderSub.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblHeaderSub.ForeColor = DarkTheme.TextSecondary;
            this.lblHeaderSub.Location = new System.Drawing.Point(64, 38);
            this.lblHeaderSub.Name = "lblHeaderSub";
            this.lblHeaderSub.Size = new System.Drawing.Size(280, 15);
            this.lblHeaderSub.Text = "Ajouter, modifier et consulter les professeurs";

            // pnlLeft
            this.pnlLeft.BackColor = DarkTheme.BgCard;
            this.pnlLeft.Controls.Add(this.lblNom);
            this.pnlLeft.Controls.Add(this.txtNom);
            this.pnlLeft.Controls.Add(this.lblPrenom);
            this.pnlLeft.Controls.Add(this.txtPrenom);
            this.pnlLeft.Controls.Add(this.lblTel);
            this.pnlLeft.Controls.Add(this.txtTelephone);
            this.pnlLeft.Controls.Add(this.lblEmail);
            this.pnlLeft.Controls.Add(this.txtEmail);
            this.pnlLeft.Controls.Add(this.lblMdp);
            this.pnlLeft.Controls.Add(this.txtMotDePasse);
            this.pnlLeft.Controls.Add(this.lblSpec);
            this.pnlLeft.Controls.Add(this.txtSpecialite);
            
            this.pnlLeft.Controls.Add(this.btnSelect);
            this.pnlLeft.Controls.Add(this.btnAdd);
            this.pnlLeft.Controls.Add(this.btnEdit);
            this.pnlLeft.Controls.Add(this.btnRemove);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 72);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Padding = new System.Windows.Forms.Padding(20);
            this.pnlLeft.Size = new System.Drawing.Size(360, 628);

            // lblNom
            this.lblNom.AutoSize = true;
            this.lblNom.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblNom.ForeColor = DarkTheme.TextSecondary;
            this.lblNom.Location = new System.Drawing.Point(20, 20);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(100, 15);
            this.lblNom.Text = "NOM";

            // txtNom
            this.txtNom.BackColor = DarkTheme.BgHover;
            this.txtNom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNom.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtNom.ForeColor = DarkTheme.TextPrimary;
            this.txtNom.Location = new System.Drawing.Point(20, 45);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(320, 34);

            // lblPrenom
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblPrenom.ForeColor = DarkTheme.TextSecondary;
            this.lblPrenom.Location = new System.Drawing.Point(20, 85);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(100, 15);
            this.lblPrenom.Text = "PRÉNOM";

            // txtPrenom
            this.txtPrenom.BackColor = DarkTheme.BgHover;
            this.txtPrenom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrenom.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPrenom.ForeColor = DarkTheme.TextPrimary;
            this.txtPrenom.Location = new System.Drawing.Point(20, 110);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(320, 34);

            // lblTel
            this.lblTel.AutoSize = true;
            this.lblTel.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblTel.ForeColor = DarkTheme.TextSecondary;
            this.lblTel.Location = new System.Drawing.Point(20, 150);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(100, 15);
            this.lblTel.Text = "TÉLÉPHONE";

            // txtTelephone
            this.txtTelephone.BackColor = DarkTheme.BgHover;
            this.txtTelephone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTelephone.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtTelephone.ForeColor = DarkTheme.TextPrimary;
            this.txtTelephone.Location = new System.Drawing.Point(20, 175);
            this.txtTelephone.Name = "txtTelephone";
            this.txtTelephone.Size = new System.Drawing.Size(320, 34);

            // lblEmail
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblEmail.ForeColor = DarkTheme.TextSecondary;
            this.lblEmail.Location = new System.Drawing.Point(20, 215);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(100, 15);
            this.lblEmail.Text = "EMAIL";

            // txtEmail
            this.txtEmail.BackColor = DarkTheme.BgHover;
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtEmail.ForeColor = DarkTheme.TextPrimary;
            this.txtEmail.Location = new System.Drawing.Point(20, 240);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(320, 34);

            // lblMdp
            this.lblMdp.AutoSize = true;
            this.lblMdp.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblMdp.ForeColor = DarkTheme.TextSecondary;
            this.lblMdp.Location = new System.Drawing.Point(20, 280);
            this.lblMdp.Name = "lblMdp";
            this.lblMdp.Size = new System.Drawing.Size(120, 15);
            this.lblMdp.Text = "MOT DE PASSE";

            // txtMotDePasse
            this.txtMotDePasse.BackColor = DarkTheme.BgHover;
            this.txtMotDePasse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMotDePasse.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtMotDePasse.ForeColor = DarkTheme.TextPrimary;
            this.txtMotDePasse.Location = new System.Drawing.Point(20, 305);
            this.txtMotDePasse.Name = "txtMotDePasse";
            this.txtMotDePasse.Size = new System.Drawing.Size(320, 34);
            this.txtMotDePasse.UseSystemPasswordChar = true;

            // lblSpec
            this.lblSpec.AutoSize = true;
            this.lblSpec.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblSpec.ForeColor = DarkTheme.TextSecondary;
            this.lblSpec.Location = new System.Drawing.Point(20, 345);
            this.lblSpec.Name = "lblSpec";
            this.lblSpec.Size = new System.Drawing.Size(100, 15);
            this.lblSpec.Text = "SPÉCIALITÉ";

            // txtSpecialite
            this.txtSpecialite.BackColor = DarkTheme.BgHover;
            this.txtSpecialite.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSpecialite.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSpecialite.ForeColor = DarkTheme.TextPrimary;
            this.txtSpecialite.Location = new System.Drawing.Point(20, 370);
            this.txtSpecialite.Name = "txtSpecialite";
            this.txtSpecialite.Size = new System.Drawing.Size(320, 34);

            // btnSelect
            this.btnSelect.BackColor = Color.FromArgb(16, 185, 129); // Emerald
            this.btnSelect.FlatAppearance.BorderSize = 0;
            this.btnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelect.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSelect.ForeColor = Color.White;
            this.btnSelect.Location = new System.Drawing.Point(20, 420);
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
            this.btnAdd.Location = new System.Drawing.Point(20, 460);
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
            this.btnEdit.Location = new System.Drawing.Point(20, 510);
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
            this.btnRemove.Location = new System.Drawing.Point(185, 510);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(155, 40);
            this.btnRemove.Text = "Supprimer";
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);

            // pnlRight
            this.pnlRight.BackColor = DarkTheme.BgPrincipal;
            this.pnlRight.Controls.Add(this.dgProfesseur);
            this.pnlRight.Controls.Add(this.pnlSearch);
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRight.Location = new System.Drawing.Point(360, 72);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Padding = new System.Windows.Forms.Padding(16);

            // pnlSearch
            this.pnlSearch.BackColor = DarkTheme.BgCard;
            this.pnlSearch.Controls.Add(this.lblRNom);
            this.pnlSearch.Controls.Add(this.txtRNom);
            this.pnlSearch.Controls.Add(this.lblRSpec);
            this.pnlSearch.Controls.Add(this.txtRSpecialite);
            this.pnlSearch.Controls.Add(this.btnSearch);
            this.pnlSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSearch.Height = 80;
            this.pnlSearch.Padding = new System.Windows.Forms.Padding(10);
            this.pnlSearch.Name = "pnlSearch";

            // lblRNom
            this.lblRNom.Text = "Chercher Nom";
            this.lblRNom.ForeColor = DarkTheme.TextSecondary;
            this.lblRNom.Location = new System.Drawing.Point(10, 15);
            this.lblRNom.AutoSize = true;

            // txtRNom
            this.txtRNom.BackColor = DarkTheme.BgHover;
            this.txtRNom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRNom.ForeColor = DarkTheme.TextPrimary;
            this.txtRNom.Location = new System.Drawing.Point(10, 35);
            this.txtRNom.Width = 200;
            this.txtRNom.Name = "txtRNom";

            // lblRSpec
            this.lblRSpec.Text = "Chercher Spécialité";
            this.lblRSpec.ForeColor = DarkTheme.TextSecondary;
            this.lblRSpec.Location = new System.Drawing.Point(220, 15);
            this.lblRSpec.AutoSize = true;

            // txtRSpecialite
            this.txtRSpecialite.BackColor = DarkTheme.BgHover;
            this.txtRSpecialite.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRSpecialite.ForeColor = DarkTheme.TextPrimary;
            this.txtRSpecialite.Location = new System.Drawing.Point(220, 35);
            this.txtRSpecialite.Width = 200;
            this.txtRSpecialite.Name = "txtRSpecialite";

            // btnSearch
            this.btnSearch.BackColor = DarkTheme.Amber;
            this.btnSearch.ForeColor = Color.White;
            this.btnSearch.Text = "🔍 Rechercher";
            this.btnSearch.Location = new System.Drawing.Point(430, 30);
            this.btnSearch.Width = 140;
            this.btnSearch.Height = 35;
            this.btnSearch.FlatStyle = FlatStyle.Flat;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);

            // dgProfesseur
            this.dgProfesseur.AllowUserToAddRows = false;
            this.dgProfesseur.AllowUserToDeleteRows = false;
            this.dgProfesseur.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgProfesseur.BackgroundColor = DarkTheme.BgPrincipal;
            this.dgProfesseur.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgProfesseur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProfesseur.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgProfesseur.Location = new System.Drawing.Point(16, 96);
            this.dgProfesseur.Name = "dgProfesseur";
            this.dgProfesseur.ReadOnly = true;
            this.dgProfesseur.RowHeadersVisible = false;

            // frmProfesseur
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = DarkTheme.BgPrincipal;
            this.ClientSize = new System.Drawing.Size(1100, 700);
            this.Controls.Add(this.pnlRight);
            this.Controls.Add(this.pnlLeft);
            this.Controls.Add(this.pnlHeader);
            this.Name = "frmProfesseur";
            this.Text = "Professeurs";
            
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlLeft.ResumeLayout(false);
            this.pnlLeft.PerformLayout();
            this.pnlRight.ResumeLayout(false);
            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgProfesseur)).EndInit();
            this.ResumeLayout(false);
        }
        #endregion

        private APPSenSoutenance.Shared.GradientPanel pnlHeader;
        private System.Windows.Forms.Label lblHeaderTitle;
        private System.Windows.Forms.Label lblHeaderSub;
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.Panel pnlSearch;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.TextBox txtTelephone;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblMdp;
        private System.Windows.Forms.TextBox txtMotDePasse;
        private System.Windows.Forms.Label lblSpec;
        private System.Windows.Forms.TextBox txtSpecialite;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.DataGridView dgProfesseur;
        private System.Windows.Forms.TextBox txtRNom;
        private System.Windows.Forms.TextBox txtRSpecialite;
        private System.Windows.Forms.Label lblRNom;
        private System.Windows.Forms.Label lblRSpec;
        private System.Windows.Forms.Button btnSearch;
    }
}