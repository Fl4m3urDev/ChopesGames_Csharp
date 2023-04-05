using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChopesGames
{
    class Marque
    {
        private int noMarque;
        private string nom;

        public Marque(int noMarque, string nom)
        {
            this.noMarque = noMarque;
            this.nom = nom;
        }

        public int GetNoMarque()
        {
            return noMarque;
        }
        public override string ToString()
        {
            return noMarque.ToString() + " - " + nom;
        }
    }
}
