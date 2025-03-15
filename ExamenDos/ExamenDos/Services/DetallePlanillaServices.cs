using AutoMapper;
using ExamenDos.Database;
using ExamenDos.Database.Entities;
using ExamenDos.Dtos.DetallesPlanilla;
using ExamenDos.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ExamenDos.Services
{
    public class DetallePlanillaServices : IDetallePlanillaServices
    {
        private readonly PlanillasDbContext _context;
        private readonly IMapper _mapper;

        public DetallePlanillaServices(PlanillasDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<List<DetallePlanillaOutputDto>> GetDetallesByPlanillaIdAsync(int planillaId)
        {
            var detalles = await _context.DetallePlanillas
                .Where(d => d.PlanillaId == planillaId)
                .ToListAsync();
            return _mapper.Map<List<DetallePlanillaOutputDto>>(detalles);
        }

        public async Task<DetallePlanillaOutputDto> GetDetalleByIdAsync(int id)
        {
            var detalle = await _context.DetallePlanillas.FindAsync(id);
            if (detalle == null)
            {
                throw new Exception("Detalle no encontrado.");
            }
            return _mapper.Map<DetallePlanillaOutputDto>(detalle);
        }

        public async Task CreateDetalleAsync(DetallePlanillaInputDto detalleInputDto)
        {
            detalleInputDto.SalarioNeto = detalleInputDto.SalarioBase +
                                          detalleInputDto.MontoHorasExtra +
                                          detalleInputDto.Bonificaciones -
                                          detalleInputDto.Deducciones;

            var detalle = _mapper.Map<DetallePlanillaEntity>(detalleInputDto);
            _context.DetallePlanillas.Add(detalle);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateDetalleAsync(int id, DetallePlanillaEditDto detalleEditDto)
        {
            var detalle = await _context.DetallePlanillas.FindAsync(id);
            if (detalle == null)
            {
                throw new Exception("Detalle no encontrado.");
            }

            _mapper.Map(detalleEditDto, detalle);

            detalle.SalarioNeto = detalle.SalarioBase +
                                  detalle.MontoHorasExtra +
                                  detalle.Bonificaciones -
                                  detalle.Deducciones;

            await _context.SaveChangesAsync();
        }

        public async Task DeleteDetalleAsync(int id)
        {
            var detalle = await _context.DetallePlanillas.FindAsync(id);
            if (detalle == null)
            {
                throw new Exception("Detalle no encontrado.");
            }

            _context.DetallePlanillas.Remove(detalle);
            await _context.SaveChangesAsync();
        }

        public async Task<List<DetallePlanillaOutputDto>> GetDetallesByEmpleadoIdAsync(int empleadoId)
        {
            var detalles = await _context.DetallePlanillas
                .Where(d => d.EmpleadoId == empleadoId)
                .ToListAsync();
            return _mapper.Map<List<DetallePlanillaOutputDto>>(detalles);
        }
    }
}