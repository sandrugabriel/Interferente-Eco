using Interferente_Eco.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interferente_Eco.Panels
{
    internal class PnlInterferente:Panel
    {

        Form1 form;
        Utilizator utilizator;
        Image image;

        private System.Windows.Forms.PictureBox pctBackground;
        private System.Windows.Forms.PictureBox pctDef;
        private System.Windows.Forms.CheckBox chkLini;
        private System.Windows.Forms.Label lblDeflector;
        private System.Windows.Forms.Button btnRoteste;
        private System.Windows.Forms.Button btnCuratat;
        private System.Windows.Forms.Label lblSticla;
        private System.Windows.Forms.Label lblHartie;
        private System.Windows.Forms.Label lblPlastic;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.Button btnSalv;
        private System.Windows.Forms.PictureBox pctOceanul;

        private int index;

        Image imgDef;

        public PnlInterferente(Form1 form1, Utilizator utilizator1, Image image1)
        {

            this.image = image1;
            this.form = form1;
            this.utilizator = utilizator1;
            this.form.WindowState = FormWindowState.Maximized;
            this.form.Size = new System.Drawing.Size(1113, 828);
            this.form.MinimumSize = new System.Drawing.Size(1113, 828);
            this.form.MaximumSize = new System.Drawing.Size(1113, 828);
            index = 1;
            //PnlInterferente
            this.Size = new System.Drawing.Size(1113, 828);
            this.Name = "PnlInterferente";

            this.pctBackground = new System.Windows.Forms.PictureBox();
            this.pctDef = new System.Windows.Forms.PictureBox();
            this.chkLini = new System.Windows.Forms.CheckBox();
            this.lblDeflector = new System.Windows.Forms.Label();
            this.btnRoteste = new System.Windows.Forms.Button();
            this.btnCuratat = new System.Windows.Forms.Button();
            this.lblSticla = new System.Windows.Forms.Label();
            this.lblHartie = new System.Windows.Forms.Label();
            this.lblPlastic = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnRestart = new System.Windows.Forms.Button();
            this.btnSalv = new System.Windows.Forms.Button();
            this.pctOceanul = new System.Windows.Forms.PictureBox();

            this.Controls.Add(this.pctOceanul);
            this.Controls.Add(this.pctBackground);

            // pctBackground
            this.pctBackground.Controls.Add(this.btnSalv);
            this.pctBackground.Controls.Add(this.btnRestart);
            this.pctBackground.Controls.Add(this.btnStart);
            this.pctBackground.Controls.Add(this.lblPlastic);
            this.pctBackground.Controls.Add(this.lblHartie);
            this.pctBackground.Controls.Add(this.lblSticla);
            this.pctBackground.Controls.Add(this.btnCuratat);
            this.pctBackground.Controls.Add(this.btnRoteste);
            this.pctBackground.Controls.Add(this.pctDef);
            this.pctBackground.Controls.Add(this.lblDeflector);
            this.pctBackground.Controls.Add(this.chkLini);
            this.pctBackground.Location = new System.Drawing.Point(890, 0);
            this.pctBackground.Name = "pctBackground";
            this.pctBackground.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pctBackground.Image = Image.FromFile(Application.StartupPath + @"\Wood\Wood1.jpg");
            this.pctBackground.Size = new System.Drawing.Size(260, 837);
            this.pctBackground.BackColor = Color.Transparent;

            // pctDef
            this.pctDef.Location = new System.Drawing.Point(50, 123);
            this.pctDef.Name = "pctDef";
            this.pctDef.Size = new System.Drawing.Size(110, 110);
            this.pctDef.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pctDef.Image = Image.FromFile(Application.StartupPath + @"\Deflector\1.png");
            this.imgDef = pctDef.Image;

            // chkLini
            this.chkLini.AutoSize = true;
            this.chkLini.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, System.Drawing.FontStyle.Regular);
            this.chkLini.ForeColor = System.Drawing.SystemColors.Control;
            this.chkLini.Location = new System.Drawing.Point(15, 35);
            this.chkLini.Name = "chkLini";
            this.chkLini.Size = new System.Drawing.Size(209, 31);
            this.chkLini.Text = "Afiseaza lini de grid";

            // lblDeflector
            this.lblDeflector.AutoSize = true;
            this.lblDeflector.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, System.Drawing.FontStyle.Regular);
            this.lblDeflector.ForeColor = System.Drawing.SystemColors.Control;
            this.lblDeflector.Location = new System.Drawing.Point(35, 93);
            this.lblDeflector.Name = "lblDeflector";
            this.lblDeflector.Size = new System.Drawing.Size(172, 27);
            this.lblDeflector.Text = "Adauga Deflector";
             
            // btnRoteste
            this.btnRoteste.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnRoteste.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, System.Drawing.FontStyle.Regular);
            this.btnRoteste.ForeColor = System.Drawing.SystemColors.Control;
            this.btnRoteste.Location = new System.Drawing.Point(15, 260);
            this.btnRoteste.Name = "btnRoteste";
            this.btnRoteste.Size = new System.Drawing.Size(179, 63);
            this.btnRoteste.Text = "Roteste Deflector";

            // btnCuratat
            this.btnCuratat.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnCuratat.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, System.Drawing.FontStyle.Regular);
            this.btnCuratat.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCuratat.Location = new System.Drawing.Point(15, 356);
            this.btnCuratat.Name = "btnCuratat";
            this.btnCuratat.Size = new System.Drawing.Size(179, 63);
            this.btnCuratat.Text = "Curata tot";
             
            // lblSticla
            this.lblSticla.AutoSize = true;
            this.lblSticla.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, System.Drawing.FontStyle.Regular);
            this.lblSticla.ForeColor = System.Drawing.SystemColors.Control;
            this.lblSticla.Location = new System.Drawing.Point(15, 450);
            this.lblSticla.Name = "lblSticla";
            this.lblSticla.Size = new System.Drawing.Size(69, 27);
            this.lblSticla.Text = "Sticla: ";

            // lblHartie
            this.lblHartie.AutoSize = true;
            this.lblHartie.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, System.Drawing.FontStyle.Regular);
            this.lblHartie.ForeColor = System.Drawing.SystemColors.Control;
            this.lblHartie.Location = new System.Drawing.Point(15, 490);
            this.lblHartie.Name = "lblHartie";
            this.lblHartie.Size = new System.Drawing.Size(71, 27);
            this.lblHartie.Text = "Hartie:";
             
            // lblPlastic
            this.lblPlastic.AutoSize = true;
            this.lblPlastic.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, System.Drawing.FontStyle.Regular);
            this.lblPlastic.ForeColor = System.Drawing.SystemColors.Control;
            this.lblPlastic.Location = new System.Drawing.Point(15, 530);
            this.lblPlastic.Name = "lblPlastic";
            this.lblPlastic.Size = new System.Drawing.Size(72, 27);
            this.lblPlastic.Text = "Plastic:";

            // btnStart
            this.btnStart.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnStart.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, System.Drawing.FontStyle.Regular);
            this.btnStart.ForeColor = System.Drawing.SystemColors.Control;
            this.btnStart.Location = new System.Drawing.Point(15, 570);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(179, 63);
            this.btnStart.Text = "Start";

            // btnRestart
            this.btnRestart.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnRestart.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, System.Drawing.FontStyle.Regular);
            this.btnRestart.ForeColor = System.Drawing.SystemColors.Control;
            this.btnRestart.Location = new System.Drawing.Point(15, 645);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(179, 63);
            this.btnRestart.Text = "Restart";
             
            // btnSalv
            this.btnSalv.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnSalv.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, System.Drawing.FontStyle.Regular);
            this.btnSalv.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSalv.Location = new System.Drawing.Point(15, 720);
            this.btnSalv.Name = "btnSalv";
            this.btnSalv.Size = new System.Drawing.Size(179, 63);
            this.btnSalv.Text = "Salveaza jpg";
             
            // pctOceanul
            this.pctOceanul.Location = new System.Drawing.Point(0, 0);
            this.pctOceanul.Name = "pctOceanul";
            this.pctOceanul.Size = new System.Drawing.Size(841, 781);
            this.pctOceanul.Image = image;
            this.pctOceanul.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pctOceanul.BackColor = Color.Transparent;
        }


    }
}
