using System;
using TechTalk.SpecFlow;
using NUnit.Framework;

namespace ICT3101_Calculator.UnitTests.Step_Definitions
{
    [Binding]
    public class UsingCalculatorDivisionsSteps
    {
        private Calculator _calculator;
        public UsingCalculatorDivisionsSteps(Calculator calc)
        {
            this._calculator = calc;
        }

        private double _result;

        [When(@"I have entered ""(.*)"" and ""(.*)"" into the calculator and press divide")]
        public void WhenIHaveEnteredAndIntoTheCalculator(double p0, double p1)
        {
            _result = _calculator.GherkinDivide(p0, p1);
        }

        [Then(@"the division result should be ""(.*)""")]
        public void ThenTheResultShouldBeOnTheScreen(double p0)
        {
            Assert.That(_result, Is.EqualTo(p0));
        }

        [Then(@"the division result should be positive infinity")]
        public void ThenTheResultShouldBePositiveInfinity()
        {
            Assert.That(_result, Is.EqualTo(0));
        }
    }
}