using System.ComponentModel.DataAnnotations.Schema;

namespace Empleados
{
    //tabla empleado con los campos respectivos
    [Table("Employee")]
    public class Empleado
    {
        public int Id { get; set; }
        [Column("first_name")]
        public string FirstName { get; set; }
        [Column("last_name")]
        public string LastName { get; set; }
        public string Address { get; set; }
        [Column("home_phone")]
        public string HomePhone { get; set; }
        [Column("cell_phone")]
        public string CellPhone { get; set; }
    }
}
