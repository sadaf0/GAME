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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            this.Text = "Shooting";
            this.button1.Text = "Start";
            this.button2.Text = "Exit";
            this.button1.Font = new Font("Winter Solstice Italic", 25);
            this.button2.Font = new Font("Winter Solstice Italic", 25);
            this.button1.FlatStyle = FlatStyle.Flat;
            this.button2.FlatStyle = FlatStyle.Flat;
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
