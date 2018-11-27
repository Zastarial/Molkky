using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Molkky.Classes
{
    class Equipe
    {
        public List<Joueur> LesJoueurs { get; set; }
        public string Libelle { get; set; }

        public Equipe(string libelle)
        {
            Libelle = libelle;
            LesJoueurs = new List<Joueur>();
        }

        public Equipe(List<Joueur> lesJoueurs, string libelle)
        {
            LesJoueurs = lesJoueurs;
            Libelle = libelle;
        }
    }

}
