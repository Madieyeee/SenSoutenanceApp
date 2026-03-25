using APPSenSoutenance.Shared;
using System.Drawing;
using System.Windows.Forms;

namespace APPSenSoutenance.Views.Parametre
{
    partial class frmChefDepartement
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
            this.lblProf = new System.Windows.Forms.Label();
            this.cbbProfesseur = new System.Windows.Forms.ComboBox();
            this.lblDept = new System.Windows.Forms.Label();
            this.cbbDepartement = new System.Windows.Forms.ComboBox();
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
            this.pnlHeader.Size = new System.Drawing.Size(1100, 93);
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
            this.lblHeaderTitle.Size = new System.Drawing.Size(508, 41);
            this.lblHeaderTitle.TabIndex = 0;
            this.lblHeaderTitle.Text = "Assignation Chefs de Département";
            // 
            // lblHeaderSub
            // 
            this.lblHeaderSub.AutoSize = true;
            this.lblHeaderSub.BackColor = System.Drawing.Color.Transparent;
            this.lblHeaderSub.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblHeaderSub.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(162)))), ((int)(((byte)(158)))));
            this.lblHeaderSub.Location = new System.Drawing.Point(64, 51);
            this.lblHeaderSub.Name = "lblHeaderSub";
            this.lblHeaderSub.Size = new System.Drawing.Size(366, 25);
            this.lblHeaderSub.TabIndex = 1;
            this.lblHeaderSub.Text = "Gestion des responsabilités par département";
            // 
            // pnlLeft
            // 
            this.pnlLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(25)))), ((int)(((byte)(23)))));
            this.pnlLeft.Controls.Add(this.lblProf);
            this.pnlLeft.Controls.Add(this.cbbProfesseur);
            this.pnlLeft.Controls.Add(this.lblDept);
            this.pnlLeft.Controls.Add(this.cbbDepartement);
            this.pnlLeft.Controls.Add(this.btnAdd);
            this.pnlLeft.Controls.Add(this.btnEdit);
            this.pnlLeft.Controls.Add(this.btnRemove);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 93);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Padding = new System.Windows.Forms.Padding(20);
            this.pnlLeft.Size = new System.Drawing.Size(360, 607);
            this.pnlLeft.TabIndex = 1;
            // 
            // lblProf
            // 
            this.lblProf.AutoSize = true;
            this.lblProf.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblProf.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(162)))), ((int)(((byte)(158)))));
            this.lblProf.Location = new System.Drawing.Point(20, 20);
            this.lblProf.Name = "lblProf";
            this.lblProf.Size = new System.Drawing.Size(114, 23);
            this.lblProf.TabIndex = 0;
            this.lblProf.Text = "PROFESSEUR";
            // 
            // cbbProfesseur
            // 
            this.cbbProfesseur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(37)))), ((int)(((byte)(36)))));
            this.cbbProfesseur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbbProfesseur.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbbProfesseur.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(228)))));
            this.cbbProfesseur.Location = new System.Drawing.Point(20, 45);
            this.cbbProfesseur.Name = "cbbProfesseur";
            this.cbbProfesseur.Size = new System.Drawing.Size(320, 36);
            this.cbbProfesseur.TabIndex = 1;
            // 
            // lblDept
            // 
            this.lblDept.AutoSize = true;
            this.lblDept.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblDept.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(162)))), ((int)(((byte)(158)))));
            this.lblDept.Location = new System.Drawing.Point(20, 95);
            this.lblDept.Name = "lblDept";
            this.lblDept.Size = new System.Drawing.Size(131, 23);
            this.lblDept.TabIndex = 2;
            this.lblDept.Text = "DÉPARTEMENT";
            // 
            // cbbDepartement
            // 
            this.cbbDepartement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(37)))), ((int)(((byte)(36)))));
            this.cbbDepartement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbbDepartement.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbbDepartement.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(228)))));
            this.cbbDepartement.Location = new System.Drawing.Point(20, 120);
            this.cbbDepartement.Name = "cbbDepartement";
            this.cbbDepartement.Size = new System.Drawing.Size(320, 36);
            this.cbbDepartement.TabIndex = 2;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(119)))), ((int)(((byte)(6)))));
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(20, 200);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(320, 40);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Assigner";
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
            this.btnEdit.Location = new System.Drawing.Point(20, 250);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(155, 40);
            this.btnEdit.TabIndex = 4;
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
            this.btnRemove.Location = new System.Drawing.Point(185, 250);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(155, 40);
            this.btnRemove.TabIndex = 5;
            this.btnRemove.Text = "Révoquer";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // pnlRight
            // 
            this.pnlRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(10)))), ((int)(((byte)(9)))));
            this.pnlRight.Controls.Add(this.dataGridView1);
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRight.Location = new System.Drawing.Point(360, 93);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Padding = new System.Windows.Forms.Padding(16);
            this.pnlRight.Size = new System.Drawing.Size(740, 607);
            this.pnlRight.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(10)))), ((int)(((byte)(9)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(16, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(708, 575);
            this.dataGridView1.TabIndex = 0;
            // 
            // frmChefDepartement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(10)))), ((int)(((byte)(9)))));
            this.ClientSize = new System.Drawing.Size(1100, 700);
            this.ControlBox = false;
            this.Controls.Add(this.pnlRight);
            this.Controls.Add(this.pnlLeft);
            this.Controls.Add(this.pnlHeader);
            this.Name = "frmChefDepartement";
            this.Text = "Chefs de Département";
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
        private System.Windows.Forms.Label lblProf;
        private System.Windows.Forms.ComboBox cbbProfesseur;
        private System.Windows.Forms.Label lblDept;
        private System.Windows.Forms.ComboBox cbbDepartement;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}