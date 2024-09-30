
using AutoMapper;
using FusionTech.src.Entity;
using static FusionTech.src.DTO.CategoryDTO;
using static FusionTech.src.DTO.ConsoleDTO;
using static FusionTech.src.DTO.CustomerDTO;
using static FusionTech.src.DTO.PaymentDTO;
using static FusionTech.src.DTO.PersonDTO;
using static FusionTech.src.DTO.StoreEmployeeDTO;
using static FusionTech.src.DTO.StudioDTO;
using static FusionTech.src.DTO.SystemAdminDTO;

namespace FusionTech.src.Utils

{
    public class MapperProfile : Profile
    {
        public MapperProfile()


        {   //Supply
            CreateMap<Supply, SupplyReadDto>();
            CreateMap<SupplyCreateDto, Supply>();
            CreateMap<SupplyUpdateDto, Supply>().
            ForAllMembers(opts => opts.Condition((src, dest, strProperty)=> strProperty != null));



{
            // Person mappings
            CreateMap<PersonCreateDto, Person>();
            CreateMap<Person, PersonReadDto>();
            // CreateMap<PersonUpdateDto, Person>();

            // Customer mappings
            CreateMap<CustomerCreateDto, Customer>();
            CreateMap<Customer, CustomerReadDto>();
            // CreateMap<CustomerUpdateDto, Customer>();

            // StoreEmployee mappings
            CreateMap<StoreEmployeeCreateDto, StoreEmployee>();
            CreateMap<StoreEmployee, StoreEmployeeReadDto>();
            // CreateMap<StoreEmployeeUpdateDto, StoreEmployee>();

            // SystemAdmin mappings
            CreateMap<SystemAdminCreateDto, SystemAdmin>();
            CreateMap<SystemAdmin, SystemAdminReadDto>();
            // CreateMap<SystemAdminUpdateDto, SystemAdmin>();

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
            CreateMap<CreateConsoleDTO, GameConsole>()
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

