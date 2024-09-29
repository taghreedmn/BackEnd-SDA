using AutoMapper;
using FusionTech.src.Entity;
using static FusionTech.src.DTO.CategoryDTO;
using static FusionTech.src.DTO.PaymentDTO;
using static sda_3_online_Backend_Teamwork.src.DTO.ConsoleDTO;
using static sda_3_online_Backend_Teamwork.src.DTO.StudioDTO;

namespace FusionTech.src.Utils
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            //Category
            CreateMap<Category, CategoryReadDto>();
            CreateMap<CategoryCreateDto, Category>();
            CreateMap<CategoryUpdateDto, Category>()
                .ForAllMembers(Opts =>
                    Opts.Condition((src, dest, srcProperty) => srcProperty != null)
                );

            //Payment
            CreateMap<Payment, PaymentReadDto>();
            CreateMap<PaymentCreateDto, Payment>();
            CreateMap<PaymentUpdateDto, Payment>()
                .ForAllMembers(Opts =>
                    Opts.Condition((src, dest, srcProperty) => srcProperty != null)
                );
            //Console
            CreateMap<GameConsole, ReadConsoleDTO>();
            CreateMap<UpdateConsoleDTO, GameConsole>();
            CreateMap<CreatConsoleDTO, GameConsole>()
                .ForAllMembers(opts =>
                    opts.Condition((src, dest, srcProperty) => srcProperty != null)
                );
            //studio
            CreateMap<GameStudio, ReadStudioDTO>();
            CreateMap<UpdateStudioDTO, GameStudio>();
            CreateMap<CreatStudioDTO, GameStudio>()
                .ForAllMembers(opts =>
                    opts.Condition((src, dest, srcProperty) => srcProperty != null)
                );
        }
    }
}
