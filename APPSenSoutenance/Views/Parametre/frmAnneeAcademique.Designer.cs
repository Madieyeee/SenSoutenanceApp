using APPSenSoutenance.Shared;
using System.Drawing;
using System.Windows.Forms;
using System;

namespace APPSenSoutenance.Views.Parametre
{
    partial class frmAnneeAcademique
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.pnlHeader = new APPSenSoutenance.Shared.GradientPanel();
            this.lblHeaderTitle = new System.Windows.Forms.Label();
            this.lblHeaderSub = new System.Windows.Forms.Label();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.lblLibelle = new System.Windows.Forms.Label();
            this.txtLibelleAnneeAcademique = new System.Windows.Forms.TextBox();
            this.lblValeur = new System.Windows.Forms.Label();
            this.txtAnneeAcademiqueVal = new System.Windows.Forms.TextBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.dgAnneeAcademique = new System.Windows.Forms.DataGridView();
            this.pnlHeader.SuspendLayout();
            this.pnlLeft.SuspendLayout();
            this.pnlRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgAnneeAcademique)).BeginInit();
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
            this.lblHeaderTitle.Size = new System.Drawing.Size(300, 41);
            this.lblHeaderTitle.Text = "Gestion des Années";

            // lblHeaderSub
            this.lblHeaderSub.AutoSize = true;
            this.lblHeaderSub.BackColor = System.Drawing.Color.Transparent;
            this.lblHeaderSub.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblHeaderSub.ForeColor = DarkTheme.TextSecondary;
            this.lblHeaderSub.Location = new System.Drawing.Point(64, 38);
            this.lblHeaderSub.Name = "lblHeaderSub";
            this.lblHeaderSub.Size = new System.Drawing.Size(410, 25);
            this.lblHeaderSub.Text = "Configuration des périodes académiques globales";

            // pnlLeft
            this.pnlLeft.BackColor = DarkTheme.BgCard;
            this.pnlLeft.Controls.Add(this.lblLibelle);
            this.pnlLeft.Controls.Add(this.txtLibelleAnneeAcademique);
            this.pnlLeft.Controls.Add(this.lblValeur);
            this.pnlLeft.Controls.Add(this.txtAnneeAcademiqueVal);
            this.pnlLeft.Controls.Add(this.btnSelect);
            this.pnlLeft.Controls.Add(this.btnAdd);
            this.pnlLeft.Controls.Add(this.btnEdit);
            this.pnlLeft.Controls.Add(this.btnRemove);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 72);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Padding = new System.Windows.Forms.Padding(20);
            this.pnlLeft.Size = new System.Drawing.Size(360, 628);

            // lblLibelle
            this.lblLibelle.AutoSize = true;
            this.lblLibelle.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblLibelle.ForeColor = DarkTheme.TextSecondary;
            this.lblLibelle.Location = new System.Drawing.Point(20, 20);
            this.lblLibelle.Name = "lblLibelle";
            this.lblLibelle.Size = new System.Drawing.Size(77, 23);
            this.lblLibelle.Text = "LIBELLÉ";

            // txtLibelleAnneeAcademique
            this.txtLibelleAnneeAcademique.BackColor = DarkTheme.BgHover;
            this.txtLibelleAnneeAcademique.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLibelleAnneeAcademique.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtLibelleAnneeAcademique.ForeColor = DarkTheme.TextPrimary;
            this.txtLibelleAnneeAcademique.Location = new System.Drawing.Point(20, 45);
            this.txtLibelleAnneeAcademique.Name = "txtLibelleAnneeAcademique";
            this.txtLibelleAnneeAcademique.Size = new System.Drawing.Size(320, 34);
            this.txtLibelleAnneeAcademique.TabIndex = 1;

            // lblValeur
            this.lblValeur.AutoSize = true;
            this.lblValeur.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblValeur.ForeColor = DarkTheme.TextSecondary;
            this.lblValeur.Location = new System.Drawing.Point(20, 95);
            this.lblValeur.Name = "lblValeur";
            this.lblValeur.Size = new System.Drawing.Size(75, 23);
            this.lblValeur.Text = "VALEUR";

            // txtAnneeAcademiqueVal
            this.txtAnneeAcademiqueVal.BackColor = DarkTheme.BgHover;
            this.txtAnneeAcademiqueVal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAnneeAcademiqueVal.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtAnneeAcademiqueVal.ForeColor = DarkTheme.TextPrimary;
            this.txtAnneeAcademiqueVal.Location = new System.Drawing.Point(20, 120);
            this.txtAnneeAcademiqueVal.Name = "txtAnneeAcademiqueVal";
            this.txtAnneeAcademiqueVal.Size = new System.Drawing.Size(320, 34);
            this.txtAnneeAcademiqueVal.TabIndex = 2;

            // btnSelect
            this.btnSelect.BackColor = Color.FromArgb(16, 185, 129); // Emerald
            this.btnSelect.FlatAppearance.BorderSize = 0;
            this.btnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelect.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSelect.ForeColor = System.Drawing.Color.White;
            this.btnSelect.Location = new System.Drawing.Point(20, 180);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(320, 32);
            this.btnSelect.TabIndex = 3;
            this.btnSelect.Text = "Sélectionner la ligne active";
            this.btnSelect.UseVisualStyleBackColor = false;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);

            // btnAdd
            this.btnAdd.BackColor = DarkTheme.Amber;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(20, 240);
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
            this.btnEdit.Location = new System.Drawing.Point(20, 290);
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
            this.btnRemove.Location = new System.Drawing.Point(185, 290);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(155, 40);
            this.btnRemove.TabIndex = 6;
            this.btnRemove.Text = "Supprimer";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);

            // pnlRight
            this.pnlRight.BackColor = DarkTheme.BgPrincipal;
            this.pnlRight.Controls.Add(this.dgAnneeAcademique);
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRight.Location = new System.Drawing.Point(360, 72);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Padding = new System.Windows.Forms.Padding(16);
            this.pnlRight.Size = new System.Drawing.Size(740, 628);

            // dgAnneeAcademique
            this.dgAnneeAcademique.AllowUserToAddRows = false;
            this.dgAnneeAcademique.AllowUserToDeleteRows = false;
            this.dgAnneeAcademique.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgAnneeAcademique.BackgroundColor = DarkTheme.BgPrincipal;
            this.dgAnneeAcademique.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgAnneeAcademique.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAnneeAcademique.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgAnneeAcademique.Location = new System.Drawing.Point(16, 16);
            this.dgAnneeAcademique.Name = "dgAnneeAcademique";
            this.dgAnneeAcademique.ReadOnly = true;
            this.dgAnneeAcademique.RowHeadersVisible = false;
            this.dgAnneeAcademique.Size = new System.Drawing.Size(708, 596);
            this.dgAnneeAcademique.TabIndex = 0;

            // frmAnneeAcademique
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = DarkTheme.BgPrincipal;
            this.ClientSize = new System.Drawing.Size(1100, 700);
            this.Controls.Add(this.pnlRight);
            this.Controls.Add(this.pnlLeft);
            this.Controls.Add(this.pnlHeader);
            this.Name = "frmAnneeAcademique";
            this.Text = "Années Académiques";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlLeft.ResumeLayout(false);
            this.pnlLeft.PerformLayout();
            this.pnlRight.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgAnneeAcademique)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        private APPSenSoutenance.Shared.GradientPanel pnlHeader;
        private System.Windows.Forms.Label lblHeaderTitle;
        private System.Windows.Forms.Label lblHeaderSub;
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.Label lblLibelle;
        private System.Windows.Forms.TextBox txtLibelleAnneeAcademique;
        private System.Windows.Forms.Label lblValeur;
        private System.Windows.Forms.TextBox txtAnneeAcademiqueVal;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.DataGridView dgAnneeAcademique;
    }
}