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
    public partial class Form3 : Form
    {
        public string playerName;
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        void moveline(int speed)
        {
            if (pictureBox1.Top >= 500)
            {
                pictureBox1.Top = 0;
            }
            else
            {
                pictureBox1.Top += speed;
            }

            if (pictureBox2.Top >= 500)
            {
                pictureBox2.Top = 0;
            }
            else
            {
                pictureBox2.Top += speed;
            }

            if (pictureBox3.Top >= 500)
            {
                pictureBox3.Top = 0;
            }
            else
            {
                pictureBox3.Top += speed;
            }

            if (pictureBox4.Top >= 500)
            {
                pictureBox4.Top = 0;
            }
            else
            {
                pictureBox4.Top += speed;
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            moveline(5);
        }

        private void btmQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btmPlay_Click(object sender, EventArgs e)
        {
           
            Form2 gamescreen = new Form2();
            gamescreen.playerName = this.playerName;
            gamescreen.Show();
            this.Hide();
        }

        private void btmScores_Click(object sender, EventArgs e)
        {
            
        }
    }
}
