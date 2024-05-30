using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChopesGames
{
    class Categorie
    {
        private int noCategorie;
        private string libelle;

        public Categorie(int noCategorie, string libelle)
        {
            this.noCategorie = noCategorie;
            this.libelle = libelle;
        }

        public int GetNoCategorie()
        {
            return noCategorie;
        }

        public string GetLibelle()
        {
            return libelle;
        }

        public override string ToString()
        {
            return libelle;
        }

    }
}
