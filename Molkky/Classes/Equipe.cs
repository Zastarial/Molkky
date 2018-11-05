using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Molkky.Classes
{
    class Equipe
    {
        
        string nom;

        public Equipe(string nom)
        {
            this.Nom = nom;
        }
        public string Nom { get => nom; set => nom = value; }
    }
}
