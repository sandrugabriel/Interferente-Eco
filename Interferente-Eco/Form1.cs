using Interferente_Eco.Models;
using Interferente_Eco.Panels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interferente_Eco
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Utilizator utilizator = new Utilizator("1 Ioana eco");
            Image image = Image.FromFile(Application.StartupPath+ @"\Background\Back2.jpg");
            this.Controls.Add(new PnlInterferente(this,utilizator,image));

        }

        public void removePnl(string pnl)
        {

            Control control = null;

            foreach (Control c in this.Controls)
            {

                if (c.Name.Equals(pnl))
                {
                    control = c;
                }

            }

            this.Controls.Remove(control);
        }
    }
}
