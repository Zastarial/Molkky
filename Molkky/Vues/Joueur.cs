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

            /*
                using (StreamReader file = File.OpenText(@"C:\BTS SIO\Molkky\joueur.json"))
            {
                
                JsonSerializer serializer = new JsonSerializer();
                Classes.Joueur jsonJoueur = (Classes.Joueur)serializer.Deserialize(file, typeof(Classes.Joueur));
                dtg_player.Rows.Insert(0, false, jsonJoueur);
                
            } 
            */
        }

        private void btn_addplayer_Click(object sender, EventArgs e)
        {
            Classes.Joueur joueur = new Classes.Joueur(tbx_name.Text);
            dtg_player.Rows.Insert(0, true, joueur);
            

            /*
            File.AppendAllText(@"C:\BTS SIO\Molkky\joueur.json", JsonConvert.SerializeObject(joueur, Formatting.Indented));
            using (StreamReader file = File.OpenText(@"C:\BTS SIO\Molkky\joueur.json"))
            {
                JsonSerializer serializer = new JsonSerializer();
                Classes.Joueur jsonJoueur = (Classes.Joueur)serializer.Deserialize(file, typeof(Classes.Joueur));
                dtg_player.Rows.Insert(0, true, jsonJoueur);
            }
            
    */           
        }

        private void btn_jouer_Click(object sender, EventArgs e)
        {
            
            List<Classes.Joueur> player = new List<Classes.Joueur>();

            var checkedRows = from DataGridViewRow r in dtg_player.Rows where Convert.ToBoolean(r.Cells[0].Value) == true select r;
            
            foreach(var row in checkedRows)
            {
                Classes.Joueur j = new Classes.Joueur(row.Cells[1].Value.ToString());
                player.Add(j);
            }


            File.AppendAllText(@"C:\BTS SIO\Molkky\joueur.json", JsonConvert.SerializeObject(player, Formatting.Indented));
            using (StreamReader file = File.OpenText(@"C:\BTS SIO\Molkky\joueur.json"))
            {
                JsonSerializer serializer = new JsonSerializer();
                List<Classes.Joueur> jsonJoueur = (List<Classes.Joueur>)serializer.Deserialize(file, typeof(List<Classes.Joueur>));
            }
                Partie game = new Partie();
            game.Show();
        }
    }
}
