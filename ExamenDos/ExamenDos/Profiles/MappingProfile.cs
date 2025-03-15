using AutoMapper;
using ExamenDos.Database.Entities;
using ExamenDos.Dtos.DetallesPlanilla;
using ExamenDos.Dtos.Empleado;
using ExamenDos.Dtos.Planillas;

namespace ExamenDos.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<EmpleadoEntity, EmpleadoOutputDto>();
            CreateMap<EmpleadoInputDto, EmpleadoEntity>();
            CreateMap<EmpleadoEditDto,  EmpleadoEntity>();

            CreateMap<PlanillaEntity, PlanillaOutputDto>();
            CreateMap<PlanillaInputDto, PlanillaEntity>();
            CreateMap<PlanillaEditDto, PlanillaEntity>();

            CreateMap<DetallePlanillaEntity, DetallePlanillaOutputDto>();
            CreateMap<DetallePlanillaInputDto, DetallePlanillaEntity>();
            CreateMap<DetallePlanillaEditDto, DetallePlanillaEntity>();
        }
    }
}
