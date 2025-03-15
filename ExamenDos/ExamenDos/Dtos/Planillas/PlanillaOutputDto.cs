namespace ExamenDos.Dtos.Planillas
{
    public class PlanillaOutputDto
    {
        public int Id { get; set; }
        public string Periodo { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaPago { get; set; }
        public string Estado { get; set; }
    }
}
