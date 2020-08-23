using Microsoft.EntityFrameworkCore;

//Esta clase se hereda de Microsoft.EntityFrameworkCore.DbContext, 
namespace Empleados
{
    //hacemos la llamada de la clase empleado Contexto con la tabla empleados
    //para otorgar seguridad esta clase conexión solo sera privada

    
    public class EmpleadoContexto : DbContext
    {
        private readonly string connectionString;
        //y recibirá a través de su constructor, las opciones de configuración para el DbContext. 
        public EmpleadoContexto(string connectionString)
        {
            this.connectionString = connectionString;
        }

        //Obtenemos la TABLA empleado en base a conexiones de la DB Empleado
        public EmpleadoContexto(DbContextOptions<EmpleadoContexto> options) : base(options)
        {
        }
        //definimos el modelo de datos con el que vamos a trabajar, get y set
        
        public DbSet<Empleado> Empleados { get; set; }

        //Como ya hemos registrado el DbContext como servicio, podremos obtener una instancia del mismo mediante 
        //inyección de dependencias, cualquier Controlador de nuestra aplicación dotnet Empleado
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(connectionString);
            }
        }
    }

}
