using NUnit.Framework;

namespace ICT3101_Calculator.UnitTests
{
    public class CalculatorTests
    {
        private Calculator _calculator;

        [SetUp]
        public void Setup()
        {
            // Arrange
            _calculator = new Calculator();
        }

        [Test]
        public void Add_WhenAddingTwoNumbers_ResultEqualToSum()
        {
            // Act 
            double result = _calculator.Add(10, 20);
            // Assert
            Assert.That(result, Is.EqualTo(30));
        }

        [Test]
        public void Subtract_WhenSubtractingTwoNumbers_ResultEqualToMinus()
        {
            // Act 
            double result = _calculator.Subtract(20, 10);
            // Assert
            Assert.That(result, Is.EqualTo(10));
        }

        [Test]
        public void Multiply_WhenMultiplyingTwoNumbers_ResultEqualToMultiply()
        {
            // Act 
            double result = _calculator.Multiply(5, 2);
            // Assert
            Assert.That(result, Is.EqualTo(10));
        }

        [Test]
        public void Divide_WhenDividingTwoNumbers_ResultEqualToDivide()
        {
            // Act 
            double result = _calculator.Divide(10, 2);
            // Assert
            Assert.That(result, Is.EqualTo(5));
        }

        [Test]
        [TestCase(0, 0)]
        [TestCase(0, 10)]
        [TestCase(10, 0)]
        public void Divide_WithZerosAsInputs_ResultThrowArgumentException(int a, int b)
        {
            Assert.That(() => _calculator.Divide(0, 0), Throws.ArgumentException);
        }

        [Test]
        public void Factorial_WithZeroAsInputs_ResultThrowException()
        {
            Assert.That(() => _calculator.Factorial(0), Throws.ArgumentException);
        }

        [Test]
        public void Factorial_WithNegativeAsInputs_ResultThrowException()
        {
            Assert.That(() => _calculator.Factorial(-5), Throws.ArgumentException);
        }

        [Test]
        public void AreaOfTriangle_WhenCalculatingAreaOfTriangle_ResultEqualToAreaOfTriangle()
        {
            // Act 
            double result = _calculator.AreaOfTriangle(10, 20);
            // Assert
            Assert.That(result, Is.EqualTo(100));
        }

        [Test]
        public void AreaOfCircle_WhenCalculatingAreaOfCircle_ResultEqualToAreaOfCircle()
        {
            // Act 
            double result = _calculator.AreaOfCircle(10);
            // Assert
            Assert.That(result, Is.EqualTo(314.2));
        }
    }
}
