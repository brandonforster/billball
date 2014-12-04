using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BillBall
{
    public partial class Form1 : Form
    {
        private billball billball;

        public Form1(billball billball)
        {
            InitializeComponent();
            this.billball = billball;

            // initialize the source word
            setSourceWord();

            Console.WriteLine("The word is: " + billball.getSourceWord());
        }

        public void setSourceWord()
        {
            this.billball.setSourceWord();
            this.srcWordLabel.Text = billball.getSourceWord();
            this.srcValLabel.Text = "" + billball.getSourceWordScore();
        }

        private void sbmtBtn_Click(object sender, EventArgs e)
        {
            this.searchValLabel.Text = String.Empty;

            // show the user's play in the GUI
            this.searchValLabel.Text= "" + billball.getWordScore(inputBox.Text);

            // run the game loop and pass it the played word's score
            billball.gameLoop(billball.getWordScore(inputBox.Text));
        }

        public void scoreUpdate(int frameCount, int totalScore)
        {
            this.scoreValLabel.Text = "" + totalScore;
            this.frameValLabel.Text = "" + frameCount;
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            this.billball.startGame();
        }

        private void srcLabel_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void loadGamePict()
        {
            pictureBox1.Image = BillBall.Properties.Resources.gamePict;
        }

        public void loadNewPict(int arg)
        {
            int caseSwitch = arg;
            switch(caseSwitch)
            {
                case 1://gutterball
                    pictureBox1.Image = BillBall.Properties.Resources.gutterball;
                    break;
                case 2://strike
                    pictureBox1.Image = BillBall.Properties.Resources.strike;
                    break;
                case 3://hit
                    pictureBox1.Image = BillBall.Properties.Resources.hit;
                    break;
                case 4://miss
                    pictureBox1.Image = BillBall.Properties.Resources.miss;
                    break;
                case 5://spare
                    pictureBox1.Image = BillBall.Properties.Resources.spare;
                    break;
                case 6://specSpare
                    pictureBox1.Image = BillBall.Properties.Resources.specSpare;
                    break;
                case 7://specHit
                    pictureBox1.Image = BillBall.Properties.Resources.specHit;
                    break;
                default://gamePict
                    pictureBox1.Image = BillBall.Properties.Resources.gamePict;
                    break;
            }
        }
    }
}