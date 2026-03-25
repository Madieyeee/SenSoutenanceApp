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
            this.label1 = new System.Windows.Forms.Label();
            this.txtIdentifiant = new System.Windows.Forms.TextBox();
            this.txtMotDePasse = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.btnSeConnecter = new System.Windows.Forms.Button();
            this.lblTitre = new System.Windows.Forms.Label();
            this.lblSousTitre = new System.Windows.Forms.Label();
            this.lblSeparateur = new System.Windows.Forms.Label();
            this.panelConnexion = new System.Windows.Forms.Panel();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.lblBrand = new System.Windows.Forms.Label();
            this.lblBrandDesc = new System.Windows.Forms.Label();
            this.panelConnexion.SuspendLayout();
            this.panelLeft.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(162)))), ((int)(((byte)(158)))));
            this.label1.Location = new System.Drawing.Point(62, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "IDENTIFIANT";
            // 
            // txtIdentifiant
            // 
            this.txtIdentifiant.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(37)))), ((int)(((byte)(36)))));
            this.txtIdentifiant.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIdentifiant.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtIdentifiant.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(228)))));
            this.txtIdentifiant.Location = new System.Drawing.Point(62, 188);
            this.txtIdentifiant.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIdentifiant.Name = "txtIdentifiant";
            this.txtIdentifiant.Size = new System.Drawing.Size(347, 32);
            this.txtIdentifiant.TabIndex = 1;
            // 
            // txtMotDePasse
            // 
            this.txtMotDePasse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(37)))), ((int)(((byte)(36)))));
            this.txtMotDePasse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMotDePasse.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtMotDePasse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(228)))));
            this.txtMotDePasse.Location = new System.Drawing.Point(62, 260);
            this.txtMotDePasse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMotDePasse.Name = "txtMotDePasse";
            this.txtMotDePasse.Size = new System.Drawing.Size(347, 32);
            this.txtMotDePasse.TabIndex = 2;
            this.txtMotDePasse.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(162)))), ((int)(((byte)(158)))));
            this.label2.Location = new System.Drawing.Point(62, 236);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "MOT DE PASSE";
            // 
            // btnQuitter
            // 
            this.btnQuitter.BackColor = System.Drawing.Color.Transparent;
            this.btnQuitter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuitter.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(64)))), ((int)(((byte)(60)))));
            this.btnQuitter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuitter.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnQuitter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(162)))), ((int)(((byte)(158)))));
            this.btnQuitter.Location = new System.Drawing.Point(289, 324);
            this.btnQuitter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(120, 38);
            this.btnQuitter.TabIndex = 4;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = false;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // btnSeConnecter
            // 
            this.btnSeConnecter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(119)))), ((int)(((byte)(6)))));
            this.btnSeConnecter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSeConnecter.FlatAppearance.BorderSize = 0;
            this.btnSeConnecter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeConnecter.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnSeConnecter.ForeColor = System.Drawing.Color.White;
            this.btnSeConnecter.Location = new System.Drawing.Point(62, 324);
            this.btnSeConnecter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSeConnecter.Name = "btnSeConnecter";
            this.btnSeConnecter.Size = new System.Drawing.Size(213, 38);
            this.btnSeConnecter.TabIndex = 3;
            this.btnSeConnecter.Text = "Se connecter →";
            this.btnSeConnecter.UseVisualStyleBackColor = false;
            this.btnSeConnecter.Click += new System.EventHandler(this.btnSeConnecter_Click);
            // 
            // lblTitre
            // 
            this.lblTitre.BackColor = System.Drawing.Color.Transparent;
            this.lblTitre.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblTitre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(249)))));
            this.lblTitre.Location = new System.Drawing.Point(62, 72);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(356, 40);
            this.lblTitre.TabIndex = 0;
            this.lblTitre.Text = "Connexion";
            // 
            // lblSousTitre
            // 
            this.lblSousTitre.BackColor = System.Drawing.Color.Transparent;
            this.lblSousTitre.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSousTitre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(162)))), ((int)(((byte)(158)))));
            this.lblSousTitre.Location = new System.Drawing.Point(62, 116);
            this.lblSousTitre.Name = "lblSousTitre";
            this.lblSousTitre.Size = new System.Drawing.Size(356, 24);
            this.lblSousTitre.TabIndex = 1;
            this.lblSousTitre.Text = "Entrez vos identifiants pour accéder au système";
            // 
            // lblSeparateur
            // 
            this.lblSeparateur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(64)))), ((int)(((byte)(60)))));
            this.lblSeparateur.Location = new System.Drawing.Point(62, 308);
            this.lblSeparateur.Name = "lblSeparateur";
            this.lblSeparateur.Size = new System.Drawing.Size(347, 1);
            this.lblSeparateur.TabIndex = 4;
            // 
            // panelConnexion
            // 
            this.panelConnexion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(25)))), ((int)(((byte)(23)))));
            this.panelConnexion.Controls.Add(this.lblTitre);
            this.panelConnexion.Controls.Add(this.lblSousTitre);
            this.panelConnexion.Controls.Add(this.label1);
            this.panelConnexion.Controls.Add(this.txtIdentifiant);
            this.panelConnexion.Controls.Add(this.label2);
            this.panelConnexion.Controls.Add(this.txtMotDePasse);
            this.panelConnexion.Controls.Add(this.lblSeparateur);
            this.panelConnexion.Controls.Add(this.btnSeConnecter);
            this.panelConnexion.Controls.Add(this.btnQuitter);
            this.panelConnexion.Location = new System.Drawing.Point(338, 0);
            this.panelConnexion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelConnexion.Name = "panelConnexion";
            this.panelConnexion.Size = new System.Drawing.Size(480, 464);
            this.panelConnexion.TabIndex = 1;
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(25)))), ((int)(((byte)(23)))));
            this.panelLeft.Controls.Add(this.lblBrand);
            this.panelLeft.Controls.Add(this.lblBrandDesc);
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(338, 464);
            this.panelLeft.TabIndex = 0;
            // 
            // lblBrand
            // 
            this.lblBrand.BackColor = System.Drawing.Color.Transparent;
            this.lblBrand.Font = new System.Drawing.Font("Segoe UI", 26F, System.Drawing.FontStyle.Bold);
            this.lblBrand.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(119)))), ((int)(((byte)(6)))));
            this.lblBrand.Location = new System.Drawing.Point(12, 72);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(309, 200);
            this.lblBrand.TabIndex = 0;
            this.lblBrand.Text = "🎓\nSen\nSoutenance";
            this.lblBrand.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblBrand.Click += new System.EventHandler(this.lblBrand_Click);
            // 
            // lblBrandDesc
            // 
            this.lblBrandDesc.BackColor = System.Drawing.Color.Transparent;
            this.lblBrandDesc.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblBrandDesc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(162)))), ((int)(((byte)(158)))));
            this.lblBrandDesc.Location = new System.Drawing.Point(36, 280);
            this.lblBrandDesc.Name = "lblBrandDesc";
            this.lblBrandDesc.Size = new System.Drawing.Size(267, 64);
            this.lblBrandDesc.TabIndex = 1;
            this.lblBrandDesc.Text = "Plateforme de gestion\ndes soutenances académiques";
            this.lblBrandDesc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmConnexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(10)))), ((int)(((byte)(9)))));
            this.ClientSize = new System.Drawing.Size(818, 464);
            this.ControlBox = false;
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.panelConnexion);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmConnexion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sen Soutenance :: Connexion";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelConnexion.ResumeLayout(false);
            this.panelConnexion.PerformLayout();
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
}

