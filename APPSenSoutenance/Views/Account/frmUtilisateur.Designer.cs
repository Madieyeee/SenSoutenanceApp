namespace APPSenSoutenance.Views.Account
{
    partial class frmUtilisateur
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabCandidat = new System.Windows.Forms.TabPage();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.txtMatricule = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabProfesseur = new System.Windows.Forms.TabPage();
            this.btnPSupprimer = new System.Windows.Forms.Button();
            this.btnPModifier = new System.Windows.Forms.Button();
            this.btnPAjouter = new System.Windows.Forms.Button();
            this.txtPSpecialite = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPTel = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPEmail = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPPrenom = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPNom = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tabChefDepartement = new System.Windows.Forms.TabPage();
            this.btnCSupprimer = new System.Windows.Forms.Button();
            this.btnCModifier = new System.Windows.Forms.Button();
            this.btnCAjouter = new System.Windows.Forms.Button();
            this.txtCDepartement = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtCTel = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtCEmail = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtCPrenom = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtCNom = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.dgUtilisateur = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabCandidat.SuspendLayout();
            this.tabProfesseur.SuspendLayout();
            this.tabChefDepartement.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgUtilisateur)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabCandidat);
            this.tabControl1.Controls.Add(this.tabProfesseur);
            this.tabControl1.Controls.Add(this.tabChefDepartement);
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(589, 643);
            this.tabControl1.TabIndex = 0;
            // 
            // tabCandidat
            // 
            this.tabCandidat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(245)))));
            this.tabCandidat.Controls.Add(this.btnSupprimer);
            this.tabCandidat.Controls.Add(this.btnModifier);
            this.tabCandidat.Controls.Add(this.btnAjouter);
            this.tabCandidat.Controls.Add(this.txtMatricule);
            this.tabCandidat.Controls.Add(this.label5);
            this.tabCandidat.Controls.Add(this.txtTel);
            this.tabCandidat.Controls.Add(this.label4);
            this.tabCandidat.Controls.Add(this.txtEmail);
            this.tabCandidat.Controls.Add(this.label3);
            this.tabCandidat.Controls.Add(this.txtPrenom);
            this.tabCandidat.Controls.Add(this.label2);
            this.tabCandidat.Controls.Add(this.txtNom);
            this.tabCandidat.Controls.Add(this.label1);
            this.tabCandidat.Location = new System.Drawing.Point(4, 39);
            this.tabCandidat.Name = "tabCandidat";
            this.tabCandidat.Padding = new System.Windows.Forms.Padding(3);
            this.tabCandidat.Size = new System.Drawing.Size(581, 600);
            this.tabCandidat.TabIndex = 0;
            this.tabCandidat.Text = "📋 Candidat";
            this.tabCandidat.UseVisualStyleBackColor = true;
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnSupprimer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSupprimer.FlatAppearance.BorderSize = 0;
            this.btnSupprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSupprimer.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSupprimer.ForeColor = System.Drawing.Color.White;
            this.btnSupprimer.Location = new System.Drawing.Point(305, 504);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(150, 50);
            this.btnSupprimer.TabIndex = 8;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = false;
            // 
            // btnModifier
            // 
            this.btnModifier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnModifier.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModifier.FlatAppearance.BorderSize = 0;
            this.btnModifier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModifier.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnModifier.ForeColor = System.Drawing.Color.White;
            this.btnModifier.Location = new System.Drawing.Point(305, 441);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(150, 50);
            this.btnModifier.TabIndex = 7;
            this.btnModifier.Text = "✏️ Modifier";
            this.btnModifier.UseVisualStyleBackColor = false;
            // 
            // btnAjouter
            // 
            this.btnAjouter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnAjouter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAjouter.FlatAppearance.BorderSize = 0;
            this.btnAjouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjouter.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAjouter.ForeColor = System.Drawing.Color.White;
            this.btnAjouter.Location = new System.Drawing.Point(305, 378);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(150, 50);
            this.btnAjouter.TabIndex = 6;
            this.btnAjouter.Text = "➕ Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = false;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // txtMatricule
            // 
            this.txtMatricule.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMatricule.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtMatricule.Location = new System.Drawing.Point(15, 330);
            this.txtMatricule.Name = "txtMatricule";
            this.txtMatricule.Size = new System.Drawing.Size(270, 34);
            this.txtMatricule.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.label5.Location = new System.Drawing.Point(15, 298);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 28);
            this.label5.TabIndex = 8;
            this.label5.Text = "Matricule:";
            // 
            // txtTel
            // 
            this.txtTel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtTel.Location = new System.Drawing.Point(15, 260);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(270, 34);
            this.txtTel.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.label4.Location = new System.Drawing.Point(15, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 28);
            this.label4.TabIndex = 6;
            this.label4.Text = "Téléphone:";
            // 
            // txtEmail
            // 
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtEmail.Location = new System.Drawing.Point(15, 190);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(270, 34);
            this.txtEmail.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.label3.Location = new System.Drawing.Point(15, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 28);
            this.label3.TabIndex = 4;
            this.label3.Text = "Email:";
            // 
            // txtPrenom
            // 
            this.txtPrenom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrenom.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPrenom.Location = new System.Drawing.Point(15, 120);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(270, 34);
            this.txtPrenom.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.label2.Location = new System.Drawing.Point(15, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "Prénom:";
            // 
            // txtNom
            // 
            this.txtNom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNom.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtNom.Location = new System.Drawing.Point(15, 50);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(270, 34);
            this.txtNom.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.label1.Location = new System.Drawing.Point(15, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom:";
            // 
            // tabProfesseur
            // 
            this.tabProfesseur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(245)))));
            this.tabProfesseur.Controls.Add(this.btnPSupprimer);
            this.tabProfesseur.Controls.Add(this.btnPModifier);
            this.tabProfesseur.Controls.Add(this.btnPAjouter);
            this.tabProfesseur.Controls.Add(this.txtPSpecialite);
            this.tabProfesseur.Controls.Add(this.label6);
            this.tabProfesseur.Controls.Add(this.txtPTel);
            this.tabProfesseur.Controls.Add(this.label7);
            this.tabProfesseur.Controls.Add(this.txtPEmail);
            this.tabProfesseur.Controls.Add(this.label8);
            this.tabProfesseur.Controls.Add(this.txtPPrenom);
            this.tabProfesseur.Controls.Add(this.label9);
            this.tabProfesseur.Controls.Add(this.txtPNom);
            this.tabProfesseur.Controls.Add(this.label10);
            this.tabProfesseur.Location = new System.Drawing.Point(4, 39);
            this.tabProfesseur.Name = "tabProfesseur";
            this.tabProfesseur.Padding = new System.Windows.Forms.Padding(3);
            this.tabProfesseur.Size = new System.Drawing.Size(499, 600);
            this.tabProfesseur.TabIndex = 1;
            this.tabProfesseur.Text = "👨‍🏫 Professeur";
            this.tabProfesseur.UseVisualStyleBackColor = true;
            // 
            // btnPSupprimer
            // 
            this.btnPSupprimer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnPSupprimer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPSupprimer.FlatAppearance.BorderSize = 0;
            this.btnPSupprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPSupprimer.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnPSupprimer.ForeColor = System.Drawing.Color.White;
            this.btnPSupprimer.Location = new System.Drawing.Point(305, 503);
            this.btnPSupprimer.Name = "btnPSupprimer";
            this.btnPSupprimer.Size = new System.Drawing.Size(150, 50);
            this.btnPSupprimer.TabIndex = 20;
            this.btnPSupprimer.Text = "Supprimer";
            this.btnPSupprimer.UseVisualStyleBackColor = false;
            // 
            // btnPModifier
            // 
            this.btnPModifier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnPModifier.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPModifier.FlatAppearance.BorderSize = 0;
            this.btnPModifier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPModifier.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnPModifier.ForeColor = System.Drawing.Color.White;
            this.btnPModifier.Location = new System.Drawing.Point(305, 440);
            this.btnPModifier.Name = "btnPModifier";
            this.btnPModifier.Size = new System.Drawing.Size(150, 50);
            this.btnPModifier.TabIndex = 19;
            this.btnPModifier.Text = "✏️ Modifier";
            this.btnPModifier.UseVisualStyleBackColor = false;
            // 
            // btnPAjouter
            // 
            this.btnPAjouter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnPAjouter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPAjouter.FlatAppearance.BorderSize = 0;
            this.btnPAjouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPAjouter.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnPAjouter.ForeColor = System.Drawing.Color.White;
            this.btnPAjouter.Location = new System.Drawing.Point(305, 377);
            this.btnPAjouter.Name = "btnPAjouter";
            this.btnPAjouter.Size = new System.Drawing.Size(150, 50);
            this.btnPAjouter.TabIndex = 17;
            this.btnPAjouter.Text = "➕ Ajouter";
            this.btnPAjouter.UseVisualStyleBackColor = false;
            // 
            // txtPSpecialite
            // 
            this.txtPSpecialite.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPSpecialite.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPSpecialite.Location = new System.Drawing.Point(15, 329);
            this.txtPSpecialite.Name = "txtPSpecialite";
            this.txtPSpecialite.Size = new System.Drawing.Size(270, 34);
            this.txtPSpecialite.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.label6.Location = new System.Drawing.Point(15, 297);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 28);
            this.label6.TabIndex = 21;
            this.label6.Text = "Spécialité:";
            // 
            // txtPTel
            // 
            this.txtPTel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPTel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPTel.Location = new System.Drawing.Point(15, 259);
            this.txtPTel.Name = "txtPTel";
            this.txtPTel.Size = new System.Drawing.Size(270, 34);
            this.txtPTel.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.label7.Location = new System.Drawing.Point(15, 227);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 28);
            this.label7.TabIndex = 18;
            this.label7.Text = "Téléphone:";
            // 
            // txtPEmail
            // 
            this.txtPEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPEmail.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPEmail.Location = new System.Drawing.Point(15, 189);
            this.txtPEmail.Name = "txtPEmail";
            this.txtPEmail.Size = new System.Drawing.Size(270, 34);
            this.txtPEmail.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.label8.Location = new System.Drawing.Point(15, 157);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 28);
            this.label8.TabIndex = 15;
            this.label8.Text = "Email:";
            // 
            // txtPPrenom
            // 
            this.txtPPrenom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPPrenom.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPPrenom.Location = new System.Drawing.Point(15, 119);
            this.txtPPrenom.Name = "txtPPrenom";
            this.txtPPrenom.Size = new System.Drawing.Size(270, 34);
            this.txtPPrenom.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.label9.Location = new System.Drawing.Point(15, 87);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 28);
            this.label9.TabIndex = 12;
            this.label9.Text = "Prénom:";
            // 
            // txtPNom
            // 
            this.txtPNom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPNom.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPNom.Location = new System.Drawing.Point(15, 49);
            this.txtPNom.Name = "txtPNom";
            this.txtPNom.Size = new System.Drawing.Size(270, 34);
            this.txtPNom.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.label10.Location = new System.Drawing.Point(15, 17);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 28);
            this.label10.TabIndex = 9;
            this.label10.Text = "Nom:";
            // 
            // tabChefDepartement
            // 
            this.tabChefDepartement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(245)))));
            this.tabChefDepartement.Controls.Add(this.btnCSupprimer);
            this.tabChefDepartement.Controls.Add(this.btnCModifier);
            this.tabChefDepartement.Controls.Add(this.btnCAjouter);
            this.tabChefDepartement.Controls.Add(this.txtCDepartement);
            this.tabChefDepartement.Controls.Add(this.label11);
            this.tabChefDepartement.Controls.Add(this.txtCTel);
            this.tabChefDepartement.Controls.Add(this.label12);
            this.tabChefDepartement.Controls.Add(this.txtCEmail);
            this.tabChefDepartement.Controls.Add(this.label13);
            this.tabChefDepartement.Controls.Add(this.txtCPrenom);
            this.tabChefDepartement.Controls.Add(this.label14);
            this.tabChefDepartement.Controls.Add(this.txtCNom);
            this.tabChefDepartement.Controls.Add(this.label15);
            this.tabChefDepartement.Location = new System.Drawing.Point(4, 39);
            this.tabChefDepartement.Name = "tabChefDepartement";
            this.tabChefDepartement.Padding = new System.Windows.Forms.Padding(3);
            this.tabChefDepartement.Size = new System.Drawing.Size(499, 600);
            this.tabChefDepartement.TabIndex = 2;
            this.tabChefDepartement.Text = "👔 Chef Département";
            this.tabChefDepartement.UseVisualStyleBackColor = true;
            // 
            // btnCSupprimer
            // 
            this.btnCSupprimer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnCSupprimer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCSupprimer.FlatAppearance.BorderSize = 0;
            this.btnCSupprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCSupprimer.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnCSupprimer.ForeColor = System.Drawing.Color.White;
            this.btnCSupprimer.Location = new System.Drawing.Point(305, 503);
            this.btnCSupprimer.Name = "btnCSupprimer";
            this.btnCSupprimer.Size = new System.Drawing.Size(150, 50);
            this.btnCSupprimer.TabIndex = 20;
            this.btnCSupprimer.Text = "Supprimer";
            this.btnCSupprimer.UseVisualStyleBackColor = false;
            // 
            // btnCModifier
            // 
            this.btnCModifier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnCModifier.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCModifier.FlatAppearance.BorderSize = 0;
            this.btnCModifier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCModifier.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnCModifier.ForeColor = System.Drawing.Color.White;
            this.btnCModifier.Location = new System.Drawing.Point(305, 440);
            this.btnCModifier.Name = "btnCModifier";
            this.btnCModifier.Size = new System.Drawing.Size(150, 50);
            this.btnCModifier.TabIndex = 19;
            this.btnCModifier.Text = "✏️ Modifier";
            this.btnCModifier.UseVisualStyleBackColor = false;
            this.btnCModifier.Click += new System.EventHandler(this.btnCModifier_Click);
            // 
            // btnCAjouter
            // 
            this.btnCAjouter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnCAjouter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCAjouter.FlatAppearance.BorderSize = 0;
            this.btnCAjouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCAjouter.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnCAjouter.ForeColor = System.Drawing.Color.White;
            this.btnCAjouter.Location = new System.Drawing.Point(305, 377);
            this.btnCAjouter.Name = "btnCAjouter";
            this.btnCAjouter.Size = new System.Drawing.Size(150, 50);
            this.btnCAjouter.TabIndex = 17;
            this.btnCAjouter.Text = "➕ Ajouter";
            this.btnCAjouter.UseVisualStyleBackColor = false;
            this.btnCAjouter.Click += new System.EventHandler(this.btnCAjouter_Click);
            // 
            // txtCDepartement
            // 
            this.txtCDepartement.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCDepartement.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtCDepartement.Location = new System.Drawing.Point(15, 329);
            this.txtCDepartement.Name = "txtCDepartement";
            this.txtCDepartement.Size = new System.Drawing.Size(270, 34);
            this.txtCDepartement.TabIndex = 16;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.label11.Location = new System.Drawing.Point(15, 297);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(143, 28);
            this.label11.TabIndex = 21;
            this.label11.Text = "Département:";
            // 
            // txtCTel
            // 
            this.txtCTel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCTel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtCTel.Location = new System.Drawing.Point(15, 259);
            this.txtCTel.Name = "txtCTel";
            this.txtCTel.Size = new System.Drawing.Size(270, 34);
            this.txtCTel.TabIndex = 14;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.label12.Location = new System.Drawing.Point(15, 227);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(114, 28);
            this.label12.TabIndex = 18;
            this.label12.Text = "Téléphone:";
            // 
            // txtCEmail
            // 
            this.txtCEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCEmail.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtCEmail.Location = new System.Drawing.Point(15, 189);
            this.txtCEmail.Name = "txtCEmail";
            this.txtCEmail.Size = new System.Drawing.Size(270, 34);
            this.txtCEmail.TabIndex = 13;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.label13.Location = new System.Drawing.Point(15, 157);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(69, 28);
            this.label13.TabIndex = 15;
            this.label13.Text = "Email:";
            // 
            // txtCPrenom
            // 
            this.txtCPrenom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCPrenom.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtCPrenom.Location = new System.Drawing.Point(15, 119);
            this.txtCPrenom.Name = "txtCPrenom";
            this.txtCPrenom.Size = new System.Drawing.Size(270, 34);
            this.txtCPrenom.TabIndex = 11;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.label14.Location = new System.Drawing.Point(15, 87);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(90, 28);
            this.label14.TabIndex = 12;
            this.label14.Text = "Prénom:";
            // 
            // txtCNom
            // 
            this.txtCNom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCNom.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtCNom.Location = new System.Drawing.Point(15, 49);
            this.txtCNom.Name = "txtCNom";
            this.txtCNom.Size = new System.Drawing.Size(270, 34);
            this.txtCNom.TabIndex = 10;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.label15.Location = new System.Drawing.Point(15, 17);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(63, 28);
            this.label15.TabIndex = 9;
            this.label15.Text = "Nom:";
            // 
            // dgUtilisateur
            // 
            this.dgUtilisateur.AllowUserToAddRows = false;
            this.dgUtilisateur.AllowUserToDeleteRows = false;
            this.dgUtilisateur.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgUtilisateur.BackgroundColor = System.Drawing.Color.White;
            this.dgUtilisateur.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgUtilisateur.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgUtilisateur.ColumnHeadersHeight = 45;
            this.dgUtilisateur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgUtilisateur.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgUtilisateur.EnableHeadersVisualStyles = false;
            this.dgUtilisateur.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.dgUtilisateur.Location = new System.Drawing.Point(607, 51);
            this.dgUtilisateur.Name = "dgUtilisateur";
            this.dgUtilisateur.ReadOnly = true;
            this.dgUtilisateur.RowHeadersVisible = false;
            this.dgUtilisateur.RowHeadersWidth = 62;
            this.dgUtilisateur.RowTemplate.Height = 35;
            this.dgUtilisateur.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgUtilisateur.Size = new System.Drawing.Size(818, 610);
            this.dgUtilisateur.TabIndex = 1;
            // 
            // frmUtilisateur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(1409, 667);
            this.ControlBox = false;
            this.Controls.Add(this.dgUtilisateur);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmUtilisateur";
            this.Text = "Utilisateurs";
            this.Load += new System.EventHandler(this.frmUtilisateur_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabCandidat.ResumeLayout(false);
            this.tabCandidat.PerformLayout();
            this.tabProfesseur.ResumeLayout(false);
            this.tabProfesseur.PerformLayout();
            this.tabChefDepartement.ResumeLayout(false);
            this.tabChefDepartement.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgUtilisateur)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabCandidat;
        private System.Windows.Forms.TabPage tabProfesseur;
        private System.Windows.Forms.TabPage tabChefDepartement;
        private System.Windows.Forms.TextBox txtMatricule;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnPSupprimer;
        private System.Windows.Forms.Button btnPModifier;
        private System.Windows.Forms.Button btnPAjouter;
        private System.Windows.Forms.TextBox txtPSpecialite;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPTel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPEmail;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPPrenom;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtPNom;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnCSupprimer;
        private System.Windows.Forms.Button btnCModifier;
        private System.Windows.Forms.Button btnCAjouter;
        private System.Windows.Forms.TextBox txtCDepartement;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtCTel;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtCEmail;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtCPrenom;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtCNom;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DataGridView dgUtilisateur;
    }
}