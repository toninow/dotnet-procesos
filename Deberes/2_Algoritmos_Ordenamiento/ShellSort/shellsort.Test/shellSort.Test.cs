using NUnit.Framework;
using TestClass = NUnit.Framework.TestFixtureAttribute;
using TestMethod = NUnit.Framework.TestAttribute;


namespace shellSort.Test
{
    [TestClass]
    public class Tests
    {
        [TestMethod]
        public void Setup()
        {
            //arrange
            int catorce = 14;
            int siete = 7;
            int menostres= -3;
            int dos= 2;
            int veinteycinco= 25;
            int menosdiez = -10;
            var numerosShell = new int[] {catorce, siete, menostres, dos, veinteycinco, menosdiez};
            var numerosShellOrdenados = new[] {menosdiez, menostres, dos, siete, catorce, veinteycinco};
            //act
           
            var misSHells = ShellOrder.ordenarShell(numerosShell);
            //assert
            CollectionAssert.AreEqual((System.Collections.IEnumerable)misSHells, numerosShell);

        }

    }
}