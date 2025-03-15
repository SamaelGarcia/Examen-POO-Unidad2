namespace ExamenDos.Dtos.DetallesPlanilla
{
    public class DetallePlanillaInputDto
    {
        public int PlanillaId { get; set; }
        public int EmpleadoId { get; set; }
        public double SalarioBase { get; set; }
        public double HorasExtra { get; set; }
        public double MontoHorasExtra { get; set; }
        public double Bonificaciones { get; set; }
        public double Deducciones { get; set; }
        public double SalarioNeto { get; set; } 
        public string Comentarios { get; set; }
    }
}
