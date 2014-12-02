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

            Console.WriteLine("The word is: " + billball.getSourceWord());

            // initialize the source word
            this.srcWordLabel.Text= billball.getSourceWord();
            this.srcValLabel.Text = "" + billball.getSourceWordScore();
        }

        public void writeToDatabox(String text)
        {
            this.dataBox.Text += text ;
        }

        private void sbmtBtn_Click(object sender, EventArgs e)
        {
            this.searchValLabel.Text = String.Empty;
            dataBox.Text = String.Empty;

            // show the user's play in the GUI
            this.searchValLabel.Text= "" + billball.getWordScore(inputBox.Text);

            // run the game loop and pass it the played word's score
            gameLoop(billball.getWordScore(inputBox.Text));
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            dataBox.Text = String.Empty;
        }

        private void srcLabel_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
