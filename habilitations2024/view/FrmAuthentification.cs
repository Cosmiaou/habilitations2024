using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using habilitations2024.controller;
using habilitations2024.model;

namespace habilitations2024.view
{
    public partial class FrmAuthentification : Form
    {
        FrmAuthentificationController controller;
        int compteurErreur = 0;
        /// <summary>
        /// Constructeur
        /// </summary>
        public FrmAuthentification()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Chargement, initialise controller
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmAuthentification_Load(object sender, EventArgs e)
        {
            controller = new FrmAuthentificationController();
            btnConnection.Focus();
        }

        /// <summary>
        /// Lors du clic sur btnConnection, vérifie si tout les champs sont remplis. Si oui, appelle
        /// controller.ControleAuthentification() pour vérifier si le mot de passe est bon. Si oui, lance
        /// le formulaire habilitation normal. Sinon, indique un message d'erreur. Si erreur plus de 5 fois,
        /// ferme l'application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConnection_Click(object sender, EventArgs e)
        {
            if (txbNom.Text.Equals("") || txbPrenom.Text.Equals("") || txbPwd.Text.Equals(""))
            {
                MessageBox.Show("Merci de remplir toutes les informations.");
            }
            else {
                string nom = txbNom.Text;
                string prenom = txbPrenom.Text;
                string pwd = txbPwd.Text;

                Admin admin = new Admin(nom, prenom, pwd);

                if (controller.ControleAuthentification(admin))
                {
                    FrmHabilitations frmHabilitations = new FrmHabilitations();
                    frmHabilitations.ShowDialog();
                    this.Close();
                }
                else if (compteurErreur >= 5)
                {
                    MessageBox.Show("Veuillez réessayer plus tard.");
                    Application.Exit();
                }
                else
                {
                    compteurErreur++;
                    MessageBox.Show("Erreur : le mot de passe incorrect, l'utilisateur n'existe pas, ou le profil n'est pas admin.");
                    btnConnection.Focus();
                }
            }
        }
    }
}
