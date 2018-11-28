using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Molkky.Formulaires
{
    public partial class EnPartie : Form
    {
        List<Classes.Joueur> joueurs;

        public EnPartie(List<Classes.Joueur> lesJoueurs)
        {
            InitializeComponent();
            this.joueurs = lesJoueurs;
        }
    }
}
