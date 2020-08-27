using System;

namespace Empleados
{
    class Program
    {
        //aqui se ejecutario el id obtenido en la aplicacion de consola
        static void Main(string[] args)
        {
            //llamo a mis clases del empleado contexto y empleado proveedor 
            var empleadoContexto = new EmpleadoContexto(@"Persist Security Info = False; Integrated Security = true; Initial Catalog = TimeManagement; server = Nirjhar-Tab\SQLEXPRESS");
            var empleadoProveedor = new EmpleadoProveedor(empleadoContexto);
            
            //de la tabla employee llamo los siguientes campos
            var employee = empleadoProveedor.Get(1);
            //mediante el id obtenido se mostraría en la consola
            Console.WriteLine($"Name: {employee.FirstName} {employee.LastName}, Address: {employee.Address}");
        }
    }
}
