using Interferente_Eco.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interferente_Eco.Controllers
{
    internal class ControllerUtilizatori
    {

        private List<Utilizator> utilizatori;

        public ControllerUtilizatori()
        {

            utilizatori = new List<Utilizator>();

            load();

        }

        public void load()
        {

            string path = Application.StartupPath + @"/data/Useri.txt";
            StreamReader streamReader = new StreamReader(path);

            string t;

            while((t = streamReader.ReadLine()) != null)
            {
                Utilizator utilizator = new Utilizator(t);
                utilizatori.Add(utilizator);
            }

            streamReader.Close();
        }

        public List<Utilizator> getUtilizatori()
        {
            return utilizatori;
        }

        public bool verificare(string name, string parola)
        {

            for(int i=0;i<utilizatori.Count;i++)
            {
                if (name.Equals(utilizatori[i].Name) && parola.Equals(utilizatori[i].Password)) return true;
            }

            return false;
        }

        public Utilizator getUtilizator(string name,string parola) {


            for (int i = 0; i < utilizatori.Count; i++)
            {
                if (name.Equals(utilizatori[i].Name) && parola.Equals(utilizatori[i].Password)) return utilizatori[i];
            }

            return null;

        }

    }
}
