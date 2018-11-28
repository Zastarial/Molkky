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
        private void reinitQuilles()
        {
            ptb_1.BackColor = Color.SandyBrown;
            ptb_2.BackColor = Color.SandyBrown;
            ptb_3.BackColor = Color.SandyBrown;
            ptb_4.BackColor = Color.SandyBrown;
            ptb_5.BackColor = Color.SandyBrown;
            ptb_6.BackColor = Color.SandyBrown;
            ptb_7.BackColor = Color.SandyBrown;
            ptb_8.BackColor = Color.SandyBrown;
            ptb_9.BackColor = Color.SandyBrown;
            ptb_10.BackColor = Color.SandyBrown;
            ptb_11.BackColor = Color.SandyBrown;
            ptb_12.BackColor = Color.SandyBrown;

        }

        private void ptb_click(object sender, EventArgs e)
        {
            PictureBox ptb = (PictureBox)sender;
            if (ptb.BackColor == Color.SaddleBrown)
            {
                ptb.BackColor = Color.SandyBrown;

            }
            else
            {
                ptb.BackColor = Color.SaddleBrown;
                lbl_nbPointsLancer.Text = 33.ToString();
                lbl_nbPointsTotal.Text = 33.ToString();
                lbl_nbPointsRestant.Text = (50 - Convert.ToInt16(lbl_nbPointsTotal.Text)).ToString();

            }
        }

        private void btn_scorer_Click(object sender, EventArgs e)
        {
            
            //lbl_ptsMarque.Text = pgrbar_score.Value.ToString();
            //lbl_ptsRestant.Text = (50 - Convert.ToInt16(lbl_ptsMarque.Text)).ToString();
            reinitQuilles();
            lbl_nbPointsLancer.Text = "";
            lbl_nbPointsTotal.Text = "";
            lbl_nbPointsRestant.Text = "";
        }
    }
}
