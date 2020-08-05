using System;

namespace bubbleSort.Test
{
    public class BubbleOrder
    {
        public static object ordenarSeleccionados(int[] numerosAleatorios)
        {
            int numerosParaOrdenar = numerosAleatorios.Length;
            // Ejecuta bucles dos veces: uno para recorrer la matriz y el otro para comparar
            for(int count = 0; count < numerosParaOrdenar-1; count++ ){
                for (int i = 0; i< numerosParaOrdenar -1; i++ )
                    //intercambio de posiciones 
                    if (numerosAleatorios[i] > numerosAleatorios[i + 1]){
                        int final = numerosAleatorios[i];
                        numerosAleatorios[i] = numerosAleatorios [i + 1];
                        numerosAleatorios [i + 1] = final;
                    }
            }    
            return numerosAleatorios;
        }
    }
}