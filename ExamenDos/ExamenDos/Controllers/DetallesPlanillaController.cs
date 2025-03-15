using ExamenDos.Dtos.DetallesPlanilla;
using ExamenDos.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ExamenDos.Controllers
{
    [Route("api/detallesplanilla")]
    [ApiController]
    public class DetallesPlanillaController : ControllerBase
    {
        private readonly IDetallePlanillaServices _detallePlanillaServices;

        public DetallesPlanillaController(IDetallePlanillaServices detallePlanillaServices)
        {
            _detallePlanillaServices = detallePlanillaServices;
        }

        [HttpGet("planilla/{planillaId}")]
        public async Task<IActionResult> GetDetallesByPlanillaId(int planillaId)
        {
            var detalles = await _detallePlanillaServices.GetDetallesByPlanillaIdAsync(planillaId);
            return Ok(detalles);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetDetalleById(int id)
        {
            var detalle = await _detallePlanillaServices.GetDetalleByIdAsync(id);
            return Ok(detalle);
        }

        [HttpPost]
        public async Task<IActionResult> CreateDetalle([FromBody] DetallePlanillaInputDto detalleInputDto)
        {
            await _detallePlanillaServices.CreateDetalleAsync(detalleInputDto);
            return Ok("Detalle creado correctamente.");
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateDetalle(int id, [FromBody] DetallePlanillaEditDto detalleEditDto)
        {
            await _detallePlanillaServices.UpdateDetalleAsync(id, detalleEditDto);
            return Ok("Detalle actualizado correctamente.");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDetalle(int id)
        {
            await _detallePlanillaServices.DeleteDetalleAsync(id);
            return Ok("Detalle eliminado correctamente.");
        }

        [HttpGet("empleado/{empleadoId}")]
        public async Task<IActionResult> GetDetallesByEmpleadoId(int empleadoId)
        {
            var detalles = await _detallePlanillaServices.GetDetallesByEmpleadoIdAsync(empleadoId);
            return Ok(detalles);
        }
    }
}