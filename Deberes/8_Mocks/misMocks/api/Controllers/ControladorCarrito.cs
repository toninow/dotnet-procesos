using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Services;

namespace api.Controllers
{
  [ApiController]
  [Route("[controller]")]
  public class ControladorCarrito 
  {
    private readonly IServicioCarrito _servicioCarrito;
    private readonly IServicioPago _servicioPago;
    private readonly IServicioEnvio _servicioEnvio;
    
    public ControladorCarrito(
      IServicioCarrito servicioCarrito,
      IServicioPago servicioPago,
      IServicioEnvio servicioEnvio
    ) 
    {
      _servicioCarrito = servicioCarrito;
      _servicioPago = servicioPago;
      _servicioEnvio = servicioEnvio;
    }

    [HttpPost]
    public string CheckOut(ITarjeta tarjeta, IDireccion direccion) 
    {
        var result = _servicioPago.Charge(_servicioCarrito.Total(), tarjeta);
        if (result)
        {
            _servicioEnvio.Ship(direccion, _servicioCarrito.Items());
            return "Servicio Aceptado";
        }
        else {
            return "Servicio no Aceptado";
        }
    }
  }
}
