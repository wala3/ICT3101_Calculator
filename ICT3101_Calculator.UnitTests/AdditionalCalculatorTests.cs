using System;
using Moq;
using NUnit.Framework;

namespace ICT3101_Calculator.UnitTests
{
    public class AdditionalCalculatorTests
    {
        private Calculator _calculator;
        private Mock<IFileReader> _mockFileReader;

        [SetUp]
        public void Setup()
        {
            _mockFileReader = new Mock<IFileReader>();
            _mockFileReader.Setup(fr => fr.Read("MagicNumbers.txt")).Returns(new string[2] { "42", "42" });
            _calculator = new Calculator();
        }

        [Test]
        public void GenMagicNum_WhenGeneratingMagicNumber_ResultEqualToSelectedIndexTimes2()
        {
            // Act 
            double result = _calculator.GenMagicNum(0, _mockFileReader.Object);
            // Assert
            Assert.That(result, Is.EqualTo(84));
        }
    }
}
