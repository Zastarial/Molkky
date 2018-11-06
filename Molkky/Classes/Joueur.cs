using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Molkky.Classes
{
    public class Joueur
    {

        public Joueur(string nomJoueur)
        {
            this.nomJoueur = nomJoueur;
        }

         
        public string nomJoueur { get => nomJoueur; set => nomJoueur = value; }
        public int partieGagnee { get => partieGagnee; set => partieGagnee = value; }
        public int partieJouee { get => partieJouee; set => partieJouee = value; }
        
    }
}
