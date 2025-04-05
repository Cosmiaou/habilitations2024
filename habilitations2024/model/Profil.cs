using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace habilitations2024.model
{
    public class Profil
    {
        /// <summary>
        /// Constructeur qui crée un profil
        /// </summary>
        /// <param name="idprofil">id du profil, entre 1 et 5, comme indiqué dans la BDD</param>
        /// <param name="nom">nom du profil, lié à un id dans la BDD</param>
        public Profil(int idprofil, string nom)
        {
            this.Idprofil = idprofil;
            this.Nom = nom;
        }

        /// <summary>
        /// Retourne l'idprofil
        /// </summary>
        public int Idprofil { get; }
        /// <summary>
        /// Retourne le nom du profil
        /// </summary>
        public string Nom { get; }

        /// <summary>
        /// Redéfinie ToString pour toujours renvoyer le nom du profil quand appelé
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this.Nom;
        }
    }
}
