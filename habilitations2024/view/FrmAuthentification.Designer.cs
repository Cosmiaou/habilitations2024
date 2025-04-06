namespace habilitations2024.view
{
    partial class FrmAuthentification
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
            this.txtPrenom = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.Label();
            this.txtPwd = new System.Windows.Forms.Label();
            this.txbPrenom = new System.Windows.Forms.TextBox();
            this.txbNom = new System.Windows.Forms.TextBox();
            this.txbPwd = new System.Windows.Forms.TextBox();
            this.btnConnection = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtPrenom
            // 
            this.txtPrenom.AutoSize = true;
            this.txtPrenom.Location = new System.Drawing.Point(13, 17);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(49, 13);
            this.txtPrenom.TabIndex = 0;
            this.txtPrenom.Text = "Prenom :";
            // 
            // txtNom
            // 
            this.txtNom.AutoSize = true;
            this.txtNom.Location = new System.Drawing.Point(13, 43);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(35, 13);
            this.txtNom.TabIndex = 1;
            this.txtNom.Text = "Nom :";
            // 
            // txtPwd
            // 
            this.txtPwd.AutoSize = true;
            this.txtPwd.Location = new System.Drawing.Point(13, 69);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.Size = new System.Drawing.Size(77, 13);
            this.txtPwd.TabIndex = 2;
            this.txtPwd.Text = "Mot de passe :";
            // 
            // txbPrenom
            // 
            this.txbPrenom.Location = new System.Drawing.Point(94, 10);
            this.txbPrenom.Name = "txbPrenom";
            this.txbPrenom.Size = new System.Drawing.Size(188, 20);
            this.txbPrenom.TabIndex = 3;
            // 
            // txbNom
            // 
            this.txbNom.Location = new System.Drawing.Point(94, 36);
            this.txbNom.Name = "txbNom";
            this.txbNom.Size = new System.Drawing.Size(188, 20);
            this.txbNom.TabIndex = 4;
            // 
            // txbPwd
            // 
            this.txbPwd.Location = new System.Drawing.Point(94, 62);
            this.txbPwd.Name = "txbPwd";
            this.txbPwd.PasswordChar = '*';
            this.txbPwd.Size = new System.Drawing.Size(188, 20);
            this.txbPwd.TabIndex = 5;
            // 
            // btnConnection
            // 
            this.btnConnection.Location = new System.Drawing.Point(184, 88);
            this.btnConnection.Name = "btnConnection";
            this.btnConnection.Size = new System.Drawing.Size(98, 23);
            this.btnConnection.TabIndex = 6;
            this.btnConnection.Text = "Se connecter";
            this.btnConnection.UseVisualStyleBackColor = true;
            this.btnConnection.Click += new System.EventHandler(this.btnConnection_Click);
            // 
            // FrmAuthentification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 119);
            this.Controls.Add(this.btnConnection);
            this.Controls.Add(this.txbPwd);
            this.Controls.Add(this.txbNom);
            this.Controls.Add(this.txbPrenom);
            this.Controls.Add(this.txtPwd);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.txtPrenom);
            this.Name = "FrmAuthentification";
            this.Text = "Se connecter";
            this.Load += new System.EventHandler(this.FrmAuthentification_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtPrenom;
        private System.Windows.Forms.Label txtNom;
        private System.Windows.Forms.Label txtPwd;
        private System.Windows.Forms.TextBox txbPrenom;
        private System.Windows.Forms.TextBox txbNom;
        private System.Windows.Forms.TextBox txbPwd;
        private System.Windows.Forms.Button btnConnection;
    }
}