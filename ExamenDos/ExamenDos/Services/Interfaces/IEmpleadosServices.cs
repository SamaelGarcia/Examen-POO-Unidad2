using ExamenDos.Dtos.Empleado;

namespace ExamenDos.Services.Interfaces
{
    public interface IEmpleadosServices
    {
        Task<List<EmpleadoOutputDto>> GetEmpleadosAsync();
        //Task<EmpleadoOutputDto> GetEmpleadoByIdAsync(int id);
        //Task CreateEmpleadoAsync(EmpleadoInputDto empleadoInputDto);
        //Task UpdateEmpleadoAsync(int id, EmpleadoEditDto empleadoEditDto);
        //Task DeleteEmpleadoAsync(int id);
        //Task<List<EmpleadoOutputDto>> GetEmpleadosActivosAsync();
    }
}