using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace habilitations2024.model
{
    public class Admin
    {
        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="nom"></param>
        /// <param name="prenom"></param>
        /// <param name="pwd"></param>
        public Admin(string nom, string prenom, string pwd) {
            this.Nom = nom;
            this.Prenom = prenom;
            this.Pwd = pwd;
        }

        /// <summary>
        /// Nom de l'admin
        /// </summary>
        public string Nom { get; }
        /// <summary>
        /// Prenom de l'admin
        /// </summary>
        public string Prenom { get; }
        /// <summary>
        /// Mot de passe de l'admin
        /// </summary>
        public string Pwd { get; }

    }
}
