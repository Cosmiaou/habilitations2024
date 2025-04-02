using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace habilitations2024.bddmanager

{
    internal class BddManager
    {
        private static BddManager instance = null;
        private static MySqlConnection connection;
        private static readonly object locker = new object();

        private BddManager(string chaineConnection) {
            connection = new MySqlConnection(chaineConnection);

            instance = this;

            connection.Open();
        }

        public static BddManager getInstance(string chaineConnection)
        {
            if (BddManager.instance == null)
            {
                lock (locker)
                {
                    if (BddManager.instance == null)
                    {
                        BddManager.instance = new BddManager(chaineConnection);
                    }
                }
            }
            return BddManager.instance;
        }

        public void reqUpdate (string requete, Dictionary<string, object> parameters = null) {

            MySqlCommand commande = new MySqlCommand(requete, connection);

            //Gestion des paramètres
            if (parameters != null)
            {
                foreach (KeyValuePair<string, object> element in parameters)
                {
                    commande.Parameters.Add(new MySqlParameter(element.Key, element.Value));
                }
            }

            //Préparation et éxécution
            commande.Prepare();
            commande.ExecuteNonQuery();
        }


    }
}
