using Microsoft.AspNetCore.Mvc;
using ExamenDos.Dtos.Empleado;
using ExamenDos.Services.Interfaces;

namespace ExamenDos.Controllers
{
    [Route("api/empleados")]
    [ApiController]
    public class EmpleadosController : ControllerBase
    {
        private readonly IEmpleadosServices _empleadosServices;

        public EmpleadosController(IEmpleadosServices empleadosServices)
        {
            _empleadosServices = empleadosServices;
        }

        [HttpGet]
        public async Task<IActionResult> GetEmpleados()
        {
            var empleados = await _empleadosServices.GetEmpleadosAsync();
            return Ok(empleados);
        }
    }
}
