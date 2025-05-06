using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Calculator
{
    public class Calculator
    {
        public double Add(int a, int b) => a + b;
        public double Subtract(int a, int b) => a - b;
        public double Multiply(int a, int b) => a * b;
        public double Divide(int a, int b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("Cannot divide by zero.");
            }
            return a / b;
        }


    }
}
