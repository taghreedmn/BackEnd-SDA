using AutoMapper;
using FusionTech.src.Entity;
using static FusionTech.src.DTO.CategoryDTO;
using static FusionTech.src.DTO.PaymentDTO;

namespace FusionTech.src.Utils
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            //Category 
            CreateMap<Category, CategoryReadDto>();
            CreateMap<CategoryCreateDto, Category>();
            CreateMap<CategoryUpdateDto, Category>().
            ForAllMembers(Opts => Opts.Condition((src, dest, srcProperty) => srcProperty != null));

            //Payment 
            CreateMap<Payment, PaymentReadDto>();
            CreateMap<PaymentCreateDto, Payment>();
            CreateMap<PaymentUpdateDto, Payment>().
            ForAllMembers(Opts => Opts.Condition((src, dest, srcProperty) => srcProperty != null));

        }

    }
}