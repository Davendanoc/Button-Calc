using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ButtonCalc
{
    public partial class Form1 : Form
    {

        double value = 0;
        string operation = "";
        bool op = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_Click(object sender, EventArgs e)
        { 

            if (Result.Text == "0")
            Result.Clear();

            Button b = (Button)sender;
            Result.Text = Result.Text + b.Text;
        }

        private void buttonCE_Click(object sender, EventArgs e)
        {
            Result.Text = "0";
        }

        private void operator_click(object sender, EventArgs e)
        {
            Button c = (Button)sender;
            operation = c.Text;
            value = Double.Parse(Result.Text);
            op = true;
        }

        private void Equal_Click(object sender, EventArgs e)
        {

            switch (operation)
            {
                case "+":
                    Result.Text = (value + Double.Parse(Result.Text)).ToString();
                    break;

                case "-":
                    Result.Text = (value - Double.Parse(Result.Text)).ToString();
                    break;

                case "*":
                    Result.Text = (value * Double.Parse(Result.Text)).ToString();
                    break;

                case "/":
                    Result.Text = (value / Double.Parse(Result.Text)).ToString();
                    break;

                default:
                    break;
            }

            op = false;
        }

        
    }
}
