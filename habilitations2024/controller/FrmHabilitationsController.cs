using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using habilitations2024.dal;
using habilitations2024.model;
using Mysqlx.Crud;

namespace habilitations2024.controller
{
    public class FrmHabilitationsController
    {
        private readonly DeveloppeurAccess devAccess;
        private readonly ProfilAccess profAccess;

        /// <summary>
        /// Constructeur
        /// </summary>
        public FrmHabilitationsController()
        {
            profAccess = new ProfilAccess();
            devAccess = new DeveloppeurAccess();
        }

        /// <summary>
        /// Reçoit la liste des développeurs
        /// </summary>
        /// <returns>List Developpeur</returns>
        public List<Developpeur> GetLesDeveloppeurs()
        {
            return devAccess.GetLesDeveloppeurs();
        }

        /// <summary>
        /// Reçoit la liste des profils
        /// </summary>
        /// <returns>List Developpeur</returns>
        public List<Profil> GetLesProfils()
        {
            return profAccess.GetProfils();
        }

        /// <summary>
        /// Appelle la fonction de suppression d'un développeur
        /// </summary>
        /// <param name="dev">Object de type Developpeur</param>
        public void DelDev (Developpeur dev) {
            devAccess.DelDeveloppeur(dev);
        }

        /// <summary>
        /// Appelle la fonction d'ajout d'un développeur
        /// </summary>
        /// <param name="dev">Objet développeur</param>
        public void AddDev (Developpeur dev) {
            devAccess.AddDeveloppeur(dev);
        }

        /// <summary>
        /// Appelle la fonction de MàJ d'un développeur
        /// </summary>
        /// <param name="dev">Objet développeur</param>
        public void UpdateDev (Developpeur dev) {
            devAccess.UpdateDeveloppeur(dev);
        }

        /// <summary>
        /// Appelle la fonction de MàJ d'un mot de passe
        /// </summary>
        /// <param name="dev">Objet développeur</param>
        public void UpdatePwd (Developpeur dev) {
            devAccess.UpdatePwd(dev);
        }
    }
}
