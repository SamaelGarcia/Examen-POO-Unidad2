using AutoMapper;
using ExamenDos.Database;
using ExamenDos.Database.Entities;
using ExamenDos.Dtos.Planillas;
using ExamenDos.Services.Interfaces;
using System.Net;

namespace ExamenDos.Services
{
    public class PlanillaServices : IPlanillaServices
    {
        private readonly PlanillasDbContext _context;

        public PlanillaServices(PlanillasDbContext context)
        {
            _context = context;
        }

        public async Task<PlanillaOutputDto> CreatePlanillaAsync(PlanillaInputDto planillaInputDto)
        {
            var planilla = new PlanillaEntity
            {
                Id = planillaInputDto.Id,
                Periodo = planillaInputDto.Periodo,
                FechaCreacion = planillaInputDto.FechaCreacion,
                FechaPago = planillaInputDto.FechaPago,
                Estado = planillaInputDto.Estado,
            };

            await _context.AddAsync(planilla);

            return new PlanillaOutputDto
            {
                Id = planilla.Id,
                Periodo = planilla.Periodo,
                FechaCreacion = planilla.FechaCreacion,
                FechaPago = planilla.FechaPago,
                Estado = planilla.Estado,
            };
        }
    }
}
