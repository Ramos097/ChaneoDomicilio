namespace ChaneoDomicilio.Models
{
    public class Empleado
    {
        public string Cedula { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public DateTime IngresoEmpresa { get; set; }
        public decimal SalarioDiario { get; set; }
        public int VacacionesAcumulado { get; set; }
        public DateTime FechaRetiro { get; set; }
        public decimal Liquidacion { get; set; }

    }
}
