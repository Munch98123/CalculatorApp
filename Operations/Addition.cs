using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculatorApp.IOperations;

namespace CalculatorApp.Operations
{
    public class Addition : IOperations.IOperations
    {
        public double Calculate(double num1 = 0, double num2 = 0) => num1 + num2;
    }
}
