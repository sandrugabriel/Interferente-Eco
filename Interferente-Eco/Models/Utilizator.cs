using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interferente_Eco.Models
{
    internal class Utilizator
    {

        private int _id;
        private string _name;
        private string _password;

        public Utilizator(int id, string name, string password)
        {
            _id = id;
            _name = name;
            _password = password;
        }

        public Utilizator(string text)
        {
            string[] prop = text.Split(' ');

            this._id = int.Parse(prop[0]);
            this._name = prop[1];
            this._password = prop[2];

        }

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }

    }
}
