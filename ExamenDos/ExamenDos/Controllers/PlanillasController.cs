using ExamenDos.Dtos.Planillas;
using ExamenDos.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ExamenDos.Controllers
{
    [Route("api/planillas")]
    [ApiController]
    public class PlanillasController : ControllerBase
    {
        private readonly IPlanillaServices _planillaServices;

        public PlanillasController (IPlanillaServices planillaServices) 
        {
            _planillaServices = planillaServices;
        }

        [HttpPost]
        public async Task<IActionResult> CreatePlanilla([FromBody]PlanillaInputDto loanInput)
        {
            var result = await _planillaServices.CreatePlanillaAsync(loanInput);
            return Ok(result);
        }

    }
}
