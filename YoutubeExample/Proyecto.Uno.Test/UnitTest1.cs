using NUnit.Framework;
using TestClass = NUnit.Framework.TestFixtureAttribute;
using TestMethod = NUnit.Framework.TestAttribute;

namespace Proyecto.Uno.Test
{
    [TestClass]
    public class ComparadorTest
    {
        [TestMethod]
        public void ObtenerELNumeroMenor()
        {

            //Arrange
            var numeroUno = 96;
            var numeroDos = 35;
            var numeroEsperado =35;
            //Act
            Comparador compararNUmeros = new Comparador();
            int VerificarLosNumeros = compararNUmeros.ObtenerELNumeroMenor(numeroUno, numeroDos);
            //Assert
            Assert.AreEqual(numeroEsperado, VerificarLosNumeros);
            

        }

       
    }
}