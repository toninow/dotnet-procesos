using System;
using System.Collections.Generic;

namespace Informatica.Negocio
{
    public class Ordenamiento
    {
        public List<int> Ordenar(int primero, int segundo, int tercero)
        {
            var resultado = new List<int>();

            if (primero <= segundo)
            {
                if (primero <= tercero)
                {
                    resultado.Add(primero);
                    if (segundo <= tercero)
                    {
                       resultado.Add(segundo); 
                       resultado.Add(tercero); 
                    }
                    else
                    {
                       resultado.Add(tercero); 
                       resultado.Add(segundo); 
                    }
                }
                else
                {
                    resultado.Add(tercero);
                    if (segundo <= primero)
                    {
                       resultado.Add(segundo); 
                       resultado.Add(primero); 
                    }
                    else
                    {
                        resultado.Add(primero); 
                       resultado.Add(segundo); 
                    }
                }
            }
            else
            {
                if (segundo <= tercero)
                {
                    resultado.Add(segundo);
                    if (primero <= tercero)
                    {
                       resultado.Add(primero); 
                       resultado.Add(tercero); 
                    }
                    else
                    {
                       resultado.Add(tercero); 
                       resultado.Add(primero); 
                    }
                }
                else
                {
                    resultado.Add(tercero);
                    if (primero <= segundo)
                    {
                       resultado.Add(primero); 
                       resultado.Add(segundo); 
                    }
                    else
                    {
                       resultado.Add(segundo); 
                       resultado.Add(primero); 
                    }
                }
            }

            return resultado;

        }
    }
}
