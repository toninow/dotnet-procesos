using System;

namespace Informatica.Negocio
{
    public class Comparador
    {
        public int ObtenerMenor(int primerElemento, int segundoElemento)
        {
            //refact this code
            
            /**if (primerElemento < segundoElemento)
                
                return primerElemento;
            
            else 

                return segundoElemento; **/

            //ternarios
            return primerElemento < segundoElemento ? primerElemento :segundoElemento;
        }

        public int ObtenerMayor(int primerElemento, int segundoElemento)
        {
            //ternarios
            return primerElemento > segundoElemento ? primerElemento :segundoElemento;
        }
    }
}
