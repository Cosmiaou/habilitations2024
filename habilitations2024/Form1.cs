using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace habilitations2024
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string connectionString = "Server=localhost;Database=habilitations;User Id=habilitations;Password=motdepasseuser;";

        private void Form1_Load(object sender, EventArgs e)
        {
            afficherTout();
        }

        private void afficherTout()
        {
            string query = "SELECT * FROM developpeur";

            try
            {
                MySqlConnection connection = new MySqlConnection(connectionString);

                connection.Open();

                MySqlCommand recupererNom = new MySqlCommand(query, connection);

                MySqlDataReader reader = recupererNom.ExecuteReader();

                while (reader.Read())
                {
                    lstNoms.Items.Add(reader["nom"].ToString());
                }

            }
            catch
            {
                MessageBox.Show("Erreur :");
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void testInsert_Click(object sender, EventArgs e)
        {
            BddManager connexion = BddManager.getInstance(connectionString);

            string request = "INSERT INTO developpeur (idprofil, prenom, nom) VALUES (@idprofil, @prenom, @nom);";

            Dictionary<string, object> parameters = new Dictionary<string, object>();

            parameters.Add("@idprofil", "5");
            parameters.Add("@prenom", txbPrenom.Text);
            parameters.Add("@nom", txbNom.Text);

            connexion.reqUpdate(request, parameters);

            afficherTout();

        }
    }
}
