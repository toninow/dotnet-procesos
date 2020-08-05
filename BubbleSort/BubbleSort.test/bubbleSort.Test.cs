using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace bubbleSort.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //arrange
            int cuerentaycuatro= 44;
            int dieciocho= 18;
            int quince= 15;
            int cinco= 5;
            int siete= 7;
            int cientouno= 101;
            int setentayocho= 78;
            int uno= 1;
            //arreglo de tipo entero
            var numerosAleatorios = new int[] {cuerentaycuatro, dieciocho, quince, cinco, siete, cientouno, setentayocho, uno  };
            var numerosOrdenados = new [] {uno, cinco, siete, quince, dieciocho, cuerentaycuatro, setentayocho, cientouno};
            //act
            var misNumeros = BubbleOrder.ordenarSeleccionados(numerosAleatorios);
            //assert
            CollectionAssert.AreEqual((System.Collections.ICollection)misNumeros, numerosAleatorios);
        }
    }
}
