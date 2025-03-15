using System.ComponentModel.DataAnnotations;

namespace ExamenDos.Dtos.Empleado
{
    public class EmpleadoInputDto
    {
        [Required]
        public string Nombre { get; set; }
        [Required]
        public string Apellido { get; set; }
        [Required]
        public string Documento { get; set; }
        public DateTime FechaContratacion { get; set; }
        public string Departamento { get; set; }
        public string PuestoTrabajo { get; set; }
        public double SalarioBase { get; set; }
        public bool Activo { get; set; }
    }
}
