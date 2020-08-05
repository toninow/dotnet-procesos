using NUnit.Framework;
using TestClass = NUnit.Framework.TestFixtureAttribute;
using TestMethod = NUnit.Framework.TestAttribute;

namespace heapSort.Test
{
    [TestClass]
    public class Tests
    {
        [TestMethod]
        public void Setup()
        {
        
        /**
        int dos = 2;
        int cinco = 5;
        int menoscinco= 4;
        int doce= 12;
        int cero= 0;
        int veinte= 20;
        int veinteycinco= 25;
        int sesentaynueve= 69;
        int setecientosuno= 701;
        int[] llaves = new int[] {dos, cinco, menoscinco, doce, cero, veinte, veinteycinco, sesentaynueve, setecientosuno };
        **/
        var arreglo = new int[] { -1, 25, -58964, 8547, -119, 0, 78596 };;

        var resultado = new [] {-58964, -119, -1025, 8547, 78596};
        
        //var Ordenados = new [] {};        

        var orden = HeapSortOrder.Ordenarlos(arreglo);
        //assert
        CollectionAssert.AreEqual((System.Collections.ICollection)orden, arreglo);
        }

        
    }
}