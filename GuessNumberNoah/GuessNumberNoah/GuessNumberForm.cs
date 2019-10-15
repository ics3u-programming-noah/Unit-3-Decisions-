/*
    * Created by: Noah Colbourne
    * Created on: 6-Oct-2019
    * Created for: ICS3U Programming
    * Daily Assignment – Day #16 - Guess Number
    * This program Takes the users guess and will tell
    * them if they guessued the right number.
   */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessNumberNoah
{
    public partial class frmGuessNumber : Form
    {
        public frmGuessNumber()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void frmGuessNumber_Load(object sender, EventArgs e)
        {
            this.lblAnswer.Hide();

            this.picAnswer.Hide();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            const int NUMBER = 4;
            const int MAX = 10;
            const int MIN = 1;
            int GuessNumber;

            GuessNumber = int.Parse(txtGuess.Text);

            if (GuessNumber == NUMBER)
            {   lblAnswer.Show();
                picAnswer.Show();
                lblAnswer.Text = "CORRECT!";
                picAnswer.Image = Properties.Resources.checkmark;
            }
            else if (GuessNumber > MAX)
                {
                lblAnswer.Show();
                picAnswer.Show();
                lblAnswer.Text = "Please use a smaller number!";
                picAnswer.Image = Properties.Resources.red_x; }
            else if (GuessNumber < MIN)
            {
                lblAnswer.Show();
                picAnswer.Show();
                lblAnswer.Text = "Please use a bigger number!";
                picAnswer.Image = Properties.Resources.red_x;
            }
            else
            {
                lblAnswer.Show();
                picAnswer.Show();
                lblAnswer.Text = "WRONG!";
                picAnswer.Image = Properties.Resources.red_x;
            }



        }
    }
}
