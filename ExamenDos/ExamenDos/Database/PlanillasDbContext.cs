using ExamenDos.Database.Entities;
using Microsoft.EntityFrameworkCore;

namespace ExamenDos.Database
{
    public class PlanillasDbContext : DbContext
    {
        public PlanillasDbContext(DbContextOptions Options) : base(Options) { }

        public DbSet<EmpleadoEntity> Empleados { get; set; }
        public DbSet<PlanillaEntity> Planillas { get; set; }
        public DbSet<DetallePlanillaEntity> DetallePlanillas { get; set; }  

    }
}
