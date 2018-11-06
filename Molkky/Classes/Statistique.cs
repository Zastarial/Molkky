using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Molkky.Classes
{
    public class Statistique
    {
        int idStatistique;
        int meilleurMoyenne;
        string joueurPlusPrecis;
        string meilleurJoueur;

        public Statistique(int idStatistique, int meilleurMoyenne, string joueurPlusPrecis, string meilleurJoueur)
        {
            this.IdStatistique = idStatistique;
            this.MeilleurMoyenne = meilleurMoyenne;
            this.JoueurPlusPrecis = joueurPlusPrecis;
            this.MeilleurJoueur = meilleurJoueur;
        }

        public int IdStatistique { get => idStatistique; set => idStatistique = value; }
        public int MeilleurMoyenne { get => meilleurMoyenne; set => meilleurMoyenne = value; }
        public string JoueurPlusPrecis { get => joueurPlusPrecis; set => joueurPlusPrecis = value; }
        public string MeilleurJoueur { get => meilleurJoueur; set => meilleurJoueur = value; }
    }
}
