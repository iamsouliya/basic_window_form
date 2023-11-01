using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Basic_Window_Form_App
{
    public partial class Form1 : Form
    {
        int timer = 31;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Hello World");
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            //if (green.BackColor == Color.Green)
            if (timer > 0 && timer <= 5)
            {
                green.BackColor = Color.Empty;
                yellow.BackColor = Color.Yellow;
                red.BackColor = Color.Empty;
            }
            //else if (yellow.BackColor == Color.Yellow)
            else if (timer == 30)
            {
                green.BackColor = Color.Empty;
                yellow.BackColor = Color.Empty;
                red.BackColor = Color.Red;
            }
            //else if (red.BackColor == Color.Red)
            else if (timer > 5 && timer <= 15)
            {
                green.BackColor = Color.Green;
                yellow.BackColor = Color.Empty;
                red.BackColor = Color.Empty;
            }

            timer--;
            if (timer < 1)
            {
                timer = 30;
            }
            label1.Text = timer.ToString();

        }
    }
}
