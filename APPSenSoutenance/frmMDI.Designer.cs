namespace APPSenSoutenance
{
    partial class frmMDI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelSidebar = new System.Windows.Forms.Panel();
            this.btnDeconnexion = new System.Windows.Forms.Button();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnSecurite = new System.Windows.Forms.Button();
            this.btnParametres = new System.Windows.Forms.Button();
            this.btnDepartements = new System.Windows.Forms.Button();
            this.btnProfesseurs = new System.Windows.Forms.Button();
            this.btnMemoires = new System.Windows.Forms.Button();
            this.btnSoutenances = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.panelUserInfo = new System.Windows.Forms.Panel();
            this.lblUserRole = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.lblAppName = new System.Windows.Forms.Label();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblBreadcrumb = new System.Windows.Forms.Label();
            this.lblPageTitle = new System.Windows.Forms.Label();
            this.panelSidebar.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.panelUserInfo.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSidebar
            // 
            this.panelSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.panelSidebar.Controls.Add(this.btnDeconnexion);
            this.panelSidebar.Controls.Add(this.panelMenu);
            this.panelSidebar.Controls.Add(this.panelUserInfo);
            this.panelSidebar.Controls.Add(this.panelLogo);
            this.panelSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSidebar.Location = new System.Drawing.Point(0, 0);
            this.panelSidebar.Name = "panelSidebar";
            this.panelSidebar.Size = new System.Drawing.Size(250, 800);
            this.panelSidebar.TabIndex = 0;
            // 
            // btnDeconnexion
            // 
            this.btnDeconnexion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnDeconnexion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeconnexion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnDeconnexion.FlatAppearance.BorderSize = 0;
            this.btnDeconnexion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeconnexion.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnDeconnexion.ForeColor = System.Drawing.Color.White;
            this.btnDeconnexion.Location = new System.Drawing.Point(0, 750);
            this.btnDeconnexion.Name = "btnDeconnexion";
            this.btnDeconnexion.Size = new System.Drawing.Size(250, 50);
            this.btnDeconnexion.TabIndex = 3;
            this.btnDeconnexion.Text = "🚺 Déconnexion";
            this.btnDeconnexion.UseVisualStyleBackColor = false;
            this.btnDeconnexion.Click += new System.EventHandler(this.seDeconnecterToolStripMenuItem_Click);
            // 
            // panelMenu
            // 
            this.panelMenu.Controls.Add(this.btnSecurite);
            this.panelMenu.Controls.Add(this.btnParametres);
            this.panelMenu.Controls.Add(this.btnDepartements);
            this.panelMenu.Controls.Add(this.btnProfesseurs);
            this.panelMenu.Controls.Add(this.btnMemoires);
            this.panelMenu.Controls.Add(this.btnSoutenances);
            this.panelMenu.Controls.Add(this.btnDashboard);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenu.Location = new System.Drawing.Point(0, 156);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Padding = new System.Windows.Forms.Padding(10, 20, 10, 10);
            this.panelMenu.Size = new System.Drawing.Size(250, 500);
            this.panelMenu.TabIndex = 2;
            // 
            // btnSecurite
            // 
            this.btnSecurite.BackColor = System.Drawing.Color.Transparent;
            this.btnSecurite.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSecurite.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSecurite.FlatAppearance.BorderSize = 0;
            this.btnSecurite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSecurite.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSecurite.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.btnSecurite.Location = new System.Drawing.Point(10, 295);
            this.btnSecurite.Name = "btnSecurite";
            this.btnSecurite.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnSecurite.Size = new System.Drawing.Size(230, 45);
            this.btnSecurite.TabIndex = 6;
            this.btnSecurite.Text = "🔐 Sécurité";
            this.btnSecurite.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSecurite.UseVisualStyleBackColor = false;
            this.btnSecurite.Click += new System.EventHandler(this.utilisateurToolStripMenuItem_Click);
            // 
            // btnParametres
            // 
            this.btnParametres.BackColor = System.Drawing.Color.Transparent;
            this.btnParametres.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnParametres.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnParametres.FlatAppearance.BorderSize = 0;
            this.btnParametres.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnParametres.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnParametres.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.btnParametres.Location = new System.Drawing.Point(10, 250);
            this.btnParametres.Name = "btnParametres";
            this.btnParametres.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnParametres.Size = new System.Drawing.Size(230, 45);
            this.btnParametres.TabIndex = 5;
            this.btnParametres.Text = "⚙️ Paramètres";
            this.btnParametres.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnParametres.UseVisualStyleBackColor = false;
            this.btnParametres.Click += new System.EventHandler(this.anneeAcadmiqueToolStripMenuItem_Click);
            // 
            // btnDepartements
            // 
            this.btnDepartements.BackColor = System.Drawing.Color.Transparent;
            this.btnDepartements.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDepartements.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDepartements.FlatAppearance.BorderSize = 0;
            this.btnDepartements.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDepartements.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnDepartements.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.btnDepartements.Location = new System.Drawing.Point(10, 205);
            this.btnDepartements.Name = "btnDepartements";
            this.btnDepartements.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnDepartements.Size = new System.Drawing.Size(230, 45);
            this.btnDepartements.TabIndex = 4;
            this.btnDepartements.Text = "🏢 Départements";
            this.btnDepartements.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDepartements.UseVisualStyleBackColor = false;
            this.btnDepartements.Click += new System.EventHandler(this.departementToolStripMenuItem_Click);
            // 
            // btnProfesseurs
            // 
            this.btnProfesseurs.BackColor = System.Drawing.Color.Transparent;
            this.btnProfesseurs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProfesseurs.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProfesseurs.FlatAppearance.BorderSize = 0;
            this.btnProfesseurs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfesseurs.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnProfesseurs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.btnProfesseurs.Location = new System.Drawing.Point(10, 160);
            this.btnProfesseurs.Name = "btnProfesseurs";
            this.btnProfesseurs.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnProfesseurs.Size = new System.Drawing.Size(230, 45);
            this.btnProfesseurs.TabIndex = 3;
            this.btnProfesseurs.Text = "👨‍🏫 Professeurs";
            this.btnProfesseurs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProfesseurs.UseVisualStyleBackColor = false;
            this.btnProfesseurs.Click += new System.EventHandler(this.professeurToolStripMenuItem_Click);
            // 
            // btnMemoires
            // 
            this.btnMemoires.BackColor = System.Drawing.Color.Transparent;
            this.btnMemoires.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMemoires.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMemoires.FlatAppearance.BorderSize = 0;
            this.btnMemoires.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMemoires.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnMemoires.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.btnMemoires.Location = new System.Drawing.Point(10, 115);
            this.btnMemoires.Name = "btnMemoires";
            this.btnMemoires.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnMemoires.Size = new System.Drawing.Size(230, 45);
            this.btnMemoires.TabIndex = 2;
            this.btnMemoires.Text = "📝 Mémoires";
            this.btnMemoires.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMemoires.UseVisualStyleBackColor = false;
            this.btnMemoires.Click += new System.EventHandler(this.memoireToolStripMenuItem_Click);
            // 
            // btnSoutenances
            // 
            this.btnSoutenances.BackColor = System.Drawing.Color.Transparent;
            this.btnSoutenances.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSoutenances.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSoutenances.FlatAppearance.BorderSize = 0;
            this.btnSoutenances.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSoutenances.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSoutenances.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.btnSoutenances.Location = new System.Drawing.Point(10, 70);
            this.btnSoutenances.Name = "btnSoutenances";
            this.btnSoutenances.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnSoutenances.Size = new System.Drawing.Size(230, 45);
            this.btnSoutenances.TabIndex = 1;
            this.btnSoutenances.Text = "📚 Soutenances";
            this.btnSoutenances.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSoutenances.UseVisualStyleBackColor = false;
            this.btnSoutenances.Click += new System.EventHandler(this.soutenanceToolStripMenuItem_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.Location = new System.Drawing.Point(10, 20);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnDashboard.Size = new System.Drawing.Size(230, 50);
            this.btnDashboard.TabIndex = 0;
            this.btnDashboard.Text = "📊 Tableau de bord";
            this.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.UseVisualStyleBackColor = false;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // panelUserInfo
            // 
            this.panelUserInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.panelUserInfo.Controls.Add(this.lblUserRole);
            this.panelUserInfo.Controls.Add(this.lblUserName);
            this.panelUserInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUserInfo.Location = new System.Drawing.Point(0, 80);
            this.panelUserInfo.Name = "panelUserInfo";
            this.panelUserInfo.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.panelUserInfo.Size = new System.Drawing.Size(250, 76);
            this.panelUserInfo.TabIndex = 1;
            // 
            // lblUserRole
            // 
            this.lblUserRole.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblUserRole.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblUserRole.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.lblUserRole.Location = new System.Drawing.Point(15, 36);
            this.lblUserRole.Name = "lblUserRole";
            this.lblUserRole.Size = new System.Drawing.Size(220, 30);
            this.lblUserRole.TabIndex = 1;
            this.lblUserRole.Text = "Administrateur";
            this.lblUserRole.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblUserName
            // 
            this.lblUserName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblUserName.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblUserName.ForeColor = System.Drawing.Color.White;
            this.lblUserName.Location = new System.Drawing.Point(15, 10);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(220, 30);
            this.lblUserName.TabIndex = 0;
            this.lblUserName.Text = "👤 Utilisateur";
            this.lblUserName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.lblAppName);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(250, 80);
            this.panelLogo.TabIndex = 0;
            // 
            // lblAppName
            // 
            this.lblAppName.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblAppName.ForeColor = System.Drawing.Color.White;
            this.lblAppName.Location = new System.Drawing.Point(2, 0);
            this.lblAppName.Name = "lblAppName";
            this.lblAppName.Size = new System.Drawing.Size(250, 90);
            this.lblAppName.TabIndex = 0;
            this.lblAppName.Text = "🎓 Sen\r\nSoutenance";
            this.lblAppName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.White;
            this.panelHeader.Controls.Add(this.lblBreadcrumb);
            this.panelHeader.Controls.Add(this.lblPageTitle);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(250, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Padding = new System.Windows.Forms.Padding(30, 15, 30, 15);
            this.panelHeader.Size = new System.Drawing.Size(1150, 120);
            this.panelHeader.TabIndex = 1;
            // 
            // lblBreadcrumb
            // 
            this.lblBreadcrumb.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblBreadcrumb.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblBreadcrumb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.lblBreadcrumb.Location = new System.Drawing.Point(30, 72);
            this.lblBreadcrumb.Name = "lblBreadcrumb";
            this.lblBreadcrumb.Size = new System.Drawing.Size(1090, 33);
            this.lblBreadcrumb.TabIndex = 1;
            this.lblBreadcrumb.Text = "Accueil > Tableau de bord";
            this.lblBreadcrumb.Click += new System.EventHandler(this.lblBreadcrumb_Click);
            // 
            // lblPageTitle
            // 
            this.lblPageTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblPageTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblPageTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblPageTitle.Location = new System.Drawing.Point(30, 15);
            this.lblPageTitle.Name = "lblPageTitle";
            this.lblPageTitle.Size = new System.Drawing.Size(1090, 57);
            this.lblPageTitle.TabIndex = 0;
            this.lblPageTitle.Text = "Tableau de bord";
            // 
            // frmMDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(1400, 800);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panelSidebar);
            this.IsMdiContainer = true;
            this.Name = "frmMDI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "🎓 Sen Soutenance - Gestion";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMDI_Load);
            this.panelSidebar.ResumeLayout(false);
            this.panelMenu.ResumeLayout(false);
            this.panelUserInfo.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelHeader.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSidebar;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Label lblAppName;
        private System.Windows.Forms.Panel panelUserInfo;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblUserRole;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnSoutenances;
        private System.Windows.Forms.Button btnMemoires;
        private System.Windows.Forms.Button btnProfesseurs;
        private System.Windows.Forms.Button btnDepartements;
        private System.Windows.Forms.Button btnParametres;
        private System.Windows.Forms.Button btnSecurite;
        private System.Windows.Forms.Button btnDeconnexion;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblPageTitle;
        private System.Windows.Forms.Label lblBreadcrumb;
    }
}