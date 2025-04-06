using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using habilitations2024.model;
using habilitations2024.bddmanager;
using System.Windows.Forms;

namespace habilitations2024.dal
{

    public class ProfilAccess
    {
        private readonly Access access;

        /// <summary>
        /// Constructeur
        /// </summary>
        public ProfilAccess()
        {
            access = Access.getInstance();
        }

        /// <summary>
        /// Crée et envoie une requête SQL pour demander la liste des profils
        /// </summary>
        /// <returns>Liste des profils</returns>
        public List<Profil> GetProfils()
        {
            List<Profil> liste = new List<Profil>();
            string requete = "SELECT * FROM profil";

            try
            {
                List<Object[]> list = access.Manager.reqSelect(requete);

                if (list != null && list.Count > 0)
                {
                    foreach (Object[] item in list)
                    {
                        Profil profil = new Profil((int)item[0], (string)item[1]);

                        liste.Add(profil);
                    }
                }
                return liste;
            }
            catch
            {
                MessageBox.Show("E07 : Erreur lors de l'exécution de la requête SQL");
                Application.Exit();
                return liste = null;
            }
        }
    }
}
