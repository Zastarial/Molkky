using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Molkky.Classes
{
    public class StatistiqueJoueur
    {
        int partieJouee;
        int partieGagnee;
        int precision;
        int efficacite;
        int ratio;
        Joueur joueur;

        public StatistiqueJoueur()
        {
        }

        public StatistiqueJoueur(int partieJouee, int partieGagnee, int precision, int efficacite, int ratio)
        {
            this.PartieJouee = partieJouee;
            this.PartieGagnee = partieGagnee;
            this.Precision = precision;
            this.Efficacite = efficacite;
            this.Ratio = ratio;
        }

        public int PartieJouee { get => partieJouee; set => partieJouee = value; }
        public int PartieGagnee { get => partieGagnee; set => partieGagnee = value; }
        public int Precision { get => precision; set => precision = value; }
        public int Efficacite { get => efficacite; set => efficacite = value; }
        public int Ratio { get => ratio; set => ratio = value; }
        public Joueur Joueur { get => joueur; set => joueur = value; }
    }
}
