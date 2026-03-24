namespace APPSenSoutenance
{
    partial class FrmConnexion
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        private void InitializeComponent()
        {
            this.label1          = new System.Windows.Forms.Label();
            this.txtIdentifiant  = new System.Windows.Forms.TextBox();
            this.txtMotDePasse   = new System.Windows.Forms.TextBox();
            this.label2          = new System.Windows.Forms.Label();
            this.btnQuitter      = new System.Windows.Forms.Button();
            this.btnSeConnecter  = new System.Windows.Forms.Button();
            this.lblTitre        = new System.Windows.Forms.Label();
            this.lblSousTitre    = new System.Windows.Forms.Label();
            this.lblSeparateur   = new System.Windows.Forms.Label();
            this.panelConnexion  = new System.Windows.Forms.Panel();
            this.panelLeft       = new System.Windows.Forms.Panel();
            this.lblBrand        = new System.Windows.Forms.Label();
            this.lblBrandDesc    = new System.Windows.Forms.Label();
            this.panelConnexion.SuspendLayout();
            this.panelLeft.SuspendLayout();
            this.SuspendLayout();

            // ── FORM ────────────────────────────────────────────────────
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(12, 10, 9);   // #0C0A09
            this.ClientSize = new System.Drawing.Size(920, 580);
            this.ControlBox = false;
            this.Name = "FrmConnexion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sen Soutenance :: Connexion";
            this.Load += new System.EventHandler(this.Form1_Load);

            // ── PANEL GAUCHE (branding) ──────────────────────────────────
            this.panelLeft.BackColor = System.Drawing.Color.FromArgb(28, 25, 23);  // #1C1917
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Size = new System.Drawing.Size(380, 580);
            this.panelLeft.Name = "panelLeft";

            this.lblBrand.AutoSize = false;
            this.lblBrand.Text = "🎓\nSen\nSoutenance";
            this.lblBrand.Font = new System.Drawing.Font("Segoe UI", 26F, System.Drawing.FontStyle.Bold);
            this.lblBrand.ForeColor = System.Drawing.Color.FromArgb(217, 119, 6);  // Amber
            this.lblBrand.BackColor = System.Drawing.Color.Transparent;
            this.lblBrand.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblBrand.Location = new System.Drawing.Point(40, 160);
            this.lblBrand.Size = new System.Drawing.Size(300, 180);

            this.lblBrandDesc.AutoSize = false;
            this.lblBrandDesc.Text = "Plateforme de gestion\ndes soutenances académiques";
            this.lblBrandDesc.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblBrandDesc.ForeColor = System.Drawing.Color.FromArgb(168, 162, 158);  // TextSecondary
            this.lblBrandDesc.BackColor = System.Drawing.Color.Transparent;
            this.lblBrandDesc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblBrandDesc.Location = new System.Drawing.Point(40, 350);
            this.lblBrandDesc.Size = new System.Drawing.Size(300, 80);

            this.panelLeft.Controls.Add(this.lblBrand);
            this.panelLeft.Controls.Add(this.lblBrandDesc);

            // ── PANEL DROIT (connexion) ──────────────────────────────────
            this.panelConnexion.BackColor = System.Drawing.Color.FromArgb(28, 25, 23); // #1C1917
            this.panelConnexion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.panelConnexion.Location = new System.Drawing.Point(380, 0);
            this.panelConnexion.Size = new System.Drawing.Size(540, 580);
            this.panelConnexion.Name = "panelConnexion";

            // Titre connexion
            this.lblTitre.AutoSize = false;
            this.lblTitre.Text = "Connexion";
            this.lblTitre.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblTitre.ForeColor = System.Drawing.Color.FromArgb(250, 250, 249); // TextTitle
            this.lblTitre.BackColor = System.Drawing.Color.Transparent;
            this.lblTitre.Location = new System.Drawing.Point(70, 90);
            this.lblTitre.Size = new System.Drawing.Size(400, 50);

            this.lblSousTitre.AutoSize = false;
            this.lblSousTitre.Text = "Entrez vos identifiants pour accéder au système";
            this.lblSousTitre.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSousTitre.ForeColor = System.Drawing.Color.FromArgb(168, 162, 158);
            this.lblSousTitre.BackColor = System.Drawing.Color.Transparent;
            this.lblSousTitre.Location = new System.Drawing.Point(70, 145);
            this.lblSousTitre.Size = new System.Drawing.Size(400, 30);

            // Label Identifiant
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(168, 162, 158);
            this.label1.Location = new System.Drawing.Point(70, 205);
            this.label1.Name = "label1";
            this.label1.Text = "IDENTIFIANT";

            // TextBox Identifiant
            this.txtIdentifiant.BackColor = System.Drawing.Color.FromArgb(41, 37, 36); // BgHover
            this.txtIdentifiant.ForeColor = System.Drawing.Color.FromArgb(231, 229, 228);
            this.txtIdentifiant.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIdentifiant.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtIdentifiant.Location = new System.Drawing.Point(70, 235);
            this.txtIdentifiant.Name = "txtIdentifiant";
            this.txtIdentifiant.Size = new System.Drawing.Size(390, 37);
            this.txtIdentifiant.TabIndex = 1;

            // Label Mot de passe
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(168, 162, 158);
            this.label2.Location = new System.Drawing.Point(70, 295);
            this.label2.Name = "label2";
            this.label2.Text = "MOT DE PASSE";

            // TextBox Mot de passe
            this.txtMotDePasse.BackColor = System.Drawing.Color.FromArgb(41, 37, 36);
            this.txtMotDePasse.ForeColor = System.Drawing.Color.FromArgb(231, 229, 228);
            this.txtMotDePasse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMotDePasse.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtMotDePasse.Location = new System.Drawing.Point(70, 325);
            this.txtMotDePasse.Name = "txtMotDePasse";
            this.txtMotDePasse.Size = new System.Drawing.Size(390, 37);
            this.txtMotDePasse.TabIndex = 2;
            this.txtMotDePasse.UseSystemPasswordChar = true;

            // Séparateur
            this.lblSeparateur.AutoSize = false;
            this.lblSeparateur.BackColor = System.Drawing.Color.FromArgb(68, 64, 60); // BgBorder
            this.lblSeparateur.Location = new System.Drawing.Point(70, 385);
            this.lblSeparateur.Size = new System.Drawing.Size(390, 1);

            // Bouton Se connecter (Ambre)
            this.btnSeConnecter.BackColor = System.Drawing.Color.FromArgb(217, 119, 6);  // Amber
            this.btnSeConnecter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSeConnecter.FlatAppearance.BorderSize = 0;
            this.btnSeConnecter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeConnecter.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnSeConnecter.ForeColor = System.Drawing.Color.White;
            this.btnSeConnecter.Location = new System.Drawing.Point(70, 405);
            this.btnSeConnecter.Name = "btnSeConnecter";
            this.btnSeConnecter.Size = new System.Drawing.Size(240, 48);
            this.btnSeConnecter.TabIndex = 3;
            this.btnSeConnecter.Text = "Se connecter →";
            this.btnSeConnecter.UseVisualStyleBackColor = false;
            this.btnSeConnecter.Click += new System.EventHandler(this.btnSeConnecter_Click);

            // Bouton Quitter (outline discret)
            this.btnQuitter.BackColor = System.Drawing.Color.Transparent;
            this.btnQuitter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuitter.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(68, 64, 60);
            this.btnQuitter.FlatAppearance.BorderSize = 1;
            this.btnQuitter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuitter.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnQuitter.ForeColor = System.Drawing.Color.FromArgb(168, 162, 158);
            this.btnQuitter.Location = new System.Drawing.Point(325, 405);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(135, 48);
            this.btnQuitter.TabIndex = 4;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = false;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);

            // Ajout des contrôles au panel connexion
            this.panelConnexion.Controls.Add(this.lblTitre);
            this.panelConnexion.Controls.Add(this.lblSousTitre);
            this.panelConnexion.Controls.Add(this.label1);
            this.panelConnexion.Controls.Add(this.txtIdentifiant);
            this.panelConnexion.Controls.Add(this.label2);
            this.panelConnexion.Controls.Add(this.txtMotDePasse);
            this.panelConnexion.Controls.Add(this.lblSeparateur);
            this.panelConnexion.Controls.Add(this.btnSeConnecter);
            this.panelConnexion.Controls.Add(this.btnQuitter);

            // Ajout au form
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.panelConnexion);

            this.panelConnexion.ResumeLayout(false);
            this.panelLeft.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIdentifiant;
        private System.Windows.Forms.TextBox txtMotDePasse;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.Button btnSeConnecter;
        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.Label lblSousTitre;
        private System.Windows.Forms.Label lblSeparateur;
        private System.Windows.Forms.Panel panelConnexion;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.Label lblBrandDesc;
    }
}nnexion;
    }
}

