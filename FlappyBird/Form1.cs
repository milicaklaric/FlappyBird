using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlappyBird
{
    public partial class FlappyBird : Form
    {

        int pipeSpeed = 5;
        int gravity = 5;
        int score = 0;

        Random rnd = new Random();

        public FlappyBird()
        {
            InitializeComponent();
            lblGameOver.Visible = false;
            lblFinalScore.Visible = false;
        }

        private void gameTimerEvent(object sender, EventArgs e)
        {
            pbBird.Top += gravity;
            pbTop.Left -= pipeSpeed;
            pbBottom.Left -= pipeSpeed;
            lblScore.Text = "Score: " + score;
            lblFinalScore.Text = "Final score: " + score;

            if (pbBottom.Left < -80)
            {
                pbBottom.Left = 600;
                pbBottom.Top = 290 + rnd.Next(-30, 30);
                score++;
            }
            if(pbTop.Left < -110)
            {
                pbTop.Left = 650;
                score++;
                pbTop.Top = -47 + rnd.Next(-50, 50);
                pipeSpeed++;
            }

            if(pbBird.Bounds.IntersectsWith(pbBottom.Bounds) || pbBird.Bounds.IntersectsWith(pbTop.Bounds) || pbBird.Bounds.IntersectsWith(pbGround.Bounds) ||
              pbBird.Top < -25)
            {
                endGame();
            }
        }

        private void gameKeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Space)
            {
                gravity = -5;
            }
        }

        private void gameKeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 5;
            }
        }

        private void endGame()
        {
            timer.Stop();
            lblFinalScore.Visible = true;
            lblGameOver.Visible = true;
        }
    }
}
