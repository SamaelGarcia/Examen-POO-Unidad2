using AutoMapper;
using ExamenDos.Database;
using ExamenDos.Database.Entities;
using ExamenDos.Dtos.Planillas;
using ExamenDos.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Net;

namespace ExamenDos.Services
{
    public class PlanillaServices : IPlanillaServices
    {
        private readonly PlanillasDbContext _context;
        private readonly IMapper _mapper;

        public PlanillaServices(PlanillasDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<List<PlanillaOutputDto>> GetPlanillasAsync()
        {
            var planillas = await _context.Planillas.ToListAsync();
            return _mapper.Map<List<PlanillaOutputDto>>(planillas);
        }

        public async Task<PlanillaOutputDto> GetPlanillaByIdAsync(int id)
        {
            var planillas = await _context.Planillas.FindAsync(id);
            if (planillas == null)
            {
                throw new Exception("Planilla no encontrada");
            }

            return _mapper.Map<PlanillaOutputDto>(planillas);
        }

        public async Task CreatePlanillaAsync(PlanillaInputDto planillaInputDto)
        {
            var existePlanilla = await _context.Planillas.AnyAsync(p => p.Periodo == planillaInputDto.Periodo);
            if (existePlanilla)
            {
                throw new Exception("Ya existe una planilla para este período.");
            }

            var planilla = _mapper.Map<PlanillaEntity>(planillaInputDto);
            _context.Planillas.Add(planilla);
            await _context.SaveChangesAsync();

        //    var planilla = new PlanillaEntity
        //    {
        //        Id = planillaInputDto.Id,
        //        Periodo = planillaInputDto.Periodo,
        //        FechaCreacion = planillaInputDto.FechaCreacion,
        //        FechaPago = planillaInputDto.FechaPago,
        //        Estado = planillaInputDto.Estado,
        //    };

        //    await _context.AddAsync(planilla);

        //    return new PlanillaOutputDto
        //    {
        //        Id = planilla.Id,
        //        Periodo = planilla.Periodo,
        //        FechaCreacion = planilla.FechaCreacion,
        //        FechaPago = planilla.FechaPago,
        //        Estado = planilla.Estado,
        //    };
        //}
        }
    }
    }
