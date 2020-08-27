using System.Collections.Generic;


namespace Services
{
    public interface IServicioCarrito
    {
    double Total();
    IEnumerable<ItemsTarjeta> Items();
  }
}