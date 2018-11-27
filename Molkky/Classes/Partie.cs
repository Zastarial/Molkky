using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Molkky.Classes
{
    class Partie
    {
        private int numPartie;
        private DateTime dateDebutPartie;
        private DateTime dateFinPartie;

        public Partie(int numPartie, DateTime dateDebutPartie, DateTime dateFinPartie, List<Joueur> lesJoueurs)
        {
            this.NumPartie = numPartie;
            this.DateDebutPartie = dateDebutPartie;
            this.DateFinPartie = dateFinPartie;
            this.lesJoueurs = lesJoueurs;
        }
        

        public int NumPartie { get => numPartie; set => numPartie = value; }
        public DateTime DateDebutPartie { get => dateDebutPartie; set => dateDebutPartie = value; }
        public DateTime DateFinPartie { get => dateFinPartie; set => dateFinPartie = value; }
        public List<Joueur> lesJoueurs { get; set; }
    }
}
