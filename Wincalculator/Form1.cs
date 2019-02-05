using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wincalculator
{
    public partial class Calculator : Form
    {
        double value;
        String operation="";
        Boolean operation_pressed = false;

        public Calculator()
        {
            InitializeComponent();
        }

        private void Calculator_Load(object sender, EventArgs e)
        {

        }

       /* private void button1_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            result.Text = result.Text + b.Text;
        }
       private void button2_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            result.Text = result.Text + b.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            result.Text = result.Text + b.Text;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            result.Text = result.Text + b.Text;
        }
        private void button5_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            result.Text = result.Text + b.Text;
        }


        private void button6_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            result.Text = result.Text + b.Text;
        }


        private void button7_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            result.Text = result.Text + b.Text;



        }
        private void button8_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            result.Text = result.Text + b.Text;
        }
        private void button9_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            result.Text = result.Text + b.Text;
        }*/
        private void button_Click(object sender, EventArgs e)
        {
            if (result.Text == "0"||operation_pressed)
            {
                result.Clear();
                operation_pressed = false;
            }
           
          //  operation_pressed = false;
            Button b = (Button)sender;
            result.Text = result.Text + b.Text;
           
        }

        private void button16_Click(object sender, EventArgs e)
        {
            result.Text = "0";
        }

        private void operator_click(object sender, EventArgs e)
        {
           
           
            
                Button b = (Button)sender;
                operation = b.Text;
                value = Double.Parse(result.Text);
                operation_pressed = true;

                equation.Text = value + "" + operation;
            
        }

        private void button18_Click(object sender, EventArgs e)
        {
            equation.Text = "";
            switch (operation)
            {
                case "+":
                    {
                        result.Text = (value + Double.Parse(result.Text)).ToString();
                        break;

                    }

                case "-":
                    {
                        result.Text = (value - Double.Parse(result.Text)).ToString();
                        break;

                    }

                case "*":
                    {
                        result.Text = (value * Double.Parse(result.Text)).ToString();
                        break;

                    }

                case "/":
                    {
                        result.Text = (value / Double.Parse(result.Text)).ToString();
                        break;

                    }

                default:
                    break;

            }//END SWITCH
           // operation_pressed = false;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            result.Text="0";
            value = 0;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
