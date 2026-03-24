using APPSenSoutenance.Shared;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace APPSenSoutenance
{
    partial class frmMDI
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
            this.components = new System.ComponentModel.Container();
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.lblLogo = new System.Windows.Forms.Label();
            this.lblLogoSub = new System.Windows.Forms.Label();
            this.pnlLogoDivider = new System.Windows.Forms.Panel();
            this.lblNavSection1 = new System.Windows.Forms.Label();
            this.btnAnneeAcademique = new System.Windows.Forms.Button();
            this.btnSession = new System.Windows.Forms.Button();
            this.btnProfesseur = new System.Windows.Forms.Button();
            this.btnDepartement = new System.Windows.Forms.Button();
            this.btnChefDepartement = new System.Windows.Forms.Button();
            this.lblNavSection2 = new System.Windows.Forms.Label();
            this.btnSoutenance = new System.Windows.Forms.Button();
            this.btnMemoire = new System.Windows.Forms.Button();
            this.lblNavSection3 = new System.Windows.Forms.Label();
            this.btnUtilisateur = new System.Windows.Forms.Button();
            this.pnlSidebarFooter = new System.Windows.Forms.Panel();
            this.lblClock = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.btnDeconnexion = new System.Windows.Forms.Button();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.pnlMdiContainer = new System.Windows.Forms.Panel();
            this.timerClock = new System.Windows.Forms.Timer(this.components);
            this.pnlSidebar.SuspendLayout();
            this.pnlSidebarFooter.SuspendLayout();
            this.SuspendLayout();

            // pnlSidebar
            this.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(12)))), ((int)(((byte)(11)))));
            this.pnlSidebar.Controls.Add(this.btnUtilisateur);
            this.pnlSidebar.Controls.Add(this.lblNavSection3);
            this.pnlSidebar.Controls.Add(this.btnMemoire);
            this.pnlSidebar.Controls.Add(this.btnSoutenance);
            this.pnlSidebar.Controls.Add(this.lblNavSection2);
            this.pnlSidebar.Controls.Add(this.btnChefDepartement);
            this.pnlSidebar.Controls.Add(this.btnDepartement);
            this.pnlSidebar.Controls.Add(this.btnProfesseur);
            this.pnlSidebar.Controls.Add(this.btnSession);
            this.pnlSidebar.Controls.Add(this.btnAnneeAcademique);
            this.pnlSidebar.Controls.Add(this.lblNavSection1);
            this.pnlSidebar.Controls.Add(this.pnlLogoDivider);
            this.pnlSidebar.Controls.Add(this.lblLogoSub);
            this.pnlSidebar.Controls.Add(this.lblLogo);
            this.pnlSidebar.Controls.Add(this.pnlSidebarFooter);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Location = new System.Drawing.Point(0, 0);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(220, 800);
            this.pnlSidebar.TabIndex = 0;

            // lblLogo
            this.lblLogo.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblLogo.ForeColor = DarkTheme.Amber;
            this.lblLogo.Location = new System.Drawing.Point(0, 18);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(220, 42);
            this.lblLogo.TabIndex = 0;
            this.lblLogo.Text = "🎓 SenSoutenance";
            this.lblLogo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // lblLogoSub
            this.lblLogoSub.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblLogoSub.ForeColor = DarkTheme.TextSecondary;
            this.lblLogoSub.Location = new System.Drawing.Point(0, 58);
            this.lblLogoSub.Name = "lblLogoSub";
            this.lblLogoSub.Size = new System.Drawing.Size(220, 20);
            this.lblLogoSub.TabIndex = 1;
            this.lblLogoSub.Text = "Gestion académique";
            this.lblLogoSub.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // pnlLogoDivider
            this.pnlLogoDivider.BackColor = DarkTheme.BgBorder;
            this.pnlLogoDivider.Location = new System.Drawing.Point(20, 88);
            this.pnlLogoDivider.Name = "pnlLogoDivider";
            this.pnlLogoDivider.Size = new System.Drawing.Size(180, 1);
            this.pnlLogoDivider.TabIndex = 2;

            // lblNavSection1
            this.lblNavSection1.AutoSize = true;
            this.lblNavSection1.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold);
            this.lblNavSection1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.lblNavSection1.Location = new System.Drawing.Point(16, 106);
            this.lblNavSection1.Name = "lblNavSection1";
            this.lblNavSection1.Size = new System.Drawing.Size(89, 20);
            this.lblNavSection1.TabIndex = 3;
            this.lblNavSection1.Text = "PARAMÈTRES";

            // btnAnneeAcademique
            this.btnAnneeAcademique.FlatAppearance.BorderSize = 0;
            this.btnAnneeAcademique.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(217)))), ((int)(((byte)(119)))), ((int)(((byte)(6)))));
            this.btnAnneeAcademique.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(217)))), ((int)(((byte)(119)))), ((int)(((byte)(6)))));
            this.btnAnneeAcademique.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnneeAcademique.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnAnneeAcademique.ForeColor = DarkTheme.TextSecondary;
            this.btnAnneeAcademique.Location = new System.Drawing.Point(0, 126);
            this.btnAnneeAcademique.Name = "btnAnneeAcademique";
            this.btnAnneeAcademique.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.btnAnneeAcademique.Size = new System.Drawing.Size(220, 38);
            this.btnAnneeAcademique.TabIndex = 4;
            this.btnAnneeAcademique.Text = "📅  Année Académique";
            this.btnAnneeAcademique.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAnneeAcademique.UseVisualStyleBackColor = true;
            this.btnAnneeAcademique.Click += new System.EventHandler(this.btnAnneeAcademique_Click);

            // btnSession
            this.btnSession.FlatAppearance.BorderSize = 0;
            this.btnSession.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(217)))), ((int)(((byte)(119)))), ((int)(((byte)(6)))));
            this.btnSession.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(217)))), ((int)(((byte)(119)))), ((int)(((byte)(6)))));
            this.btnSession.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSession.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnSession.ForeColor = DarkTheme.TextSecondary;
            this.btnSession.Location = new System.Drawing.Point(0, 166);
            this.btnSession.Name = "btnSession";
            this.btnSession.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.btnSession.Size = new System.Drawing.Size(220, 38);
            this.btnSession.TabIndex = 5;
            this.btnSession.Text = "🗓  Session";
            this.btnSession.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSession.UseVisualStyleBackColor = true;
            this.btnSession.Click += new System.EventHandler(this.btnSession_Click);

            // btnProfesseur
            this.btnProfesseur.FlatAppearance.BorderSize = 0;
            this.btnProfesseur.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(217)))), ((int)(((byte)(119)))), ((int)(((byte)(6)))));
            this.btnProfesseur.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(217)))), ((int)(((byte)(119)))), ((int)(((byte)(6)))));
            this.btnProfesseur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfesseur.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnProfesseur.ForeColor = DarkTheme.TextSecondary;
            this.btnProfesseur.Location = new System.Drawing.Point(0, 206);
            this.btnProfesseur.Name = "btnProfesseur";
            this.btnProfesseur.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.btnProfesseur.Size = new System.Drawing.Size(220, 38);
            this.btnProfesseur.TabIndex = 6;
            this.btnProfesseur.Text = "👨‍🏫  Professeurs";
            this.btnProfesseur.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProfesseur.UseVisualStyleBackColor = true;
            this.btnProfesseur.Click += new System.EventHandler(this.btnProfesseur_Click);

            // btnDepartement
            this.btnDepartement.FlatAppearance.BorderSize = 0;
            this.btnDepartement.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(217)))), ((int)(((byte)(119)))), ((int)(((byte)(6)))));
            this.btnDepartement.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(217)))), ((int)(((byte)(119)))), ((int)(((byte)(6)))));
            this.btnDepartement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDepartement.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnDepartement.ForeColor = DarkTheme.TextSecondary;
            this.btnDepartement.Location = new System.Drawing.Point(0, 246);
            this.btnDepartement.Name = "btnDepartement";
            this.btnDepartement.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.btnDepartement.Size = new System.Drawing.Size(220, 38);
            this.btnDepartement.TabIndex = 7;
            this.btnDepartement.Text = "🏛  Départements";
            this.btnDepartement.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDepartement.UseVisualStyleBackColor = true;
            this.btnDepartement.Click += new System.EventHandler(this.btnDepartement_Click);

            // btnChefDepartement
            this.btnChefDepartement.FlatAppearance.BorderSize = 0;
            this.btnChefDepartement.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(217)))), ((int)(((byte)(119)))), ((int)(((byte)(6)))));
            this.btnChefDepartement.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(217)))), ((int)(((byte)(119)))), ((int)(((byte)(6)))));
            this.btnChefDepartement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChefDepartement.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnChefDepartement.ForeColor = DarkTheme.TextSecondary;
            this.btnChefDepartement.Location = new System.Drawing.Point(0, 286);
            this.btnChefDepartement.Name = "btnChefDepartement";
            this.btnChefDepartement.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.btnChefDepartement.Size = new System.Drawing.Size(220, 38);
            this.btnChefDepartement.TabIndex = 8;
            this.btnChefDepartement.Text = "👤  Chefs Dept.";
            this.btnChefDepartement.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChefDepartement.UseVisualStyleBackColor = true;
            this.btnChefDepartement.Click += new System.EventHandler(this.btnChefDepartement_Click);

            // lblNavSection2
            this.lblNavSection2.AutoSize = true;
            this.lblNavSection2.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold);
            this.lblNavSection2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.lblNavSection2.Location = new System.Drawing.Point(16, 336);
            this.lblNavSection2.Name = "lblNavSection2";
            this.lblNavSection2.Size = new System.Drawing.Size(91, 20);
            this.lblNavSection2.TabIndex = 9;
            this.lblNavSection2.Text = "ACADÉMIQUE";

            // btnSoutenance
            this.btnSoutenance.FlatAppearance.BorderSize = 0;
            this.btnSoutenance.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(217)))), ((int)(((byte)(119)))), ((int)(((byte)(6)))));
            this.btnSoutenance.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(217)))), ((int)(((byte)(119)))), ((int)(((byte)(6)))));
            this.btnSoutenance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSoutenance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnSoutenance.ForeColor = DarkTheme.TextSecondary;
            this.btnSoutenance.Location = new System.Drawing.Point(0, 356);
            this.btnSoutenance.Name = "btnSoutenance";
            this.btnSoutenance.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.btnSoutenance.Size = new System.Drawing.Size(220, 38);
            this.btnSoutenance.TabIndex = 10;
            this.btnSoutenance.Text = "🎓  Soutenances";
            this.btnSoutenance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSoutenance.UseVisualStyleBackColor = true;
            this.btnSoutenance.Click += new System.EventHandler(this.btnSoutenance_Click);

            // btnMemoire
            this.btnMemoire.FlatAppearance.BorderSize = 0;
            this.btnMemoire.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(217)))), ((int)(((byte)(119)))), ((int)(((byte)(6)))));
            this.btnMemoire.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(217)))), ((int)(((byte)(119)))), ((int)(((byte)(6)))));
            this.btnMemoire.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMemoire.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnMemoire.ForeColor = DarkTheme.TextSecondary;
            this.btnMemoire.Location = new System.Drawing.Point(0, 396);
            this.btnMemoire.Name = "btnMemoire";
            this.btnMemoire.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.btnMemoire.Size = new System.Drawing.Size(220, 38);
            this.btnMemoire.TabIndex = 11;
            this.btnMemoire.Text = "📄  Mémoires";
            this.btnMemoire.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMemoire.UseVisualStyleBackColor = true;
            this.btnMemoire.Click += new System.EventHandler(this.btnMemoire_Click);

            // lblNavSection3
            this.lblNavSection3.AutoSize = true;
            this.lblNavSection3.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold);
            this.lblNavSection3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.lblNavSection3.Location = new System.Drawing.Point(16, 446);
            this.lblNavSection3.Name = "lblNavSection3";
            this.lblNavSection3.Size = new System.Drawing.Size(68, 20);
            this.lblNavSection3.TabIndex = 12;
            this.lblNavSection3.Text = "SÉCURITÉ";

            // btnUtilisateur
            this.btnUtilisateur.FlatAppearance.BorderSize = 0;
            this.btnUtilisateur.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(217)))), ((int)(((byte)(119)))), ((int)(((byte)(6)))));
            this.btnUtilisateur.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(217)))), ((int)(((byte)(119)))), ((int)(((byte)(6)))));
            this.btnUtilisateur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUtilisateur.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnUtilisateur.ForeColor = DarkTheme.TextSecondary;
            this.btnUtilisateur.Location = new System.Drawing.Point(0, 466);
            this.btnUtilisateur.Name = "btnUtilisateur";
            this.btnUtilisateur.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.btnUtilisateur.Size = new System.Drawing.Size(220, 38);
            this.btnUtilisateur.TabIndex = 13;
            this.btnUtilisateur.Text = "🔐  Utilisateurs";
            this.btnUtilisateur.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUtilisateur.UseVisualStyleBackColor = true;
            this.btnUtilisateur.Click += new System.EventHandler(this.btnUtilisateur_Click);

            // pnlSidebarFooter
            this.pnlSidebarFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(8)))), ((int)(((byte)(7)))));
            this.pnlSidebarFooter.Controls.Add(this.btnQuitter);
            this.pnlSidebarFooter.Controls.Add(this.btnDeconnexion);
            this.pnlSidebarFooter.Controls.Add(this.lblDate);
            this.pnlSidebarFooter.Controls.Add(this.lblClock);
            this.pnlSidebarFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlSidebarFooter.Location = new System.Drawing.Point(0, 670);
            this.pnlSidebarFooter.Name = "pnlSidebarFooter";
            this.pnlSidebarFooter.Size = new System.Drawing.Size(220, 130);
            this.pnlSidebarFooter.TabIndex = 14;

            // lblClock
            this.lblClock.Font = new System.Drawing.Font("Segoe UI", 26F, System.Drawing.FontStyle.Bold);
            this.lblClock.ForeColor = DarkTheme.Amber;
            this.lblClock.Location = new System.Drawing.Point(0, 8);
            this.lblClock.Name = "lblClock";
            this.lblClock.Size = new System.Drawing.Size(220, 40);
            this.lblClock.TabIndex = 0;
            this.lblClock.Text = "00:00";
            this.lblClock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // lblDate
            this.lblDate.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblDate.ForeColor = DarkTheme.TextSecondary;
            this.lblDate.Location = new System.Drawing.Point(0, 48);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(220, 18);
            this.lblDate.TabIndex = 1;
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // btnDeconnexion
            this.btnDeconnexion.BackColor = DarkTheme.Danger;
            this.btnDeconnexion.FlatAppearance.BorderSize = 0;
            this.btnDeconnexion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeconnexion.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.btnDeconnexion.ForeColor = System.Drawing.Color.White;
            this.btnDeconnexion.Location = new System.Drawing.Point(10, 70);
            this.btnDeconnexion.Name = "btnDeconnexion";
            this.btnDeconnexion.Size = new System.Drawing.Size(95, 32);
            this.btnDeconnexion.TabIndex = 2;
            this.btnDeconnexion.Text = "⏻  Déconnexion";
            this.btnDeconnexion.UseVisualStyleBackColor = false;
            this.btnDeconnexion.Click += new System.EventHandler(this.btnDeconnexion_Click);

            // btnQuitter
            this.btnQuitter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.btnQuitter.FlatAppearance.BorderSize = 0;
            this.btnQuitter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuitter.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.btnQuitter.ForeColor = System.Drawing.Color.White;
            this.btnQuitter.Location = new System.Drawing.Point(115, 70);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(95, 32);
            this.btnQuitter.TabIndex = 3;
            this.btnQuitter.Text = "✕  Quitter";
            this.btnQuitter.UseVisualStyleBackColor = false;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);

            // pnlMdiContainer
            this.pnlMdiContainer.BackColor = DarkTheme.BgPrincipal;
            this.pnlMdiContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMdiContainer.Location = new System.Drawing.Point(220, 0);
            this.pnlMdiContainer.Name = "pnlMdiContainer";
            this.pnlMdiContainer.Size = new System.Drawing.Size(860, 800);
            this.pnlMdiContainer.TabIndex = 1;

            // timerClock
            this.timerClock.Interval = 30000;
            this.timerClock.Tick += new System.EventHandler(this.timerClock_Tick);

            // frmMDI
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = DarkTheme.BgPrincipal;
            this.ClientSize = new System.Drawing.Size(1080, 800);
            this.Controls.Add(this.pnlMdiContainer);
            this.Controls.Add(this.pnlSidebar);
            this.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.IsMdiContainer = true;
            this.Name = "frmMDI";
            this.Text = "Sen Soutenance";
            this.Load += new System.EventHandler(this.frmMDI_Load);
            this.pnlSidebar.ResumeLayout(false);
            this.pnlSidebar.PerformLayout();
            this.pnlSidebarFooter.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Label lblLogoSub;
        private System.Windows.Forms.Panel pnlLogoDivider;
        private System.Windows.Forms.Label lblNavSection1;
        private System.Windows.Forms.Button btnAnneeAcademique;
        private System.Windows.Forms.Button btnSession;
        private System.Windows.Forms.Button btnProfesseur;
        private System.Windows.Forms.Button btnDepartement;
        private System.Windows.Forms.Button btnChefDepartement;
        private System.Windows.Forms.Label lblNavSection2;
        private System.Windows.Forms.Button btnSoutenance;
        private System.Windows.Forms.Button btnMemoire;
        private System.Windows.Forms.Label lblNavSection3;
        private System.Windows.Forms.Button btnUtilisateur;
        private System.Windows.Forms.Panel pnlSidebarFooter;
        private System.Windows.Forms.Label lblClock;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Button btnDeconnexion;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.Panel pnlMdiContainer;
        private System.Windows.Forms.Timer timerClock;
    }
}