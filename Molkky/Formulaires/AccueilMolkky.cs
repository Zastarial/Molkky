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
       
        List<Classes.Joueur> joueurs = new List<Classes.Joueur>();

        public AccueilMolkky()
        {
            InitializeComponent();
            Program.statistique = Classes.AdoJson.deserialiser();
            foreach (Classes.Partie p in Program.statistique.ListePartie)
            {
                foreach (Classes.Joueur j in p.LesJoueurs)
                {
                    if (joueurs.Contains(j) == false)
                    { joueurs.Add(j); }
                }
            }
        }

        private void btn_pvp_Click(object sender, EventArgs e)
        {
            SelectionJoueur pvp = new SelectionJoueur(joueurs);
            pvp.Show();
        }

        private void btn_News_Click(object sender, EventArgs e)
        {
            //Molkky.Classes.Joueur j = new Molkky.Classes.Joueur("SebPern");
            //Molkky.Classes.Joueur jj = new Molkky.Classes.Joueur("Lilian");
            ////Molkky.Classes.StatistiqueJoueur statistiqueJoueur = new Classes.StatistiqueJoueur();
            ////statistiqueJoueur.Joueur = j;
            ////Molkky.Classes.StatistiqueJoueur statistiqueJoueur2 = new Classes.StatistiqueJoueur();
            ////statistiqueJoueur2.Joueur = jj;
            //Molkky.Classes.Partie p = new Molkky.Classes.Partie();
            //p.LesJoueurs.Add(j);
            //p.LesJoueurs.Add(jj);
            //Molkky.Classes.Partie pp = new Molkky.Classes.Partie();
            //pp.LesJoueurs.Add(j);
            //pp.LesJoueurs.Add(jj);
            //Program.statistique.ListePartie.Add(p);
            //Program.statistique.ListePartie.Add(pp);
            //statistique.ListeStatJoueur.Add(statistiqueJoueur);
            //statistique.ListeStatJoueur.Add(statistiqueJoueur2);
            Molkky.Classes.AdoJson.serialiser(Program.statistique);
        }
    }
}
