using System;
using System.Drawing;
using System.Windows.Forms;

namespace Basic_Window_Form_App
{
    public partial class Form1 : Form
    {
        int input1 = 0;
        int input2 = 0;
        int result = 0;
        char op;
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

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            label1.Text += "1";
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            label1.Text += "2";
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            label1.Text += "3";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label1.Text += "4";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label1.Text += "5";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            label1.Text += "6";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            label1.Text += "7";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            label1.Text += "8";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            label1.Text += "9";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            label1.Text += "0";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            result = 0;
            input1 = 0;
            input2 = 0;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            input2 = int.Parse(label1.Text);
            if (op == '+')
            {
                result = input1 + input2;
                label1.Text = result.ToString();
            }
            else if (op == '-')
            {
                result = input1 - input2;
                label1.Text = result.ToString();
            }
            else if (op == '*')
            {
                result = input1 * input2;
                label1.Text = result.ToString();
            }
            else if (op == '/')
            {
                result = input1 / input2;
                label1.Text = result.ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            input1 = int.Parse(label1.Text);
            label1.Text = "";
            op = '+';
        }

        private void button8_Click(object sender, EventArgs e)
        {
            input1 = int.Parse(label1.Text);
            label1.Text = "";
            op = '-';
        }

        private void button12_Click(object sender, EventArgs e)
        {
            input1 = int.Parse(label1.Text);
            label1.Text = "";
            op = '*';
        }

        private void button16_Click(object sender, EventArgs e)
        {
            input1 = int.Parse(label1.Text);
            label1.Text = "";
            op = '/';
        }
    }
}
