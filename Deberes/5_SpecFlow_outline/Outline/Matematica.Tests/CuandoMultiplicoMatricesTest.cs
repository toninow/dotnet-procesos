using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;
using System.Numerics;

namespace Matematica.Tests
{
    [TestClass]
    public class CuandoMultiplicoMatrices
    {
        [TestMethod]
        public void SiMatrizA3X2YMatrizB2X4EntoncesMatrizAXB3X4()
        {
            int filas = 3;
            int columnas = 4;
            int[,] matrizA = new int[filas, 2];
            int[,] matrizB = new int[2, columnas];

            Calculadora calculadora = new Calculadora();

            int[,] matrizAXB = calculadora.Multiplicar(matrizA, matrizB);

            Assert.AreEqual(filas, matrizAXB.GetLength(0));
            Assert.AreEqual(columnas, matrizAXB.GetLength(1));
        }

        [TestMethod]
        public void EnParaleloEsMasRapidoQueEnSecuencia()
        {

            int filas = 1000;
            int columnas = 1000;
            int interno = 500;
            int[,] matrizA = Calculadora.CrearMatriz(filas,interno);
            int[,] matrizB = Calculadora.CrearMatriz(interno, columnas);

            Calculadora calculadora = new Calculadora();

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            
            calculadora.Multiplicar(matrizA, matrizB);

            stopwatch.Stop();
            var secuencial = stopwatch.ElapsedTicks;

            Stopwatch stopwatch1 = new Stopwatch();
            stopwatch1.Start();
            
            calculadora.MultiplicarParalelo(matrizA, matrizB);

            stopwatch1.Stop();
            var paralelo = stopwatch1.ElapsedTicks;

            Assert.IsTrue(secuencial > paralelo);

        }


    }
}
