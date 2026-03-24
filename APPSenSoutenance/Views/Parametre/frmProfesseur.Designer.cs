using APPSenSoutenance.Shared;
using System;
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

        // ── Contrôles ─────────────────────────────────────────────────
        private Panel pnlHeader;
        private Label lblHeaderIcon, lblHeaderTitle, lblHeaderSub;
        private Panel pnlLeft, pnlRight, pnlActions, pnlSearch;
        private Label lblNom, lblPrenom, lblTel, lblEmail, lblMdp, lblSpec;
        private TextBox txtNom, txtPrenom, txtTelephone, txtEmail, txtMotDePasse, txtSpecialite;
        private Label lblRNom, lblRSpec;
        private TextBox txtRNom, txtRSpecialite;
        private DataGridView dgProfesseur;
        private Button btnAdd, btnEdit, btnRemove, btnSelect;
        private Panel pnlNom, pnlPrenom, pnlTel, pnlEmail, pnlMdp, pnlSpec;
        private Panel pnlRNom, pnlRSpec;

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.SuspendLayout();

            // ── HEADER ────────────────────────────────────────────────
            this.pnlHeader = new GradientPanel
            {
                Dock         = DockStyle.Top,
                Height       = 72,
                GradientStart = Color.FromArgb(28, 25, 23),
                GradientEnd   = Color.FromArgb(20, 18, 16)
            };

            this.lblHeaderIcon  = MakeLabel("👨‍🏫", new Font("Segoe UI Emoji", 22f), DarkTheme.Amber,  new Point(18, 12), false);
            this.lblHeaderTitle = MakeLabel("Gestion des Professeurs", new Font("Segoe UI", 15f, FontStyle.Bold), DarkTheme.TextTitle, new Point(62, 10), false);
            this.lblHeaderSub   = MakeLabel("Ajouter, modifier et consulter les professeurs", new Font("Segoe UI", 9f), DarkTheme.TextSecondary, new Point(64, 38), false);

            var hdrLine = new Panel { Dock = DockStyle.Bottom, Height = 2, BackColor = DarkTheme.Amber };
            this.pnlHeader.Controls.AddRange(new Control[] { this.lblHeaderIcon, this.lblHeaderTitle, this.lblHeaderSub, hdrLine });

            // ── PANEL GAUCHE (formulaire) ─────────────────────────────
            this.pnlLeft = new Panel
            {
                Width     = 340,
                Dock      = DockStyle.Left,
                BackColor = DarkTheme.BgCard,
                Padding   = new Padding(20, 16, 20, 0)
            };

            // Champs
            int y = 16;
            (lblNom,    pnlNom,    txtNom)          = MakeField("NOM",               y,          300); y += 68;
            (lblPrenom, pnlPrenom, txtPrenom)        = MakeField("PRÉNOM",            y,          300); y += 68;
            (lblTel,    pnlTel,    txtTelephone)     = MakeField("TÉLÉPHONE",          y,          300); y += 68;
            (lblEmail,  pnlEmail,  txtEmail)         = MakeField("EMAIL",             y,          300); y += 68;
            (lblMdp,    pnlMdp,    txtMotDePasse)    = MakeField("MOT DE PASSE",      y,          300, isPassword: true); y += 68;
            (lblSpec,   pnlSpec,   txtSpecialite)    = MakeField("SPÉCIALITÉ",        y,          300); y += 80;

            // Boutons actions
            this.pnlActions = new Panel
            {
                Location  = new Point(20, y),
                Size      = new Size(300, 96),
                BackColor = Color.Transparent
            };

            this.btnAdd    = MakePremiumBtn("+ Ajouter",    new Point(0, 0),   new Size(145, 40), DarkTheme.Amber,   this.btnAdd_Click);
            this.btnSelect = MakePremiumBtn("↑ Sélect.",   new Point(153, 0),  new Size(147, 40), DarkTheme.Emerald, this.btnSelect_Click);
            this.btnEdit   = MakePremiumBtn("✎ Modifier",   new Point(0, 50),   new Size(145, 40), Color.FromArgb(41,37,36), this.btnEdit_Click, amber: true);
            this.btnRemove = MakePremiumBtn("✕ Supprimer", new Point(153, 50), new Size(147, 40), DarkTheme.Danger,  this.btnRemove_Click);

            this.pnlActions.Controls.AddRange(new Control[] { btnAdd, btnSelect, btnEdit, btnRemove });

            this.pnlLeft.Controls.AddRange(new Control[]
            {
                lblNom, pnlNom, lblPrenom, pnlPrenom,
                lblTel, pnlTel, lblEmail, pnlEmail,
                lblMdp, pnlMdp, lblSpec, pnlSpec,
                pnlActions
            });

            // ── PANEL DROIT (tableau) ─────────────────────────────────
            this.pnlRight = new Panel
            {
                Dock      = DockStyle.Fill,
                BackColor = DarkTheme.BgPrincipal,
                Padding   = new Padding(16, 12, 16, 16)
            };

            // Barre de recherche
            this.pnlSearch = new RoundedPanel
            {
                BackColor    = DarkTheme.BgCard,
                Size         = new Size(600, 38),
                Location     = new Point(16, 12),
                CornerRadius = 8,
                ShowBorder   = true,
                BorderColor  = DarkTheme.BgBorder,
                ShowShadow   = false
            };

            this.lblRNom  = MakeLabel("Nom :", new Font("Segoe UI", 8.5f, FontStyle.Bold), DarkTheme.TextSecondary, new Point(8, 10), true);
            this.txtRNom  = MakeSearchBox(new Point(55, 6), 130);
            this.lblRSpec = MakeLabel("Spécialité :", new Font("Segoe UI", 8.5f, FontStyle.Bold), DarkTheme.TextSecondary, new Point(202, 10), true);
            this.txtRSpecialite = MakeSearchBox(new Point(286, 6), 130);

            this.pnlSearch.Controls.AddRange(new Control[] { lblRNom, txtRNom, lblRSpec, txtRSpecialite });

            // DataGridView
            var dgStyle1 = new DataGridViewCellStyle
            {
                Alignment        = DataGridViewContentAlignment.MiddleLeft,
                BackColor        = Color.FromArgb(32, 29, 27),
                Font             = new Font("Segoe UI", 9f, FontStyle.Bold),
                ForeColor        = DarkTheme.Amber,
                Padding          = new Padding(10, 0, 0, 0),
                SelectionBackColor = Color.FromArgb(32, 29, 27),
                SelectionForeColor = DarkTheme.AmberHover,
                WrapMode         = DataGridViewTriState.True
            };
            var dgStyle2 = new DataGridViewCellStyle
            {
                Alignment        = DataGridViewContentAlignment.MiddleLeft,
                BackColor        = DarkTheme.BgCard,
                Font             = new Font("Segoe UI", 10f),
                ForeColor        = DarkTheme.TextPrimary,
                Padding          = new Padding(10, 0, 0, 0),
                SelectionBackColor = DarkTheme.BgHover,
                SelectionForeColor = DarkTheme.Amber,
                WrapMode         = DataGridViewTriState.False
            };

            this.dgProfesseur = new DataGridView
            {
                AllowUserToAddRows           = false,
                AllowUserToDeleteRows        = false,
                AutoSizeColumnsMode          = DataGridViewAutoSizeColumnsMode.Fill,
                BackgroundColor              = DarkTheme.BgPrincipal,
                BorderStyle                  = BorderStyle.None,
                CellBorderStyle             = DataGridViewCellBorderStyle.SingleHorizontal,
                ColumnHeadersBorderStyle     = DataGridViewHeaderBorderStyle.None,
                ColumnHeadersDefaultCellStyle = dgStyle1,
                ColumnHeadersHeight          = 42,
                ColumnHeadersHeightSizeMode  = DataGridViewColumnHeadersHeightSizeMode.DisableResizing,
                DefaultCellStyle             = dgStyle2,
                EnableHeadersVisualStyles    = false,
                GridColor                    = DarkTheme.BgBorder,
                Location                     = new Point(16, 62),
                Name                         = "dgProfesseur",
                ReadOnly                     = true,
                RowHeadersVisible            = false,
                RowTemplate                  = { Height = 38 },
                SelectionMode               = DataGridViewSelectionMode.FullRowSelect,
                Anchor                       = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right,
                Size                         = new Size(700, 500)
            };
            this.dgProfesseur.AlternatingRowsDefaultCellStyle = new DataGridViewCellStyle
            {
                BackColor = Color.FromArgb(22, 20, 18),
                ForeColor = DarkTheme.TextPrimary
            };

            this.pnlRight.Controls.AddRange(new Control[] { pnlSearch, dgProfesseur });

            // ── FORM ──────────────────────────────────────────────────
            this.AutoScaleDimensions = new SizeF(8f, 16f);
            this.AutoScaleMode       = AutoScaleMode.Font;
            this.BackColor           = DarkTheme.BgPrincipal;
            this.ClientSize          = new Size(1120, 700);
            this.ControlBox          = false;
            this.Name                = "frmProfesseur";
            this.Text                = "Professeurs";
            this.Font                = new Font("Segoe UI", 9.5f);

            this.Controls.Add(this.pnlRight);
            this.Controls.Add(this.pnlLeft);
            this.Controls.Add(this.pnlHeader);

            this.ResumeLayout(false);
            this.PerformLayout();
        }
        #endregion

        // ── Helpers ───────────────────────────────────────────────────
        private Label MakeLabel(string text, Font font, Color color, Point loc, bool autoSize)
            => new Label { Text = text, Font = font, ForeColor = color, BackColor = Color.Transparent, Location = loc, AutoSize = autoSize };

        private (Label, Panel, TextBox) MakeField(string labelText, int y, int width, bool isPassword = false)
        {
            var lbl = new Label
            {
                Text      = labelText,
                Font      = new Font("Segoe UI", 8f, FontStyle.Bold),
                ForeColor = DarkTheme.TextSecondary,
                BackColor = Color.Transparent,
                AutoSize  = true,
                Location  = new Point(20, y)
            };
            var pnl = new RoundedPanel
            {
                BackColor    = DarkTheme.BgHover,
                Location     = new Point(20, y + 20),
                Size         = new Size(width, 40),
                CornerRadius = 8,
                ShowBorder   = true,
                BorderColor  = DarkTheme.BgBorder,
                ShowShadow   = false
            };
            var txt = new TextBox
            {
                BorderStyle         = BorderStyle.None,
                BackColor           = DarkTheme.BgHover,
                ForeColor           = DarkTheme.TextPrimary,
                Font                = new Font("Segoe UI", 10.5f),
                Location            = new Point(10, 9),
                Width               = width - 22,
                UseSystemPasswordChar = isPassword
            };
            pnl.Controls.Add(txt);
            return (lbl, pnl, txt);
        }

        private TextBox MakeSearchBox(Point loc, int width) => new TextBox
        {
            BorderStyle = BorderStyle.None,
            BackColor   = DarkTheme.BgCard,
            ForeColor   = DarkTheme.TextPrimary,
            Font        = new Font("Segoe UI", 9.5f),
            Location    = loc,
            Width       = width
        };

        private Button MakePremiumBtn(string text, Point loc, Size size, Color bg, EventHandler handler, bool amber = false)
        {
            var btn = new Button
            {
                Text      = text,
                Location  = loc,
                Size      = size,
                Font      = new Font("Segoe UI", 9.5f, FontStyle.Bold),
                ForeColor = amber ? DarkTheme.Amber : Color.White,
                BackColor = bg,
                FlatStyle = FlatStyle.Flat,
                Cursor    = Cursors.Hand
            };
            btn.FlatAppearance.BorderSize = amber ? 1 : 0;
            if (amber) btn.FlatAppearance.BorderColor = DarkTheme.Amber;
            btn.Click += handler;
            return btn;
        }
    }
}