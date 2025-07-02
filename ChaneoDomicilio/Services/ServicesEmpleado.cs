using ChaneoDomicilio.DB;
using ChaneoDomicilio.Models;
using ChaneoDomicilio.Interface;

namespace ChaneoDomicilio.Services
{
    public class ServiceEmpleados : EmpleadoInterface
    {
        public void ActualizarEmpleado(string Cedula, Empleado empleadoActualizado)
        {
            Empleado empleadoExistente = BaseDatos.Empleados.FirstOrDefault(empleado => empleado.Cedula == Cedula);

            if (empleadoExistente == null)
            {
                throw new ArgumentException("El empleado no existe.");
            }

            empleadoExistente.FechaNacimiento = empleadoActualizado.FechaNacimiento;
            empleadoExistente.IngresoEmpresa = empleadoActualizado.IngresoEmpresa;
            empleadoExistente.SalarioDiario = empleadoActualizado.SalarioDiario;
            empleadoExistente.VacacionesAcumulado = empleadoActualizado.VacacionesAcumulado;
            empleadoExistente.FechaRetiro = empleadoActualizado.FechaRetiro;
            empleadoExistente.Liquidacion = empleadoActualizado.Liquidacion;
        }

        public void CrearEmpleado(Empleado empleado)
        {
            if (EmpleadoExistente(empleado.Cedula))
            {
                throw new ArgumentException("La cédula ya está registrada.");
            }

            BaseDatos.Empleados.Add(empleado);
        }

        public void EliminarEmpleado(string Cedula)
        {
            BaseDatos.Empleados.RemoveAll(empleado => empleado.Cedula == Cedula);
        }

        public Empleado ObtenerEmpleadoPorCedula(string Cedula)
        {
            return BaseDatos.Empleados.FirstOrDefault(empleado => empleado.Cedula == Cedula);
        }

        public List<Empleado> ObtenerEmpleado()
        {
            return BaseDatos.Empleados;
        }

        public bool EmpleadoExistente(string Cedula)
        {
            return BaseDatos.Empleados.Any(empleado => empleado.Cedula == Cedula);
        }
    }
}
