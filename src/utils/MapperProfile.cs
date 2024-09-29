using AutoMapper;
using FusionTech.src.Entity;
using static FusionTech.src.DTO.SupplyDTO;

namespace FusionTech.src.utils
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {   //Supply
            CreateMap<Supply, SupplyReadDto>();
            CreateMap<SupplyCreateDto, Supply>();
            CreateMap<SupplyUpdateDto, Supply>().
            ForAllMembers(opts => opts.Condition((src, dest, strProperty)=> strProperty != null));


        }
    }
}