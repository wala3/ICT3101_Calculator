using System;
using TechTalk.SpecFlow;
using NUnit.Framework;

namespace ICT3101_Calculator.UnitTests.Step_Definitions
{
    [Binding]
    public class UsingCalculatorFactorialSteps
    {
        private Calculator _calculator;
        public UsingCalculatorFactorialSteps(Calculator calc)
        {
            this._calculator = calc;
        }

        private double input;

        [When(@"I have entered ""(.*)"" into the calculator and press factorial")]
        public void WhenIHaveEnteredIntoTheCalculator(double p0)
        {
            input = p0;
        }

        [Then(@"the factorial result should be ""(.*)""")]
        public void ThenTheResultShouldBeOnTheScreen(double p0)
        {
            Assert.That(_calculator.Factorial(input), Is.EqualTo(p0));
        }

        [Then(@"the factorial function should throw argument exception")]
        public void ThenTheResultShouldBePositiveInfinity()
        {
            Assert.That(() => _calculator.Factorial(input), Throws.ArgumentException);
        }
    }
}
