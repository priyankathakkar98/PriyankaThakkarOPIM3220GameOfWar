using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

#region Starting Deck
namespace WindowsFormsApp3
{
    public partial class CardDeck : Form
    {
        public CardDeck()
        {
            InitializeComponent();
            Image [] redImages;
            redImages = new Image[2];
            redImages[0] = Properties.Resources.red_back;
            redImages[1] = Properties.Resources.red_back;

            pictureBox9.Image = redImages[0];
            pictureBox10.Image = redImages[1];
        }

        #endregion

        #region Card Images

        Image [] cardImages;
        int [] card;
        int result = 0;
        int result1 = 0;
        Random rand;
        Image[] backImages;

        private void Form1_Load(object sender, EventArgs e)
        {
            cardImages = new Image[52];
            cardImages[0] = Properties.Resources._2C;
            cardImages[1] = Properties.Resources._2D;
            cardImages[2] = Properties.Resources._2H;
            cardImages[3] = Properties.Resources._2S;
            cardImages[4] = Properties.Resources._3C;
            cardImages[5] = Properties.Resources._3D;
            cardImages[6] = Properties.Resources._3H;
            cardImages[7] = Properties.Resources._3S;
            cardImages[8] = Properties.Resources._4C;
            cardImages[9] = Properties.Resources._4D;
            cardImages[10] = Properties.Resources._4H;
            cardImages[11] = Properties.Resources._4S;
            cardImages[12] = Properties.Resources._5C;
            cardImages[13] = Properties.Resources._5D;
            cardImages[14] = Properties.Resources._5H;
            cardImages[15] = Properties.Resources._5S;
            cardImages[16] = Properties.Resources._6C;
            cardImages[17] = Properties.Resources._6D;
            cardImages[18] = Properties.Resources._6H;
            cardImages[19] = Properties.Resources._6S;
            cardImages[20] = Properties.Resources._7C;
            cardImages[21] = Properties.Resources._7D;
            cardImages[22] = Properties.Resources._7H;
            cardImages[23] = Properties.Resources._7S;
            cardImages[24] = Properties.Resources._8C;
            cardImages[25] = Properties.Resources._8D;
            cardImages[26] = Properties.Resources._8H;
            cardImages[27] = Properties.Resources._8S;
            cardImages[28] = Properties.Resources._9C;
            cardImages[29] = Properties.Resources._9D;
            cardImages[30] = Properties.Resources._9H;
            cardImages[31] = Properties.Resources._9S;
            cardImages[32] = Properties.Resources._10C;
            cardImages[33] = Properties.Resources._10D;
            cardImages[34] = Properties.Resources._10H;
            cardImages[35] = Properties.Resources._10S;
            cardImages[36] = Properties.Resources.JC;
            cardImages[37] = Properties.Resources.JD;
            cardImages[38] = Properties.Resources.JH;
            cardImages[39] = Properties.Resources.JS;
            cardImages[40] = Properties.Resources.QC;
            cardImages[41] = Properties.Resources.QD;
            cardImages[42] = Properties.Resources.QH;
            cardImages[43] = Properties.Resources.QS;
            cardImages[44] = Properties.Resources.KC;
            cardImages[45] = Properties.Resources.KD;
            cardImages[46] = Properties.Resources.KH;
            cardImages[47] = Properties.Resources.KS;
            cardImages[48] = Properties.Resources.AC;
            cardImages[49] = Properties.Resources.AD;
            cardImages[50] = Properties.Resources.AH;
            cardImages[51] = Properties.Resources.AS;
            card = new int[2] { 0, 0 };

            rand = new Random();

        
        }
        #endregion

        #region Play Button
        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox9.Visible = false;
            pictureBox10.Visible = false;
            label2.Visible = true;
            label3.Visible = true;
            label7.Visible = true;
            label9.Visible = true;
            DisplayCard();
        }

        private void DisplayCard()
        {
            for (int i = 0; i < card.Length; i++)
                card[i] = rand.Next(0, 52);
 //makes a random integer from 0 to 52; takes it to random place //

            pictureBox1.Image = cardImages[card[0]];
            pictureBox2.Image = cardImages[card[1]];

            int playerVal1 = card[0];
            int playerVal2 = card[1];
            int player1 = 0;
            int player2 = 0;

            #endregion

            #region Player 1

            if (playerVal1 >= 0 && playerVal1 < 4)

            {
                player1 = 2;

            }
            else if (playerVal1 >= 4 && playerVal1 < 8)
            {
                player1 = 3;

            }
            else if (playerVal1 >= 8 && playerVal1 < 12)
            {
                player1 = 4;
            }

            else if (playerVal1 >= 12 && playerVal1 < 16)

            {
                player1 = 5;

            }
            else if (playerVal1 >= 16 && playerVal1 < 20)
            {
                player1 = 6;

            }
            else if (playerVal1 >= 20 && playerVal1 < 24)
            {
                player1 = 7;
            }
            else if (playerVal1 >= 24 && playerVal1 < 28)
            {
                player1 = 8;

            }
            else if (playerVal1 >= 28 && playerVal1 < 32)
            {
                player1 = 9;
            }

            else if (playerVal1 >= 32 && playerVal1 < 36)
            {
                player1 = 10;

            }
            else if (playerVal1 >= 36 && playerVal1 < 40)
            {
                player1 = 11;

            }
            else if (playerVal1 >= 40 && playerVal1 < 44)
            {
                player1 = 12;
            }
            else if (playerVal1 >= 44 && playerVal1 < 48)
            {
                player1 = 13;
            }
            else 
            {
                player1 = 14;
            }

            #endregion

            #region Player 2

            if (playerVal2 >= 0 && playerVal2 < 4)

            {
                player2 = 2;
            }
            else if (playerVal2 >= 4 && playerVal2 < 8)
            {
                player2 = 3; 

            }
            else if (playerVal2 >= 8 && playerVal2 < 12)
            {
                player2 = 4;
            }

            else if (playerVal2 >= 12 && playerVal2 < 16)

            {
                player1 = 5;

            }
            else if (playerVal2 >= 16 && playerVal2 < 20)
            {
                player2 = 6;

            }
            else if (playerVal2 >= 20 && playerVal2 < 24)
            {
                player2 = 7;
            }
            else if (playerVal2 >= 24 && playerVal2 < 28)
            {
                player2 = 8;

            }
            else if (playerVal2 >= 28 && playerVal2 < 32)
            {
                player2 = 9;
            }

            else if (playerVal2 >= 32 && playerVal2 < 36)
            {
                player2 = 10;

            }
            else if (playerVal2 >= 36 && playerVal2 < 40)
            {
                player2 = 11;

            }
            else if (playerVal2 >= 40 && playerVal2 < 44)
            {
                player2 = 12;
            }
            else if (playerVal2 >= 44 && playerVal2 < 48)
            {
                player2 = 13;
            }
            else
            {
                player2 = 14;
            }

            #endregion

            #region Winning Game
            if (player1 > player2)

            {
                // string str = "Player 1 Wins the Round!";
                // label4.Text = str;
                MessageBox.Show("Player 1 wins this round");


                result++;
                scoreP1.Text = Convert.ToString(result); 

            }

            else if (player2 > player1)

            {
                //string st1 = "Player 2 Wins the Round!";
                //label5.Text = st1;
                MessageBox.Show("Player 2 wins this round");

                result1++;
                scoreP2.Text = Convert.ToString(result1);
            }
            else if (player1 == player2)
            {
                MessageBox.Show("This means war");
                playbtn.Visible = false;
                warbtn.Visible = true;

            }
            else
            {
                MessageBox.Show("game over");

            }

            if (result == 5)
            {
                MessageBox.Show("Player 1 wins game!");
                DialogResult dialogResult = MessageBox.Show("Do you want to play again?", "Game of War", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    result = 0;
                    result1 = 0;
                    scoreP1.Text = Convert.ToString(result);
                    scoreP2.Text = Convert.ToString(result1);
                }
                else if (dialogResult == DialogResult.No)
                {
                    System.Windows.Forms.Application.Exit();
                }
               // MessageBox.Show("Game closing");
                

            }
            else if (result1 == 5) 
            {
                MessageBox.Show("Player 2 wins game!");
                DialogResult dialogResult = MessageBox.Show("Do you want to play again?", "Game of War", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    result = 0;
                    result1 = 0;
                    scoreP1.Text = Convert.ToString(result);
                    scoreP2.Text = Convert.ToString(result1);
                }
                else if (dialogResult == DialogResult.No)
                {
                    System.Windows.Forms.Application.Exit();
                }
                // MessageBox.Show("Game closing");
            }

        }

        #endregion

        #region Clicks
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        #endregion

        #region War Button
        private void button1_Click_2(object sender, EventArgs e)
        {
            backImages = new Image[6];
            backImages[0] = Properties.Resources.red_back;
            backImages[1] = Properties.Resources.red_back;
            backImages[2] = Properties.Resources.red_back;
            backImages[3] = Properties.Resources.red_back;
            backImages[4] = Properties.Resources.red_back;
            backImages[5] = Properties.Resources.red_back;

            pictureBox3.Image = backImages[0];
            pictureBox4.Image = backImages[1];
            pictureBox5.Image = backImages[2];
            pictureBox6.Image = backImages[3];
            pictureBox7.Image = backImages[4];
            pictureBox8.Image = backImages[5];
            winnerbtn.Visible = true;
            warbtn.Visible = false;
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_3(object sender, EventArgs e)
        {
            playbtn.Visible = true;
            winnerbtn.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            pictureBox7.Visible = false;
            pictureBox8.Visible = false;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void scoreP2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_4(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
#endregion