using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class CalculatorUI : Form
    {
        public CalculatorUI()
        {
            InitializeComponent();
        }
        Calculator myCalculator=new Calculator();
        private void addButton_Click(object sender, EventArgs e)
        {
            if (firstNumberTextBox.Text != "" && secondNumberTextBox.Text != "")
            {   resultTextBox.Clear();
                myCalculator.firstNumber = Convert.ToDouble(firstNumberTextBox.Text);
                myCalculator.secondNumber = Convert.ToDouble(secondNumberTextBox.Text);
                resultTextBox.Text = Convert.ToString(myCalculator.AddTwoNumber());
               
            }
            else
            {
                MessageBox.Show("please enter number");
            }
        }

        private void subTractButton_Click(object sender, EventArgs e)
        {
            if (firstNumberTextBox.Text != "" && secondNumberTextBox.Text != "")
            {
                resultTextBox.Clear();
                myCalculator.firstNumber = Convert.ToDouble(firstNumberTextBox.Text);
                myCalculator.secondNumber = Convert.ToDouble(secondNumberTextBox.Text);
                resultTextBox.Text = Convert.ToString(myCalculator.SubtractionOfTwoNumber());
               
            }
            else
            {
                MessageBox.Show("please enter number");
            }

        }

        private void multiplyButton_Click(object sender, EventArgs e)
        {
            if (firstNumberTextBox.Text != "" && secondNumberTextBox.Text != "")
            {
                resultTextBox.Clear();
                myCalculator.firstNumber = Convert.ToDouble(firstNumberTextBox.Text);
                myCalculator.secondNumber = Convert.ToDouble(secondNumberTextBox.Text);
                resultTextBox.Text = Convert.ToString(myCalculator.MultiplyTwoNumber());
               
            }
            else
            {
                MessageBox.Show("please enter number");
            }
        }

        private void divideButton_Click(object sender, EventArgs e)
        {
            if (firstNumberTextBox.Text != "" && secondNumberTextBox.Text != "")
            {
                resultTextBox.Clear();
                myCalculator.firstNumber = Convert.ToDouble(firstNumberTextBox.Text);
                myCalculator.secondNumber = Convert.ToDouble(secondNumberTextBox.Text);
                resultTextBox.Text = Convert.ToString(myCalculator.DivideTwoNumber());
                
            }
               
            else
            {
                MessageBox.Show("please enter number");
            }
        }
       
    }
}
