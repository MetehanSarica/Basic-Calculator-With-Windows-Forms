using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Basic_Calculator_With_Windows_Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int number1 = int.Parse(textBox1.Text);
            int number2 = int.Parse(textBox2.Text);
            int sum = number1 + number2;
            label3.Text = "Sum: " + sum.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int number1 = int.Parse(textBox1.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void Operation_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            int number1 = int.Parse(textBox1.Text);
            int number2 = int.Parse(textBox2.Text);
            int result = 0;
            switch (btn.Text)
            {
                case "+":
                    result = number1 + number2;
                    break;
                case "-":
                    result = number1 - number2;
                    break;
                case "x":
                    result = number1 * number2;
                    break;
                case "/":
                    if (number2 != 0)
                    {
                        result = number1 / number2;
                    }
                    else
                    {
                        MessageBox.Show("Cannot divide by zero");
                        return;
                    }
                    break;
            }
            label3.Text = "Result: " + result.ToString();
        }
    }
}
