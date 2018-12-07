using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppCSEcoCycle
{
    public partial class Form1 : Form
    {
        //the basic money starter
        int argentIndiv = 800;
        int argentTeam ;

        //detect if the enemy team is from CT or T
        bool terroriste = false;
        bool counterTerroriste = false;

        //Usefull Variables for lose rounds 
        int loseCount = 0;
        int GRLoseAvailable = 1;
        bool roundLose = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnTerroriste_Click(object sender, EventArgs e)
        {
            terroriste = true;
        }

        private void btnCouterTerroriste_Click(object sender, EventArgs e)
        {
            counterTerroriste = true;
        }

        private void btnWin_Click(object sender, EventArgs e)
        {
            if(terroriste == true)
            {
                argentIndiv += 3250;
                loseCount = 0;
                GRLoseAvailable = 0;
            }
            else if(counterTerroriste == true)
            {
                argentIndiv += 3250;
                loseCount = 0;
                GRLoseAvailable = 0;
            }
            else
            {
                MessageBox.Show("Choisie un Side adverse avant :) ");
            }
        }

        private void btnCalculer_Click(object sender, EventArgs e)
        {
            //Base money for ennemy team after round finish and sum was made
            lbIndiv.Text = argentIndiv.ToString() + " $ ";
            argentTeam = argentIndiv * 5;
            lbTeam.Text = argentTeam.ToString() + " $ ";

        }

        private void btnLose_Click(object sender, EventArgs e)
        {
            if (terroriste == true)
            {
                //Only if it's gunRound, so he is available
                if (GRLoseAvailable == 1)
                {
                    if (loseCount == 0)
                        argentIndiv += 1900;
                    if (loseCount == 1)
                        argentIndiv += 2400;
                    if (loseCount == 2)
                        argentIndiv += 2900;
                    if (loseCount == 3)
                        argentIndiv += 3400;
                    loseCount++;
                }
                else
                {
                    if (loseCount == 0)
                        argentIndiv += 1400;
                    if (loseCount == 1)
                        argentIndiv += 1900;
                    if (loseCount == 2)
                        argentIndiv += 2400;
                    if (loseCount == 3)
                        argentIndiv += 2900;
                    if (loseCount >= 4)
                        argentIndiv += 3400;
                    loseCount++;
                }
                //connected to bomb plant, if the round lose is deteted by true and plant +800$
                roundLose = true;
            }
            else if (counterTerroriste == true)
            {
                //Only if it's gunRound, so he is available
                if (GRLoseAvailable == 1)
                {
                    if (loseCount == 0)
                        argentIndiv += 1900;
                    if (loseCount == 1)
                        argentIndiv += 2400;
                    if (loseCount == 2)
                        argentIndiv += 2900;
                    if (loseCount == 3)
                        argentIndiv += 3400;
                    loseCount++;
                }
                else
                {
                    if (loseCount == 0)
                        argentIndiv += 1400;
                    if (loseCount == 1)
                        argentIndiv += 1900;
                    if (loseCount == 2)
                        argentIndiv += 2400;
                    if (loseCount == 3)
                        argentIndiv += 2900;
                    if (loseCount >= 4)
                        argentIndiv += 3400;
                    loseCount++;
                }
                //connected to bomb plant, if the round lose is deteted by true and plant +800$
                roundLose = true;
            }
            else
            {
                MessageBox.Show("Choisie un Side adverse avant :) ");
            }
        }

        private void btnEco_Click(object sender, EventArgs e)
        {
            if (terroriste == true)
            {
                argentIndiv -= 700;
            }
            else if (counterTerroriste == true)
            {
                argentIndiv -= 700;
            }
            else
            {
                MessageBox.Show("Choisie un Side adverse avant :) ");
            }
        }

        private void btnArme_Click(object sender, EventArgs e)
        {
            if (terroriste == true)
            {
                argentIndiv -= 3700;
            }
            else if (counterTerroriste == true)
            {
                argentIndiv -= 4100;
            }
            else
            {
                MessageBox.Show("Choisie un Side adverse avant :) ");
            }
        }

        private void btnForce_Click(object sender, EventArgs e)
        {
            if (terroriste == true)
            {
                argentIndiv -= 2300;
            }
            else if (counterTerroriste == true)
            {
                argentIndiv -= 2300;
            }
            else
            {
                MessageBox.Show("Choisie un Side adverse avant :) ");
            }
        }

        private void btnPlant_Click(object sender, EventArgs e)
        {
            if (terroriste == true)
            {
                if(roundLose == true)
                {
                    argentIndiv += 800;
                    roundLose = false;
                }
                else
                {
                    //Approximativ average
                    argentIndiv += 250;
                }
            }
            else if (counterTerroriste == true)
            {
                MessageBox.Show("Les CT ne plante pas de bombe :/ (change de side)");
            }
            else
            {
                MessageBox.Show("Choisie un Side adverse avant :) ");
            }
        }

        private void btnDefuse_Click(object sender, EventArgs e)
        {
            if (terroriste == true)
            {
                MessageBox.Show("Les terroristes ne defuse pas de bombe (change de side)");
            }
            else if (counterTerroriste == true)
            {
                if(roundLose == true)
                {
                    MessageBox.Show("Les CT ne peuvent pas perdre le round en désamorçant");
                }
                else
                {
                    argentIndiv += 250;
                }
            }
            else
            {
                MessageBox.Show("Choisie un Side adverse avant :) ");
            }
        }

        private void btnRecommencer_Click(object sender, EventArgs e)
        {
            /*  --- We set all Variables to default --- */
            /* --- for a clean restart or change side --- */

            argentIndiv = 800;

            //detect if the enemy team is from CT or T
            terroriste = false;
            counterTerroriste = false;

            //Usefull Variables for lose rounds 
            loseCount = 0;
            GRLoseAvailable = 1;
            roundLose = false;

            lbIndiv.Text = argentIndiv.ToString() + " $ ";
            argentTeam = argentIndiv * 5;
            lbTeam.Text = argentTeam.ToString() + " $ ";
        }
    }
}
