using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace habilitations2024.bddmanager

{
    public class BddManager
    {
        /// <summary>
        /// Instance unique de la classe
        /// </summary>
        private static BddManager instance = null;

        /// <summary>
        /// Objet de connexion
        /// </summary>
        private readonly MySqlConnection connection;

        /// <summary>
        /// Locker pour supporter le multithread - pas forcément nécessaire
        /// </summary>
        private static readonly object locker = new object();


        /// <summary>
        /// Constructeur privé qui crée la connexion à la DB
        /// </summary>
        /// <param name="chaineConnection">chaine de connexion</param>
        private BddManager(string chaineConnection)
        {
            connection = new MySqlConnection(chaineConnection);

            instance = this;

            connection.Open();
        }

        /// <summary>
        /// Création d'une seule instance selon le patron singleton. Supporte le multithreading
        /// </summary>
        /// <param name="chaineConnection"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Exécution de toutes requêtes autre que "select"
        /// </summary>
        /// <param name="requete">requète SQL demandée</param>
        /// <param name="parameters">paramètres sour forme d'un dictionnaire (null par défaut)</param>
        public void reqUpdate(string requete, Dictionary<string, object> parameters = null)
        {

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

        public List<Object[]> reqSelect(string requete, Dictionary<string, object> parameters = null)
        {
            MySqlCommand commande = new MySqlCommand(requete, connection);

            //Gestion des paramètres
            if (parameters != null)
            {
                foreach (KeyValuePair<string, object> element in parameters)
                {
                    commande.Parameters.Add(new MySqlParameter(element.Key, element.Value));
                }
            }

            commande.Prepare();

            MySqlDataReader reader = commande.ExecuteReader();
            int nbCols = reader.FieldCount;

            List<Object[]> liste = new List<object[]>();

            while (reader.Read())
            {
                Object[] attributs = new Object[nbCols];
                reader.GetValues(attributs);
                liste.Add(attributs);
            } 

            reader.Close();
            return liste;
        }
    }
}
