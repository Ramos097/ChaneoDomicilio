using ChaneoDomicilio.Models;

namespace ChaneoDomicilio.DB
{
    public class BaseDatos
    {
        public static List<Models.Empleado> Empleados { get; set; } = new List<Models.Empleado>();
        public static List<Models.Vehiculo> Vehiculos { get; set; } = new List<Models.Vehiculo>();
    }
}
