using System;

namespace Matematica.Test
{
    internal class Calculadora
    {

        internal int[,] Multiplicar(int[,] matrizA, int[,] matrizB)
        {
            int matACols = matrizA.GetLength(1);
            int matBCols = matrizB.GetLength(1);
            int matARows = matrizA.GetLength(0);
            int[,] resultado = new int [matARows, matACols];

            for (int i = 0; i < matARows; i++)
            {
                for (int j = 0; j < matBCols; j++)
                {
                    int temp = 0;
                    for (int k = 0; k < matACols; k++)
                    {
                    temp += matrizA[i, k] * matrizB[k, j];
                    }
                    resultado[i, j] += temp;
                }
            }
            return resultado;
        }
    }
}