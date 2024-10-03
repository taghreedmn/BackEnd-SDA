using AutoMapper;
using FusionTech.src.DTO;
using FusionTech.src.Entity;
using static FusionTech.src.DTO.CategoryDTO;
using static FusionTech.src.DTO.ConsoleDTO;
using static FusionTech.src.DTO.CustomerDTO;
using static FusionTech.src.DTO.InventoryDTO;
using static FusionTech.src.DTO.PaymentDTO;
using static FusionTech.src.DTO.PersonDTO;
using static FusionTech.src.DTO.PublisherDTO;
using static FusionTech.src.DTO.StoreDTO;
using static FusionTech.src.DTO.StoreEmployeeDTO;
using static FusionTech.src.DTO.StudioDTO;
using static FusionTech.src.DTO.SupplierDTO;
using static FusionTech.src.DTO.SupplyDTO;
using static FusionTech.src.DTO.SupplyReadDto;
using static FusionTech.src.DTO.SystemAdminDTO;
using static FusionTech.src.DTO.VideoGameInfoDTO;

namespace FusionTech.src.Utils
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            //Supply
            CreateMap<Supply, SupplyReadDto>();
            CreateMap<SupplyCreateDto, Supply>();
            CreateMap<SupplyUpdateDto, Supply>()
                .ForAllMembers(opts =>
                    opts.Condition((src, dest, strProperty) => strProperty != null)
                );
            // Supplier mappings
            CreateMap<Supplier, SupplierReadDto>();
            CreateMap<SupplierCreateDto, Supplier>();
            CreateMap<SupplierUpdateDto, Supplier>();

            // StoreEmployee mappings
            CreateMap<StoreEmployeeSignUpDTO, StoreEmployee>();
            CreateMap<StoreEmployee, StoreEmployeeSignInDto>();

            // SystemAdmin mappings
            CreateMap<SystemAdminSignUpDTO, SystemAdmin>();
            CreateMap<SystemAdmin, SystemAdminReadDto>();

            // Category mappings
            CreateMap<Category, CategoryReadDto>();
            CreateMap<CategoryCreateDto, Category>();
            CreateMap<CategoryUpdateDto, Category>()
                .ForAllMembers(opts =>
                    opts.Condition((src, dest, srcProperty) => srcProperty != null)
                );

            // Payment mappings
            CreateMap<Payment, PaymentReadDto>();
            CreateMap<PaymentCreateDto, Payment>();
            CreateMap<PaymentUpdateDto, Payment>()
                .ForAllMembers(opts =>
                    opts.Condition((src, dest, srcProperty) => srcProperty != null)
                );

            // Studio mappings
            CreateMap<GameStudio, ReadStudioDTO>();
            CreateMap<UpdateStudioDTO, GameStudio>();
            CreateMap<CreatStudioDTO, GameStudio>()
                .ForAllMembers(opts =>
                    opts.Condition((src, dest, srcProperty) => srcProperty != null)
                );

            //inventory
            CreateMap<Inventory, InventoryReadDto>();
            CreateMap<InventoryModifyGameQuantityDTO, Inventory>();
            CreateMap<InventoryCreateDto, Inventory>()
                .ForAllMembers(opts =>
                    opts.Condition((src, dest, srcProperty) => srcProperty != null)
                );

            // Person mappings
            CreateMap<PersonSignInDTO, Person>();
            CreateMap<Person, PersonReadDto>();

            // Customer mappings
            CreateMap<CustomerSignUpDTO, Customer>();
            CreateMap<Customer, CustomerReadDto>();

            // Console mappings
            CreateMap<GameConsole, ReadConsoleDTO>();
            CreateMap<UpdateConsoleDTO, GameConsole>();
            CreateMap<CreateConsoleDTO, GameConsole>()
                .ForAllMembers(opts =>
                    opts.Condition((src, dest, srcProperty) => srcProperty != null)
                );

            // Publisher mappings
            CreateMap<Publisher, PublisherReadDto>();
            CreateMap<PublisherUpdateDto, Publisher>();
            CreateMap<PublisherCreateDto, Publisher>()
                .ForAllMembers(opts =>
                    opts.Condition((src, dest, srcProperty) => srcProperty != null)
                );

            // Store mappings
            CreateMap<Store, StoreReadDto>();
            CreateMap<StoreCreateDto, Store>();
            CreateMap<StoreUpdateDto, Store>()
                .ForAllMembers(opts =>
                    opts.Condition((src, dest, srcProperty) => srcProperty != null)
                );

            // VideoGameInfo mappings
            CreateMap<VideoGameInfo, VideoGameInfoReadDto>();
            CreateMap<VideoGameInfoCreateDto, VideoGameInfo>();
            CreateMap<VideoGameInfoUpdateDto, VideoGameInfo>()
                .ForAllMembers(opts =>
                    opts.Condition((src, dest, srcProperty) => srcProperty != null)
                );
        }
    }
}


