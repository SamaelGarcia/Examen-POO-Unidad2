using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExamenDos.Database.Entities
{
    public class PlanillaEntity
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("periodo")]
        [Required]
        public string Periodo { get; set; } // Ejemplo: "Marzo 2025"
        [Column("fecha_creacion")]
        public DateTime FechaCreacion { get; set; }
        [Column("fecha_pago")]
        public DateTime FechaPago { get; set; }
        [Column("estado")]
        public string Estado { get; set; } // "Pendiente", "Pagada", "Anulada"

    }
}

/*
● Id (int, clave primaria)
● Periodo (string, requerido) - Ejemplo: "Marzo 2025"
● FechaCreacion (DateTime)
● FechaPago (DateTime)
● Estado (string) - "Pendiente", "Pagada", "Anulada"
 */