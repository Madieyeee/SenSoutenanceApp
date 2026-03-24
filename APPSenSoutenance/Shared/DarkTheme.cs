using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace APPSenSoutenance.Shared
{
    /// <summary>
    /// Système de thème dark premium pour SenSoutenance
    /// Palette : Ambre chaleureux sur dark charcoal
    /// </summary>
    public static class DarkTheme
    {
        // ── BACKGROUNDS ─────────────────────────────────────────────────
        public static readonly Color BgPrincipal   = ColorFromHex("#0C0A09");
        public static readonly Color BgCard        = ColorFromHex("#1C1917");
        public static readonly Color BgHover       = ColorFromHex("#292524");
        public static readonly Color BgBorder      = ColorFromHex("#44403C");

        // ── COULEURS PRINCIPALES ─────────────────────────────────────────
        public static readonly Color Amber         = ColorFromHex("#D97706");
        public static readonly Color AmberHover    = ColorFromHex("#F59E0B");
        public static readonly Color AmberPressed  = ColorFromHex("#B45309");
        public static readonly Color Emerald       = ColorFromHex("#10B981");
        public static readonly Color EmeraldHover  = ColorFromHex("#34D399");
        public static readonly Color Danger        = ColorFromHex("#EF4444");

        // ── TEXTES ───────────────────────────────────────────────────────
        public static readonly Color TextPrimary   = ColorFromHex("#E7E5E4");
        public static readonly Color TextSecondary = ColorFromHex("#A8A29E");
        public static readonly Color TextTitle     = ColorFromHex("#FAFAF9");

        // ── TYPOGRAPHIE ──────────────────────────────────────────────────
        public static readonly Font FontTitle    = new Font("Segoe UI", 22f, FontStyle.Bold);
        public static readonly Font FontSubtitle = new Font("Segoe UI", 13f, FontStyle.Bold);
        public static readonly Font FontLabel    = new Font("Segoe UI", 10f, FontStyle.Bold);
        public static readonly Font FontBody     = new Font("Segoe UI", 10f);
        public static readonly Font FontSmall    = new Font("Segoe UI", 9f);
        public static readonly Font FontMenu     = new Font("Segoe UI", 11f, FontStyle.Bold);

        // ── HELPERS ──────────────────────────────────────────────────────
        private static Color ColorFromHex(string hex)
        {
            return ColorTranslator.FromHtml(hex);
        }

        /// <summary>Arrondit les coins d'un contrôle (Panel, Button…)</summary>
        public static void SetRoundedRegion(Control ctrl, int radius = 10)
        {
            GraphicsPath path = new GraphicsPath();
            int w = ctrl.Width, h = ctrl.Height;
            path.AddArc(0, 0, radius * 2, radius * 2, 180, 90);
            path.AddArc(w - radius * 2, 0, radius * 2, radius * 2, 270, 90);
            path.AddArc(w - radius * 2, h - radius * 2, radius * 2, radius * 2, 0, 90);
            path.AddArc(0, h - radius * 2, radius * 2, radius * 2, 90, 90);
            path.CloseAllFigures();
            ctrl.Region = new Region(path);
        }

        /// <summary>Applique le style dark à un bouton primaire (Ambre)</summary>
        public static void StyleButtonPrimary(Button btn)
        {
            btn.BackColor = Amber;
            btn.ForeColor = Color.White;
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.Font = FontLabel;
            btn.Cursor = Cursors.Hand;
            btn.MouseEnter += (s, e) => btn.BackColor = AmberHover;
            btn.MouseLeave += (s, e) => btn.BackColor = Amber;
            btn.MouseDown  += (s, e) => btn.BackColor = AmberPressed;
            btn.MouseUp    += (s, e) => btn.BackColor = AmberHover;
        }

        /// <summary>Applique le style dark à un bouton secondaire (Émeraude)</summary>
        public static void StyleButtonSuccess(Button btn)
        {
            btn.BackColor = Emerald;
            btn.ForeColor = Color.White;
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.Font = FontLabel;
            btn.Cursor = Cursors.Hand;
            btn.MouseEnter += (s, e) => btn.BackColor = EmeraldHover;
            btn.MouseLeave += (s, e) => btn.BackColor = Emerald;
        }

        /// <summary>Applique le style dark à un bouton danger</summary>
        public static void StyleButtonDanger(Button btn)
        {
            btn.BackColor = Danger;
            btn.ForeColor = Color.White;
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.Font = FontLabel;
            btn.Cursor = Cursors.Hand;
            btn.MouseEnter += (s, e) => btn.BackColor = Color.FromArgb(220, 38, 38);
            btn.MouseLeave += (s, e) => btn.BackColor = Danger;
        }

        /// <summary>Applique le style dark à un bouton neutre (outline)</summary>
        public static void StyleButtonOutline(Button btn)
        {
            btn.BackColor = BgHover;
            btn.ForeColor = TextSecondary;
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderColor = BgBorder;
            btn.FlatAppearance.BorderSize = 1;
            btn.Font = FontLabel;
            btn.Cursor = Cursors.Hand;
            btn.MouseEnter += (s, e) => { btn.BackColor = BgBorder; btn.ForeColor = TextPrimary; };
            btn.MouseLeave += (s, e) => { btn.BackColor = BgHover;  btn.ForeColor = TextSecondary; };
        }

        /// <summary>Style dark pour un TextBox</summary>
        public static void StyleTextBox(TextBox tb)
        {
            tb.BackColor = BgHover;
            tb.ForeColor = TextPrimary;
            tb.BorderStyle = BorderStyle.FixedSingle;
            tb.Font = FontBody;
        }

        /// <summary>Style dark pour un ComboBox</summary>
        public static void StyleComboBox(ComboBox cb)
        {
            cb.BackColor = BgHover;
            cb.ForeColor = TextPrimary;
            cb.FlatStyle = FlatStyle.Flat;
            cb.Font = FontBody;
        }

        /// <summary>Style dark premium pour un DataGridView</summary>
        public static void StyleDataGridView(DataGridView dgv)
        {
            dgv.BackgroundColor = BgCard;
            dgv.GridColor = BgBorder;
            dgv.BorderStyle = BorderStyle.None;
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv.EnableHeadersVisualStyles = false;
            dgv.RowHeadersVisible = false;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.Font = FontSmall;
            dgv.RowTemplate.Height = 38;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // En-têtes
            dgv.ColumnHeadersDefaultCellStyle.BackColor = BgHover;
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Amber;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9f, FontStyle.Bold);
            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgv.ColumnHeadersDefaultCellStyle.Padding = new Padding(8, 0, 0, 0);
            dgv.ColumnHeadersHeight = 42;
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;

            // Lignes normales
            dgv.DefaultCellStyle.BackColor = BgCard;
            dgv.DefaultCellStyle.ForeColor = TextPrimary;
            dgv.DefaultCellStyle.SelectionBackColor = ColorFromHex("#292524");
            dgv.DefaultCellStyle.SelectionForeColor = AmberHover;
            dgv.DefaultCellStyle.Padding = new Padding(8, 0, 0, 0);

            // Lignes alternées
            dgv.AlternatingRowsDefaultCellStyle.BackColor = ColorFromHex("#14120F");
            dgv.AlternatingRowsDefaultCellStyle.ForeColor = TextPrimary;
        }

        /// <summary>Style dark pour un Label titre de section</summary>
        public static void StyleLabelSection(Label lbl)
        {
            lbl.ForeColor = Amber;
            lbl.Font = new Font("Segoe UI", 9f, FontStyle.Bold);
            lbl.BackColor = Color.Transparent;
        }

        /// <summary>Style dark pour un Label standard</summary>
        public static void StyleLabel(Label lbl)
        {
            lbl.ForeColor = TextSecondary;
            lbl.Font = FontLabel;
            lbl.BackColor = Color.Transparent;
        }

        /// <summary>Style dark pour le MenuStrip</summary>
        public static void StyleMenuStrip(MenuStrip menu)
        {
            menu.BackColor = BgCard;
            menu.ForeColor = TextPrimary;
            menu.Font = FontMenu;
            menu.Padding = new Padding(12, 5, 0, 5);
            menu.Renderer = new DarkMenuRenderer();
        }

        /// <summary>Applique le fond dark à un Form</summary>
        public static void ApplyToForm(Form form)
        {
            form.BackColor = BgPrincipal;
            form.ForeColor = TextPrimary;
            form.Font = FontBody;
        }
    }

    /// <summary>Renderer personnalisé pour MenuStrip dark</summary>
    public class DarkMenuRenderer : ToolStripProfessionalRenderer
    {
        private static readonly Color BgCard    = DarkTheme.BgCard;
        private static readonly Color BgHover   = DarkTheme.BgHover;
        private static readonly Color Amber      = DarkTheme.Amber;
        private static readonly Color TextColor  = DarkTheme.TextPrimary;

        public DarkMenuRenderer() : base(new DarkColorTable()) { }

        protected override void OnRenderMenuItemBackground(ToolStripItemRenderEventArgs e)
        {
            var item = e.Item;
            var g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            Color bg = item.Selected ? BgHover : BgCard;
            using (var brush = new SolidBrush(bg))
                g.FillRectangle(brush, new Rectangle(Point.Empty, item.Size));
            if (item.Selected)
            {
                using (var pen = new Pen(Amber, 2))
                    g.DrawLine(pen, 0, item.Height - 2, item.Width, item.Height - 2);
            }
        }

        protected override void OnRenderItemText(ToolStripItemTextRenderEventArgs e)
        {
            e.TextColor = e.Item.Selected ? DarkTheme.AmberHover : TextColor;
            base.OnRenderItemText(e);
        }

        protected override void OnRenderToolStripBackground(ToolStripRenderEventArgs e)
        {
            using (var brush = new SolidBrush(BgCard))
                e.Graphics.FillRectangle(brush, e.AffectedBounds);
        }
    }

    public class DarkColorTable : ProfessionalColorTable
    {
        public override Color MenuItemSelected        => DarkTheme.BgHover;
        public override Color MenuItemBorder          => DarkTheme.Amber;
        public override Color MenuBorder              => DarkTheme.BgBorder;
        public override Color ToolStripDropDownBackground => DarkTheme.BgCard;
        public override Color MenuItemSelectedGradientBegin => DarkTheme.BgHover;
        public override Color MenuItemSelectedGradientEnd   => DarkTheme.BgHover;
        public override Color MenuStripGradientBegin  => DarkTheme.BgCard;
        public override Color MenuStripGradientEnd    => DarkTheme.BgCard;
        public override Color ImageMarginGradientBegin => DarkTheme.BgCard;
        public override Color ImageMarginGradientMiddle => DarkTheme.BgCard;
        public override Color ImageMarginGradientEnd  => DarkTheme.BgCard;
        public override Color SeparatorDark           => DarkTheme.BgBorder;
        public override Color SeparatorLight          => DarkTheme.BgBorder;
    }
}
