using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using mediatek86.dal;
using mediatek86.model;

namespace mediatek86.controller
{
    internal class FrmAuthentificationController
    {
        /// <summary>
        /// Ici utiliser un profil responsable
        /// </summary>
        private readonly ResponsableAccess Access;

        /// <summary>
        /// Constructeur
        /// </summary>
        public FrmAuthentificationController()
        {
            Access = new ResponsableAccess();
        }

        /// <summary>
        /// Appelle la fonction ControleAuthentification() de la classe ResponsableAccess
        /// </summary>
        /// <param name="admin">Objet de type Admin</param>
        /// <returns>TRUE or FALSE</returns>
        public bool ControleAuthentification(Responsable admin)
        {
            bool reponse = Access.ControleAuthentification(admin);
            return reponse;
        }

    }
}
