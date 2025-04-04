using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using habilitations2024.model;
using habilitations2024.bddmanager;

namespace habilitations2024.dal
{
    public class ProfilAccess
    {
        private readonly Access access;


        public ProfilAccess()
        {
            access = Access.getInstance();
        }

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
            catch (Exception ex)
            {
                return liste = null;
                Environment.Exit(0);
            }
        }
    }
}
