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
            string query = "SELECT nom FROM developpeur";

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

            } catch
            {
                MessageBox.Show("Erreur :");
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
