using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mediatek86.model
{
    public class Responsable
    {
        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="login"></param>
        /// <param name="pwd"></param>
        public Responsable(string login, string pwd) {
            this.Login = login;
            this.Pwd = pwd;
        }

        /// <summary>
        /// Prenom de l'admin
        /// </summary>
        public string Login { get; }
        /// <summary>
        /// Mot de passe de l'admin
        /// </summary>
        public string Pwd { get; }

    }
}
