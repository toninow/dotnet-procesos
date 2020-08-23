namespace Empleados
{
    //traemos el EMpleado con IEmpleadoProveedor
    public interface IEmpleadoProveedor
    {
        Empleado Get(int id);
    }
}