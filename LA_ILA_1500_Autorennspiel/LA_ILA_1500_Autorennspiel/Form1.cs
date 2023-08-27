using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LA_ILA_1500_Autorennspiel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            

        }

       

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string playerName = textBox1.Text;
            Form3 titleScreen = new Form3();
            titleScreen.playerName = playerName;
            titleScreen.Show();


            this.Hide();
        }
    }
}
