using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace ChopesGames
{
    public partial class FormListerCommandes : Form
    {
        private MySqlConnection sqlcon;
        public FormListerCommandes()
        {
            InitializeComponent();
            sqlcon = new MySqlConnection("SERVER=127.0.0.1; DATABASE=ppe_chopesgames; UID=root; PASSWORD=");
        }

        void ChargerListeCommandes(int noClient)
        {
            // initialisation de la listViev lignes de commande lvCommandes
            lvCommandes.View = View.Details; // Mode d'affichage
            lvCommandes.GridLines = true; // on affichera la grille
            lvCommandes.FullRowSelect = true; // Mode de sélection : ligne
                                              // Pour le mode de selection voir aussi la property SelectionMode
            lvCommandes.Columns.Add("n°", 60);
            lvCommandes.Columns.Add("Date", 150);
            lvCommandes.Columns.Add("Total HT", 100);
            lvCommandes.Columns.Add("Total TTC", 100);

            // Chargement des produits dans cmbProduit
            try
            {
                MySqlDataReader jeuEnr = null;
                MySqlCommand sqlcomCommandes;
                sqlcon.Open();
                if (noClient >= 0) // si noClient < 0 on sort toutes les dernières commandes, sinon seulement celles de noClient
                {
                    string requete = "Select NOCOMMANDE, DATECOMMANDE, TOTALHT, TOTALTTC FROM commande WHERE NOCLIENT=@noClient ORDER BY NOCOMMANDE DESC;";
                    sqlcomCommandes = new MySqlCommand(requete, sqlcon);
                    sqlcomCommandes.Prepare();
                    sqlcomCommandes.Parameters.AddWithValue("@noClient", noClient);
                }
                else
                {
                    string requete = "Select NOCOMMANDE, DATECOMMANDE, TOTALHT, TOTALTTC FROM commande ORDER BY NOCOMMANDE DESC;";
                    sqlcomCommandes = new MySqlCommand(requete, sqlcon);
                }
                jeuEnr = sqlcomCommandes.ExecuteReader();

                var TabItem = new string[4];
                while (jeuEnr.Read())
                {

                    TabItem[0] = jeuEnr.GetInt32("NOCOMMANDE").ToString();
                    TabItem[1] = jeuEnr.GetDateTime("DATECOMMANDE").ToString();
                    TabItem[2] = jeuEnr.GetDouble("TOTALHT").ToString();
                    TabItem[3] = jeuEnr.GetDouble("TOTALTTC").ToString();

                    lvCommandes.Items.Add(new ListViewItem(TabItem));
                }
            }
            catch (MySqlException erreur)
            {
                MessageBox.Show("Erreur chargement des commandes : " + erreur.ToString());
            }
            finally
            {
                if (sqlcon is object & sqlcon.State == ConnectionState.Open)
                {
                    sqlcon.Close(); // on se déconnecte
                }
            }

        } // FIN Charger Commandes

        private void FormListerCommandes_Load(object sender, EventArgs e)
        {
            ChargerListeCommandes(-1); // noClient = -1, on sortira toutes les commandes

            // Chargement des clients dans cmbClient
            try
            {
                int noClient;
                string nom, prenom, adresse, ville;
                int codePostal;
                string email;
                MySqlDataReader jeuEnr = null;
                sqlcon.Open();
                var maCde = new MySqlCommand("Select * from Client", sqlcon);
                jeuEnr = maCde.ExecuteReader();
                while (jeuEnr.Read())
                {
                    noClient = jeuEnr.GetInt32("NOCLIENT");
                    nom = jeuEnr.GetString("NOM");
                    prenom = jeuEnr.GetString("PRENOM");
                    adresse = jeuEnr.GetString("ADRESSE");
                    ville = jeuEnr.GetString("VILLE");
                    codePostal = jeuEnr.GetInt32("CODEPOSTAL");
                    email = jeuEnr.GetString("EMAIL");
                    cmbClient.Items.Add(new Client(noClient, nom, prenom, adresse, ville, codePostal, email));
                }
            }
            catch (MySqlException erreur)
            {
                MessageBox.Show("Erreur chargement des clients : " + erreur.ToString());
            }
            finally
            {
                if (sqlcon is object & sqlcon.State == ConnectionState.Open)
                {
                    sqlcon.Close(); // on se déconnecte
                }
            }
        }

        private void cmbClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            lvCommandes.Clear();
            int noClient = ((Client)(cmbClient.SelectedItem)).GetNoClient();
            ChargerListeCommandes(noClient);
        }
    }
}
