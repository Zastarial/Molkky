using Molkky.Classes;
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
    public partial class AccueilMolkky : Form
    {
        public AccueilMolkky()
        {
            InitializeComponent();
        }

        private void btn_pvp_Click(object sender, EventArgs e)
        {
            SelectionJoueur pvp = new SelectionJoueur();
            pvp.Show();
        }
    }
}
