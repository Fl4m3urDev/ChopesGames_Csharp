using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChopesGames
{
    class Produit
    {
        // NOPRODUIT, QUANTITEENSTOCK, LIBELLE, DETAIL, NOMIMAGE, PRIXHT, TAUXTVA, DISPONIBLE, VITRINE, DATEAJOUT
        private int noProduit, quantiteEnStock;
        private string libelle, detail, nomImage;
        private double prixHT, tauxTVA;
        bool disponibilite, vitrine;
        DateTime dateAjout;

        public Produit(int noProduit, int quantiteEnStock,  string libelle, string detail, string nomImage, double prixHT, double tauxTVA, bool disponibilite, bool vitrine, DateTime dateAjout)
        {
            this.noProduit = noProduit;
            this.quantiteEnStock = quantiteEnStock;
            this.libelle = libelle;
            this.detail = detail;
            this.nomImage = nomImage;
            this.prixHT = prixHT;
            this.tauxTVA = tauxTVA;
            this.disponibilite = disponibilite;
            this.vitrine = vitrine;
            this.dateAjout = dateAjout.Date;
        }
        public int GetNoProduit()
        {
            return noProduit;
        }
        public int GetQuantite()
        {
            return quantiteEnStock;
        }
        public string GetLibelle()
        {
            return libelle;
        }
        public string GetDetail()
        {
            return detail;
        }
        public string GetNomImage()
        {
            return nomImage;
        }
        public double GetPrixHT()
        {
            return prixHT;
        }
        public double GetTauxTVA()
        {
            return tauxTVA;
        }
        public bool GetDisponibilite()
        {
            return disponibilite;
        }
        public bool GetVitrine()
        {
            return vitrine;
        }
        public DateTime GetDateAJout()
        {
            return dateAjout.Date;
        }
        public override string ToString()
        {
            return noProduit.ToString() + " - " + libelle + " - " + prixHT.ToString();
        }
    }
}
