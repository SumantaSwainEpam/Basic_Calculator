namespace Basic_Calculator
{
    [TestFixture]
    public class CalculatorTest
    {

        private Calculator _calculator;

        [SetUp]
        public void Setup()
        {
            _calculator = new Calculator();

        }

        [Test]
        public void Add_TwoPositiveNumbers_ReturnsCorrectSum()
        {
            // Arrange
            int a = 5;
            int b = 3;

            // Act
            double result = _calculator.Add(a, b);

            // Assert
            Assert.That(result, Is.EqualTo(8));
        }

        [Test]
        public void Subtract_TwoPositiveNumbers_ReturnsCorrectDifference()
        {
            // Arrange
            int a = 5;
            int b = 3;

            // Act
            double result = _calculator.Subtract(a, b);

            // Assert
            Assert.That(result, Is.EqualTo(2));
        }
        [Test]
        public void Multiply_TwoPositiveNumbers_ReturnsCorrectProduct()
        {
            // Arrange
            int a = 5;
            int b = 3;

            // Act
            double result = _calculator.Multiply(a, b);

            // Assert
            Assert.That(result, Is.EqualTo(15));
        }
        [Test]
        public void Divide_TwoPositiveNumbers_ReturnsCorrectQuotient()
        {
            // Arrange
            int a = 6;
            int b = 3;

            // Act
            double result = _calculator.Divide(a, b);

            // Assert
            Assert.That(result, Is.EqualTo(2));
        }
        [Test]
        public void Divide_ByZero_ThrowsDivideByZeroException()
        {
            // Arrange
            int a = 5;
            int b = 0;

            // Act & Assert
            Assert.Throws<DivideByZeroException>(() => _calculator.Divide(a, b));
        }

        [Test]
        public void Add_NegativeAndPositiveNumber_ReturnsCorrectSum()
        {
            // Arrange
            int a = -5;
            int b = 3;

            // Act
            double result = _calculator.Add(a, b);

            // Assert
            Assert.That(result, Is.EqualTo(-2));
        }

        [Test]
        public void Subtract_LargerFromSmallerNumber_ReturnsNegativeDifference()
        {
            // Arrange
            int a = 3;
            int b = 5;

            // Act
            double result = _calculator.Subtract(a, b);

            // Assert
            Assert.That(result, Is.EqualTo(-2));
        }

        [Test]
        public void Multiply_ByZero_ReturnsZero()
        {
            // Arrange
            int a = 5;
            int b = 0;

            // Act
            double result = _calculator.Multiply(a, b);

            // Assert
            Assert.That(result, Is.EqualTo(0));
        }

        [Test]
        public void Divide_NegativeByPositiveNumber_ReturnsNegativeQuotient()
        {
            // Arrange
            int a = -6;
            int b = 3;

            // Act
            double result = _calculator.Divide(a, b);

            // Assert
            Assert.That(result, Is.EqualTo(-2));
        }

        [Test]
        public void Divide_TwoNegativeNumbers_ReturnsPositiveQuotient()
        {
            // Arrange
            int a = -6;
            int b = -3;

            // Act
            double result = _calculator.Divide(a, b);

            // Assert
            Assert.That(result, Is.EqualTo(2));
        }

        [Test]
        public void Add_TwoNegativeNumbers_ReturnsCorrectSum()
        {
            // Arrange
            int a = -5;
            int b = -3;

            // Act
            double result = _calculator.Add(a, b);

            // Assert
            Assert.That(result, Is.EqualTo(-8));
        }

        [Test]
        public void Subtract_TwoNegativeNumbers_ReturnsCorrectDifference()
        {
            // Arrange
            int a = -5;
            int b = -3;

            // Act
            double result = _calculator.Subtract(a, b);

            // Assert
            Assert.That(result, Is.EqualTo(-2));
        }

        [Test]
        public void Multiply_TwoNegativeNumbers_ReturnsPositiveProduct()
        {
            // Arrange
            int a = -5;
            int b = -3;

            // Act
            double result = _calculator.Multiply(a, b);

            // Assert
            Assert.That(result, Is.EqualTo(15));
        }

        [Test]
        public void Divide_PositiveByNegativeNumber_ReturnsNegativeQuotient()
        {
            // Arrange
            int a = 6;
            int b = -3;

            // Act
            double result = _calculator.Divide(a, b);

            // Assert
            Assert.That(result, Is.EqualTo(-2));
        }

        [Test]
        public void Divide_ZeroByAnyNumber_ReturnsZero()
        {
            // Arrange
            int a = 0;
            int b = 5;

            // Act
            double result = _calculator.Divide(a, b);

            // Assert
            Assert.That(result, Is.EqualTo(0));
        }

        [Test]
        public void DivideWithNegativeNumber()
        {
            int a = 11;
            int b = -5;
            double res=_calculator.Divide(a, b);

            //Assert
            Assert.That(res, Is.EqualTo(-2.0d));
            
        }



    }
}