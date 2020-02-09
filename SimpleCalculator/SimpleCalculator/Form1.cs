using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class Form1 : Form
    {
        double result = 0;
        string operatorPreform = "";
        bool isOpetaroPreform = false;
        public Form1()
        {
            InitializeComponent();
        }
   
        
        private void button_Click(object sender, EventArgs e)
        {
            if (textResult.Text == "0" || isOpetaroPreform)
            {
                textResult.Clear();
            }
            
            isOpetaroPreform = false;
            Button button = (Button)sender;
           textResult.Text = textResult.Text + button.Text;
        }

      
        private void Operator_Click(object sender, EventArgs e)
        {         
            Button operators = (Button)sender;
            isOpetaroPreform = true;         
            operatorPreform = operators.Text;
            result = double.Parse(textResult.Text);
            
        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {
            switch (operatorPreform)
            {
                case "+":
                    textResult.Text = (result + double.Parse(textResult.Text)).ToString();             
                    break;
                case "-":
                    textResult.Text = (result - double.Parse(textResult.Text)).ToString();
                    break;
                case "X":
                    textResult.Text = (result * double.Parse(textResult.Text)).ToString();
                    break;
                case "/":
                    textResult.Text = (result / double.Parse(textResult.Text)).ToString();
                    break;
            }
             
        }

        private void buttonCE_Click(object sender, EventArgs e)
        {
            textResult.Text = "0";
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textResult.Text = "0";
            result = 0;
        }
    }
}
