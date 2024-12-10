using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje_Mat.Games
{
    public partial class Flapyy : Form
    {
        public Flapyy()
        {
            InitializeComponent();
        }

        int boruHızı = 8;
        int gravity = 10;
        int score = 0;
        private void gameTimerEvent(object sender, EventArgs e)
        {
            Bird.Top += gravity;
            pipeDown.Left -= boruHızı;
            pipeUp.Left -= boruHızı;
            Bulut.Left -= boruHızı;
            Bulut2.Left -= boruHızı;
            Bulut3.Left -= boruHızı;
            lblScore.Text = "Score: " + score;

            Random rand = new Random();
            int Bulut1Random = rand.Next(900, 1000);
            int Bulut2Random = rand.Next(1100, 1300);
            int Bulut3Random = rand.Next(1400, 1600);

            /* Pipe Random */
            int PipeRandom = rand.Next(850,1000);
            if (pipeDown.Left < -100)
            {
                pipeDown.Left = PipeRandom;
            }
            if (pipeUp.Left < -100)
            {
                pipeUp.Left = PipeRandom;
                score++;
            }
            if(Bulut.Left < -500)
            {
                Bulut.Left = Bulut1Random;
            }
            if (Bulut2.Left < -500)
            {
                Bulut2.Left = Bulut2Random;
            }
            if (Bulut3.Left < -500)
            {
                Bulut3.Left = Bulut3Random;
            }

            if (Bird.Bounds.IntersectsWith(pipeDown.Bounds) || Bird.Bounds.IntersectsWith(pipeUp.Bounds) || Bird.Bounds.IntersectsWith(ground.Bounds))
            {
                endGame();
            }
            if (Bird.Top < -25)
            {
                endGame();
            }
            if (score >= 5)
            {
                boruHızı = 15;
            }
            if (score >= 10)
            {
                boruHızı = 20;
            }
        }

        private void gameKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = -10;
            }
        }

        private void gameKeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 10;
            }
        }

        private void endGame()
        {
            gameTimer.Stop();

            lblScore.Text = "Game Over!!!  Score: " + score;

            btnGeriGit.Show();
            btnGeriGit.Enabled = true;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            gameTimer.Start();

            btnStart.Hide();
            btnStart.Enabled = false;

            btnGeriGit.Hide();
            btnGeriGit.Enabled = false;
        }

        private void Flapyy_Load(object sender, EventArgs e)
        {
            gameTimer.Stop();
        }

        private void btnGeriGit_Click(object sender, EventArgs e)
        {
            this.Close();

            AnaSayfa anasayfa = new AnaSayfa();

            anasayfa.Show();
        }
    }
}
