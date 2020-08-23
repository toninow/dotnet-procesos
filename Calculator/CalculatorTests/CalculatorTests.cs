using NUnit.Framework;
//using TestClass = NUnit.Framework.TestFixtureAttribute;
using TestMethod = NUnit.Framework.TestAttribute;

namespace CalculatorTests
{
    public class CalculatorTests
    {
        [Reference]
        [TestMethod]
        public void SumaDeDosNumerosPositivos()
        {
            var calculadora = new Calculator();
            //triple a - arrange= prepara - act= ejecuta - assert= verifica
            var numero1 = 65;
            var numero2 = 13;

            var esperado = 78;

            var resultado = calculadora.Add(numero1, numero2);
            Assert.AreEqual(resultado, esperado);  
            
        }
        [TestMethod]
        public void SumaDeDosNumerosNegativos()
        {
            var calculadora = new Calculator();
            //triple a - arrange= prepara - act= ejecuta - assert= verifica
            var numero1 = -43;
            var numero2 = -11;

            var esperado = -53;

            var resultado = calculadora.Add(numero1, numero2);
            Assert.AreEqual(resultado, esperado);  
            

        }
        [TestMethod]
        public void SumaDeUnNumeroPositivoYNegativo()
        {
            var calculadora = new Calculator();
            //triple a - arrange= prepara - act= ejecuta - assert= verifica
            var numero1 = 28;
            var numero2 = -74;

            var esperado = -46;

            var resultado = calculadora.Add(numero1, numero2);
            Assert.AreEqual(resultado, esperado);  
            

        }
    }
}