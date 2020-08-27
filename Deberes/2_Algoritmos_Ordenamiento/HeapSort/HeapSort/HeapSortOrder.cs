using System;

namespace heapSort.Test
{
    public class HeapSortOrder
    {
        public static object Ordenarlos(int[] arreglo)
        {
            int Incrementos = arreglo.Length;
            // extreae elementos uno por uno
            for (int p = (Incrementos - 1) / 2; p >= 0; --p)
                incrementable(ref arreglo, Incrementos, p);

            for (int i = arreglo.Length - 1; i > 0; --i)
            {
                int temp = arreglo[i];
                arreglo[i] = arreglo[0];
                arreglo[0] = temp;

                --Incrementos;
                incrementable(ref arreglo, Incrementos, 0);
            }
                return arreglo;
        }
        
        public static void incrementable(ref int[] datos, int Incrementos, int indice)
        {
            int izquierda = (indice + 1) * 2 - 1;
            int derecha = (indice + 1) * 2;
            int distancia = 0;

            // Si el izquierdo es más distancia que la raíz
            if (izquierda < Incrementos && datos[izquierda] > datos[indice])
                distancia = izquierda;
            else
                distancia = indice;
            // Si el derecho es más distancia que la raíz
            if (derecha < Incrementos && datos[derecha] > datos[distancia])
                distancia = derecha;
            // Si la distancia no está en la raiz 
            if (distancia != indice)
            {
                int temp = datos[indice];
                datos[indice] = datos[distancia];
                datos[distancia] = temp;

                incrementable(ref datos, Incrementos, distancia);
            }
        }

    }

}
