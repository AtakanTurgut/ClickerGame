using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClickerGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int amountGold = 0;
        int hit = 5;

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            amountGold++;
            lblAmountGold.Text = amountGold.ToString();

            if (pngBat1.Enabled == false && pngBat2.Enabled == false && pngBat3.Enabled == false &&
                pngSword1.Enabled == false && pngSword2.Enabled == false && pngSword3.Enabled == false &&
                pngAx1.Enabled == false && pngAx2.Enabled == false && pngAx3.Enabled == false &&
                pngHammer1.Enabled == false && pngHammer2.Enabled == false && pngHammer3.Enabled == false &&
                pngDagger1.Enabled == false && pngDagger2.Enabled == false && pngDagger3.Enabled == false &&
                pngBow1.Enabled == false && pngBow2.Enabled == false && pngBow3.Enabled == false &&
                pngSpear1.Enabled == false && pngSpear2.Enabled == false && pngSpear3.Enabled == false &&
                pngStaff1.Enabled == false && pngStaff21.Enabled == false && pngStaff22.Enabled == false &&
                pngShield1.Enabled == false && pngShield2.Enabled == false && pngShield3.Enabled == false)
            {
                lblStatus.Visible = true;
                pngEnemy.Enabled = false;
                timer1.Stop();
            }
        }

        private void pngBat1_MouseHover(object sender, EventArgs e)
        {
            lblPrice.Text = "50 G";
            lblPowerGold.Text = "+10";
        }

        private void pngBat2_MouseHover(object sender, EventArgs e)
        {
            lblPrice.Text = "100 G";
            lblPowerGold.Text = "+12";
        }

        private void pngBat3_MouseHover(object sender, EventArgs e)
        {
            lblPrice.Text = "150 G";
            lblPowerGold.Text = "+15";
        }

        private void pngSword1_MouseHover(object sender, EventArgs e)
        {
            lblPrice.Text = "200 G";
            lblPowerGold.Text = "+17";
        }

        private void pngSword2_MouseHover(object sender, EventArgs e)
        {
            lblPrice.Text = "400 G";
            lblPowerGold.Text = "+20";
        }

        private void pngSword3_MouseHover(object sender, EventArgs e)
        {
            lblPrice.Text = "600 G";
            lblPowerGold.Text = "+23";
        }

        private void pngAx1_MouseHover(object sender, EventArgs e)
        {
            lblPrice.Text = "250 G";
            lblPowerGold.Text = "+18";
        }

        private void pngAx2_MouseHover(object sender, EventArgs e)
        {
            lblPrice.Text = "450 G";
            lblPowerGold.Text = "+21";
        }

        private void pngAx3_MouseHover(object sender, EventArgs e)
        {
            lblPrice.Text = "650 G";
            lblPowerGold.Text = "+25";
        }

        private void pngHammer1_MouseHover(object sender, EventArgs e)
        {
            lblPrice.Text = "200 G";
            lblPowerGold.Text = "+17";
        }

        private void pngHammer2_MouseHover(object sender, EventArgs e)
        {
            lblPrice.Text = "450 G";
            lblPowerGold.Text = "+21";
        }

        private void pngHammer3_MouseHover(object sender, EventArgs e)
        {
            lblPrice.Text = "600 G";
            lblPowerGold.Text = "+23";
        }

        private void pngDagger1_MouseHover(object sender, EventArgs e)
        {
            lblPrice.Text = "100 G";
            lblPowerGold.Text = "+15";
        }

        private void pngDagger2_MouseHover(object sender, EventArgs e)
        {
            lblPrice.Text = "250 G";
            lblPowerGold.Text = "+20";
        }

        private void pngDagger3_MouseHover(object sender, EventArgs e)
        {
            lblPrice.Text = "350 G";
            lblPowerGold.Text = "+25";
        }

        private void pngBow1_MouseHover(object sender, EventArgs e)
        {
            lblPrice.Text = "400 G";
            lblPowerGold.Text = "+23";
        }

        private void pngBow2_MouseHover(object sender, EventArgs e)
        {
            lblPrice.Text = "650 G";
            lblPowerGold.Text = "+25";
        }

        private void pngBow3_MouseHover(object sender, EventArgs e)
        {
            lblPrice.Text = "950 G";
            lblPowerGold.Text = "+30";
        }

        private void pngSpear1_MouseHover(object sender, EventArgs e)
        {
            lblPrice.Text = "450 G";
            lblPowerGold.Text = "+25";
        }

        private void pngSpear2_MouseHover(object sender, EventArgs e)
        {
            lblPrice.Text = "600 G";
            lblPowerGold.Text = "+28";
        }

        private void pngSpear3_MouseHover(object sender, EventArgs e)
        {
            lblPrice.Text = "800 G";
            lblPowerGold.Text = "+31";
        }

        private void pngStaff1_MouseHover(object sender, EventArgs e)
        {
            lblPrice.Text = "850 G";
            lblPowerGold.Text = "+35";
        }

        private void pngStaff21_MouseHover(object sender, EventArgs e)
        {
            lblPrice.Text = "1150 G";
            lblPowerGold.Text = "+40";
        }

        private void pngStaff22_MouseHover(object sender, EventArgs e)
        {
            lblPrice.Text = "1150 G";
            lblPowerGold.Text = "+40";
        }

        private void pngShield1_MouseHover(object sender, EventArgs e)
        {
            lblPrice.Text = "500 G";
            lblPowerGold.Text = "++10";
        }

        private void pngShield2_MouseHover(object sender, EventArgs e)
        {
            lblPrice.Text = "750 G";
            lblPowerGold.Text = "++20";
        }

        private void pngShield3_MouseHover(object sender, EventArgs e)
        {
            lblPrice.Text = "1000 G";
            lblPowerGold.Text = "++40";
        }

        private void pngEnemy_Click(object sender, EventArgs e)
        {
            amountGold += hit;
            lblAmountGold.Text = amountGold.ToString();
        }

        private void pngBat1_Click(object sender, EventArgs e)
        {
            if (amountGold >= 50)
            {
                hit = 10;

                amountGold = amountGold - 50;
                lblAmountGold.Text = amountGold.ToString();

                pngBat1.BackColor = Color.Green;
                pngBat1.Enabled = false;
            }
        }

        private void pngBat2_Click(object sender, EventArgs e)
        {
            if (amountGold >= 100)
            {
                hit = 12;

                amountGold = amountGold - 100;
                lblAmountGold.Text = amountGold.ToString();

                pngBat2.BackColor = Color.Green;
                pngBat2.Enabled = false;
            }
        }

        private void pngBat3_Click(object sender, EventArgs e)
        {
            if (amountGold >= 150)
            {
                hit = 15;

                amountGold = amountGold - 150;
                lblAmountGold.Text = amountGold.ToString();

                pngBat3.BackColor = Color.Green;
                pngBat3.Enabled = false;
            }
        }

        private void pngSword1_Click(object sender, EventArgs e)
        {
            if (amountGold >= 200)
            {
                hit = 17;

                amountGold = amountGold - 200;
                lblAmountGold.Text = amountGold.ToString();

                pngSword1.BackColor = Color.Green;
                pngSword1.Enabled = false;
            }
        }

        private void pngSword2_Click(object sender, EventArgs e)
        {
            if (amountGold >= 400)
            {
                hit = 20;

                amountGold = amountGold - 400;
                lblAmountGold.Text = amountGold.ToString();

                pngSword2.BackColor = Color.Green;
                pngSword2.Enabled = false;
            }
        }

        private void pngSword3_Click(object sender, EventArgs e)
        {
            if (amountGold >= 600)
            {
                hit = 23;

                amountGold = amountGold - 600;
                lblAmountGold.Text = amountGold.ToString();

                pngSword3.BackColor = Color.Green;
                pngSword3.Enabled = false;
            }
        }

        private void pngAx1_Click(object sender, EventArgs e)
        {
            if (amountGold >= 250)
            {
                hit = 18;

                amountGold = amountGold - 250;
                lblAmountGold.Text = amountGold.ToString();

                pngAx1.BackColor = Color.Green;
                pngAx1.Enabled = false;
            }
        }

        private void pngAx2_Click(object sender, EventArgs e)
        {
            if (amountGold >= 450)
            {
                hit = 21;

                amountGold = amountGold - 450;
                lblAmountGold.Text = amountGold.ToString();

                pngAx2.BackColor = Color.Green;
                pngAx2.Enabled = false;
            }
        }

        private void pngAx3_Click(object sender, EventArgs e)
        {
            if (amountGold >= 650)
            {
                hit = 25;

                amountGold = amountGold - 650;
                lblAmountGold.Text = amountGold.ToString();

                pngAx3.BackColor = Color.Green;
                pngAx3.Enabled = false;
            }
        }

        private void pngHammer1_Click(object sender, EventArgs e)
        {
            if (amountGold >= 200)
            {
                hit = 17;

                amountGold = amountGold - 200;
                lblAmountGold.Text = amountGold.ToString();

                pngHammer1.BackColor = Color.Green;
                pngHammer1.Enabled = false;
            }
        }

        private void pngHammer2_Click(object sender, EventArgs e)
        {
            if (amountGold >= 450)
            {
                hit = 21;

                amountGold = amountGold - 450;
                lblAmountGold.Text = amountGold.ToString();

                pngHammer2.BackColor = Color.Green;
                pngHammer2.Enabled = false;
            }
        }

        private void pngHammer3_Click(object sender, EventArgs e)
        {
            if (amountGold >= 600)
            {
                hit = 23;

                amountGold = amountGold - 600;
                lblAmountGold.Text = amountGold.ToString();

                pngHammer3.BackColor = Color.Green;
                pngHammer3.Enabled = false;
            }
        }

        private void pngDagger1_Click(object sender, EventArgs e)
        {
            if (amountGold >= 100)
            {
                hit = 15;

                amountGold = amountGold - 100;
                lblAmountGold.Text = amountGold.ToString();

                pngDagger1.BackColor = Color.Green;
                pngDagger1.Enabled = false;
            }
        }

        private void pngDagger2_Click(object sender, EventArgs e)
        {
            if (amountGold >= 250)
            {
                hit = 20;

                amountGold = amountGold - 250;
                lblAmountGold.Text = amountGold.ToString();

                pngDagger2.BackColor = Color.Green;
                pngDagger2.Enabled = false;
            }
        }

        private void pngDagger3_Click(object sender, EventArgs e)
        {
            if (amountGold >= 350)
            {
                hit = 25;

                amountGold = amountGold - 350;
                lblAmountGold.Text = amountGold.ToString();

                pngDagger3.BackColor = Color.Green;
                pngDagger3.Enabled = false;
            }
        }

        private void pngBow1_Click(object sender, EventArgs e)
        {
            if (amountGold >= 400)
            {
                hit = 23;

                amountGold = amountGold - 400;
                lblAmountGold.Text = amountGold.ToString();

                pngBow1.BackColor = Color.Green;
                pngBow1.Enabled = false;
            }
        }

        private void pngBow2_Click(object sender, EventArgs e)
        {
            if (amountGold >= 650)
            {
                hit = 26;

                amountGold = amountGold - 650;
                lblAmountGold.Text = amountGold.ToString();

                pngBow2.BackColor = Color.Green;
                pngBow2.Enabled = false;
            }
        }

        private void pngBow3_Click(object sender, EventArgs e)
        {
            if (amountGold >= 950)
            {
                hit = 30;

                amountGold = amountGold - 950;
                lblAmountGold.Text = amountGold.ToString();

                pngBow3.BackColor = Color.Green;
                pngBow3.Enabled = false;
            }
        }

        private void pngSpear1_Click(object sender, EventArgs e)
        {
            if (amountGold >= 450)
            {
                hit = 25;

                amountGold = amountGold - 450;
                lblAmountGold.Text = amountGold.ToString();

                pngSpear1.BackColor = Color.Green;
                pngSpear1.Enabled = false;
            }
        }

        private void pngSpear2_Click(object sender, EventArgs e)
        {
            if (amountGold >= 600)
            {
                hit = 28;

                amountGold = amountGold - 600;
                lblAmountGold.Text = amountGold.ToString();

                pngSpear2.BackColor = Color.Green;
                pngSpear2.Enabled = false;
            }
        }

        private void pngSpear3_Click(object sender, EventArgs e)
        {
            if (amountGold >= 800)
            {
                hit = 31;

                amountGold = amountGold - 800;
                lblAmountGold.Text = amountGold.ToString();

                pngSpear3.BackColor = Color.Green;
                pngSpear3.Enabled = false;
            }
        }

        private void pngStaff1_Click(object sender, EventArgs e)
        {
            if (amountGold >= 850)
            {
                hit = 35;

                amountGold = amountGold - 850;
                lblAmountGold.Text = amountGold.ToString();

                pngStaff1.BackColor = Color.Green;
                pngStaff1.Enabled = false;
            }
        }

        private void pngStaff21_Click(object sender, EventArgs e)
        {
            if (amountGold >= 1150)
            {
                hit = 40;

                amountGold = amountGold - 1150;
                lblAmountGold.Text = amountGold.ToString();

                pngStaff21.BackColor = Color.Green;
                pngStaff21.Enabled = false;
            }
        }

        private void pngStaff22_Click(object sender, EventArgs e)
        {
            if (amountGold >= 1150)
            {
                hit = 40;

                amountGold = amountGold - 1150;
                lblAmountGold.Text = amountGold.ToString();

                pngStaff22.BackColor = Color.Green;
                pngStaff22.Enabled = false;
            }
        }

        private void pngShield1_Click(object sender, EventArgs e)
        {
            if (amountGold >= 500)
            {
                hit = hit + 10;

                amountGold = amountGold - 500;
                lblAmountGold.Text = amountGold.ToString();

                pngShield1.BackColor = Color.Green;
                pngShield1.Enabled = false;
            }
        }

        private void pngShield2_Click(object sender, EventArgs e)
        {
            if (amountGold >= 750)
            {
                hit = hit + 25;

                amountGold = amountGold - 750;
                lblAmountGold.Text = amountGold.ToString();

                pngShield2.BackColor = Color.Green;
                pngShield2.Enabled = false;
            }
        }

        private void pngShield3_Click(object sender, EventArgs e)
        {
            if (amountGold >= 1000)
            {
                hit = hit + 40;

                amountGold = amountGold - 1000;
                lblAmountGold.Text = amountGold.ToString();

                pngShield3.BackColor = Color.Green;
                pngShield3.Enabled = false;
            }
        }
    }
}
