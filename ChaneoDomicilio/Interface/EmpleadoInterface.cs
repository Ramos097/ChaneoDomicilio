using ChaneoDomicilio.Models;

namespace ChaneoDomicilio.Interface
{
    public interface EmpleadoInterface
    {
        List<Empleado> ObtenerEmpleado();
        Empleado ObtenerEmpleadoPorCedula(string Cedula);
        void CrearEmpleado(Empleado empleado);
        void ActualizarEmpleado(string Cedula, Empleado empleadoActualizado);   
        void EliminarEmpleado(string Cedula);
        bool EmpleadoExistente(string Cedula);
    }
}
