using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Molkky.Classes
{
    class Lancer
    {
        int numeroLancer;
        int scoreLancer;

        public Lancer(int numeroLancer, int scoreLancer)
        {
            this.NumeroLancer = numeroLancer;
            this.ScoreLancer = scoreLancer;
        }

        public int NumeroLancer { get => numeroLancer; set => numeroLancer = value; }
        public int ScoreLancer { get => scoreLancer; set => scoreLancer = value; }
    }
}
