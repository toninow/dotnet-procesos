using NUnit.Framework;
using TestClass = NUnit.Framework.TestFixtureAttribute;
using TestMethod = NUnit.Framework.TestAttribute;

namespace QuickSort.Test
{
    [TestClass]
    public class Tests
    {
        [TestMethod]
        public void OrdenarSeleccionados()
        
        {
            //arrange
            int izquierda = 0;
            int derecha = 0;
             //arreglo de tipo entero con 
            var numerosRandomicos = new int[] { 2, 5, -4, 11, 0, 18, 22, 67, 51, 6 };
            //Esperamos los numeros ordenados de la siguiente manera
            var numerosRandomicosOrdenados = new [] {-4, 0, 2, 5, 6, 11, 18, 22, 51, 67 };
            //act
            var numerosDefinidos = QuickOrder.OrdenarSeleccionados(numerosRandomicos, izquierda, derecha);
            //assert
            CollectionAssert.AreEqual((System.Collections.ICollection)numerosDefinidos, numerosRandomicos);
        }
    }
}