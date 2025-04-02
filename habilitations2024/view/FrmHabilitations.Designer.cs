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
            this.lstNoms = new System.Windows.Forms.ListBox();
            this.testInsert = new System.Windows.Forms.Button();
            this.txbPrenom = new System.Windows.Forms.TextBox();
            this.txbNom = new System.Windows.Forms.TextBox();
            this.txbID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lstNoms
            // 
            this.lstNoms.FormattingEnabled = true;
            this.lstNoms.Location = new System.Drawing.Point(12, 12);
            this.lstNoms.Name = "lstNoms";
            this.lstNoms.Size = new System.Drawing.Size(344, 173);
            this.lstNoms.TabIndex = 0;
            this.lstNoms.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // testInsert
            // 
            this.testInsert.Location = new System.Drawing.Point(281, 201);
            this.testInsert.Name = "testInsert";
            this.testInsert.Size = new System.Drawing.Size(75, 20);
            this.testInsert.TabIndex = 1;
            this.testInsert.Text = "Insérer";
            this.testInsert.UseVisualStyleBackColor = true;
            this.testInsert.Click += new System.EventHandler(this.testInsert_Click);
            // 
            // txbPrenom
            // 
            this.txbPrenom.Location = new System.Drawing.Point(13, 201);
            this.txbPrenom.Name = "txbPrenom";
            this.txbPrenom.Size = new System.Drawing.Size(75, 20);
            this.txbPrenom.TabIndex = 2;
            this.txbPrenom.Text = "Prénom";
            // 
            // txbNom
            // 
            this.txbNom.Location = new System.Drawing.Point(94, 201);
            this.txbNom.Name = "txbNom";
            this.txbNom.Size = new System.Drawing.Size(75, 20);
            this.txbNom.TabIndex = 3;
            this.txbNom.Text = "Nom";
            // 
            // txbID
            // 
            this.txbID.Location = new System.Drawing.Point(175, 202);
            this.txbID.Name = "txbID";
            this.txbID.Size = new System.Drawing.Size(75, 20);
            this.txbID.TabIndex = 4;
            this.txbID.Text = "ID";
            // 
            // FrmHabilitations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 314);
            this.Controls.Add(this.txbID);
            this.Controls.Add(this.txbNom);
            this.Controls.Add(this.txbPrenom);
            this.Controls.Add(this.testInsert);
            this.Controls.Add(this.lstNoms);
            this.Name = "FrmHabilitations";
            this.Text = "Habilitations V0.3";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstNoms;
        private System.Windows.Forms.Button testInsert;
        private System.Windows.Forms.TextBox txbPrenom;
        private System.Windows.Forms.TextBox txbNom;
        private System.Windows.Forms.TextBox txbID;
    }
}

