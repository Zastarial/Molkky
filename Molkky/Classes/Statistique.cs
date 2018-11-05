using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Molkky.Classes
{
    public class Statistique : Joueur
    {

        public Statistique(int precision, int efficacite, int ratio, string nomJoueur) : base(nomJoueur)
        {
            this.precision = precision;
            this.efficacite = efficacite;
            this.ratio = ratio;
            
        }

        public int precision { get => precision; set => precision = value; }
        public int efficacite { get => efficacite; set => efficacite = value; }
        public int ratio { get => ratio; set => ratio = value; }
    }
}
