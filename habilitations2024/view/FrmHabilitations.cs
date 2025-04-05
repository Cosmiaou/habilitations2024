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
using habilitations2024.controller;
using habilitations2024.model;

//La totalité du code présent ici est vouée à disparaitre pour être placée dans des classes spécifiques.

namespace habilitations2024.view
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
        /// Chargement du formulaire. Initialise controller, appelle les fonctions pour remplir cmbProfil et dgwDonnees
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
            List<Profil> liste = controller.GetLesProfils();

            foreach (Profil profil in liste)
            {
                cmbProfil.Items.Add(profil);
            }
            cmbProfil.SelectedIndex = 0;
        }

        /// <summary>
        /// Rempli dgwDonnees via GetLesDeveloppeurs() du controlleur et masque deux colonnes
        /// </summary>
        private void afficherTout()
        {
            List<Developpeur> liste = controller.GetLesDeveloppeurs();
            dgwDonnees.DataSource = liste;
            dgwDonnees.Columns["Pwd"].Visible = false;
            dgwDonnees.Columns["Iddeveloppeur"].Visible = false;
        }

        /// <summary>
        /// Vérifie que les deux champs de texte sont égaux. Si oui, récupère l'objet de dgwDonnees, lui
        /// affecte un nouveau mot de passe, et l'envoie à controller.UpdatePwd(). Désactive grbPwd
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            if (txbRepetezMdp.Text.Equals(txbIndiquezMdp.Text) && txbIndiquezMdp != null && txbRepetezMdp != null)
            {
                Developpeur objet = (Developpeur)dgwDonnees.CurrentRow.DataBoundItem;
                objet.Pwd = txbIndiquezMdp.Text;
                controller.UpdatePwd(objet);

                grbPassword.Enabled = false;
            } else
            {
                MessageBox.Show("Erreur : les deux lignes doivent être remplies et égales. Le mot de passe est sensible à la casse.");
            }
            
        }

        /// <summary>
        /// Lors du clic sur AjouterDev, vérifie via verifierChamps() si tous les champs sont remplies. Si oui, initialise les
        /// champs avec les paramètres et vérifie s'il s'agit d'une modification ou non. Si oui, appelle
        /// modifierDev() avec les bons champs. Sinon, ajoute le développeur via controller.AddDev() et
        /// met à jour dgwDonnees
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAjouterDev_Click(object sender, EventArgs e)
        {
            if (verifierChamps())
            {
                string prenom = txbPrenom.Text;
                string nom = txbNom.Text;
                string tel = txbTel.Text;
                string email = txbMail.Text;
                Profil profil = (Profil)cmbProfil.SelectedItem;

                if (modif)
                {
                    modifierDev(prenom, nom, tel, email, profil);
                } 
                else
                {
                    Developpeur dev = new Developpeur(0, nom, prenom, tel, email, profil);
                    controller.AddDev(dev);
                }
                afficherTout();
            }
            else { MessageBox.Show("Veuillez remplir toutes les cases"); }
        }

        /// <summary>
        /// Reçoit les paramètres nécessaires et demande à modifier l'élement sélectionné dans dgwDonnees.
        /// </summary>
        /// <param name="prenom"></param>
        /// <param name="nom"></param>
        /// <param name="tel"></param>
        /// <param name="email"></param>
        /// <param name="profil"></param>
        private void modifierDev(string prenom, string nom, string tel, string email, Profil profil) {
            Developpeur objet = (Developpeur)dgwDonnees.CurrentRow.DataBoundItem;
            grbDevs.Enabled = false;

            if (objet == null) { MessageBox.Show("Merci de sélectionner une ligne !"); } else
            {
                objet.Profil = profil;
                objet.Prenom = prenom;
                objet.Nom = nom;
                objet.Tel = tel;
                objet.Mail = email;
                controller.UpdateDev(objet);

                grbDevs.Enabled = true;
                grbAjouterDev.Text = "Ajouter un developpeur :";
            }
        }

        /// <summary>
        /// Vérifie si les champs du grbAjouterDev sont vides. Si oui, return false.
        /// </summary>
        /// <returns></returns>
        private bool verifierChamps()
        {
            if (txbNom.Text.Equals("") || txbPrenom.Text.Equals("") || txbTel.Text.Equals("") || txbMail.Text.Equals("") || cmbProfil.SelectedIndex == -1) { 
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
            Developpeur objet = (Developpeur)dgwDonnees.CurrentRow.DataBoundItem;
            if (objet != null)
            {
                controller.DelDev(objet);
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
            grbAjouterDev.Text = "Modifiez un développeur :";
        }

        /// <summary>
        /// Autorise la modification du mot de passe
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEditPwd_Click(object sender, EventArgs e)
        {
            grbPassword.Enabled = true;
        }

        /// <summary>
        /// Vide les tout grbPwd et interdit la modification du mot de passe
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txbAnnuler_Click(object sender, EventArgs e)
        {
            txbIndiquezMdp.Text = "";
            txbRepetezMdp.Text = "";
            grbPassword.Enabled = false;
        }

        /// <summary>
        /// Demande confirmation, puis vide tous les champs de grbAjouterDev
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAnnulerDev_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez-vous vraiment annuler ?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                txbPrenom.Text = "";
                txbNom.Text = "";
                txbTel.Text = "";
                txbMail.Text = "";
                cmbProfil.SelectedIndex = 0;
            }
        }
    }
}



