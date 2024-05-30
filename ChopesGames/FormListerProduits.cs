using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChopesGames
{
    public partial class FormListerProduits : Form
    {
        private MySqlConnection maCnx;
        public FormListerProduits()
        {
            InitializeComponent();
            maCnx = new MySqlConnection("SERVER=127.0.0.1; DATABASE=ppe_chopesgames; UID=root; PASSWORD=; Convert Zero Datetime = true;");
        }

        // Permet lors du chargement, une declaration de la requête puis envoie dans charger produit
        private void FormListerProduits_Load(object sender, EventArgs e)
        {
            lvProduits.View = View.Details;
            lvProduits.GridLines = true;
            lvProduits.FullRowSelect = true;
                                             
            lvProduits.Columns.Add("Date", 80);
            lvProduits.Columns.Add("Libelle", 150);
            lvProduits.Columns.Add("Prix HT", 80);
            lvProduits.Columns.Add("Taux TVA", 80);
            lvProduits.Columns.Add("Quantitée", 70);
            lvProduits.Columns.Add("Disponible", 70);
            lvProduits.Columns.Add("Vitrine", 50);

            // Chargement des categories dans cmbCategorie
            try
            {
                string requête;
                int noCategorie;
                string libelle;
                MySqlDataReader jeuEnr = null;
                maCnx.Open(); // on se connecte
                requête = "Select * from Categorie";
                var maCde = new MySqlCommand(requête, maCnx);
                jeuEnr = maCde.ExecuteReader();

                while (jeuEnr.Read())
                {
                    noCategorie = jeuEnr.GetInt32("NOCATEGORIE");
                    libelle = jeuEnr.GetString("LIBELLE");
                    cmbCategorie.Items.Add(new Categorie(noCategorie, libelle));
                }
            }
            catch (MySqlException erreur)
            {
                MessageBox.Show("Erreur de chargement des catégories : " + erreur.ToString());
            }
            finally
            {
                if (maCnx is object & maCnx.State == ConnectionState.Open)
                {
                    maCnx.Close(); // on se déconnecte
                }
            }

            // Chargement des marques dans cmbMarque
            try
            {
                string requête;
                int noMarque;
                string nom;
                MySqlDataReader jeuEnr = null;
                maCnx.Open(); // on se connecte
                requête = "Select * from Marque";
                var maCde = new MySqlCommand(requête, maCnx);
                jeuEnr = maCde.ExecuteReader();

                while (jeuEnr.Read())
                {
                    noMarque = jeuEnr.GetInt32("NOMARQUE");
                    nom = jeuEnr.GetString("NOM");
                    cmbMarque.Items.Add(new Marque(noMarque, nom));
                }
            }
            catch (MySqlException erreur)
            {
                MessageBox.Show("Erreur de chargement des marques : " + erreur.ToString());
            }
            finally
            {
                if (maCnx is object & maCnx.State == ConnectionState.Open)
                {
                    maCnx.Close(); // on se déconnecte
                }
            }

            // Chargement des produits
            string requete = "Select DATEAJOUT,LIBELLE,PRIXHT,TAUXTVA,QUANTITEENSTOCK,DISPONIBLE,VITRINE from Produit";
            ChargerListeProduits(requete);
        }

        // Permet lorsque la valeur de la cmbCategorie change, on récupère le noCategorie et on l'envoie à critères de recherche pour la requête
        private void cmbCategorie_SelectedIndexChanged(object sender, EventArgs e)
        {
            int noCategorie;
            int noMarque;
            if (cmbCategorie.SelectedItem == null)
            {
                noCategorie = 0;
            }
            else
            {
                noCategorie = ((Categorie)(cmbCategorie.SelectedItem)).GetNoCategorie();
                foreach (Categorie categorie in cmbCategorie.Items)
                {
                    if (categorie.GetNoCategorie() == noCategorie)
                    {
                        cmbCategorie.SelectedItem = categorie;
                    }
                }
            }
            if (cmbMarque.SelectedItem == null)
            {
                noMarque = 0;
            }
            else
            {
                noMarque = ((Marque)(cmbMarque.SelectedItem)).GetNoMarque();
                foreach (Marque marque in cmbMarque.Items)
                {
                    if (marque.GetNoMarque() == noMarque)
                    {
                        cmbMarque.SelectedItem = marque;
                    }
                }
            }
            criteresRecherche(noMarque, noCategorie);
        }

        // Permet lorsque la valeur de la cmbMarque change, on récupère le cmbMarque et on l'envoie à critères de recherche pour la requete
        private void cmbMarque_SelectedIndexChanged(object sender, EventArgs e)
        {
            int noCategorie;
            int noMarque;
            if (cmbCategorie.SelectedItem == null)
            {
                noCategorie = 0;
            }
            else
            {
                noCategorie = ((Categorie)(cmbCategorie.SelectedItem)).GetNoCategorie();
                foreach (Categorie categorie in cmbCategorie.Items)
                {
                    if (categorie.GetNoCategorie() == noCategorie)
                    {
                        cmbCategorie.SelectedItem = categorie;
                    }
                }
            }
            if (cmbMarque.SelectedItem == null)
            {
                noMarque = 0;
            }
            else
            {
                noMarque = ((Marque)(cmbMarque.SelectedItem)).GetNoMarque();
                foreach (Marque marque in cmbMarque.Items)
                {
                    if (marque.GetNoMarque() == noMarque)
                    {
                        cmbMarque.SelectedItem = marque;
                    }
                }
            }
            criteresRecherche(noMarque, noCategorie);
        }

        // Permet de charger la liste des produits
        void ChargerListeProduits(string requete)
        {
            lvProduits.Items.Clear();
            try
            {
                MySqlDataReader jeuEnr = null;
                MySqlCommand sqlcomProduits;
                maCnx.Open();
                //MessageBox.Show(requete);
                sqlcomProduits = new MySqlCommand(requete, maCnx);
                jeuEnr = sqlcomProduits.ExecuteReader();
                var TabItem = new string[7];
                while (jeuEnr.Read())
                {

                    TabItem[0] = jeuEnr.GetDateTime("DATEAJOUT").ToString();
                    TabItem[1] = jeuEnr.GetString("LIBELLE");
                    TabItem[2] = jeuEnr.GetDouble("PRIXHT").ToString();
                    TabItem[3] = jeuEnr.GetDouble("TAUXTVA").ToString();
                    TabItem[4] = jeuEnr.GetInt32("QUANTITEENSTOCK").ToString();
                    TabItem[5] = jeuEnr.GetInt32("DISPONIBLE").ToString();
                    TabItem[6] = jeuEnr.GetInt32("VITRINE").ToString();
                    lvProduits.Items.Add(new ListViewItem(TabItem));
                }
            }
            catch (MySqlException erreur)
            {
                MessageBox.Show("Erreur de chargement des produits : " + erreur.ToString());
            }
            finally
            {
                if (maCnx is object & maCnx.State == ConnectionState.Open)
                {
                    maCnx.Close(); // on se déconnecte
                }
            }

        }

        // Permet de préparer la requête avec les valeurs récupérés
        void criteresRecherche(int noMarque, int noCategorie)
        {
            string requete;
            if (noMarque == 0 & noCategorie == 0)
            {
                requete = "Select DATEAJOUT,LIBELLE,PRIXHT,TAUXTVA,QUANTITEENSTOCK,DISPONIBLE,VITRINE from Produit";
            }
            else if (noMarque != 0 & noCategorie == 0)
            {
                requete = "Select DATEAJOUT,LIBELLE,PRIXHT,TAUXTVA,QUANTITEENSTOCK,DISPONIBLE,VITRINE from Produit WHERE NOMARQUE = " + noMarque;
            }
            else if (noMarque == 0 & noCategorie != 0)
            {
                requete = "Select DATEAJOUT,LIBELLE,PRIXHT,TAUXTVA,QUANTITEENSTOCK,DISPONIBLE,VITRINE from Produit WHERE NOCATEGORIE = " + noCategorie;
            }
            else
            {
                requete = "Select DATEAJOUT,LIBELLE,PRIXHT,TAUXTVA,QUANTITEENSTOCK,DISPONIBLE,VITRINE from Produit WHERE NOMARQUE = " + noMarque + " AND NOCATEGORIE = " + noCategorie;
            }
            ChargerListeProduits(requete);
        }
    }
}
