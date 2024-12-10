using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje_Mat.Games
{
    public partial class TaşKagıtMakas : Form
    {
        public TaşKagıtMakas()
        {
            InitializeComponent();
        }

        int PlayerTercih = 0;
        int PlayerScore = 0;
        int ComputerScore = 0;
        private void btnTas_Click(object sender, EventArgs e)
        {
            pictGameover.Image = null; // gameover ekranı geldiginde ve oyuna tekrar başlandıgında game overı silmek için
            pictPlayer.Image = imageList1.Images[0];
            PlayerTercih = 0;
            RandomComputerPlay();
            ScoreUpdate();
            GameOver();
        }

        private void btnKagıt_Click(object sender, EventArgs e)
        {
            pictGameover.Image = null; // gameover ekranı geldiginde ve oyuna tekrar başlandıgında game overı silmek için
            pictPlayer.Image = imageList1.Images[1];
            PlayerTercih = 1;
            RandomComputerPlay();
            ScoreUpdate();
            GameOver();
        }

        private void btnMakas_Click(object sender, EventArgs e)
        {
            pictGameover.Image = null; // gameover ekranı geldiginde ve oyuna tekrar başlandıgında game overı silmek için
            pictPlayer.Image = imageList1.Images[2];
            PlayerTercih = 2;
            RandomComputerPlay();
            ScoreUpdate();
            GameOver();
        }

        private void RandomComputerPlay()
        {
            Random rand = new Random();
            int randKart = rand.Next(3, 6);
            pictComputer.Image = imageList1.Images[randKart];


            // taşın olasılıkarı
            if(PlayerTercih == 0 && randKart == 4) 
            {
                ComputerScore++;
            }
            else if (PlayerTercih == 0 && randKart == 5)
            {
                PlayerScore++;
            }

            // kagıdın olasılıkları
            if(PlayerTercih == 1 && randKart == 3)
            {
                PlayerScore++;

            }
            else if(PlayerTercih == 1 && randKart == 5)
            {
                ComputerScore++;
            }

            // Makas Olasılıklar
            if(PlayerTercih == 2 && randKart == 3)
            {
                ComputerScore++;
            }
            else if (PlayerTercih == 2 && randKart == 4)
            {
                PlayerScore++;
            }

        }
        private void ScoreUpdate()
        {
            lblPlayerScore.Text = PlayerScore.ToString();
            lblComputerScore.Text = ComputerScore.ToString();
        }

        private void GameOver()
        {
            if(PlayerScore == 3)
            {
                pictGameover.Image = imgListGameOver.Images[0];
                lblPlayerScore.Text = "0";
                PlayerScore = 0;
                lblComputerScore.Text = "0";
                ComputerScore = 0;
                //pictComputer.Image = null;
                //pictPlayer.Image = null;
                

            }
            if(ComputerScore == 3)
            {
                pictGameover.Image = imgListGameOver.Images[1];
                lblPlayerScore.Text = "0";
                PlayerScore = 0;
                lblComputerScore.Text = "0";
                ComputerScore = 0;
                //pictComputer.Image = null;
                //pictPlayer.Image = null;
            }
        }

        private void btnGeriGit_Click(object sender, EventArgs e)
        {
            AnaSayfa anasayfa = new AnaSayfa();
            this.Close();

            anasayfa.Show();
        }
    }
}
