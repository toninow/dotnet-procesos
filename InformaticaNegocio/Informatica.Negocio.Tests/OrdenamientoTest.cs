using NUnit.Framework;
using System.Collections.Generic;
using TestClass = NUnit.Framework.TestFixtureAttribute;
using TestMethod = NUnit.Framework.TestAttribute;

namespace Informatica.Negocio.Tests
{
    [TestClass]
    public class OrdenamientoTest
    {
        [TestMethod]
        public void TresElementos()
        {
            //triple a - arrange= prepara - ejecuta - verifica

            var primero = 45;
            var segundo = 23;
            var tercero = 15;

            var esperado0 = 15; //primer valor

            var esperado1 = 23;  //segundo valor

            Ordenamiento ordenamiento = new Ordenamiento();
            List<int> esperados = ordenamiento.Ordenar(primero, segundo, tercero);
            Assert.AreEqual(esperado0, esperados[0]);
            Assert.AreEqual(esperado1, esperados[1]);

        }

        [TestMethod]
        public void TresElementosConNegativos()
        {
            //triple a - arrange= prepara - ejecuta - verifica

            var primero = 45;
            var segundo = -23;
            var tercero = 15;

            var esperado0 = -23; //primer valor

            var esperado1 = 15;  //segundo valor

            Ordenamiento ordenamiento = new Ordenamiento();
            List<int> esperados = ordenamiento.Ordenar(primero, segundo, tercero);
            Assert.AreEqual(esperado0, esperados[0]);
            Assert.AreEqual(esperado1, esperados[1]);

        }

        [TestMethod]
        public void TresElementosTodasCondiciones()
        {
            //triple a - arrange= prepara - ejecuta - verifica

            //a b c
            //a c b
            //b a c
            //b c a
            //c b a
            //c a b
        }

        [TestMethod]
        public SumaDeDosNumerosPositivos()
        {
            var calculo = new Calculator();


            var numero1 = 65;
            var numero2 = 12;
            var esperado = 77;

            var resultado = calculo.Add(numero1, numero2);
            Assert.AreEqual(esperado, resultado);

        }
    }
}