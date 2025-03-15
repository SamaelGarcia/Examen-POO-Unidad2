using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExamenDos.Migrations
{
    /// <inheritdoc />
    public partial class InitPlanillas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Empleados",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    nombre = table.Column<string>(type: "TEXT", nullable: false),
                    apellido = table.Column<string>(type: "TEXT", nullable: false),
                    documento = table.Column<string>(type: "TEXT", nullable: false),
                    fecha_contratacion = table.Column<DateTime>(type: "TEXT", nullable: false),
                    departamento = table.Column<string>(type: "TEXT", nullable: true),
                    puesto_trabajo = table.Column<string>(type: "TEXT", nullable: true),
                    salario_base = table.Column<double>(type: "REAL", nullable: false),
                    activo = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empleados", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Planillas",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    periodo = table.Column<string>(type: "TEXT", nullable: false),
                    fecha_creacion = table.Column<DateTime>(type: "TEXT", nullable: false),
                    fecha_pago = table.Column<DateTime>(type: "TEXT", nullable: false),
                    estado = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Planillas", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "DetallePlanillas",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    planilla_id = table.Column<int>(type: "INTEGER", nullable: false),
                    empleado_id = table.Column<int>(type: "INTEGER", nullable: false),
                    salario_base = table.Column<double>(type: "REAL", nullable: false),
                    horas_extra = table.Column<double>(type: "REAL", nullable: false),
                    monto_horas_extra = table.Column<double>(type: "REAL", nullable: false),
                    bonificaciones = table.Column<double>(type: "REAL", nullable: false),
                    deducciones = table.Column<double>(type: "REAL", nullable: false),
                    salario_neto = table.Column<double>(type: "REAL", nullable: false),
                    comentarios = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetallePlanillas", x => x.id);
                    table.ForeignKey(
                        name: "FK_DetallePlanillas_Empleados_empleado_id",
                        column: x => x.empleado_id,
                        principalTable: "Empleados",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DetallePlanillas_Planillas_planilla_id",
                        column: x => x.planilla_id,
                        principalTable: "Planillas",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DetallePlanillas_empleado_id",
                table: "DetallePlanillas",
                column: "empleado_id");

            migrationBuilder.CreateIndex(
                name: "IX_DetallePlanillas_planilla_id",
                table: "DetallePlanillas",
                column: "planilla_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DetallePlanillas");

            migrationBuilder.DropTable(
                name: "Empleados");

            migrationBuilder.DropTable(
                name: "Planillas");
        }
    }
}
