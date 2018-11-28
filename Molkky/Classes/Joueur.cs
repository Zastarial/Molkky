using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Molkky.Classes
{
    public class Joueur: IEquatable<Joueur>
    {
        private string pseudoJoueur;
        // private List<StatistiqueJoueur> statistiqueJoueurs;
        int partieJouee;
        int partieGagnee;
        int precision;
        int efficacite;
        int ratio;

        public Joueur(string pseudoJoueur)
        {
            this.PseudoJoueur = pseudoJoueur;
        }

        public string PseudoJoueur { get => pseudoJoueur; set => pseudoJoueur = value; }
        public int PartieJouee { get => partieJouee; set => partieJouee = value; }
        public int PartieGagnee { get => partieGagnee; set => partieGagnee = value; }
        public int Precision { get => precision; set => precision = value; }
        public int Efficacite { get => efficacite; set => efficacite = value; }
        public int Ratio { get => ratio; set => ratio = value; }

        public bool Equals(Joueur other)
        {
           if (this.PseudoJoueur == other.PseudoJoueur)
            {
                return true;
            }
            return false;
        }
        public override string ToString()
        {
            return this.PseudoJoueur;
        }
        // public List<StatistiqueJoueur> StatistiqueJoueurs { get => statistiqueJoueurs; set => statistiqueJoueurs = value; }
    }
}
