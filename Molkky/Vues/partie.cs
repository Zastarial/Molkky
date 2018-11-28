using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Molkky.Vues
{
    public partial class Partie : MetroFramework.Forms.MetroForm
    {
        public Partie partie;
        public Joueur joueur;
        public List<CheckBox> quilles;
        public List<Joueur> joueurs;
        public int nbQuille;
        public int nbPoint;
        public int rotation;
        public int nbJoueurs;
        public int tour;
        //public Statistique stat;
        public Partie(Partie unePartie)
        {
            //if (Json.getStat() == null) { stat = new Statistique(); } else { stat = Json.getStat(); };

            InitializeComponent();
            partie = unePartie;
            quilles = new List<CheckBox>();
            //joueurs = partie.lesJoueurs;
            foreach (Control c in panelJeu.Controls)
            {
                if (c is CheckBox) { quilles.Add((CheckBox)c); }
            }
            partie = unePartie;
            nbQuille = 0;
            nbPoint = 0;
            rotation = 0;
            tour = 1;
            joueur = joueurs[rotation];
            nbJoueurs = joueurs.Count;
            //lblJoueur.Text = joueur.pseudoJoueur;
        }
       private void reinitQuilles()
        {
            ptb_1.BackColor = Color.White;
            ptb_2.BackColor = Color.White;
            ptb_3.BackColor = Color.White;
            ptb_4.BackColor = Color.White;
            ptb_5.BackColor = Color.White;
            ptb_6.BackColor = Color.White;
            ptb_7.BackColor = Color.White;
            ptb_8.BackColor = Color.White;
            ptb_9.BackColor = Color.White;
            ptb_10.BackColor = Color.White;
            ptb_11.BackColor = Color.White;
            ptb_12.BackColor = Color.White;

        }
        
        private void ptb_Click(object sender, EventArgs e)
        {
            PictureBox ptb = (PictureBox)sender;
            if (ptb.BackColor == Color.SaddleBrown)
            {
                ptb.BackColor = Color.White;

            }
            else
            {
                ptb.BackColor = Color.SaddleBrown;

            }
        }
        private void liveScore()
        {
        //if(nbQuillesTouchees == 1)
        //    {
        //        //valeur de la quille
        //        break;
        //    }
        //else if
        //        {

        //    }
        }
        

        private void metroButton1_Click(object sender, EventArgs e)
        {
            pgrbar_score.Value = 33;
            lbl_ptsMarque.Text = pgrbar_score.Value.ToString();
            lbl_ptsRestant.Text = (50 - Convert.ToInt16(lbl_ptsMarque.Text)).ToString();
            reinitQuilles();
        }
    }
}
