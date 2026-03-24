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

        // ── Contrôles déclarés ────────────────────────────────────────
        private SidebarPanel pnlSidebar;
        private Panel pnlMdiContainer;

        // Sidebar controls
        private Label lblLogo;
        private Label lblLogoSub;
        private Panel pnlLogoDivider;

        private Label lblNavSection1;
        private Button btnAnneeAcademique;
        private Button btnSession;
        private Button btnProfesseur;
        private Button btnDepartement;
        private Button btnChefDepartement;

        private Label lblNavSection2;
        private Button btnSoutenance;
        private Button btnMemoire;

        private Label lblNavSection3;
        private Button btnUtilisateur;

        private Panel pnlSidebarFooter;
        private Label lblClock;
        private Label lblDate;
        private Button btnDeconnexion;
        private Button btnQuitter;

        private System.Windows.Forms.Timer timerClock;

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();

            // ── MDI area ──────────────────────────────────────────────
            this.pnlMdiContainer = new Panel
            {
                BackColor    = DarkTheme.BgPrincipal,
                Dock         = DockStyle.Fill,
                Padding      = new Padding(0)
            };

            // ── SIDEBAR ───────────────────────────────────────────────
            this.pnlSidebar = new SidebarPanel
            {
                Width        = 220,
                Dock         = DockStyle.Left,
                BackColor    = Color.FromArgb(15, 12, 11)
            };

            // Logo
            this.lblLogo = new Label
            {
                Text      = "🎓 SenSoutenance",
                Font      = new Font("Segoe UI", 13f, FontStyle.Bold),
                ForeColor = DarkTheme.Amber,
                BackColor = Color.Transparent,
                AutoSize  = false,
                Size      = new Size(220, 42),
                Location  = new Point(0, 18),
                TextAlign = ContentAlignment.MiddleCenter
            };

            this.lblLogoSub = new Label
            {
                Text      = "Gestion académique",
                Font      = new Font("Segoe UI", 8.5f),
                ForeColor = DarkTheme.TextSecondary,
                BackColor = Color.Transparent,
                AutoSize  = false,
                Size      = new Size(220, 20),
                Location  = new Point(0, 58),
                TextAlign = ContentAlignment.MiddleCenter
            };

            this.pnlLogoDivider = new Panel
            {
                Height    = 1,
                Width     = 180,
                Location  = new Point(20, 88),
                BackColor = DarkTheme.BgBorder
            };

            // ── Section PARAMÈTRES ────────────────────────────────────
            this.lblNavSection1 = MakeSectionLabel("PARAMÈTRES", new Point(16, 106));
            this.btnAnneeAcademique  = MakeNavButton("📅  Année Académique",  new Point(0, 126), this.btnAnneeAcademique_Click);
            this.btnSession          = MakeNavButton("🗓  Session",            new Point(0, 166), this.btnSession_Click);
            this.btnProfesseur       = MakeNavButton("👨‍🏫  Professeurs",        new Point(0, 206), this.btnProfesseur_Click);
            this.btnDepartement      = MakeNavButton("🏛  Départements",       new Point(0, 246), this.btnDepartement_Click);
            this.btnChefDepartement  = MakeNavButton("👤  Chefs Dept.",        new Point(0, 286), this.btnChefDepartement_Click);

            // ── Section ACADÉMIQUE ────────────────────────────────────
            this.lblNavSection2 = MakeSectionLabel("ACADÉMIQUE", new Point(16, 336));
            this.btnSoutenance   = MakeNavButton("🎓  Soutenances", new Point(0, 356), this.btnSoutenance_Click);
            this.btnMemoire      = MakeNavButton("📄  Mémoires",    new Point(0, 396), this.btnMemoire_Click);

            // ── Section SÉCURITÉ ─────────────────────────────────────
            this.lblNavSection3 = MakeSectionLabel("SÉCURITÉ", new Point(16, 446));
            this.btnUtilisateur  = MakeNavButton("🔐  Utilisateurs", new Point(0, 466), this.btnUtilisateur_Click);

            // ── Footer sidebar ────────────────────────────────────────
            this.pnlSidebarFooter = new Panel
            {
                Dock      = DockStyle.Bottom,
                Height    = 130,
                BackColor = Color.FromArgb(10, 8, 7)
            };

            this.lblClock = new Label
            {
                Text      = "00:00",
                Font      = new Font("Segoe UI", 26f, FontStyle.Bold),
                ForeColor = DarkTheme.Amber,
                BackColor = Color.Transparent,
                AutoSize  = false,
                Size      = new Size(220, 40),
                Location  = new Point(0, 8),
                TextAlign = ContentAlignment.MiddleCenter
            };

            this.lblDate = new Label
            {
                Text      = "",
                Font      = new Font("Segoe UI", 8f),
                ForeColor = DarkTheme.TextSecondary,
                BackColor = Color.Transparent,
                AutoSize  = false,
                Size      = new Size(220, 18),
                Location  = new Point(0, 48),
                TextAlign = ContentAlignment.MiddleCenter
            };

            this.btnDeconnexion = MakeFooterButton("⏻  Déconnexion", new Point(10, 70), DarkTheme.Danger, this.btnDeconnexion_Click);
            this.btnQuitter     = MakeFooterButton("✕  Quitter",     new Point(115, 70), Color.FromArgb(50, 50, 55), this.btnQuitter_Click);

            this.pnlSidebarFooter.Controls.AddRange(new Control[]
            { this.lblClock, this.lblDate, this.btnDeconnexion, this.btnQuitter });

            // ── Assemblage sidebar ────────────────────────────────────
            this.pnlSidebar.Controls.AddRange(new Control[]
            {
                this.lblLogo, this.lblLogoSub, this.pnlLogoDivider,
                this.lblNavSection1,
                this.btnAnneeAcademique, this.btnSession, this.btnProfesseur,
                this.btnDepartement, this.btnChefDepartement,
                this.lblNavSection2,
                this.btnSoutenance, this.btnMemoire,
                this.lblNavSection3,
                this.btnUtilisateur,
                this.pnlSidebarFooter
            });

            // ── Timer horloge ─────────────────────────────────────────
            this.timerClock = new System.Windows.Forms.Timer(this.components)
            { Interval = 30000 };
            this.timerClock.Tick += new EventHandler(this.timerClock_Tick);

            // ── Form MDI ──────────────────────────────────────────────
            this.IsMdiContainer  = true;
            this.BackColor       = DarkTheme.BgPrincipal;
            this.WindowState     = FormWindowState.Maximized;
            this.Text            = "Sen Soutenance";
            this.Name            = "frmMDI";
            this.Font            = new Font("Segoe UI", 9.5f);
            this.Load           += new EventHandler(this.frmMDI_Load);

            this.Controls.Add(this.pnlMdiContainer);
            this.Controls.Add(this.pnlSidebar);

            // ── Pointer la zone MDI vers le panel ─────────────────────
            // (WinForms utilise automatiquement le dernier contrôle Fill comme MdiClient zone)
        }

        // ── Factory helpers ───────────────────────────────────────────
        private Label MakeSectionLabel(string text, Point loc) => new Label
        {
            Text      = text,
            Font      = new Font("Segoe UI", 7.5f, FontStyle.Bold),
            ForeColor = Color.FromArgb(80, 80, 80),
            BackColor = Color.Transparent,
            AutoSize  = true,
            Location  = loc
        };

        private Button MakeNavButton(string text, Point loc, EventHandler handler)
        {
            var btn = new Button
            {
                Text      = text,
                Font      = new Font("Segoe UI", 10f),
                ForeColor = DarkTheme.TextSecondary,
                BackColor = Color.Transparent,
                FlatStyle = FlatStyle.Flat,
                TextAlign = ContentAlignment.MiddleLeft,
                Padding   = new Padding(14, 0, 0, 0),
                Cursor    = Cursors.Hand,
                Size      = new Size(220, 38),
                Location  = loc
            };
            btn.FlatAppearance.BorderSize      = 0;
            btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(25, 217, 119, 6);
            btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(40, 217, 119, 6);
            btn.Click += handler;
            btn.MouseEnter += (s, e) => { if (btn.BackColor == Color.Transparent) btn.ForeColor = DarkTheme.Amber; };
            btn.MouseLeave += (s, e) => { if (btn.BackColor == Color.Transparent) btn.ForeColor = DarkTheme.TextSecondary; };
            return btn;
        }

        private Button MakeFooterButton(string text, Point loc, Color bg, EventHandler handler)
        {
            var btn = new Button
            {
                Text      = text,
                Font      = new Font("Segoe UI", 8.5f, FontStyle.Bold),
                ForeColor = Color.White,
                BackColor = bg,
                FlatStyle = FlatStyle.Flat,
                Cursor    = Cursors.Hand,
                Size      = new Size(95, 32),
                Location  = loc
            };
            btn.FlatAppearance.BorderSize = 0;
            btn.Click += handler;
            return btn;
        }

        #endregion
    }

    // ══════════════════════════════════════════════════════════════════════
    //  SIDEBAR PANEL CUSTOM (GDI+ peint)
    // ══════════════════════════════════════════════════════════════════════
    public class SidebarPanel : Panel
    {
        public SidebarPanel() { this.DoubleBuffered = true; }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            var g = e.Graphics;

            // Ligne verticale ambre à droite
            using (var brush = new LinearGradientBrush(
                new Rectangle(Width - 2, 0, 2, Height),
                Color.Transparent, DarkTheme.Amber, LinearGradientMode.Vertical))
                g.FillRectangle(brush, Width - 2, 0, 2, Height);
        }
    }
}