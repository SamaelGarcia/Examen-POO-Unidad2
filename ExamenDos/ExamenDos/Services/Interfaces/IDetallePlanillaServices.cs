using ExamenDos.Dtos.DetallesPlanilla;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ExamenDos.Services.Interfaces
{
    public interface IDetallePlanillaServices
    {
        Task<List<DetallePlanillaOutputDto>> GetDetallesByPlanillaIdAsync(int planillaId);
        Task<DetallePlanillaOutputDto> GetDetalleByIdAsync(int id);
        Task CreateDetalleAsync(DetallePlanillaInputDto detalleInputDto);
        Task UpdateDetalleAsync(int id, DetallePlanillaEditDto detalleEditDto);
        Task DeleteDetalleAsync(int id);
        Task<List<DetallePlanillaOutputDto>> GetDetallesByEmpleadoIdAsync(int empleadoId);
    }
}