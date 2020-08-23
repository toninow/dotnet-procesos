using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework; 

namespace Empleados.Tests
{
    public class EmpleadosProveedorTests
    {
        [Test]
        public void ObtenerEmpleadoPorId()
        {
            //definir un objeto del tipo SqliteConnection, 
            //Las bases de datos en memoria se pueden compartir entre múltiples conexiones usando 
            //Mode = Memory y Cache = Shared en la cadena de conexión. 
            //La palabra Data Source se utiliza para dar un nombre a la base de datos en memoria.
            var connection = new SqliteConnection("DataSource=:memory:");
            connection.Open();

            //generamos el constructor de DbContextOptionsBuilder de contexto del empleado con El metodo 

            var options = new DbContextOptionsBuilder<EmpleadoContexto>().UseSqlite(connection).Options;

            //nos aseguramos que la conexion a la db del empleado se haya generado y que esta db exista
            using (var context = new EmpleadoContexto(options))
            {
                context.Database.EnsureCreated();
            }

            //arange
            //agregamos un empleado a la tabla de employees de la base de datos
            using (var context = new EmpleadoContexto(options))
            {
                context.Empleados.Add(new Empleado { Id = 1, FirstName = "John", LastName = "Doe", Address = "123 Street", HomePhone = "111-111-1111", CellPhone = "222-222-2222" });
                context.SaveChanges();
            }

            using (var context = new EmpleadoContexto(options))
            {
                var proveedor = new EmpleadoProveedor(context);
                //act
                //verifica trayendo al empleado ingresado por id con el metodo get(1) 
                var empleado = proveedor.Get(1);

                //asert se verifica que el nombre del empleado sea igual al de la db con el campo firstName
                Assert.AreEqual("John", empleado.FirstName);
            }
        }
    }
}