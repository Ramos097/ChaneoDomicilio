using ChaneoDomicilio.DB;
using ChaneoDomicilio.Models;

namespace ChaneoDomicilio.Services
{
    public class ServiceVehiculo
    {
        public void CrearVehiculo(Vehiculo vehiculo)
        {
            BaseDatos.Vehiculos.Add(vehiculo);
        }
    }
}
