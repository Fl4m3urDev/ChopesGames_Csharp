using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChopesGames
{
    class Produit
    {
        // NOPRODUIT, LIBELLE, PRIXHT, TAUXTVA
        private int noProduit;
        private string libelle;
        private double prixHT, tauxTVA;

        public Produit(int noProduit, string libelle, double prixHT, double tauxTVA)
        {
            this.noProduit = noProduit;
            this.libelle = libelle;
            this.prixHT = prixHT;
            this.tauxTVA = tauxTVA;
        }
        public int GetNoProduit()
        {
            return noProduit;
        }
        public string GetLibelle()
        {
            return libelle;
        }
        public double GetPrixHT()
        {
            return prixHT;
        }
        public double GetTauxTVA()
        {
            return tauxTVA;
        }
        public override string ToString()
        {
            return noProduit.ToString() + " - " + libelle + " - " + prixHT.ToString();
        }
    }
}
