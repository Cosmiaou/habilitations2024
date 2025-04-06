using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using habilitations2024.dal;
using habilitations2024.model;

namespace habilitations2024.controller
{
    internal class FrmAuthentificationController
    {
        private readonly DeveloppeurAccess devAccess;

        /// <summary>
        /// Constructeur
        /// </summary>
        public FrmAuthentificationController()
        {
            devAccess = new DeveloppeurAccess();
        }

        /// <summary>
        /// Appelle la fonction ControleAuthentification() de la classe DeveloppeurAccess
        /// </summary>
        /// <param name="admin">Objet de type Admin</param>
        /// <returns>TRUE or FALSE</returns>
        public bool ControleAuthentification(Admin admin)
        {
            bool reponse = devAccess.ControleAuthentification(admin);
            return reponse;
        }

    }
}
