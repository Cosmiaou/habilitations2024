﻿namespace mediatek86.view
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
            this.grbPersonnel = new System.Windows.Forms.GroupBox();
            this.btnAbsence = new System.Windows.Forms.Button();
            this.lblConfirm = new System.Windows.Forms.Label();
            this.dgwDonnees = new System.Windows.Forms.DataGridView();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnModifierItem = new System.Windows.Forms.Button();
            this.grbAjouterPerso = new System.Windows.Forms.GroupBox();
            this.lblTel = new System.Windows.Forms.Label();
            this.lblMail = new System.Windows.Forms.Label();
            this.lblService = new System.Windows.Forms.Label();
            this.cmbService = new System.Windows.Forms.ComboBox();
            this.txbTel = new System.Windows.Forms.TextBox();
            this.txbMail = new System.Windows.Forms.TextBox();
            this.txbPrenom = new System.Windows.Forms.TextBox();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.txbNom = new System.Windows.Forms.TextBox();
            this.btnAnnulerPersonnel = new System.Windows.Forms.Button();
            this.btnAjouterPersonnel = new System.Windows.Forms.Button();
            this.grbPersonnel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwDonnees)).BeginInit();
            this.grbAjouterPerso.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbPersonnel
            // 
            this.grbPersonnel.Controls.Add(this.btnAbsence);
            this.grbPersonnel.Controls.Add(this.lblConfirm);
            this.grbPersonnel.Controls.Add(this.dgwDonnees);
            this.grbPersonnel.Controls.Add(this.btnSupprimer);
            this.grbPersonnel.Controls.Add(this.btnModifierItem);
            this.grbPersonnel.Location = new System.Drawing.Point(13, 13);
            this.grbPersonnel.Name = "grbPersonnel";
            this.grbPersonnel.Size = new System.Drawing.Size(553, 177);
            this.grbPersonnel.TabIndex = 0;
            this.grbPersonnel.TabStop = false;
            this.grbPersonnel.Text = "Personnels";
            // 
            // btnAbsence
            // 
            this.btnAbsence.Location = new System.Drawing.Point(425, 148);
            this.btnAbsence.Name = "btnAbsence";
            this.btnAbsence.Size = new System.Drawing.Size(120, 23);
            this.btnAbsence.TabIndex = 5;
            this.btnAbsence.Text = "Voir les absences";
            this.btnAbsence.UseVisualStyleBackColor = true;
            this.btnAbsence.Click += new System.EventHandler(this.btnAbsence_Click);
            // 
            // lblConfirm
            // 
            this.lblConfirm.AutoSize = true;
            this.lblConfirm.Location = new System.Drawing.Point(423, 153);
            this.lblConfirm.Name = "lblConfirm";
            this.lblConfirm.Size = new System.Drawing.Size(0, 13);
            this.lblConfirm.TabIndex = 4;
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
            this.dgwDonnees.Size = new System.Drawing.Size(535, 121);
            this.dgwDonnees.TabIndex = 3;
            this.dgwDonnees.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgwDonnees_MouseClick);
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
            // grbAjouterPerso
            // 
            this.grbAjouterPerso.Controls.Add(this.lblTel);
            this.grbAjouterPerso.Controls.Add(this.lblMail);
            this.grbAjouterPerso.Controls.Add(this.lblService);
            this.grbAjouterPerso.Controls.Add(this.cmbService);
            this.grbAjouterPerso.Controls.Add(this.txbTel);
            this.grbAjouterPerso.Controls.Add(this.txbMail);
            this.grbAjouterPerso.Controls.Add(this.txbPrenom);
            this.grbAjouterPerso.Controls.Add(this.lblPrenom);
            this.grbAjouterPerso.Controls.Add(this.lblNom);
            this.grbAjouterPerso.Controls.Add(this.txbNom);
            this.grbAjouterPerso.Controls.Add(this.btnAnnulerPersonnel);
            this.grbAjouterPerso.Controls.Add(this.btnAjouterPersonnel);
            this.grbAjouterPerso.Location = new System.Drawing.Point(13, 196);
            this.grbAjouterPerso.Name = "grbAjouterPerso";
            this.grbAjouterPerso.Size = new System.Drawing.Size(553, 105);
            this.grbAjouterPerso.TabIndex = 1;
            this.grbAjouterPerso.TabStop = false;
            this.grbAjouterPerso.Text = "Ajouter un personnel :";
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Location = new System.Drawing.Point(273, 50);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(115, 13);
            this.lblTel.TabIndex = 14;
            this.lblTel.Text = "Numéro de téléphone :";
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Location = new System.Drawing.Point(273, 25);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(41, 13);
            this.lblMail.TabIndex = 14;
            this.lblMail.Text = "E-mail :";
            // 
            // lblService
            // 
            this.lblService.AutoSize = true;
            this.lblService.Location = new System.Drawing.Point(352, 81);
            this.lblService.Name = "lblService";
            this.lblService.Size = new System.Drawing.Size(49, 13);
            this.lblService.TabIndex = 13;
            this.lblService.Text = "Service :";
            // 
            // cmbService
            // 
            this.cmbService.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbService.FormattingEnabled = true;
            this.cmbService.Location = new System.Drawing.Point(407, 76);
            this.cmbService.Name = "cmbService";
            this.cmbService.Size = new System.Drawing.Size(138, 21);
            this.cmbService.TabIndex = 12;
            // 
            // txbTel
            // 
            this.txbTel.Location = new System.Drawing.Point(407, 47);
            this.txbTel.Name = "txbTel";
            this.txbTel.Size = new System.Drawing.Size(138, 20);
            this.txbTel.TabIndex = 11;
            // 
            // txbMail
            // 
            this.txbMail.Location = new System.Drawing.Point(361, 22);
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
            // btnAnnulerPersonnel
            // 
            this.btnAnnulerPersonnel.Location = new System.Drawing.Point(105, 76);
            this.btnAnnulerPersonnel.Name = "btnAnnulerPersonnel";
            this.btnAnnulerPersonnel.Size = new System.Drawing.Size(93, 23);
            this.btnAnnulerPersonnel.TabIndex = 6;
            this.btnAnnulerPersonnel.Text = "Annuler";
            this.btnAnnulerPersonnel.UseVisualStyleBackColor = true;
            this.btnAnnulerPersonnel.Click += new System.EventHandler(this.btnAnnulerPerso_Click);
            // 
            // btnAjouterPersonnel
            // 
            this.btnAjouterPersonnel.Location = new System.Drawing.Point(6, 76);
            this.btnAjouterPersonnel.Name = "btnAjouterPersonnel";
            this.btnAjouterPersonnel.Size = new System.Drawing.Size(93, 23);
            this.btnAjouterPersonnel.TabIndex = 6;
            this.btnAjouterPersonnel.Text = "Enregistrer";
            this.btnAjouterPersonnel.UseVisualStyleBackColor = true;
            this.btnAjouterPersonnel.Click += new System.EventHandler(this.btnAjouterPerso_Click);
            // 
            // FrmHabilitations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 314);
            this.Controls.Add(this.grbAjouterPerso);
            this.Controls.Add(this.grbPersonnel);
            this.Name = "FrmHabilitations";
            this.Text = "MediaTek86 - gestion du personnel V0.1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grbPersonnel.ResumeLayout(false);
            this.grbPersonnel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwDonnees)).EndInit();
            this.grbAjouterPerso.ResumeLayout(false);
            this.grbAjouterPerso.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbPersonnel;
        private System.Windows.Forms.GroupBox grbAjouterPerso;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnModifierItem;
        private System.Windows.Forms.Button btnAjouterPersonnel;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label lblService;
        private System.Windows.Forms.ComboBox cmbService;
        private System.Windows.Forms.TextBox txbTel;
        private System.Windows.Forms.TextBox txbMail;
        private System.Windows.Forms.TextBox txbPrenom;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.TextBox txbNom;
        private System.Windows.Forms.Button btnAnnulerPersonnel;
        private System.Windows.Forms.DataGridView dgwDonnees;
        private System.Windows.Forms.Label lblConfirm;
        private System.Windows.Forms.Button btnAbsence;
    }
}

