using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Calculator
{
    
        public class ScientficCalculator
        {
            public double SquareRoot(double number)
            {
                if (number < 0)
                {
                    throw new ArgumentException("Cannot calculate the square root of a negative number.");
                }
                return Math.Sqrt(number);
            }

            public double Power(double baseNumber, double exponent)
            {
                return Math.Pow(baseNumber, exponent);
            }

            public double Logarithm(double number, double baseValue)
            {
                if (number <= 0 || baseValue <= 0 || baseValue == 1)
                {
                    throw new ArgumentException("Invalid input for logarithm. Number and base must be positive, and base cannot be 1.");
                }
                return Math.Log(number, baseValue);
            }

            public double Sine(double angleInDegrees)
            {
                double angleInRadians = DegreesToRadians(angleInDegrees);
                return Math.Sin(angleInRadians);
            }

            public double Cosine(double angleInDegrees)
            {
                double angleInRadians = DegreesToRadians(angleInDegrees);
                return Math.Cos(angleInRadians);
            }

            public double Tangent(double angleInDegrees)
            {
                double angleInRadians = DegreesToRadians(angleInDegrees);
                if (Math.Abs(angleInDegrees % 180) == 90)
                {
                    throw new InvalidOperationException("Tangent is undefined for angles 90° + n*180°.");
                }
                return Math.Tan(angleInRadians);
            }

            private double DegreesToRadians(double degrees)
            {
                return degrees * (Math.PI / 180);
            }
        }
}


