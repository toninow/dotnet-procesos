using System;

namespace QuickSort.Test
{
    public class QuickOrder
    {
        public static object OrdenarSeleccionados(int[] numerosRandomicos,int izquierda, int derecha)
        {
            //el valor de pivote se usa para dividir la matriz; y, en una matriz sin clasificar
            int i = izquierda;
            int pivot = numerosRandomicos[derecha];
            int temp;
            //a la izquierda del valor del pivote, mueva cualquier cosa mayor que el pivote, o a la derecha del pivote
            for(int j = izquierda; j <=derecha; j++)
            {
            if(numerosRandomicos[j] < pivot)
            {
                temp = numerosRandomicos[i];
                numerosRandomicos[i] = numerosRandomicos[j];
                numerosRandomicos[j] = temp;
                i++;
            }
            }

            temp = numerosRandomicos[derecha];
            numerosRandomicos[derecha] = numerosRandomicos[i];
            numerosRandomicos[i] = temp;
            return numerosRandomicos;
        }

        //toma 3 parámetros: matriz [], inicio de entero, final de entero
        public static void OrdenamientoRapido(int[] numerosRandomicos, int izquierda, int derecha) 
        {
            if (izquierda < derecha)
            { 
            int pivot = (int)OrdenarSeleccionados(numerosRandomicos, izquierda, derecha);
            OrdenamientoRapido(numerosRandomicos, izquierda, pivot-1);
            OrdenamientoRapido(numerosRandomicos, pivot+1, derecha);
            }
        }
        
    }
}