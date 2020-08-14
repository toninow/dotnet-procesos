
using TechTalk.SpecFlow;

namespace MyProject.Specs.Steps
{
    [Binding]
    public class CalculatorSteps
    {
        Calculadora _calculadora = new Calculadora();
        int resultado;

        [Given(@"the first number is (.*)")]
        public void GivenTheFirstNumberIs(int number)
        {
            _calculadora.PrimerNumero = number;
        }

        [Given(@"the second number is (.*)")]
        public void GivenTheSecondNumberIs(int number)
        {
            _calculadora.SegundoNumero = number;
        }

        [When(@"the two numbers are added")]
        public void WhenTheTwoNumbersAreAdded()
        {
            resultado = _calculadora.suma();
        }

        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBe(int expectedResult)
        {
            Assert.AreEqual(resultado, expectedResult);
            
        }
    }
}
