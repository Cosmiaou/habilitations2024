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

        public FrmHabilitationsController()
        {
            profAccess = new ProfilAccess();
            devAccess = new DeveloppeurAccess();
        }

        public List<Developpeur> GetLesDeveloppeurs()
        {
            return devAccess.GetDev();
        }

        public List<Profil> GetLesProfils()
        {
            return profAccess.GetProfils();
        }

        public void DelDev (Developpeur dev) {
            devAccess.DelDeveloppeur(dev);
        }
        public void AddDev (Developpeur dev) {
            devAccess.AddDeveloppeur(dev);
        }
        public void UpdateDev (Developpeur dev) {
            devAccess.UpdateDeveloppeur(dev);
        }
        public void UpdatePwd (Developpeur dev) {
            devAccess.UpdatePwd(dev);
        }
    }
}
