using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Molkky.Vues;

namespace Molkky
{
    public partial class Accueil : MetroFramework.Forms.MetroForm
    {
        public Accueil()
        {
            InitializeComponent();
        }

        private void btn_solo_Click(object sender, EventArgs e)
        {
            joueurs pvp = new joueurs();
            pvp.Show();
        }

        private void btn_team_Click(object sender, EventArgs e)
        {
            Equipes pvp = new Equipes();
            pvp.Show();
        }
    }
}
