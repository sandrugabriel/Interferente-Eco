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
        public PnlInterferente pnlInterferente;
        int dx1, dy1;
        public Form1()
        {
            InitializeComponent();
            Utilizator utilizator3 = new Utilizator("1 Ioana eco");
            Image image4 = Image.FromFile(Application.StartupPath+ @"\Background\Back2.jpg");
            pnlInterferente = new PnlInterferente(this, utilizator3, image4);
            this.Controls.Add(pnlInterferente);

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

        private void Form1_Load(object sender, EventArgs e)
        {
            
                this.KeyPreview = true;
                pnlInterferente.Focus();

            dx1 = pnlInterferente.dx;
            dy1 = pnlInterferente.dy;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

            switch (e.KeyCode)
            {
                case Keys.Left:
                    //MessageBox.Show("sdf");
                    pnlInterferente.dx = -1;
                    pnlInterferente.dy = 0;
                    break;
                case Keys.Right:
                    pnlInterferente.dx = 1;
                    pnlInterferente.dy = 0;
                    break;
                case Keys.Up:
                    pnlInterferente.dx = 0;
                    pnlInterferente.dy = -1;
                    break;
                case Keys.Down:
                    pnlInterferente.dx = 0;
                    pnlInterferente.dy = 1;
                    break;
            }

          // pnlInterferente.pctOceanul.MouseDown -= pnlInterferente.pctOceanul_MouseDown;
            pnlInterferente.timer.Enabled = true;
            pnlInterferente.pctBackground.Enabled = false;
            pnlInterferente.btnStop.Visible = true;
        }
    }
}
