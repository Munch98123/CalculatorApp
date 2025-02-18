using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApp.Operations
{
    public class Division : IOperations.IOperations
    {
        public double Calculate(double num1, double num2)
        {
            //a little iffy about this implementation but it atleast main catches the error instead of crashing the program
            if (num2 == 0)
                throw new DivideByZeroException("Cannot divide by zero! Please try again.");
            return num1 / num2;
        }
    }
}
