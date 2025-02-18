using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CalculatorApp.IOperations.IOperations;

namespace CalculatorApp
{
    public class Calculator
    {
        private readonly IOperations.IOperations _operation;

        public Calculator(IOperations.IOperations operation)
        {
            _operation = operation;
        }

        public double PerformCalculation(double num1, double num2)
        {
            return _operation.Calculate(num1, num2);
        }
    }
}
