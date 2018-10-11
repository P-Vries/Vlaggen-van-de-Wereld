using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VlaggenVanDeWereld
{
    public partial class Form1 : Form
    {
        //
        //VARS
        //
        List<Land> Landen = new List<Land>();
        List<string> landNamen = new List<string>();
        List<string> landVlaggen = new List<string>();
        int landPos = 0;
        Random rnd = new Random();
        int antwoordCijfer;
        int foutTeller = 0;
        int goedStreek = 1;


        public Form1()
        {
            InitializeComponent();
            pbVlag.SizeMode = PictureBoxSizeMode.Zoom;
        }


        //
        //METHODES
        //
        private void SlaLandOp(string landNaam, string vlagURL)
        {
            landNamen.Add(txbLandNaam.Text);
            landVlaggen.Add(txbVlagURL.Text);
            Land newLand = new Land(landNaam, vlagURL);
            using (TextWriter tw = new StreamWriter(@"LandenFile.txt", true))
            {
              tw.WriteLine(newLand.ToLand());
                tw.Close();
            }
        }

        private void laden2()
        {
            landVlaggen.Clear();
            landNamen.Clear();
            string[] lines = System.IO.File.ReadAllLines(@"LandenFile.txt");
            foreach (string line in lines)
            {
                string[] details = line.Split(',');
                landNamen.Add(details[0]);
                landVlaggen.Add(details[1]);
            }
        }

        private void LaatLandZien(int landPositie)
        {
            if (landPositie >= landVlaggen.ToArray().Length || landPositie >= landNamen.ToArray().Length)
            {
                MessageBox.Show("Er zijn geen ander landen opgeslagen.");
                landPos = -1;
            }
            else
            {
                pbVlag.Load(landVlaggen[landPositie]);
                lblOut.Text = landNamen[landPositie];
            }
        }

        private void randomizeLand()
        {
            int rand = rnd.Next(0, landVlaggen.ToArray().Length);
            pbVlag.Load(landVlaggen[rand]);
            antwoordCijfer = rand;

        }
        
        private void checkAntwoord()
        {
            if (txbAntwoord.Text == landNamen[antwoordCijfer])
            {
                if (goedStreek == 1)
                {
                    MessageBox.Show("Correct!");
                    randomizeLand();
                    goedStreek++;
                }
                else
                {
                    MessageBox.Show("Correct! Voor de " + goedStreek.ToString() + "e op een rij!");
                    randomizeLand();
                    goedStreek++;
                    if(goedStreek >= 10)
                    {
                        MessageBox.Show("Gefeliciteerd! je hebt tien goede antoorden gegeven op een rij! dit heb je nu wel onder de knie.");
                        btnVolgende.Enabled = true;
                    }
                }
            }
            else
            {
                goedStreek = 1;
                foutTeller++;
                MessageBox.Show("Fout! Voor de " + foutTeller.ToString() + "e keer");
            }
            txbAntwoord.Text = "";
        }


        //
        //EVENTS
        //
        private void btnSlaOp_Click(object sender, EventArgs e)
        {
            SlaLandOp(txbLandNaam.Text, txbVlagURL.Text);
            txbLandNaam.Text = "";
            txbVlagURL.Text = "";
        }

        private void btnVolgende_Click(object sender, EventArgs e)
        {
            LaatLandZien(landPos);
            landPos++;
        }

        private void btnLaad_Click(object sender, EventArgs e)
        {
            laden2();
        }

        private void btnStartQuiz_Click(object sender, EventArgs e)
        {
            pnlQuiz.Visible = true;
            lblOut.Text = "";
            btnVolgende.Enabled = false;
            randomizeLand();
        }

        private void btnCheckAns_Click(object sender, EventArgs e)
        {
            checkAntwoord();
        }
    }
}
