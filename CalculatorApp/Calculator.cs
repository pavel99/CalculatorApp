using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApp
{
    class Calculator
    {
        public double firstNumber;
        public double secondNumber;

        public double AddTwoNumber()
        {
            return firstNumber + secondNumber;
        }
        public double SubtractionOfTwoNumber()
        {
            return firstNumber - secondNumber;
        }

        public double MultiplyTwoNumber()
        {
            return firstNumber * secondNumber;
        }
        public double DivideTwoNumber()
        {
            return firstNumber / secondNumber;
        }
    }
}
