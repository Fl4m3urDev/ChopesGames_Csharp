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
    public partial class FormAccueil : Form
    {
        public FormAccueil()
        {
            InitializeComponent();
        }

        private void miCreerClient_Click(object sender, EventArgs e)
        {
            FormCreerClient formCreerClient = new FormCreerClient();
            formCreerClient.ShowDialog();
        }

        private void miCreerProduit_Click(object sender, EventArgs e)
        {
            FormCreerProduit formCreerProduit = new FormCreerProduit();
            formCreerProduit.ShowDialog();
        }

        private void miCreerCommande_Click(object sender, EventArgs e)
        {
            FormCreerCommande formCreerCommande = new FormCreerCommande();
            formCreerCommande.ShowDialog();
        }

        private void miListerCommandes_Click(object sender, EventArgs e)
        {
            FormListerCommandes formListerCommandes = new FormListerCommandes();
            formListerCommandes.ShowDialog(); 
        }

        private void miAProposDeSpaceBoutique_Click(object sender, EventArgs e)
        {

            // Nota Bene : pour que la fenêtre 'About' se renseigne correctement : dans Projet->Propriétés renseigner les "Informations de l'Assembly"
            FormAPropos formAPropos = new FormAPropos();
            formAPropos.ShowDialog();
        }

    }
}
