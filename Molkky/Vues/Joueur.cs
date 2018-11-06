using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;

namespace Molkky.Vues
{
    public partial class Joueur : MetroFramework.Forms.MetroForm
    {
        public Joueur()
        {
            InitializeComponent();
            
        }

        private void btn_jouer_Click(object sender, EventArgs e)
        {
            Partie game = new Partie();
            game.Show();
        }

        private void btn_addplayer_Click(object sender, EventArgs e)
        {
            Classes.Joueur joueur = new Classes.Joueur(tbx_name.Text);

            string jsonSerializedObj = JsonConvert.SerializeObject(joueur);
            File.WriteAllText(@"C:\BTS SIO\Molkky\joueur.json", jsonSerializedObj);

        }
    }
}
