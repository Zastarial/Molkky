using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Molkky.Classes
{
    class Partie
    {
        Boolean typePartie;

        public Partie(bool typePartie)
        {
            this.TypePartie = typePartie;
        }

        
        public bool TypePartie { get => typePartie; set => typePartie = value; }
    }
}
