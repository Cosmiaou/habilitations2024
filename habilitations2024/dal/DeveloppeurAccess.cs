using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using habilitations2024.model;

namespace habilitations2024.dal
{
    public class DeveloppeurAccess
    {
        private readonly Access access;

        public DeveloppeurAccess()
        {
            access = Access.getInstance();
        }

        public List<Developpeur> GetDev()
        {
            List<Developpeur> liste = new List<Developpeur>();
            //Attention, apparemment rajouter nom du profil dans la requete
            string requete = "SELECT * FROM developpeur ORDER BY nom"; 

            try
            {
                List<Object[]> list = access.Manager.reqSelect(requete);

                if (list != null && list.Count > 0)
                {
                    foreach (Object[] item in list)
                    {
                        Developpeur dev = new Developpeur((int)item[0], (string)item[1], (string)item[2], (string)item[3], (string)item[4], (Profil)item[5]);
                        liste.Add(dev);
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

        public void DelDeveloppeur (Developpeur dev) { }

//Prendre en compte les paramètres
        public void AddDeveloppeur (Developpeur dev) { }

        public void UpdateDeveloppeur (Developpeur dev) { }
//Egalement prendre en compte le hachage
        public void UpdatePwd(Developpeur dev) { }


    }
}
