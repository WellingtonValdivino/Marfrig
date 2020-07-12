using System.Linq;
using AutoMapper;
using Marfrig.Domain;
using Marfrig.WebAPI.Dtos;

namespace Marfrig.WebAPI.Helpers
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<CompraGadoItem, CompraGadoItemDto>().ReverseMap();
            CreateMap<CompraGado, CompraGadoDto>().ReverseMap();
            CreateMap<Pecuarista, PecuaristaDto>().ReverseMap();
            CreateMap<Animal, AnimalDto>().ReverseMap();
        }
    }
}