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
    public partial class joueurs : MetroFramework.Forms.MetroForm
    {
        public joueurs()
        {
            InitializeComponent();
            //test git
        }

        private void btn_jouer_Click(object sender, EventArgs e)
        {
            partie game = new partie();
            game.Show();
        }

        private void btn_statistique_Click(object sender, EventArgs e)
        {
            
        }
    }
}
