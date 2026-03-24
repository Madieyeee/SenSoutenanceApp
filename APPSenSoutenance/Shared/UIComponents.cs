using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace APPSenSoutenance.Shared
{
    // ══════════════════════════════════════════════════════════════════
    //  PANEL AVEC COINS ARRONDIS + OMBRE PORTÉE
    // ══════════════════════════════════════════════════════════════════
    public class RoundedPanel : Panel
    {
        public int CornerRadius { get; set; } = 12;
        public Color ShadowColor { get; set; } = Color.FromArgb(40, 0, 0, 0);
        public bool ShowShadow { get; set; } = true;
        public Color BorderColor { get; set; } = Color.FromArgb(68, 64, 60);
        public bool ShowBorder { get; set; } = false;

        public RoundedPanel()
        {
            this.DoubleBuffered = true;
            this.ResizeRedraw = true;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            var g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            // Ombre
            if (ShowShadow)
            {
                for (int i = 3; i >= 1; i--)
                {
                    var shadowRect = new Rectangle(i, i, Width - i * 2, Height - i * 2);
                    using (var shadowPath = RoundedRect(shadowRect, CornerRadius))
                    using (var shadowBrush = new SolidBrush(Color.FromArgb(15 * i, 0, 0, 0)))
                        g.FillPath(shadowBrush, shadowPath);
                }
            }

            // Fond
            var rect = new Rectangle(0, 0, Width - 1, Height - 1);
            using (var path = RoundedRect(rect, CornerRadius))
            {
                using (var brush = new SolidBrush(BackColor))
                    g.FillPath(brush, path);

                if (ShowBorder)
                    using (var pen = new Pen(BorderColor, 1))
                        g.DrawPath(pen, path);

                Region = new Region(path);
            }
        }

        public static GraphicsPath RoundedRect(Rectangle bounds, int radius)
        {
            int diameter = radius * 2;
            var path = new GraphicsPath();
            path.AddArc(bounds.X, bounds.Y, diameter, diameter, 180, 90);
            path.AddArc(bounds.Right - diameter, bounds.Y, diameter, diameter, 270, 90);
            path.AddArc(bounds.Right - diameter, bounds.Bottom - diameter, diameter, diameter, 0, 90);
            path.AddArc(bounds.X, bounds.Bottom - diameter, diameter, diameter, 90, 90);
            path.CloseAllFigures();
            return path;
        }
    }

    // ══════════════════════════════════════════════════════════════════
    //  PANEL AVEC DÉGRADÉ
    // ══════════════════════════════════════════════════════════════════
    public class GradientPanel : Panel
    {
        public Color GradientStart { get; set; } = DarkTheme.Amber;
        public Color GradientEnd   { get; set; } = DarkTheme.AmberPressed;
        public LinearGradientMode GradientMode { get; set; } = LinearGradientMode.Horizontal;
        public int CornerRadius { get; set; } = 0;

        public GradientPanel() { this.DoubleBuffered = true; this.ResizeRedraw = true; }

        protected override void OnPaint(PaintEventArgs e)
        {
            var g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            var rect = new Rectangle(0, 0, Width, Height);

            using (var brush = new LinearGradientBrush(rect, GradientStart, GradientEnd, GradientMode))
            {
                if (CornerRadius > 0)
                {
                    using (var path = RoundedPanel.RoundedRect(new Rectangle(0,0,Width-1,Height-1), CornerRadius))
                    {
                        g.FillPath(brush, path);
                        Region = new Region(path);
                    }
                }
                else
                {
                    g.FillRectangle(brush, rect);
                }
            }
        }
    }

    // ══════════════════════════════════════════════════════════════════
    //  BOUTON PREMIUM ARRONDI
    // ══════════════════════════════════════════════════════════════════
    public class PremiumButton : Button
    {
        public enum ButtonStyle { Amber, Emerald, Danger, Outline, Ghost }
        public ButtonStyle Style { get; set; } = ButtonStyle.Amber;
        public int CornerRadius { get; set; } = 8;
        private bool _isHovered = false;
        private bool _isPressed = false;

        public PremiumButton()
        {
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.Font = new Font("Segoe UI", 10f, FontStyle.Bold);
            this.ForeColor = Color.White;
            this.Cursor = Cursors.Hand;
            this.DoubleBuffered = true;
        }

        protected override void OnMouseEnter(EventArgs e) { _isHovered = true; Invalidate(); base.OnMouseEnter(e); }
        protected override void OnMouseLeave(EventArgs e) { _isHovered = false; Invalidate(); base.OnMouseLeave(e); }
        protected override void OnMouseDown(MouseEventArgs e) { _isPressed = true; Invalidate(); base.OnMouseDown(e); }
        protected override void OnMouseUp(MouseEventArgs e) { _isPressed = false; Invalidate(); base.OnMouseUp(e); }

        protected override void OnPaint(PaintEventArgs e)
        {
            var g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            var rect = new Rectangle(0, 0, Width - 1, Height - 1);

            Color bg, fg, border;
            switch (Style)
            {
                case ButtonStyle.Amber:
                    bg = _isPressed ? DarkTheme.AmberPressed : _isHovered ? DarkTheme.AmberHover : DarkTheme.Amber;
                    fg = Color.White;
                    border = Color.Transparent;
                    break;
                case ButtonStyle.Emerald:
                    bg = _isPressed ? Color.FromArgb(5,150,105) : _isHovered ? DarkTheme.EmeraldHover : DarkTheme.Emerald;
                    fg = Color.White;
                    border = Color.Transparent;
                    break;
                case ButtonStyle.Danger:
                    bg = _isPressed ? Color.FromArgb(185,28,28) : _isHovered ? Color.FromArgb(220,38,38) : DarkTheme.Danger;
                    fg = Color.White;
                    border = Color.Transparent;
                    break;
                case ButtonStyle.Outline:
                    bg = _isHovered ? DarkTheme.BgHover : Color.Transparent;
                    fg = _isHovered ? DarkTheme.Amber : DarkTheme.TextSecondary;
                    border = _isHovered ? DarkTheme.Amber : DarkTheme.BgBorder;
                    break;
                default: // Ghost
                    bg = _isHovered ? DarkTheme.BgHover : Color.Transparent;
                    fg = DarkTheme.TextSecondary;
                    border = Color.Transparent;
                    break;
            }

            using (var path = RoundedPanel.RoundedRect(rect, CornerRadius))
            {
                using (var brush = new SolidBrush(bg))
                    g.FillPath(brush, path);
                if (border != Color.Transparent)
                    using (var pen = new Pen(border, 1.5f))
                        g.DrawPath(pen, path);
            }

            // Texte
            var sf = new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center };
            using (var textBrush = new SolidBrush(fg))
                g.DrawString(Text, Font, textBrush, new RectangleF(0, 0, Width, Height), sf);
        }
    }

    // ══════════════════════════════════════════════════════════════════
    //  HEADER DE FORMULAIRE AVEC GRADIENT
    // ══════════════════════════════════════════════════════════════════
    public class FormHeader : Panel
    {
        public string Title { get; set; } = "Titre";
        public string Subtitle { get; set; } = "";
        public string Icon { get; set; } = "📋";

        public FormHeader()
        {
            this.Height = 80;
            this.Dock = DockStyle.Top;
            this.DoubleBuffered = true;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            var g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            var rect = new Rectangle(0, 0, Width, Height);

            // Gradient fond
            using (var brush = new LinearGradientBrush(rect,
                Color.FromArgb(28, 25, 23), Color.FromArgb(20, 17, 15), LinearGradientMode.Vertical))
                g.FillRectangle(brush, rect);

            // Ligne accent ambre en bas
            using (var pen = new Pen(DarkTheme.Amber, 2))
                g.DrawLine(pen, 0, Height - 1, Width, Height - 1);

            // Accent vertical gauche
            using (var brush = new LinearGradientBrush(
                new Rectangle(0, 10, 4, Height - 20),
                DarkTheme.Amber, DarkTheme.AmberPressed, LinearGradientMode.Vertical))
                g.FillRectangle(brush, 20, 15, 4, Height - 30);

            // Icône
            using (var iconFont = new Font("Segoe UI Emoji", 22f))
            using (var brush = new SolidBrush(DarkTheme.Amber))
                g.DrawString(Icon, iconFont, brush, new PointF(36, Height / 2f - 20));

            // Titre
            using (var titleFont = new Font("Segoe UI", 16f, FontStyle.Bold))
            using (var brush = new SolidBrush(DarkTheme.TextTitle))
                g.DrawString(Title, titleFont, brush, new PointF(80, 12));

            // Sous-titre
            if (!string.IsNullOrEmpty(Subtitle))
                using (var subFont = new Font("Segoe UI", 9.5f))
                using (var brush = new SolidBrush(DarkTheme.TextSecondary))
                    g.DrawString(Subtitle, subFont, brush, new PointF(82, 42));
        }
    }

    // ══════════════════════════════════════════════════════════════════
    //  TEXTBOX STYLISÉ
    // ══════════════════════════════════════════════════════════════════
    public class DarkTextBox : TextBox
    {
        public DarkTextBox()
        {
            this.BorderStyle = BorderStyle.None;
            this.BackColor   = DarkTheme.BgHover;
            this.ForeColor   = DarkTheme.TextPrimary;
            this.Font        = new Font("Segoe UI", 10.5f);
        }
    }

    // ══════════════════════════════════════════════════════════════════
    //  LABEL STYLISÉ (champ)
    // ══════════════════════════════════════════════════════════════════
    public class FieldLabel : Label
    {
        public FieldLabel()
        {
            this.Font = new Font("Segoe UI", 8.5f, FontStyle.Bold);
            this.ForeColor = DarkTheme.TextSecondary;
            this.BackColor = Color.Transparent;
            this.AutoSize = true;
        }
    }

    // ══════════════════════════════════════════════════════════════════
    //  SÉPARATEUR HORIZONTAL
    // ══════════════════════════════════════════════════════════════════
    public class DarkSeparator : Panel
    {
        public DarkSeparator()
        {
            this.Height = 1;
            this.BackColor = DarkTheme.BgBorder;
        }
    }

    // ══════════════════════════════════════════════════════════════════
    //  BADGE STATUT
    // ══════════════════════════════════════════════════════════════════
    public class StatusBadge : Label
    {
        public enum BadgeType { Success, Warning, Danger, Info }
        public BadgeType Type { get; set; } = BadgeType.Info;

        public StatusBadge()
        {
            this.AutoSize = false;
            this.Size = new Size(90, 24);
            this.Font = new Font("Segoe UI", 8.5f, FontStyle.Bold);
            this.TextAlign = ContentAlignment.MiddleCenter;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            var g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            Color bg, fg;
            switch (Type)
            {
                case BadgeType.Success: bg = Color.FromArgb(30,16,185,129); fg = DarkTheme.Emerald; break;
                case BadgeType.Warning: bg = Color.FromArgb(30,217,119,6);  fg = DarkTheme.Amber; break;
                case BadgeType.Danger:  bg = Color.FromArgb(30,239,68,68);  fg = DarkTheme.Danger; break;
                default:               bg = Color.FromArgb(30,99,102,241); fg = Color.FromArgb(129,140,248); break;
            }

            using (var path = RoundedPanel.RoundedRect(new Rectangle(0,0,Width-1,Height-1), 12))
            {
                using (var brush = new SolidBrush(bg)) g.FillPath(brush, path);
                using (var pen = new Pen(fg, 1)) g.DrawPath(pen, path);
            }
            using (var brush = new SolidBrush(fg))
            {
                var sf = new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center };
                g.DrawString(Text, Font, brush, new RectangleF(0,0,Width,Height), sf);
            }
        }
    }

    // ══════════════════════════════════════════════════════════════════
    //  HELPERS POUR CRÉER DES CHAMPS DE FORMULAIRE COHÉRENTS
    // ══════════════════════════════════════════════════════════════════
    public static class FormBuilder
    {
        /// <summary>Crée un ensemble Label + Panel conteneur TextBox stylisé</summary>
        public static (Label lbl, Panel container, TextBox txt) CreateField(
            string labelText, Point location, int width = 280, bool isPassword = false)
        {
            var lbl = new Label
            {
                Text = labelText.ToUpper(),
                Font = new Font("Segoe UI", 8.5f, FontStyle.Bold),
                ForeColor = DarkTheme.TextSecondary,
                BackColor = Color.Transparent,
                AutoSize = true,
                Location = location
            };

            var container = new RoundedPanel
            {
                BackColor = DarkTheme.BgHover,
                Location = new Point(location.X, location.Y + 22),
                Size = new Size(width, 40),
                CornerRadius = 8,
                ShowBorder = true,
                BorderColor = DarkTheme.BgBorder,
                ShowShadow = false
            };

            var txt = new TextBox
            {
                BorderStyle = BorderStyle.None,
                BackColor = DarkTheme.BgHover,
                ForeColor = DarkTheme.TextPrimary,
                Font = new Font("Segoe UI", 10.5f),
                Location = new Point(10, 8),
                Width = width - 20,
                UseSystemPasswordChar = isPassword
            };

            container.Controls.Add(txt);
            return (lbl, container, txt);
        }

        /// <summary>Crée un combo stylisé avec son label</summary>
        public static (Label lbl, ComboBox cbb) CreateCombo(
            string labelText, Point location, int width = 280)
        {
            var lbl = new Label
            {
                Text = labelText.ToUpper(),
                Font = new Font("Segoe UI", 8.5f, FontStyle.Bold),
                ForeColor = DarkTheme.TextSecondary,
                BackColor = Color.Transparent,
                AutoSize = true,
                Location = location
            };

            var cbb = new ComboBox
            {
                BackColor = DarkTheme.BgHover,
                ForeColor = DarkTheme.TextPrimary,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Segoe UI", 10f),
                Location = new Point(location.X, location.Y + 22),
                Size = new Size(width, 36),
                FormattingEnabled = true,
                DropDownStyle = ComboBoxStyle.DropDownList
            };

            return (lbl, cbb);
        }
    }
}
