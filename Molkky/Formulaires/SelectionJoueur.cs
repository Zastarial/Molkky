using Molkky.Classes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Molkky.Formulaires
{
    public partial class SelectionJoueur : Form
    {
        public SelectionJoueur()
        {
            InitializeComponent();
        }

        private void btn_nom_Click(object sender, EventArgs e)
        {
            Joueur joueur = new Joueur(tbx_nom.Text);
            DataGridViewCheckBoxColumn col = new DataGridViewCheckBoxColumn();
            dtgv_joueur.ColumnCount = 2;
            dtgv_joueur.Columns.Add(col);
            col.HeaderText = "Participation";
            dtgv_joueur.Columns[0].Name = "Nom du joueur";
            dtgv_joueur.Columns[1].Name = "KDA";
            dtgv_joueur.Rows.Add(joueur);

        }
        

        private void btn_lancementPartie_Click(object sender, EventArgs e)
        {
            EnPartie game = new EnPartie();
            game.Show();

        }
        
    }
}
