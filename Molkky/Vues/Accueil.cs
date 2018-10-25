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
            Joueur pvp = new Joueur();
            pvp.Show();
        }

        private void btn_team_Click(object sender, EventArgs e)
        {
            Equipe pvp = new Equipe();
            pvp.Show();
        }

        private void btn_newsSync_Click(object sender, EventArgs e)
        {
            NewsSync newsSync = new NewsSync();
            newsSync.Show();
        }
    }
}
