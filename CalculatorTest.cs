namespace Basic_Calculator
{
    [TestFixture]
    public class Tests
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

    }
}