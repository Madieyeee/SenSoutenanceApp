using APPSenSoutenance.Shared;
using System.Drawing;
using System.Windows.Forms;

namespace APPSenSoutenance.Views.Parametre
{
    partial class frmSession
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
            this.lblSession = new System.Windows.Forms.Label();
            this.txtSession = new System.Windows.Forms.TextBox();
            this.lblAnnee = new System.Windows.Forms.Label();
            this.cbbAnneeAcademique = new System.Windows.Forms.ComboBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.dgSession = new System.Windows.Forms.DataGridView();
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.lblRSession = new System.Windows.Forms.Label();
            this.txtRSession = new System.Windows.Forms.TextBox();
            this.lblRAnnee = new System.Windows.Forms.Label();
            this.txtRanneeAcademique = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.pnlHeader.SuspendLayout();
            this.pnlLeft.SuspendLayout();
            this.pnlRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSession)).BeginInit();
            this.pnlSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.Controls.Add(this.lblHeaderTitle);
            this.pnlHeader.Controls.Add(this.lblHeaderSub);
            this.pnlHeader.CornerRadius = 0;
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.GradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(18)))), ((int)(((byte)(16)))));
            this.pnlHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.pnlHeader.GradientStart = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(25)))), ((int)(((byte)(23)))));
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1100, 82);
            this.pnlHeader.TabIndex = 2;
            // 
            // lblHeaderTitle
            // 
            this.lblHeaderTitle.AutoSize = true;
            this.lblHeaderTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblHeaderTitle.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblHeaderTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(249)))));
            this.lblHeaderTitle.Location = new System.Drawing.Point(62, 10);
            this.lblHeaderTitle.Name = "lblHeaderTitle";
            this.lblHeaderTitle.Size = new System.Drawing.Size(306, 41);
            this.lblHeaderTitle.TabIndex = 0;
            this.lblHeaderTitle.Text = "Gestion des Sessions";
            // 
            // lblHeaderSub
            // 
            this.lblHeaderSub.AutoSize = true;
            this.lblHeaderSub.BackColor = System.Drawing.Color.Transparent;
            this.lblHeaderSub.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblHeaderSub.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(162)))), ((int)(((byte)(158)))));
            this.lblHeaderSub.Location = new System.Drawing.Point(64, 51);
            this.lblHeaderSub.Name = "lblHeaderSub";
            this.lblHeaderSub.Size = new System.Drawing.Size(316, 25);
            this.lblHeaderSub.TabIndex = 1;
            this.lblHeaderSub.Text = "Définition des périodes de soutenance";
            // 
            // pnlLeft
            // 
            this.pnlLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(25)))), ((int)(((byte)(23)))));
            this.pnlLeft.Controls.Add(this.lblSession);
            this.pnlLeft.Controls.Add(this.txtSession);
            this.pnlLeft.Controls.Add(this.lblAnnee);
            this.pnlLeft.Controls.Add(this.cbbAnneeAcademique);
            this.pnlLeft.Controls.Add(this.btnSelect);
            this.pnlLeft.Controls.Add(this.btnAdd);
            this.pnlLeft.Controls.Add(this.btnEdit);
            this.pnlLeft.Controls.Add(this.btnRemove);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 82);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Padding = new System.Windows.Forms.Padding(20);
            this.pnlLeft.Size = new System.Drawing.Size(360, 618);
            this.pnlLeft.TabIndex = 1;
            // 
            // lblSession
            // 
            this.lblSession.AutoSize = true;
            this.lblSession.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblSession.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(162)))), ((int)(((byte)(158)))));
            this.lblSession.Location = new System.Drawing.Point(20, 20);
            this.lblSession.Name = "lblSession";
            this.lblSession.Size = new System.Drawing.Size(127, 23);
            this.lblSession.TabIndex = 0;
            this.lblSession.Text = "NOM SESSION";
            // 
            // txtSession
            // 
            this.txtSession.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(37)))), ((int)(((byte)(36)))));
            this.txtSession.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSession.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSession.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(228)))));
            this.txtSession.Location = new System.Drawing.Point(20, 45);
            this.txtSession.Name = "txtSession";
            this.txtSession.Size = new System.Drawing.Size(320, 34);
            this.txtSession.TabIndex = 1;
            // 
            // lblAnnee
            // 
            this.lblAnnee.AutoSize = true;
            this.lblAnnee.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblAnnee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(162)))), ((int)(((byte)(158)))));
            this.lblAnnee.Location = new System.Drawing.Point(20, 95);
            this.lblAnnee.Name = "lblAnnee";
            this.lblAnnee.Size = new System.Drawing.Size(183, 23);
            this.lblAnnee.TabIndex = 2;
            this.lblAnnee.Text = "ANNÉE ACADÉMIQUE";
            // 
            // cbbAnneeAcademique
            // 
            this.cbbAnneeAcademique.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(37)))), ((int)(((byte)(36)))));
            this.cbbAnneeAcademique.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbbAnneeAcademique.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbbAnneeAcademique.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(228)))));
            this.cbbAnneeAcademique.Location = new System.Drawing.Point(20, 120);
            this.cbbAnneeAcademique.Name = "cbbAnneeAcademique";
            this.cbbAnneeAcademique.Size = new System.Drawing.Size(320, 36);
            this.cbbAnneeAcademique.TabIndex = 2;
            // 
            // btnSelect
            // 
            this.btnSelect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
            this.btnSelect.FlatAppearance.BorderSize = 0;
            this.btnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelect.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSelect.ForeColor = System.Drawing.Color.White;
            this.btnSelect.Location = new System.Drawing.Point(20, 180);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(320, 30);
            this.btnSelect.TabIndex = 3;
            this.btnSelect.Text = "Sélectionner la ligne active";
            this.btnSelect.UseVisualStyleBackColor = false;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(119)))), ((int)(((byte)(6)))));
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
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(37)))), ((int)(((byte)(36)))));
            this.btnEdit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(119)))), ((int)(((byte)(6)))));
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(119)))), ((int)(((byte)(6)))));
            this.btnEdit.Location = new System.Drawing.Point(20, 290);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(155, 40);
            this.btnEdit.TabIndex = 5;
            this.btnEdit.Text = "Modifier";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
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
            // 
            // pnlRight
            // 
            this.pnlRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(10)))), ((int)(((byte)(9)))));
            this.pnlRight.Controls.Add(this.dgSession);
            this.pnlRight.Controls.Add(this.pnlSearch);
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRight.Location = new System.Drawing.Point(360, 82);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Padding = new System.Windows.Forms.Padding(16);
            this.pnlRight.Size = new System.Drawing.Size(740, 618);
            this.pnlRight.TabIndex = 0;
            // 
            // dgSession
            // 
            this.dgSession.AllowUserToAddRows = false;
            this.dgSession.AllowUserToDeleteRows = false;
            this.dgSession.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgSession.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(10)))), ((int)(((byte)(9)))));
            this.dgSession.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgSession.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSession.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgSession.Location = new System.Drawing.Point(16, 96);
            this.dgSession.Name = "dgSession";
            this.dgSession.ReadOnly = true;
            this.dgSession.RowHeadersVisible = false;
            this.dgSession.RowHeadersWidth = 62;
            this.dgSession.Size = new System.Drawing.Size(708, 506);
            this.dgSession.TabIndex = 0;
            // 
            // pnlSearch
            // 
            this.pnlSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(25)))), ((int)(((byte)(23)))));
            this.pnlSearch.Controls.Add(this.lblRSession);
            this.pnlSearch.Controls.Add(this.txtRSession);
            this.pnlSearch.Controls.Add(this.lblRAnnee);
            this.pnlSearch.Controls.Add(this.txtRanneeAcademique);
            this.pnlSearch.Controls.Add(this.btnSearch);
            this.pnlSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSearch.Location = new System.Drawing.Point(16, 16);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Padding = new System.Windows.Forms.Padding(10);
            this.pnlSearch.Size = new System.Drawing.Size(708, 80);
            this.pnlSearch.TabIndex = 1;
            // 
            // lblRSession
            // 
            this.lblRSession.AutoSize = true;
            this.lblRSession.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(162)))), ((int)(((byte)(158)))));
            this.lblRSession.Location = new System.Drawing.Point(10, 15);
            this.lblRSession.Name = "lblRSession";
            this.lblRSession.Size = new System.Drawing.Size(135, 20);
            this.lblRSession.TabIndex = 0;
            this.lblRSession.Text = "Chercher Session";
            // 
            // txtRSession
            // 
            this.txtRSession.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(37)))), ((int)(((byte)(36)))));
            this.txtRSession.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRSession.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(228)))));
            this.txtRSession.Location = new System.Drawing.Point(10, 35);
            this.txtRSession.Name = "txtRSession";
            this.txtRSession.Size = new System.Drawing.Size(200, 26);
            this.txtRSession.TabIndex = 1;
            // 
            // lblRAnnee
            // 
            this.lblRAnnee.AutoSize = true;
            this.lblRAnnee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(162)))), ((int)(((byte)(158)))));
            this.lblRAnnee.Location = new System.Drawing.Point(220, 15);
            this.lblRAnnee.Name = "lblRAnnee";
            this.lblRAnnee.Size = new System.Drawing.Size(125, 20);
            this.lblRAnnee.TabIndex = 2;
            this.lblRAnnee.Text = "Chercher Année";
            // 
            // txtRanneeAcademique
            // 
            this.txtRanneeAcademique.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(37)))), ((int)(((byte)(36)))));
            this.txtRanneeAcademique.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRanneeAcademique.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(228)))));
            this.txtRanneeAcademique.Location = new System.Drawing.Point(220, 35);
            this.txtRanneeAcademique.Name = "txtRanneeAcademique";
            this.txtRanneeAcademique.Size = new System.Drawing.Size(200, 26);
            this.txtRanneeAcademique.TabIndex = 3;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(119)))), ((int)(((byte)(6)))));
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(430, 30);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(140, 35);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "🔍 Rechercher";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // frmSession
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(10)))), ((int)(((byte)(9)))));
            this.ClientSize = new System.Drawing.Size(1100, 700);
            this.ControlBox = false;
            this.Controls.Add(this.pnlRight);
            this.Controls.Add(this.pnlLeft);
            this.Controls.Add(this.pnlHeader);
            this.Name = "frmSession";
            this.Text = "Sessions";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlLeft.ResumeLayout(false);
            this.pnlLeft.PerformLayout();
            this.pnlRight.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgSession)).EndInit();
            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion

        private APPSenSoutenance.Shared.GradientPanel pnlHeader;
        private System.Windows.Forms.Label lblHeaderTitle;
        private System.Windows.Forms.Label lblHeaderSub;
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.Panel pnlSearch;
        private System.Windows.Forms.Label lblSession;
        private System.Windows.Forms.TextBox txtSession;
        private System.Windows.Forms.Label lblAnnee;
        private System.Windows.Forms.ComboBox cbbAnneeAcademique;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.DataGridView dgSession;
        private System.Windows.Forms.TextBox txtRSession;
        private System.Windows.Forms.TextBox txtRanneeAcademique;
        private System.Windows.Forms.Label lblRSession;
        private System.Windows.Forms.Label lblRAnnee;
        private System.Windows.Forms.Button btnSearch;
    }
}
