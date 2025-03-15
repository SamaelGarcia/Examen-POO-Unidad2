using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExamenDos.Database.Entities
{
    public class DetallePlanillaEntity
    {
        [Key]
        [Column("id")]
        public int id { get; set; }

        [Column("planilla_id")]
        public int PlanillaId { get; set; }
        [ForeignKey(nameof(PlanillaId))]
        public virtual PlanillaEntity Planilla { get; set; }

        [Column("empleado_id")]
        public int EmpleadoId { get; set; }
        [ForeignKey(nameof(EmpleadoId))]
        public virtual EmpleadoEntity Empleado { get; set; }

        [Column("salario_base")]
        public double SalarioBase { get; set; }
        [Column("horas_extra")]
        public double HorasExtra { get; set; }
        [Column("monto_horas_extra")]
        public double MontoHorasExtra { get; set; }
        [Column("bonificaciones")]
        public double Bonificaciones { get; set; }
        [Column("deducciones")]
        public double Deducciones { get; set; }
        [Column("salario_neto")]
        public double SalarioNeto { get; set; }
        [Column("comentarios")]
        public string Comentarios { get; set; }
    }
}

/*
● Id (int, clave primaria)
● PlanillaId (int, clave foránea)
● EmpleadoId (int, clave foránea)
● SalarioBase (decimal)
● HorasExtra (decimal)
● MontoHorasExtra (decimal)
● Bonificaciones (decimal)
● Deducciones (decimal)
● SalarioNeto (decimal)
● Comentarios (string)
 */