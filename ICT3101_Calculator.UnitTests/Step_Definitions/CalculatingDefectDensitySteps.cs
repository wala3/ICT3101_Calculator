using System;
using TechTalk.SpecFlow;
using NUnit.Framework;

namespace ICT3101_Calculator.UnitTests.Step_Definitions
{
    [Binding]
    public class CalculatingDefectDensitySteps
    {
        private Calculator _calculator;
        public CalculatingDefectDensitySteps(Calculator calc)
        {
            this._calculator = calc;
        }

        private double _result;

        [When(@"number of defects is ""(.*)"" and the program has ""(.*)"" KLOC")]
        public void WhenIHaveEnteredIntoTheCalculatorAndPressDefectDensity(double p0, double p1)
        {
            _result = _calculator.DefectDensity(p0, p1);
        }

        [Then(@"the defect density should be ""(.*)"" defects/KLOC")]
        public void ThenTheDefectDensityShouldBeOnTheScreen(double p0)
        {
            Assert.That(_result, Is.EqualTo(p0));
        }

        [When(@"the previous SSI is ""(.*)"" KLOC and the CSI is ""(.*)"" KLOC and there are ""(.*)"" KLOC of changed code")]
        public void WhenIHaveEnteredIntoTheCalculatorAndPressNewSSI(double p0, double p1, double p2)
        {
            _result = _calculator.NewSSI(p0, p1, p2);
        }

        [Then(@"the new SSI should be ""(.*)"" KLOC")]
        public void ThenTheNewSSIShouldBeOnTheScreen(double p0)
        {
            Assert.That(_result, Is.EqualTo(p0));

        }
    }
}
