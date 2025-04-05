using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace habilitations2024.model
{
    public class Developpeur
    {
        /// <summary>
        /// Crée
        /// </summary>
        /// <param name="iddeveloppeur">id du développeur, définie automatiquement dans la DB. Quand on appelle la fonction pour créer un développeur, il faut mettre "0" pour laisser le SGBDD autincrémenter la fonction</param>
        /// <param name="nom">nom du développeur</param>
        /// <param name="prenom">prénom du dev</param>
        /// <param name="tel">N° de téléphone du dev</param>
        /// <param name="mail">adresse email du dev</param>
        /// <param name="profil">Objet de type profil</param>
        public Developpeur(int iddeveloppeur, string nom, string prenom, string tel, string mail, Profil profil) { 
            this.Iddeveloppeur = iddeveloppeur;
            this.Nom = nom;
            this.Prenom = prenom;   
            this.Tel = tel;
            this.Mail = mail;
            this.Profil = profil;
        }

        /// <summary>
        /// Retourne l'idée du developpeur
        /// </summary>
        public int Iddeveloppeur { get;  }
        /// <summary>
        /// Nom du dev
        /// </summary>
        public string Nom { get; set; }  
        /// <summary>
        /// Prenom du dev
        /// </summary>
        public string Prenom { get; set; }
        /// <summary>
        /// N° de tel du dev
        /// </summary>
        public string Tel { get; set; }
        /// <summary>
        /// Objet de type profil associé au developpeur
        /// </summary>
        public Profil Profil { get; set; }
        /// <summary>
        /// Adresse email du dev
        /// </summary>
        public string Mail { get; set; }
        /// <summary>
        /// Mot de passe du développeur. N'est pas assigné dès l'appel du constructeur.
        /// </summary>
        public string Pwd { get; set; }
    }
}
