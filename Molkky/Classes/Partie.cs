using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Molkky.Classes
{
    class Partie
    {
        int idPartie;
        Boolean typePartie;

        public Partie(bool typePartie)
        {
            this.TypePartie = typePartie;
        }

        public int IdPartie { get => idPartie; set => idPartie = value; }
        public bool TypePartie { get => typePartie; set => typePartie = value; }
    }
}
