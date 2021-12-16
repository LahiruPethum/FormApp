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
        string op = "";
        double result = 0;
        bool isOParationPerform = false;

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

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button18_Click(object sender, EventArgs e)
        {
            switch (op) {
                case "+" :textBox1.Text = (result + double.Parse(textBox1.Text)).ToString();
                    break;
                case "-":
                    textBox1.Text = (result - double.Parse(textBox1.Text)).ToString();
                    break;
                case "*":
                    textBox1.Text = (result * double.Parse(textBox1.Text)).ToString();
                    break;
                case "/":
                    textBox1.Text = (result / double.Parse(textBox1.Text)).ToString();
                    break;
            }
        }

        private void button_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" || isOParationPerform) {
                textBox1.Clear();
            }
            Button btn = (Button)sender;
            if (btn.Text == ".")
            {
                if (!textBox1.Text.Contains(".")) {
                    textBox1.Text = textBox1.Text + btn.Text;
                }
                
            }
            else
            {
                textBox1.Text = textBox1.Text + btn.Text;
            }
            isOParationPerform = false;
        }

        private void oparation(object sender, EventArgs e)
        {
            if (result != 0) {
                button18.PerformClick();
                Button btn = (Button)sender;
                op = btn.Text;
                result = double.Parse(textBox1.Text);
                label1.Text = result + op;
                isOParationPerform = true;
            }
            else
            {
                Button btn = (Button)sender;
                op = btn.Text;
                result = double.Parse(textBox1.Text);
                label1.Text = result + op;
                isOParationPerform = true;
            }
            

        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            label1.Text = "";
        }
    }
    

}
