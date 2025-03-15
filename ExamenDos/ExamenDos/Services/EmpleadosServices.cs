using AutoMapper;
using ExamenDos.Database;
using ExamenDos.Dtos.Empleado;
using ExamenDos.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ExamenDos.Services
{
    public class EmpleadosServices : IEmpleadosServices
    {
        private readonly PlanillasDbContext _context;
        private readonly IMapper _mapper;

        public EmpleadosServices(PlanillasDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<List<EmpleadoOutputDto>> GetEmpleadosAsync()
        {
            var empleados = await _context.Empleados.ToListAsync();
            return _mapper.Map<List<EmpleadoOutputDto>>(empleados);
        }


    }
}
