using System;

namespace Proyecto.Uno.Test
{
    public class Comparador
    {
        public int ObtenerELNumeroMenor(int numeroUno, int numeroDos)
        {
            /**if (numeroUno < numeroDos)
                return numeroUno;
            else 
                return numeroDos;**/
            
            //ternario
            return numeroUno < numeroDos ? numeroUno : numeroDos;
        }
    }
}