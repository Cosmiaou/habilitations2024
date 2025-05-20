using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using mediatek86.controller;
using mediatek86.model;


namespace mediatek86.view
{
    public partial class FrmHabilitations : Form
    {
        private FrmHabilitationsController controller;
        private bool modif = false;

        /// <summary>
        /// Constructeur de la classe, initialise les composants
        /// </summary>
        public FrmHabilitations()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Chargement du formulaire. Initialise controller, appelle les fonctions pour remplir cmbService et dgwDonnees
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            controller = new FrmHabilitationsController();
            afficherTout();
            remplirCombo();
        }

        /// <summary>
        /// Rempli cmbProfil et place son index à 0
        /// </summary>
        private void remplirCombo()
        {
            cmbService.Items.Add("");
            List<Service> liste = controller.GetLesServices();
            foreach (Service service in liste)
            {
                cmbService.Items.Add(service);
            }
            cmbService.SelectedIndex = 0;
        }

        /// <summary>
        /// Rempli dgwDonnees via GetLesDeveloppeurs() du controlleur et masque deux colonnes
        /// </summary>
        private void afficherTout()
        {
            List<Personnel> liste = controller.GetLesPerso();
            dgwDonnees.DataSource = liste;
            dgwDonnees.Columns["Idpersonnel"].Visible = false;
        }


        /// <summary>
        /// Reçoit les paramètres nécessaires et demande à modifier l'élement sélectionné dans dgwDonnees.
        /// </summary>
        /// <param name="prenom"></param>
        /// <param name="nom"></param>
        /// <param name="tel"></param>
        /// <param name="email"></param>
        /// <param name="profil"></param>
        private void modifier(string prenom, string nom, string tel, string email, Service service) {
            Personnel objet = (Personnel)dgwDonnees.CurrentRow.DataBoundItem;
            grbPersonnel.Enabled = false;

            if (objet == null) { MessageBox.Show("Merci de sélectionner une ligne !"); } else
            {
                objet.Service = service;
                objet.Prenom = prenom;
                objet.Nom = nom;
                objet.Tel = tel;
                objet.Mail = email;
                controller.UpdateItem(objet);

                grbPersonnel.Enabled = true;
                grbAjouterPerso.Text = "Ajouter un employé :";
            }
        }

        /// <summary>
        /// Vérifie si les champs du grbAjouterPerso sont vides. Si oui, return false.
        /// </summary>
        /// <returns></returns>
        private void remplissageCase()
        {
            Personnel objet = (Personnel)dgwDonnees.CurrentRow.DataBoundItem;

            txbMail.Text = objet.Mail;
            txbTel.Text = objet.Tel;
            txbNom.Text = objet.Nom;
            txbPrenom.Text = objet.Prenom;
            cmbService.SelectedIndex = objet.Service.Idservice;
        }

        /// <summary>
        /// Vérifie si les champs du grbAjouterPerso sont vides. Si oui, return false.
        /// </summary>
        /// <returns></returns>
        private bool verifierChamps()
        {
            if (txbNom.Text.Equals("") || txbPrenom.Text.Equals("") || txbTel.Text.Equals("") || txbMail.Text.Equals("") || cmbService.SelectedIndex == 0) { 
                   return false; }
            else { return true;  }
        }

        /// <summary>
        /// Récupère l'objet sélectionné dans dgwDonnees et appelle controller.DelDev() pour le supprimer.
        /// Met à jour l'affichage. Si aucun objet n'est supprimé, affiche un message d'erreur.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            Personnel objet = (Personnel)dgwDonnees.CurrentRow.DataBoundItem;
            if (objet != null)
            {
                controller.DelItem(objet);
                afficherTout();
            }
            else
            {
                MessageBox.Show("Merci de sélectionner une ligne");
            }
        }

        /// <summary>
        /// Change le booléen modif en true pour btnAjouterDev_Click(). Change le texte de grbAjouterDev
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModifierItem_Click(object sender, EventArgs e)
        {
            modif = true;
            grbAjouterPerso.Text = "Modifiez un personnel :";
        }

        private void btnAjouterPerso_Click(object sender, EventArgs e)
        {
            if (verifierChamps())
            {
                string prenom = txbPrenom.Text;
                string nom = txbNom.Text;
                string tel = txbTel.Text;
                string email = txbMail.Text;
                Service profil = (Service)cmbService.SelectedItem;

                if (modif)
                {
                    modifier(prenom, nom, tel, email, profil);
                }
                else
                {
                    Personnel dev = new Personnel(0, nom, prenom, tel, email, profil);
                    controller.AddItem(dev);
                }
                afficherTout();
            }
            else { MessageBox.Show("Veuillez remplir toutes les cases"); }
        }

        private void btnAnnulerPerso_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez-vous vraiment annuler ?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                txbPrenom.Text = "";
                txbNom.Text = "";
                txbTel.Text = "";
                txbMail.Text = "";
                cmbService.SelectedIndex = 0;
            }
        }

        private void btnAbsence_Click(object sender, EventArgs e)
        {

        }

        private void dgwDonnees_MouseClick(object sender, MouseEventArgs e)
        {
            remplissageCase();
        }
    }
}



