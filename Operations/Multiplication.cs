using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApp.Operations
{
    public class Multiplication : IOperations.IOperations
    {
        public double Calculate(double num1, double num2) => num1 * num2;
    }
}
