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
        List<Classes.Joueur> joueurs;

        public SelectionJoueur(List<Classes.Joueur> lesJoueurs)
        {
            InitializeComponent();
            this.joueurs = lesJoueurs;
            DataGridViewCheckBoxColumn col = new DataGridViewCheckBoxColumn();
            dtgv_joueur.ColumnCount = 2;
            dtgv_joueur.Columns.Add(col);
            col.HeaderText = "Participation";
            dtgv_joueur.Columns[0].Name = "Nom du joueur";
            dtgv_joueur.Columns[1].Name = "KDA";

            foreach (Joueur j in joueurs)
            {
                dtgv_joueur.Rows.Add(j);
            }

        }

        private void btn_nom_Click(object sender, EventArgs e)
        {

           
            Joueur joueur = new Joueur(tbx_nom.Text);
            if (joueurs.Contains(joueur) == false){
                
                dtgv_joueur.Rows.Add(joueur);
                joueurs.Add(joueur);
            }
        }
        

        private void btn_lancementPartie_Click(object sender, EventArgs e)
        {
            List<Joueur> joueursSelec = new List<Joueur>();
            foreach (DataGridViewRow ligne in dtgv_joueur.SelectedRows)
            {
                joueursSelec.Add(new Joueur(ligne.Cells[0].Value.ToString()));
            }
         

            Formulaires.EnPartie enPartie = new EnPartie(joueursSelec);
            enPartie.Show();

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            List<Joueur> joueursSelec = new List<Joueur>();
            Joueur j = new Joueur ("");
            
           
            foreach (DataGridViewRow ligne in dtgv_joueur.SelectedRows)
            {
                j.PseudoJoueur = ligne.Cells[0].Value.ToString();
                j.newPartie();
                joueursSelec.Add(j);
            }

            Partie p = new Partie();
            p.LesJoueurs = joueursSelec;
            Program.statistique.ListePartie.Add(p);
            this.Close();
        }
    }
}
