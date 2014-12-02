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
        }

        public void setSourceWord()
        {

        }

        public void writeToDatabox(String text)
        {
            this.dataBox.Text += text ;
        }

        private void sbmtBtn_Click(object sender, EventArgs e)
        {
            dataBox.Text = String.Empty;
            billball.parse(inputBox.Text);
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            dataBox.Text = String.Empty;
        }

        private void srcLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
