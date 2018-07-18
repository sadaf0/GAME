using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace sadaf_Game
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        Random r = new Random();
        int score = 0;
        int miss_shots = 0;
        int total_shots = 0;
        void s()
        {

            score++;
            label1.Text = "Total Score "+score;
            total_shots++;
            label3.Text = "Total Shots "+total_shots;
        
        }
        void ms()
        {
            miss_shots++;
            label2.Text = "Miss Shots "+miss_shots;
            total_shots++;
            label3.Text = "Total Shots "+total_shots;
         }
        void reset()
        {

            score = 0;
            miss_shots = 0;
            total_shots = 0;
            label1.Text = "Total Score " + score;
            label2.Text = "Miss Shots " + miss_shots;
            label3.Text = "Total Shots " + total_shots;
        
        }
        
        private void Form2_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            this.Text = "Shooting";         
            this.label1.Text = "Total Score: ";
            this.label2.Text = "Miss Shots: ";
            this.label3.Text = "Total Shots: ";
            this.button1.Text = "Exit";
            this.button2.Text = "Restart";
            this.label1.Font = new Font("Winter Solstice Italic", 18);
            this.label2.Font = new Font("Winter Solstice Italic", 18);
            this.label3.Font = new Font("Winter Solstice Italic", 18);
            this.button1.Font = new Font("Winter Solstice Italic", 20);
            this.button2.Font = new Font("Winter Solstice Italic", 17);
            this.label1.BackColor = Color.PaleGoldenrod;
            this.label2.BackColor = Color.PaleGoldenrod;
            this.label3.BackColor = Color.PaleGoldenrod;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int x, y;
            x = r.Next(0,440);
            y = r.Next(200,350);
            pictureBox1.Location = new Point(x, y);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            s();
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void Form2_MouseClick(object sender, MouseEventArgs e)
        {
            ms();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            reset();
        }
    }
}
