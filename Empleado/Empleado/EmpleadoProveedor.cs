using System.Linq;

namespace Empleados
{
    //contexto significa toda la informacion general del empleado
    //llamamos a la clase del contexto del empleado y hacemos el get del empleado 
    public class EmpleadoProveedor : IEmpleadoProveedor
    {
        private readonly EmpleadoContexto empleadoContexto;

        //Como habiamos dicho se puede 
        public EmpleadoProveedor(EmpleadoContexto empleadoContexto)
        {
            this.empleadoContexto = empleadoContexto;
        }

        //obtenemos el empledo mediante el id en este caso el primero
        public Empleado Get(int id)
        {
            //Devuelve el primer elemento de una secuencia o un valor predeterminado si la secuencia no contiene elementos.
            return empleadoContexto.Empleados.Where(empleado => empleado.Id == id).FirstOrDefault();
        }
    }
}
