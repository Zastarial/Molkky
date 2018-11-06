using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Molkky.Classes
{
    public class Joueur
    {
        private string pseudoJoueur;

        public Joueur(string pseudoJoueur)
        {
            this.PseudoJoueur = pseudoJoueur;
        }

        public string PseudoJoueur { get => pseudoJoueur; set => pseudoJoueur = value; }
    }
}
