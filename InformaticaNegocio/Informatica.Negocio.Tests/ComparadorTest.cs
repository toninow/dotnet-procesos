
using NUnit.Framework;
using TestClass = NUnit.Framework.TestFixtureAttribute;
using TestMethod = NUnit.Framework.TestAttribute;

namespace Informatica.Negocio.Tests
{
    [TestClass]
    public class ComparadorTest
    {
        [TestMethod]
        public void ObtenerMenor()
        {
            //AAA ==> Arrange // Act // Assert

            //Order data  = Arrange
            var primerElemento = 56;
            var segundoElemento = 20;
            var esperado = 20;
            //execute = ACt
            Comparador comparador = new Comparador();
            int actual = comparador.ObtenerMenor(primerElemento,segundoElemento);
            
            //Prove = Assert
            Assert.AreEqual(esperado, actual);
            
        }


        [TestMethod]
        public void ObtenerMayor()
        {
            //AAA ==> Arrange // Act // Assert

            //Order data  = Arrange
            var primerElemento = 56;
            var segundoElemento = 20;
            var esperado = 56;
            //execute = ACt
            Comparador comparador = new Comparador();
            int actual = comparador.ObtenerMayor(primerElemento,segundoElemento);
            
            //Prove = Assert
            Assert.AreEqual(esperado, actual);
            
        }
    }
}

