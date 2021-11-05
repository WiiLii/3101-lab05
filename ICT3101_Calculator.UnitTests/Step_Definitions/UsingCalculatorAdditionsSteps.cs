using System;
using TechTalk.SpecFlow;
using NUnit.Framework;

namespace ICT3101_Calculator.UnitTests.Step_Definitions
{
    public class CalculatorDetails
    {
        public Calculator calculator;
    }
    [Binding]
    public class UsingCalculatorAdditionsSteps
    {
        private double _result;

        private readonly CalculatorDetails calculatorDetails;
        public UsingCalculatorAdditionsSteps(CalculatorDetails calculatorDetails) // use it as ctor parameter
        {
            this.calculatorDetails = calculatorDetails;
        }

        [Given(@"I have a calculator")]
        public void GivenIHaveACalculator()
        {
            // Lab 2.1 Q13: With context injection
            calculatorDetails.calculator = new Calculator();
        }

        [When(@"I have entered ""(.*)"" and ""(.*)"" into the calculator and press add")]
        public void WhenIHaveEnteredAndIntoTheCalculator(double p0, double p1)
        {
            // Lab 2.1 Q8: Addition without context injection
            //_result = _calculator.Add(p0, p1);

            // Lab 2.1 Q13: Addition with context injection
            _result = calculatorDetails.calculator.Add(p0, p1);
        }
        [Then(@"the result should be ""(.*)""")]
        public void ThenTheResultShouldBeOnTheScreen(int p0)
        {
            Assert.That(_result, Is.EqualTo(p0));
        }

    }
}
