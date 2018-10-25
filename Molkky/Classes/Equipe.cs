using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Molkky.Classes
{
    class Equipe
    {
        int idEquipe;
        string nom;

        public Equipe(string nom)
        {
            this.Nom = nom;
        }

        public int IdEquipe { get => idEquipe; set => idEquipe = value; }
        public string Nom { get => nom; set => nom = value; }
    }
}
