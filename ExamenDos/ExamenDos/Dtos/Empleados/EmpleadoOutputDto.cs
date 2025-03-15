namespace ExamenDos.Dtos.Empleado
{
    public class EmpleadoOutputDto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Documento { get; set; }
        public DateTime FechaContratacion { get; set; }
        public string Departamento { get; set; }
        public string PuestoTrabajo { get; set; }
        public double SalarioBase { get; set; }
        public bool Activo { get; set; }

    }
}
