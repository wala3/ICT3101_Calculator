using System;
using TechTalk.SpecFlow;
using NUnit.Framework;

namespace ICT3101_Calculator.UnitTests.Step_Definitions
{
    [Binding]
    public class UsingCalculatorBasicReliabilitySteps
    {
        private Calculator _calculator;
        public UsingCalculatorBasicReliabilitySteps(Calculator calc)
        {
            this._calculator = calc;
        }

        private double _result;

        [When(@"initial failure intensity is ""(.*)"" and program already experienced ""(.*)"" failures and will experience ""(.*)"" failures")]
        public void WhenIHaveEnteredIntoTheCalculatorAndPressCurrentFailureIntensity(double p0, double p1, double p2)
        {
            _result = _calculator.CurrentFailureIntensity(p0, p1, p2);
        }

        [Then(@"the current failure intensity should be ""(.*)""")]
        public void ThenTheCurrentFailureIntensityShouldBeOnTheScreen(double p0)
        {
            Assert.That(_result, Is.EqualTo(p0));
        }

        [When(@"initial failure intensity is ""(.*)"" and the program will experience ""(.*)"" failures and it ran for ""(.*)"" CPU hours")]
        public void WhenIHaveEnteredIntoTheCalculatorAndPressAerageNumberOfFailures(double p0, double p1, double p2)
        {
            _result = _calculator.AverageExpectedFailures(p0, p1, p2);
        }

        [Then(@"the average number of expected failures should be ""(.*)""")]
        public void ThenTheAverageNumberOfExpectedFailuresShouldBeOnTheScreen(double p0)
        {
            Assert.That(Math.Round(_result, 0), Is.EqualTo(p0));
        }
    }
}
