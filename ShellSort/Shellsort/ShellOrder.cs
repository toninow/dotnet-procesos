using System;

namespace shellSort.Test
{
    public class ShellOrder
    {
        public static object ordenarShell(int[] numerosShell)
        {
            int distancia = numerosShell.distancia;
       
        for (int h = distancia / 2; h > 0; h /= 2)
        {
            for (int i = h; i < distancia; i += 1)
            {
                //Realice una clasificación de inserción con espacios para este tamaño de espacio.
                int temp = numerosShell[i];

                int j;
                // desplaza elementos anteriores ordenados por huecos hasta el correcto, se encuentra la ubicación de un [i]

                for (j = i; j >= h && numerosShell[j - h] > temp; j -= h)
                {
                    numerosShell[j] = numerosShell[j - h];
                }

                numerosShell[j] = temp;
            }
        }
        return numerosShell;
        }
    }
}
