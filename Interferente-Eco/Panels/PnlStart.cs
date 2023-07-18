using Interferente_Eco.Controllers;
using Interferente_Eco.Models;
using Interferente_Eco.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interferente_Eco.Panels
{
    internal class PnlStart:Panel
    {

        Form1 form;

        private System.Windows.Forms.ComboBox comboUtilizator;
        private System.Windows.Forms.Label lblUtilizatori;
        private System.Windows.Forms.Label lblParola;
        private System.Windows.Forms.TextBox txtParola;
        private System.Windows.Forms.PictureBox pct1;
        private System.Windows.Forms.Label lblDescriere;
        private System.Windows.Forms.PictureBox pct3;
        private System.Windows.Forms.PictureBox pct5;
        private System.Windows.Forms.PictureBox pct2;
        private System.Windows.Forms.PictureBox pct4;

        ControllerUtilizatori controllerUtilizatori;

        List<Utilizator> utilizatori;

        public PnlStart(Form1 form1) {

            this.form = form1;
            this.form.Size = new System.Drawing.Size(742, 760);
            this.form.MinimumSize = new System.Drawing.Size(742, 760);
            this.form.MaximumSize = new System.Drawing.Size(742, 760);
            this.controllerUtilizatori = new ControllerUtilizatori();
            this.utilizatori = new List<Utilizator>();

            //PnlLogare
            this.Size = new System.Drawing.Size(742, 760);
            this.Name = "PnlLogare";

            this.comboUtilizator = new System.Windows.Forms.ComboBox();
            this.lblUtilizatori = new System.Windows.Forms.Label();
            this.lblParola = new System.Windows.Forms.Label();
            this.txtParola = new System.Windows.Forms.TextBox();
            this.pct1 = new System.Windows.Forms.PictureBox();
            this.lblDescriere = new System.Windows.Forms.Label();
            this.pct3 = new System.Windows.Forms.PictureBox();
            this.pct5 = new System.Windows.Forms.PictureBox();
            this.pct2 = new System.Windows.Forms.PictureBox();
            this.pct4 = new System.Windows.Forms.PictureBox();

            this.Controls.Add(this.pct4);
            this.Controls.Add(this.pct2);
            this.Controls.Add(this.pct5);
            this.Controls.Add(this.pct3);
            this.Controls.Add(this.lblDescriere);
            this.Controls.Add(this.pct1);
            this.Controls.Add(this.txtParola);
            this.Controls.Add(this.lblParola);
            this.Controls.Add(this.lblUtilizatori);
            this.Controls.Add(this.comboUtilizator);

            // comboUtilizator
            this.comboUtilizator.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 13.8F);
            this.comboUtilizator.Location = new System.Drawing.Point(125, 87);
            this.comboUtilizator.Name = "comboUtilizator";
            this.comboUtilizator.Size = new System.Drawing.Size(412, 38);
            this.comboUtilizator.Text = "Ioana";
            utilizatori = controllerUtilizatori.getUtilizatori();

            for(int i = 0; i < utilizatori.Count; i++)
            {
                string n = utilizatori[i].Name.ToString();
                comboUtilizator.Items.Add(n);
            }

            // lblUtilizatori
            this.lblUtilizatori.AutoSize = true;
            this.lblUtilizatori.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 18F, System.Drawing.FontStyle.Regular);
            this.lblUtilizatori.Location = new System.Drawing.Point(118, 27);
            this.lblUtilizatori.Name = "lblUtilizatori";
            this.lblUtilizatori.Size = new System.Drawing.Size(146, 39);
            this.lblUtilizatori.Text = "Utilizatori";
             
            // lblParola
            this.lblParola.AutoSize = true;
            this.lblParola.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 18F, System.Drawing.FontStyle.Regular);
            this.lblParola.Location = new System.Drawing.Point(119, 148);
            this.lblParola.Name = "lblParola";
            this.lblParola.Size = new System.Drawing.Size(103, 39);
            this.lblParola.Text = "Parola";

            // txtParola
            this.txtParola.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 13.8F, System.Drawing.FontStyle.Regular);
            this.txtParola.Location = new System.Drawing.Point(126, 207);
            this.txtParola.Name = "txtParola";
            this.txtParola.Size = new System.Drawing.Size(411, 38);

            // lblDescriere
            this.lblDescriere.AutoSize = true;
            this.lblDescriere.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 11.8F);
            this.lblDescriere.Location = new System.Drawing.Point(54, 279);
            this.lblDescriere.Name = "lblDescriere";
            this.lblDescriere.Size = new System.Drawing.Size(610, 108);
            this.lblDescriere.Text = "Incarcati harta zonei maritime.\r\nRobotelul va trebui sa stranga sticlele, hartiile si plasticul din ocean.\r\nTrasati deflectoare pentru a stabili traseul robotelului. \r\nRobotelul nu trebuie sa atinga meduzele.";

            string path = Application.StartupPath + @"/Background\";
            
            // pct1
            this.pct1.Location = new System.Drawing.Point(49, 432);
            this.pct1.Name = "pct1";
            this.pct1.Size = new System.Drawing.Size(176, 134);
            this.pct1.Image = Image.FromFile(path + "Back1.jpg");

            // pct3
            this.pct3.Location = new System.Drawing.Point(437, 432);
            this.pct3.Name = "pct3";
            this.pct3.Size = new System.Drawing.Size(176, 134);
            this.pct3.Image = Image.FromFile(path + "Back3.jpg");

            // pct5
            this.pct5.Location = new System.Drawing.Point(343, 586);
            this.pct5.Name = "pct5";
            this.pct5.Size = new System.Drawing.Size(176, 134); 
            this.pct5.Image = Image.FromFile(path + "Back5.jpg");

            // pct2
            this.pct2.Location = new System.Drawing.Point(246, 432);
            this.pct2.Name = "pct2";
            this.pct2.Size = new System.Drawing.Size(176, 134);
            this.pct2.Image = Image.FromFile(path + "Back2.jpg");

            // pct4
            this.pct4.Location = new System.Drawing.Point(144, 586);
            this.pct4.Name = "pct4";
            this.pct4.Size = new System.Drawing.Size(176, 134);
            this.pct4.Image = Image.FromFile(path + "Back4.jpg");

            this.pct1.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pct2.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pct3.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pct4.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pct5.SizeMode = PictureBoxSizeMode.StretchImage;

            this.pct1.Click += new EventHandler(pcts_Click);
            this.pct2.Click += new EventHandler(pcts_Click);
            this.pct3.Click += new EventHandler(pcts_Click);
            this.pct4.Click += new EventHandler(pcts_Click);
            this.pct5.Click += new EventHandler(pcts_Click);

        }

        private void pcts_Click(object sender, EventArgs e)
        {

            if (txtParola.Text.Equals(""))
            {
                MessageBox.Show("Nu ai introdus parola!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                if (controllerUtilizatori.verificare(comboUtilizator.Text, txtParola.Text))
                {

                    PictureBox pictureBox = sender as PictureBox;


                }
                else
                {
                    MessageBox.Show("Parola este incorecta!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

          

        }





    }
}
