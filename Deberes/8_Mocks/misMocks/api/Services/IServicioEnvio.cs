
using System.Collections.Generic;

namespace Services
{
  public interface IServicioEnvio
  {
    void Ship(IDireccion info, IEnumerable<ItemsTarjeta> items);
  }
}
