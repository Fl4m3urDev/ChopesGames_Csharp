﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChopesGames
{
    class Client
    {
        private int noClient;
        private string nom, prenom, adresse, ville;
        private int codePostal;
        private string email;
        private string motdepasse;

        public Client(int noClient, string nom, string prenom, string adresse,
                        string ville, int codePostal, string email, string motdepasse)
        {
            this.noClient = noClient;
            this.nom = nom;
            this.prenom = prenom;
            this.adresse = adresse;
            this.ville = ville;
            this.codePostal = codePostal;
            this.email = email;
            this.motdepasse = motdepasse;
        }

        public int GetNoClient()
        {
            return noClient;
        }
        public override string ToString()
        {
            return noClient.ToString() + " - " + nom + ", " + prenom + " - " + ville;
        }
    }
}
