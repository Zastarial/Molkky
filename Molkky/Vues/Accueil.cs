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
        Molkky.Classes.Statistique statistique = new Molkky.Classes.Statistique();
        List<Classes.Joueur> joueurs = new List<Classes.Joueur>();
        public Accueil()
        {
            InitializeComponent();
            statistique = Classes.AdoJson.deserialiser();
            foreach (Classes.Partie p in statistique.ListePartie)
            {
                foreach(Classes.Joueur j in p.LesJoueurs)
                {
                    if (joueurs.Contains(j) == false)
                    { joueurs.Add(j); }
                }
            }
        }

        private void btn_solo_Click(object sender, EventArgs e)
        {
            Joueur pvp = new Joueur(joueurs);
            pvp.Show();
        }

        private void btn_team_Click(object sender, EventArgs e)
        {
            //Equipe pvp = new Equipe();
            //pvp.Show();
        }

        private void btn_newsSync_Click(object sender, EventArgs e)
        {
            //NewsSync newsSync = new NewsSync();
            //newsSync.Show();*
            Molkky.Classes.Joueur j = new Molkky.Classes.Joueur("SebPern");
            Molkky.Classes.Joueur jj = new Molkky.Classes.Joueur("Lilian");
            //Molkky.Classes.StatistiqueJoueur statistiqueJoueur = new Classes.StatistiqueJoueur();
            //statistiqueJoueur.Joueur = j;
            //Molkky.Classes.StatistiqueJoueur statistiqueJoueur2 = new Classes.StatistiqueJoueur();
            //statistiqueJoueur2.Joueur = jj;

            Molkky.Classes.Partie p = new Molkky.Classes.Partie();
            p.LesJoueurs.Add(j);
            p.LesJoueurs.Add(jj);
            Molkky.Classes.Partie pp = new Molkky.Classes.Partie();
            pp.LesJoueurs.Add(j);
            pp.LesJoueurs.Add(jj);
            statistique.ListePartie.Add(p);
            statistique.ListePartie.Add(pp);

            //statistique.ListeStatJoueur.Add(statistiqueJoueur);
            //statistique.ListeStatJoueur.Add(statistiqueJoueur2);

            Molkky.Classes.AdoJson.serialiser(statistique);

        }
    }
}
