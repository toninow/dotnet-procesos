using System;

namespace Calculo.Negocio
{
    public class Calculadora
    {
        public int PrimerNumero { get; set; }

        public int SegundoNumero { get; set; }

        public int Suma()
        {
            return PrimerNumero + SegundoNumero;
        }
    }
}
