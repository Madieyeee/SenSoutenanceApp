using APPSenSoutenance.Shared;
using System.Drawing;
using System.Windows.Forms;

namespace APPSenSoutenance.Views.Parametre
{
    partial class frmSoutenance
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
            this.lblDate = new System.Windows.Forms.Label();
            this.cbbDateSoutenance = new System.Windows.Forms.ComboBox();
            this.lblLieu = new System.Windows.Forms.Label();
            this.txtLieuSoutenance = new System.Windows.Forms.TextBox();
            this.lblResultat = new System.Windows.Forms.Label();
            this.txtResultatSoutenance = new System.Windows.Forms.TextBox();
            this.lblMention = new System.Windows.Forms.Label();
            this.txtMentionSoutenance = new System.Windows.Forms.TextBox();
            this.lblObs = new System.Windows.Forms.Label();
            this.txtObservation = new System.Windows.Forms.TextBox();
            this.lblMemoire = new System.Windows.Forms.Label();
            this.cbbMemoire = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pnlHeader.SuspendLayout();
            this.pnlLeft.SuspendLayout();
            this.pnlRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.lblHeaderTitle.Text = "Gestion des Soutenances";

            // lblHeaderSub
            this.lblHeaderSub.AutoSize = true;
            this.lblHeaderSub.BackColor = System.Drawing.Color.Transparent;
            this.lblHeaderSub.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblHeaderSub.ForeColor = DarkTheme.TextSecondary;
            this.lblHeaderSub.Location = new System.Drawing.Point(64, 38);
            this.lblHeaderSub.Name = "lblHeaderSub";
            this.lblHeaderSub.Size = new System.Drawing.Size(400, 25);
            this.lblHeaderSub.Text = "Planification et résultats des soutenances";

            // pnlLeft
            this.pnlLeft.BackColor = DarkTheme.BgCard;
            this.pnlLeft.Controls.Add(this.lblDate);
            this.pnlLeft.Controls.Add(this.cbbDateSoutenance);
            this.pnlLeft.Controls.Add(this.lblLieu);
            this.pnlLeft.Controls.Add(this.txtLieuSoutenance);
            this.pnlLeft.Controls.Add(this.lblResultat);
            this.pnlLeft.Controls.Add(this.txtResultatSoutenance);
            this.pnlLeft.Controls.Add(this.lblMention);
            this.pnlLeft.Controls.Add(this.txtMentionSoutenance);
            this.pnlLeft.Controls.Add(this.lblObs);
            this.pnlLeft.Controls.Add(this.txtObservation);
            this.pnlLeft.Controls.Add(this.lblMemoire);
            this.pnlLeft.Controls.Add(this.cbbMemoire);
            this.pnlLeft.Controls.Add(this.btnAdd);
            this.pnlLeft.Controls.Add(this.btnEdit);
            this.pnlLeft.Controls.Add(this.btnRemove);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 72);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Padding = new System.Windows.Forms.Padding(20);
            this.pnlLeft.Size = new System.Drawing.Size(360, 628);

            // lblDate
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblDate.ForeColor = DarkTheme.TextSecondary;
            this.lblDate.Location = new System.Drawing.Point(20, 20);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(150, 23);
            this.lblDate.Text = "DATE SOUTENANCE";

            // cbbDateSoutenance
            this.cbbDateSoutenance.BackColor = DarkTheme.BgHover;
            this.cbbDateSoutenance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbbDateSoutenance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbbDateSoutenance.ForeColor = DarkTheme.TextPrimary;
            this.cbbDateSoutenance.Location = new System.Drawing.Point(20, 45);
            this.cbbDateSoutenance.Name = "cbbDateSoutenance";
            this.cbbDateSoutenance.Size = new System.Drawing.Size(320, 36);
            this.cbbDateSoutenance.TabIndex = 1;

            // lblLieu
            this.lblLieu.AutoSize = true;
            this.lblLieu.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblLieu.ForeColor = DarkTheme.TextSecondary;
            this.lblLieu.Location = new System.Drawing.Point(20, 95);
            this.lblLieu.Name = "lblLieu";
            this.lblLieu.Size = new System.Drawing.Size(161, 23);
            this.lblLieu.Text = "LIEU SOUTENANCE";

            // txtLieuSoutenance
            this.txtLieuSoutenance.BackColor = DarkTheme.BgHover;
            this.txtLieuSoutenance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLieuSoutenance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtLieuSoutenance.ForeColor = DarkTheme.TextPrimary;
            this.txtLieuSoutenance.Location = new System.Drawing.Point(20, 120);
            this.txtLieuSoutenance.Name = "txtLieuSoutenance";
            this.txtLieuSoutenance.Size = new System.Drawing.Size(320, 34);
            this.txtLieuSoutenance.TabIndex = 2;

            // lblResultat
            this.lblResultat.AutoSize = true;
            this.lblResultat.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblResultat.ForeColor = DarkTheme.TextSecondary;
            this.lblResultat.Location = new System.Drawing.Point(20, 170);
            this.lblResultat.Name = "lblResultat";
            this.lblResultat.Size = new System.Drawing.Size(92, 23);
            this.lblResultat.Text = "RÉSULTAT";

            // txtResultatSoutenance
            this.txtResultatSoutenance.BackColor = DarkTheme.BgHover;
            this.txtResultatSoutenance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtResultatSoutenance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtResultatSoutenance.ForeColor = DarkTheme.TextPrimary;
            this.txtResultatSoutenance.Location = new System.Drawing.Point(20, 195);
            this.txtResultatSoutenance.Name = "txtResultatSoutenance";
            this.txtResultatSoutenance.Size = new System.Drawing.Size(320, 34);
            this.txtResultatSoutenance.TabIndex = 3;

            // lblMention
            this.lblMention.AutoSize = true;
            this.lblMention.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblMention.ForeColor = DarkTheme.TextSecondary;
            this.lblMention.Location = new System.Drawing.Point(20, 245);
            this.lblMention.Name = "lblMention";
            this.lblMention.Size = new System.Drawing.Size(92, 23);
            this.lblMention.Text = "MENTION";

            // txtMentionSoutenance
            this.txtMentionSoutenance.BackColor = DarkTheme.BgHover;
            this.txtMentionSoutenance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMentionSoutenance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtMentionSoutenance.ForeColor = DarkTheme.TextPrimary;
            this.txtMentionSoutenance.Location = new System.Drawing.Point(20, 270);
            this.txtMentionSoutenance.Name = "txtMentionSoutenance";
            this.txtMentionSoutenance.Size = new System.Drawing.Size(320, 34);
            this.txtMentionSoutenance.TabIndex = 4;

            // lblObs
            this.lblObs.AutoSize = true;
            this.lblObs.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblObs.ForeColor = DarkTheme.TextSecondary;
            this.lblObs.Location = new System.Drawing.Point(20, 320);
            this.lblObs.Name = "lblObs";
            this.lblObs.Size = new System.Drawing.Size(126, 23);
            this.lblObs.Text = "OBSERVATION";

            // txtObservation
            this.txtObservation.BackColor = DarkTheme.BgHover;
            this.txtObservation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtObservation.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtObservation.ForeColor = DarkTheme.TextPrimary;
            this.txtObservation.Location = new System.Drawing.Point(20, 345);
            this.txtObservation.Multiline = true;
            this.txtObservation.Name = "txtObservation";
            this.txtObservation.Size = new System.Drawing.Size(320, 60);
            this.txtObservation.TabIndex = 5;

            // lblMemoire
            this.lblMemoire.AutoSize = true;
            this.lblMemoire.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblMemoire.ForeColor = DarkTheme.TextSecondary;
            this.lblMemoire.Location = new System.Drawing.Point(20, 420);
            this.lblMemoire.Name = "lblMemoire";
            this.lblMemoire.Size = new System.Drawing.Size(92, 23);
            this.lblMemoire.Text = "MÉMOIRE";

            // cbbMemoire
            this.cbbMemoire.BackColor = DarkTheme.BgHover;
            this.cbbMemoire.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbbMemoire.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbbMemoire.ForeColor = DarkTheme.TextPrimary;
            this.cbbMemoire.Location = new System.Drawing.Point(20, 445);
            this.cbbMemoire.Name = "cbbMemoire";
            this.cbbMemoire.Size = new System.Drawing.Size(320, 36);
            this.cbbMemoire.TabIndex = 6;

            // btnAdd
            this.btnAdd.BackColor = DarkTheme.Amber;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(20, 510);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(320, 40);
            this.btnAdd.TabIndex = 7;
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
            this.btnEdit.Location = new System.Drawing.Point(20, 560);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(155, 40);
            this.btnEdit.TabIndex = 8;
            this.btnEdit.Text = "Modifier";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);

            // btnRemove
            this.btnRemove.BackColor = DarkTheme.Danger;
            this.btnRemove.FlatAppearance.BorderSize = 0;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnRemove.ForeColor = System.Drawing.Color.White;
            this.btnRemove.Location = new System.Drawing.Point(185, 560);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(155, 40);
            this.btnRemove.TabIndex = 9;
            this.btnRemove.Text = "Supprimer";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);

            // pnlRight
            this.pnlRight.BackColor = DarkTheme.BgPrincipal;
            this.pnlRight.Controls.Add(this.dataGridView1);
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRight.Location = new System.Drawing.Point(360, 72);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Padding = new System.Windows.Forms.Padding(16);
            this.pnlRight.Size = new System.Drawing.Size(740, 628);

            // dataGridView1
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = DarkTheme.BgPrincipal;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(16, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(708, 596);
            this.dataGridView1.TabIndex = 0;

            // frmSoutenance
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = DarkTheme.BgPrincipal;
            this.ClientSize = new System.Drawing.Size(1100, 700);
            this.Controls.Add(this.pnlRight);
            this.Controls.Add(this.pnlLeft);
            this.Controls.Add(this.pnlHeader);
            this.Name = "frmSoutenance";
            this.Text = "Soutenances";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlLeft.ResumeLayout(false);
            this.pnlLeft.PerformLayout();
            this.pnlRight.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        private APPSenSoutenance.Shared.GradientPanel pnlHeader;
        private System.Windows.Forms.Label lblHeaderTitle;
        private System.Windows.Forms.Label lblHeaderSub;
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.ComboBox cbbDateSoutenance;
        private System.Windows.Forms.Label lblLieu;
        private System.Windows.Forms.TextBox txtLieuSoutenance;
        private System.Windows.Forms.Label lblResultat;
        private System.Windows.Forms.TextBox txtResultatSoutenance;
        private System.Windows.Forms.Label lblMention;
        private System.Windows.Forms.TextBox txtMentionSoutenance;
        private System.Windows.Forms.Label lblObs;
        private System.Windows.Forms.TextBox txtObservation;
        private System.Windows.Forms.Label lblMemoire;
        private System.Windows.Forms.ComboBox cbbMemoire;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}