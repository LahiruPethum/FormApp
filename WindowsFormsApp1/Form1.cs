using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            double num1 = double.Parse(textBox1.Text);
            double num2 = double.Parse(textBox2.Text);
            string op = textBox3.Text;

            if (op == "+")
            {
                double ans = num1 + num2;
                label5.Text = ans.ToString();
            }
            else if (op == "-")
            {
                double ans = num1 - num2;
                label5.Text = ans.ToString();
            }
            else if (op == "*")
            {
                double ans = num1 * num2;
                label5.Text = ans.ToString();
            }
            else if (op == "/")
            {
                double ans = num1 / num2;
                label5.Text = ans.ToString();
            }
            else {
                
                label5.Text = "Invalid";
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            label5.Text = "";
        }
    }
}
