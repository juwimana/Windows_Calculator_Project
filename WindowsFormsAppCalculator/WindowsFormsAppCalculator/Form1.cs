using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppCalculator
{
    /*Name: Jean Marie Uwimana
     *Application Purpose: Simple Mathematical Calculator
     *Date: 21 January 2018
    */
    public partial class Form1 : Form
    {
        double number = 0;
        string result= string.Empty;
        string operator__= string.Empty;
        bool operator_ = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void output_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button_Click(object sender, EventArgs e)
        {
            if (output.Text =="0" || operator_)
                output.Clear();
            operator_ = false;

            Button b = (Button)sender;
            output.Text = output.Text + b.Text; 

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            output.Text = "0";
            label3.Text = string.Empty;
        }

        private void operator_Click(object sender, EventArgs e)
        {
            operator_ = true;
            Button b = (Button)sender;
            operator__ = b.Text;
            number = double.Parse(output.Text);
            output.Text = number + b.Text;
            label3.Text = number + "" + b.Text; 
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            label3.Text = string.Empty;

            switch (operator__)
            {
                case "+":
                     result = (number + double.Parse(output.Text)).ToString();
                    break;
                case "-":
                    result = (number - double.Parse(output.Text)).ToString();
                    break;
                case "*":
                    result = (number * double.Parse(output.Text)).ToString();
                    break;
                case "/":
                    if (double.Parse(output.Text) == 0)
                    {
                        MessageBox.Show("Error! Can't divide by zero");
                    }
                    else
                        result = (number / double.Parse(output.Text)).ToString();
                    break;
                default:
                    break;
            }
            output.Text = result.ToString();
        }

        private void btnPoint_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            if (!output.Text.Contains("."))
            {
                output.Text = output.Text + b.Text;
            }
            else
                output.Text = output.Text;
        }
    }
}
