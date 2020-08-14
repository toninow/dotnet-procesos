using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Matematica.Test
{
    [TestClass]
    public class CuandoMultiplicoMatricesTest
    {
        [TestMethod]
        public void SiMaTrizA3x2YMatrizB3x4EntoncesMatruzAXB3X4()
        {
            int filas = 1000;
            int columnas = 1000;
            int intermedio = 500;

            //int[,] matrizA = new int[filas,intermedio];
            //int[,] matrizB = new int[filas,columnas];

            int[,] matrizA = Calculadora.CrearMatriz[filas,intermedio];
            int[,] matrizB = Calculadora.CrearMatriz[filas,intermedio];

            Calculadora calculadora = new Calculadora();
            int[,] matrizAxB = calculadora.Multiplicar(matrizA, matrizB); 

            Assert.AreEqual(filas,matrizAxB.GetLength(0));
            Assert.AreEqual(columnas,matrizAxB.GetLength(1));
        }

        [TestMethod]
        public void EnParaleloEsMasRapidoQueEnSecuencia()
        {
            Stopwatch stopwatch = new Stopwatch();
            
            stopwatch.Start();
            // to do: tu código va aqui
            Calculadora.Multiplicar(matrizA, matrizB);

            stopwatch.Stop();
            //
            var paralelo = stopwatch.ElapsedTicks;

            

            Stopwatch stopwatch1 = new Stopwatch();
            stopwatch1.Start();
            // to do: tu código va aqui

            stopwatch1.Stop();
            

        }
    }
}
