using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Calculator
{
    public class ScientficCalculatorTest
    {
        
            private ScientficCalculator _scientficCalculator;

            [SetUp]
            public void Setup()
            {
                _scientficCalculator = new ScientficCalculator();
            }

            [Test]
            public void SquareRoot_PositiveNumber_ReturnsCorrectResult()
            {
                // Arrange
                double number = 16;

                // Act
                double result = _scientficCalculator.SquareRoot(number);

                // Assert
                Assert.That(result, Is.EqualTo(4));
            }

            [Test]
            public void SquareRoot_NegativeNumber_ThrowsArgumentException()
            {
                // Arrange
                double number = -16;

                // Act & Assert
                Assert.Throws<ArgumentException>(() => _scientficCalculator.SquareRoot(number));
            }

            [Test]
            public void Power_PositiveBaseAndExponent_ReturnsCorrectResult()
            {
                // Arrange
                double baseNumber = 2;
                double exponent = 3;

                // Act
                double result = _scientficCalculator.Power(baseNumber, exponent);

                // Assert
                Assert.That(result, Is.EqualTo(8));
            }

            [Test]
            public void Power_BaseZeroAndPositiveExponent_ReturnsZero()
            {
                // Arrange
                double baseNumber = 0;
                double exponent = 5;

                // Act
                double result = _scientficCalculator.Power(baseNumber, exponent);

                // Assert
                Assert.That(result, Is.EqualTo(0));
            }

            [Test]
            public void Logarithm_PositiveNumber_ReturnsCorrectResult()
            {
                // Arrange
                double number = 100;
                double baseValue = 10;

                // Act
                double result = _scientficCalculator.Logarithm(number, baseValue);

                // Assert
                Assert.That(result, Is.EqualTo(2));
            }

            [Test]
            public void Logarithm_NegativeNumber_ThrowsArgumentException()
            {
                // Arrange
                double number = -10;
                double baseValue = 10;

                // Act & Assert
                Assert.Throws<ArgumentException>(() => _scientficCalculator.Logarithm(number, baseValue));
            }

            [Test]
            public void Sine_ValidAngleInDegrees_ReturnsCorrectResult()
            {
                // Arrange
                double angle = 30;

                // Act
                double result = _scientficCalculator.Sine(angle);

                // Assert
                Assert.That(result, Is.EqualTo(0.5).Within(0.0001));
            }

            [Test]
            public void Cosine_ValidAngleInDegrees_ReturnsCorrectResult()
            {
                // Arrange
                double angle = 60;

                // Act
                double result = _scientficCalculator.Cosine(angle);

                // Assert
                Assert.That(result, Is.EqualTo(0.5).Within(0.0001));
            }

            [Test]
            public void Tangent_ValidAngleInDegrees_ReturnsCorrectResult()
            {
                // Arrange
                double angle = 45;

                // Act
                double result = _scientficCalculator.Tangent(angle);

                // Assert
                Assert.That(result, Is.EqualTo(1).Within(0.0001));
            }

            [Test]
            public void Tangent_Angle90Degrees_ThrowsInvalidOperationException()
            {
                // Arrange
                double angle = 90;

                // Act & Assert
                Assert.Throws<InvalidOperationException>(() => _scientficCalculator.Tangent(angle));
            }
    }



}

