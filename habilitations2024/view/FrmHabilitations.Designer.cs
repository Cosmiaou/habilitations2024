namespace habilitations2024.view
{
    partial class FrmHabilitations
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.grbDevs = new System.Windows.Forms.GroupBox();
            this.dgwDonnees = new System.Windows.Forms.DataGridView();
            this.btnEditPwd = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnModifierItem = new System.Windows.Forms.Button();
            this.grbAjouterDev = new System.Windows.Forms.GroupBox();
            this.lblTel = new System.Windows.Forms.Label();
            this.lblMail = new System.Windows.Forms.Label();
            this.lblProfil = new System.Windows.Forms.Label();
            this.cmbProfil = new System.Windows.Forms.ComboBox();
            this.txbTel = new System.Windows.Forms.TextBox();
            this.txbMail = new System.Windows.Forms.TextBox();
            this.txbPrenom = new System.Windows.Forms.TextBox();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.txbNom = new System.Windows.Forms.TextBox();
            this.btnAnnulerDev = new System.Windows.Forms.Button();
            this.btnAjouterDev = new System.Windows.Forms.Button();
            this.grbPassword = new System.Windows.Forms.GroupBox();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.txbAnnuler = new System.Windows.Forms.Button();
            this.txbIndiquezMdp = new System.Windows.Forms.TextBox();
            this.txbRepetezMdp = new System.Windows.Forms.TextBox();
            this.lblRepeterMdp = new System.Windows.Forms.Label();
            this.lblindiquezMdp = new System.Windows.Forms.Label();
            this.lblConfirm = new System.Windows.Forms.Label();
            this.grbDevs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwDonnees)).BeginInit();
            this.grbAjouterDev.SuspendLayout();
            this.grbPassword.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbDevs
            // 
            this.grbDevs.Controls.Add(this.lblConfirm);
            this.grbDevs.Controls.Add(this.dgwDonnees);
            this.grbDevs.Controls.Add(this.btnEditPwd);
            this.grbDevs.Controls.Add(this.btnSupprimer);
            this.grbDevs.Controls.Add(this.btnModifierItem);
            this.grbDevs.Location = new System.Drawing.Point(13, 13);
            this.grbDevs.Name = "grbDevs";
            this.grbDevs.Size = new System.Drawing.Size(535, 177);
            this.grbDevs.TabIndex = 0;
            this.grbDevs.TabStop = false;
            this.grbDevs.Text = "Développeurs :";
            // 
            // dgwDonnees
            // 
            this.dgwDonnees.AllowUserToAddRows = false;
            this.dgwDonnees.AllowUserToDeleteRows = false;
            this.dgwDonnees.AllowUserToResizeColumns = false;
            this.dgwDonnees.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgwDonnees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwDonnees.Location = new System.Drawing.Point(10, 21);
            this.dgwDonnees.MultiSelect = false;
            this.dgwDonnees.Name = "dgwDonnees";
            this.dgwDonnees.ReadOnly = true;
            this.dgwDonnees.RowHeadersVisible = false;
            this.dgwDonnees.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwDonnees.Size = new System.Drawing.Size(519, 121);
            this.dgwDonnees.TabIndex = 3;
            // 
            // btnEditPwd
            // 
            this.btnEditPwd.Location = new System.Drawing.Point(198, 148);
            this.btnEditPwd.Name = "btnEditPwd";
            this.btnEditPwd.Size = new System.Drawing.Size(134, 23);
            this.btnEditPwd.TabIndex = 2;
            this.btnEditPwd.Text = "Modifier le mot de passe";
            this.btnEditPwd.UseVisualStyleBackColor = true;
            this.btnEditPwd.Click += new System.EventHandler(this.btnEditPwd_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(104, 148);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(88, 23);
            this.btnSupprimer.TabIndex = 1;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // btnModifierItem
            // 
            this.btnModifierItem.Location = new System.Drawing.Point(10, 148);
            this.btnModifierItem.Name = "btnModifierItem";
            this.btnModifierItem.Size = new System.Drawing.Size(88, 23);
            this.btnModifierItem.TabIndex = 0;
            this.btnModifierItem.Text = "Modifier";
            this.btnModifierItem.UseVisualStyleBackColor = true;
            this.btnModifierItem.Click += new System.EventHandler(this.btnModifierItem_Click);
            // 
            // grbAjouterDev
            // 
            this.grbAjouterDev.Controls.Add(this.lblTel);
            this.grbAjouterDev.Controls.Add(this.lblMail);
            this.grbAjouterDev.Controls.Add(this.lblProfil);
            this.grbAjouterDev.Controls.Add(this.cmbProfil);
            this.grbAjouterDev.Controls.Add(this.txbTel);
            this.grbAjouterDev.Controls.Add(this.txbMail);
            this.grbAjouterDev.Controls.Add(this.txbPrenom);
            this.grbAjouterDev.Controls.Add(this.lblPrenom);
            this.grbAjouterDev.Controls.Add(this.lblNom);
            this.grbAjouterDev.Controls.Add(this.txbNom);
            this.grbAjouterDev.Controls.Add(this.btnAnnulerDev);
            this.grbAjouterDev.Controls.Add(this.btnAjouterDev);
            this.grbAjouterDev.Location = new System.Drawing.Point(13, 196);
            this.grbAjouterDev.Name = "grbAjouterDev";
            this.grbAjouterDev.Size = new System.Drawing.Size(535, 105);
            this.grbAjouterDev.TabIndex = 1;
            this.grbAjouterDev.TabStop = false;
            this.grbAjouterDev.Text = "Ajouter un développeur :";
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Location = new System.Drawing.Point(247, 50);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(115, 13);
            this.lblTel.TabIndex = 14;
            this.lblTel.Text = "Numéro de téléphone :";
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Location = new System.Drawing.Point(247, 25);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(41, 13);
            this.lblMail.TabIndex = 14;
            this.lblMail.Text = "E-mail :";
            // 
            // lblProfil
            // 
            this.lblProfil.AutoSize = true;
            this.lblProfil.Location = new System.Drawing.Point(326, 81);
            this.lblProfil.Name = "lblProfil";
            this.lblProfil.Size = new System.Drawing.Size(36, 13);
            this.lblProfil.TabIndex = 13;
            this.lblProfil.Text = "Profil :";
            // 
            // cmbProfil
            // 
            this.cmbProfil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProfil.FormattingEnabled = true;
            this.cmbProfil.Location = new System.Drawing.Point(381, 76);
            this.cmbProfil.Name = "cmbProfil";
            this.cmbProfil.Size = new System.Drawing.Size(138, 21);
            this.cmbProfil.TabIndex = 12;
            // 
            // txbTel
            // 
            this.txbTel.Location = new System.Drawing.Point(381, 47);
            this.txbTel.Name = "txbTel";
            this.txbTel.Size = new System.Drawing.Size(138, 20);
            this.txbTel.TabIndex = 11;
            // 
            // txbMail
            // 
            this.txbMail.Location = new System.Drawing.Point(335, 22);
            this.txbMail.Name = "txbMail";
            this.txbMail.Size = new System.Drawing.Size(184, 20);
            this.txbMail.TabIndex = 10;
            // 
            // txbPrenom
            // 
            this.txbPrenom.Location = new System.Drawing.Point(70, 45);
            this.txbPrenom.Name = "txbPrenom";
            this.txbPrenom.Size = new System.Drawing.Size(100, 20);
            this.txbPrenom.TabIndex = 9;
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Location = new System.Drawing.Point(7, 50);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(49, 13);
            this.lblPrenom.TabIndex = 8;
            this.lblPrenom.Text = "Prénom :";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(7, 22);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(35, 13);
            this.lblNom.TabIndex = 7;
            this.lblNom.Text = "Nom :";
            // 
            // txbNom
            // 
            this.txbNom.Location = new System.Drawing.Point(70, 19);
            this.txbNom.Name = "txbNom";
            this.txbNom.Size = new System.Drawing.Size(100, 20);
            this.txbNom.TabIndex = 7;
            // 
            // btnAnnulerDev
            // 
            this.btnAnnulerDev.Location = new System.Drawing.Point(105, 76);
            this.btnAnnulerDev.Name = "btnAnnulerDev";
            this.btnAnnulerDev.Size = new System.Drawing.Size(93, 23);
            this.btnAnnulerDev.TabIndex = 6;
            this.btnAnnulerDev.Text = "Annuler";
            this.btnAnnulerDev.UseVisualStyleBackColor = true;
            this.btnAnnulerDev.Click += new System.EventHandler(this.btnAnnulerDev_Click);
            // 
            // btnAjouterDev
            // 
            this.btnAjouterDev.Location = new System.Drawing.Point(6, 76);
            this.btnAjouterDev.Name = "btnAjouterDev";
            this.btnAjouterDev.Size = new System.Drawing.Size(93, 23);
            this.btnAjouterDev.TabIndex = 6;
            this.btnAjouterDev.Text = "Enregistrer";
            this.btnAjouterDev.UseVisualStyleBackColor = true;
            this.btnAjouterDev.Click += new System.EventHandler(this.btnAjouterDev_Click);
            // 
            // grbPassword
            // 
            this.grbPassword.Controls.Add(this.btnEnregistrer);
            this.grbPassword.Controls.Add(this.txbAnnuler);
            this.grbPassword.Controls.Add(this.txbIndiquezMdp);
            this.grbPassword.Controls.Add(this.txbRepetezMdp);
            this.grbPassword.Controls.Add(this.lblRepeterMdp);
            this.grbPassword.Controls.Add(this.lblindiquezMdp);
            this.grbPassword.Enabled = false;
            this.grbPassword.Location = new System.Drawing.Point(13, 307);
            this.grbPassword.Name = "grbPassword";
            this.grbPassword.Size = new System.Drawing.Size(535, 85);
            this.grbPassword.TabIndex = 2;
            this.grbPassword.TabStop = false;
            this.grbPassword.Text = "Changer le mot de passe :";
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.Location = new System.Drawing.Point(426, 17);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(93, 23);
            this.btnEnregistrer.TabIndex = 5;
            this.btnEnregistrer.Text = "Enregistrer";
            this.btnEnregistrer.UseVisualStyleBackColor = true;
            this.btnEnregistrer.Click += new System.EventHandler(this.btnEnregistrer_Click);
            // 
            // txbAnnuler
            // 
            this.txbAnnuler.Location = new System.Drawing.Point(426, 59);
            this.txbAnnuler.Name = "txbAnnuler";
            this.txbAnnuler.Size = new System.Drawing.Size(93, 23);
            this.txbAnnuler.TabIndex = 4;
            this.txbAnnuler.Text = "Annuler";
            this.txbAnnuler.UseVisualStyleBackColor = true;
            this.txbAnnuler.Click += new System.EventHandler(this.txbAnnuler_Click);
            // 
            // txbIndiquezMdp
            // 
            this.txbIndiquezMdp.Location = new System.Drawing.Point(116, 20);
            this.txbIndiquezMdp.Name = "txbIndiquezMdp";
            this.txbIndiquezMdp.PasswordChar = '*';
            this.txbIndiquezMdp.Size = new System.Drawing.Size(281, 20);
            this.txbIndiquezMdp.TabIndex = 3;
            // 
            // txbRepetezMdp
            // 
            this.txbRepetezMdp.Location = new System.Drawing.Point(117, 59);
            this.txbRepetezMdp.Name = "txbRepetezMdp";
            this.txbRepetezMdp.PasswordChar = '*';
            this.txbRepetezMdp.Size = new System.Drawing.Size(281, 20);
            this.txbRepetezMdp.TabIndex = 2;
            // 
            // lblRepeterMdp
            // 
            this.lblRepeterMdp.AutoSize = true;
            this.lblRepeterMdp.Location = new System.Drawing.Point(7, 56);
            this.lblRepeterMdp.Name = "lblRepeterMdp";
            this.lblRepeterMdp.Size = new System.Drawing.Size(76, 26);
            this.lblRepeterMdp.TabIndex = 1;
            this.lblRepeterMdp.Text = "Répetez le\r\nmot de passe :";
            // 
            // lblindiquezMdp
            // 
            this.lblindiquezMdp.AutoSize = true;
            this.lblindiquezMdp.Location = new System.Drawing.Point(7, 20);
            this.lblindiquezMdp.Name = "lblindiquezMdp";
            this.lblindiquezMdp.Size = new System.Drawing.Size(103, 26);
            this.lblindiquezMdp.TabIndex = 0;
            this.lblindiquezMdp.Text = "Indiquez le nouveau\r\nmot de passe :";
            // 
            // lblConfirm
            // 
            this.lblConfirm.AutoSize = true;
            this.lblConfirm.Location = new System.Drawing.Point(423, 153);
            this.lblConfirm.Name = "lblConfirm";
            this.lblConfirm.Size = new System.Drawing.Size(0, 13);
            this.lblConfirm.TabIndex = 4;
            // 
            // FrmHabilitations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 404);
            this.Controls.Add(this.grbPassword);
            this.Controls.Add(this.grbAjouterDev);
            this.Controls.Add(this.grbDevs);
            this.Name = "FrmHabilitations";
            this.Text = "Habilitations V0.5";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grbDevs.ResumeLayout(false);
            this.grbDevs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwDonnees)).EndInit();
            this.grbAjouterDev.ResumeLayout(false);
            this.grbAjouterDev.PerformLayout();
            this.grbPassword.ResumeLayout(false);
            this.grbPassword.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbDevs;
        private System.Windows.Forms.GroupBox grbAjouterDev;
        private System.Windows.Forms.GroupBox grbPassword;
        private System.Windows.Forms.Button txbAnnuler;
        private System.Windows.Forms.TextBox txbIndiquezMdp;
        private System.Windows.Forms.TextBox txbRepetezMdp;
        private System.Windows.Forms.Label lblRepeterMdp;
        private System.Windows.Forms.Label lblindiquezMdp;
        private System.Windows.Forms.Button btnEnregistrer;
        private System.Windows.Forms.Button btnEditPwd;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnModifierItem;
        private System.Windows.Forms.Button btnAjouterDev;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label lblProfil;
        private System.Windows.Forms.ComboBox cmbProfil;
        private System.Windows.Forms.TextBox txbTel;
        private System.Windows.Forms.TextBox txbMail;
        private System.Windows.Forms.TextBox txbPrenom;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.TextBox txbNom;
        private System.Windows.Forms.Button btnAnnulerDev;
        private System.Windows.Forms.DataGridView dgwDonnees;
        private System.Windows.Forms.Label lblConfirm;
    }
}

