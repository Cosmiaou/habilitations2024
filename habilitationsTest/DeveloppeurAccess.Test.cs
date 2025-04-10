using habilitations2024.dal;
using habilitations2024.model;
using MySql.Data.MySqlClient;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data;
namespace habilitationsTest
{
    [TestClass]
    public sealed class DeveloppeurAccessTest
    {
        private DeveloppeurAccess access = new DeveloppeurAccess();
        private MySqlConnection? connection;
        private Profil profil = new Profil(5, "admin");
        private Profil profilVide = new Profil(0, " ");

        [TestInitialize]
        public void connexion()
        {
                string chaineConnection = "Server=localhost;Database=habilitations;User Id=habilitations;Password=motdepasseuser;";
                connection = new MySqlConnection(chaineConnection);
                connection.Open();
        }

        [TestCleanup]
        public void Nettoyage()
        {
            if (connection != null && connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }
        
        [TestMethod]
        public void NombreDevsProfilsTest()
        {

            int expected;
            using (MySqlCommand commande = new MySqlCommand("SELECT COUNT(*) FROM developpeur WHERE idprofil = @idprofil;", connection))
            {
                commande.Parameters.Add(new MySqlParameter("@idprofil", profil.Idprofil));
                commande.Prepare();
                using (MySqlDataReader reader = commande.ExecuteReader())
                {
                    reader.Read();
                    expected = reader.GetInt32(0);
                }
            }

            List<Developpeur> liste = access.GetLesDeveloppeurs(profil);
            int resultat = liste.Count;

            Assert.AreEqual(expected, resultat);
        }
        
        [TestMethod]
        public void NombreDevsTest()
        {
            int expected;
            using (MySqlCommand commande = new MySqlCommand("SELECT COUNT(*) FROM developpeur;", connection))
            {
                using (MySqlDataReader reader = commande.ExecuteReader())
                {
                    reader.Read();
                    expected = reader.GetInt32(0);
                }
            }

            List<Developpeur> list = access.GetLesDeveloppeurs(profilVide);
            int resultat = list.Count;

            Assert.AreEqual(expected, resultat);
        } 
    }
}
