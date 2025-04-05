using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
            string requete = "SELECT * FROM developpeur JOIN profil ON developpeur.idprofil = profil.idprofil;"; 

            try
            {
                List<Object[]> list = access.Manager.reqSelect(requete);
                Console.WriteLine("Appel de la requête validé");

                if (list != null && list.Count > 0)
                {
                    foreach (Object[] item in list)
                    {
                        Profil profil = new Profil((int)item[7], (string)item[8]);
                        Developpeur dev = new Developpeur((int)item[0], (string)item[1], (string)item[2], (string)item[3], (string)item[4], profil);
                        liste.Add(dev);
                    }
                }
                return liste;
            }
            catch (Exception ex)
            {
                MessageBox.Show("E02 : Erreur lors de l'exécution de la requête");
                Environment.Exit(0);
                return liste = null;
            }
        }

        public void DelDeveloppeur (Developpeur dev) {
            string requete = "DELETE FROM developpeur WHERE iddeveloppeur IN (@iddeveloppeur);";
            
            Dictionary<string, object> parameters = new Dictionary<string, object>();

            parameters.Add("@iddeveloppeur", dev.Iddeveloppeur);

            try { access.Manager.reqUpdate(requete, parameters); } catch { MessageBox.Show("E03 : Erreur lors de l'exécution de la requête"); }

        }

        public void AddDeveloppeur (Developpeur dev) {
            string requete = "INSERT INTO developpeur (iddeveloppeur, prenom, nom, tel, mail, idprofil) VALUES (@iddeveloppeur, @prenom, @nom, @tel, @mail, @idprofil);";

            Dictionary<string, object> parameters = new Dictionary<string, object>();

            parameters.Add("@iddeveloppeur", dev.Iddeveloppeur);
            parameters.Add("@prenom", dev.Prenom);
            parameters.Add("@nom", dev.Nom);
            parameters.Add("@tel", dev.Tel);
            parameters.Add("@mail", dev.Mail);
            parameters.Add("idprofil", dev.Profil.Idprofil);

            try { access.Manager.reqUpdate(requete, parameters); } catch { MessageBox.Show("E04 : Erreur lors de l'exécution de la requête"); }
        }

        public void UpdateDeveloppeur (Developpeur dev) {
            string requete = "UPDATE developpeur SET prenom = @prenom, nom = @nom, tel = @tel, mail = @mail, idprofil = @idprofil WHERE iddeveloppeur IN (@iddeveloppeur);";

            Dictionary<string, object> parameters = new Dictionary<string, object>();

            parameters.Add("@iddeveloppeur", dev.Iddeveloppeur);
            parameters.Add("@prenom", dev.Prenom);
            parameters.Add("@nom", dev.Nom);
            parameters.Add("@tel", dev.Tel);
            parameters.Add("@mail", dev.Mail);
            parameters.Add("idprofil", dev.Profil.Idprofil);

            try { access.Manager.reqUpdate(requete, parameters); } catch { MessageBox.Show("E05 : Erreur lors de l'exécution de la requête"); }
        }

        public void UpdatePwd(Developpeur dev) {
            string requete = "UPDATE developpeur SET pwd = SHA2(@pwd, 256) WHERE iddeveloppeur IN (@iddeveloppeur);";

            Dictionary<string, object> parameters = new Dictionary<string, object>();

            parameters.Add("@iddeveloppeur", dev.Iddeveloppeur);
            parameters.Add("pwd", dev.Pwd);

            try { access.Manager.reqUpdate(requete, parameters); } catch { MessageBox.Show("E06 : Erreur lors de l'exécution de la requête"); }
        }


    }
}
