using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace LA_ILA_1500_Autorennspiel
{
    public partial class Form2 : Form
    {
        int roadSpeed;
        int trafficSpeed;
        int playerSpeed = 12;
        public int score;
        public string playerName;
        int carImage;
        

        Random rnd = new Random();
        Random carPosition = new Random();

        Random rand = new Random();

        Random rnd2 = new Random();
        Random coinPosition = new Random();
        

        bool goleft, goright;


        public Form2()
        {
            InitializeComponent();
            ResetGame();
        }

        
        

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void keyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goleft = true;
            }

            if (e.KeyCode == Keys.Right)
            {
                goright = true;
            }
        }

        private void keyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goleft = false;
            }

            if (e.KeyCode == Keys.Right)
            {
                goright = false;
            }
        }

        private void gameTimerEvent(object sender, EventArgs e)

          {
            lblScore.Text = "Score: " + score;
            score++;

            if (goleft == true && player.Left > -17)
            {
                player.Left -= playerSpeed;
            }

            if (goright == true && player.Left < 268)
            {
                player.Left += playerSpeed;
            }

            Roadtrack.Top += roadSpeed;
            Roadtrack2.Top += roadSpeed;

            if (Roadtrack2.Top > 519)
            {
                Roadtrack2.Top = -519;
            }

            if (Roadtrack.Top > 519)
            {
                Roadtrack.Top = -519;
            }
            AI1.Top += trafficSpeed;
            AI2.Top += trafficSpeed;

            if (AI1.Top > 530)
            {
                changeAIcars(AI1);
            }
            if (AI2.Top > 530)
            {
                changeAIcars(AI2);
            }
           
            

            if (player.Bounds.IntersectsWith (AI1.Bounds) || player.Bounds.IntersectsWith(AI2.Bounds)) {
                gameOver();

            }

           

         

        }

        private void changeAIcars(PictureBox tempCar)
        {
            carImage = rand.Next(1, 8);

            switch (carImage)
            {
                case 1: 
                    tempCar.Image = Properties.Resources.Ambulance_1_png;
                    break;
                case 2:
                    tempCar.Image = Properties.Resources.Mini_truck_1_png;
                    break;
                case 3:
                    tempCar.Image = Properties.Resources.Audi_1_png;
                    break;
                case 4:
                    tempCar.Image = Properties.Resources.Black_viper_2_;
                    break;
                case 5:
                    tempCar.Image = Properties.Resources.taxi_1_png;
                    break;
                case 6:
                    tempCar.Image = Properties.Resources.truck_1_png;
                    break;
                case 7:
                    tempCar.Image = Properties.Resources.Car_1_png;
                    break;
                case 8:
                    tempCar.Image = Properties.Resources.Police_1_png;
                    break;


            }

            
            tempCar.Top = carPosition.Next(100, 400)* -1;

            
            if((string)tempCar.Tag == "carLeft")
            {
                tempCar.Left = carPosition.Next(-17, 170);
            }
            if ((string)tempCar.Tag == "carright")
            {
                tempCar.Left = carPosition.Next(200, 367);
            }
        }

        private void changeAIcoins(PictureBox coins)
        {
            coins.Top = coinPosition.Next(100, 400) * -1;

            if ((string)coins.Tag == "coin1")
            {
                coins.Left = coinPosition.Next(260, 460);
            }
        }

        private void gameOver()
        {
            gameTimer.Stop();
            this.Close();
            new Form4().Show();

            MessageBox.Show(this.playerName + "," + score);
            StreamWriter scoreWriter = new StreamWriter("Highscores.txt", true);
            scoreWriter.WriteLine(this.playerName +"," + score);
            scoreWriter.Close();

            
            
        }

        private void ResetGame()
        {
            goleft = false;
            goright = false;
            score = 0;

            
            roadSpeed = 12;
            trafficSpeed = 15;




            

            gameTimer.Start();
        }

        private void AI2_Click(object sender, EventArgs e)
        {

        }

        private void lblScore_Click(object sender, EventArgs e)
        {

        }

        private void Roadtrack2_Click(object sender, EventArgs e)
        {

        }

        private void playSound()
        {

        }
    }
}
