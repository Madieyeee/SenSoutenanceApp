using APPSenSoutenance.Shared;
using System.Drawing;
using System.Windows.Forms;

namespace APPSenSoutenance.Views.Account
{
    partial class frmUtilisateur
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
            this.txtNomUtilisateur = new System.Windows.Forms.TextBox();
            this.lblMdp = new System.Windows.Forms.Label();
            this.txtMotDePasse = new System.Windows.Forms.TextBox();
            this.lblRole = new System.Windows.Forms.Label();
            this.cbbRole = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.dgUtilisateur = new System.Windows.Forms.DataGridView();
            this.pnlHeader.SuspendLayout();
            this.pnlLeft.SuspendLayout();
            this.pnlRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgUtilisateur)).BeginInit();
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
            this.lblHeaderTitle.Size = new System.Drawing.Size(262, 41);
            this.lblHeaderTitle.Text = "Gestion des Utilisateurs";

            // lblHeaderSub
            this.lblHeaderSub.AutoSize = true;
            this.lblHeaderSub.BackColor = System.Drawing.Color.Transparent;
            this.lblHeaderSub.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblHeaderSub.ForeColor = DarkTheme.TextSecondary;
            this.lblHeaderSub.Location = new System.Drawing.Point(64, 38);
            this.lblHeaderSub.Name = "lblHeaderSub";
            this.lblHeaderSub.Size = new System.Drawing.Size(380, 25);
            this.lblHeaderSub.Text = "Contrôle d'accès et rôles de sécurité";

            // pnlLeft
            this.pnlLeft.BackColor = DarkTheme.BgCard;
            this.pnlLeft.Controls.Add(this.lblNom);
            this.pnlLeft.Controls.Add(this.txtNomUtilisateur);
            this.pnlLeft.Controls.Add(this.lblMdp);
            this.pnlLeft.Controls.Add(this.txtMotDePasse);
            this.pnlLeft.Controls.Add(this.lblRole);
            this.pnlLeft.Controls.Add(this.cbbRole);
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
            this.lblNom.Size = new System.Drawing.Size(161, 23);
            this.lblNom.Text = "NOM D\'UTILISATEUR";

            // txtNomUtilisateur
            this.txtNomUtilisateur.BackColor = DarkTheme.BgHover;
            this.txtNomUtilisateur.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNomUtilisateur.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtNomUtilisateur.ForeColor = DarkTheme.TextPrimary;
            this.txtNomUtilisateur.Location = new System.Drawing.Point(20, 45);
            this.txtNomUtilisateur.Name = "txtNomUtilisateur";
            this.txtNomUtilisateur.Size = new System.Drawing.Size(320, 34);
            this.txtNomUtilisateur.TabIndex = 1;

            // lblMdp
            this.lblMdp.AutoSize = true;
            this.lblMdp.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblMdp.ForeColor = DarkTheme.TextSecondary;
            this.lblMdp.Location = new System.Drawing.Point(20, 95);
            this.lblMdp.Name = "lblMdp";
            this.lblMdp.Size = new System.Drawing.Size(131, 23);
            this.lblMdp.Text = "MOT DE PASSE";

            // txtMotDePasse
            this.txtMotDePasse.BackColor = DarkTheme.BgHover;
            this.txtMotDePasse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMotDePasse.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtMotDePasse.ForeColor = DarkTheme.TextPrimary;
            this.txtMotDePasse.Location = new System.Drawing.Point(20, 120);
            this.txtMotDePasse.Name = "txtMotDePasse";
            this.txtMotDePasse.PasswordChar = '●';
            this.txtMotDePasse.Size = new System.Drawing.Size(320, 34);
            this.txtMotDePasse.TabIndex = 2;

            // lblRole
            this.lblRole.AutoSize = true;
            this.lblRole.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblRole.ForeColor = DarkTheme.TextSecondary;
            this.lblRole.Location = new System.Drawing.Point(20, 175);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(55, 23);
            this.lblRole.Text = "RÔLE";

            // cbbRole
            this.cbbRole.BackColor = DarkTheme.BgHover;
            this.cbbRole.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbbRole.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbbRole.ForeColor = DarkTheme.TextPrimary;
            this.cbbRole.Location = new System.Drawing.Point(20, 200);
            this.cbbRole.Name = "cbbRole";
            this.cbbRole.Size = new System.Drawing.Size(320, 36);
            this.cbbRole.TabIndex = 3;

            // btnAdd
            this.btnAdd.BackColor = DarkTheme.Amber;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(20, 280);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(320, 40);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Ajouter";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);

            // btnEdit
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(37)))), ((int)(((byte)(36)))));
            this.btnEdit.FlatAppearance.BorderSize = 1;
            this.btnEdit.FlatAppearance.BorderColor = DarkTheme.Amber;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnEdit.ForeColor = DarkTheme.Amber;
            this.btnEdit.Location = new System.Drawing.Point(20, 330);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(155, 40);
            this.btnEdit.TabIndex = 5;
            this.btnEdit.Text = "Modifier";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);

            // btnRemove
            this.btnRemove.BackColor = DarkTheme.Danger;
            this.btnRemove.FlatAppearance.BorderSize = 0;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnRemove.ForeColor = System.Drawing.Color.White;
            this.btnRemove.Location = new System.Drawing.Point(185, 330);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(155, 40);
            this.btnRemove.TabIndex = 6;
            this.btnRemove.Text = "Supprimer";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);

            // pnlRight
            this.pnlRight.BackColor = DarkTheme.BgPrincipal;
            this.pnlRight.Controls.Add(this.dgUtilisateur);
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRight.Location = new System.Drawing.Point(360, 72);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Padding = new System.Windows.Forms.Padding(16);
            this.pnlRight.Size = new System.Drawing.Size(740, 628);

            // dgUtilisateur
            this.dgUtilisateur.AllowUserToAddRows = false;
            this.dgUtilisateur.AllowUserToDeleteRows = false;
            this.dgUtilisateur.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgUtilisateur.BackgroundColor = DarkTheme.BgPrincipal;
            this.dgUtilisateur.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgUtilisateur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgUtilisateur.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgUtilisateur.Location = new System.Drawing.Point(16, 16);
            this.dgUtilisateur.Name = "dgUtilisateur";
            this.dgUtilisateur.ReadOnly = true;
            this.dgUtilisateur.RowHeadersVisible = false;
            this.dgUtilisateur.Size = new System.Drawing.Size(708, 596);
            this.dgUtilisateur.TabIndex = 0;

            // frmUtilisateur
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = DarkTheme.BgPrincipal;
            this.ClientSize = new System.Drawing.Size(1100, 700);
            this.Controls.Add(this.pnlRight);
            this.Controls.Add(this.pnlLeft);
            this.Controls.Add(this.pnlHeader);
            this.Name = "frmUtilisateur";
            this.Text = "Utilisateurs";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlLeft.ResumeLayout(false);
            this.pnlLeft.PerformLayout();
            this.pnlRight.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgUtilisateur)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        private APPSenSoutenance.Shared.GradientPanel pnlHeader;
        private System.Windows.Forms.Label lblHeaderTitle;
        private System.Windows.Forms.Label lblHeaderSub;
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.TextBox txtNomUtilisateur;
        private System.Windows.Forms.Label lblMdp;
        private System.Windows.Forms.TextBox txtMotDePasse;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.ComboBox cbbRole;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.DataGridView dgUtilisateur;
    }
}
