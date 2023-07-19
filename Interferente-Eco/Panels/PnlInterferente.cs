using Interferente_Eco.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interferente_Eco.Panels
{
    public class PnlInterferente : Panel
    {

        Form1 form;
        Utilizator utilizator;
        Image image;

        public System.Windows.Forms.PictureBox pctBackground;
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
        public System.Windows.Forms.PictureBox pctOceanul;

        private int index;

        Image imgDef;
        private int ctSticla;
        private int ctPlastic;
        private int ctHartie;

        PictureBox pctRobot;

        public Timer timer;

        public int dx, dy;

        PictureBox[] pctsDeflectoare;
        PictureBox[] pctsGunoaie;
        private int pctsDefIndex;
        private string caleDef;

        public Button btnStartJoc;
        public Button btnStop;

        private int indePctGun;

        public PnlInterferente(Form1 form1, Utilizator utilizator1, Image image1)
        {

            this.image = image1;
            this.form = form1;
            caleDef = 1.ToString();
            pctsDefIndex = 0;
            indePctGun = 0;
            pctsDeflectoare = new PictureBox[50];
            this.timer = new Timer();
            this.utilizator = utilizator1;
            pctsGunoaie = new PictureBox[50];
            this.form.WindowState = FormWindowState.Maximized;
            this.form.Size = new System.Drawing.Size(1113, 828);
            this.form.MinimumSize = new System.Drawing.Size(1113, 828);
            this.form.MaximumSize = new System.Drawing.Size(1113, 828);
            ctSticla = 0;
            pctRobot = new PictureBox();
            ctPlastic = 0;
            ctHartie = 0;
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
            this.btnStartJoc = new Button();
            this.btnStop = new Button();    

            this.Controls.Add(this.pctOceanul);
            this.Controls.Add(this.pctBackground);
            this.Controls.Add(btnStop);

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
            this.pctBackground.Controls.Add(btnStartJoc);
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
            this.chkLini.Checked = true;
            this.chkLini.CheckedChanged += new EventHandler(chkLini_CheckedChanged);

            // lblDeflector
            this.lblDeflector.AutoSize = true;
            this.lblDeflector.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 15F, System.Drawing.FontStyle.Regular);
            this.lblDeflector.ForeColor = System.Drawing.SystemColors.Control;
            this.lblDeflector.Location = new System.Drawing.Point(15, 93);
            this.lblDeflector.Name = "lblDeflector";
            this.lblDeflector.Size = new System.Drawing.Size(172, 27);
            this.lblDeflector.Text = "Adauga Deflector";
            this.lblDeflector.Click += new EventHandler(lblDeflector_Click);
            this.lblDeflector.BackColor = System.Drawing.Color.SaddleBrown;
            this.lblDeflector.Enabled = false;

            // btnRoteste
            this.btnRoteste.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnRoteste.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, System.Drawing.FontStyle.Regular);
            this.btnRoteste.ForeColor = System.Drawing.SystemColors.Control;
            this.btnRoteste.Location = new System.Drawing.Point(15, 260);
            this.btnRoteste.Name = "btnRoteste";
            this.btnRoteste.Size = new System.Drawing.Size(179, 63);
            this.btnRoteste.Text = "Roteste Deflector";
            this.btnRoteste.Click += new EventHandler(btnRoteste_Click);

            // btnCuratat
            this.btnCuratat.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnCuratat.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, System.Drawing.FontStyle.Regular);
            this.btnCuratat.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCuratat.Location = new System.Drawing.Point(15, 356);
            this.btnCuratat.Name = "btnCuratat";
            this.btnCuratat.Size = new System.Drawing.Size(179, 63);
            this.btnCuratat.Text = "Curata tot";
            this.btnCuratat.Click += new EventHandler(btnCuratat_Click);

            // lblSticla
            this.lblSticla.AutoSize = true;
            this.lblSticla.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, System.Drawing.FontStyle.Regular);
            this.lblSticla.ForeColor = System.Drawing.SystemColors.Control;
            this.lblSticla.Location = new System.Drawing.Point(15, 450);
            this.lblSticla.Name = "lblSticla";
            this.lblSticla.Size = new System.Drawing.Size(69, 27);
            this.lblSticla.Text = "Sticla: " + ctSticla.ToString();

            // lblHartie
            this.lblHartie.AutoSize = true;
            this.lblHartie.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, System.Drawing.FontStyle.Regular);
            this.lblHartie.ForeColor = System.Drawing.SystemColors.Control;
            this.lblHartie.Location = new System.Drawing.Point(15, 490);
            this.lblHartie.Name = "lblHartie";
            this.lblHartie.Size = new System.Drawing.Size(71, 27);
            this.lblHartie.Text = "Hartie: " + ctHartie.ToString();

            // lblPlastic
            this.lblPlastic.AutoSize = true;
            this.lblPlastic.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, System.Drawing.FontStyle.Regular);
            this.lblPlastic.ForeColor = System.Drawing.SystemColors.Control;
            this.lblPlastic.Location = new System.Drawing.Point(15, 530);
            this.lblPlastic.Name = "lblPlastic";
            this.lblPlastic.Size = new System.Drawing.Size(72, 27);
            this.lblPlastic.Text = "Plastic: " + ctPlastic.ToString();

            // btnStart
            this.btnStart.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnStart.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, System.Drawing.FontStyle.Regular);
            this.btnStart.ForeColor = System.Drawing.SystemColors.Control;
            this.btnStart.Location = new System.Drawing.Point(15, 570);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(179, 63);
            this.btnStart.Text = "Start";
            this.btnStart.Click += new EventHandler(btnStart_Click);

            // btnStartJoc
            this.btnStartJoc.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnStartJoc.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, System.Drawing.FontStyle.Regular);
            this.btnStartJoc.ForeColor = System.Drawing.SystemColors.Control;
            this.btnStartJoc.Location = new System.Drawing.Point(15, 570);
            this.btnStartJoc.Name = "btnStart";
            this.btnStartJoc.Size = new System.Drawing.Size(179, 63);
            this.btnStartJoc.Text = "Start Robot";
            this.btnStartJoc.Click += new EventHandler(btnStartJoc_Click);
            this.btnStartJoc.Visible = false;

            // btnStop
            this.btnStop.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnStop.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, System.Drawing.FontStyle.Regular);
            this.btnStop.ForeColor = System.Drawing.SystemColors.Control;
            this.btnStop.Location = new System.Drawing.Point(905, 570);
            this.btnStop.Name = "btnStart";
            this.btnStop.Size = new System.Drawing.Size(179, 63);
            this.btnStop.Text = "Stop";
            this.btnStop.Click += new EventHandler(btnStop_Click);
            this.btnStop.Visible = false;
            this.btnStop.BringToFront();

            // btnRestart
            this.btnRestart.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnRestart.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, System.Drawing.FontStyle.Regular);
            this.btnRestart.ForeColor = System.Drawing.SystemColors.Control;
            this.btnRestart.Location = new System.Drawing.Point(15, 645);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(179, 63);
            this.btnRestart.Text = "Restart";
            this.btnRestart.Click += new EventHandler(btnRestart_Click);

            // btnSalv
            this.btnSalv.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnSalv.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, System.Drawing.FontStyle.Regular);
            this.btnSalv.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSalv.Location = new System.Drawing.Point(15, 720);
            this.btnSalv.Name = "btnSalv";
            this.btnSalv.Size = new System.Drawing.Size(179, 63);
            this.btnSalv.Text = "Salveaza jpg";
            this.btnSalv.Click += new EventHandler(btnSalv_Click);

            // pctOceanul
            this.pctOceanul.Location = new System.Drawing.Point(0, 0);
            this.pctOceanul.Name = "pctOceanul";
            this.pctOceanul.Size = new System.Drawing.Size(841, 781);
            this.pctOceanul.Image = image;
            this.pctOceanul.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pctOceanul.BackColor = Color.Transparent;
            this.pctOceanul.Paint += pctOceanul_Paint;
            this.pctOceanul.MouseDown += pctOceanul_MouseDown;

            this.timer.Enabled = false;
            this.timer.Interval = 900;
            this.timer.Tick += new EventHandler(timer_Tick);

            string fisier = Application.StartupPath + @"\data\Harta1.txt";
            string[] linii = File.ReadAllLines(fisier);
            string[] date = linii[0].Split(' ');

            string caleImagine = date[0];
            int x = int.Parse(date[1]);
            int y = int.Parse(date[2]);

            int absoluteX = x * 60 - 60;
            int absoluteY = y * 60 - 60;

            pctRobot.Image = Image.FromFile(Application.StartupPath + @"/Produse/" + caleImagine + ".png");
            pctRobot.SizeMode = PictureBoxSizeMode.StretchImage;
            pctRobot.Name = caleImagine;
            pctRobot.Size = new Size(60, 60);
            pctRobot.Location = new Point(absoluteX, absoluteY);

            pctOceanul.Controls.Add(pctRobot);
            pctRobot.Visible = false;
        }

        private void chkLini_CheckedChanged(object sender, EventArgs e)
        {

            if (chkLini.Checked)
            {
                this.pctOceanul.Paint += pctOceanul_Paint;
            }
            else
            {
                pctOceanul.Paint -= pctOceanul_Paint;
                pctOceanul.Refresh();
            }
        }

        private void pctOceanul_Paint(object sender, PaintEventArgs e)
        {

            PictureBox pictureBox = (PictureBox)sender;
            Graphics graphics = e.Graphics;

            Pen gridPen = new Pen(Color.White, 2);

            int cellSize = 60;

            for (int x = 0; x < pictureBox.Width; x += cellSize)
            {
                graphics.DrawLine(gridPen, x, 0, x, pictureBox.Height);
            }

            for (int y = 0; y < pictureBox.Height; y += cellSize)
            {
                graphics.DrawLine(gridPen, 0, y, pictureBox.Width, y);
            }



        }

        private void btnRoteste_Click(object sender, EventArgs e)
        {

            index++;
            if (index == 5) index = 1;
            caleDef = index.ToString();
            this.pctDef.Image = Image.FromFile(Application.StartupPath + @"\Deflector\" + index.ToString() + ".png");
            this.imgDef = pctDef.Image;

        }

        private void lblDeflector_Click(object sender, EventArgs e)
        {

            this.pctBackground.Enabled = false;

        }
        
        public void pctOceanul_MouseDown(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left)
            {

                if (pctOceanul.Image != null)
                {
                    int cellSize = 60;

                    int cellX = e.X / cellSize;
                    int cellY = e.Y / cellSize;

                    Rectangle cellRect = new Rectangle(cellX * cellSize, cellY * cellSize, cellSize, cellSize);


                    PictureBox cellPictureBox = new PictureBox();
                    pctOceanul.Controls.Add(cellPictureBox);
                    cellPictureBox.Image = imgDef;
                    cellPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    cellPictureBox.Size = cellRect.Size;
                    cellPictureBox.Name = caleDef;
                    cellPictureBox.Location = cellRect.Location;
                   //  MessageBox.Show(caleDef);
                    pctsDeflectoare[pctsDefIndex] = cellPictureBox;
                    this.pctBackground.Enabled = true;
                    pctsDefIndex++;
                }
            }
        }

        private void btnStartJoc_Click(object sender, EventArgs e)
        {
            this.pctOceanul.MouseDown += pctOceanul_MouseDown;
            this.pctBackground.Enabled = false;
            this.btnRestart.Enabled = true;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            this.pctRobot.Visible = true;
            this.btnStart.Visible= false;
            this.btnStartJoc.Visible = true;
            this.btnStart.Enabled = false;
            this.lblDeflector.Enabled = true;
            string fisier = Application.StartupPath + @"\data\Harta1.txt";
            string[] linii = File.ReadAllLines(fisier);
            int ct = 0;
            for(int i=1;i<linii.Length;i++)
            {
                string[] date = linii[i].Split(' ');

                string caleImagine = date[0];
                int x = int.Parse(date[1]);
                int y = int.Parse(date[2]);

                int absoluteX = x * 60 - 60;
                int absoluteY = y * 60 - 60;

                PictureBox pictureBox = new PictureBox();
                pictureBox.Image = Image.FromFile(Application.StartupPath+@"/Produse/" + caleImagine + ".png");
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox.Name = caleImagine;
                pictureBox.Size = new Size(60, 60);
                pictureBox.Location = new Point(absoluteX, absoluteY);

                pctOceanul.Controls.Add(pictureBox);

                pctsGunoaie[ct] = pictureBox;
                indePctGun++;
                ct++;
            }

         //   this.timer.Enabled = true;

        }

        private void timer_Tick(object sender, EventArgs e)
        {
           //MessageBox.Show(pctRobot.Location.ToString());
            if ((pctRobot.Location.X < 60 || pctRobot.Location.X > 840) || (pctRobot.Location.Y > 780 || pctRobot.Location.Y < 60))
            {

                this.timer.Enabled = false;
                MessageBox.Show("Robotul a iesit din mare\nAi pierdut!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.form.removePnl("PnlInterferente");
                this.form.Controls.Add(new PnlInterferente(form, utilizator, image));

            }
            else
            {
                pctRobot.Location = new Point(pctRobot.Location.X + dx * 60, pctRobot.Location.Y + dy * 60);

                if (pctsDefIndex > 0)
                    for (int i = 0; i < pctsDefIndex; i++)
                    {

                        if (pctRobot.Location == pctsDeflectoare[i].Location)
                        {

                            if (pctsDeflectoare[i].Name == 1.ToString())
                            {

                                if (dx == -1 && dy == 0)
                                {
                                    dx = 0;
                                    dy = -1;
                                }
                                else if (dx == 0 && dy == 1)
                                {
                                    dx = 1;
                                    dy = 0;
                                }
                            }

                            if (pctsDeflectoare[i].Name == 2.ToString())
                            {

                                if (dx == 0 && dy == -1)
                                {
                                    dx = 1;
                                    dy = 0;
                                    // MessageBox.Show(pctRobot.Location.ToString() + "  " + pctsDeflectoare[i].Location.ToString());

                                }
                                else if (dx == 1 && dy == 0)
                                {
                                    dx = 0;
                                    dy = -1;
                                }
                            }

                            if (pctsDeflectoare[i].Name == 3.ToString())
                            {

                                if (dx == 1 && dy == 0)
                                {
                                    dx = 0;
                                    dy = 1;
                                    // MessageBox.Show(pctRobot.Location.ToString() + "  " + pctsDeflectoare[i].Location.ToString());

                                }
                                else if (dx == 0 && dy == 1)
                                {
                                    dx = 1;
                                    dy = 0;
                                }
                            }

                            if (pctsDeflectoare[i].Name == 4.ToString())
                            {

                                if (dx == 0 && dy == 1)
                                {
                                    dx = -1;
                                    dy = 0;
                                    // MessageBox.Show(pctRobot.Location.ToString() + "  " + pctsDeflectoare[i].Location.ToString());

                                }
                                else if (dx == -1 && dy == 0)
                                {
                                    dx = 0;
                                    dy = 1;
                                }
                            }

                        }

                    }

                if (indePctGun > 0)
                    for (int i = 0; i < indePctGun; i++)
                    {
                        if (pctRobot.Location == pctsGunoaie[i].Location)
                        {

                            if (pctsGunoaie[i].Name == "Meduza1" || pctsGunoaie[i].Name == "Meduza2" || pctsGunoaie[i].Name == "Meduza3" || pctsGunoaie[i].Name == "Meduza4")
                            {
                                this.timer.Enabled = false;
                                MessageBox.Show("Ai murit!!", "Ghinion", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                                this.form.removePnl("PnlInterferente");
                                this.form.Controls.Add(new PnlInterferente(form, utilizator, image));
                            }

                            else if (pctsGunoaie[i].Name == "Hartie")
                            {
                                pctsGunoaie[i].Visible = false;
                                ctHartie++;
                                lblHartie.Text = "Hartie: " + ctHartie.ToString();
                            }

                            else if (pctsGunoaie[i].Name == "Sticla")
                            {
                                pctsGunoaie[i].Visible = false;
                                ctSticla++;
                                lblSticla.Text = "Sticla: " + ctSticla.ToString();
                            }

                            else if (pctsGunoaie[i].Name == "Plastic")
                            {
                                pctsGunoaie[i].Visible = false;
                                ctPlastic++;
                                lblPlastic.Text = "Plastic: " + ctPlastic.ToString();
                            }

                        }
                    }
            }
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {

            this.form.removePnl("PnlInterferente");
            this.form.Controls.Add(new PnlInterferente(form, utilizator, image));

        }

        private void btnCuratat_Click(object sender, EventArgs e)
        {
            this.btnStart.Enabled = true;
            this.pctOceanul.Controls.Clear();
            this.timer.Enabled = false;

        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            this.pctOceanul.MouseDown += pctOceanul_MouseDown;
            this.btnStop.Visible = false;
            this.btnStartJoc.Visible = false;
            this.btnStart.Visible = true;
            this.btnStart.Enabled = true;
            this.pctBackground.Enabled = true;
            this.timer.Enabled = false;
        }
        private int ct = 0;
        private void btnSalv_Click(object sender, EventArgs e)
        {

            Bitmap imagine = new Bitmap(pctOceanul.Width, pctOceanul.Height, PixelFormat.Format24bppRgb);

            pctOceanul.DrawToBitmap(imagine, pctOceanul.ClientRectangle);

            imagine.Save("C:/Mycode/CSHARP/Apps/Interferente-Eco/Interferente-Eco/Poze salvate/imagine"+ct+".jpg", ImageFormat.Jpeg);

            imagine.Dispose();
            ct++;
            MessageBox.Show("Imaginea a fost salvată cu succes!");

        }

    }
}
