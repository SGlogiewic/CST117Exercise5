using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CST117Exercise5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e) 
        {
            int intTerms;
            if (int.TryParse(textBox1.Text, out intTerms)) 
            {
                // declare variables
                int index = 0;
                double x = 4;
                double y = 1;
                double approx;
                double newpi = 0.0;
                // makes while loop go through loop specified amount of times by user
                while (++index < intTerms - 1) 
                {
                    //algorithm to create = x - x/y + x/y - x/y etc...
                    approx = x / y;
                    newpi = newpi + approx;
                    y = y + 2;
                    // alternate between positive and negative values of x
                    x = (x > 0) ? -4.0 : 4.0;
                }
                // updates the text box and label
                label3.Text = Convert.ToString(newpi);
                this.label2.Text = "Approximate value of pi after " + textBox1.Text + " terms";
            }
            else
            {
                // message box lets user know there's an invalid input.
                MessageBox.Show("Please enter a valid integer.");
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
