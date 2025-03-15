using ExamenDos.Dtos.Planillas;

namespace ExamenDos.Services.Interfaces
{
    public interface IPlanillaServices
    {
        Task<PlanillaOutputDto> CreatePlanillaAsync(PlanillaInputDto planillaInputDto);
    }
}
