using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExamenDos.Database.Entities
{
    public class EmpleadoEntity
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("nombre")]
        [Required]
        public string Nombre { get; set; }
        [Column("apellido")]
        [Required]
        public string Apellido { get; set; }
        [Column("documento")]
        [Required]
        public string Documento { get; set; }
        [Column("fecha_contratacion")]
        public DateTime FechaContratacion { get; set; }
        [Column("departamento")]
        public string Departamento { get; set; }
        [Column("puesto_trabajo")]
        public string PuestoTrabajo { get; set; }
        [Column("salario_base")]
        public double SalarioBase { get; set; }
        [Column("activo")]
        public bool Activo {  get; set; }
    }
}

/*
● Id (int, clave primaria)
● Nombre (string, requerido)
● Apellido (string, requerido)
● Documento (string, requerido, único)
● FechaContratacion (DateTime)
● Departamento (string)
● PuestoTrabajo (string)
● SalarioBase (decimal)
● Activo (bool)
*/
