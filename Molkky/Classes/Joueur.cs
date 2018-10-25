using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Molkky.Classes
{
    class Joueur
    {
        int idJoueur;
        string nomJoueur;
        int partieGagnee;
        int partieJouee;
        int precision;
        int efficacite;
        int ratio;

        public Joueur(string nomJoueur)
        {
            this.NomJoueur = nomJoueur;
        }

        public int IdJoueur { get => idJoueur; set => idJoueur = value; }
        public string NomJoueur { get => nomJoueur; set => nomJoueur = value; }
        public int PartieGagnee { get => partieGagnee; set => partieGagnee = value; }
        public int PartieJouee { get => partieJouee; set => partieJouee = value; }
        public int Precision { get => precision; set => precision = value; }
        public int Efficacite { get => efficacite; set => efficacite = value; }
        public int Ratio { get => ratio; set => ratio = value; }
    }
}
