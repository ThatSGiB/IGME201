using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PE17
{
    public partial class GameForm : Form
    {
        public GameForm(int lowNumber, int highNumber)
        {
            InitializeComponent();

            Random rand = new Random();
            int nRandom = rand.Next(lowNumber, highNumber);

            timer1.Enabled = true;
            timer1.Start();

            this.outputLabel.Text = null;

            this.guessBox.KeyPress += new KeyPressEventHandler(this.NumTextBox__KeyPress);
            this.guessButton.Click += new EventHandler((sender, e) => this.GuessButton_Click(sender, e, nRandom));
            this.timer1.Tick += new EventHandler((sender, e) => this.TimerMove__Tick(sender, e, nRandom));
        }

        int nGuesses = 0;

        private void NumTextBox__KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar);
        }

        private void GuessButton_Click(object sender, EventArgs e, int nRandom)
        {
            
            
            int guessNum = Int32.Parse(this.guessBox.Text);
            if(guessNum == nRandom)
            {
                timer1.Stop();
                MessageBox.Show($"Woohoo, you got it in {nGuesses} guesses!");
                this.Close();
            }else if(guessNum < nRandom)
            {
                outputLabel.Text = "Your guess of " + guessBox.Text + " was LOW";
                nGuesses++;
            }
            else if(guessNum > nRandom)
            {
                outputLabel.Text = "Your guess of " + guessBox.Text + " was HIGH";
                nGuesses++;
            }
            
        }

        private void TimerMove__Tick(object sender, EventArgs e, int nRandom)
        {
            if (toolStripProgressBar1.Value != toolStripProgressBar1.Maximum)
            {
                toolStripProgressBar1.Value++;
            }
            else
            {
                timer1.Stop();
                MessageBox.Show("You ran out of time!  The correct answer was " + nRandom);
                this.Close();
            }
        }
    }
}
