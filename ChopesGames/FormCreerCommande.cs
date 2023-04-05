using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing; // pour SystemColors
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ChopesGames
{
    public partial class FormCreerCommande : Form
    {
        private MySqlConnection sqlcon;
        private Regex regexNombreEntier = new Regex("^[1-9][0-9]?$|^100$");

        public FormCreerCommande()
        {
            InitializeComponent();
            sqlcon = new MySqlConnection("SERVER=127.0.0.1; DATABASE=chopesgames; UID=root; PASSWORD=");
        } // FIN FormCreerCommande

        private void FormCreerCommande_Load(object sender, EventArgs e)
        {

            lblDateCourante.Text = DateTime.Now.ToString();
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

            // Chargement des produits dans cmbProduit
            try
            {
                int noProduit;
                string libelle;
                double prixHT, tauxTVA;
                MySqlDataReader jeuEnr = null;
                sqlcon.Open();
                string requete = "Select NOPRODUIT, LIBELLE, PRIXHT, TAUXTVA FROM produit ORDER BY NOPRODUIT";
                var maCde = new MySqlCommand(requete, sqlcon);
                jeuEnr = maCde.ExecuteReader();
                while (jeuEnr.Read())
                {
                    noProduit = jeuEnr.GetInt32("NOPRODUIT");
                    libelle = jeuEnr.GetString("LIBELLE");
                    prixHT = jeuEnr.GetDouble("PRIXHT");
                    tauxTVA = jeuEnr.GetDouble("TAUXTVA");
                    cmbProduit.Items.Add(new Produit(noProduit, libelle, prixHT, tauxTVA));
                }
            }
            catch (MySqlException erreur)
            {
                MessageBox.Show("Erreur chargement des produits : " + erreur.ToString());
            }
            finally
            {
                if (sqlcon is object & sqlcon.State == ConnectionState.Open)
                {
                    sqlcon.Close(); // on se déconnecte
                }
            }

            // initialisation de la listViev lignes de commande lvLignesCommande
            lvLignesCommande.View = View.Details; // Mode d'affichage
            lvLignesCommande.GridLines = true; // on affichera la grille
            lvLignesCommande.FullRowSelect = true; // Mode de sélection : ligne
                                                   // Pour le mode de selection voir aussi la property SelectionMode
            lvLignesCommande.Columns.Add("n°", 30);
            lvLignesCommande.Columns.Add("Libellé", 160);
            lvLignesCommande.Columns.Add("Quantité", 60);
            lvLignesCommande.Columns.Add("Prix HT", 50);
            lvLignesCommande.Columns.Add("TVA", 40);
            lvLignesCommande.Columns.Add("Total TVA", 60);
            lvLignesCommande.Columns.Add("Total TTC", 70);
        } // FIN FormCreerCommande_Load

        private void MiseAJourLignesCommande()
        {
            // MAJ lignes de commande = lvLignesCommande
            double totalHTLigne, totalTVALigne, totalTTCLigne; // à 0 par défaut
            double totalHT, totalTTC; // à 0 par défaut
            int nombreDItems;

            nombreDItems = 0;
            totalHT = 0;
            totalTTC = 0;

            // on recacule les totaux par ligne et pour le tableau
            foreach (ListViewItem ligne in lvLignesCommande.Items)
            {
                totalHTLigne = double.Parse(ligne.SubItems[2].Text) * double.Parse(ligne.SubItems[3].Text);
                totalHT = totalHT + totalHTLigne;

                totalTVALigne = totalHTLigne * double.Parse(ligne.SubItems[4].Text) / 100;
                ligne.SubItems[5].Text = totalTVALigne.ToString();

                totalTTCLigne = totalHTLigne + totalTVALigne;
                ligne.SubItems[6].Text = totalTTCLigne.ToString();
                totalTTC = totalTTC + totalTTCLigne;

                nombreDItems = nombreDItems + int.Parse(ligne.SubItems[2].Text);
            }

            // mise à jour des labels sous la listView
            lblNombreDItems.Text = nombreDItems.ToString();
            lblTotalHT.Text = totalHT.ToString();
            lblTotalTTC.Text = totalTTC.ToString();
        } // FIN MiseAJourLignesCommande

        void ReinitialiserFormulaire()
        {
            lvLignesCommande.Items.Clear();
            lblTotalHT.Text = "0";
            lblTotalTTC.Text = "0";
            lblNombreDItems.Text = "0";
            cmbClient.SelectedItem = null;
            cmbProduit.SelectedItem = null;
        } // FIN ReinitialiserFormulaire

        private void btnAjoutUneLigne_Click(object sender, EventArgs e)
        {
            tbxQuantite.BackColor = SystemColors.Window;
            var TabItem = new string[7];
            //ListViewItem unItem; SERT A RIEN
            bool trouve = false;
            // Dans ce qui suit on regarde si le produit n'est pas déjà dans le listView
            // test fait sur le n° de produit
            if (lvLignesCommande.Items.Count > 0)
            {
                foreach (ListViewItem ligne in lvLignesCommande.Items)
                {
                    if (((Produit)(cmbProduit.SelectedItem)).GetNoProduit() == int.Parse(ligne.SubItems[0].Text))
                    {
                        trouve = true;
                        MessageBox.Show("Produit déjà dans la Commande", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break; // sortie forcée de la boucle
                    }
                }
            }

            if (!trouve) // pas déjà dans la listView, on peut faire l'ajout
            {
                if (regexNombreEntier.Match(tbxQuantite.Text).Success) // et quantité valide
                {
                    TabItem[0] = ((Produit)(cmbProduit.SelectedItem)).GetNoProduit().ToString();
                    TabItem[1] = ((Produit)(cmbProduit.SelectedItem)).GetLibelle();
                    TabItem[2] = tbxQuantite.Text.ToString();
                    TabItem[3] = (((Produit)(cmbProduit.SelectedItem)).GetPrixHT()).ToString();
                    TabItem[4] = ((Produit)(cmbProduit.SelectedItem)).GetTauxTVA().ToString();

                    // unItem = new ListViewItem(TabItem); SERT A RIEN ? ? ? ? ? ? ? ? ?
                    lvLignesCommande.Items.Add(new ListViewItem(TabItem));

                    MiseAJourLignesCommande();
                }
                else
                {
                    MessageBox.Show("Quantité saisie non valide.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tbxQuantite.BackColor = Color.Red;
                } // if validation quantité
            }
            // produit déjà ajouté dans la listView déjà traité (cf. ci-dessus foreach)
        } // FIN btnAjoutUneLigne_Click


        private void btnReinitialiserFormulaire_Click(object sender, EventArgs e)
        {
            ReinitialiserFormulaire();
        } // FIN btnReinitialiserFormulaire_Click

        private void miSupprimerLigneCourante_Click(object sender, EventArgs e) // menu contextuel sur listView
        {
            if (lvLignesCommande.SelectedItems.Count > 0)
            { // si au moins une ligne sélectionnée 
                lvLignesCommande.SelectedItems[0].Remove(); // suppression de la première ligne sélectionnée
                // (N.B. : sélection multiple à false)
                MiseAJourLignesCommande();
            }
        } // FIN miSupprimerLigneCourante_Click

        private void miValider_Click(object sender, EventArgs e) // modification de quantité, menu contextuel sur listView
        {
            if (int.Parse(tstbxQuantite.Text) > 1)
            {   // on met a jour la colonne 'quantité' (2) de la ligne sélectionnée
                lvLignesCommande.SelectedItems[0].SubItems[2].Text = tstbxQuantite.Text;
                MiseAJourLignesCommande();
            }
            else
            {
                MessageBox.Show("La nouvelle quantité doit être > 1");
            }
        } // FIN miValider_Click

        /* 
     *  ("n°", 30); col. 0
        ("Libellé", 160); col. 1
        ("Quantité", 80); col. 2 
        ("Prix HT", 100); col. 3
        ("TVA", 100); col . 4
        ("Total TVA", 100); col. 5
        ("Total TTC", 100); col. 6
     * */
        private void btnCreer_Click(object sender, EventArgs e)
        {
            Int32 noCommande = 0;
            if (lvLignesCommande.Items.Count == 0)
            {
                MessageBox.Show("La commande est vide");
            }
            else
            {

                if (cmbClient.SelectedItem != null) // si un client est sélectionné
                {
                    //////////////////////////////////
                    // D'ABORD création de la commande
                    //////////////////////////////////
                    try
                    {
                        int noClient = ((Client)(cmbClient.SelectedItem)).GetNoClient();
                        sqlcon.Open(); // on se connecte
                        string requete = "INSERT INTO Commande (NOCLIENT, DATECOMMANDE, TOTALHT, TOTALTTC) values (@noClient, @dateCommande, @totalHT,@totalTTC);SELECT LAST_INSERT_ID()";
                        var sqlcomCommande = new MySqlCommand(requete, sqlcon);
                        sqlcomCommande.Prepare();
                        sqlcomCommande.Parameters.AddWithValue("@noClient", noClient);
                        sqlcomCommande.Parameters.AddWithValue("@dateCommande", DateTime.Now);
                        sqlcomCommande.Parameters.AddWithValue("@totalHT", double.Parse(lblTotalHT.Text));
                        sqlcomCommande.Parameters.AddWithValue("@totalTTC", double.Parse(lblTotalTTC.Text));
                        noCommande = Convert.ToInt32(sqlcomCommande.ExecuteScalar()); // en cas de null, erreur à l'exécution si cast
                        MessageBox.Show("Commande crée : n°" + noCommande.ToString());
                    }
                    catch (MySqlException erreur)
                    {
                        MessageBox.Show("Echec insertion dans table Commande" + erreur.ToString(), "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        // sortie function si soucis avec création commande... erreur sur création des lignes associées
                        // (erreur gérée par try catch)
                    }
                    finally
                    {
                        if (sqlcon is object & sqlcon.State == ConnectionState.Open)
                        {
                            sqlcon.Close();
                        }
                    }

                    //////////////////////////////////////////////////////////////
                    // PUIS : parcours du listView et insertion, pour chaque ligne
                    //////////////////////////////////////////////////////////////

                    foreach (ListViewItem ligne in lvLignesCommande.Items)
                    {
                        try
                        {
                            sqlcon.Open();
                            var sqlcomLigne = new MySqlCommand("INSERT INTO Ligne values (@noCommande,@noProduit,@quantiteCommandee);", sqlcon);
                            sqlcomLigne.Prepare();
                            sqlcomLigne.Parameters.AddWithValue("@noCommande", noCommande);
                            sqlcomLigne.Parameters.AddWithValue("@noProduit", ligne.SubItems[0].Text);
                            sqlcomLigne.Parameters.AddWithValue("@quantiteCommandee", ligne.SubItems[2].Text);
                            sqlcomLigne.ExecuteNonQuery();
                        }

                        catch (MySqlException erreur)
                        {
                            MessageBox.Show("Echec insertion dans table Ligne" + erreur.ToString(), "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            if (sqlcon is object & sqlcon.State == ConnectionState.Open)
                            {
                                sqlcon.Close();
                            }
                        }
                    } // foreach

                    ReinitialiserFormulaire();
                }
                else
                    MessageBox.Show("Pas de client sélectionné.");
            } // if commande vide
        } // FIN btnCreer_Click
    } // FIN FORM
} // FIN NAMESPACE
