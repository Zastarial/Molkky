using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Molkky.Classes
{
    public class Joueur
    {       
       private string nomJoueur;
        private int partieGagnee;
        private int partieJouee;

        public Joueur(string nomJoueur)
        {
            NomJoueur = nomJoueur;
        }

        public string NomJoueur { get => nomJoueur; set => nomJoueur = value; }
        public int PartieGagnee { get => partieGagnee; set => partieGagnee = value; }
        public int PartieJouee { get => partieJouee; set => partieJouee = value; }
    }
}
