using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Molkky.Classes
{
    class AdoJson
    {
        public static Statistique deserialiser()
        {
            Statistique stat = new Statistique();
            using (StreamReader file = File.OpenText(@"C:\BTS SIO\Molkky\joueur.json"))
            {
                JsonSerializer serializer = new JsonSerializer();
                 stat  = (Classes.Statistique)serializer.Deserialize(file, typeof(Classes.Statistique));
            }
            return stat;
        }

        public static void serialiser(Statistique statistique)
        {
            File.WriteAllText(@"C:\BTS SIO\Molkky\joueur.json", JsonConvert.SerializeObject(statistique, Formatting.Indented));
        }
    }
}
