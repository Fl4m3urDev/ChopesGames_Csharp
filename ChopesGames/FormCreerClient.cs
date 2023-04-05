using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;


namespace ChopesGames
{
    public partial class FormCreerClient : Form
    {
        private Regex regNomPrenomVille = new Regex("^[a-zA-Zéèêëçàâôù ûïî-]*$");
        private Regex regCodePostal = new Regex("^(([0-8][0-9])|(9[0-5])|(2[ab]))[0-9]{3}$");
        private Regex regAdresse = new Regex("^[a-zA-Z0-9 '-]*?[a-zA-Zéèêëçàâôù ûïî-]+$");
        private Regex regEmail = new Regex(@"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z");
        private bool nomEstValide, prenomEstValide, adresseEstValide, villeEstValide, codePostalEstValide, emailEstValide = false; // controle

        public FormCreerClient()
        {
            InitializeComponent();
        }

        private void btnCreer_Click(object sender, EventArgs e)
        {
            MySqlConnection maCnx; // ! déclaration avant le bloc Try
            maCnx = new MySqlConnection("SERVER=127.0.0.1; DATABASE=chopesgames; UID=root; PASSWORD=");
            if (nomEstValide && prenomEstValide && adresseEstValide && villeEstValide
                && codePostalEstValide && emailEstValide)
            {
                try
                {
                    string requête;
                    maCnx.Open(); // on se connecte
                    requête = "INSERT INTO Client (NOM,PRENOM,ADRESSE,VILLE, CODEPOSTAL, EMAIL) values (@nom,@prenom,@adresse,@ville,@codePostal,@email)";
                    var maCde = new MySqlCommand(requête, maCnx);
                    maCde.Prepare();
                    maCde.Parameters.AddWithValue("@nom", tbxNom.Text);
                    maCde.Parameters.AddWithValue("@prenom", tbxPrenom.Text);
                    maCde.Parameters.AddWithValue("@adresse", tbxAdresse.Text);
                    maCde.Parameters.AddWithValue("@ville", tbxVille.Text);
                    maCde.Parameters.AddWithValue("@codePostal", tbxCodePostal.Text);
                    maCde.Parameters.AddWithValue("@email", tbxEmail.Text.ToString());
                    int nbLigneAffectées;
                    nbLigneAffectées = maCde.ExecuteNonQuery();
                    MessageBox.Show(nbLigneAffectées.ToString() + " client(s) créé(s)!", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tbxNom.Clear();
                    tbxPrenom.Clear();
                    tbxAdresse.Clear();
                    tbxCodePostal.Clear();
                    tbxVille.Clear();
                    tbxEmail.Clear();
                }
                catch (MySqlException erreur)
                {
                    MessageBox.Show("Echec lors de l'ajout : " + erreur.ToString(), "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (maCnx is object & maCnx.State == ConnectionState.Open)
                    {
                        maCnx.Close(); // on se déconnecte
                    }
                }
            }
            else // un champ au moins n'est pas valide
            {
                MessageBox.Show("Au moins un champ n'est pas renseigné correctement", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        /* Validation des zones de saisie. 
         * 
        */
        private void tbxNom_Leave(object sender, EventArgs e)
        {
            if (regNomPrenomVille.Match(tbxNom.Text).Success & tbxNom.Text != null)
            {
                tbxNom.BackColor = SystemColors.Window;
                tbxNom.Text = tbxNom.Text.ToUpper();
                nomEstValide = true;
            }
            else
            {
                tbxNom.BackColor = Color.Red;
                nomEstValide = false;
            }
        }
        private void tbxPrenom_Leave(object sender, EventArgs e)
        {
            if (regNomPrenomVille.Match(tbxPrenom.Text).Success & tbxPrenom.Text != "")
            {
                tbxPrenom.BackColor = SystemColors.Window;
                tbxPrenom.Text = (tbxPrenom.Text.Substring(0, 1)).ToUpper() + tbxPrenom.Text.Substring(1);
                prenomEstValide = true;
            }
            else
            {
                tbxPrenom.BackColor = Color.Red;
                prenomEstValide = false;
            }
        }
        private void tbxAdresse_Leave(object sender, EventArgs e)
        {
            if (regAdresse.Match(tbxNom.Text).Success & tbxAdresse.Text != "")
            {
                tbxAdresse.BackColor = SystemColors.Window;
                adresseEstValide = true;
            }
            else
            {
                tbxAdresse.BackColor = Color.Red;
                adresseEstValide = false;
            }
        }
        private void tbxVille_Leave(object sender, EventArgs e)
        {
            if (regNomPrenomVille.Match(tbxNom.Text).Success & tbxVille.Text != "")
            {
                tbxVille.BackColor = SystemColors.Window;
                tbxVille.Text = tbxVille.Text.ToUpper();
                villeEstValide = true;
            }
            else
            {
                tbxVille.BackColor = Color.Red;
                villeEstValide = false;
            }
        }
        private void tbxCodePostal_Leave(object sender, EventArgs e)
        {
            if (regCodePostal.Match(tbxCodePostal.Text).Success & tbxCodePostal.Text != "")
            {
                tbxCodePostal.BackColor = SystemColors.Window;
                codePostalEstValide = true;
            }
            else
            {
                tbxCodePostal.BackColor = Color.Red;
                codePostalEstValide = false;
            }
        }
        private void tbxEmail_Leave(object sender, EventArgs e)
        {
            if (regEmail.Match(tbxEmail.Text).Success & tbxEmail.Text != "")
            {
                tbxEmail.BackColor = SystemColors.Window;
                emailEstValide = true;
            }
            else
            {
                tbxEmail.BackColor = Color.Red;
                emailEstValide = false;
            }
        }

        /* Dans les méthodes qui suivent on vide les zones de saisie de exemple
         * et on passe la couleur de la police à noire pour plus de lisibilité
         */
        private void tbxNom_Enter(object sender, EventArgs e)
        {
            if (tbxNom.Text == "ex. : JAOUEN")
            {
                tbxNom.Text = null;
                tbxNom.ForeColor = Color.Black;
            }
        }


        private void tbxPrenom_Enter(object sender, EventArgs e)
        {
            if (tbxPrenom.Text == "ex. : Yves")
            {
                tbxPrenom.Text = null;
                tbxPrenom.ForeColor = Color.Black;
            }
        }
        private void tbxAdresse_Enter(object sender, EventArgs e)
        {
            if (tbxAdresse.Text == "ex. : 1 rue de Gouédic (sans de virgule)")
            {
                tbxAdresse.Text = null;
                tbxAdresse.ForeColor = Color.Black;
            }
        }
        private void tbxVille_Enter(object sender, EventArgs e)
        {
            if (tbxVille.Text == "ex. : Saint Brieuc")
            {
                tbxVille.Text = null;
                tbxVille.ForeColor = Color.Black;
            }
        }
        private void tbxCodePostal_Enter(object sender, EventArgs e)
        {
            if (tbxCodePostal.Text == "ex. : 22000")
            {
                tbxCodePostal.Text = null;
                tbxCodePostal.ForeColor = Color.Black;
            }
        }
        private void tbxEmail_Enter(object sender, EventArgs e)
        {
            if (tbxEmail.Text == "ex. : yves.jaouen@rabelais.fr")
            {
                tbxEmail.Text = null;
                tbxEmail.ForeColor = Color.Black;
            }
        }
    }
}
